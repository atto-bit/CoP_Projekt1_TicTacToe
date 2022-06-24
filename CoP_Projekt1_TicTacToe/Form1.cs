using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoP_Projekt1_TicTacToe.Classes;

namespace CoP_Projekt1_TicTacToe
{
    public partial class Form1 : Form
    {
        internal static Form1 ViewForm1;
        public Form1()
        {
            InitializeComponent();
            ViewForm1 = this;
        }

        public GameFlow Game { get; set; } 
        

        public void ResetGame_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

            var Player1 = new Player(Player1Name.Text, "X");
            var Player2 = new Player(Player2Name.Text, "O");
            Game  = new GameFlow(Player1,Player2);
            Game.StartGame();
            Game.CurrentPlayer = Game.PlayersInGame.First();

            Player1Name.ReadOnly = true;
            Player2Name.ReadOnly = true;

            StartGame.Enabled = false;

            textBox1.BackColor = Color.Green;

            button00.Enabled = true;
            button01.Enabled = true;
            button02.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;




        }

        private void button00_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 0).PlayField(Game.CurrentPlayer.Filler);
            textBox00.Text = Game.MatchField.FindField(0, 0).Content;
            button00.Enabled = false;
            Game.GameLoop();
        }

        private void button01_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 1).PlayField(Game.CurrentPlayer.Filler);
            textBox01.Text = Game.MatchField.FindField(0, 1).Content;
            button01.Enabled = false;
            Game.GameLoop();
        }

        private void button02_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 2).PlayField(Game.CurrentPlayer.Filler);
            textBox02.Text = Game.MatchField.FindField(0, 2).Content;
            button02.Enabled = false;
            Game.GameLoop();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 0).PlayField(Game.CurrentPlayer.Filler);
            textBox10.Text = Game.MatchField.FindField(1, 0).Content;
            button10.Enabled = false;
            Game.GameLoop();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 1).PlayField(Game.CurrentPlayer.Filler);
            textBox11.Text = Game.MatchField.FindField(1, 1).Content;
            button11.Enabled = false;
            Game.GameLoop();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 2).PlayField(Game.CurrentPlayer.Filler);
            textBox12.Text = Game.MatchField.FindField(1, 2).Content;
            button12.Enabled = false;
            Game.GameLoop();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 0).PlayField(Game.CurrentPlayer.Filler);
            textBox20.Text = Game.MatchField.FindField(2, 0).Content;
            button20.Enabled = false;
            Game.GameLoop();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 1).PlayField(Game.CurrentPlayer.Filler);
            textBox21.Text = Game.MatchField.FindField(2, 1).Content;
            button21.Enabled = false;
            Game.GameLoop();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 2).PlayField(Game.CurrentPlayer.Filler);
            textBox22.Text = Game.MatchField.FindField(2, 2).Content;
            button22.Enabled = false;
            Game.GameLoop();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox00_TextChanged(object sender, EventArgs e)
        {

        }

        private void WinnerName_TextChanged(object sender, EventArgs e)
        {

        }

        public void ActivateWinner()
        {
            WinnerDeclaration.Visible = true;
            WinnerName.Text = Game.CurrentPlayer.Name;
            WinnerName.Visible = true;
            groupBox2.Enabled = false;

        }
        public void changeColorActivePlayer()
        {
            if(textBox1.BackColor != Color.Green) {
                textBox1.BackColor = Color.Green;
                textBox2.BackColor = Color.WhiteSmoke;

            }
            else
            {
                textBox1.BackColor = Color.WhiteSmoke;
                textBox2.BackColor = Color.Green;
            }

        }
    }




    
}
