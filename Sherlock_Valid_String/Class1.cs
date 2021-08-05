using System;
using System.Collections.Generic;

namespace Sherlock_Valid_String
{
    public class Valid_String
    {
        public static string isValid(string s)
        {
            char[] str = s.ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                {

                    dict.Add(c, 1);

                }
                else if (dict[c] < 2)
                {

                    //return "YES";
                    dict[c]++;

                }

            }
            string result = String.Empty;


            foreach (int c in dict.Values)
            {

                if (c > 2)
                {

                    result = "NO";
                    break;

                }
                result = "YES";
            }

            return result;

        }

    }
}
