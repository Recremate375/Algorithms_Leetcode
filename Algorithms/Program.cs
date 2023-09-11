using RomanToInteger;
using Algorithms;

var roman = new RomanToIntegerClass();

Console.WriteLine(roman.RomanToInt("MCMXCIV"));

var triangle = new PascalTriangle();

var list = triangle.Generate(6);

foreach (var item in list)
{
	foreach (var item2 in item)
	{
		Console.WriteLine(item2.ToString());
	}
	Console.WriteLine("/");
}
