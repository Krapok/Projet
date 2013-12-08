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
    class Obstacle
    {
        //FIELDS
        Rectangle hitbox;

        public Rectangle Hitbox
        {
            get { return hitbox; }
            set { hitbox = value; }
        }

        Texture2D texture;

        //CONSTRUCTOR
        public Obstacle(int x, int y, Texture2D newTexture)
        {
            texture = newTexture;
            hitbox = new Rectangle(x, y, texture.Width, texture.Height);
        }


        //METHOD

        //UPDATE & DRAW
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, Hitbox, Color.White);
        }

    }
}
