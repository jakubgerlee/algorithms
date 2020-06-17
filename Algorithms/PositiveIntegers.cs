using System.Runtime.InteropServices;

namespace Algorithms
{
	public class PositiveIntegers
	{
		public int[] GetTwoPositiveIntegersWhichSumIsEqualToInput(int num)
		{
			if(IsItPrimeNumber(num))
				return new[] { 1, num - 1 };

			for (var i = 2; i < num / 2; i++)
			{
				if (num % i != 0 || i % 10 == 0) 
					continue;
				if ((num - i) % 10 != 0)
				{
					return new[]{ i, num - i };
				}
			}
			return new []{num/2, num/2};
		}

		private bool IsItPrimeNumber(int num)
		{
			var a = 0;
			for (var i = 2; i <= num; i++)
			{
				if (num % i != 0) 
					continue;
				a++;
				if (a > 2)
					return false;
			}
			return true;
		}
	}
}
