﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Espresso_Space_Station
{
    public class Text
    {
        //all fonts handled by text
        public static Dictionary<string, SpriteFont> fonts = new Dictionary<string, SpriteFont>();
        public SpriteFont font;
        public Color color;
        public Vector2 position;
        public string message;

        public const string DEFAULT_FONT = "Arial-12";


        public static Color DEFAULT_COLOR = Color.Black;

        public Text(string msg = "", Vector2 position = default(Vector2), SpriteFont f = default(SpriteFont), Color c = default(Color))
        {
            message = msg;
            if (f == default(SpriteFont))
            {
                f = fonts["Arial-12"];
            }
            font = f;
            if (c == default(Color))
            {
                c = DEFAULT_COLOR;
            }
            color = c;
            if (position == default(Vector2))
            {
                position = new Vector2(0, 0);
            }
            this.position = position;
        }


        public void changeMessage(string msg)
        {
            message = msg;
        }
        public static void LoadFont(string fontName, ContentManager content)
        {
            fonts[fontName] = content.Load<SpriteFont>("Fonts/" + fontName);
        }
        public static void LoadContent(ContentManager content)
        {
            DirectoryInfo dir = new DirectoryInfo(content.RootDirectory + @"\Fonts");
            if (!dir.Exists)
                throw new DirectoryNotFoundException();

            Console.WriteLine("Starting files");
            FileInfo[] files = dir.GetFiles("*.xnb");
            string str = "";
            foreach (FileInfo file in files)
            {
                str = str + ", " + file.Name;
                string key = Path.GetFileNameWithoutExtension(file.Name);
                Console.WriteLine(key);
                fonts[key] = content.Load<SpriteFont>(@"Fonts\" + key);
            }
            Console.WriteLine(str);
        }
        public string updateString(float maxLineWidth)
        {
            string[] blocks = message.Split('\n');
            StringBuilder sb = new StringBuilder();
            foreach (String block in blocks)
            {
                string[] words = block.Split(' ');

                float lineWidth = 0f;
                float spaceWidth = font.MeasureString(" ").X;

                foreach (string word in words)
                {
                    Vector2 size = font.MeasureString(word);

                    if (lineWidth + size.X < maxLineWidth)
                    {
                        sb.Append(word + " ");
                        lineWidth += size.X + spaceWidth;
                    }
                    else
                    {
                        sb.Append("\n" + word + " ");
                        lineWidth = size.X + spaceWidth;
                    }
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
        public Vector2 getMeasurements(float maxLineWidth)
        {
            return font.MeasureString(updateString(maxLineWidth));
        }
        public virtual void Draw(SpriteBatch s, Vector2 pos = default(Vector2), Color c = default(Color), float maxLineWidth = 0)
        {
            if (c == default(Color))
            {
                c = this.color;
            }
            if (pos == default(Vector2))
            {
                pos = position;
            }
            if (maxLineWidth != 0)
            {
                s.DrawString(font, updateString(maxLineWidth), pos, c);
            }
            else
            {
                s.DrawString(font, message, pos, c);
            }
        }
        public void Move(Vector2 pos)
        {
            position = pos;
        }
        /*public void draw(SpriteBatch sb, int x, int y)
        {
            //draws a string, params are your font, your message, position, and color
            if (font != null)
            {
                sb.DrawString(font, message, new Vector2(x, y), color);
            }
        }*/

    }
}