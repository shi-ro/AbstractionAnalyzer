using AForge.Neuro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace LanguageAnalyzer
{

    class Program
    {
        private static ActivationNetwork TrainedNetwork = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Initiating analyzer ...");
            string input = "";
            while (input != "exit")
            {
                input = Console.ReadLine();
                RunCommand(input);
            }
        }

        private static void RunCommand(string cmd)
        {
            cmd = cmd.ToLower();
            if (cmd.StartsWith("run! "))
            {
                cmd = cmd.Replace("run! ", "");
                if (TrainedNetwork != null)
                {
                    Console.WriteLine("\t" + TrainedNetwork.Compute(RootBreaker.BreakWord(cmd).SignificantRoots(2).GetVals())[0]);
                    Console.WriteLine("");
                }
            }
            else if (cmd.StartsWith("graph "))
            {
                cmd = cmd.Replace("graph ", "");
                var lineCount = File.ReadAllLines(cmd).Length;
                StreamReader file = new StreamReader(cmd);
                string line = "";
                List<LogResult> results = new List<LogResult>();
                int maxLine = 0;
                Dictionary<int, double[]> initial = new Dictionary<int, double[]>();
                while ((line = file.ReadLine()) != null)
                {
                    if(line.Contains("type: new-word"))
                    {
                        NewWordResult res = new NewWordResult(line);
                        results.Add(res);
                    }
                    else if(line.Contains("type: abstraction"))
                    {
                        ClassResult res = new ClassResult(line);
                        if(initial.ContainsKey(res.Line))
                        {
                            initial[res.Line] = new double[] { initial[res.Line][0]+res.Value, initial[res.Line][1]+1};
                        } else
                        {
                            initial.Add(res.Line, new double[] { res.Value, 1 });
                        }
                        results.Add(res);
                    }
                }
                double[] classResults = new double[20000]; 
                foreach (KeyValuePair<int, double[]> e in initial)
                {
                    classResults[e.Key] = ( e.Value[0] / e.Value[1] );
                }
                for (int i = 0; i < classResults.Length; i++)
                {
                    Console.WriteLine(classResults[i]);
                }
            }
            else if (cmd.StartsWith("read "))
            {
                cmd = cmd.Replace("read ", "");
                StreamReader file = new StreamReader(cmd);
                string line = "";
                Queue<string> readQueue = new Queue<string>();
                Queue<Sentence> sentences = new Queue<Sentence>();
                int lineNum = 0;
                while ((line = file.ReadLine()) != null)
                {
                    // remove not needed words
                    line = line.Replace(" the ", " ").Replace(" an ", " ").Replace(" a ", " ");
                    string[] words = line.Split(' ');

                    int i = 0;
                    for (i = 0; i < words.Length; i++)
                    {
                        Word w = new Word(words[i]);
                        // check abstraction only for nouns
                        if (w.WordType == WordType.Noun)
                        {
                            double d = GlobalNetworks.GetRootsNetwork().Compute(RootBreaker.BreakWord(w.Isolation).SignificantRoots(2).GetVals())[0];
                            WordClassification cl = d > 0.5 ? WordClassification.Abstract : WordClassification.Physical;
                            GlobalCache.LogAction("abstraction", $"class: {cl}, value: {d}, word: {w.Isolation}, line: {lineNum}");
                        }
                    }
                    i = 0;
                    while (i < words.Length)
                    {
                        string word = words[i];
                        readQueue.Enqueue(word);
                        if (word.Contains(".") || word.Contains("?") || word.Contains("!"))
                        {
                            // empty queue into sentance
                            string all = "";
                            while (readQueue.Count > 0)
                            {
                                all += " " + readQueue.Dequeue();
                            }
                            all = all.Trim();
                            Sentence s = new Sentence(all);
                            Console.WriteLine("\n\t > " + s.Raw);
                            sentences.Enqueue(s);
                            if (sentences.Count > 50)
                            {
                                Sentence sen = sentences.Dequeue();
                                List<Sentence> sens = SentenceBreaker.BreakSentence(sen);
                                // pass sentances into context analyzer
                            }
                        }
                        i++;
                    }
                    lineNum++;
                }

                file.Close();

            }
            else if (cmd.StartsWith("train "))
            {
                cmd = cmd.Replace("train ", "");
                if (cmd.StartsWith("root from "))
                {
                    cmd = cmd.Replace("root from ", "");
                    string[] args = cmd.Split(' ');
                    if (args.Length > 1)
                    {
                        string input = args[0];
                        string output = args[1];
                        Console.WriteLine(">> training roots\n");
                        ActivationNetwork an = Analyzer.RunRoots(input, output);
                        Console.WriteLine(">> finished training roots\n");
                        TrainedNetwork = an;
                    }
                }
            }
            else if (cmd.StartsWith("test "))
            {
                cmd = cmd.Replace("test ", "");
                if (cmd.StartsWith("sen "))
                {
                    cmd = cmd.Replace("sen ", "");
                    List<List<Sentence>> s = SentenceBreaker.BreakString(cmd);
                    foreach (List<Sentence> list in s)
                    {
                        Console.WriteLine("\n\t> " + list);
                        foreach (Sentence sen in list)
                        {
                            Console.WriteLine($"\t - {sen.Raw}");
                        }
                    }
                }
                else if (cmd.StartsWith("syn "))
                {
                    cmd = cmd.Replace("syn ", "");
                    Word w = new Word(cmd);
                    w.LoadSynonyms();
                }
                else if (cmd == "backpropogation" || cmd == "bp")
                {
                    double[][] input = new double[4][] {
                        new double[] {0, 0}, new double[] {0, 1},
                        new double[] {1, 0}, new double[] {1, 1}
                    };
                    double[][] output = new double[4][] {
                        new double[] {0}, new double[] {1},
                        new double[] {1}, new double[] {0}
                    };

                    Console.WriteLine(">> testing back-propogation\n");
                    ActivationNetwork net = Neural.RunBackPropogation(input, output, 6);
                    Console.WriteLine($"\n>> test results:\n" +
                        $"\n[0,0]\t{net.Compute(new double[] { 0, 0 })[0]}" +
                        $"\n[0,1]\t{net.Compute(new double[] { 0, 1 })[0]}" +
                        $"\n[1,0]\t{net.Compute(new double[] { 1, 0 })[0]}" +
                        $"\n[1,1]\t{net.Compute(new double[] { 1, 1 })[0]}");
                }
            }
        }
    }
}
