#include "State.h"


State::State(int name)
{
	// Initialize lists
	trasitionTable = new map<char, State*>();
	outputTable = new map<char, char>();
	directionTable = new map<char, State::Direction>();

	// Initialize name
	_name = name;
}

State::~State()
{
	// Delete pointers
	if (trasitionTable != NULL)
		delete trasitionTable;
	if (outputTable != NULL)
		delete outputTable;
	if (directionTable != NULL)
		delete directionTable;
}

void State::addTransition(char input, State *state, char output, State::Direction direction){
	// Update maps
	trasitionTable->insert(make_pair(input, state));
	outputTable->insert(make_pair(input, output));
	directionTable->insert(make_pair(input, direction));
}

State* State::getState(char input){
	// Return the new state
	return trasitionTable->find(input)->second;
}

char State::getOutput(char input){
	// Return the output
	return outputTable->find(input)->second;
}

State::Direction State::getDirection(char input){
	// Return the direction
	return directionTable->find(input)->second;
}

int State::getName(){
	return _name;
}

bool State::isTransitionValid(char input){
	// Must be in all three tables to be valid
	if (trasitionTable->find(input) == trasitionTable->end())
		return false;
	if (outputTable->find(input) == outputTable->end())
		return false;
	if (directionTable->find(input) == directionTable->end())
		return false;

	return true;
}

State::Direction State::convertToDirection(char direction){
	switch (direction){
	case 'R':
	case 'r':
		return RIGHT;
		break;
	case 'L':
	case 'l':
		return LEFT;
		break;
	case 'H':
	case 'h':
		return HALT;
		break;
	default:
		return HALT;
	}
}