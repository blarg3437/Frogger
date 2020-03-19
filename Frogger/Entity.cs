using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger
{
    abstract class Entity
    {
        public float posX { get; protected set; }
        public float posY { get; protected set; }
        
        public int textureID { get; protected set; }//this value will be the dictonary key for the texture atlas
        public int rotation { get; protected set; }
        public float speed { get; protected set; }
       protected int size;
        public int getSize() { return size; }

        public Entity( int x = 0, int y = 0, int size = 1)
        {
            posX = x;
            posY = y;
            speed = 10;
         this.size = size;
        }
        public bool moveUnit(float x, float y)
        {
            posX += x;
            posY += y;
            //check for collision here, I will
            return true;
        }

        public void setY(float y)
        {
            posY = y;
        }

        public void setX(float x)
        {
            posX = x;
        }
        
        public void drawEntity(SpriteBatch sb)
        {
          
        }

        //this method will contain commands on how the entity should randomly move
       
       
        public virtual void Update(GameTime gt)
        {
           
        }
    }
}
