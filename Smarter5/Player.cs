using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarter5
{
    class Player
    {
        private string name;
        private int score;

        public Player() { }

        public Player(string name, int score) {
            this.name = name;
            this.score = score;
        }


        public string getName() {
            return name;
        }

        public void setName(string value) {
            name = value;
        }

        public int getScore() {
            return score;
        }

        public void setScore(int value) {
            score = value;
        }











        public void calcScore(int score) {

            int pastScore = getScore();
            int newScore = pastScore + score;

            setScore(newScore);
        }

    }
}
