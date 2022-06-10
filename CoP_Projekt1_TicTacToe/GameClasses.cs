using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP_Projekt1_TicTacToe
{
    public class Matchfield
    {

        public string Player1 { get; }
        public string Player2 { get; }

        private object[,] GameField2DArray { get; }
        // maybe Field Class instead of Object

        private int[][] GameDecidingFields { get; }

        public Matchfield(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
            this.GameField2DArray = new object[3, 3];
            //Arrays mit zwei Feldern in GameDecidingFields gespeichert (wird vllt durch andere Prüfungsidee vereinfacht)
            this.GameDecidingFields = new int[][]{
                                                           new int[] {0, 1},
                                                           new int[] {1, 0},
                                                           new int[] {1, 1},
                                                           new int[] {1, 2},
                                                           new int[] {2, 1}
                                                   };
        }
    }

    public enum Contents
    {
        Empty,
        WOW,
        BÄM
        //TODO better ENUMS

    }


    public class Field
    {
        public int[,] Position { get; }
        public string CorespondingButton { get; }
        public string CorespondingTextField { get; }

        public string Content { get; }
        public string LastModifier { get; set; }

        public bool Decider { get;  }
        public bool CentralField { get; }

        public Field[] Neighbors { get; set; } 

        public Field(int row, int line)
        {
            this.Position = new int[1, 2] { { row, line } };
            Content = "?";
        }

    }

    public class GameFlow
    {
    }


}
