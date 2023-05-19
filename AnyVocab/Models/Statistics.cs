using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyVocab.Models
{
    public class Statistics
    {
        private int totalGuessed;
        private int guessedCorrectly;

        public Statistics()
        {
            totalGuessed = 0;
            guessedCorrectly = 0;
        }

        public void trackCorrect()
        {
            guessedCorrectly++;
            totalGuessed++;
        }

        public void trackIncorrect()
        {
            totalGuessed++;
        }

        public double getPercentage()
        {
            return (double)guessedCorrectly / totalGuessed;
        }

    }
}
