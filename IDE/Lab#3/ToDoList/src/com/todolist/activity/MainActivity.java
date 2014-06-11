package com.todolist.activity;

import java.util.List;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.text.InputType;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView.OnItemLongClickListener;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import com.todolist.adapters.TasksAdapter;
import com.todolist.entity.Category;
import com.todolist.entity.Task;
import com.todolist.service.TaskLayer;

public class MainActivity extends Activity{

	ListView taskList;

	TaskLayer tasksService;
	TasksAdapter taskAdapter;

	EditText txt_name_task;
	
	SharedPreferences settings;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		
		
		
		taskList = (ListView) findViewById(R.id.list_tasks);
		txt_name_task = (EditText) findViewById(R.id.txt_name_task);

		tasksService = new TaskLayer(getApplication());
		// Set adapter for tasks
		

		if(isFirstLaunch()) {
			Category defaultCategory = new Category(getApplication());
			defaultCategory.name = "Default";
			tasksService.AddCategory(defaultCategory);
			SharedPreferences.Editor editor = settings.edit();
			editor.putBoolean("isFirstLaunch", false);
			editor.commit();
			
			
		}
		
		
		List<Task> tasks = tasksService.GetListTasks();

		if (tasks.size() > 0) {
			taskAdapter = new TasksAdapter(this, R.layout.item_list_task, tasks);
			taskList.setAdapter(taskAdapter);
			
		}
		
		taskList.setOnItemClickListener(new OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> parent, View view, int position,
					long id) {

				Intent intentAdd = new Intent(MainActivity.this, EditTaskActivity.class);
				long itemId = taskAdapter.getItem(position).getId();
				
				intentAdd.putExtra("idTask", itemId);
				startActivity(intentAdd);

			
			}
		});
	}

	
	
	private boolean isFirstLaunch() {
		settings = getSharedPreferences("FIRST_START", 0);
		boolean isFirstLaunch = settings.getBoolean("isFirstLaunch", true);
		
		return isFirstLaunch;
	}



	public void OnClick(View v) {

		switch (v.getId()) {
		case R.id.refresh_btn:
			RefreshContent();
			break;

		case R.id.add_task_btn:
			String task_name = txt_name_task.getText().toString();
			if (task_name.equals("") || task_name == null)
				break;

			Task add_task = AddSimpleTask(task_name);
			if (add_task == null)
				break;

			tasksService.AddTask(add_task);

			RefreshContent();

			break;

		}

	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// TODO Auto-generated method stub
		Intent intent;
		switch (item.getItemId()) {
		case R.id.MustRead:
			intent = new Intent(this,ReadBook.class);
			Toast.makeText(MainActivity.this, "You have to read the following books", Toast.LENGTH_SHORT).show();
			startActivity(intent);
            return true;
		case R.id.AddCategory:
			AlertDialog.Builder builder = new AlertDialog.Builder(this);
			builder.setTitle("Add category");

			// Set up the input
			final EditText input = new EditText(this);
			// Specify the type of input expected; this, for example, sets the input as a password, and will mask the text
			input.setInputType(InputType.TYPE_CLASS_TEXT);
			builder.setView(input);

			// Set up the buttons
			builder.setPositiveButton("OK", new DialogInterface.OnClickListener() { 
			    @Override
			    public void onClick(DialogInterface dialog, int which) {
			        String category = input.getText().toString();
			        tasksService.AddCategory(new Category(getApplication(),category));
			        dialog.dismiss();
			        Toast.makeText(MainActivity.this, "You added a new category", Toast.LENGTH_SHORT).show();
			    }
			});
			builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
			    @Override
			    public void onClick(DialogInterface dialog, int which) {
			        dialog.cancel();
			    }
			});

			builder.show();
            return true;

		default:
			return false;
		}
		
	}
	
	

	private Task AddSimpleTask(String name) {

		Task task = new Task(getApplication(), name);
		return task;
	}

	public void RefreshContent() {

		List<Task> newItems = tasksService.GetListTasks();
		
		if (taskAdapter != null) {
			taskAdapter.clear();
			txt_name_task.setText("");
			taskAdapter.addAll(newItems);
			taskAdapter.notifyDataSetChanged();
		}
		

		return;

	}


	@Override
	protected void onResume() {
		// TODO Auto-generated method stub
		super.onResume();
		RefreshContent();
	}
	

}
