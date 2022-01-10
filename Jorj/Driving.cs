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

    public partial class Driving : UserControl
    {
        int timer = 0;
        int timerpass;
        public Driving()
        {
            InitializeComponent();
        }

        private void driveTimer_Tick(object sender, EventArgs e)
        {
            timer++;

            if (timer%15 == 0)
            {
                driveBox.Image = Properties.Resources.d__1_;
            }
            if (timer%15 == 5)
            {
                driveBox.Image = Properties.Resources.d__2_;
            }
            if (timer%15 == 10)
            {
                driveBox.Image = Properties.Resources.d__3_;

            }
            Console.WriteLine(timer);
            if (timer == 30)
                {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                Work1 w1 = new Work1();
                f.Controls.Add(w1);
            }
        }
    }
}
