package com.todolist.adapters;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteDatabase.CursorFactory;
import android.database.sqlite.SQLiteOpenHelper;

public class TaskerDBHelper extends SQLiteOpenHelper{

	private static final int DATABASE_VERSION = 1;
	private static final String DATABASE_NAME = "ToDolist";
	
	
	private static final String TABLE_TASKS = "tasks";
	private static final String TASK_KEY_ID = "id";
	private static final String TASK_KEY_NAME = "name";
	//private static final String TASK_KEY_CATEGORY_ID = "category_id";
	private static final String TASK_KEY_START_DATE = "start_date";
	private static final String TASK_KEY_DUE_DATE = "due_date";
	private static final String TASK_KEY_IMPORTANCE = "importance";
	private static final String TASK_KEY_PROGRESS = "progress";
	private static final String TASK_KEY_ACTIVE = "active";
	
	
	
	
	
	private static final String TABLE_CATEGORY = "category";
	private static final String CATEGORY_KEY_ID = "id";
	private static final String CATEGORY_KEY_NAME = "name";
	
	private static final String TABLE_TODO_TAG = "tasks_category";
	private static final String TODO_TAG_KEY_ID = "id";
	private static final String TODO_TAG_KEY_CATEGORY = "category_id";
	private static final String TODO_TAG_KEY_TASK = "task_id";
	
	
	
	
	private static final String CREATE_TABLE_TASK = "CREATE TABLE "
            + TABLE_TASKS + "(" + TASK_KEY_ID + " INTEGER PRIMARY KEY," + TASK_KEY_NAME
            + " TEXT,"  + TASK_KEY_START_DATE
            + " DATETIME," + TASK_KEY_DUE_DATE
            + " DATETIME," + TASK_KEY_IMPORTANCE + " INTEGER," 
            + TASK_KEY_PROGRESS + " INTEGER," 
            + TASK_KEY_ACTIVE + " INTEGER" + ")";
 
    // Tag table create statement
    private static final String CREATE_TABLE_CATEGORY = "CREATE TABLE " + TABLE_CATEGORY
            + "(" + CATEGORY_KEY_ID + " INTEGER PRIMARY KEY," + CATEGORY_KEY_NAME + " TEXT" +  ")";
 
    // todo_tag table create statement
    private static final String CREATE_TABLE_TASK_CATEGORY = "CREATE TABLE "
            + TABLE_TODO_TAG + "(" + TODO_TAG_KEY_ID + " INTEGER PRIMARY KEY,"
            + TODO_TAG_KEY_CATEGORY + " INTEGER," + TODO_TAG_KEY_TASK + " INTEGER " + ")";
	
	
	
	public TaskerDBHelper(Context context, String name, CursorFactory factory,
			int version) {
		super(context, name, factory, version);
		// TODO Auto-generated constructor stub
	}

	@Override
	public void onCreate(SQLiteDatabase db) {
		
		
		
		db.execSQL(CREATE_TABLE_TASK);
		db.execSQL(CREATE_TABLE_CATEGORY);
		db.execSQL(CREATE_TABLE_TASK_CATEGORY);
		
	}

	@Override
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
		// TODO Auto-generated method stub
		db.execSQL("DROP TABLE IF EXISTS " + CREATE_TABLE_TASK);
		db.execSQL("DROP TABLE IF EXISTS " + CREATE_TABLE_CATEGORY);
		db.execSQL("DROP TABLE IF EXISTS " + CREATE_TABLE_TASK_CATEGORY);
		
		onCreate(db);
		
	}

}
