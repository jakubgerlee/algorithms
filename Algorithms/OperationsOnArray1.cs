using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class OperationsOnArray1
	{
		//method should return G where G is a concatenation of some of the strings from A
		//every letter in G has to be different
		public int ConcatLongestStringWithUniqueCharacters(string[] A)
		{
			A = GetStringsOnlyWithUniqueCharacters(A);
			if (!A.Any())
				return 0;
			
			var longestString = string.Empty;

			foreach (var currentString in A)
			{
				var charactersThatExistsInTwoArrays = longestString.Intersect(currentString).ToList();
				if (!charactersThatExistsInTwoArrays.Any())
				{
					longestString += currentString;
				}
			}

			return longestString.Length;
		}

		public static string[] GetStringsOnlyWithUniqueCharacters(string[] strings)
		{
			var arrayWithUniqueCharactersPerString = strings;
			foreach (var s in strings)
			{
				for (var i = 0; i < s.Length; i++)
				{
					for (var j = 0; j < s.Length; j++)
					{
						if (i == j)
							continue;
						if (s[i] == s[j])
						{
							arrayWithUniqueCharactersPerString = arrayWithUniqueCharactersPerString.Where(x => x != s).ToArray();
						}
					}
				}
			}
			return arrayWithUniqueCharactersPerString;
		}
	}
}
