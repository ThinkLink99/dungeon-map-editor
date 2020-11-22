using DungeonGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor
{
    public class Room : IRoom
    {
        int id = 0,
            w = 0,
            h = 0;
        float x = 0,
              y = 0;

        List<ITile> tiles = new List<ITile>();

        public int ID { get => id; set => id = value; }

        public int NorthID { get; set; }
        public int SouthID { get; set; }
        public int EastID { get; set; }
        public int WestID { get; set; }

        public float OriginX { get => x; set => x = value; }
        public float OriginY { get => y; set => y = value; }

        public int Width { get => w; set => w = value; }
        public int Height { get => h; set => h = value; }

        public List<ITile> Tiles { get => tiles; set => tiles = value; }
    }
}
