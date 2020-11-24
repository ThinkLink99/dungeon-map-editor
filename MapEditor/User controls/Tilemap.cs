using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace MapEditor.User_controls
{
    public partial class Tilemap : UserControl
    {
        private int tileHeight = 0,
                    tileWidth = 0,
                    tilemapWidth = 0,
                    tilemapHeight = 0;

        private int progressValue = 0;
        private List<PictureBox> pictureBoxes;
        
        public int HorizontalScrollValue { get => hScrollBar1.Value; }
        public int VerticalScrollValue { get => vScrollBar1.Value; }

        public int TilemapHeight { get => tilemapHeight; set => tilemapHeight = value; }
        public int TilemapWidth { get => tilemapWidth; set => tilemapWidth = value; }

        public int TileHeight { get => tileHeight; set => tileHeight = value; }
        public int TileWidth { get => tileWidth; set => tileWidth = value; }

        public event Action<PictureBox, int, int, int> onTileClicked;
        public event Action<int> onTilemapLoading;

        public Tilemap()
        {
            InitializeComponent();
        }

        public void RedrawTiles (List<DungeonGeneration.Tile<Bitmap>> tiles)
        {
            if (tiles.Count == 0) { pictureBoxes.ForEach(p => p.Image = null); }
            foreach(Tile tile in tiles)
            {
                pictureBoxes[(int)(tile.X * tilemapWidth) + (int)tile.Y].Image = tile.Sprite as Bitmap;
            }
        }


        private void RebuildTilemap ()
        {
            Width = Parent.Width;
            Height = Parent.Height;
        }
        private void GeneratePictureBoxes ()
        {
            pictureBoxes = new List<PictureBox>();
            
            for (int x = 0; x < tilemapWidth; x++)
            {
                for (int y = 0; y < tilemapHeight; y++)
                {
                    var pb = new PictureBox();

                    pb.Size = new Size(32, 32);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.Location = new Point(x * tileWidth, y * tileHeight);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Click += TileClicked;

                    pictureBoxes.Add(pb);
                    progressValue += 1;
                    TilemapLoading();
                }
            }
        }
        private void SetPictureBoxParent ()
        {
            for (int x = 0; x < pictureBoxes.Count; x++)
            {
                pictureBoxes[x].Parent = panel1;
            }
        }
        private void DrawPictureBoxes ()
        {
            panel1.Location = new Point(-(HorizontalScrollValue * tileWidth), -(VerticalScrollValue * tileHeight));
            for (int x = 0; x < pictureBoxes.Count; x++)
            {
                if (pictureBoxes[x].Location.X < HorizontalScrollValue || pictureBoxes[x].Location.Y < VerticalScrollValue)
                {
                    pictureBoxes[x].Visible = false;
                }
                else
                {
                    pictureBoxes[x].Visible = true;
                }
            }
        }

        private void TileClicked (object sender, EventArgs e)
        {
            onTileClicked?.Invoke(sender as PictureBox, pictureBoxes.IndexOf(sender as PictureBox), (sender as PictureBox).Location.X / tileWidth, (sender as PictureBox).Location.Y / tileHeight);
        }
        private void TilemapLoading()
        {
            onTilemapLoading?.Invoke(progressValue);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DrawPictureBoxes();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DrawPictureBoxes();
        }

        private void Tilemap_Load(object sender, EventArgs e)
        {
            RebuildTilemap();

            progressBarUpdateTimer.Enabled = true;
            GeneratePictureBoxes();

            SetPictureBoxParent();
        }
    }
}
