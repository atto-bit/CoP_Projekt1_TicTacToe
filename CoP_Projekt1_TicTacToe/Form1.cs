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
        public Form1()
        {
            InitializeComponent();
        }

        public GameFlow Game { get; set; }   //Gameflow could get players!!!!!!!!
        

        public void ResetGame_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

            var Player1 = new Player(Player1Name.Text);
            var Player2 = new Player(Player2Name.Text);
            Game  = new GameFlow(Player1,Player2);
            Game.StartGame();
            Game.CurrentPlayer = Game.PlayersInGame.First();

            Player1Name.ReadOnly = true;
            Player2Name.ReadOnly = true;

            StartGame.Enabled = false;

            textBox1.BackColor = Color.Green;

        }

        private void button00_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 0).PlayField(Game.CurrentPlayer);
            textBox00.Text = Game.MatchField.FindField(0, 0).Content;
            button00.Enabled = false;
        }

        private void button01_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 1).PlayField(Game.CurrentPlayer);
            textBox01.Text = Game.MatchField.FindField(0, 1).Content;
            button01.Enabled = false;
        }

        private void button02_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 2).PlayField(Game.CurrentPlayer);
            textBox02.Text = Game.MatchField.FindField(0, 2).Content;
            button02.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 0).PlayField(Game.CurrentPlayer);
            textBox10.Text = Game.MatchField.FindField(1, 0).Content;
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 1).PlayField(Game.CurrentPlayer);
            textBox11.Text = Game.MatchField.FindField(1, 1).Content;
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 2).PlayField(Game.CurrentPlayer);
            textBox12.Text = Game.MatchField.FindField(1, 2).Content;
            button12.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 0).PlayField(Game.CurrentPlayer);
            textBox20.Text = Game.MatchField.FindField(2, 0).Content;
            button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 1).PlayField(Game.CurrentPlayer);
            textBox21.Text = Game.MatchField.FindField(2, 1).Content;
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 2).PlayField(Game.CurrentPlayer);
            textBox22.Text = Game.MatchField.FindField(2, 2).Content;
            button22.Enabled = false;
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
    }


    
}
