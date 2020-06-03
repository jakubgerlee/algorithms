using System;
using System.Linq;

namespace Algorithms
{
	public class OperationsOnArray
	{
		public int GetTheSmallestPositiveNumberWhichIsNotInArray(int[] A)
		{
			Array.Sort(A);
			if (A.Max() <= 0)
			{
				return 1;
			}

			for (var i = A.Min(); i <= A.Max(); i++)
			{
				if (i == A.Max() && i > 0)
				{
					return ++i;
				}
				if (!A.Contains(i) && i > 0)
				{
					return i;
				}
			}
			return A.Last();
		}
	}
}
