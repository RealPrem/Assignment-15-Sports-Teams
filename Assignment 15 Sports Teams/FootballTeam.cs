using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_Teams
{
    class FootballTeam : Team
    {
        private int TotalGoals;
        private int TotalRedCards;
        public FootballTeam()
        {

        }
        public double GetAverageRedCards()
        {
            double Average;
            Average = (  (double) TotalRedCards / TotalGames);
            return Average;
        }
        public double GetAverageGoals()
        {
            double Average;
            Average = ((double)TotalGoals / TotalGames);
            return Average;
        }
        public void AddGame(string Result, int Goals, int RedCards)
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
            TotalGoals += Goals;
            TotalRedCards += RedCards;
        }
    }
}
