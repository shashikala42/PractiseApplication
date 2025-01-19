
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PractiseApp
{
    public class Logic
    {
        public int reverseDigits(int n)
        {
            int revNum = 0;
            while (n > 0)
            {
                revNum = revNum * 10 + n % 10;
                n = n / 10;
            }
            return revNum;
        }

        public int longestSubstringWithoutRepeatingCharacter(string s)
        {
            var res = s.Trim();

            if (string.IsNullOrEmpty(s))
                return 0;
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            int maxLength = 0,
                start = 0;
            for (int end = 0; end < s.Length; end++)
            {
                if (charMap.ContainsKey(s[end]))
                {
                    start = Math.Max(charMap[s[end]] + 1, start);
                }
                charMap[s[end]] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
        }

        public string LongestPalindromicSubstring(string s)
        {
            int n = s.Length;
            if (n == 0) return "";

            int start = 0, maxLen = 1;

            // Traverse the input string
            for (int i = 0; i < n; i++)
            {

                // THIS RUNS TWO TIMES 
                // for both odd and even length
                // palindromes. j = 0 means odd
                // and j = 1 means even length
                for (int j = 0; j <= 1; j++)
                {
                    int low = i;
                    int hi = i + j;

                    // Expand substring while it is a palindrome
                    // and in bounds
                    while (low >= 0 && hi < n && s[low] == s[hi])
                    {
                        int currLen = hi - low + 1;
                        if (currLen > maxLen)
                        {
                            start = low;
                            maxLen = currLen;
                        }
                        low--;
                        hi++;
                    }
                }
            }
            return s.Substring(start, maxLen); ;
        }

        public bool CheckPalindromeNumber(int num)
        {
            int reverseNum = 0;
            int temp = num;

            // Reverse the digits of the number
            while (temp != 0)
            {
                int digit = temp % 10;
                reverseNum = reverseNum * 10 + digit;
                temp = temp / 10;
            }

            if (num == reverseNum) return true;
            else return false;
        }

        public int ConvertStringtoInteger(string s)
        {
            int result = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c)) { result = result * 10 + (c - '0'); }
            }
            return result;
        }

        public int CalculateMaximumWidthfromLines()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };   
            int maxArea = 0; 
            int left = 0, right = height.Length - 1; 
            while (left < right) 
            { 
                int width = right - left; 
                int minHeight = Math.Min(height[left], height[right]); 
                int currentArea = width * minHeight; 
                maxArea = Math.Max(maxArea, currentArea); 
                if (height[left] < height[right]) 
                { 
                    left++; 
                } 
                else 
                { 
                    right--; 
                } 
            }
            return maxArea;
        }

        public string ConvertRomantoInteger(string roman)
        {
            StringBuilder result = new StringBuilder();

            Dictionary<char, string> romanValues = new Dictionary<char, string> { 
                { '1', "I" },
                { '2', "II" },
                { '3', "III" }, 
                { '4', "IV" }, 
                { '5', "V" }, 
                { '6', "VI" }, 
                { '7', "VII" },
                { '8', "VIII" },
                { '9', "XI" }
            };

            foreach (char c in roman) 
            { 
                if (romanValues.ContainsKey(c)) 
                { 
                    result.Append(romanValues[c]); 
                } 
            }

            return result.ToString();
        }

        public int FindSecondLargestNumber(int[] arr)
        {
            if (arr.Length < 2)
                throw new ArgumentException("Array must contain at least two elements.");

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) 
                return ""; 
            string prefix = strs[0]; 
            for (int i = 1; i < strs.Length; i++) 
            { 
                while (strs[i].IndexOf(prefix) != 0) 
                { 
                    prefix = prefix.Substring(0, prefix.Length - 1); 
                    if (prefix == "") return ""; 
                } 
            }
            return prefix;
        }
    }
}
