using System.Text;

namespace Algorithms
{
    public class LongestPrefix
    {
        public string FindLongestPrefix(string[] strings)
        {
            string prefix = "";
            
            for(int j = 0; j < strings[0].Length; j++)
            {
                char letter = strings[0][j];

                for (int i = 1; i < strings.Length; i++)
                {
                    if (strings[i].Length == 0 || j + 1 > strings[i].Length || letter != strings[i][j])
                    {
                        if (prefix.Length == 0)
                        {
                            return prefix;
                        }

                        return prefix;
                    }
                }

                prefix += letter;
            }

            return prefix;
        }


        public string SecondMethod(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            Array.Sort(strs);

            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }

            string first = strs[0], last = strs[strs.Length - 1];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < first.Length; i++)
            {
                if (i < last.Length && first[i] == last[i])
                {
                    result.Append(first[i]);
                }
                else
                {
                    break;
                }
            }
            return result.ToString();
        }
    }
}
