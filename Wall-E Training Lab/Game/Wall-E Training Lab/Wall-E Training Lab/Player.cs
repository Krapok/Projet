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
        bool jumping = false;
        int jumpRound = 50;
        float gravity = 5f;
        float jump = -5f;
        float coeffPhysicJump = 0.7f;
        float coeffPhysicGravity = 1.3f;
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            Vector2 movement = Vector2.Zero;

            if (keyboard.IsKeyDown(Keys.W))
            {
                if (!jumping)
                {
                    jump = -5f;
                    jumping = true;
                }
            }

            if (jumping && jumpRound > 0)
            {
                movement.Y = jump * coeffPhysicJump;
                jumpRound -= 1;
            }
            else
            {
                movement.Y = gravity * coeffPhysicGravity;
                jumping = false;
                jumpRound = 50; // Has to be the same as the init one
            }


            if (keyboard.IsKeyDown(Keys.A))
            {
                movement.X = -speed;
            }
            else if (keyboard.IsKeyDown(Keys.D))
            {
                movement.X = speed;
            }





            Rectangle newHitboxX = new Rectangle(Hitbox.X + (int)movement.X, Hitbox.Y, Hitbox.Width, Hitbox.Height);
            Rectangle newHitboxY = new Rectangle(Hitbox.X, Hitbox.Y + (int)movement.Y, Hitbox.Width, Hitbox.Height);

            if (!Collisions.IsColliding(newHitboxX, obstacles))
            {
                Hitbox.X += (int)movement.X;
            }
            if (!Collisions.IsColliding(newHitboxY, obstacles))
            {
                Hitbox.Y += (int)movement.Y;
            }
            else
            {
                jump = -5f;
                gravity = 5f;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Resources.Player, Hitbox, Color.White);
        }

    }
}
