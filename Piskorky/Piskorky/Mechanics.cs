using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskorky
{
    class Mechanics
    {
        public Stack<string[,]> StepBack { get; set; }

        public int NumOfPlayers { get; set; }
        public int WinNumber { get; set; }
        public int FieldSize { get; set; }
        public int Turn { get; set; }
        public int CurrentCollumn { get; set; }
        public int CurrentRow { get; set; }

        public string[,] Field { get; set; }

        public Mechanics(int numOfPLayers,int winNUmber,int fieldSize, int turn,string[,] field, int currentRow, int currentCollumn)
        {
            NumOfPlayers = numOfPLayers;
            Field = field;
            WinNumber = winNUmber;
            FieldSize = fieldSize;
            Turn = turn;
            CurrentCollumn = currentCollumn;
            CurrentRow = currentRow;
        }

        public Mechanics()
        {
            //LoadFromFile();
        }

        public Mechanics(int numOfPLayers, int winNUmber, int fieldSize)
        {
            NumOfPlayers = numOfPLayers;
            WinNumber = winNUmber;
            FieldSize = fieldSize;
            Turn = 0;
            Field = new string[fieldSize, fieldSize];
            StepBack = new Stack<string[,]>();

        }

        public void GoBack()
        {
            if (Turn == 1)
            {
                Debug.Write("You are at the first Turn cant go back ");
            }
            else
            {
                
                 StepBack.Pop();
                Field = StepBack.Peek();
                Turn--;

            }

        }

        public string ReturnTurnCharacter(int collumn, int row)
        {
            CurrentCollumn = collumn;
            CurrentRow = row;
            
            int something = Turn % NumOfPlayers;

            switch (something)
            {
                case 0:
                    {
                        Field[CurrentRow, CurrentCollumn] = "X";
                        string[,] joke = Field.Clone() as string[,];
                        StepBack.Push(joke);
                        Turn++;
                        return "X";

                    }
                case 1:
                    {
                        Field[CurrentRow, CurrentCollumn] = "O";
                        string[,] joke = Field.Clone() as string[,];
                        StepBack.Push(joke);
                        Turn++;
                        return "O";
                    }
                case 2:
                    {
                        Field[CurrentRow, CurrentCollumn] = "Y";
                        string[,] joke = Field.Clone() as string[,];
                        StepBack.Push(joke);
                        Turn++;
                        return "Y";
                    }
                case 3:
                    {
                        Field[CurrentRow, CurrentCollumn] = "Z";
                        string[,] joke = Field.Clone() as string[,];
                        StepBack.Push(joke);
                        Turn++;
                        return "Z";
                    }
                default:
                    {
                        return "0";
                    }
            }

        }

        public bool CheckWin()
        {
            return (CheckColumn() || CheckRow() || CheckDiagonalLeft() || CheckAnotherDiagonal()) ? true : false;
        }

        private bool CheckColumn()
        {
            int num = 0;
            string character = Field[CurrentRow, CurrentCollumn];

            for (int i = 0; i < FieldSize; i++)
            {
                if (Field[i, CurrentCollumn] == character)
                {
                    num++;
                    if (num == WinNumber)
                    {
                        return true;
                    }

                }
                else
                {
                    num = 0;

                }


            }
            return false;
        }
        private bool CheckRow()
        {
            int pocitadlo = 0;
            string character = Field[CurrentRow, CurrentCollumn];

            for (int i = 0; i < FieldSize; i++)
            {
                if (Field[CurrentRow, i] == character)
                {
                    pocitadlo++;
                    if (pocitadlo == WinNumber)
                    {
                        return true;
                    }

                }
                else
                {
                    pocitadlo = 0;

                }


            }
            return false;


        }
        private bool CheckDiagonalLeft()
        {
            int nejakePocitadlo = 0;
            int lowest = 0;
            int rightest = 0;
            string character = Field[CurrentRow, CurrentCollumn];
            try
            {
                while (true)
                {
                    if (Field[CurrentRow + nejakePocitadlo, CurrentCollumn + nejakePocitadlo] == character)
                    {
                        nejakePocitadlo++;
                    }
                    else
                    {
                        lowest = CurrentRow + nejakePocitadlo;
                        rightest = CurrentCollumn + nejakePocitadlo;
                        break;

                    }

                }
                nejakePocitadlo = 0;

                for (int i = 0; i < WinNumber + 1; i++)
                {
                    if (Field[lowest - i, rightest - i] == character)
                    {
                        nejakePocitadlo++;
                        if (nejakePocitadlo == WinNumber)
                        {
                            return true;
                        }
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        private bool CheckAnotherDiagonal()
        {
            int num = 0;
            int highest = 0;
            int rightMost = 0;
            string character = Field[CurrentRow, CurrentCollumn];
            try
            {
                while (true)
                {
                    if (Field[CurrentRow - num, CurrentCollumn + num] == character)
                    {
                        num++;
                    }
                    else
                    {
                        highest = CurrentRow - num;
                        rightMost = CurrentCollumn + num;
                        break;

                    }

                }
                num = 0;

                for (int i = 0; i < WinNumber + 1; i++)
                {
                    if (Field[highest + i, rightMost - i] == character)
                    {
                        num++;
                        if (num == WinNumber)
                        {
                            return true;
                        }
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;


        }


    }
}
