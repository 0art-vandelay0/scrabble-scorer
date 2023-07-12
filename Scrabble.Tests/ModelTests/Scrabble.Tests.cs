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
            ScrabbleScore score = new ScrabbleScore("testword");
            Assert.AreEqual(typeof(ScrabbleScore), score.GetType());
        }

    }
}