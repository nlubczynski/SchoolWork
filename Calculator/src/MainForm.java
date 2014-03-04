import java.awt.Button;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Stack;

import javax.swing.JFrame;
import javax.swing.WindowConstants;


public class MainForm extends JFrame implements ActionListener{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	
	//Stuff
	static ArrayList<Button> buttons;
	TextField textField;
	String[] states = {"numb1", "numb2", "result"};
	String state;
	Double numb1;
	Double numb2;
	String operand;
	//RPN Mode
	Boolean mode;
	
	//RPN Stack
	Stack<String> stack;
	
	MainForm(){
		super();
		
		//set default state
		state = states[0];
		numb1 = 0.0;
		numb2 = 0.0;
		operand = "+";
		mode = false;
		stack = new Stack<String>();
		
		//create button list
		buttons = new ArrayList<Button>();
		
		//create text field
		textField = new TextField();
		
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints c = new GridBagConstraints();
		this.setLayout(gridBag);				
		c.fill = GridBagConstraints.HORIZONTAL;		
		
		//add the text field
		c.gridwidth = 4;
		c.weightx = 1;
		c.gridx = 0;
		c.gridy = 0;
		gridBag.setConstraints(textField, c);
		add(textField);
		
		for(int i=0; i<17; ++i){
			Button tempButton = new Button();
			
			c.gridx = i % 4;
			c.gridy = i / 4 + 1;
			
			switch(i){
			case 3:
				tempButton.setLabel("+");
				break;
			case 7:
				tempButton.setLabel("-");
				break;
			case 11:
				tempButton.setLabel("/");
				break;
			case 15:
				tempButton.setLabel("X");
				break;
			case 12:
				tempButton.setLabel(".");
				break;
			case 14:
				tempButton.setLabel("=");
				break;
			case 0: case 1: case 2:
				tempButton.setLabel(String.valueOf(i + 7));
				break;
			case 4: case 5: case 6:
				tempButton.setLabel(String.valueOf(i));
				break;
			case 8: case 9: case 10:
				tempButton.setLabel(String.valueOf(i-7));
				break;
			case 13:
				tempButton.setLabel("0");
				break;
			default:
				tempButton.setLabel("RPN");
				
			}
			

			
			//RPN Button
			if(tempButton.getLabel() == "RPN")
			{
				tempButton.addActionListener(new RPNAction());
				
				c.weightx = 0.33;
				c.gridwidth = 4 ;
			}
			else
			{
				//add listener
				tempButton.addActionListener(this);
				
				//add the button
				c.weightx = 0.33;
				c.gridwidth = 1;
			}
			
			gridBag.setConstraints(tempButton, c);
			add(tempButton);
			
			//add button to our list
			buttons.add(tempButton);
		}
		
		this.pack();
		this.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
	}

	@Override
	public void actionPerformed(ActionEvent arg) {
		String input = ((Button)arg.getSource()).getLabel();
		
		//branch off whether it's a number or not
		try{
			int number = Integer.valueOf(input);
			handleNumber(number);
		}catch(NumberFormatException e){
			handleOperator(input);
		}
		
	}
	public class RPNAction implements ActionListener{
		public void actionPerformed(ActionEvent arg){
			if(mode)
			{
				mode=false;
				MainForm.buttons.get(16).setLabel("RPN");
				MainForm.buttons.get(14).setEnabled(true);
			}
			else
			{
				mode=true;
				MainForm.buttons.get(16).setLabel("INFIX");
				MainForm.buttons.get(14).setEnabled(false);
			}
		}
	}
	public void handleNumber(int number){
		
		if (!mode) {
			if (state == states[0]) {
				//append number, don't change state
				textField.setText(textField.getText() + String.valueOf(number));
			} else if (state == states[1]) {
				//append number, don't change state
				textField.setText(textField.getText() + String.valueOf(number));
			} else if (state == states[2]) {
				//change state to state 0, remove memory, add number
				state = states[0];
				numb1 = 0.0;
				numb2 = 0.0;
				textField.setText("");
				textField.setText(textField.getText() + String.valueOf(number));
			}
		}
		else
		{
			String inputValue = String.valueOf(number);
			
			stack.push(inputValue);
			textField.setText(inputValue);
		}
	}
	public void handleOperator(String operator){
		
		if (!mode) {
			if (operator.equals("=")) {
				handleEquals();
				return;
			}
			if (operator.equals(".")) {
				handleDecimal();
				return;
			}
			//Handle states
			if (state == states[0]) {
				//store number as number 1, change state to state 1, store operator
				numb1 = Double.valueOf(textField.getText());

				state = states[1];

				operand = operator;
			} else if (state == states[1]) {
				//store result as number 1, change state to state 1, store operator
				numb2 = Double.valueOf(textField.getText());

				numb1 = doOperation(numb1, numb2, operand);

				operand = operator;
			} else if (state == states[2]) {
				//store result as number 1, change to state 1, store operator
				numb1 = Double.valueOf(textField.getText());

				state = states[1];

				operand = operator;
			}
			textField.setText("");
		}
		else
		{
			double topNumber = Double.parseDouble(stack.pop());
			double botNumber = Double.parseDouble(stack.pop());
			
			double result = this.doOperation(botNumber, topNumber, operator);
			
			stack.push(String.valueOf(result));
			
			textField.setText(String.valueOf(result));
		}
	}
	
	public void handleEquals(){
		if(state == states[0] || state == states[1]){
			numb2 = Double.valueOf(textField.getText());
			textField.setText(String.valueOf(doOperation(numb1, numb2, operand)));
			state = states[2];
		}else{
			numb1 = Double.valueOf(textField.getText());
			textField.setText(String.valueOf(doOperation(numb1, numb2, operand)));
			state = states[2];
		}
	}
	public void handleDecimal(){
		if(textField.getText().contains("."))
			return;
		else
			textField.setText(textField.getText() + ".");
	}
	public double doOperation(double numA, double numB, String operator){
		if(operator.equals("+")){
			return numA + numB;
		}
		else if(operator.equals("-")){
			return numA - numB;
		}
		else if(operator.equals("/")){
			return numA / numB;
		}
		else if(operator.equals("X")){
			return numA * numB;
		}
		
		return 0.0;
	}
}
