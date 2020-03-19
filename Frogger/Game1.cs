using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frogger
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>

    public enum gameStates
    {
        start,
        mapSelector,
        gamePlay,

    }
    public class Game1 : Game
    {
        public gameStates currentGameState;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GamePlayState gamep;
        MapSelectorState mapsel;
        public static int resolution = 64;
        private static int resX = 11;
        private static int resY = 9;
        public static int screenWidth = resX * resolution;
        public static int screenHeight = resY * resolution;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            gamep = new GamePlayState();
            mapsel = new MapSelectorState();
            currentGameState = gameStates.gamePlay;
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            IsMouseVisible = true;
            graphics.ApplyChanges();

            gamep.Initialize();
            mapsel.Initialize();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //call a scene switcher
            gamep.LoadContent(Content);
            mapsel.LoadContent(Content);
            // TODO: use this.Content to load your game content here
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (currentGameState == gameStates.start)
            {

            }
            if (currentGameState == gameStates.gamePlay)
            {
                gamep.Update(gameTime);
            }
            if (currentGameState == gameStates.mapSelector)
            {

            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (currentGameState == gameStates.gamePlay)
                    currentGameState = gameStates.mapSelector;
                else
                {
                    currentGameState = gameStates.gamePlay;
                }
            }

            base.Update(gameTime);
        }




        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            if (currentGameState == gameStates.start)
            {

            }
            if (currentGameState == gameStates.gamePlay)
            {
                gamep.Draw(spriteBatch);
            }
            if (currentGameState == gameStates.mapSelector)
            {
                mapsel.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
