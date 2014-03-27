#pragma once
#include <map>
#include <iostream>
#include <string>
using namespace std;

class State
{
public:
	// Constructors
	State(int name);
	~State();

	// Enum
	enum Direction { LEFT, RIGHT, HALT };

	// Functions
	void addTransition(char input, State *state, char output, Direction direction);
	State* getState(char input);
	char getOutput(char input);
	Direction getDirection(char input);
	int getName();
	bool isTransitionValid(char input);

	// Static functions
	static Direction convertToDirection(char direction);	

private:
	// Map an input string to an output string and new state
	map<char, State*> *trasitionTable;
	map<char, char> *outputTable;
	map<char, Direction> *directionTable;

	// Variables
	int _name;
};

