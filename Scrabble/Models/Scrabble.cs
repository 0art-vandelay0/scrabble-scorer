using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleScore
    {
        public String Word { get; set; }

        public ScrabbleScore(string word)
        {
            Word = word;
        }
    }
}