using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilotApp
{
    public class Player
    {
        private string name;
        private int score;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}
