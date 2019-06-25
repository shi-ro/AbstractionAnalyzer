using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LanguageAnalyzer
{
    public static class GlobalCache
    {
        public static Dictionary<string, Word> WordCache = new Dictionary<string, Word>();
        public static void LogAction(string type, string data)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Action a = new Action(type, data);
                w.WriteLine(a.ToString());
                Console.WriteLine($"log <- \t{type} - {data}");
            }
        }
    }
}
