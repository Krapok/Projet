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
    public class Sprite
    {
        //TEXTURE
        private Texture2D texture;
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        //HITBOX
        private Rectangle hitbox;
        public Rectangle Hitbox
        {
            get { return hitbox; }
            set { hitbox = value; }
        }

        //TAILLE
        private Vector2 size;
        public Vector2 Size
        {
            get { return size; }
            set { size = value; }
        }


        /// METHODES

        // Initialise la hitbox du sprite
        public virtual void Initialize(Vector2 initialPosition, Vector2 initialSize)
        {
            hitbox = new Rectangle ((int)initialPosition.X, (int)initialPosition.Y, (int)initialSize.X, (int)initialSize.Y);
        }

        // Charge l'image voulue grâce au ContentManager donné
        public virtual void LoadContent(ContentManager content, string assetName)
        {
            texture = content.Load<Texture2D>(assetName);
        }

        // Dessine le sprite en utilisant ses attributs et le spritebatch donné
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, new Vector2 (hitbox.X, hitbox.Y), Color.White);
        }
    }
}
