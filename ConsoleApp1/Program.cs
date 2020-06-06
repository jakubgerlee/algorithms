using System;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{ var val = new ValidateArguments();
			var result = val.Validate(new[]{"--Name", "SOME_NAME", "--count", "10"});
			var result2 = val.Validate(new[]{"--name", "SOME_NAME", "--count", "10", "--help"});
			Console.WriteLine("Hello World!");
		}
	}

	public class ValidateArguments
	{
 
	}
}
