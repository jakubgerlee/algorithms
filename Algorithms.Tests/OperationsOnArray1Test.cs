using NUnit.Framework;

namespace Algorithms.Tests
{
	public class OperationsOnArray1Test
	{
		private OperationsOnArray1 _operationsOnArray1;

		[SetUp]
		public void SetUp()
		{
			_operationsOnArray1 = new OperationsOnArray1();
		}

		[Test]
		public void GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem_ManyStringProvided_Return5()
		{
			var input = new[]{"co", "dil", "ity"};

			var result = _operationsOnArray1.GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem(input);
			
			Assert.That(result, Is.EqualTo(5));
		}

		[Test]
		public void GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem_ManyStringProvided_Return6()
		{
			var input = new[]{"abc", "yyy", "def", "csv"};

			var result = _operationsOnArray1.GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem(input);

			Assert.That(result, Is.EqualTo(6));
		}

		[Test]
		public void GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem_SameLettersInEachStrings_Return0()
		{
			var input = new[]{"potato", "kayak", "banana", "rececar"};

			var result = _operationsOnArray1.GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem(input);

			Assert.That(result, Is.EqualTo(0));
		}

		[Test]
		public void GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem_SameLettersInEachStrings_Return9()
		{
			var input = new[]{"eva", "jqw", "tyn", "jan"};

			var result = _operationsOnArray1.GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem(input);

			Assert.That(result, Is.EqualTo(9));
		}
	}
}
