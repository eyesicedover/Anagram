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
            newAnagramGenerator.BreakString();
            List<string> newList = new List<string> {};
            newList = newAnagramGenerator.GetCompareList();

            //Assert
            CollectionAssert.AreEqual(newList, test);
        }
        [TestMethod]
        public void BreakWordIntoChar_ReturnCharList()
        {
            //Arrange
            string word = "bread";
            string unbrokenList = "banana mouse";
            List<string> charList = new List<string> {"b", "r", "e", "a", "d"};
            AnagramGenerator newAnagramGenerator = new AnagramGenerator (word, unbrokenList);

            //Act
            List<string> newList = new List<string> {};
            newAnagramGenerator.CreateCharList();
            newList = newAnagramGenerator.GetWordCharList();

            //Assert
            CollectionAssert.AreEqual(charList, newList);
        }
    }
}
