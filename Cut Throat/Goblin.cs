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
    class Goblin : Character
    {
        int baseWidth = 200;
        int baseHeight = 250;
        public Goblin(Vector2 position) : base(position)
        {
            Texture = Textures.Pixel;
            HitBox = new Rectangle(0, 0, baseWidth, baseHeight);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Draw(SpriteBatch sb)
        {
            base.Draw(sb);
        }
    }
}
