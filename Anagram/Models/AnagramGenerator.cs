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
        private List<string> _result = new List<string> {};
        private List<List<string>> _sortedResult = new List<List<string>> {};
        private List<List<string>> _splitCharacterCompareList = new List<List<string>> {};
        private List<List<string>> _sortedCompareList = new List<List<string>> {};

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

        public List<List<string>> GetSplitCharacterCompareList()
        {
            return _splitCharacterCompareList;
        }

        public List<List<string>> GetSortedCompareList()
        {
            return _sortedCompareList;
        }

        public List<List<string>> GetSortedResult()
        {
            return _sortedResult;
        }

        public List<string> GetResult()
        {
            return _result;
        }

        public void SplitCompareList()
        {
            string[] separators = {",", " ", "."};
            string[] words = _unbrokenList.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int index = 0; index < words.Length; index ++)
            {
                _compareWords.Add(words[index]);
            }
        }

        public void SplitWordList()
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

        public void SplitCharacterCompareList()
        {
            for (int j = 0; j < _compareWords.Count; j++)
            {
                List<string> splitWord = new List<string> {};
                string[] characters = Regex.Split(_compareWords[j], string.Empty);
                for (int index = 0; index < characters.Length; index ++)
                {
                    if (characters[index] != "")
                    {
                        splitWord.Add(characters[index]);
                    }
                    else
                    {
                    }
                }
                _splitCharacterCompareList.Add(splitWord);
            }
        }

        public void SortCompareList()
        {
            for (int index = 0; index < _splitCharacterCompareList.Count; index++)
            {
                List<string> newList = new List<string> {};
                newList = _splitCharacterCompareList[index];
                newList.Sort();
                _sortedCompareList.Add(newList);
            }
        }

        public void CompareSortedListToSortedWord()
        {
            _wordCharList.Sort();
            for (int index = 0; index < _sortedCompareList.Count; index++)
            {
                if (_wordCharList == _sortedCompareList[index])
                {
                    _result.Add(_compareWords[index]);
                    _sortedResult.Add(_splitCharacterCompareList[index]);
                }
            }
        }

    }
}
