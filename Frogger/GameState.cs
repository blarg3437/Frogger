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
    interface IGameState
    {
        void Initialize();
        void LoadContent(ContentManager cm);
      
        void Update(GameTime gt);
        void Draw(SpriteBatch sb);
    }
    
}
