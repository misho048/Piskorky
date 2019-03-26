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
    public partial class WinWindow : Form
    {
        public WinWindow(string winner)
        {
            InitializeComponent();
            label2.Text = $"{winner} is winner";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
