using RomanToInteger;
using Algorithms;

var roman = new RomanToIntegerClass();
var triangle = new PascalTriangle();
var twoSum = new TwoSumClass();

var list = triangle.Generate(6);

Console.WriteLine(roman.RomanToInt("MCMXCIV"));

foreach (var item in list)
{
	foreach (var item2 in item)
	{
		Console.WriteLine(item2.ToString());
	}
	Console.WriteLine("/");
}

var nums = twoSum.TwoSum(new int[] { 2, 7, 11, 15 }, 13);

foreach (var item in nums)
{
	Console.WriteLine(item.ToString());
}
