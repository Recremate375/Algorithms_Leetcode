namespace Algorithms
{
    public class LongestSubstringWithoutRepeatinCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> symbolPosition = new Dictionary<char, int>();
            int left = 0;
            int maxlength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char symbol = s[right];

                if (symbolPosition.ContainsKey(symbol) && symbolPosition[symbol] >= left)
                {
                    left = symbolPosition[symbol] + 1;
                }

                symbolPosition[symbol] = right;

                int currentLenght = right - left + 1;
                if (currentLenght > maxlength)
                {
                    maxlength = currentLenght;
                }
            }

            return maxlength;
        }
    }
}
