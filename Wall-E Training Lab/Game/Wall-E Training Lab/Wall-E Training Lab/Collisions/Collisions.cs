using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Wall_E_Training_Lab
{
    static class Collisions
    {
        public static bool IsColliding(Rectangle newHitbox, List<Obstacle> obstacles)
        {
            foreach (Obstacle obstacle in obstacles)
            {
                if (newHitbox.Intersects(obstacle.Hitbox))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
