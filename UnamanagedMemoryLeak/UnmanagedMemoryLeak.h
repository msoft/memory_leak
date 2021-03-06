#pragma once
#include "WrappingObject.h"

using namespace System;
using namespace System::Collections::Generic;

namespace UnmanagedMemoryLeak {
	public ref class UnmanagedBigObjectGenerator
	{
	public:
		UnmanagedBigObjectGenerator(int count);

		void CreateObjects();

	private:
		List<WrappingObject ^> ^objectList;
	};
}
