using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Scrabble.Models
{
    public class ScrabbleScore
    {
        public string InputWord { get; set; }
        public int Score { get; set; }
        public List<string> ScoreDetails;

        public ScrabbleScore()
        {
            InputWord = "";
            Score = 0;
            ScoreDetails = new List<string>{};
        }

        public bool GetWord(string inputWord)
        {
            if (inputWord != null)
            {
                InputWord = inputWord;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckWord(string input)
        {
            bool outcome = Regex.IsMatch(input, @"^[a-zA-Z]+$");
            return outcome;
        }

        public int GetScore(string input)
        {
            for (int i=0; i<input.Length; i++)
            {
                if ("a, e, i, o, u, l, n, r, s, t".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 1");
                    Score += 1;
                }
                else if ("d, g".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 2");
                    Score += 2;
                }
                else if ("b, c, m, p".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 3");
                    Score += 3;
                }
                else if ("f, h, v, w, y".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 4");
                    Score += 4;
                }
                else if ("k".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 5");
                    Score += 5;
                }
                else if ("j, x".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 8");
                    Score += 8;
                }
                else if ("q, z".Contains(input[i]))
                {
                    ScoreDetails.Add(input[i] + " = 10");
                    Score += 10;
                }
            }
            return Score;
        }
    }
}