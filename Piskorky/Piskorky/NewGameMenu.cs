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

    public partial class NewGameMenu : Form
    {

        public int SizeOfTheField { get; private set; }
        public int NumberOfPlayers { get; private set; }
        public int CharToWin { get; private set; }


        public NewGameMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
              if (CheckFieldSize(FieldSize.Text) && (CheckCharToWin(CharsToWin.Text)))
                {
                    DialogResult = DialogResult.OK;
                }                
            NumberOfPlayers = Convert.ToInt32(comboBox1.SelectedItem);                                
            
        }

        private bool CheckFieldSize(string something)
        {
            if (int.TryParse(something, out int result))
            {
                if (result < 3)
                {
                    MessageBox.Show("Play Field needs to be at least 3 tile long");
                    return false;
                }
                SizeOfTheField = result;
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Play Field Size value");
                return false;
            }


        }

        private bool CheckCharToWin(string something)
        {
            if (int.TryParse(something, out int result))
            {
                if (result < 2)
                {
                    MessageBox.Show("Number of Chars to win  needs to be at least 2 ");
                    return false;
                }
                CharToWin = result;
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Numbers Of Chars to win value");
                return false;
            }


        }



    }
}
