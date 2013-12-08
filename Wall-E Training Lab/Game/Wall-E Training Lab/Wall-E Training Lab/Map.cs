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
    class Map
    {
        //FIELDS
        List<Obstacle> obstacles;

        internal List<Obstacle> Obstacles
        {
            get { return obstacles; }
            set { obstacles = value; }
        }

        //CONSTRUCTOR
        public Map(List<Obstacle> newObstacles)
        {
            obstacles = newObstacles;
        }

        //METHODS

        //UPDATE & DRAW
        public void Upgrade(MouseState mouse, KeyboardState keyboard)
        {
        }

        public void Draw(SpriteBatch spritebatch)
        {
            foreach (Obstacle obstacle in Obstacles)
            {
                obstacle.Draw(spritebatch);
            }
        }
    }
}
