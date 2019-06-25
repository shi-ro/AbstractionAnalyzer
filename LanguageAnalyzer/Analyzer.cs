using AForge.Neuro;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAnalyzer
{
    public static class Analyzer
    {
        public static ActivationNetwork RunRoots(string input, string output)
        {
            List<string> ip = new List<string>();
            List<string> op = new List<string>();
            Console.WriteLine("\tReading files ...");
            System.IO.StreamReader file = new System.IO.StreamReader(input);
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                ip.Add(line);
            }
            file.Close();
            System.IO.StreamReader file2 = new System.IO.StreamReader(output);
            line = "";
            while ((line = file2.ReadLine()) != null)
            {
                op.Add(line);
            }
            file2.Close();
            Console.WriteLine("\tFinished reading.\n\tTranslating to data ...");
            double[][] newIn = new double[ip.Count][];
            double[][] newOut = new double[op.Count][];

            for(int i = 0; i < ip.Count; i++)
            {
                newIn[i] = RootBreaker.BreakWord(ip[i]).SignificantRoots(2).GetVals();
                string s = "[ ";

                for (int j = 0; j < newIn[i].Length; j++)
                {
                    s += $"{newIn[i][j]} ";
                }
                s += "]";
                Console.WriteLine($"\t{ip[i]} : {s}");
            }

            //train root from C:\Users\usagi\Desktop\Books\Roots\Input.txt C:\Users\usagi\Desktop\Books\Roots\Output.txt

            for (int i = 0; i < ip.Count; i++)
            {
                newOut[i] = new double[] { Int32.Parse(op[i]) };
            }

            Console.WriteLine("\tFinished translating.\n\tTraining ...\n");
            ActivationNetwork net = Neural.RunBackPropogation(newIn, newOut, 20000000);
            Console.WriteLine("\tFinished training.");

            return net;
        }
    }
}
