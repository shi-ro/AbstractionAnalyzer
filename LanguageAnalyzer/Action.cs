using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAnalyzer
{
    public class Action
    {
        string RawType;
        string Data;
        DateTime TimeStamp;
        public Action(string type, string data)
        {
            RawType = type;
            Data = data;
            TimeStamp = DateTime.Now;
        }

        public string ToString()
        {
            return $"{{ time: {TimeStamp} ,type: {RawType}, data: {{{Data}}} }}";
        }
    }
}
