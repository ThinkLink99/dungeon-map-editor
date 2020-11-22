using DungeonGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor
{
    public class Tile : ITile
    {
        public TILE_IDS ID { get; set; }

        public object Sprite { get; set; }

        public float X { get; set; }

        public float Y { get; set; }

        public bool Dense { get; set; }
    }
}
