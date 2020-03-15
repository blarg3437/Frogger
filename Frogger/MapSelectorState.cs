using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger
{
    class MapSelectorState : IGameState
    {

        Texture2D buttons;

        public void Initialize()
        {
            
        }

        public void LoadContent(ContentManager cm)
        {
            buttons = cm.Load<Texture2D>("buttons");
        }

        public void Update(GameTime gt)
        {
            
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(buttons, Vector2.Zero, Color.White);
        }
    }
}
