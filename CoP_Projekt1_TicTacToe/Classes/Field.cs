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
        public string Content { get; set; }
        public bool Decider { get; set; }
        public bool CentralField { get; set; }

        public List<Field> Neighbors = new List<Field>();

        public Field(int row, int line)
        {
            this.Position = new int[1, 2] { { row, line } };
            //Content = "?";
        }

        public bool CheckWinningConditions()
        {

            if (this.Decider && this.Content == Neighbors[0].Content && this.Content == Neighbors[1].Content && this.Content != null)
            {
                    return true;  
            }

            else if (this.CentralField)
            {
                for (int i = 0; i < Neighbors.Count() - 1; i += 2)
                {
                    if (this.Content == Neighbors[i].Content && this.Content == Neighbors[i + 1].Content && this.Content != null)
                    {
                        return true;

                    }
                }

                return false;
            }

            else
            {
                return false;
            }
        }

            public void PlayField(string content)
        {

            this.Content = content;
        }

    }
}
