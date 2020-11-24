using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class Form1 : Form
    {
        private Bitmap selectedImage;

        public Form1()
        {
            InitializeComponent();

            tilemap1.onTilemapLoading += onTilemapLoading;
            tilemap1.onTileClicked += onTileClicked;
            tilesheetLoader2.onTilemapLoading += onTilemapLoading;
            tilesheetLoader2.onTileSelected += onTileSelected;
            roomBuilder1.onSelectedRoomChanged += RoomBuilder1_onSelectedRoomChanged;
        }

        private void RoomBuilder1_onSelectedRoomChanged(Room obj)
        {
            tilemap1.RedrawTiles(obj.Tiles);
        }

        void onTilemapLoading(int progress)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Maximum = (tilemap1.TilemapHeight * tilemap1.TilemapWidth);
            toolStripProgressBar1.Value = progress;
            toolStripStatusLabel1.Text = $"{toolStripProgressBar1.Value}/{toolStripProgressBar1.Maximum}";

            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Visible = false;
            }
        }
        void onTilemapLoading (int progress, int maximum)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Maximum = maximum;
            toolStripProgressBar1.Value = progress;
            toolStripStatusLabel1.Text = $"{toolStripProgressBar1.Value}/{toolStripProgressBar1.Maximum}";

            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Visible = false;
            }
        }
        void onTileClicked (PictureBox pb, int i, int x, int y)
        {
            if (roomBuilder1.SelectedRoom != null)
            {
                var temp = new Tile();
                temp.Sprite = selectedImage;
                temp.X = x;
                temp.Y = y;
                temp.Dense = roomBuilder1.SelectedTile.Dense;
                temp.ID = roomBuilder1.SelectedTile.ID;

                pb.Image = selectedImage;
                if (roomBuilder1.SelectedRoom.Tiles.Count <= i)
                {
                    roomBuilder1.SelectedRoom.Tiles.Add(temp);
                }
                else if (roomBuilder1.SelectedRoom.Tiles[i] != temp)
                {
                    roomBuilder1.SelectedRoom.Tiles[i] = temp;
                }
            }
        }
        void onTileSelected (Bitmap b, int i)
        {
            selectedImage = b;
            roomBuilder1.SelectedTileImage.Image = selectedImage;
            roomBuilder1.TileProperties.SelectedObject = tilesheetLoader2.CreatedTiles[i];
            roomBuilder1.SelectedTile = tilesheetLoader2.CreatedTiles[i];
        }

        void OpenExportForm (string mode)
        {
            var form = new ExportForm(mode);
            form.LoadRooms(roomBuilder1.Rooms);
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roomBuilder1.onSelectedRoomChanged += (Room room) => { 
                Debug.WriteLine(room);
                propertyGrid1.SelectedObject = room;

            };
        }

        private void toJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExportForm("JSON");
        }
        private void toXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExportForm("XML");
        }

        private void fromJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            var json = "";
            using (StreamReader reader = new StreamReader(openFileDialog1.OpenFile()))
            {
                json = reader.ReadToEnd();
                reader.Close();
            }

            List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(json);

            roomBuilder1.Rooms = rooms;
            roomBuilder1.RefreshTree();
            tilemap1.RedrawTiles(rooms[0].Tiles);
        }
    }
}
