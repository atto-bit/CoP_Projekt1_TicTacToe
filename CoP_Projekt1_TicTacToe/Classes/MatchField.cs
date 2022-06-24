using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP_Projekt1_TicTacToe.Classes
{
    public class MatchField
    {

        private Field[,] MatchField2DArray { get; }
        // maybe Field Class instead of Object

        private int[][] GameDecidingFields { get; }

        public MatchField()
        {

            this.MatchField2DArray = new Field[3, 3];
            //Arrays mit zwei Feldern in GameDecidingFieldsKoordinaten gespeichert (wird vllt durch andere Prüfungsidee vereinfacht)
            // Aktuell wurde es nicht  wirklich beutzt.
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
                        if (element[0] == x && element[1] == y)
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
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 0]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 0]);
                    }
                    if (x == 1 & y == 2)
                    {
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 2]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 2]);
                    }
                    if (x == 2 & y == 1)
                    {
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 0]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 2]);
                    }
                    if (x == 1 & y == 1)
                    {
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 0]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 2]);

                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 2]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 0]);

                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[0, 1]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[2, 1]);

                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[1, 0]);
                        MatchField2DArray[x, y].Neighbors.Add(MatchField2DArray[1, 2]);
                    }
                }
            }
        }

        public Field FindField(int x, int y)
        {
            return MatchField2DArray[x, y];
        }

        public void CheckAllFieldsForWinningConditions(){
            foreach(Field field in MatchField2DArray)
            {
                if (field.CheckWinningConditions())
                {
                    Form1.ViewForm1.ActivateWinner();
                }
            }

        }


    }

}

