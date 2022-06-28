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
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            initializeButtons();            
        }

        private void initializeButtons()
        {
            //Hier werden die Texte der einzelnen Buttons auf "-" gesetzt und die Buttons aktiviert
            for (int i = 1; i < 4; i++) //äußere Schleife für die Reihe
            {
                for (int j = 1; j < 4; j++) //innere Schleife für die Spalte
                {
                    var buttonName = $"button{i}_{j}";
                    this.Controls.Find(buttonName, true).FirstOrDefault().Text = "-";
                    this.Controls.Find(buttonName, true).FirstOrDefault().Enabled = true;
                }

            }
            labelMessage.Text = "Spieler 1 beginnt!";
        }
        private void disableButtons()
        {
            //Die gleiche Logik wie in initializeButtons
            for (int i = 1; i < 4; i++) //äußere Schleife für die Reihe
            {
                for (int j = 1; j < 4; j++) //innere Schleife für die Spalte
                {
                    var buttonName = $"button{i}_{j}";
                    this.Controls.Find(buttonName, true).FirstOrDefault().Enabled = false;
                }

            }
        }
        private void checkwin()
        {
            int state = game.checkwin();
            bool gameover = true;
            if (state == 1)
            {
                labelMessage.Text = "Spieler 1 gewinnt!";
            }else if (state == 2)
            {
                labelMessage.Text = "Spieler 2 gewinnt!";
            }else if(state == 3)
            {
                labelMessage.Text = "Unentschieden!";
            }
            else
            {
                gameover = false;
                labelMessage.Text = $"Spieler {game.getCurrentplayer()} ist dran";
            }
            if (gameover == true)
            {
                disableButtons();
            }
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            button1_1.Text = game.sign(1);
            button1_1.Enabled = false;
            checkwin();
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            button1_2.Text = game.sign(2);
            button1_2.Enabled = false;
            checkwin();
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            button1_3.Text = game.sign(3);
            button1_3.Enabled = false;
            checkwin();
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            button2_1.Text = game.sign(4);
            button2_1.Enabled = false;
            checkwin();
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            button2_2.Text = game.sign(5);
            button2_2.Enabled = false;
            checkwin();
        }

        private void button2_3_Click(object sender, EventArgs e)
        {
            button2_3.Text = game.sign(6);
            button2_3.Enabled = false;
            checkwin();
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            button3_1.Text = game.sign(7);
            button3_1.Enabled = false;
            checkwin();
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            button3_2.Text = game.sign(8);
            button3_2.Enabled = false;
            checkwin();
        }

        private void button3_3_Click(object sender, EventArgs e)
        {
            button3_3.Text = game.sign(9);
            button3_3.Enabled = false;
            checkwin();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            game = new Game();
            initializeButtons();
        }
    }
}
