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
    class GameManager
    {
        //FIELDS
        Level Test;
        Map mapTest;
        Vector2 InitialPos;
        List<Obstacle> obstacles;

        //CONSTRUTOR
        public GameManager()
        {
            InitialPos = new Vector2(50,50);

            obstacles = new List<Obstacle>();
            obstacles.Add(new Obstacle(20, 20, Resources.Obstacle));
            obstacles.Add(new Obstacle(100, 120, Resources.Obstacle));

            mapTest = new Map(obstacles);

            Test = new Level(InitialPos, mapTest);
        }

        //METHODS


        //UPDATE & DRAW
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            Test.Update(mouse, keyboard);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            Test.Draw(spritebatch);
        }
        
    }
}
