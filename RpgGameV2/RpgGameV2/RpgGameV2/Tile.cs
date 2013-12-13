using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace RpgGameV2
{
    public class Tile
    {
        private int id;
        private int xPos;
        private int yPos;
        private int gameSize = Game1.gameSize;

        private Rectangle texture;
        private Rectangle position;

        private int horizontalFrames = 39;
        private int frameSize = 16;

        public bool isCollidable;

        Texture2D mapTexture;

        public Tile(int id, int xPos, int yPos, ContentManager content, bool isCollidable)
        {
            this.id = id;
            this.xPos = xPos;
            this.yPos = yPos;

            if (id > horizontalFrames)
                texture = new Rectangle((id % horizontalFrames - 1) * frameSize, (id / horizontalFrames) * frameSize, frameSize, frameSize);
            else
                texture = new Rectangle((id - 1) * frameSize, (id / horizontalFrames) * frameSize, frameSize, frameSize);

            position = new Rectangle(xPos * gameSize, yPos * gameSize, gameSize, gameSize);
            mapTexture = content.Load<Texture2D>("textures/TileSetBase");
            
            this.isCollidable = isCollidable;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(mapTexture, position, texture, Color.White);
            spriteBatch.End();
        }
    }
}
