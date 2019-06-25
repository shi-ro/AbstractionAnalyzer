using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAnalyzer
{
    public class Word
    {
        public string Isolation { get; private set; }
        public string Literal { get; private set; }
        public WordType WordType { get; private set; }
        public WordClassification WordClassification { get; set; }
        public List<Word> Synonyms = new List<Word>();

        public Word(string word)
        {
            WordClassification = WordClassification.None;
            Literal = word;
            word = word.Replace(":", "").Replace("?", "").Replace("_", "").Replace("!", "").Replace(".", "").ToLower().Replace("\"", "").Replace("\\", "").Replace("/", "").Replace(",", "");
            Isolation = word;
            if(GlobalCache.WordCache.ContainsKey(Isolation))
            {
                Word w = GlobalCache.WordCache[Isolation];
                WordType = w.WordType;
            } else
            {
                try
                {
                    string w = WebInteractive.GetPageContents(@"https://www.dictionary.com/browse/" + word);
                    string[] bk = w.Split(new string[] { "<span class=\"luna-pos\">" }, StringSplitOptions.None);
                    if (bk.Length < 2)
                    {
                        WordType = WordType.None;
                        return;
                    }
                    string type = bk[1].Split(new string[] { "</span>" }, StringSplitOptions.None)[0].Replace(",", "").Replace(";", "").ToLower();
                    switch (type)
                    {
                        case "definite article":
                            WordType = WordType.DefiniteArticle;
                            break;
                        case "noun adjective":
                        case "noun":
                            WordType = WordType.Noun;
                            break;
                        case "verb (used without object)":
                        case "verb (used with object)":
                        case "auxiliary verb":
                        case "verb":
                            WordType = WordType.Verb;
                            break;
                        case "interjection":
                            WordType = WordType.Interjection;
                            break;
                        case "adjective":
                            WordType = WordType.Adjective;
                            break;
                        case "adverb":
                            WordType = WordType.Adverb;
                            break;
                        case "pronoun":
                            WordType = WordType.Pronoun;
                            break;
                        case "preposition":
                            WordType = WordType.Preposition;
                            break;
                        case "conjunction":
                        case "connective":
                            WordType = WordType.Adjective;
                            break;
                        default:
                            WordType = WordType.None;
                            break;
                    }
                    if (WordType == WordType.None)
                    {
                        Console.WriteLine(Isolation + " - " + type);
                    }
                    GlobalCache.WordCache.Add(Isolation, this);
                    GlobalCache.LogAction("new-word", $"word: {Isolation}, type: {WordType}");
                    //Console.WriteLine($"\tcached: [{Isolation}, {WordType}]");
                }
                catch
                {

                }
            }
        }

        public void LoadSynonyms()
        {
            string w = WebInteractive.GetPageContents(@"https://www.thesaurus.com/browse/" + Isolation);
            string[] bk = w.Split(new string[] { "synonyms-container" }, StringSplitOptions.None);
            string block = bk[1].Split(new string[] { "</section>" }, StringSplitOptions.None)[0];
            string[] syns = block.Split(new string[] { "<a " }, StringSplitOptions.None);
            for(int i = 0; i < syns.Length; i++)
            {
                string syn = syns[i].Split( new string[] { "\">" }, StringSplitOptions.None)[1];
                string synonym = syn.Split(new string[] { "</a>" }, StringSplitOptions.None)[0];
                Word word = new Word(synonym);
                Synonyms.Add(word);
            }
        }
    } 
}
