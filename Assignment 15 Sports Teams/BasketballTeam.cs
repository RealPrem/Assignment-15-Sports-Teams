using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_Teams
{
    class BasketballTeam : Team
    {
        private int TotalPoints;
        private int TotalBlocks;
        private int TotalSteals;
        public BasketballTeam()
        {

        }
        public void AddGame(string Result, int Points, int Blocks, int Steals)
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
            TotalPoints += Points;
            TotalBlocks += Blocks;
            TotalSteals += Steals;
        }
        public double GetAveragePoints()
        {
            double Average;
            Average = ((double)TotalPoints / TotalGames);
            return Average;
        }
        public double GetAverageBlocks()
        {
            double Average;
            Average = ((double)TotalBlocks / TotalGames);
            return Average;
        }
        public double GetAverageSteals()
        {
            double Average;
            Average = ((double)TotalSteals / TotalGames);
            return Average;
        }

    }
}
