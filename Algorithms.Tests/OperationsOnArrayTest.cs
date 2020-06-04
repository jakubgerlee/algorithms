using NUnit.Framework;
using Algorithms;

namespace Algorithms.Tests
{
	public class OperationsOnArrayTest
	{
		private OperationsOnArray _operationsOnArray;

		[SetUp]
		public void Setup()
		{
			_operationsOnArray = new OperationsOnArray();
		}

		[Test]
		public void GetTheSmallestPositiveNumber_OnlyPositiveNumbersInArray_ReturnFirstPositiveNumber()
		{
			var input = new[] { 1, 3, 6, 4, 1, 2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumber(input);

			Assert.That(result, Is.EqualTo(5));
		}

		[Test]
		public void GetTheSmallestPositiveNumber_OnlyNegativeNumbersInArray_ReturnOne()
		{
			var input = new[] { -1, -3, -6, -4, -1, -2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumber(input);

			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void GetTheSmallestPositiveNumber_NegativeAndPositiveNumbersInArray_ReturnOne()
		{
			var input = new[] { -1, -3, 6, 4, 1, 2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumber(input);

			Assert.That(result, Is.EqualTo(3));
		}
	}
}