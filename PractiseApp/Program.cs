// See https://aka.ms/new-console-template for more information
using PractiseApp;

Console.WriteLine("Hello, Rayan!");
Logic logic = new Logic();
var resultReverseDigits = logic.reverseDigits(457);
Console.WriteLine("resultReverseDigits", resultReverseDigits);
var longestSubstring = logic.longestSubstringWithoutRepeatingCharacter("abcabdabfg");
Console.WriteLine("longestSubstring", longestSubstring);
var longestPalindrome = logic.LongestPalindromicSubstring("geeksskeegabc");
Console.WriteLine("longestPalindrome", longestPalindrome);
var checkPalindrome = logic.CheckPalindromeNumber(121);
Console.WriteLine("checkPalindrome", checkPalindrome);
var stringtoInteger = logic.ConvertStringtoInteger("123shash12i");
Console.WriteLine("stringtoInteger", stringtoInteger);
var calculateMaxWidth = logic.CalculateMaximumWidthfromLines();
Console.WriteLine("calculateMaxWidth", calculateMaxWidth);
var convertRomantoInteger = logic.ConvertRomantoInteger("1254367");
Console.WriteLine("convertRomantoInteger", convertRomantoInteger);
int[] array = { 10, 20, 4, 45, 99, 45 };
string[] strs = { "flower", "flow", "flight" };
var findSecondLargest = logic.FindSecondLargestNumber(array);
Console.WriteLine("findSecondLargest", findSecondLargest);
var findCommonPrefixInListofstring = logic.LongestCommonPrefix(strs);
Console.WriteLine("findCommonPrefixInListofstring", findCommonPrefixInListofstring);
