#include <iostream>
#include <fstream>
#include <string>
#include "StateController.h";
using namespace std;


int main(int argc, const char* argv[]){
	StateController controller;

	// Main Loop
	while (true){

		// Get file
		ifstream infile;
		infile.open(argv[1]);
		if (!infile.good()){
			cout << "FILE OPENING ERROR" << endl;
			break;
		}
		
		// Prep input array
		char input[256];
		for (int i = 0; i < 100; i++)
			input[i] = NULL;
		
		// Read the line
		infile.getline(input, 256);

		// Switch on first character
		switch (input[0]){
		case 't':
		{
			// Get / Create the state
			int current_state = input[1] - '0';		//convert to int
			State* state = controller.getState(current_state);
			if (state == NULL)
				state = controller.addState(new State(current_state), current_state);

			// Add the transition
			// Read input
			char input_symbol = input[2];
			int next_state = input[3] - '0';		//convert to int
			char output_symbol = input[4];
			char direction = input[5];

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
			for (int i = 1; i < sizeof(input) / sizeof(char); i++){
				// Null check
				if (input[i] == NULL)
					break;

				// Get/Create the state
				State* state = controller.getState(input[i] - '0');
				if (state == NULL)
					state = controller.addState(new State(input[i] - '0'), input[i] - '0');

				//Set it as a final state
				controller.addFinalState(state);
			}
			break;
		}
		case 'i':
		{
			// Reset the controller (start at state 0, not invalid)
			controller.reset();

			// Line break
			cout << endl;

			// Add preceding and ending 'Z'
			// shift array 1 right
			for (int i = sizeof(input) / sizeof(char); i >= 0; i--){
				// Shift
				input[i] = input[i - 1];

				// Turn NULLs into 'Z'
				if (input[i] == NULL || input[i] == 'i')
					input[i] = 'Z';
			}
			// shift array back (now with Z's"
			for (int i = 0; i < sizeof(input) / sizeof(char) - 1; i++)
				input[i] = input[i + 1];

			// For all chars after the first
			for (int i = 1; i < sizeof(input) / sizeof(char) && i >= 1; /* tape set from transition */){
				// Null Check or if we're halting
				if (input[i] == NULL || controller.getLastDirection() == State::HALT)
					break;

				// Apply the transition
				controller.applyTransition(input[i]);

				// Get the output
				cout << controller.getLastOutput();

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
				default:
					cout << endl << "REJECTED" << endl;
					break;
				}
			}
			
			// Check if we rejected it
			if (!controller.isValid()){
				cout << endl << "REJECTED" << endl << endl;
				break;
			}
			else if (controller.isFinalState(controller.getCurrentState())){	// Are we accpeting?
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