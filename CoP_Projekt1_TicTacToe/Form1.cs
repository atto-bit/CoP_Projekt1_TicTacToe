using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoP_Projekt1_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GameFlow Game { get; set; }   //Gameflow could get players!!!!!!!!
        public string CurrentPlayer { get; set; }

        public void ResetGame_Click(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Game  = new GameFlow();
            Game.StartGame(Player1Name.Text, Player2Name.Text);
            CurrentPlayer = Game.MatchField.Player1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 0).PlayField(CurrentPlayer);
            textBox2.Text = Game.MatchField.FindField(0, 0).Content;
        }
    }


    public class MatchField
    { 

        public string Player1 { get; }
        public string Player2 { get; }

        private Field[,] MatchField2DArray { get; }
        // maybe Field Class instead of Object

        private int[][] GameDecidingFields { get; }

        public MatchField(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
            this.MatchField2DArray = new Field[3, 3];
            //Arrays mit zwei Feldern in GameDecidingFieldsKoordinaten gespeichert (wird vllt durch andere Prüfungsidee vereinfacht)
            this.GameDecidingFields = new int[][]{
                                                           new int[] {0, 1},
                                                           new int[] {1, 0},
                                                           new int[] {1, 1},
                                                           new int[] {1, 2},
                                                           new int[] {2, 1}
                                                   };
        }

        public void FillMatchFieldwithFields()
        {
            for (int x = 0; x < MatchField2DArray.GetLength(0); x++)
            {
                for (int y = 0; y < MatchField2DArray.GetLength(1); y++)
                {
                    this.MatchField2DArray[x, y] = new Field(x, y);
                    foreach (var element in GameDecidingFields)
                        if (element[0] ==  x && element[1] == y)
                        {
                            MatchField2DArray[x, y].Decider = true;
                            if (element[0] == 1 && element[1] == 1) MatchField2DArray[x, y].CentralField = true;
                        }

                }

            }

            //Hardcoded Neighbors
            for (int x = 0; x < MatchField2DArray.GetLength(0); x++)
            {
                for (int y = 0; y < MatchField2DArray.GetLength(1); y++)
                {
                    if (x == 0 & y == 1)
                    {
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 0]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 2]);
                    }
                    if (x == 1 & y == 0)
                    {
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[0, 0]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 0]);
                    }
                    if (x == 1 & y == 2)
                    {
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[0, 2]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 2]);
                    }
                    if (x == 2 & y == 1)
                    {
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 0]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 2]);
                    }
                    if (x == 1 & y == 1)
                    {
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[0, 0]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 2]);

                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[0, 2]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 0]);

                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[0, 1]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[2, 1]);

                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[1, 0]);
                        MatchField2DArray[x, y].Neighbors.Append(MatchField2DArray[1, 2]);
                    }
                }
            }
        }

        public Field FindField(int x, int y)
        {
            return MatchField2DArray[x,y];
        }
    }


    public class Field
    {
        public int[,] Position { get; }
        public string CorespondingButton { get; }
        public string CorespondingTextField { get; }

        public string Content { get; set; }
        public string LastModifier { get; set; }

        public bool Decider { get; set; } 
        public bool CentralField { get; set; } 

        //public Field[] Neighbors { get; set; }
        public List<Field> Neighbors = new List<Field>();

        public Field(int row, int line)
        {
            this.Position = new int[1, 2] { { row, line } };
            Content = "?";
        }

        public void PlayField(string player)
        {
            //so funktioniert das nicht!!
            if (player == "Player1") this.Content = "X";
            else this.Content = "O";
        }

    }

    public class GameFlow
    {
        public MatchField MatchField { get; set; }
    
        public void StartGame(string Player1, string Player2){
            MatchField = new MatchField(Player1, Player2);
            MatchField.FillMatchFieldwithFields();

        } 


    }
}
