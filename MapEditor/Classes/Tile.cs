using DungeonGeneration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
namespace MapEditor
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Tile : Tile<Bitmap>
    {
        byte[] spriteBytes;

        public override Bitmap Sprite
        {
            get
            {
                MemoryStream ms = new MemoryStream(spriteBytes);
                return (Bitmap)Image.FromStream(ms);
            }
            set
            {
                MemoryStream ms = new MemoryStream();
                value.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                spriteBytes = ms.ToArray();
            }
        }

        [JsonProperty("Sprite")]
        public byte[] SpriteBytes
        {
            get
            {
                return spriteBytes;
            }
            set
            {
                spriteBytes = value;
            }
        }
    }
}
