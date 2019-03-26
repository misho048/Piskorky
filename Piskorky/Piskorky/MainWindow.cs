using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskorky
{
    public partial class MainWindow : Form
    {
        NewGameMenu newGame = new NewGameMenu();
        Mechanics mechanic;
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Game()
        {
            FillGrid();
            mechanic = new Mechanics(newGame.NumberOfPlayers, newGame.CharToWin, newGame.SizeOfTheField);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FillGrid()
        {
            gameGridField.Columns.Clear();
            gameGridField.Rows.Clear();
            for (int i = 0; i < newGame.SizeOfTheField; i++)
            {
                gameGridField.Columns.Add(new DataGridViewTextBoxColumn());
                gameGridField.Columns[i].Width = 30;


            }
            gameGridField.Rows.Add(newGame.SizeOfTheField);

        }

        private void LoadGrid()
        {
            gameGridField.Columns.Clear();
            gameGridField.Rows.Clear();
            for (int i = 0; i < mechanic.FieldSize; i++)
            {
                gameGridField.Columns.Add(new DataGridViewTextBoxColumn());
                gameGridField.Columns[i].Width = 30;

            }

            gameGridField.Rows.Add(mechanic.FieldSize);



            for (int i = 0; i < mechanic.FieldSize; i++)
            {
                for (int j = 0; j < mechanic.FieldSize; j++)
                {
                    gameGridField[j, i].Value = mechanic.Field[i, j];
                }
            }

        }


        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem == "New Game")
            {

                newGame.ShowDialog();
                Game();

            }

            if (comboBoxMenu.SelectedItem == "Save Game")
            {

                if (mechanic==null)
                {
                    MessageBox.Show("Error: Create Game First");
                }
                else
                {
                    DataLayer.SaveToFile(mechanic);
                   
                    MessageBox.Show("Save Succesfull");
                }
            }
            if (comboBoxMenu.SelectedItem == "Exit")
            {

                Close();

            }

            if (comboBoxMenu.SelectedItem == "Load Game")
            {
                mechanic = DataLayer.LoadFromFile();
                MessageBox.Show("Load Succesfull");

                LoadGrid();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void gameGridField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNumber = e.RowIndex;
            ColumnNumber = e.ColumnIndex;
            if ((gameGridField[ColumnNumber, RowNumber].Value == null) || (gameGridField[ColumnNumber, RowNumber].Value == ""))
            {
                gameGridField[ColumnNumber, RowNumber].Value = mechanic.ReturnTurnCharacter(ColumnNumber, RowNumber);
                if (mechanic.CheckWin())
                {
                    WinWindow win = new WinWindow((gameGridField[ColumnNumber, RowNumber].Value).ToString());
                    win.ShowDialog();
                    if (win.DialogResult == DialogResult.Abort)
                    {
                        Close();
                    }
                    else if (win.DialogResult == DialogResult.OK)
                    {
                        newGame.ShowDialog();
                        Game();
                    }

                }
            }


        }

        private void StepBack_Click(object sender, EventArgs e)
        {
            mechanic.GoBack();            
            LoadGrid();
        }
    }
}
