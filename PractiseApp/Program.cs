// See https://aka.ms/new-console-template for more information
using PractiseApp;

Console.WriteLine("Hello, World!");
Logic logic = new Logic();
//var result = logic.reverseDigits(457);
//var longestSubstring = logic.longestSubstringWithoutRepeatingCharacter("abcabdabfg");
//Console.WriteLine("Result", longestSubstring);
//var longestPalindrome = logic.LongestPalindromicSubstring("geeksskeegabc");
//var checkPalindrome = logic.CheckPalindromeNumber(121);
//Console.WriteLine("Result", checkPalindrome);
//var stringtoInteger = logic.ConvertStringtoInteger("123shash12i");
//var calculateMaxWidth = logic.CalculateMaximumWidthfromLines();
//var convertRomantoInteger = logic.ConvertRomantoInteger("1254367");
int[] array = { 10, 20, 4, 45, 99, 45 };
string[] strs = { "flower", "flow", "flight" };
//var findSecondLargest = logic.FindSecondLargestNumber(array);
var findCommonPrefixInListofstring = logic.LongestCommonPrefix(strs);
