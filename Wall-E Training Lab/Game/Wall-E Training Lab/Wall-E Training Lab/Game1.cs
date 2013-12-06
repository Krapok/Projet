using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Wall_E_Training_Lab
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //déclaration des sprites
        private Player wallE;
        private Sprite cube;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //initialisation wall E
            wallE = new Player();
            wallE.Initialize(new Vector2 (50,50), new Vector2 (37,49));

            //initialisation cube
            cube = new Sprite();
            cube.Initialize(Vector2.Zero, new Vector2 (32,32));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //chargement ressources wall E et cube
            wallE.LoadContent(Content, "player");
            cube.LoadContent(Content, "cube");
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Etats de la souris et du clavier
            KeyboardState keyboardState = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            //MaJ entrées joueurs et MaJ position wallE
            wallE.HandleInput(keyboardState, mouseState);
            wallE.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            //dessin walle et cube
            cube.Draw(spriteBatch, gameTime);
            wallE.Draw(spriteBatch, gameTime, new Rectangle(0,0,37,49));

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
