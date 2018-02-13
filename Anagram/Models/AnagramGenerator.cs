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

        // public void SetCompareWords(string unbrokenList)
        // {
        //
        // }
    }
}
