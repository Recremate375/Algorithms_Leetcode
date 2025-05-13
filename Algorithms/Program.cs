using RomanToInteger;
using Algorithms;

var roman = new RomanToIntegerClass();
var triangle = new PascalTriangle();
var twoSum = new TwoSumClass();
var longestPrefix = new LongestPrefix();
var longestSubstring = new LongestSubstringWithoutRepeatinCharacters();
var BestTimeToBuy = new BestTimeToBuyAndSellStock();

//var list = triangle.Generate(6);

//Console.WriteLine(roman.RomanToInt("MCMXCIV"));

//foreach (var item in list)
//{
//	foreach (var item2 in item)
//	{
//		Console.WriteLine(item2.ToString());
//	}
//	Console.WriteLine("/");
//}

//var nums = twoSum.TwoSum(new int[] { 2, 7, 11, 15 }, 13);

//foreach (var item in nums)
//{
//	Console.WriteLine(item.ToString());
//}

//string[] strings = { "asddc", "as", "asdf", "asdfff" };

//string prefix = longestPrefix.FindLongestPrefix(strings);

//string[] strings = { "flowers", "flights", "flos", "flow" };

//string prefix = longestPrefix.SecondMethod(strings);

//Console.WriteLine(prefix);

//string str = "pwwkew";

//int length = longestSubstring.LengthOfLongestSubstring(str);

//Console.WriteLine(length.ToString());

int[] prices = new int[]
{
    7,1,5,3,6,4
};

int profit = BestTimeToBuy.MaxProfit(prices);

Console.WriteLine(profit);

