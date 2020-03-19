using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger.Enemies
{
    class Bus:MultiTileEnemy
    {
        float speed = 0.1f;
        public Bus(int x, int y):base(x,y,2)
        {
            textureID = 3;
        }

        public override void defaultMove(GameTime gt)
        {
             posX += speed;
            if(posX > 8 || posX < 0)
            { speed *= -1; }
        }

    }
}
