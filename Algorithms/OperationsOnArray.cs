using System;
using System.Linq;

namespace Algorithms
{
	public class OperationsOnArray
	{
		public int GetTheSmallestPositiveNumber(int[] a)
		{
			Array.Sort(a);
			if (a.Max() <= 0)
			{
				return 1;
			}

			for (var i = a.Min(); i <= a.Max(); i++)
			{
				if (i == a.Max() && i > 0)
				{
					return ++i;
				}
				if (!a.Contains(i) && i > 0)
				{
					return i;
				}
			}
			return a.Last();
		}

		//Remove Duplicates from Sorted Array
		public int GetLengthOfSortedArrayWithoutDuplicates(int[] sortedArray)
		{
			if (sortedArray.Length == 0)
				return 0;
			sortedArray = sortedArray.Distinct().ToArray();
			return sortedArray.Length;
		}
	}
}
