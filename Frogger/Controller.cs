using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Frogger
{
    /// <summary>
    /// I would like to have this as partial so I can make the second half of the class be 
    /// determined by the specific level it belongs to. Think different keybinds for different levels
    /// </summary>
    partial class Controller
    {
        KeyboardState ks;
        MouseState ms;
        Camera camera;
        private int mapXBound, mapYBound;
        private float speed = 0.2f;


        public bool canControl = true;
        public Controller(Camera cam, int mapXDim, int mapYDim)
        {
            camera = cam;
            mapXBound = mapXDim;
            mapYBound = mapYDim;
        }
        public void UpdateControls(GameTime gt)
        {

            getMouseInput();
            getKeyboardInput(gt);

        }
        private void getMouseInput()
        {
            ms = Mouse.GetState();


        }

        private void getKeyboardInput(GameTime gt)
        {
            ks = Keyboard.GetState();
            //movement block
            if (canMove())
            {
                float moveamount = speed;
                if (ks.IsKeyDown(Keys.S))
                {
                    if(camera.Cy + camera.CgHeight + moveamount < mapYBound)
                    camera.setCY(moveamount);
                    return;
                }
                if(ks.IsKeyDown(Keys.W))
                {
                    if(camera.Cy - moveamount > 0)
                    camera.setCY(-moveamount);
                    return;
                }
                if (ks.IsKeyDown(Keys.D))
                {
                    if(camera.Cx + camera.CGWidth + moveamount < mapXBound)
                    camera.setCX(moveamount);
                    return;
                }
                if (ks.IsKeyDown(Keys.A))
                {
                    if(camera.Cx - moveamount > 0)
                    camera.setCX(-moveamount);
                    return;
                }
            }
        }

        private bool canMove()
        {
            return true;
        }
    }
}
