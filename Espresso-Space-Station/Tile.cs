using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espresso_Space_Station
{
    public class Tile: GameObject
    {
        public static Vector2 size = new Vector2(50, 50);
        public const string spritetext = "test";
        public Vector2 gridposition;
        public static Vector2 ConvertGridToPixels(Vector2 p)
        {
            return new Vector2(p.X * size.X, p.Y * size.Y);
        }
        public Tile(Vector2 position)
            : base(EspressoSpaceStation.sprites[spritetext], ConvertGridToPixels(position))
        {
            gridposition = position;
        }
    }
}
