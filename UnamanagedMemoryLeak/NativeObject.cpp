#include "stdafx.h"
#include "NativeObject.h"


NativeObject::NativeObject(int count)
{
	this->count = count;
}

void NativeObject::CreateObjects()
{
	this->innerStrings = new std::string[this->count];

	for (int i = 0; i < this->count; i++)
	{
		this->innerStrings[i] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
	}
}