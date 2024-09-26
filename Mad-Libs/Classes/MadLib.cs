using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mad_Libs_App.Classes
{
    internal class MadLib
    {
        public List<Word> WordList { get; set; }

        private string Story { get; set; } = string.Empty;
        public string FinishedStory {  get; set; } = string.Empty;
        public int index { get; set; } = 0;

        public MadLib(string str) 
        {
            Story = str;
            Load();
        }
        public Word Next()
        {
            Word? word = null;
            if (WordList.Count > 0 && index < WordList.Count)
            {
                word = WordList[index];
                index++;
            }
            //return next word
            return word;
        }
        public void Load()
        {
            //create wordlist
            if (WordList == null) { WordList = new List<Word>(); }
            if (Story == string.Empty) { return; }
            foreach (string word in Story.ToLower().Split(' '))
            {
                if (word.Contains('['))
                {
                    //use all types in examples to determine the bracketed word is valid
                    foreach (string type in Word.Examples.Keys)
                    {
                        if (word.Contains($"[{type}]"))
                        {
                            WordList.Add(new Word(word,type));
                            break;
                        }
                    }
                }
            }
        }

        public void Finish()
        {
            //creates finished story
            //add or remove from array to change what will stay when [word] is replaced
            char[] puncEnd = {'.',',',':',';','?','!',')'};
            char[] puncStart = { '"', '\'', '(' };
            string[] words = Story.Split(' ');
            FinishedStory = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (WordList.Count > 0)
                {
                    //looping through story in the same order as we created wordlist, so the oldest will always be at zero.
                    if (words[i].Contains($"[{WordList[0].Type}]"))
                    {
                        string suffix = "", prefix = "";
                        string str = words[i];

                        //beginning punc.
                        if (!str.StartsWith('['))
                        {
                            int begin = str.IndexOf('[');
                            foreach (char c in str.Substring(0,begin-1))
                            {
                                if (puncStart.Contains(c)) { prefix += c; }
                            }
                        }
                        //end punc.
                        if (!str.EndsWith(']'))
                        {
                            int end = str.IndexOf(']');
                            foreach (char c in str.Substring(end-1))
                            {
                                if (puncEnd.Contains(c)) { suffix += c; }
                            }
                        }
                        //capitialize
                        if (i > 0)
                        {
                            if (Regex.IsMatch(words[i-1], @"[?!\.]"))
                            {
                                string r = WordList[0].Replace;
                                WordList[0].Replace = Char.ToUpper(r[0]).ToString() + r.Substring(1); 
                            }
                        }
                        else
                        {
                            string r = WordList[0].Replace;
                            WordList[0].Replace = Char.ToUpper(r[0]).ToString() + r.Substring(1);
                        }
                        //pop
                        words[i] = prefix + WordList[0].Replace + suffix;
                        WordList.RemoveAt(0);
                    }
                }
                FinishedStory += $"{words[i]} " ;
            }
        }
    } 
}
