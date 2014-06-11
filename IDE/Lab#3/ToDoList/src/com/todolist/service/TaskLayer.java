package com.todolist.service;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.UUID;

import android.content.Context;

import com.todolist.entity.Category;
import com.todolist.entity.Task;

public class TaskLayer {
	
	Context context;
	
	public TaskLayer(Context context) {
		
		this.context = context;
	}
	
	public List<Task> GetListTasks() {
		
		List<Task> tasks = Task.listAll(Task.class);
		Collections.reverse(tasks);
		for(Task task:tasks) {
			//task.category = GetTasksCategory(task.getId());
		}
		
		return tasks;
		
	}
	
	public List<Category> GetListCategories() {
		
		List<Category> cats = Category.listAll(Category.class);
		
		return cats;
		
	}
	
	public Task GetTask(long id) {
		
		Task task = Task.findById(Task.class, id);
		
		//task.category = GetTasksCategory(task.getId());
		
		return task;
	}
	
	public Category GetCategory(int id) {
		
		return Category.findById(Category.class, (long)id);
		
	}
	
	public Category GetCategoryByName(String name) {
		List<Category> category = Category.find(Category.class, "name = ?", name);
		if(category.size() > 0)
			return category.get(0);
		return null;
	}
	
	public Category GetTasksCategory(long id) {
		
		List<Category> categories = Category.find(Category.class, "task = ?", Long.toString(id));
		if(categories.size() > 0)
			return categories.get(0);
		return Category.findById(Category.class, (long)1);
	}
	
	
	
	public void AddTask(Task task) {
		
		task.save();
	}
	
	public void EditTask(Task task) {
		Task updateTask = Task.findById(Task.class, task.getId());
		updateTask.name = task.name;
		updateTask.category.setId(task.category.getId());
		updateTask.importance = task.importance;
		updateTask.progress = task.importance;
		updateTask.save();
		
		
	}
	
	public void DeleteTask(Task task) {
		Task updateTask = Task.findById(Task.class, task.getId());
		updateTask.delete();
		
	}
	
	
	public void AddCategory(Category cat) {
		
		cat.save();
	}
	
	public void EditCategory(Category cat) {
		Category updateCat = Category.findById(Category.class, cat.getId());
		updateCat.save();
	}
	
	
	public void DeleteCategory(Category cat) {
		Category updateCat = Category.findById(Category.class, cat.getId());
		updateCat.delete();
	}
	
	
	
	
	
}
