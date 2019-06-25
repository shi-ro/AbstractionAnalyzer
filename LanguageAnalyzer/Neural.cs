using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAnalyzer
{
    public static class Neural
    {
        public static ActivationNetwork RunBackPropogation(double[][] input, double[][] output, int epochAmmount)
        {
            ActivationNetwork network = new ActivationNetwork(new SigmoidFunction(2), 2, 2, 1);
            BackPropagationLearning teacher = new BackPropagationLearning(network);
            double error = Int32.MaxValue;
            int counter = 0;
            while (counter<epochAmmount)
            {
                error = teacher.RunEpoch(input, output);
                if (counter % 1000000 == 0)
                {
                    Console.WriteLine($"\t[{error}]");
                }
                counter++;
            }
            return network;
        }

        public static ActivationNetwork RunBackPropogation(double[][] input, double[][] output, double expectedErrorLevel)
        {
            ActivationNetwork network = new ActivationNetwork( new SigmoidFunction(2), 2, 2, 1);
            BackPropagationLearning teacher = new BackPropagationLearning(network);
            double error = Int32.MaxValue;
            int counter = 0;
            while (error > Math.Pow(0.1, expectedErrorLevel))
            {
                error = teacher.RunEpoch(input, output);
                if(counter%500000==0)
                {
                    Console.WriteLine($"\t[{error}]");
                }
                counter ++;
            }
            return network;
        }
    }
}
