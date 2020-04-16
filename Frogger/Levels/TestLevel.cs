using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Frogger.Levels
{
    /// <summary>
    /// You must call loadsprites on this class, and probably init
    /// </summary>
    class TestLevel : Level
    {
        
        public TestLevel(Player pl, Camera cam) : base(pl, cam)
        {
            entitiesOnMap = new List<Entity>();
            entitiesOnMap.Add(new Enemies.Bug(0, 0));
            entitiesOnMap.Add(new Enemies.Bug(2, 4));
            entitiesOnMap.Add(new Enemies.Bug(0, 1));
            entitiesOnMap.Add(new Enemies.Bug(4, 6));
            entitiesOnMap.Add(new Enemies.Bus(7, 3));

            //next, you should encode values into this here dictonary!
        }

        protected override void setTexAtlas()
        {
            TextureAtlas.Add(0, new Rectangle(0, 0, 64, 64));
            TextureAtlas.Add(1, new Rectangle(64, 0, 64, 64));
            TextureAtlas.Add(2, new Rectangle(128, 0, 64, 64));
            TextureAtlas.Add(3, new Rectangle(192, 0, 64, 64));
            TextureAtlas.Add(4, new Rectangle(256, 0, 64, 64));
        }

        public override void LoadSprites(ContentManager content)
        {
            //remember that this is not a general template for a level, put specific directories here.
            //BgSprites = content.Load<Texture2D>("Test64");
            moveableSprites = content.Load<Texture2D>("Test64");
            BgSprites = moveableSprites;
        }

        public override void InitMap()
        {
            int mapSize = 20;
            currentmap = new Map(mapSize, mapSize);
            currentmap.setTerrainMap(new int[mapSize, mapSize]);
            currentmap.randomizeTerrain();
            currentmap.addHorizontalRoad(6); 
            /*
            currentmap.setTerrainMap(new int[7, 7]
            {{0,0,0,0,0,0,0},
            { 0,1,0,1,0,1,0},
            { 0,1,0,1,0,1,0},
            { 0,1,0,1,0,1,0},
            { 0,1,0,1,0,1,0},
            { 0,1,0,1,0,1,0},
            { 0,0,0,1,0,1,0} }
            );
            */
            base.InitMap();
        }
    }
}