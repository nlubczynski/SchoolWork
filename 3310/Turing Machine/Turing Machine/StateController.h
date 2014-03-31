#pragma once
#include "State.h"
#include <vector>
#include <string>
using namespace std;

class StateController
{
public:
	// Constructors
	StateController();
	~StateController();

	// Member Variables
	
	// Functions
		//Current state
		State* getCurrentState();
		void setCurrentState(State*);
		bool isValid();
		void setInvalid();
		void reset();

		// State modifiers
		State* getState(int i);
		State* addState(State *, int i);
		void addFinalState(State*);
		bool isFinalState(State*);

		//Transitions
		void applyTransition(char input);	
		void addTransition(char input, State *currentState, State *newState, char output, State::Direction direction);

		//Outputs
		char getLastOutput();
		State::Direction getLastDirection();

private:
	// Member Variables
	State *_currentState;
	vector<State*> *_allStates;
	vector<State*> *_acceptingStates;
	State::Direction _direction;
	char _output;
	bool _valid;

};

