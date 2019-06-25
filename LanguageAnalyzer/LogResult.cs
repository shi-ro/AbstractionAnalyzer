using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAnalyzer
{
    public enum ResultType
    {
        None,
        Class,
        NewWord
    }

    public class LogResult
    {
        public ResultType ResultType = ResultType.None;
    }

    public class ClassResult : LogResult
    {
        public WordClassification Classification = WordClassification.None;
        public string Word = "";
        public double Value = 0.0;
        public DateTime Time;
        public int Line;
        public ClassResult(string data)
        {
            ResultType = ResultType.Class;
            Time = Convert.ToDateTime(data.Replace("time: ","~").Split('~')[1].Split(',')[0]);
            string d1 = data.Replace("data: ", "~").Split('~')[1];
            if(d1.Contains("class: Abstract"))
            {
                Classification = WordClassification.Abstract;
            }
            else if (d1.Contains("class: Physical"))
            {
                Classification = WordClassification.Physical;
            }
            string d2 = d1.Replace("value: ", "~").Split('~')[1].Split(',')[0];
            try
            {
                Value = Double.Parse(d2);
            } catch { }
            string d3 = d1.Replace("word: ", "~").Split('~')[1].Split(',')[0];
            Word = d3;
            int d4 = Int32.Parse(d1.Replace("line: ", "~").Split('~')[1].Split('}')[0]);
            Line = d4;
        }
    }

    public class NewWordResult : LogResult
    {
        public string Word = "";
        public DateTime Time;
        public NewWordResult(string data)
        {
            ResultType = ResultType.NewWord;
            Time = Convert.ToDateTime(data.Replace("time: ", "~").Split('~')[1].Split(',')[0]);
            string d1 = data.Replace("data: ", "~").Split('~')[1];
            string d3 = d1.Replace("word: ", "~").Split('~')[1].Split(',')[0];
            Word = d3;
        }
    }
}
