using NUnit.Framework;

namespace Algorithms.Tests
{
	public class ValidatorTest
	{
		private ValidateArguments _validateArguments;

		[SetUp]
		public void Setup()
		{
			_validateArguments = new ValidateArguments();
		}

		// Everythinks is ok = 0
		// Wrong arguments = -1
		// Need more details = 1

		[Test]
		public void Validate_CorrectArguments_EverythingIsOk()
		{
			var result = _validateArguments.Validate(new[] { "--Name", "SOME_NAME", "--count", "10" });

			Assert.That(result, Is.EqualTo(0));
		}

		[Test]
		public void Validate_CorrectArgumentsWithHelpInput_NeedMoreDetails()
		{
			var result = _validateArguments.Validate(new[] { "--name", "SOME_NAME", "--count", "10", "--help" });

			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void Validate_OnlyCountArgumentPassed_EverythingIsOk()
		{
			var result = _validateArguments.Validate(new[] { "--count", "10" });
			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void Validate_WrongCountInput_WrongArguments()
		{
			var result = _validateArguments.Validate(new[] { "--count", "text" });

			Assert.That(result, Is.EqualTo(-1));

		}
	}
}