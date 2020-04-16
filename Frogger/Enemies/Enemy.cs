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
        public enum movementTypes
        {
          goforward,
          stop,
          turnaround,
          turnleft,
          turnright
        }
        //this will be a list of the movements that the enemy should perform
        private List<movementTypes> movementCircuit;
        public Enemy(int x, int y,int size = 1):base(x,y, size)
        {
            movementCircuit = new List<movementTypes>();
        }
        public void setMovementCircuit(List<movementTypes> input)
        {
            movementCircuit = input;
        }
        public virtual void defaultMove(GameTime gt)
        {
            //this 
        }
        public override void Update(GameTime gt)
        {
            defaultMove(gt);
        }
    }
}
