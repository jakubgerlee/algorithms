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
		public void Solution_OnlyPositiveNumbersInArray_ReturnFirstPositiveNumber()
		{
			var input = new[] { 1, 3, 6, 4, 1, 2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumberWhichIsNotInArray(input);

			Assert.That(result, Is.EqualTo(5));
		}

		[Test]
		public void Solution_OnlyNegativeNumbersInArray_ReturnOne()
		{
			var input = new[] { -1, -3, -6, -4, -1, -2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumberWhichIsNotInArray(input);

			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void Solution_NegativeAndPositiveNumbersInArray_ReturnOne()
		{
			var input = new[] { -1, -3, 6, 4, 1, 2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumberWhichIsNotInArray(input);

			Assert.That(result, Is.EqualTo(3));
		}

	}
}