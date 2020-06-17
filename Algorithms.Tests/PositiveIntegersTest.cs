using System.Linq;
using NUnit.Framework;

namespace Algorithms.Tests
{
	public class PositiveIntegersTest
	{
		// D + B = N
		// D or B cannot contain 0 
		private PositiveIntegers _positiveIntegers;

		[SetUp]
		public void Setup()
		{
			_positiveIntegers = new PositiveIntegers();
		}

		[Test]
		public void GetTwoPositiveIntegersWhichSumIsEqualToInput_NumberDividedBy10_SumEqualsToInput()
		{
			var input = 100;
			var expectedResult = input;

			var result = _positiveIntegers.GetTwoPositiveIntegersWhichSumIsEqualToInput(input);
			var actualResult = result.Sum();
			
			Assert.That(actualResult, Is.EqualTo(expectedResult));
			Assert.That(result[0]%10, Is.Not.Zero);
			Assert.That(result[1]%10, Is.Not.Zero);
		}

		[Test]
		public void GetTwoPositiveIntegersWhichSumIsEqualToInput_NumberCannotBeDivideBy10_SumEqualsToInput()
		{
			var input = 8;
			var expectedResult = input;

			var result = _positiveIntegers.GetTwoPositiveIntegersWhichSumIsEqualToInput(input);
			var actualResult = result.Sum();

			Assert.That(actualResult, Is.EqualTo(expectedResult));
			Assert.That(result[0] % 10, Is.Not.Zero);
			Assert.That(result[1] % 10, Is.Not.Zero);
		}

		[Test]
		public void GetTwoPositiveIntegersWhichSumIsEqualToInput_PrimeNumberIsAnInput_SumEqualsToInput()
		{
			var input = 7;
			var expectedResult = input;

			var result = _positiveIntegers.GetTwoPositiveIntegersWhichSumIsEqualToInput(input);
			var actualResult = result.Sum();

			Assert.That(actualResult, Is.EqualTo(expectedResult));
			Assert.That(result[0] % 10, Is.Not.Zero);
			Assert.That(result[1] % 10, Is.Not.Zero);
		}
	}
}
