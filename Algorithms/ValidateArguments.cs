using System;

namespace Algorithms
{
	public class ValidateArguments
	{

		// Everything is ok = 0
		// Wrong arguments = -1
		// Need more details = 1

		public int Validate(string[] arguments)
		{
			var result = 0;
			var nameLabelIndex = GetIndexOfSelectedArgument(arguments, "--name");
			if (nameLabelIndex != -1)
				result = ValidateName(arguments[nameLabelIndex + 1]);
			var countLabelIndex = GetIndexOfSelectedArgument(arguments, "--count");
			if (countLabelIndex != -1 && result != -1)
				result = ValidateCount(arguments[countLabelIndex + 1]);

			var helpLabelIndex = GetIndexOfSelectedArgument(arguments, "--help");
			if (helpLabelIndex != -1 && result != -1)
				result = 1;

			return result;
		}

		private int ValidateName(string input) => input.Length > 3 && input.Length < 10 ? 0 : -1;

		private int ValidateCount(string input)
		{
			var result = int.TryParse(input, out int numb);
			return result && numb >= 0 && numb <= 100 ? 0 : -1;
		}

		private int GetIndexOfSelectedArgument(string[] array, string input) => Array.FindIndex(array, s => s.StartsWith(input, StringComparison.InvariantCultureIgnoreCase));

	}
}
