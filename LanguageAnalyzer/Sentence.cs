
namespace LanguageAnalyzer
{
    public class Sentence
    {
        public string Raw;
        public string[] Broken;
        public Word[] Words;
        public int Length;
        public Punctuation EndingPunctuation = Punctuation.None;
        public Sentence(string s)
        {
            Raw = s;
            s = s.Trim();
            Broken = s.RemovePunctuation().Split(' ');
            Length = Broken.Length;
            Words = new Word[Broken.Length];
            if (s.EndsWith('!'))
            {
                EndingPunctuation = Punctuation.Exclamation;
            } else if (s.EndsWith('?'))
            {
                EndingPunctuation = Punctuation.Questinon;
            } else if (s.EndsWith('.'))
            {
                EndingPunctuation = Punctuation.Statement;
            }
            for(int i = 0; i < Broken.Length; i ++)
            {
                Word w = new Word(Broken[i]);
                w.WordClassification = Broken[i].ComputeAbstraction();
                Words[i] = w;
            }
        }
    }
}
