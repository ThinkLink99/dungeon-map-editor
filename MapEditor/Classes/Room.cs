using DungeonGeneration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapEditor
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class Room : Room<Bitmap>
    {
        
    }
}
