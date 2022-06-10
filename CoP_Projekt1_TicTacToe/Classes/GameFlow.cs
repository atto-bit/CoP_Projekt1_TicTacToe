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
        public MatchField MatchField { get; set; }

        public void StartGame(string Player1, string Player2)
        {
            MatchField = new MatchField(Player1, Player2);
            MatchField.FillMatchFieldwithFields();

        }

        public void GameLoop()
        {


        }


    }
}
