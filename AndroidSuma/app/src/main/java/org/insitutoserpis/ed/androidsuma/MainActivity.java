package org.insitutoserpis.ed.androidsuma;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.EditText;
import android.widget.Toast;

import java.math.BigDecimal;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    public void onClickAddButton(View view){
        try{
            EditText firstNumberEditText = (EditText)findViewById(R.id.first_number);
            String firstNumber = firstNumberEditText.getText().toString();
            BigDecimal firstNum = new BigDecimal(firstNumber);

            EditText secondNumberEditText = (EditText)findViewById(R.id.second_number);
            String secondNumber = secondNumberEditText.getText().toString();
            BigDecimal secondNum = new BigDecimal(secondNumber);

            BigDecimal result = firstNum.add(secondNum);
            String res = result.toString();

            Toast.makeText(this, res, Toast.LENGTH_SHORT).show();
        }catch(NumberFormatException e){
            Toast.makeText(this,  "Introduzca valores en los campos", Toast.LENGTH_SHORT).show();
        }
    }

    public void onClickMultButton(View view){
        try {
            EditText firstNumberEditText = (EditText) findViewById(R.id.first_number);
            String firstNumber = firstNumberEditText.getText().toString();
            BigDecimal firstNum = new BigDecimal(firstNumber);

            EditText secondNumberEditText = (EditText) findViewById(R.id.second_number);
            String secondNumber = secondNumberEditText.getText().toString();
            BigDecimal secondNum = new BigDecimal(secondNumber);

            BigDecimal result = firstNum.multiply(secondNum);
            String res = result.toString();


            Toast.makeText(this, res, Toast.LENGTH_SHORT).show();
        }catch (NumberFormatException e){
            Toast.makeText(this,  "Introduzca valores en los campos", Toast.LENGTH_SHORT).show();
        }
    }

    public void onClickRestButton(View view){
        try{
            EditText firstNumberEditText = (EditText)findViewById(R.id.first_number);
            String firstNumber = firstNumberEditText.getText().toString();
            BigDecimal firstNum = new BigDecimal(firstNumber);

            EditText secondNumberEditText = (EditText)findViewById(R.id.second_number);
            String secondNumber = secondNumberEditText.getText().toString();
            BigDecimal secondNum = new BigDecimal(secondNumber);

            BigDecimal result = firstNum.add(secondNum.negate());
            String res = result.toString();


            Toast.makeText(this, res, Toast.LENGTH_SHORT).show();
        }catch (NumberFormatException e){
            Toast.makeText(this,  "Introduzca valores en los campos", Toast.LENGTH_SHORT).show();
        }
    }

    public void onClickDivButton(View view){
        try {
            EditText firstNumberEditText = (EditText) findViewById(R.id.first_number);
            String firstNumber = firstNumberEditText.getText().toString();
            BigDecimal firstNum = new BigDecimal(firstNumber);

            EditText secondNumberEditText = (EditText) findViewById(R.id.second_number);
            String secondNumber = secondNumberEditText.getText().toString();
            BigDecimal secondNum = new BigDecimal(secondNumber);

            BigDecimal result = firstNum.divide(secondNum);
            String res = result.toString();


            Toast.makeText(this, res, Toast.LENGTH_SHORT).show();
        }catch (NumberFormatException e){
            Toast.makeText(this,  "Introduzca valores en los campos", Toast.LENGTH_SHORT).show();
        }
    }

}
