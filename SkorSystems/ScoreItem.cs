using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.Class.FileProces
{
    class ScoreItem
    {
       
        public string Name { get; set; }
        public int Score { get; set; }
        public ScoreItem()
        {
            this.Name = "";
        }
        public ScoreItem(String name)
        {
            this.Name = name;
        }
        public ScoreItem(string name,int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
