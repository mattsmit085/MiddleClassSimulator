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
    public partial class OhNo : UserControl
    {
        public OhNo()
        {
            InitializeComponent();
        }

        private void backToWorkButton_Click(object sender, EventArgs e)
        {
            L1.ResetGame();

            George.showPhone = false;
            Form f = this.FindForm();
            f.Controls.Remove(this);

            L1 l = new L1();
            f.Controls.Add(l);
            l.Focus();
            l.BringToFront();
        }
    }
}
