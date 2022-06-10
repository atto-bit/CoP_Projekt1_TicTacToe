using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoP_Projekt1_TicTacToe
{
    public class Game
    {

        public string Player1 { get; }
        public string Player2 { get; }

        private object[,] gameField2DArray { get; }
        // maybe Field Class instead of Object

        private int[,] gameDecidingFields { get; }

        public Game(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
            this.gameField2DArray = new object[3, 3];
            this.gameDecidingFields = new int[5, 2]{
                                                            {0, 1},
                                                            {1, 0},
                                                            {1, 1},
                                                            {1, 2},
                                                            {2, 1}
                                                   };
        }
    }

    public enum Contents
    {
        Empty,
        Player1,
        Player2
            //TODO better ENUMS

    }


    public class Field
    {
        public int[,] Position { get; }
        public string Content { get; }
        public string LastModifier { get; set; }

        public Field(int row, int line)
        {
            this.Position = new int[1, 2] { { row, line } };
            Content = "?";
        }

    }



    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var game = new Game("text", "player2");
        }
    }
}
