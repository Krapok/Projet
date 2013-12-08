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
    class Level
    {
        //FIELDS
        Player localPlayer;
        Map localMap;
        


        //CONSTRUCTOR
        public Level (Vector2 pos, Map map)
        {
            localMap = map;
            localPlayer = new Player(pos,localMap);
        }

        //METHODS


        //UPDATE & DRAW
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            localPlayer.Update(mouse, keyboard);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            localMap.Draw(spritebatch);
            localPlayer.Draw(spritebatch);

        }
    }
}
