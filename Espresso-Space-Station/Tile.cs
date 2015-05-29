using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espresso_Space_Station
{
    public class Tile: GameObject
    {
        public static Vector2 size = new Vector2(50, 50);
        public Vector2 gridposition;
        public Space space;
        public Floor floor;
        public Entity entity;
        public static Vector2 ConvertGridToPixels(Vector2 p)
        {
            return new Vector2(p.X * size.X, p.Y * size.Y);
        }
        public Tile(Vector2 position)
            : base(EspressoSpaceStation.sprites[SpriteText], ConvertGridToPixels(position))
        {
            gridposition = position;
        }
        public override void Draw(SpriteBatch b, Vector2 pos = default(Vector2), Color c = default(Color))
        {
            base.Draw(b, pos, c);

        }
    }
}
