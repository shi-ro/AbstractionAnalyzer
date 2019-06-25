using AForge.Neuro;

namespace LanguageAnalyzer
{
    public static class GlobalNetworks
    {
        private static ActivationNetwork _rootsNetwork { get; set; }
        public const string ROOTS_IN = @"C:\Users\usagi\Desktop\Books\Roots\Input.txt";
        public const string ROOTS_OUT = @"C:\Users\usagi\Desktop\Books\Roots\Output.txt";

        public static ActivationNetwork GetRootsNetwork()
        {
            bool load = false;
            if (_rootsNetwork == null)
            { 
                try
                {
                    _rootsNetwork = (ActivationNetwork)Network.Load("SAVED_RootNetwork");
                    load = true;
                } catch { }
                if(!load)
                {
                    _rootsNetwork = Analyzer.RunRoots(ROOTS_IN, ROOTS_OUT);
                    _rootsNetwork.Save("SAVED_RootNetwork");
                }
            }
            return _rootsNetwork;
        }
    }
}
