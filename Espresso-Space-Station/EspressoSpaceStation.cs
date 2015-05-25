using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Espresso_Space_Station
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class EspressoSpaceStation : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        //TODO: move these to the appropriate files
        public static Dictionary<string, Texture2D> sprites = new Dictionary<string,Texture2D>();
        public static Dictionary<string, Texture2D> backgrounds = new Dictionary<string, Texture2D>();
        public EspressoSpaceStation()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);



            //Load sprites
            DirectoryInfo dir = new DirectoryInfo(Content.RootDirectory + @"\Sprites");
            if (!dir.Exists)
                throw new DirectoryNotFoundException();

            Debug.WriteLine("Starting files");
            FileInfo[] files = dir.GetFiles("*.xnb");
            string str = "";
            foreach (FileInfo file in files)
            {
                str = str + ", " + file.Name;
                string key = Path.GetFileNameWithoutExtension(file.Name);
                Debug.WriteLine(key);
                sprites[key] = Content.Load<Texture2D>(@"Sprites\" + key);
            }
            Debug.WriteLine(str);

            //Load fonts
            Text.LoadContent(Content);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
