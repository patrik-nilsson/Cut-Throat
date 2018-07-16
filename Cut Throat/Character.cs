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
    abstract class Character
    {
        protected int Health { get; set; }
        protected bool InAir { get; set; }
        protected bool Attacking { get; set; }
        protected bool Damaged { get; set; }
        protected Vector2 Position { get; set; }
        protected Vector2 HitBox { get; set; }
        protected Texture2D Texture { get; set; }
        protected int CurrentFrame { get; set; }
        public Character()
        {

        }
    }
}
