package com.todolist.tests;

import org.junit.Test;

import com.todolist.service.TaskLayer;



public class TasksTest {

	TaskLayer layerDb;
	
	
	@Test
	void TaskGetUndefinedIdTest() {
		layerDb = new TaskLayer();
		
	}
	
	@Test
	void DatabaseIsWorkingTest() {
		layerDb = new TaskLayer();
	}
	@Test
	void DefaultCategoryExistsTest() {
		layerDb = new TaskLayer();
	}
	
}
