using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FSharpExperiment
{
	class Program
	{
		static void Main(string[] args)
		{
			var values = new List<double>();

			for (int i = 0; i < 10000000; i++)
			{
				values.Add(i);
			}

			var stopwatch = Stopwatch.StartNew();

			var fSharpSum = FSharpLibrary.Class1.Sum(values);
			stopwatch.Stop();

			Console.WriteLine("Sum");
			Console.WriteLine("F# result: {0} time taken {1}", fSharpSum, stopwatch.ElapsedMilliseconds);
			Console.WriteLine();

			stopwatch.Restart();

			var cSharpSum = CSharpLibrary.Class1.Sum(values);
			stopwatch.Stop();

			Console.WriteLine("Sum");
			Console.WriteLine("C# result: {0} time taken {1}", cSharpSum, stopwatch.ElapsedMilliseconds);
			Console.WriteLine();




			//stopwatch.Restart();
			//var cSharpMean = CSharpLibrary.Class1.Mean(values);
			//stopwatch.Stop();

			//Console.WriteLine("Average");
			//Console.WriteLine("C# result: {0} time taken {1}", cSharpMean, stopwatch.ElapsedTicks);
			//Console.WriteLine();

			//stopwatch.Restart();
			////	var x = new FSharpLibrary.Class1();

			//var fSharpMean = FSharpLibrary.Class1.Mean(values);
			//stopwatch.Stop();

			//Console.WriteLine("Average");
			//Console.WriteLine("C# result: {0} time taken {1}", fSharpMean, stopwatch.ElapsedTicks);
			//Console.WriteLine();

			Console.ReadKey();
		}
	}
}
