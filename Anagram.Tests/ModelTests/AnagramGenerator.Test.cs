using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Test
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void GetInput_ReturnInput()
        {
            //Arrange
            string word = "bread";
            string unbrokenList = "banana mouse";
            AnagramGenerator newAnagramGenerator = new AnagramGenerator(word, unbrokenList);

            //Act
            string newWord = newAnagramGenerator.GetWord();
            string newUnbrokenList = newAnagramGenerator.GetUnbrokenList();

            //Assert
            Assert.AreEqual(word, newWord);
            Assert.AreEqual(newUnbrokenList, unbrokenList);
        }

        [TestMethod]
        public void SeperateString_ReturnNewList()
        {
            //Arrange
            string word = "bread";
            string unbrokenList = "banana mouse";
            List<string> test = new List<string> {"banana", "mouse"};
            AnagramGenerator newAnagramGenerator = new AnagramGenerator(word, unbrokenList);

            //Act
            newAnagramGenerator.SplitCompareList();
            List<string> newList = new List<string> {};
            newList = newAnagramGenerator.GetCompareList();

            //Assert
            CollectionAssert.AreEqual(newList, test);
        }
        [TestMethod]
        public void SplitWordIntoChar_ReturnCharList()
        {
            //Arrange
            string word = "bread";
            string unbrokenList = "banana mouse";
            List<string> charList = new List<string> {"b", "r", "e", "a", "d"};
            AnagramGenerator newAnagramGenerator = new AnagramGenerator (word, unbrokenList);

            //Act
            List<string> newList = new List<string> {};
            newAnagramGenerator.SplitWordList();
            newList = newAnagramGenerator.GetWordCharList();

            //Assert
            CollectionAssert.AreEqual(charList, newList);
        }

        [TestMethod]
        public void SplitListIntoCharLists_ReturnListofCharLists()
        {
            //Arrange
            string word = "bread";
            string unbrokenList = "banana mouse butts";
            List<string> banana = new List<string> {"b", "a", "n", "a", "n", "a"};
            List<string> mouse = new List<string> {"m", "o", "u", "s", "e"};
            List<string> butts = new List<string> {"b", "u", "t", "t", "s"};
            List<List<string>> listOfCharLists = new List<List<string>>() {banana, mouse, butts};
            AnagramGenerator newAnagramGenerator = new AnagramGenerator (word, unbrokenList);
            newAnagramGenerator.SplitCompareList();

            //Act
            List<List<string>> newListofLists = new List<List<string>> {};
            newAnagramGenerator.SplitCharacterCompareList();
            newListofLists = newAnagramGenerator.GetSplitCharacterCompareList();

            //Assert
            for (int index = 0; index < newListofLists.Count; index++)
            {
                CollectionAssert.AreEqual(listOfCharLists[index], newListofLists[index]);
            }
        }

        [TestMethod]
        public void CheckSortedWord()
        {
            List<string> sortedWord = new List<string> {"a", "b", "d", "e", "r"};
            List<string> beard = new List<string> {"b", "e", "a", "r", "d"};
            beard.Sort();

            CollectionAssert.AreEqual(beard, sortedWord);
        }

        [TestMethod]
        public void CompareSplitLists_ReturnMatchingWords()
        {
            //Arrange
            string word = "bread";
            List<string> sortedWord = new List<string> {"a", "b", "d", "e", "r"};
            string unbrokenList = "banana mouse beard";
            List<string> banana = new List<string> {"b", "a", "n", "a", "n", "a"};
            List<string> mouse = new List<string> {"m", "o", "u", "s", "e"};
            List<string> beard = new List<string> {"b", "e", "a", "r", "d"};
            List<List<string>> listOfCharLists = new List<List<string>>() {banana, mouse, beard};
            AnagramGenerator newAnagramGenerator = new AnagramGenerator (word, unbrokenList);
            List<List<string>> newListofLists = new List<List<string>> {};
            newAnagramGenerator.SplitCompareList();
            newAnagramGenerator.SplitCharacterCompareList();

            newAnagramGenerator.SplitWordList();

            //Act
            List<string> sortedWordChar = new List<string> {};
            sortedWordChar = newAnagramGenerator.GetWordCharList();
            sortedWordChar.Sort();
            newAnagramGenerator.SortCompareList();
            newAnagramGenerator.CompareSortedListToSortedWord();
            newListofLists = newAnagramGenerator.GetResult();

            //Assert
            for (int index = 0; index < newListofLists.Count; index++)
            {
                CollectionAssert.AreEqual(sortedWordChar, newListofLists[index]);
            }
        }
    }
}
