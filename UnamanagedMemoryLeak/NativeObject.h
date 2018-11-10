#pragma once
#include <string>

class NativeObject
{
public:
	NativeObject(int count);

	void CreateObjects();

private:
	int count;
	std::string *innerStrings;
};

