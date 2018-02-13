using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Anagram.Models
{
    public class AnagramGenerator
    {
        private string _word;
        private string _unbrokenList;
        private List<string> _compareWords = new List<string> {};
        private List<string> _wordCharList = new List<string> {};

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

        public List<string> GetCompareList()
        {
            return _compareWords;
        }

        public List<string> GetWordCharList()
        {
            return _wordCharList;
        }

        public void BreakString()
        {
            string[] separators = {",", " ", "."};
            string[] words = _unbrokenList.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int index = 0; index < words.Length; index ++)
            {
                _compareWords.Add(words[index]);
            }
        }

        public void CreateCharList()
        {
            string[] characters = Regex.Split(_word, string.Empty);
            for (int index = 0; index < characters.Length; index ++)
            {
                if (characters[index] != "")
                {
                _wordCharList.Add(characters[index]);
                }
                else
                {

                }
            }
        }
    }
}
