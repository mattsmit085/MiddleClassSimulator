using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Jorj
{
    internal class product
    {
        public Image productImage;

        public int productX = 567;
        public  int productY = 255;
        public Rectangle productRec;

        public int speed = 10;
        public string type;

        public product(Image _image, string _type)
        {
            productImage = _image;
            type = _type;
        }

        public void move()
        {
            productX -= speed;
            productRec = new Rectangle(productX, productY, 45, 45);
        }
    }
}
