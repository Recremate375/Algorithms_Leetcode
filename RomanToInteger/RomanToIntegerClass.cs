namespace RomanToInteger
{
	public class RomanToIntegerClass
	{
		private readonly Dictionary<char, int> RomanNumDictionary = new Dictionary<char, int>()
		{
			{ 'I', 1 },
			{ 'V', 5 },
			{ 'X', 10 },
			{ 'L', 50 },
			{ 'C', 100 },
			{ 'D', 500 },
			{ 'M', 1000 }
		};

		public int RomanToInt(string s)
		{
			int sum = 0;
			int checkNumber = 0;

			if (s.Length < 1 || s.Length > 15)
			{
				throw new Exception("Incorrect string length!");
			}

			for (int i = s.Length; i > 0; i--)
			{
				if (checkNumber <= RomanNumDictionary[s[i - 1]])
				{
					checkNumber = RomanNumDictionary[s[i - 1]];
					sum += RomanNumDictionary[s[i - 1]];
				}
				else
				{
					checkNumber = RomanNumDictionary[s[i - 1]];
					sum -= RomanNumDictionary[s[i - 1]];
				}
			}

			return sum;
		}

	}
}
