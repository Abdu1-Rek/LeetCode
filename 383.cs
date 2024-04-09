using System;
namespace Program
{
	public class Solution
	{
		public bool CanConstruct(string ransomNote, string magazine)
		{
			if (ransomNote.Length > magazine.Length)
			{
				return false;
			}
			for (int i = 0; i < ransomNote.Length; i++)
			{
				if (magazine.IndexOf(ransomNote[i]) == -1)
				{
					return false;
				}
				magazine = magazine.Remove(magazine.IndexOf(ransomNote[i]), 1);
			}
			return true;
		}
	}

	internal class Program
	{
		public static void Main(string[] args)
		{
			Solution solution = new Solution();
			string ransomNote = "a";
			string magazine = "b";
			Console.WriteLine(solution.CanConstruct(ransomNote, magazine));
		}
	}
}
/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
*/