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
    class GameWorld
    {
        private Sprite[] obstacles;
        private int endOfTheList;

        public int EndOfTheList
        {
            get { return endOfTheList; }
            set { endOfTheList = value; }
        }

        public Sprite[] Obstacles
        {
            get { return obstacles; }
            set { obstacles = value; }
        }

        public virtual void Initialize()
        {
            obstacles = new Sprite[50];
            endOfTheList = 0;
        }

        public virtual void AddObstacle(Sprite newObstacle)
        {
            Obstacles[endOfTheList] = newObstacle;
            endOfTheList++;
        }

        // Charge l'image voulue grâce au ContentManager donné
        public virtual void LoadContent(ContentManager content)
        {
            foreach (Sprite obstacle in Obstacles)
            {

            }
        }

        // Dessine le sprite en utilisant ses attributs et le spritebatch donné
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (Sprite obstacle in Obstacles)
            {

            }
        }

        public virtual void Update(GameTime gameTime)
        {
        }

    }
}
