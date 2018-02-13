using System.Collections.Generic;
using System;

namespace Anagram.Models
{
    public class AnagramGenerator
    {
        private string _word;
        private string _unbrokenList;
        private List<string> _compareWords = new List<string> {};

        public AnagramGenerator(string newWord, string newUnbrokenList)
        {
            _word = newWord;
            _unbrokenList = newUnbrokenList;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetUnbrokenList()
        {
            return _unbrokenList;
        }

        public List<string> GetList()
        {
            return _compareWords;
        }

        public void BreakString()
        {
            string[] separators = {",", " ", "."};
            string[] words = _unbrokenList.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int index = 0; index < words.Length; index ++)
            {
                _compareWords.Add(words[index]);
            }
            Console.WriteLine(_compareWords);
        }
    }
}
