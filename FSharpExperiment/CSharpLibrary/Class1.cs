using System.Collections.Generic;
using System.Linq;

namespace CSharpLibrary
{
	public class Class1
	{
		public static double Sum(IEnumerable<double> values)
		{
			// return values.Sum();

			var mean = 0.0;
			foreach (double value in values)
			{
				mean += value;
			}

			return mean;
		}

		/// <summary>
		/// Returns the mean average for the specified values.
		/// </summary>
		/// <param name="values">The values to determine the mean for.</param>
		/// <returns>The mean value.</returns>
		public static double Mean(IEnumerable<double> values)
		{
			return Sum(values) / values.Count();
		}
	}
}
