using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Espresso_Space_Station
{
    public class MainGame: GameState
    {
        public Tile[,] tiles = new Tile[10,10];
        public MainGame():base()
        {
            for (int y = 0; y < tiles.GetLength(0); y++ )
            {
                for (   int x = 0; x < tiles.GetLength(1); x++ )
                {
                    Debug.WriteLine(y + " " + x);
                    tiles[x, y] = new Tile(new Vector2(x, y));
                }
            }
        }
        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch b)
        {
            foreach (Tile t in tiles)
            {
                if(t == null)
                {
                    continue;
                }
                t.Draw(b);
            }
        }

        public override GameState Update(Microsoft.Xna.Framework.GameTime t)
        {
            return this;
        }
    }
}
