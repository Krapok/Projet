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
    class Player
    {
        //FIELDS
        Vector2 initialPosition;
        Rectangle Hitbox;
        int speed = 2;

        Map World;
        List<Obstacle> obstacles;

        //CONSTRUCTOR
        public Player(Vector2 pos, Map whichworld)
        {
            World = whichworld;
            obstacles = World.Obstacles;
            initialPosition = pos;
            Hitbox = new Rectangle((int)initialPosition.X, (int)initialPosition.Y, 38, 48);
        }

        //METHODS

        //UPDATE & DRAW
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            if (keyboard.IsKeyDown(Keys.Z))
            {
                Rectangle newHitbox = new Rectangle(Hitbox.X, Hitbox.Y - speed, Hitbox.Width, Hitbox.Height);
                bool collide = false;
                foreach (Obstacle obstacle in obstacles)
                {
                    if (newHitbox.Intersects(obstacle.Hitbox))
                    {
                        collide = true;
                        break;
                    }
                }
                if (!collide)
                    Hitbox.Y -= speed;
            }
            else if (keyboard.IsKeyDown(Keys.S))
            {
                Rectangle newHitbox = new Rectangle(Hitbox.X, Hitbox.Y + speed, Hitbox.Width, Hitbox.Height);
                bool collide = false;
                foreach (Obstacle obstacle in obstacles)
                {
                    if (newHitbox.Intersects(obstacle.Hitbox))
                    {
                        collide = true;
                        break;
                    }
                }
                if (!collide)
                    Hitbox.Y += speed;
            }

            if (keyboard.IsKeyDown(Keys.Q))
            {
                Rectangle newHitbox = new Rectangle(Hitbox.X - speed, Hitbox.Y, Hitbox.Width, Hitbox.Height);
                bool collide = false;
                foreach (Obstacle obstacle in obstacles)
                {
                    if (newHitbox.Intersects(obstacle.Hitbox))
                    {
                        collide = true;
                        break;
                    }
                }
                if (!collide)
                    Hitbox.X -= speed;
            }
            else if (keyboard.IsKeyDown(Keys.D))
            {
                Rectangle newHitbox = new Rectangle(Hitbox.X + speed, Hitbox.Y, Hitbox.Width, Hitbox.Height);
                bool collide = false;
                foreach (Obstacle obstacle in obstacles)
                {
                    if (newHitbox.Intersects(obstacle.Hitbox))
                    {
                        collide = true;
                        break;
                    }
                }
                if (!collide)
                    Hitbox.X += speed;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Resources.Player, Hitbox, Color.White);
        }

    }
}
