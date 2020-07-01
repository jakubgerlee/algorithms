using System.Linq;

namespace Algorithms
{
	public class SumArguments
	{
		//Given an array of ints, write a C# method to total all the values that are even numbers.
		public long SumEvenNumberFromArray(int[] array) => array.Where(x => x % 2 == 0).Sum(i => i);
	}
}
