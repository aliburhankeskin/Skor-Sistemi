using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.Class.FileProces
{
    class ScoreService
    {
        public ScoreItem CreateScoreItemNew(String Name)
        {
            ScoreItem score = new ScoreItem(Name);
            return score;
        }
        public ScoreItem CreateScoreItemNew(String Name,int Score)
        {
            ScoreItem score = new ScoreItem(Name, Score);
            return score;
        }
    }
}
