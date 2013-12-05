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
    class WallE : Sprite
    {
        //gère les entrées du joueur
        public override void HandleInput(Microsoft.Xna.Framework.Input.KeyboardState keyboardState, Microsoft.Xna.Framework.Input.MouseState mouseState)
        {
            if (keyboardState.IsKeyDown(Keys.Z))
            {
                Direction = -Vector2.UnitY;
                Speed = 0.2F;
            }
            else if (keyboardState.IsKeyDown(Keys.S))
            {
                Direction = Vector2.UnitY;
                Speed = 0.2F;
            }

            if (keyboardState.IsKeyDown(Keys.Q))
            {
                Direction = -Vector2.UnitX;
                Speed = 0.2F;
            }
            else if (keyboardState.IsKeyDown(Keys.D))
            {
                Direction = Vector2.UnitX;
                Speed = 0.2F;
            }
        }

        // Met à jour les variables du sprite
        public override void Update(GameTime gameTime)
        {
            Position += Direction * Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            Hitbox = new Rectangle(
                (int)Position.X,
                (int)Position.Y,
                (int)Texture.Width,
                (int)Texture.Height);
        }

    }
}
