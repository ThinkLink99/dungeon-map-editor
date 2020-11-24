using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace MapEditor
{
    public partial class ExportForm : Form
    {
        private List<Room> rooms;
        private string mode = "JSON";
        public ExportForm(string mode)
        {
            InitializeComponent();
            this.mode = mode;

            evExport.onNodeChanged += EvExport_onNodeChanged;
        }

        private void EvExport_onNodeChanged(int level, int index, int parentIndex)
        {
            string text = "";
            if (mode == "JSON")
            {
                if (level == 0)
                {
                    text = JsonConvert.SerializeObject(rooms[index], formatting: Newtonsoft.Json.Formatting.Indented);
                }
                else
                {
                    text = JsonConvert.SerializeObject(rooms[parentIndex].Tiles[index], formatting: Newtonsoft.Json.Formatting.Indented);
                }
            }
            else if (mode == "XML")
            {
                var room = rooms.Where(r => r == rooms[index]).Select(r => new { r.ID, r.NorthID, r.SouthID, r.WestID, r.EastID, r.Width, r.Height, r.OriginX, r.OriginY, Tiles = r.Tiles }).FirstOrDefault();

                XmlSerializer x = new XmlSerializer(room.GetType());
                using (StringWriter textWriter = new StringWriter())
                {
                    x.Serialize(textWriter, room);
                    text = textWriter.ToString();
                }
            }
            evExport.DisplayText(text);
        }

        public void LoadRooms (List<Room> rooms)
        {
            this.rooms = new List<Room>(rooms);

            foreach(Room room in this.rooms)
            {
                evExport.BuildTree(this.rooms);
            }
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            string ext = (mode == "JSON" ? ".json" : ".xml");

            string text = "";
            
            if (mode == "JSON") { text = JsonConvert.SerializeObject(rooms); }
            else if (mode == "XML")
            {
                var rooms = this.rooms.Select(r => new { r.ID, r.NorthID, r.SouthID, r.WestID, r.EastID, r.Width, r.Height, r.OriginX, r.OriginY, Tiles = r.Tiles }).FirstOrDefault();

                XmlSerializer x = new XmlSerializer((System.Type)rooms.GetType());
                using (StringWriter textWriter = new StringWriter())
                {
                    x.Serialize(textWriter, (object)rooms);
                    text = textWriter.ToString();
                }
            }

            saveFileDialog1.DefaultExt = ext;
            saveFileDialog1.ShowDialog();
            
            using (StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile()))
            {
                writer.WriteLine(text);
                writer.Close();
            }

            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
