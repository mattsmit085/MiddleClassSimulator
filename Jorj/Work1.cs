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
    public partial class Work1 : UserControl
    {
        //PRODUCT
        List<product> products = new List<product>();

        System.Windows.Media.MediaPlayer WorkTheme = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer BoxItem = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer WrongItem = new System.Windows.Media.MediaPlayer();

        bool spaceDown = false;

        int timer = 0;
        int wait;
        int warning;
        public int money;
        int earning = 15;

        public Work1()
        {

            InitializeComponent();
            WorkTheme.Open(new Uri(Application.StartupPath + "/Resources/WorkTheme.wav"));
            WorkTheme.MediaEnded += new EventHandler(backMedia_MediaEnded);

            WrongItem.Open(new Uri(Application.StartupPath + "/Resources/ErrorSound2.wav"));
            WrongItem.MediaEnded += new EventHandler(backMedia_MediaEnded);

            BoxItem.Open(new Uri(Application.StartupPath + "/Resources/Box.wav"));
            BoxItem.MediaEnded += new EventHandler(backMedia_MediaEnded);
        }



        private void backMedia_MediaEnded(object sender, EventArgs e)

        {
            BoxItem.Stop();
            WrongItem.Stop();
        }

        private void Work1_Load(object sender, EventArgs e)
        {

            this.Focus();
            this.BringToFront();
            WorkTheme.Play();

            if (L1.day == 0)
            {

                raiseLabel.Enabled = true;
                raiseLabel.Text = $"You're making: ${earning}";
            }
            else if (L1.day > 0)
            {
                earning += 15;
                raiseLabel.Enabled = true;
                raiseLabel.Text = $"You got a raise! You're making: ${earning}";
            }
            else
            {
                raiseLabel.Text = "";
            }
            L1.day++;
        }

        //Game Engine

        private void workTimer_Tick(object sender, EventArgs e)
        {
            Rectangle greenRec = new Rectangle(this.Width / 2 + 20, 250, 40, 45);

            timer++;
            wait++;

            warningLabel.Text = $"WARNINGS: {warning}";
            moneyLabel.Text = $"EARNINGS: {money}";

            if (warning == 5)
            {
                workTimer.Enabled = false;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                loseScreen l = new loseScreen();
                f.Controls.Add(l);
                l.BringToFront();
                l.Focus();
            }

            if (timer == 300)
            {
                WorkTheme.Stop();
                workTimer.Enabled = false;
                Form f = this.FindForm();
                f.Controls.Remove(this);

                sleep s = new sleep();
                f.Controls.Add(s);

                L1.balance += money;
            }

            Random randGen = new Random();
            int randNum = randGen.Next(1, 5);

            if (wait == 20)
            {

                if (randNum == 1)
                {
                    products.Add(new product(Properties.Resources.battery, "battery"));
                    wait = 0;
                }
                if (randNum == 2)
                {
                    products.Add(new product(Properties.Resources.Nerf, "nerf"));
                    wait = 0;
                }
                if (randNum == 3)
                {
                    products.Add(new product(Properties.Resources.shampoo, "shampoo"));
                    wait = 0;
                }
                if (randNum == 4)
                {
                    products.Add(new product(Properties.Resources.gun, "gun"));
                    wait = 0;
                }

            }
            foreach (product p in products)
            {
                p.move();
            }
            if (spaceDown == true)
            {
                foreach (product p in products)
                {
                    if (p.productRec.IntersectsWith(greenRec))
                    {
                        if (p.type == "gun")
                        {
                            WrongItem.Play();
                            warning++;
                            products.Remove(p);
                            break;
                        }
                        else
                        {
                            BoxItem.Play();
                            money += earning;
                            products.Remove(p);
                            break;
                        }

                    }
                }
            }


            if (products.Count > 0)
            {
                if (products[0].productX <= this.Width / 2)
                {
                    if (products[0].type != "gun")
                    {
                        warning++;
                    }
                    products.RemoveAt(0);
                }
            }
            this.Refresh();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
        }


        //ALL ART
        private void Work1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.Green, this.Width / 2 + 20, 250, 40, 45);

            foreach (product p in products)
            {
                e.Graphics.DrawImage(p.productImage, p.productX, p.productY, 45, 45);
            }


        }

        private void georgeLabel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        //KEY DETECTION
        private void Work1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void Work1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }
    }
}
