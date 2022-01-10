using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Jorj
{
    public partial class loseScreen : UserControl
    {
        public loseScreen()
        {
            InitializeComponent();
            gameOverLabel.Enabled = false;
           // playAgainButton.Enabled = false;
            ExitButton.Enabled = false;

            Thread.Sleep(500);
            Refresh();

            gameOverLabel.Enabled = true;
           // playAgainButton.Enabled = true;
            ExitButton.Enabled = true;

            loseLabel.Enabled = false;
            BeffLabel.Enabled = false;

            Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loseScreen_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
