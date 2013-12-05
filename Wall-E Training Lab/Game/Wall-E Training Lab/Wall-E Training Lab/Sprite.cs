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
        private Texture2D texture;
        private Vector2 position;
        private Vector2 direction;
        private float speed;
        private Rectangle hitbox;

        /// CONSTRUCTEURS

        // Récupère ou définit l'image du sprite
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        // Récupère ou définit la position du Sprite
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        // Récupère ou définit la direction du sprite. Lorsque la direction est modifiée, elle est automatiquement normalisée.
        public Vector2 Direction
        {
            get { return direction; }
            set { direction = Vector2.Normalize(value); }
        }

        // Récupère ou définit la vitesse de déplacement du sprite.
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        
        // Récupère ou définit la hitbox du sprite.
        public Rectangle Hitbox
        {
            get { return hitbox; }
            set { hitbox = value; }
        }


        /// METHODES

        // Initialise les variables du Sprite
        public virtual void Initialize()
        {
            position = Vector2.Zero;
            direction = Vector2.Zero;
            speed = 0;
        }

        // Charge l'image voulue grâce au ContentManager donné
        public virtual void LoadContent(ContentManager content, string assetName)
        {
            texture = content.Load<Texture2D>(assetName);
        }

        // Met à jour les variables du sprite
        public virtual void Update(GameTime gameTime)
        {
        }

        // Permet de gérer les entrées du joueur
        public virtual void HandleInput(KeyboardState keyboardState, MouseState mouseState)
        {
        }

        // Dessine le sprite en utilisant ses attributs et le spritebatch donné
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
