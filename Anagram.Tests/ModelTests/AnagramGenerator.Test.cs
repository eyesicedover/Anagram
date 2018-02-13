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
    }
}
