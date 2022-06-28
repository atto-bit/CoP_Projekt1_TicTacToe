using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP_Projekt1_TicTacToe
{
    internal class Game
    {
        private int currentplayer;
        private static string player1sign = "X";
        private static string player2sign = "O";
        private String[] fields;
        public Game()
        {
            this.currentplayer = 1;
            fields = new String[10];
        }
        public int getCurrentplayer()
        { 
            return this.currentplayer; 
        }

        public string sign(int i)
        {
            string sign;
            if(currentplayer == 1)
            {
                currentplayer = 2;
                sign = player1sign;
            }
            else
            {
                currentplayer = 1;
                sign = player2sign;
            }
            fields[i] = sign;
            return sign;
        }

        public int checkwin()
        {
            string sign;
            int state = 0;
            for (int i = 1; i < 3; i++)
            {
                if (i==1)
                {
                    sign = player1sign;
                }
                else
                {
                    sign = player2sign; 
                }

                //Reihen prüfen
                if (fields[1] == sign && fields[4] == sign && fields[7]==sign)
                {
                    state = i;
                }
                else if (fields[2] == sign && fields[5] == sign && fields[8] == sign)
                {
                    state = i;
                }
                else if (fields[3] == sign && fields[6] == sign && fields[9]==sign)
                {
                    state = i;
                }

                //Spalten prüfen
                else if (fields[1] == sign && fields[2] == sign && fields[3] == sign)
                {
                    state = i;
                }
                else if (fields[4] == sign && fields[5] == sign && fields[6] == sign)
                {
                    state = i;
                }
                else if (fields[7] == sign && fields[8] == sign && fields[9] == sign)
                {
                    state = i;
                }
                //diagonal prüfen
                else if (fields[1] == sign && fields[5] == sign && fields[9] == sign)
                {
                    state = i;
                }
                else if (fields[3] == sign && fields[5] == sign && fields[7] == sign)
                {
                    state = i;
                }
                else
                {
                    state = 3; //unentschieden, außer es sind noch Felder frei
                }
                if (state!=3)//gibt es einen Gewinner, suchen wir nicht weiter
                {
                    return state;
                }

            }
            //Gab es bei beiden Spielern keinen Gewinner, prüfen wir, ob es ein Unentschieden war, oder das Spiel noch läuft
            for (int j = 1; j < 10; j++)
            {
                if (fields[j] == null)
                {
                    state = 0; //noch freie Felder vorhanden, Spiel geht weiter
                }
            }
            return state;

        }
    }
}
