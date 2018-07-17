using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cut_Throat
{
    class Test
    {
        Goblin player1;
        Vector2 player1Spawn = new Vector2(300, 300);
        Color color;
        public Test()
        {
            player1 = new Goblin(player1Spawn);
        }

        public void Update()
        {
            MouseState mousestate = Mouse.GetState();
            if(player1.HitBox.Contains(mousestate.Position))
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Red;
            }
            player1.Update();
        }
        
        public void Draw(SpriteBatch sb)
        {
            player1.Draw(sb);
            sb.Draw(Textures.Pixel, new Rectangle(300 -3, 300 -3, 6, 6), color);
        }
    }
}
