using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace RpgGameV2
{
    static class MonsterMap
    {
        static int s = 1;
        static int z = 2;
        static int g = 3;
        static int u = 0;
        public static int[,] mobMap1 =
        {
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,},
            {u,0,0,0,0,0,0,0,0,0,u,u,u,u,u,u,u,u,0,0,0,0,0,0,u,},
            {u,0,0,0,0,0,0,0,u,0,0,0,0,s,0,0,0,0,0,0,0,0,0,0,u,},
            {u,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,s,0,0,u,},
            {u,0,u,0,u,0,0,0,0,0,u,u,u,u,u,u,u,u,0,0,0,0,0,s,u,},
            {u,0,u,u,u,0,u,u,u,u,u,u,u,u,u,u,u,u,0,0,0,0,0,0,u,},
            {u,0,0,0,0,0,u,u,u,u,u,u,u,u,u,u,u,u,0,0,0,0,0,0,u,},
            {u,0,0,0,u,u,u,u,u,u,u,u,u,u,u,u,u,u,0,0,0,0,0,0,u,},
            {u,0,0,0,u,u,u,u,u,u,u,u,u,u,u,u,u,u,0,0,0,0,0,0,0,},
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,0,0,0,0,0,0,0,},
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,0,0,0,0,0,0,u,},
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,},
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,},
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,},
            {u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u,u },
        };
        public static Enemy[,] MobMapOne = 
         {
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
            {null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null},
        };

        public static void CreateMaps(ContentManager content)
        {
            Point position;
            Point maxPos = new Point(500, 500);
            Point minPos = new Point(32, 32);
            for (int y = 0; y < mobMap1.GetLength(0); y++)
            {
                for (int x = 0; x < mobMap1.GetLength(1); x++)
                {
                    position = new Point(x, y);
                    if (mobMap1[y, x] == s)
                    {
                        MobMapOne[y, x] = new Skeleton(position, content, maxPos, minPos);
                    }
                }
            }
        }
        public static void DrawMobs(SpriteBatch spriteBatch)
        {
            foreach (Enemy e in MobMapOne)
            {
                if (e != null)
                    e.Draw(spriteBatch);
            }
        }
        public static void UpdateMobs(GameTime gameTime)
        {
            foreach (Enemy e in MobMapOne)
            {
                if (e != null)
                    e.Update(gameTime);
            }
        }
    }
}
