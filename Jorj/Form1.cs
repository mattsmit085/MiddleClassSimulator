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
    public partial class George : Form
    {
        //BRUSHES
        SolidBrush BlackBrush = new SolidBrush(Color.Black);
        SolidBrush WhiteBrush = new SolidBrush(Color.White);
        SolidBrush BlueBrush = new SolidBrush(Color.LightBlue);
        SolidBrush RedBrush = new SolidBrush(Color.Red);
        SolidBrush GreenBrush = new SolidBrush(Color.Green);
        SolidBrush DarkGreenBrush = new SolidBrush(Color.DarkGreen);
        SolidBrush YellowBrush = new SolidBrush(Color.Yellow);

        //LEVEL
        int floorX = 0;
        int floorY = 270;
        int floorHeight = 50;
        int floorWidth = 555;
        int wholefloorHeight = 125;
        float gravity = 10;

        //PLAYER
        int playerX = 20;
        float playerY = 218.8f;
        int playerWidth = 32;
        int playerHeight = 56;
        int playerSpeed = 3;
        bool jumpOK = true;
        int jumpSpeed = 5;
        int MoveUp = 1;

        int imageChangeTimer;
        int jumpTimer;
        Image playerImage = Properties.Resources.WALK1;

        //MOVEMENT
        bool wDown = false;
        bool aDown = false;
        bool sDown = false;
        bool dDown = false;
        bool shiftDown = false;

        Rectangle FloorRec;
        Rectangle HeroRec;

        public static bool showPhone = false;

        public George()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();

            this.Controls.Add(ms);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) { }

    }
}
    

