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
        private List<List<string>> _splitCompareList = new List<List<string>> {};

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

        public List<List<string>> GetSplitCompareList()
        {
            return _splitCompareList;
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

        public void SplitCompareList()
        {
            // for (int j = 0; j < _compareWords.Count; j++)
            // {
            //     List<string> splitWord = new List<string> {};
            //     string[] characters = Regex.Split(_word, string.Empty);
            //     for (int index = 0; index < characters.Length; index ++)
            //     {
            //         if (characters[index] != "")
            //         {
            //             _splitWord.Add(characters[index]);
            //         }
            //         else
            //         {
            //         }
            //     }
            //     _splitCompareList.Add(splitWord);
            // }
            List<string> dumb = new List<string> {"d", "u", "m", "b"};
            List<string> mouse = new List<string> {"m", "o", "u", "s", "e"};
            List<string> butts = new List<string> {"b", "u", "t", "t", "s"};
            List<List<string>> listLists = new List<List<string>> {dumb, mouse, butts};
            _splitCompareList = listLists;
        }
    }
}
