using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating List of player
            List<Player> players = new List<Player>();

            //Creating objects
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            //Adding players to the list
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

            //Looping asking for player number
            Console.Write("Please enter player number : ");
            string response = Console.ReadLine();
            int playerNumber = int.Parse(response);
            //Loop for player selected
            while (playerNumber != 0)
            {
                //Determine player selected
                Player selectedPlayer = players.ElementAt(playerNumber);
                //Increase score for that player
                selectedPlayer.IncreaseScore();
                //Display results
                Display(players);
                //Ask for another player
                Console.WriteLine("Please enter player number : ");
                response = Console.ReadLine();
                playerNumber = int.Parse(response);
            }
        }
        //A method used for displaying players scores
        static void Display(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "PLAYER 1","PLAYER 2","PLAYER 3","PLAYER 4","PLAYER 5");
            foreach (Player player in players)
            {
                Console.Write("{0-10}", player.Score);
            }
        }
    }
}
