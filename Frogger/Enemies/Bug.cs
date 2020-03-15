using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger.Enemies
{
    class Bug : Enemy
    {
        float speed = 0.1f;
        public Bug(int x, int y):base(x,y)
        {
            textureID = 0;
        }

        public override void defaultMove(GameTime gt)
        {
            posX += speed;
            if(posX > 8 || posX < 0)
            { speed *= -1; }
        }
    }
}
