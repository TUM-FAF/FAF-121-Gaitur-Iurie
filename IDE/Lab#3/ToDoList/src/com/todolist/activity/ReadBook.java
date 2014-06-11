package com.todolist.activity;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import com.todolist.adapters.BooksAdapter;
import com.todolist.entity.Book;

import android.app.Activity;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class ReadBook extends Activity {

	TextView isConn;
	ListView listBooks;
	String bookJSON;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.list_books);

		isConn = (TextView) findViewById(R.id.isConnected);
		listBooks = (ListView) findViewById(R.id.listBooks);

		if (isConnected()) {
			isConn.setBackgroundColor(0xFF00C00);
			isConn.setText("You are connected");

		} else {
			isConn.setBackgroundColor(0xFF00C00);
			isConn.setText("You are not connected");
		}

		new HttpAsyncTask()
				.execute("http://www.kimonolabs.com/api/9w1giuu4?apikey=1781fb9a5b44efe055e2a239c05ac718");

		
		
		
	}

	public boolean isConnected() {
		ConnectivityManager conMng = (ConnectivityManager) getSystemService(Activity.CONNECTIVITY_SERVICE);
		NetworkInfo network = conMng.getActiveNetworkInfo();
		if (network != null && network.isConnected())
			return true;

		return false;

	}

	public static String GET(String url) {
		InputStream input = null;
		String result = "";
		try {

			// Create http client
			HttpClient client = new DefaultHttpClient();

			// make GEt request to the given url
			HttpResponse httpRespons = client.execute(new HttpGet(url));

			// receive response as an input stream
			input = httpRespons.getEntity().getContent();

			if (input != null) {
				result = convertInputToString(input);
			} else
				result = "Did not work";

		} catch (Exception ex) {
			Log.d("read exception", "Cannot read don't know why");
		}

		return result;
	}

	public static String convertInputToString(InputStream stream) {
		BufferedReader reader = new BufferedReader(
				new InputStreamReader(stream));
		String line = "";
		String result = "";
		try {
			while ((line = reader.readLine()) != null) {
				result += line;
			}

			stream.close();
		} catch (Exception ex) {
			Log.d("reader_exception", "Cannot read from input steam");
		}

		return result;
	}

	private class HttpAsyncTask extends AsyncTask<String, Void, String> {

		@Override
		protected String doInBackground(String... urls) {
			// TODO Auto-generated method stub
			return GET(urls[0]);
		}

		@Override
		protected void onPostExecute(String result) {
			// TODO Auto-generated method stub
			Toast.makeText(getBaseContext(), "Finished", Toast.LENGTH_SHORT)
					.show();
			//isConn.setText(result);
			bookJSON = result;
			
			List<Book> myBooks = fromJsonToList(bookJSON);
			BooksAdapter bookAdapter = new BooksAdapter(getApplication(), R.layout.item_list_book, myBooks);
			listBooks.setAdapter(bookAdapter);
			

		}
	}

	public List<Book> fromJsonToList(String json) {
		
		List<Book> myList = new ArrayList<Book>();
		try {
			
			JSONParser parser = new JSONParser();
			
			Object obj = parser.parse(json);
			JSONObject jsonObj = (JSONObject)obj;
			jsonObj = (JSONObject) jsonObj.get("results");
			
			JSONArray jsonList = (JSONArray)jsonObj.get("collection1");
			int length = jsonList.size();
			Log.d("iura", jsonList.size()+"");
			for(int i=0;i<jsonList.size();i++) {
				Book book = new Book();
				JSONObject jsonItem = (JSONObject)jsonList.get(i);
				
				JSONObject tempObj1  = (JSONObject) jsonItem.get("image");
				JSONObject tempObj2  = (JSONObject) jsonItem.get("Title");
				JSONObject tempObj3  = (JSONObject) jsonItem.get("Description");
				
				book.image = tempObj1.get("src").toString();
				book.title = tempObj2.get("text").toString();
				book.description = tempObj3.get("text").toString();
				
				myList.add(book);
				
				
			
			}
			
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			return myList;
		}
		
		
		return myList;
	}

}
