package nlubczynski.lab2;

import android.os.Bundle;
import android.app.Activity;
import android.view.KeyEvent;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnKeyListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.TextView.OnEditorActionListener;

public class MainActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        final Button button = (Button) findViewById(R.id.button1);
        button.setOnClickListener(new OnClickListener() {        	
        	public void onClick(View v){        		
        		calculateValue();        		
        	}        	
        });
       
       final EditText OPN = (EditText)findViewById(R.id.OPN);
       OPN.setOnKeyListener(new OnKeyListener() {

			@Override
			public boolean onKey(View arg0, int arg1, KeyEvent arg2) {
				if( arg2.getAction() == KeyEvent.ACTION_DOWN &&	arg1 == KeyEvent.KEYCODE_ENTER){
					calculateValue();
					return true;
				}
				return false;
			}

        });
       
    	final EditText DPN = (EditText)findViewById(R.id.DPN);
    	DPN.setOnKeyListener(new OnKeyListener() {

			@Override
			public boolean onKey(View arg0, int arg1, KeyEvent arg2) {
				if( arg2.getAction() == KeyEvent.ACTION_DOWN &&	arg1 == KeyEvent.KEYCODE_ENTER){
					calculateValue();
					return true;
				}
				return false;
			}
        	
        	
        	
        });      
    }
    
    public void calculateValue(){
    	
    	//get the value
    	EditText OPN = (EditText)findViewById(R.id.OPN);
    	EditText DPN = (EditText)findViewById(R.id.DPN);
    	
    	//Check strings are valid
    	if( OPN.getText().toString().length() == 0 ){
    		TextView youPay = (TextView)findViewById(R.id.PayVal);
    		youPay.setText("Please enter a value for the Price");
    		return;
    	}    	
    	if( DPN.getText().toString().length() == 0 ){
    		TextView youPay = (TextView)findViewById(R.id.PayVal);
    		youPay.setText("Please enter a value for the Discount");
    		return;
    	}
    	
    	//convert to a double
    	Double OPn = Double.parseDouble( OPN.getText().toString() );
    	Double DPn = Double.parseDouble( DPN.getText().toString() );
    	
    	//Check the Percentage is between 0 and 100
    	if(DPn < 0 || DPn > 100){
    		TextView youPay = (TextView)findViewById(R.id.PayVal);
    		youPay.setText("Please enter a percentage between 0 and 100");
    		return;
    	}
    	
    	//Calculate the value
    	Double value = OPn * (1 - DPn / 100 ) * 1.13;
    	    	
    	//Return the Value trimmed to 2 decimal places
    	TextView youPay = (TextView)findViewById(R.id.PayVal);
    	youPay.setText( "$" + String.format("%.2f", value) );
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }
    
}
