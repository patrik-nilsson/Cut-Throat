using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cut_Throat
{
    static class Textures
    {
        public static Texture2D Pixel { get; private set; }
        public static void LoadContent(ContentManager Content)
        {
            Pixel = Content.Load<Texture2D>("Pixel");
        }
    }
}
