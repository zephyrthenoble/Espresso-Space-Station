using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espresso_Space_Station
{
    public class MainGame: GameState
    {
        public List<Tile> tiles = new List<Tile>();
        public MainGame():base()
        {
            tiles.Add(new Tile());
        }
        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch b)
        {
            foreach(Tile t in tiles)
            {
                t.Draw(b);
            }
        }

        public override GameState Update(Microsoft.Xna.Framework.GameTime t)
        {
            return this;
        }
    }
}
