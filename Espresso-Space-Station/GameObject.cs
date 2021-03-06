﻿using Microsoft.Xna.Framework;
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

        public static virtual string SpriteText { 
            get { return "test"; }
        }
        
        


        public GameObject(Texture2D sprite, Vector2 position = default(Vector2), Rectangle frame = default(Rectangle), Color tint = default(Color))
        {
            this.sprite = sprite;
            if(position == default(Vector2))
            {
                position = new Vector2(0, 0);
            }
            if(frame == default(Rectangle))
            {
                frame = sprite.Bounds;
            }
            this.frame = frame;
            this.bounds = new Rectangle((int)position.X, (int)position.Y, (int)frame.Width, (int)frame.Height);

            if(tint == default(Color))
            {
                tint = Color.White;
            }
            this.tint = tint;
        }

        public virtual void Draw(SpriteBatch s, Vector2 pos = default(Vector2), Color c = default(Color))
        {
            s.Draw(sprite, bounds, frame, tint);
        }
        public virtual void Update(GameTime t)
        {

        }
    }
}
