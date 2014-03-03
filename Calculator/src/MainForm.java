import java.awt.Button;
import java.awt.Frame;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;


public class MainForm extends Frame implements ActionListener{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	
	//Stuff
	ArrayList<Button> buttons;
	TextField textField;
	
	MainForm(){
		super();
		
		//create button list
		buttons = new ArrayList<Button>();
		
		//create text field
		textField = new TextField();
		
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints c = new GridBagConstraints();
		this.setLayout(gridBag);				
		c.fill = GridBagConstraints.HORIZONTAL;		
		
		//add the textfield
		c.gridwidth = 4;
		c.weightx = 1;
		c.gridx = 0;
		c.gridy = 0;
		gridBag.setConstraints(textField, c);
		add(textField);
		
		for(int i=0; i<16; ++i){
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
			default:
				tempButton.setLabel("0");				
			}
			
			//add listener
			tempButton.addActionListener(this);
			
			//add the button
			c.weightx = 0.33;
			c.gridwidth = 1;
			gridBag.setConstraints(tempButton, c);
			add(tempButton);
			
			//add button to our list
			buttons.add(tempButton);
		}
		
		this.pack();
	}

	@Override
	public void actionPerformed(ActionEvent arg) {
		
	}

}
