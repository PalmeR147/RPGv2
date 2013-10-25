using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RpgGameV2
{
    class Skeleton : Enemy
    {
        public Skeleton(Rectangle position, ContentManager content, Point maxPos, Point minPos)
            : base(position, maxPos, minPos)
        {
            enemyTexture = content.Load<Texture2D>("textures/SkeletonSheet");
            sheetSize.X = 4;
            sheetSize.Y = 4;
            frameHeight = 48;
            frameWidth = 32;
            moveSpeed = 1;
            health = 10;
        }
    }
}
