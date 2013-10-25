using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace RpgGameV2
{
    abstract class Enemy
    {
        private Rectangle position;
        private Rectangle currentTexture;
        private Point maxPos;
        private Point minPos;
        private bool isAlive;
        protected Texture2D enemyTexture;
        protected float health;
        private int level;
        private int gameSize = Game1.gameSize;
        protected int moveSpeed;
        private Texture2D healthBar;
        protected int frameWidth;
        protected int frameHeight;
        protected Point sheetSize;

        private enum Direction
        {
            Still,
            Right,
            Left,
            Up,
            Down
        }
        Direction currentDirection;

        public Enemy(Rectangle position, Point maxPos, Point minPos)
        {
            this.position = position;
            isAlive = true;
            currentTexture = new Rectangle(0, 0, frameWidth, frameHeight);
            this.maxPos = maxPos;
            this.minPos = minPos;
        }

        public void Update(GameTime gameTime)
        {

            #region DirectionSwitcher(Based on the current direction "selected" keeps walking that way until reaching a tile.)
            switch (currentDirection)
            {
                case Direction.Right:
                    position.X += 1;
                    walkAnim(gameTime);
                    currentTexture.Y = 96;
                    if (position.X > maxPos.X)
                        currentDirection = Direction.Left;
                    break;
                case Direction.Left:
                    position.Y -= 1;
                    walkAnim(gameTime);
                    currentTexture.Y = 48;
                    if (position.X < minPos.X)
                        currentDirection = Direction.Right;
                    break;
            }
            #endregion
        }

        #region getCollisionBox
        public Rectangle GetCollisionBox()
        {
            return position;
        }
        #endregion
        #region WalkAnimation (Every Interval it changes texture to the "next" in the walk-Cycle)
        float timer = 0;
        float interval = 75;
        public void walkAnim(GameTime gameTime)
        {
            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds / 2;

            if (timer > interval)
            {
                timer = 0;
                currentTexture.X += frameWidth;
                if (currentTexture.X > sheetSize.X)
                    currentTexture.X = 0;
            }
        }
        #endregion


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            if (isAlive)
            {
                spriteBatch.Draw(enemyTexture, position, currentTexture, Color.White);
            }
            spriteBatch.End();
        }
    }
}
