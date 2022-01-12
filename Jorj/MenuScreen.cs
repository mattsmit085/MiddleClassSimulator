using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Jorj
{
    public partial class MenuScreen : UserControl
    {

        SoundPlayer MainTheme = new SoundPlayer(Properties.Resources.MAIN_THEME);

        public MenuScreen()
        {
            InitializeComponent();
            MainTheme.Play();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainTheme.Stop();
            Form f = this.FindForm();
            f.Controls.Remove(this);

            L1 l1 = new L1();
            f.Controls.Add(l1);
            l1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            instructions i = new instructions();
            f.Controls.Add(i);
            this.Focus();
        }
    }
}
