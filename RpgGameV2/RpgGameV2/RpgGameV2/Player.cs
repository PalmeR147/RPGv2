using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace RpgGameV2
{
    class Player
    {

        #region VariablesAndObjects
        public static int gameSize = Game1.gameSize;

        public string Name = "Player";

        KeyboardState currentKey;

        private int health = 10;
        private int moveSpeed = 1;

        private double sizeMod = 0.75;

        private Rectangle currentTexture;
        private Rectangle position;
        private Texture2D playerSprite;

        private Point startPosition = new Point(1, 1);

        private enum Direction
        {
            Still,
            Right,
            Left,
            Up,
            Down
        }

        Direction currentDirection = Direction.Still;
        #endregion

        public Player(ContentManager content)
        {
            playerSprite = content.Load<Texture2D>("textures/PlayerSprite");
            currentTexture = new Rectangle(0, 0, 32, 32);
            position.X = startPosition.X * 32;
            position.Y = startPosition.Y * 32;
            position = new Rectangle(position.X, position.Y, (int)(gameSize * sizeMod), (int)(gameSize * sizeMod));
        }//The constructor of the player (allows more than one player to be created and controlled)

        public Rectangle GetCollisionBox()//A public function that returns the collision box of the player.
        {
            return new Rectangle(position.X, position.Y, gameSize, gameSize);
        }

        public void Update(GameTime gameTime)
        {
            currentKey = Keyboard.GetState(); //Checks which button is pressed down on the keyboard

            #region Movement Controls (Changes direction based on keypress)
            if (!(currentKey.IsKeyDown(Keys.None)) && (currentDirection == Direction.Still))//Ändrar vilken "direction" man är påväg åt när man trycker på den motsvarande piltangenten
            {
                if (currentKey.IsKeyDown(Keys.Right) && !(rightColliding()))
                    currentDirection = Direction.Right;
                if (currentKey.IsKeyDown(Keys.Left) && !(leftColliding()))
                    currentDirection = Direction.Left;
                if (currentKey.IsKeyDown(Keys.Up) && !(upColliding()))
                    currentDirection = Direction.Up;
                if (currentKey.IsKeyDown(Keys.Down) && !(downColliding()))
                    currentDirection = Direction.Down;
            }
            #endregion

            if (health <= 0)//If health drops below zero, change the current gamestate to GameOver.
            {
                //GameState GameOver
            }

            #region DirectionSwitcher(Based on the current direction "selected" keeps walking that way until reaching a tile.)
            switch (currentDirection)
            {
                case Direction.Right:
                        currentTexture.Y = 64;
                        position.X += moveSpeed;
                        charAnim(gameTime);
                        if (position.X % gameSize == 0)
                            currentDirection = Direction.Still;
                    break;
                case Direction.Left:
                        currentTexture.Y = 32;
                        position.X -= moveSpeed;
                        charAnim(gameTime);
                        if (position.X % gameSize == 0)
                            currentDirection = Direction.Still;
                    break;
                case Direction.Down:
                        currentTexture.Y = 0;
                        position.Y += moveSpeed;
                        charAnim(gameTime);
                        if (position.Y % gameSize == 0)
                            currentDirection = Direction.Still;
                    break;
                case Direction.Up:
                        currentTexture.Y = 96;
                        position.Y -= moveSpeed;
                        charAnim(gameTime);
                        if (position.Y % gameSize == 0)
                            currentDirection = Direction.Still;
                    break;
            }
            #endregion
        }//UpdateEnd

        #region Collision checking functions (checks the next tile in the direction chosen)
        private bool rightColliding()
        {
            if (Maps.MapOne[(position.Y / gameSize), (position.X / gameSize) + 1].isCollidable)
                return true;
            else
                return false;
        }
        private bool leftColliding()
        {
            if (Maps.MapOne[(position.Y / gameSize), (position.X / gameSize) - 1].isCollidable)
                return true;
            else
                return false;
        }
        private bool upColliding()
        {
            if (Maps.MapOne[(position.Y / gameSize) - 1, (position.X / gameSize)].isCollidable)
                return true;
            else
                return false;
        }
        private bool downColliding()
        {
            if (Maps.MapOne[(position.Y / gameSize) + 1, (position.X / gameSize)].isCollidable)
                return true;
            else
                return false;
        }
        #endregion
        #region WalkAnimation (Every Interval it changes texture to the "next" in the walk-Cycle)
        float timer = 0;
        float interval = 75;
        public void charAnim(GameTime gameTime)
        {
            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds / 2;

            if (timer > interval)
            {
                timer = 0;
                currentTexture.X += 32;
                if (currentTexture.X > 64)
                    currentTexture.X = 0;
            }
        }
        #endregion

        public void Draw(SpriteBatch spriteBatch)//A draw function for drawing objects on the screen
        {
            spriteBatch.Begin();
            spriteBatch.Draw(playerSprite, position, currentTexture, Color.White);
            spriteBatch.End();
        }
    }
}
