using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    /// <summary>
    /// This class like a normal array on steroids. Contains all the info that a map would need.
    /// </summary>
    class Map
    {
        
        //this will contain the information about the terrain
        private int[,] _terrainData;
        //this will contain things like the logs and stuff that moves
        private int[,] _moveableObjects;
        public readonly int terrainHeight;
        public readonly int terrainwidth;
        public int getMovableAt(int x, int y)
        { return _moveableObjects[x, y]; }
        public int getTerrainAt(int x, int y)
        {
            return _terrainData[x, y];
        }

        public Map(int width, int height)
        {
            _terrainData = new int[width, height];
            _moveableObjects = new int[width, height];
            terrainHeight = height;
            terrainwidth = height;
        }
        public void setTerrainMap(int[,] map)
        {
            _terrainData = map;
        }

        public void AddEnemy(Enemies.Enemy enemy)
        {           
            
            
        }

        public void addMultiTileEnemy(Enemies.MultiTileEnemy mte)
            {
            for (int i = 0; i < mte.getSize(); i++)
			{
                //inside of here add some if statements to determine the direction the loop should go in
                _moveableObjects[(int)mte.posX + i,(int)mte.posY] = mte.textureID;
			}

}

          
        public void randomizeTerrain()
        {
            Random rand = new Random();
            for (int i = 0; i < terrainwidth; i++)
            {
                for (int j = 0; j<terrainwidth; j++)
                {
                    _terrainData[i, j] = rand.Next(1, 3);
                }
            }
        }
        public void addHorizontalRoad()
        {
            for (int i = 0; i < terrainwidth; i++)
            {
                _terrainData[i, terrainHeight / 2] = 4;
                _terrainData[i, (terrainHeight / 2) + 1] = 4;
                _terrainData[i, (terrainHeight / 2) + 2] = 4;
                _terrainData[i, (terrainHeight / 2) + 3] = 4;
            }
        }

        public void updateEntityMap()
        { 
           
        }
    }
}
