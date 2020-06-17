using System;

namespace Interview
{
	class Program
	{
		static void Main(string[] args)
		{
			var val = new ValidateArguments();
			var result = val.Validate(new[] { "--Name", "SOME_NAME", "", "10" });
			//var result = val.Validate(new[] { "--Name", "SOME_NAME", "--count", "10" });
			var result2 = val.Validate(new[] { "--name", "SOME_NAME", "--count", "10", "--help" });
			Solution2(15);

			Console.ReadKey();
		}

		static void Solution2(int n)
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

	public class ValidateArguments
	{
		public int Validate(string[] args)
		{
			int result = -1;
			var countIndex = Array.FindIndex(args, x => x.StartsWith("--Count", StringComparison.InvariantCultureIgnoreCase));
			if (countIndex != -1)
			{
				IsCountInputOk();
			}

			return result;
		}

		private bool IsCountInputOk()
		{
			return true;
		}
	}
}