using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class StringReverse
    {
        public static string StringReverseSoln(string s)
        {
            IList<string> words = new List<string>();
            int start=0;
            for (int index = 0; index <= s.Length; index++)
            {
                if (index == s.Length || s[index] == ' ')
                {
                    string word = s.Substring(start, index-start);
                    words.Add(word);
                    start = index + 1;
                }
            }
            IList<string> revWords = new List<string>();
            foreach (string word in words)
            {
                char[] revChar = new char[word.Length];
                int index = 0, end = revChar.Length-1;
                do
                {
                    char left = word[index];
                    revChar.SetValue(left,end);
                    index++;
                    end--;
                } while (index < word.Length);
                string revWord = string.Join("",revChar);
                revWords.Add(revWord);
            }
            string revString = string.Join(" ", revWords);
            return revString;
        }
    }
}
