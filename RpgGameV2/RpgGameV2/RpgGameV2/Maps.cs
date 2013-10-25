using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RpgGameV2
{
    static class Maps
    {
        
        public static int[,] map1 = 
         {                                                                                                       
            {85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,                       },
            {85,515,516,516,516,516,516,516,516,516,497,498,499,500,501,502,503,504,518,519,519,519,519,520,85,},
            {85,554,555,555,555,555,555,555,403,555,536,537,538,539,540,541,542,543,557,558,558,558,558,559,85,},
            {85,554,555,555,555,555,555,555,555,555,575,576,577,578,579,580,581,582,557,558,558,558,558,559,85,},
            {85,554,326,327,328,555,594,594,594,594,614,615,616,617,618,619,620,621,557,558,558,558,558,559,85,},
            {85,554,365,366,367,556,4,5,6,362,4,5,5,5,5,5,5,6,557,558,558,558,558,559,85,                      },
            {85,554,555,555,594,595,43,44,45,359,43,44,44,44,44,44,44,45,557,558,558,558,558,559,85,           },
            {85,554,555,556,4,5,123,44,45,398,43,44,44,44,44,44,44,45,557,558,558,558,558,559,85,              },
            {85,593,594,595,43,44,44,44,45,359,43,44,44,44,44,44,44,45,557,558,558,558,558,558,519,            },
            {85,4,5,5,123,44,44,44,45,398,43,44,44,44,44,44,44,45,557,558,558,558,558,558,597,                 },
            {85,43,44,44,44,44,44,44,45,359,82,83,83,83,83,83,83,84,596,597,597,597,597,598,85,                },
            {85,43,44,44,44,44,44,44,45,398,399,400,399,400,399,400,399,400,4,5,5,5,5,6,85,                    },
            {85,43,44,44,44,44,44,44,124,5,5,5,5,5,5,5,5,5,123,44,44,44,44,45,85,                              },
            {85,82,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,83,84,85,                       },
            {85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85                        },
        };

        public static int[,] colmap1 =
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
            {1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            {1,0,1,0,1,0,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,},
            {1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,},
            {1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,},
            {1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,},
            {1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
        };

        public static Tile[,] MapOne = 
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

        public static Texture2D baseTex;

        public static void CreateMaps(ContentManager content)
        {
            baseTex = content.Load<Texture2D>("textures/TileSetBase");
            for (int y = 0; y < MapOne.GetLength(0); y++)
            {
                for (int x = 0; x < MapOne.GetLength(1); x++)
                {
                    if (colmap1[y, x] == 0)
                        MapOne[y, x] = new Tile(map1[y, x], x, y, content, false);
                    if (colmap1[y, x] == 1)
                        MapOne[y, x] = new Tile(map1[y, x], x, y, content, true);

                }
            }
        }
        public static void DrawTiles(SpriteBatch spriteBatch)
        {
            foreach (Tile t in MapOne)
            {
                if (t != null)
                    t.Draw(spriteBatch);
            }
        }

    }
}
                                                       