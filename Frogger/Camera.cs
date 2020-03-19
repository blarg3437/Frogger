using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    class Camera
    {
        //make these private with an animation accesor in the future
        public float Cx { get; private set; }
        //These v & ^ are defined as grid coords, defining the top left of the viewframe, relative to the map array
        public float Cy { get; private set; }

        //these valuse can change, for instance zooming in or something, but most of the time these will be read only
        public int Cwidth = Game1.screenWidth;//These are in pixels
        public int Cheight = Game1.screenHeight;//these are in pixels
        public int CGWidth, CgHeight; // These are defined as Grid Coords

        public Camera(int Startx = 0, int StartY = 0)
        {
            Cx = Startx;
            Cy = StartY;
            CGWidth = 1 + Cwidth / Game1.resolution;
            CgHeight = 1 + Cheight / Game1.resolution;
        }

        public void setCY(float amount)
        {
            Cy += amount;
        }

        public void setCX(float amount)
        {
            Cx += amount;
        }
    }
}
