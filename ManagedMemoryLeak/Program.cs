using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnmanagedMemoryLeak;

namespace ManagedMemoryLeak
{
	class Program
	{
		static void Main(string[] args)
		{
			// Memory leak with managed objects
			var managedBigObjectGenerator = new ManagedBigObjectGenerator();
			managedBigObjectGenerator.CreateObjects();

			// Memory leak with managed objects and weak references
			//var managedBigObjectGeneratorWithWeakRef = new ManagedBigObjectGeneratorWithWeakReferences();
			//managedBigObjectGeneratorWithWeakRef.CreateObjects();

			// Memory leak with unmanaged objects
			//var unmanagedBigObjectGenerator = new UnmanagedBigObjectGenerator();
			//unmanagedBigObjectGenerator.CreateObjects();


			Console.WriteLine("Done");

			Console.ReadLine();
		}
	}
}
