#pragma once
#include "NativeObject.h"

ref class WrappingObject
{
public:
	WrappingObject(int count);

	void CreateObjects();

private:
	NativeObject *wrappedObject;
};

