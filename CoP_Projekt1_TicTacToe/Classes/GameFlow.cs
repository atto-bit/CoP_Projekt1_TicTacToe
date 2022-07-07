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
        private int currentRound { get; set; }
        public Player CurrentPlayer { get; set; }
        public MatchField MatchField { get; set; }
        public List<Player> PlayersInGame { get; }

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
            currentRound = 0;
            MatchField = new MatchField();
            MatchField.FillMatchFieldwithFields();

        }

        public void GameLoop()
        {   
            currentRound++;
            if(PlayersInGame.Count == 9)

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
            if (currentRound == 9)
            {
                Form1.ViewForm1.NoWinner();
            }
                
                
            Form1.ViewForm1.changeColorActivePlayer();
        }

    }
}
