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

        public static int GetScore(string word)
        {
            int score = 0;
            Dictionary<char, int> letterScores = new Dictionary<char, int>()
            {
                {'a', 1}, {'e', 1}, {'i', 1},
                {'o', 1}, {'u', 1}, {'l', 1},
                {'n', 1}, {'r', 1}, {'s', 1}, {'t', 1},
                {'d', 2}, {'g', 2},
                {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3},
                {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4},
                {'k', 5},
                {'j', 8}, {'x', 8},
                {'q', 10}, {'z', 10}
            };
            foreach (char letter in word)
            {
                score += letterScores[letter];
            }
            return score;
        }

    }
}