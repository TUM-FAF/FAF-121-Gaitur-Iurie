package com.todolist.adapters;

import java.util.List;

import com.androidquery.AQuery;
import com.todolist.activity.R;
import com.todolist.adapters.TasksAdapter.ViewHolder;
import com.todolist.entity.Book;
import com.todolist.entity.Task;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.BaseAdapter;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.TextView;

public class BooksAdapter extends ArrayAdapter<Book>{
	AQuery aq;
	Context context;
	List<Book> books;
	
	ImageView image;
	TextView title,desc;
	
	
	public BooksAdapter(Context context, int textViewResourceId,
			List<Book> objects) {
		super(context, textViewResourceId, objects);
		
		
		this.context = context;
		this.books = objects;
		
	}
	
	@Override
	public Book getItem(int position) {
		// TODO Auto-generated method stub
		return books.get(position);
	}
	
	
	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return books.size();
	}
	
	static class ViewHolder {
		public ImageView img;
		public TextView name;
		public TextView description;

    }
	
	
	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		 ViewHolder holder;
	        View rowView = convertView;
	        if (rowView == null) {
	            LayoutInflater inflater = LayoutInflater.from(context);
	            rowView = inflater.inflate(R.layout.item_list_book, null, true);
	            holder = new ViewHolder();
	            
	            
	            //holder.active = (CheckBox)rowView.findViewById(R.id.chb_active);
	            holder.name = (TextView) rowView.findViewById(R.id.title);
	            holder.description = (TextView) rowView.findViewById(R.id.description);
	            holder.img = (ImageView) rowView.findViewById(R.id.img_book); 
	            
	            rowView.setTag(holder);
	        } else {
	            holder = (ViewHolder) rowView.getTag();
	        }
	        
	        aq = new AQuery(rowView);
	        
	        holder.name.setText(books.get(position).title);
	        holder.description.setText(books.get(position).description);
	        String img = books.get(position).image;
	        aq.id(R.id.img_book).image(books.get(position).image,true, true, 0,
					AQuery.GONE);

	        return rowView;
	}
	

	
	

}
