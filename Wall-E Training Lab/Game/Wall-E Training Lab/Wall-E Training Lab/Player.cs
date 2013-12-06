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
    class Player : Sprite
    {
        //gère les entrées du joueur
        public virtual void HandleInput(Microsoft.Xna.Framework.Input.KeyboardState keyboardState, Microsoft.Xna.Framework.Input.MouseState mouseState)
        {
            if (keyboardState.IsKeyDown(Keys.Z))
            {
                Hitbox = new Rectangle(Hitbox.X, Hitbox.Y - 5, Hitbox.Width, Hitbox.Height);
            }
            else if (keyboardState.IsKeyDown(Keys.S))
            {
                Hitbox = new Rectangle(Hitbox.X, Hitbox.Y + 5, Hitbox.Width, Hitbox.Height);
            }

            if (keyboardState.IsKeyDown(Keys.Q))
            {
                Hitbox = new Rectangle(Hitbox.X - 5, Hitbox.Y, Hitbox.Width, Hitbox.Height);
            }
            else if (keyboardState.IsKeyDown(Keys.D))
            {
                Hitbox = new Rectangle(Hitbox.X + 5, Hitbox.Y, Hitbox.Width, Hitbox.Height);
            }
        }

        // Met à jour les variables du joueur
        public virtual void Update(GameTime gameTime)
        {
            Hitbox = new Rectangle(
                Hitbox.X,
                Hitbox.Y,
                (int)Size.X,
                (int)Size.Y);
        }

        // Dessine le joueur en utilisant ses attributs,le spritebatch donné, et le rectangle sur le sprite complet
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime, Rectangle textureRectangle)
        {
            spriteBatch.Draw(Texture, new Vector2(Hitbox.X, Hitbox.Y), textureRectangle, Color.White);
        }

    }
}
