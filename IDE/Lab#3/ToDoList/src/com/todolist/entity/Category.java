package com.todolist.entity;

import java.util.List;

import android.content.Context;

import com.orm.SugarRecord;

public class Category extends SugarRecord<Category>{
	
	
	public String name;
	public Task task;
	
	
	public Category(Context arg0) {
		super(arg0);
		name = "Default";
	}


	public Category(Context arg0, String name) {
		super(arg0);
		this.name = name;
	}
	

	
	
	
	
	
	


	
	
	

}
