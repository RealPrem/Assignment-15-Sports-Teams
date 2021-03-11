using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_Teams
{
    class Team
    {
        protected string Name;
        protected int TotalGames;
        protected int GamesWon;
        protected int GamesLost;

        public double GetPercentWin()
        {
            double Percent;
            Percent = ( (double) GamesWon / TotalGames ) * 100;
            return Percent;
        }
        public void Win()
        {
            GamesWon += 1;
            TotalGames += 1;
        }
        public void Lose()
        {
            GamesLost += 1;
            TotalGames += 1;
        }
        public void AddGame(string Result)
        {
            if (Result == "W")
            {
                GamesWon += 1;
            }
            else if (Result == "L")
            {
                GamesLost += 1;
            }
            TotalGames += 1;
        }
        public void GetStats()
        {
            Console.WriteLine("{0} {1} {2}", "GamesWon" , "GamesLoss" , "TotalGames");
            Console.WriteLine("{0,4} {1,9} {2,9}", GamesWon, GamesLost, TotalGames);
        }
    }
}
