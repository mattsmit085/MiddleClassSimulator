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
    public partial class Phone : UserControl
    {

        bool fDown = false;

        public Phone()
        {
            InitializeComponent();

        }

        private void Phone_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Phone_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    fDown = true;
                    break;
            }
        }

        private void PauseEngine_Tick(object sender, EventArgs e)
        {

            balanceLabel.Text = $" $ {L1.balance}";
            debtLabel.Text = $" $ {L1.debt}";

            if (George.showPhone == true && fDown)
            {
                PauseEngine.Enabled = false;
                George.showPhone = false;
                this.Dispose();
            }

            if (L1.ownCar == true)
            {
                carPicture.Image = Properties.Resources.CAROWNED;
            }
            else if (L1.balance >= 500)
            {
                carPicture.Image = Properties.Resources.can_buy_car;
            }

            else if (L1.balance < 500)
            {
                carPicture.Image = Properties.Resources.BUY_CAR___INSUFFICIENT;
            }


            Refresh();
        }

        private void carPicture_Click(object sender, EventArgs e)
        {
            if (L1.balance >= 500 && L1.ownCar == false)
            {
                L1.balance -= 500;
                L1.ownCar = true;
            }
        }

        private void paymentPicture_Click(object sender, EventArgs e)
        {
            L1.debt -= L1.balance;
            L1.balance = 0;
        }
    }
}
