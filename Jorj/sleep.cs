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
    public partial class sleep : UserControl
    {
        public sleep()
        {
            InitializeComponent();
        }

        // LOAD AND SWITCH
        private void sleep_Load(object sender, EventArgs e)
        {

            this.BringToFront();
            this.Focus();

            Refresh();
            Thread.Sleep(1000);
            L1.ResetPosition1();
            Form f = this.FindForm();
            f.Controls.Remove(this);

            L1.backMedia.Stop();
            L1.level = 0;
            L1.playerX = 20;

            L1 l = new L1();
            f.Controls.Add(l);
            l.Focus();

        }
    }
}
