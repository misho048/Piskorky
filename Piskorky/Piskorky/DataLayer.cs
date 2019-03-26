using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskorky
{
    static class DataLayer
    {
        public static void SaveToFile(Mechanics mech)
        {

            string save = $"Save.txt";
            try
            {
                if (!File.Exists(save))
                {
                    File.Create(save).Close();
                }

                TextWriter writer = new StreamWriter(save);
                writer.WriteLine($"{mech.NumOfPlayers}\t{mech.FieldSize}\t{mech.WinNumber}\t{mech.CurrentRow}\t{mech.CurrentCollumn}\t{mech.Turn}");
                for (int i = 0; i < mech.FieldSize; i++)
                {
                    for (int j = 0; j < mech.FieldSize; j++)
                    {
                        writer.Write($"{mech.Field[i, j]} ");
                    }
                    writer.Write("\n");
                }
                writer.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error Happend\n" +
                    $"Error Info:{e.Message}");
            }
        }

        public static Mechanics LoadFromFile()
        {
            string save = "Save.txt";
            try
            {
                if (!File.Exists(save))
                {

                    File.Create(save).Close();

                }



                string[] splitLine;
                string[] lines = File.ReadAllLines(save);

                splitLine = lines[0].Split('\t');

                int numOfPLayers = Convert.ToInt32(splitLine[0]);
                int fieldSize = Convert.ToInt32(splitLine[1]);
                int winNUmber = Convert.ToInt32(splitLine[2]);
                int currentRow = Convert.ToInt32(splitLine[3]);
                int currentCollumn = Convert.ToInt32(splitLine[4]);
                int turn = Convert.ToInt32(splitLine[5]);

                string[,] Field = new string[fieldSize, fieldSize];

                for (int i = 1; i < fieldSize + 1; i++)
                {
                    splitLine = lines[i].Split(' ');
                    for (int j = 0; j < fieldSize; j++)
                    {
                        Field[i - 1, j] = splitLine[j];
                    }
                }
                return new Mechanics(numOfPLayers, winNUmber, fieldSize, turn, Field, currentRow, currentCollumn);


            }
            catch (Exception e)
            {

                Debug.Write($"Unexpected Error Happend\n" +
                                    $"Error Info:{e.Message}");
                return new Mechanics();
            }

        }

    }
}
