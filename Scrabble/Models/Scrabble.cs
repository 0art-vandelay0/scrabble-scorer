using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleScore
    {
        public string Word { get; set; }
        public int Score { get; set; }

        public ScrabbleScore(string word, int score)
        {
            Word = word;
            Score = score;
        }

    }
}