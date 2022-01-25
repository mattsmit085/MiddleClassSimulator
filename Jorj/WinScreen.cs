using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jorj
{
    public partial class WinScreen : UserControl
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void WinLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            OhNo o = new OhNo();
            f.Controls.Add(o);
            o.Focus();
            o.BringToFront();
        }

        private void backToWorkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
