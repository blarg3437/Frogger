using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger.Enemies
{
    class MultiTileEnemy : Enemy
    {
        protected int size;
        public int getSize() { return size; }
        public MultiTileEnemy(int x, int y, int size):base(x,y)
        {
            this.size = size;
        }
        public override void defaultMove(GameTime gt)
        {
          
        }
    }
}
