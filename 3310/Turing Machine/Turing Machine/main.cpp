#include <iostream>
#include <string>
#include <sstream>
#include <iterator>
#include "StateController.h";
using namespace std;

#define MAX_INPUTS 100
#define MAX_LENGTH_INPUT 256


int main(int argc, const char* argv[]){
	StateController controller;

	// Main Loop
	while (true){
	
		// Prep input array
		char input[MAX_INPUTS][MAX_LENGTH_INPUT];
		for (int i = 0; i < MAX_INPUTS; i++)
			for (int j = 0; j < MAX_LENGTH_INPUT; j++)
				input[i][j] = NULL;
		
		// Read the line
		string line;
		getline(cin, line);
		istringstream buf(line);
		istream_iterator<string> beg(buf), end;
		vector<string> tokens(beg, end);

		// Convert strings to char arrays
		for (unsigned i = 0; i < tokens.size(); i++)
			for (unsigned j = 0; j < tokens.at(i).size(); j++)
				input[i][j] = tokens.at(i).at(j);

		// Switch on first character
		switch (input[0][0]){
		case 't':
		{
			// Get / Create the state
			int current_state;
			sscanf(input[1], "%d", &current_state);	//convert to int

			State* state = controller.getState(current_state);
			if (state == NULL)
				state = controller.addState(new State(current_state), current_state);

			// Add the transition
			// Read input
			char input_symbol = input[2][0];

			int next_state;
			sscanf(input[3], "%d", &next_state);//convert to int

			char output_symbol = input[4][0];
			char direction = input[5][0];

			// Get / Create next State
			State* nextState = controller.getState(next_state);
			if (nextState == NULL)
				nextState = controller.addState(new State(next_state), next_state);

			controller.addTransition(input_symbol, state, nextState, output_symbol, State::convertToDirection(direction));
			break;
		}
		case 'f':
		{
			// For all chars after the first
			for (int i = 1; i < MAX_INPUTS; i++){
				// Null check
				if (input[i] == NULL)
					break;

				// Get number
				int accepting_state;
				sscanf(input[i], "%d", &accepting_state);//convert to int

				// Get/Create the state
				State* state = controller.getState(accepting_state);
				if (state == NULL)
					state = controller.addState(new State(accepting_state), accepting_state);

				//Set it as a final state
				controller.addFinalState(state);
			}
			break;
		}
		case 'i':
		{
			// Reset the controller (start at state 0, not invalid)
			controller.reset();

			// Add preceding and ending 'Z'(s)
			// shift array 1 right so we can put the first one in
			for (int i = sizeof(input[1]) / sizeof(char); i >= 0; i--){
				// Shift
				input[1][i] = input[1][i - 1];

				// Turn NULLs into 'Z'
				if (input[1][i] == NULL)
					input[1][i] = 'Z';
			}

			// Run through the tape
			for (int i = 1;											// (we added Z to the start, so start at 1)		
				i < sizeof(input[1]) / sizeof(char)					// max length
				&& i >= 0											// min length
				&& controller.getLastDirection() != State::HALT;	// halting
				)													// tape step set from transition
			{

				// Apply the transition
				controller.applyTransition(input[1][i]);

				// Get the output
				input[1][i] = controller.getLastOutput();

				// Go some direction
				switch (controller.getLastDirection()){
				case State::RIGHT:
					i++;
					break;
				case State::LEFT:
					i--;
					break;
				case State::HALT:
					break;
				}
			}
			
			// Check if we rejected it
			if (!controller.isValid()){
				for (int i = 0; i < sizeof(input[1]) / sizeof(char); i++)
					if (input[1][i] != 'Z')
						cout << input[1][i];
				cout << endl << "REJECTED" << endl << endl;
				break;
			}
			else if (controller.isFinalState(controller.getCurrentState())){	// Are we accpeting?
				for (int i = 0; i < sizeof(input[1]) / sizeof(char); i++)
					if (input[1][i] != 'Z')
						cout << input[1][i];
				cout << endl << "ACCEPTED" << endl << endl;
				break;
			}
			break;
		}
		default:
			// Exit program
			exit(0);
			break;
		}
		
	}
	return 0;
}