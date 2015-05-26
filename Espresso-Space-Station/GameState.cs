using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espresso_Space_Station
{
    public abstract class GameState
    {
        public abstract void Draw(SpriteBatch b);
        public abstract GameState Update(GameTime t);
    }
}
