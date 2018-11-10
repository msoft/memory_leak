#include "stdafx.h"
#include "WrappingObject.h"


WrappingObject::WrappingObject(int count)
{
	this->wrappedObject = new NativeObject(count);
}

void WrappingObject::CreateObjects()
{
	this->wrappedObject->CreateObjects();
}
