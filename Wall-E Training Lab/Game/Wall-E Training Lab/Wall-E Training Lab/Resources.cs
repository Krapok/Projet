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
    class Resources
    {
        //STATIC FIELDS
        public static Texture2D Player, Obstacle;

        //LOAD CONTENT
        public static void LoadContent(ContentManager content)
        {
            Player = content.Load<Texture2D>("walla");
            Obstacle = content.Load<Texture2D>("cube");
        }
    }

}
