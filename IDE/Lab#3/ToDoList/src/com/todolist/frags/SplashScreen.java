package com.todolist.frags;

import java.util.Date;

import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;

import com.todolist.activity.R;
import com.todolist.entity.Category;
import com.todolist.entity.Task;

public class SplashScreen extends Fragment{

	@Override
	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		View view = inflater.inflate(R.layout.splash_frag,container,false);
		ImageView image = (ImageView)view.findViewById(R.id.splash_image);
		
		
		AddNewData();
		return super.onCreateView(inflater, container, savedInstanceState);
	}
	
	void AddNewData()
	{
		Category category = new Category(getActivity());
		Date date = new Date();
		
		Task task = new Task(getActivity(),"Fa de lucru",category,date,date,1,20,true);
		
	}
	
	
}
