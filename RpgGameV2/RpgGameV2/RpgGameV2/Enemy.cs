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
        protected float moveSpeed;
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
        Direction[] randomDirection = { Direction.Right, Direction.Left, Direction.Up, Direction.Down };
        Random random = new Random();

        public Enemy(Point position, Point maxPos, Point minPos)
        {
            this.position = new Rectangle(position.X * gameSize, position.Y * gameSize, gameSize, gameSize);
            isAlive = true;
            currentTexture = new Rectangle(0, 0, frameWidth, frameHeight);
            this.maxPos = maxPos;
            this.minPos = minPos;
            currentDirection = Direction.Right;
        }

        public void Update(GameTime gameTime)
        {
            //TO ADD: Fix 100% collision rate in corner (checking wrong tile?).
            currentTexture.Width = frameWidth;
            currentTexture.Height = frameHeight;
            #region DirectionSwitcher(Based on the current direction "selected" keeps walking that way until reaching a tile.)
            switch (currentDirection)
            {
                case Direction.Right:
                    currentTexture.Y = 96;

                    if (Maps.MapOne[(position.Y / gameSize), (position.X / gameSize) + 1].isCollidable)
                        currentDirection = randomDirection[random.Next(0, 3)];
                    else
                    {
                        walkAnim(gameTime);
                        position.X += (int)moveSpeed;
                    }
                    break;
                case Direction.Left:
                    currentTexture.Y = 48;

                    if (Maps.MapOne[(position.Y / gameSize), (position.X / gameSize)].isCollidable)
                        currentDirection = randomDirection[random.Next(0, 3)];
                    else
                    {
                        walkAnim(gameTime);
                        position.X -= (int)moveSpeed;
                    }
                    break;
                case Direction.Up:
                    currentTexture.Y = 144;

                    if (Maps.MapOne[(position.Y / gameSize), (position.X / gameSize)].isCollidable)
                    {
                        for (int loop = 0; loop == 0; )
                        {
                            int dir = random.Next(0,3);
                            if (dir != 2)
                                loop = 1;
                        }
                        currentDirection = randomDirection[random.Next(0, 3)];

                    }
                    else
                    {
                        walkAnim(gameTime);
                        position.Y -= (int)moveSpeed;
                    }
                    break;
                case Direction.Down:
                    currentTexture.Y = 0;

                    if (Maps.MapOne[(position.Y / gameSize) + 1, (position.X / gameSize)].isCollidable)
                        currentDirection = randomDirection[random.Next(0, 3)];
                    else
                    {
                        walkAnim(gameTime);
                        position.Y += (int)moveSpeed;
                    }
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
                if (currentTexture.X > (sheetSize.X - 1) * gameSize)
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
