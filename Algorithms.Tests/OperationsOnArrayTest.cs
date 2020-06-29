using NUnit.Framework;

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
		public void GetTheSmallestPositiveNumber_NegativeAndPositiveNumbersInArray_ReturnPositiveNumber()
		{
			var input = new[] { -1, -3, 6, 4, 1, 2 };

			var result = _operationsOnArray.GetTheSmallestPositiveNumber(input);

			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		public void GetLengthOfSortedArrayWithoutDuplicates_NegativeAndPositiveNumbersInArray_EverythingOk ()
		{
			var input = new[] {-5, -3, -3, 1, 1, 3, 5, 7 };
			var expectedResult = 6;

			var result = _operationsOnArray.GetLengthOfSortedArrayWithoutDuplicates(input);

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		public void GetLengthOfSortedArrayWithoutDuplicates_OnlyNegativeNumbersInArray_EverythingOk()
		{
			var input = new[] { -5, -3, -3, -1};
			var expectedResult = 3;

			var result = _operationsOnArray.GetLengthOfSortedArrayWithoutDuplicates(input);

			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}