using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Frogger.Levels;

namespace Frogger
{
    //I think I need to switch this over from an interface to a abstract class
    class GamePlayState:IGameState
    {
        Texture2D playerTex;
        SpriteFont font;
        Level currentLevel;
        Controller control;
        Player play;
        Camera camcam;
        

        public void Initialize()
        {
            //this is temporary
            play = new Player();
            camcam = new Camera();
            currentLevel = new TestLevel(play, camcam);
            currentLevel.InitMap(); // this needs to be called before currentlevel.getmap...()
            control = new Controller(camcam, currentLevel.getMapXDim(), currentLevel.getMapYDim());          
        }

        public void LoadContent(ContentManager content)
        {
            //inGameSprites = content.Load<Texture2D>("th9AEYNSAY");
            currentLevel.LoadSprites(content);
           
            font = content.Load<SpriteFont>("File");
        }
        
        public void Update(GameTime gt)
        {
            //offset = play.getPosition();
        
            control.UpdateControls(gt);
            currentLevel.UpdateStuff(gt);
        }
        public void Draw(SpriteBatch sb)
        {
            //instead of this, draw the current levels map.
            //sb.Draw(inGameSprites, Vector2.Zero, Color.White);
            currentLevel.Draw(sb);
            
            //store animation information within the player class
            
               // sb.Draw(playerTex, new Rectangle((640), (384), GamePlayState.resolution, GamePlayState.resolution), new Rectangle(0, 24, 42, 30), Color.White);
            sb.DrawString(font, camcam.Cx.ToString(), Vector2.Zero, Color.Black);
        }

        
    }
}
