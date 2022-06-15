using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP_Projekt1_TicTacToe.Classes
{
    public class Field
    {
        public int[,] Position { get; }
        public string CorespondingButton { get; }
        public string CorespondingTextField { get; }

        public string Content { get; set; }
        public string LastModifier { get; set; }

        public bool Decider { get; set; }
        public bool CentralField { get; set; }

        public List<Field> Neighbors = new List<Field>();

        public Field(int row, int line)
        {
            this.Position = new int[1, 2] { { row, line } };
            //Content = "?";
        }

        public void PlayField(Player player)
        {
            //so funktioniert das nicht!!
            if (player == player) this.Content = "X";
            else this.Content = "O";
        }

    }
}
