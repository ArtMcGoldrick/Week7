using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Player
    {
        //Adding constructors
        public readonly int PlayerID;
        public string PlayerName { get; set; }
        public int Score { get; set; }

        //Adding in a list
        public List<Player> Players { get; set; }

        //Linking evreything and intializing
        public Player(int playerID, string playerName, int score)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            Score = score;
        }

        //Increase score of a player
        public void IncreaseScore()
        {
            Score += 1;
        }
    }
       
    }

