#include "stdafx.h"

#include "UnmanagedMemoryLeak.h"

using namespace System::Threading;

UnmanagedMemoryLeak::UnmanagedBigObjectGenerator::UnmanagedBigObjectGenerator(int count)
{
	this->objectList = gcnew List<WrappingObject ^>();
	for (int i = 0; i < 10000; i++)
	{
		this->objectList->Add(gcnew WrappingObject(count));
	}
}

void UnmanagedMemoryLeak::UnmanagedBigObjectGenerator::CreateObjects()
{
	for (int i = 0; i < this->objectList->Count; i++)
	{
		this->objectList[i]->CreateObjects();

		if (i % 10 == 0)
			Thread::Sleep(100);
	}
}
