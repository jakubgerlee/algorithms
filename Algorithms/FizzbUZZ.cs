using System;

namespace Algorithms
{
	public class FizzbUZZ
	{
		static void FizzBuzzz(int n)
		{
			var temp = n;
			var result = string.Empty;
			for (var i = 1; i <= n; i++)
			{
				if (i % 3 == 0)
					result = "Fizz";
				if (i % 5 == 0)
					result += "Buzz";
				if (result == string.Empty)
				{
					result = i.ToString();
				}

				Console.WriteLine(result);
				result = string.Empty;
			}
		}
	}
}
