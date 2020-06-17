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
		public void GetTwoPositiveIntegersWhichSumIsEqualToInput_PositiveNumberInput_SumEqualsToInput()
		{
			var expectedResult = 100;

			var result = _positiveIntegers.GetTwoPositiveIntegersWhichSumIsEqualToInput(100);
			var actualResult = result.Sum();

			Assert.That(actualResult, Is.EqualTo(expectedResult));
		}
	}
}
