using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger.Levels
{
   
    abstract class Level
    {
        protected Map currentmap;
        protected Texture2D BgSprites;
        protected Texture2D moveableSprites;
        protected Player player;
        protected Camera camera;
        private int res;
        protected List<Entity> entitiesOnMap;

        protected Dictionary<int, Rectangle> TextureAtlas;//for multitiles just specify alarger source rectangle
        public int getMapXDim() { return currentmap.terrainwidth; }
        public int getMapYDim() { return currentmap.terrainHeight; }


        public Level(Player play, Camera cam)
        {
            player = play;
            camera = cam;
            res = GamePlayState.resolution;
            TextureAtlas = new Dictionary<int, Rectangle>();
            setTexAtlas(); //call in init?
        }

        protected virtual void setTexAtlas()
        {
            //this method can be overridden for any specific level, and this virtual method will set
            //up the default rectangles 
            //TextureAtlas.Add(Texture, new Rectangle(0, 0, 64, 64));
        }
        public virtual void InitMap()
        {

        }
        public abstract void LoadSprites(ContentManager content);

        public void updateEntities()
        {

        }
        public void Draw(SpriteBatch sb)
        {
            DrawMap(sb);
            DrawEntities(sb);
        }
        protected virtual void DrawMap(SpriteBatch sb)
        {
            /*
             * sand : 102, 246
             * stone : 54, 6
             * grass : 198, 6
             * Bricks : 246, 150
             * */


            /*
             *this will almost act as a viewing matrix, taking the Camera's field of view,
             * and drawing everthing between it
             * */
            for (int x = (int)camera.Cx; x < camera.Cx + camera.CGWidth; x++)
            {
                for (int y = (int)camera.Cy; y < camera.Cy + camera.CgHeight; y++)
                {
                    //here I have the option to hardcode values, or hard...code them into a dictionary?

                   
                        //later make a method to clean this up, so I dont have to change values everytime.
                        //just have a map that contains all the drawing rectangles
                        sb.Draw(BgSprites,
                            new Rectangle((x - (int)camera.Cx) * res, (y - (int)camera.Cy) * res, res, res),
                            TextureAtlas[currentmap.getTerrainAt(x,y)],
                            Color.White);
                   

                }
            }
        }

        protected virtual void DrawEntities(SpriteBatch sb)
        {
            //we need to check that the entity is within the camera's view
            //then draw the coords * resolution

            foreach (Entity item in entitiesOnMap)
            {             
                //anything that made it this far is within the camera's field of view, and can be drawn
                
                  for (int i = 0; i < item.getSize(); i++)
			    {	
                sb.Draw(moveableSprites, new Rectangle(
                    ((int)item.posX - (int)camera.Cx - i) * res,
                    ((int)item.posY - (int)camera.Cy) * res,
                    res, res),
                    TextureAtlas[item.textureID],
                    Color.White);
                    
                }
                
            }

           

        }

        public virtual void UpdateStuff(GameTime gt)
        {
            updateEntities(gt);
        }

        protected virtual void updateEntities(GameTime gt)
        {
            foreach (Entity item in entitiesOnMap)
            {
                item.Update(gt);
            }
        }

       
    }
}
