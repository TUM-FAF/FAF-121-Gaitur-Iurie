package com.todolist.activity;



import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

import ch.lambdaj.collection.*;

import com.todolist.entity.Category;
import com.todolist.entity.Task;
import com.todolist.service.TaskLayer;

import android.app.Activity;
import android.content.Intent;
import android.inputmethodservice.ExtractEditText;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.RatingBar;
import android.widget.SeekBar;
import android.widget.Spinner;
import android.widget.SpinnerAdapter;
import android.widget.TextView;

public class EditTaskActivity extends Activity {

	TaskLayer layer;
	Task currentTask;

	public Button saveButton;
	public EditText name;
	public Spinner category;

	public TextView importance;
	public SeekBar progress;
	public RatingBar rating;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.edit_task_frag);

		name = (EditText) findViewById(R.id.edit_task_name);
		category = (Spinner) findViewById(R.id.spinner_txt);		

		progress = (SeekBar) findViewById(R.id.seekBar1);
		rating = (RatingBar) findViewById(R.id.rating_task);
		saveButton = (Button) findViewById(R.id.save_btn);

		Intent intent = getIntent();
		long idTask = intent.getLongExtra("idTask",0);
		
		
		
		layer = new TaskLayer(getApplication());

		currentTask = layer.GetTask(idTask);
		
		
		ArrayAdapter<String> spinnerAdapter = 
				new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item,getCategories());
		category.setAdapter(spinnerAdapter);
		category.setSelection(safeLongToInt(currentTask.category.getId()-1));;
		name.setText(currentTask.name);
		progress.setProgress(currentTask.progress);
		rating.setRating(currentTask.importance);
		
		
		

	}

	private List<String> getCategories() {
		
		List<Category> myCategories = layer.GetListCategories();
		List<String> category = new ArrayList<String>();
		for(Category cat:myCategories) {
			category.add(cat.name);
		}
		
		
		return category;
	}

	public void OnClick(View view) {

		switch (view.getId()) {
		case R.id.save_btn:
			
			
			Category taskCat =layer.GetCategoryByName(category.getSelectedItem().toString());
			
			currentTask.category = taskCat;
			currentTask.importance = (int)rating.getRating();
			currentTask.name = name.getText().toString();
			currentTask.progress = progress.getProgress();
					
			layer.EditTask(currentTask);
			finish();
			break;

		default:
			break;
		}

	}
	
	public static int safeLongToInt(long l) {
	    if (l < Integer.MIN_VALUE || l > Integer.MAX_VALUE) {
	        throw new IllegalArgumentException
	            (l + " cannot be cast to int without changing its value.");
	    }
	    return (int) l;
	}

}
