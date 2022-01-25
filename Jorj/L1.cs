using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Jorj
{
    public partial class L1 : UserControl
    {

        // LEVEL
        public static int level = 0;
        public static bool dayCheck = true;

        //BRUSHES
        SolidBrush BlackBrush = new SolidBrush(Color.Black);
        SolidBrush WhiteBrush = new SolidBrush(Color.White);
        SolidBrush BlueBrush = new SolidBrush(Color.LightBlue);
        SolidBrush RedBrush = new SolidBrush(Color.Red);
        SolidBrush GreenBrush = new SolidBrush(Color.Green);
        SolidBrush DarkGreenBrush = new SolidBrush(Color.DarkGreen);
        SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush GreyBrush = new SolidBrush(Color.DimGray);
        SolidBrush BrownBrush = new SolidBrush(Color.SaddleBrown);
        SolidBrush InteriorBrush = new SolidBrush(Color.SandyBrown);
        Font Algerian = new Font(FontFamily.GenericMonospace, 15, FontStyle.Bold);

        //LEVEL
        int floorX = 0;
        int floorY = 270;
        int floorHeight = 50;
        int floorWidth = 555;
        int wholefloorHeight = 125;
        float gravity = 10;
        public static int day;

        public static System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();
       public static System.Windows.Media.MediaPlayer JumpPlayer = new System.Windows.Media.MediaPlayer();

        SoundPlayer Walk = new SoundPlayer(Properties.Resources.Walk);

        //PLAYER
        public static int playerX = 20;
        public static float playerY = 218.8f;
        public static int playerWidth = 32;
        public static int playerHeight = 56;
        public static int playerSpeed = 3;
        public static bool jumpOK = true;
        public static int jumpSpeed = 5;
        public static int MoveUp = 1;
        public static int CurrentPosition;

        public static int balance = 0;
        public static int debt = 10000;

        public static bool ownCar = false;

        int imageChangeTimer;
        int jumpTimer;
        public static Image playerImage = Properties.Resources.WALK1;

        //MOVEMENT
        bool wDown = false;
        bool aDown = false;
        bool dDown = false;
        bool shiftDown = false;

        Rectangle FloorRec;
        Rectangle HeroRec;
        Rectangle WorkRec;
        Rectangle CarRec;
        Rectangle BedRec;

        public L1()
        {
            InitializeComponent();
            backMedia.Open(new Uri(Application.StartupPath + "/Resources/Walk.wav"));
            JumpPlayer.Open(new Uri(Application.StartupPath + "/Resources/jump.wav"));
            backMedia.MediaEnded += new EventHandler(backMedia_MediaEnded);
            JumpPlayer.MediaEnded += new EventHandler(backMedia_MediaEnded);
        }

        private void backMedia_MediaEnded(object sender, EventArgs e)

        {

            backMedia.Stop();
            JumpPlayer.Stop();
            backMedia.Play();

        }

        private void L1_Load(object sender, EventArgs e)
        {
            gameEngine.Enabled = true;
            playerX = CurrentPosition;
        }


        //KEY DETECTION
        private void L1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.ShiftKey:
                    shiftDown = false;
                    break;
            }
        }
        private void L1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.ShiftKey:
                    shiftDown = true;
                    break;
                case Keys.F:
                    if (George.showPhone == false)
                    {
                        AddPhoneScreen();
                        L1.backMedia.Stop();
                    }
                    else if (George.showPhone == true)
                    {
                        RemovePhoneScreen();
                    }
                    break;
            }
        }

        // PAINT
        private void L1_Paint(object sender, PaintEventArgs e)
        {
            //SKY
            e.Graphics.FillRectangle(BlueBrush, 0, 0, this.Width, this.Height);

            //FLOOR
            e.Graphics.FillRectangle(GreyBrush, floorX, floorY, floorWidth, floorHeight);
            e.Graphics.FillRectangle(DarkGreenBrush, floorX, floorY + 30, floorWidth, floorHeight);

            //TEXT

            if (level == 0)
            {
                e.Graphics.FillRectangle(BrownBrush, 0, 120, 300, 150);
                e.Graphics.FillRectangle(InteriorBrush, 4, 140, 280, 130);
                e.Graphics.FillRectangle(WhiteBrush, 5, 250, 20, 20);
                e.Graphics.FillRectangle(RedBrush, 25, 250, 40, 20);
                BedRec = new Rectangle(5, 250, 60, 20);

                if (dayCheck == false && playerX == 140)
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    sleep s = new sleep();
                    f.Controls.Add(s);
                    dayCheck = true;
                }
            }

            if (level == 1)
            {
                if (dayCheck == true)
                {
                    e.Graphics.DrawString("It's a beautiful day", Algerian, BlackBrush, new Point(20, 30));
                    if (HeroRec.IntersectsWith(CarRec))
                    {
                        backMedia.Stop();
                        gameEngine.Enabled = false;
                        playerX = playerX - 20;

                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        Driving d = new Driving();
                        f.Controls.Add(d);
                        d.BringToFront();
                    }
                }

                if (ownCar == true)
                {
                    e.Graphics.DrawImage(Properties.Resources.CAR, 380, 220, 150, 75);
                }
            }
            if (level == 2)
            {
                if (dayCheck == true)
                {
                    e.Graphics.DrawString("Time to go to work!", Algerian, BlackBrush, new Point(20, 30));
                }
            }
            if (level == 3)
            {
                if (dayCheck == true)
                {
                    e.Graphics.DrawString("This is taking forever...", Algerian, BlackBrush, new Point(20, 30));
                }
            }
            if (level == 4)
            {
                e.Graphics.DrawString("Work", Algerian, BlackBrush, new Point(455, 150));
                e.Graphics.FillRectangle(GreyBrush, 455, 150, 100, 150);
                e.Graphics.FillRectangle(BlackBrush, 455, 200, 45, 70);
                WorkRec = new Rectangle(455, 200, 45, 70);
            }

            //PLAYER
            e.Graphics.DrawImage(playerImage, playerX, playerY, playerWidth, playerHeight);

            ////BARRIER TESTER
            // e.Graphics.FillRectangle(WhiteBrush, floorX, floorY, floorWidth, wholefloorHeight);

            ////PLAYER TESTER
            //e.Graphics.FillRectangle(WhiteBrush, playerX, playerY, playerWidth, playerHeight);
        }

        //GAME ENGINE
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //playerX = CurrentPosition;
            FloorCheck();
            HeroJumpSmooth();
            WorkCheck();
            #region KeyCheck
            if (shiftDown == true)
            {
                playerSpeed = 5;
            }
            else
            {
                playerSpeed = 3;
            }

            if (aDown == true)
            {
                backMedia.Play();

                playerX -= playerSpeed;

                imageChangeTimer++;

                if (imageChangeTimer == 5)
                {
                    playerImage = Properties.Resources.WALK2;
                }
                if (imageChangeTimer == 10)
                {
                    playerImage = Properties.Resources.WALK1;
                    imageChangeTimer = 0;
                }
            }

            else if (dDown == true)
            {
                backMedia.Play();
                playerX += playerSpeed;
                imageChangeTimer++;

                if (imageChangeTimer == 5)
                {
                    playerImage = Properties.Resources.WALK2;
                }
                if (imageChangeTimer == 10)
                {
                    playerImage = Properties.Resources.WALK1;
                    imageChangeTimer = 0;
                }
            }

            else if (aDown == false && dDown == false)
            {
                backMedia.Stop();
            }

            if (debt <= 0)
            {
                George.showPhone = false;
                backMedia.Stop();
                gameEngine.Enabled = false;

                Form f = this.FindForm();
                f.Controls.Remove(this);
                WinScreen w = new WinScreen();
                f.Controls.Add(w);
                w.BringToFront();
            }
            #endregion
            LevelCheck();

            if (ownCar == true)
            {
                CarRec = new Rectangle(380, 220, 150, 75);

            }

            FloorRec = new Rectangle(floorX, floorY, floorWidth, wholefloorHeight);
            HeroRec = new Rectangle(playerX, Convert.ToInt32(playerY), playerWidth, playerHeight);

            Refresh();
        }
        
        // OLD JUMP SYSTEM
        public void OLDHeroJump()
        {

            if (wDown == true && jumpOK == true)
            {
                jumpOK = false;
                jumpTimer = 0;
                MoveUp = 2;
            }

            if (MoveUp == 1)
            {
                jumpTimer = 0;
                jumpSpeed = 0;
            }

            if (MoveUp == 2)
            {
                jumpSpeed = 5;
                jumpTimer++;
                jumpOK = false;
                playerY -= jumpSpeed;


                if (jumpTimer >= 10)
                {
                    jumpSpeed--;
                    MoveUp = 3;
                    playerY -= jumpSpeed;
                    // jumpTimer = 0;
                }
            }

            if (MoveUp == 3)
            {
                jumpSpeed = 3;
                jumpTimer--;

                playerY += jumpSpeed;
            }
        }

        // NEW JUMP SYSTEM
        public void HeroJumpSmooth()
        {
            if (wDown == true && jumpOK == true)
            {
                backMedia.Stop();
                JumpPlayer.Play();
                gravity = -15;
                jumpOK = false;
            }
            jumpTimer++;
            playerY += gravity;
            gravity += 0.8f;
        }


        //COLLISION W FLOOR
        public void FloorCheck()
        {
            if (HeroRec.IntersectsWith(FloorRec))
            {
                playerY = 218.8f;
                gravity = 0;
                jumpOK = true;

            }
        }


        //SAFETY VARIABLES
        public static void ResetPosition1()
        {
            playerX = 20;
            playerY = 218.8f;
            playerWidth = 32;
            playerHeight = 56;
            playerSpeed = 3;
            jumpOK = true;
            jumpSpeed = 5;
            MoveUp = 1;
            playerImage = Properties.Resources.WALK1;

        }

        public void ResetPosition2()
        {
            playerX = 518;
            playerY = 218.8f;
            playerWidth = 32;
            playerHeight = 56;
            playerSpeed = 3;
            jumpOK = true;
            jumpSpeed = 5;
            MoveUp = 1;
            playerImage = Properties.Resources.WALK1;

        }

        public void LevelCheck()
        {
            if (playerX >= this.Width - playerWidth && level < 4)
            {
                level++;
                ResetPosition1();
            }
            if (playerX >= this.Width - playerWidth && level == 4)
            {
                playerX = this.Width - playerWidth;
            }
            if (playerX <= 0 && level > 0)
            {
                level--;
                ResetPosition2();
            }
            if (playerX <= 0 && level == 0)
            {
                playerX = 0;
            }
            if (dayCheck == true)
            {
                BlueBrush = new SolidBrush(Color.LightBlue);
            }
            if (dayCheck == false)
            {
                BlueBrush = new SolidBrush(Color.DarkBlue);
            }
        }

        public void WorkCheck()
        {
            if (HeroRec.IntersectsWith(WorkRec) && level == 4)
            {
                gameEngine.Enabled = false;
                playerX = playerX - 10;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                Work1 w1 = new Work1();
                f.Controls.Add(w1);
                w1.BringToFront();
                w1.Focus();
                this.Focus();
            }
        }

        public void AddPhoneScreen()
        {
            Form f = this.FindForm();
            Phone ph = new Phone();
            f.Controls.Add(ph);
            ph.BringToFront();
            George.showPhone = true;
        }

        public void RemovePhoneScreen()
        {

            George.showPhone = false;
        }

        public static void ResetGame()
        {
            playerX = 20;
            playerY = 218.8f;
            playerWidth = 32;
            playerHeight = 56;
            playerSpeed = 3;
            jumpOK = true;
            jumpSpeed = 5;
            MoveUp = 1;
            balance = 650;
            debt = 100;
            level = 0;
            dayCheck = true;
            ownCar = false;

        }
    }
}

