using System;
using System.Collections.Generic;

namespace Sherlock_Valid_String
{
    public class Valid_String
    {
        public static string isValid(string s)
        {
            bool IsValid = false;
        if(!string.IsNullOrEmpty(s))
        {
            //convert string to char array
            char[] InputChars = s.ToCharArray();

            //create a dictionary to hold char and count of occurence
            Dictionary<char, int> dict = new Dictionary<char, int>();

            //Add characters to dict and if char exist incerement occurence
            foreach(char c in InputChars)
            {
                if(dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c,1);
            }

            int counter = 0;
            isValid = true;

            KeyValuePair<char, int> firstItem = dict.First();

            //traverse chars in dictionary
            foreach(KeyValuePair<char, int> items in dict)
            {
                //if count of occurence is not equal to the other occurence values
                if(firstItem.Value != items.Value)
                {
                    if(counter >= 1 )
                    {
                         isValid = false;
                        break;
                    }
                   counter++;
                }
            }
        }
        if(isValid)
            return "YES";
        else
            return "NO"

        }

    }
}
