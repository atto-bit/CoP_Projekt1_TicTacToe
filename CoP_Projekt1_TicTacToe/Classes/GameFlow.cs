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

        public const string Player1Filler = "X";
        public const string Player2Filler = "O";

        public GameFlow(Player Player1 , Player Player2)
        {
            PlayersInGame = new List<Player>
            {
                Player1,
                Player2
            };
            CurrentPlayer = Player1;

        }

        public void StartGame()
        {
            MatchField = new MatchField();
            MatchField.FillMatchFieldwithFields();

        }

        public void GameLoop()
        {

            MatchField.CheckAllFieldsForWinningConditions();

            for (int i = 0; i < PlayersInGame.Count; i++)
            {
                Player player = PlayersInGame[i];
                if (CurrentPlayer != player)
                {
                    CurrentPlayer = player;
                    break;
                }
                
            }
            Form1.ViewForm1.changeColorActivePlayer();



        }

        public string DeclareWinner()
        {
            return CurrentPlayer.Name;
        }
        


    }
}
