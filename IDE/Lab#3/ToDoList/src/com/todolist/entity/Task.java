package com.todolist.entity;

import java.util.Calendar;
import java.util.Date;
import java.util.UUID;

import android.content.Context;

import com.orm.SugarRecord;

public class Task extends SugarRecord<Task>{
	
	
	public String name;
	
	public int importance;
	public int progress;
	
	public Category category;
	
	public Task(Context arg0) {
		super(arg0);
		
	}
	
	public Task(Context arg0,String name) {
		super(arg0);
		
		this.name = name;
		this.progress = 0;
		this.category = Category.findById(Category.class, (long)1);
		this.importance = 3;		
	
	}
	
	public Task(Context arg0, String name, Category category,
			Date startDate, Date due_date, int importance, int progress,
			boolean active) {
		super(arg0);
		
		this.name = name;
		this.category = category;
		this.importance = importance;
		this.progress = progress;

	}


	public Task(Context arg0, String id, String name, Category category,
			Date startDate, Date due_date, int importance, int progress,
			boolean active) {
		super(arg0);
		
		this.name = name;
		this.category = category;

		this.importance = importance;
		this.progress = progress;

	}
	
	
	
	

}
