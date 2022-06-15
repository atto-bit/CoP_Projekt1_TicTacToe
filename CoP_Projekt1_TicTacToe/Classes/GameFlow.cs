using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP_Projekt1_TicTacToe.Classes
{

    // Rename in GameController
    public class GameFlow
    {
        public Player CurrentPlayer { get; set; }
        public MatchField MatchField { get; set; }
        public List<Player> PlayersInGame { get; } 
        
        public GameFlow(Player Player1 , Player Player2)
        {
            PlayersInGame = new List<Player>();
            PlayersInGame.Add(Player1);
            PlayersInGame.Add(Player2);

        }

        public void StartGame()
        {
            MatchField = new MatchField();
            MatchField.FillMatchFieldwithFields();

        }

        public void GameLoop()
        {


        }


    }
}
