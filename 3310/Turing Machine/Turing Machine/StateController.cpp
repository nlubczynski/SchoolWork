#include "StateController.h"


StateController::StateController()
{
	// Create list
	_allStates = new vector<State*>(100);
	_acceptingStates = new vector<State*>();

	// Set direction = right
	_direction = State::RIGHT;

	// Set valid = true
	_valid = true;
}


StateController::~StateController()
{
	delete _currentState;
	delete []_allStates;
}

State* StateController::getCurrentState(){
	return _currentState;
}

State* StateController::getState(int i){
	return _allStates->at(i);
}

void StateController::setCurrentState(State* newState){
	if (newState != NULL)
		_currentState = newState;
}

void StateController::applyTransition(char input){
	// Check if valid, if not, just output the last character
	if (!_currentState->isTransitionValid(input) || !isValid()){
		// Set invalid
		setInvalid();

		//change output
		_output = input;

		// Just read through rest of tape
		_direction = State::RIGHT;

		return;
	}
	// Get the current direction
	_direction = _currentState->getDirection(input);
	// Get the output
	_output = _currentState->getOutput(input);
	// Set the new state
	setCurrentState(_currentState->getState(input));
}

State* StateController::addState(State *newState, int i){
	if (newState != NULL)
		_allStates->at(i) = newState;

	return newState;
}

void StateController::addTransition(char input, State *currentState, State *newState, 
	char output, State::Direction direction){
	if (currentState != NULL && newState != NULL)
		currentState->addTransition(input, newState, output, direction);
}

void StateController::addFinalState(State* state){
	if (state != NULL)
		_acceptingStates->push_back(state);
}

bool StateController::isFinalState(State* state){
	if (state != NULL)
	{
		if (find(_acceptingStates->begin(), _acceptingStates->end(), state) != _acceptingStates->end())
			return true;
	}
	return false;
}

char StateController::getLastOutput(){
	if (_output == 'Z')
		_output = ' ';
	return _output;
}

State::Direction StateController::getLastDirection(){
	return _direction;
}

bool StateController::isValid(){
	return _valid;
}

void StateController::setInvalid(){
	_valid = false;
}

void StateController::reset(){
	// Reset valid
	_valid = true;

	//Reset current state
	State* state = getState(0);
	if (state == NULL)
		state = addState(new State(0), 0);
	setCurrentState(getState(0));

	// Reset direction
	_direction = State::RIGHT;
}