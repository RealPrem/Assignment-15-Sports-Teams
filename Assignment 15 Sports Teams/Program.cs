using System;

namespace Assignment_15_Sports_Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Team Team = new Team();
            Team.Win();
            Console.WriteLine(Team.GetPercentWin() + "%");
            Team.Loss();
            Console.WriteLine(Team.GetPercentWin() + "%");
            Team.Win();
            Console.WriteLine(Team.GetPercentWin() + "%");
            Team.GetStats();
            */

            FootballTeam FootBallTeam = new FootballTeam();
            FootBallTeam.AddGame("W", 2, 4);
            Console.WriteLine(FootBallTeam.GetAverageGoals());
            FootBallTeam.AddGame("L", 2, 2);
            Console.WriteLine(FootBallTeam.GetAverageGoals());

            BasketballTeam BasketballTeam = new BasketballTeam();
            BasketballTeam.AddGame("W", 2, 2, 2);
            Console.WriteLine(BasketballTeam.GetAveragePoints());
            BasketballTeam.AddGame("L", 4, 2, 2);
            Console.WriteLine(BasketballTeam.GetAveragePoints());
        }
    }
}
