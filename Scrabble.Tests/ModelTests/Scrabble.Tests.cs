using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Test
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void GetWord_ReceiveInput_true()
        {
            ScrabbleScore newScore = new ScrabbleScore();
            bool outcome = newScore.GetWord("word");
            Assert.AreEqual(true, outcome);
        }

        [TestMethod]
        public void CheckWord_ReceiveLettersOnly_true()
        {
            ScrabbleScore newScore = new ScrabbleScore();
            bool outcome = newScore.CheckWord("word");
            Assert.AreEqual(true, outcome);
        }

        [TestMethod]
        public void GetScore_ReceiveTotalScore_score()
        {
            ScrabbleScore newScore = new ScrabbleScore();
            int totalScore = newScore.GetScore("word");
            Assert.AreEqual(8, totalScore);
        }
    }
}