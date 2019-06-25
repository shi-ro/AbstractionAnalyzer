using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LanguageAnalyzer
{
    public static class SentenceBreaker
    {
        public static List<List<Sentence>> BreakString(string s)
        {
            List<List<Sentence>> ret = new List<List<Sentence>>();
            string[] sentences = Regex.Split(s, @"(?<=[\.!\?])\s+");

            foreach (string sentence in sentences)
            {
                ret.Add(BreakSentence(new Sentence(sentence)));
            }
            return ret;
        }
        public static List<Sentence> BreakSentence(Sentence s)
        {
            List<Sentence> li = new List<Sentence>();
            if(s.Length<=3)
            {
                li.Add(s);
            } else
            {
                for( int i=0;i<s.Length-3;i++)
                {
                    string sen = "";
                    for(int j=i;j<i+3;j++)
                    {
                        sen += " " + s.Broken[j];
                    }
                    sen = sen.Trim();
                    li.Add(new Sentence(sen));
                }
            }
            return li;
        }
    }
}
