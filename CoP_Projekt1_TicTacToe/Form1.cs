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

        GameFlow Game { get; set; }   //Gameflow could get players!!!!!!!!
        public string CurrentPlayer { get; set; }

        public void ResetGame_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Game  = new GameFlow();
            Game.StartGame(Player1Name.Text, Player2Name.Text);
            CurrentPlayer = Game.MatchField.Player1;

            Player1Name.ReadOnly = true;
            Player2Name.ReadOnly = true;

            StartGame.Enabled = false;

            textBox1.BackColor = Color.Green;

        }

        private void button00_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 0).PlayField(CurrentPlayer);
            textBox00.Text = Game.MatchField.FindField(0, 0).Content;

        }

        private void button01_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 1).PlayField(CurrentPlayer);
            textBox01.Text = Game.MatchField.FindField(0, 1).Content;
        }

        private void button02_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(0, 2).PlayField(CurrentPlayer);
            textBox02.Text = Game.MatchField.FindField(0, 2).Content;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 0).PlayField(CurrentPlayer);
            textBox10.Text = Game.MatchField.FindField(1, 0).Content;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 1).PlayField(CurrentPlayer);
            textBox11.Text = Game.MatchField.FindField(1, 1).Content;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(1, 2).PlayField(CurrentPlayer);
            textBox12.Text = Game.MatchField.FindField(1, 2).Content;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 0).PlayField(CurrentPlayer);
            textBox20.Text = Game.MatchField.FindField(2, 0).Content;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 1).PlayField(CurrentPlayer);
            textBox21.Text = Game.MatchField.FindField(2, 1).Content;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Game.MatchField.FindField(2, 2).PlayField(CurrentPlayer);
            textBox22.Text = Game.MatchField.FindField(2, 2).Content;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


    
}
