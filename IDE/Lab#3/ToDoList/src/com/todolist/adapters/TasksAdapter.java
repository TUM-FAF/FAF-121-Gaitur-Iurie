package com.todolist.adapters;

import java.util.Date;
import java.util.List;

import android.content.Context;
import android.graphics.Color;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.view.animation.ScaleAnimation;
import android.view.animation.Transformation;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.LinearLayout.LayoutParams;
import android.widget.ListView;
import android.widget.ProgressBar;
import android.widget.TextView;

import com.todolist.activity.MainActivity;
import com.todolist.activity.R;
import com.todolist.entity.Category;
import com.todolist.entity.Task;
import com.todolist.service.TaskLayer;

public class TasksAdapter extends ArrayAdapter<Task>{

	
	Context context;
	List<Task> tasks;
	TaskLayer layerDb;
	
	
	public TasksAdapter(Context context, int textViewResourceId,
			List<Task> objects) {
		super(context, textViewResourceId, objects);
		
		this.context = context;
		this.tasks = objects;
		layerDb = new TaskLayer(context);
		
	}
	
	@Override
	public Task getItem(int position) {
		// TODO Auto-generated method stub
		return tasks.get(position);
	}
	
	
	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return tasks.size();
	}
	
	static class ViewHolder {
		
		public TextView name;
		public TextView category;
		public ImageView delete;
		public TextView importance;
		public ProgressBar progress;
    }
	
	
	@Override
	public View getView(final int position, View convertView, final ViewGroup parent) {
		    ViewHolder holder;
		 
	        View rowView = convertView;
	        if (rowView == null) {
	            LayoutInflater inflater = LayoutInflater.from(context);
	            rowView = inflater.inflate(R.layout.item_list_task, null, true);
	            
	            
	            holder = new ViewHolder();

	            holder.name = (TextView) rowView.findViewById(R.id.txt_name);
	            holder.category = (TextView) rowView.findViewById(R.id.txt_category);
	            holder.progress = (ProgressBar) rowView.findViewById(R.id.pgb_progress);
	            
	            holder.delete = (ImageView)rowView.findViewById(R.id.img_delete);
	            holder.delete.setOnClickListener(new View.OnClickListener() {
					
					
					public void onClick(View v) {
						//convertView.startAnimation(new MyScaler(1.0f, 1.0f, 1.0f, 0.0f, 500, convertView, true));
						Task task =	getItem(position);
						layerDb.DeleteTask(task);
						remove(getItem(position));
						notifyDataSetChanged();
						
						
						
					}
				});
	            
	            rowView.setTag(holder);
	        } else {
	            holder = (ViewHolder) rowView.getTag();
	        }
	        
	        holder.name.setText(tasks.get(position).name);
	        
	        if(!(tasks.get(position).category == null)) {
	        	holder.category.setText(tasks.get(position).category.name);
	        }
	        
	        
	        
	        LinearLayout mainLayout = (LinearLayout)rowView.findViewById(R.id.item_task);
	        holder.progress.setProgress(tasks.get(position).progress);
	        
	        if (tasks.get(position).importance < 2) {
	        	mainLayout.setBackgroundColor(context.getResources().getColor(R.color.red));
	        } else if(tasks.get(position).importance < 3){
	        	mainLayout.setBackgroundColor(context.getResources().getColor(R.color.orange));
	        }
	        else {
	        	mainLayout.setBackgroundColor(Color.TRANSPARENT);
	        }
	        	

	        return rowView;
	}
	
	public class MyScaler extends ScaleAnimation {

        private View mView;

        private LayoutParams mLayoutParams;

        private int mMarginBottomFromY, mMarginBottomToY;

        private boolean mVanishAfter = false;

        public MyScaler(float fromX, float toX, float fromY, float toY, int duration, View view,
                boolean vanishAfter) {
            super(fromX, toX, fromY, toY);
            setDuration(duration);
            mView = view;
            mVanishAfter = vanishAfter;
            mLayoutParams = (LayoutParams) view.getLayoutParams();
            int height = mView.getHeight();
            mMarginBottomFromY = (int) (height * fromY) + mLayoutParams.bottomMargin - height;
            mMarginBottomToY = (int) (0 - ((height * toY) + mLayoutParams.bottomMargin)) - height;
        }

        @Override
        protected void applyTransformation(float interpolatedTime, Transformation t) {
            super.applyTransformation(interpolatedTime, t);
            if (interpolatedTime < 1.0f) {
                int newMarginBottom = mMarginBottomFromY
                        + (int) ((mMarginBottomToY - mMarginBottomFromY) * interpolatedTime);
                mLayoutParams.setMargins(mLayoutParams.leftMargin, mLayoutParams.topMargin,
                    mLayoutParams.rightMargin, newMarginBottom);
                mView.getParent().requestLayout();
            } else if (mVanishAfter) {
                mView.setVisibility(View.GONE);
            }
        }

    }
}
