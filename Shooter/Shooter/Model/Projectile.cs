﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter.Model
{
    public class Projectile
    {
        public Texture2D Texture;
        public Vector2 Position;
        public bool Active;
        public int Damage;
        private Viewport viewport;
        public int Width
        {
            get { return Texture.Width; }
        }

        public int Height
        {
            get { return Texture.Height; }
        }
        private float projectileMoveSpeed;

        public void Initialize(Viewport viewport, Texture2D texture, Vector2 position, int damage, float speed)
        {
            Texture = texture;
            Position = position;
            this.viewport = viewport;

            Active = true;

            Damage = damage;

            projectileMoveSpeed = speed;
        }

        public void Update()
        {
            // Projectiles always move to the right
            Position.X += projectileMoveSpeed;

            // Deactivate the bullet if it goes out of screen
            if (Position.X + Texture.Width / 2 > viewport.Width)
                Active = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f,
            new Vector2(Width / 2, Height / 2), 1f, SpriteEffects.None, 0f);
        }
    }
}
