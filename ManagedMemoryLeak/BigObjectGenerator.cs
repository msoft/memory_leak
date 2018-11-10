using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManagedMemoryLeak
{
	internal class BigObject
	{
		private const string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		private List<string> strings = new List<string>();

		public void CreateObjects()
		{
			for (int i = 0; i < 100000; i++)
			{
				strings.Add(loremIpsum);
			}
		}
	}

	public class ManagedBigObjectGenerator
	{
		private List<BigObject> objects = new List<BigObject>();

		public void CreateObjects()
		{
			for (int i = 0; i < 100000; i++)
			{
				this.objects.Add(new BigObject());

				if (i % 10 == 0)
					Thread.Sleep(100);
			}
		}
	}

	//public class ManagedBigObjectGenerator
	//{
	//	private List<BigObject> objects = new List<BigObject>();

	//	public void CreateObjects()
	//	{
	//		for (int i = 0; i < 100000; i++)
	//		{
	//			this.objects.Add(new BigObject());

	//			if (i % 10 == 0)
	//				Thread.Sleep(10);

	//			if (i > 1000)
	//				this.objects[i - 1000] = null;
	//		}
	//	}
	//}

	public class ManagedBigObjectGeneratorWithWeakReferences
	{
		private List<WeakReference> objects = new List<WeakReference>();

		public void CreateObjects()
		{
			for (int i = 0; i < 10000; i++)
			{
				this.objects.Add(new WeakReference(new BigObject()));

				if (i % 10 == 0)
					Thread.Sleep(100);
			}
		}
	}

	public class UnmanagedBigObjectGenerator
	{
		private UnmanagedBigObjectGenerator unmanagedObjectGenerator;

		public UnmanagedBigObjectGenerator()
		{
			this.unmanagedObjectGenerator = new UnmanagedBigObjectGenerator();
		}

		public void CreateObjects()
		{
			this.unmanagedObjectGenerator.CreateObjects();
		}
	}
}
