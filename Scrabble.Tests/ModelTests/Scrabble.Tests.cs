using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests.ModelTests
{
    [TestClass]
    public class ScrabbleTests
    {

        [TestMethod]
        public void ScrabbleScoreConstructor_CreatesInstanceOfScrabbleScore_ScrabbleScore()
        {
            string word = "testword";
            int score = 0;
            ScrabbleScore scrabbleScore = new ScrabbleScore(word, score);
            Assert.AreEqual(typeof(ScrabbleScore), scrabbleScore.GetType());

        }

        [TestMethod]
        public void ScrabbleScoreConstructor_CreatesInstanceOfScrabbleScoreWithParameter_ScrabbleScore()
        {
            string word = "testword";
            int score = 0;
            ScrabbleScore scrabbleScore = new ScrabbleScore(word, score);
            Assert.AreEqual(word, scrabbleScore.Word);
            Assert.AreEqual(score, scrabbleScore.Score);
        }

    }
}