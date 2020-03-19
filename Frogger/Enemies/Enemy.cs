using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger.Enemies
{
    abstract class Enemy : Entity
    {
        public Enemy(int x, int y,int size = 1):base(x,y, size)
        {

        }
        public abstract void defaultMove(GameTime gt);
        public override void Update(GameTime gt)
        {
            defaultMove(gt);
        }
    }
}
