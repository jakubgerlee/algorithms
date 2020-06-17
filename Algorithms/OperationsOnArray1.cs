using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms
{
	public class OperationsOnArray1
	{
		//method should return G where G is a concatenation of some of the strings from A
		//every letter in G has to be different
		public int GetTheLongestStringLengthFromAllStringAfterSumTwoOfThem(string[] A)
		{
			var longestStringLengthFrom = 0;
			for (var i = 0; i < A.Length; i++)
			{
				var stringsWithoutThisLetter = A;
				for (var j = 0; j < A[i].Length; j++)
				{
					stringsWithoutThisLetter = stringsWithoutThisLetter.Where(x => !x.Contains(A[i].ToCharArray()[j])).ToArray();
				}
			}
			return longestStringLengthFrom;
		}
	}
}
