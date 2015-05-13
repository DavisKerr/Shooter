using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Shooter.View;

namespace Shooter.Model
{
    class Enemy
    {
        public Animation EnemyAnimation;
        public Vector2 Position;
        public bool Active;
        public int Health;
        public int Damage;
        public int Value;
        float enemyMoveSpeed;
        public int Width
        {
            get { return EnemyAnimation.FrameWidth; }
        }
        public int Height
        {
            get { return EnemyAnimation.FrameHeight; }
        }

        public void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            EnemyAnimation = animation;

            // Set the position of the enemy
            Position = position;

            // We initialize the enemy to be active so it will be update in the game
            Active = true;


            // Set the health of the enemy
            Health = 10;

            // Set the amount of damage the enemy can do
            Damage = 10;

            // Set how fast the enemy moves
            enemyMoveSpeed = 6f;


            // Set the score value of the enemy
            Value = 100;

        }

        public void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement it's xposition
            Position.X -= enemyMoveSpeed;

            // Update the position of the Animation
            EnemyAnimation.Position = Position;

            // Update Animation
            EnemyAnimation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0 then deactivateit
            if (Position.X < -Width || Health <= 0)
            {
                // By setting the Active flag to false, the game will remove this objet fromthe 
                // active game list
                Active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw the animation
            EnemyAnimation.Draw(spriteBatch);
        }

    }
}
