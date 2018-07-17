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
        public Rectangle HitBox { get; protected set; }
        protected Texture2D Texture { get; set; }
        protected int CurrentFrame { get; set; }
        public Character(Vector2 position)
        {
            Health = 10000;
            CurrentFrame = 0;
            Position = position;
        }
        public virtual void Update()
        {
            HitBox = new Rectangle((int)Position.X - (HitBox.Width / 2), (int)Position.Y - HitBox.Height, HitBox.Width, HitBox.Height);
        }
        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(Texture, new Rectangle((int)Position.X-(HitBox.Width/2), (int)Position.Y-HitBox.Height, HitBox.Width, HitBox.Height), Color.Blue);
        }
    }
}