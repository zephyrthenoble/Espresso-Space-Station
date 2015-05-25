using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espresso_Space_Station
{
    public class GameObject
    {
        //physical position of the object, from the top left
        public Rectangle bounds;
        //The sprite that we will use to draw
        public Texture2D sprite;
        //The position on the sprite that we will use to draw the image
        public Rectangle frame;
        //The tinting of the sprite when drawn
        public Color tint;



        public GameObject(Vector2 position)
        {
            ;
        }
        public void Draw(SpriteBatch s, Vector2 pos = default(Vector2), Color c = default(Color))
        {
            s.Draw(sprite, frame, bounds, tint);
        }
    }
}
