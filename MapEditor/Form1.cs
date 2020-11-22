using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class Form1 : Form
    {
        private Bitmap selectedImage;

        public Form1()
        {
            InitializeComponent();

            tilemap1.onTilemapLoading += (int progress) =>
            {
                toolStripProgressBar1.Maximum = (tilemap1.TilemapHeight * tilemap1.TilemapWidth);
                toolStripProgressBar1.Value = progress;
                toolStripStatusLabel1.Text = $"{toolStripProgressBar1.Value}/{toolStripProgressBar1.Maximum}";
            };
            tilesheetLoader2.onTilemapLoading += (int progress, int maximum) =>
            {
                toolStripProgressBar1.Maximum = maximum;
                toolStripProgressBar1.Value = progress;
                toolStripStatusLabel1.Text = $"{toolStripProgressBar1.Value}/{toolStripProgressBar1.Maximum}";
            };
            tilemap1.onTileClicked += (PictureBox pb, int i) =>
            {
                if (roomBuilder1.SelectedRoom != null )
                {
                        pb.Image = selectedImage;
                    if (roomBuilder1.SelectedRoom.Tiles.Count <= i)
                    {
                        roomBuilder1.SelectedRoom.Tiles.Add(roomBuilder1.SelectedTile);
                    }
                    else if (roomBuilder1.SelectedRoom.Tiles[i] != roomBuilder1.SelectedTile)
                    {
                        roomBuilder1.SelectedRoom.Tiles[i] = roomBuilder1.SelectedTile;
                    }
                }
            };
            tilesheetLoader2.onTileSelected += (Bitmap b, int i) => { 
                selectedImage = b;
                roomBuilder1.SelectedTileImage.Image = selectedImage;
                roomBuilder1.TileProperties.SelectedObject = tilesheetLoader2.CreatedTiles[i];
                roomBuilder1.SelectedTile = tilesheetLoader2.CreatedTiles[i];
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roomBuilder1.onSelectedRoomChanged += (Room room) => { 
                Debug.WriteLine(room);
                propertyGrid1.SelectedObject = room;
            };
        }
    }
}
