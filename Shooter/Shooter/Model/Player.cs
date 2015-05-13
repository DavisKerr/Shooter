using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Shooter.View;

namespace Shooter.Model
{
    public class Player
    {
        private Texture2D playerTexture;
        public Vector2 Position;
        private int health;
        private bool active;
        private int weapon;

        



        public Animation PlayerAnimation;

        public Texture2D PlayerTexture
        {
            get { return playerTexture; }
            set { playerTexture = value; }
        }


        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public int Width
        {
            get {return PlayerAnimation.FrameWidth;}
        }

        public int Height
        {
            get {return PlayerAnimation.FrameHeight;}
        }

        public int Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }



        public void Initialize(Animation animation, Vector2 position)
        {
            PlayerAnimation = animation;
            Position = position;
            Active = true;
            weapon = 1;
            Health = 100;

        }

        public void Update(GameTime gameTime)
        {
            PlayerAnimation.Position = Position;
            PlayerAnimation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            PlayerAnimation.Draw(spriteBatch);
            //spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }



    }
}
