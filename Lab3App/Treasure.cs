using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure:Collectable
    {
        public int Score { get; private set; }

        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public void updateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            updateTotalScore();
        }
    }
}
