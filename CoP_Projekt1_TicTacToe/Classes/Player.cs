using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP_Projekt1_TicTacToe.Classes
{
    public class Player
    {
        public string Name { get; }
        public string Filler { get; }

        public Player(string name, string filler)
        {
            Name = name;
            Filler = filler;
        }



    }

}
