using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MapEditor.User_controls
{
    public partial class TilesheetLoader : UserControl
    {
        public class TileSheetNode
        {
            public string TileSheetName { get; set; }
            public List<Tile> TileData { get; set; }
            public string TileSheetUrl { get; set; }
        }

        private int SpriteSize = 16;
        private List<PictureBox> tiles;
        private List<Tile> createdTiles;

        public event Action<Bitmap, int> onTileSelected;
        public event Action<int, int> onTilemapLoading;

        public List<Tile> CreatedTiles => createdTiles;

        public TilesheetLoader()
        {
            InitializeComponent();

            tiles = new List<PictureBox>();
            PopulateSpriteSheetCombobox();
        }

        private PictureBox CreateNewPictureBox(Size size, Control parent)
        {
            PictureBox pb = new PictureBox();
            pb.Size = size;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Parent = parent;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            pb.Click += delegate
            {
                onTileSelected?.Invoke(pb.Image as Bitmap, tiles.IndexOf(pb));
            };
            return pb;
        }
        private void LoadSpriteSheet(string url)
        {
            if (string.IsNullOrEmpty(url)) { return; }
            createdTiles = new List<Tile>();

            if (FindNodeByUrl(url, out TileSheetNode node))
            {
                createdTiles = node.TileData;
                tiles = new List<PictureBox>();
                int i = 0;
                foreach (Tile tile in createdTiles)
                {
                    tiles.Add(CreateNewPictureBox(new Size(64, 64), panTileSet));
                    tiles[i].Image = tile.Sprite as Bitmap;
                    i++;
                    onTilemapLoading?.Invoke(i, createdTiles.Count);
                }
            }
            else
            {
                Bitmap spritesheet = new Bitmap(url);
                tiles.ForEach(t => t.Image = null);

                // split into multiple new bitmaps with sizes of SpriteSize 
                int numTilesHorizontal = spritesheet.Width / SpriteSize;
                int numTilesVertical = spritesheet.Height / SpriteSize;

                int offset = 0;
                for (int y = 0; y < numTilesVertical; y++)
                {
                    for (int x = 0; x < numTilesHorizontal; x++)
                    {
                        if (x + offset + y >= tiles.Count) { tiles.Add(CreateNewPictureBox(new Size(64, 64), panTileSet)); }
                        tiles[x + offset + y].Image = CropImage(spritesheet, new Rectangle(x * SpriteSize, y * SpriteSize, SpriteSize, SpriteSize));

                        createdTiles.Add(new Tile() { Sprite = tiles[x + offset + y].Image as Bitmap });
                        onTilemapLoading?.Invoke(x + offset + y + 1, (numTilesVertical * numTilesHorizontal));
                    }
                    offset += numTilesHorizontal - 1;
                }

                TileSheetNode tileSheetNode = new TileSheetNode();
                tileSheetNode.TileSheetUrl = url;
                tileSheetNode.TileData = createdTiles;
                tileSheetNode.TileSheetName = url.Split('\\')[url.Split('\\').Length - 1];

                SaveNode(tileSheetNode);
            }
        }
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                return bitmap;
            }
        }

        private void PopulateSpriteSheetCombobox()
        {
            foreach (string url in GetStoredUrls())
            {
                cmbUrls.Items.Add(url);
            }
        }
        private void SaveNewURL(string url)
        {
            if (Properties.Settings.Default.storedUrls == null) { Properties.Settings.Default.storedUrls = new System.Collections.Specialized.StringCollection(); }
            if (Properties.Settings.Default.storedUrls.Contains(url)) { return; }

            Properties.Settings.Default.storedUrls.Add(url);

            Properties.Settings.Default.Save();
        }
        private void RemoveURL(string url)
        {
            if (!Properties.Settings.Default.storedUrls.Contains(url)) { return; }

            Properties.Settings.Default.storedUrls.Remove(url);

            Properties.Settings.Default.Save();
        }

        private void SaveNode (TileSheetNode node)
        {
            List<TileSheetNode> nodes = JsonConvert.DeserializeObject<List<TileSheetNode>>(Properties.Settings.Default.storedTileSheets);
            if (nodes == null) { nodes = new List<TileSheetNode>(); }
            nodes.Add(node);
            Properties.Settings.Default.storedTileSheets = JsonConvert.SerializeObject(nodes);
            Properties.Settings.Default.Save();
        }
        private bool FindNodeByUrl (string url, out  TileSheetNode node)
        {
            List<TileSheetNode> nodes = JsonConvert.DeserializeObject<List<TileSheetNode>>(Properties.Settings.Default.storedTileSheets);
            if (nodes == null) { node = null;  return false; }

            node = nodes.Where(n => n.TileSheetUrl == url).FirstOrDefault();
            return node != null;
        }

        private System.Collections.Specialized.StringCollection GetStoredUrls()
        {
            if (Properties.Settings.Default.storedUrls == null) { Properties.Settings.Default.storedUrls = new System.Collections.Specialized.StringCollection(); Properties.Settings.Default.Save(); }
            return Properties.Settings.Default.storedUrls;
        }

        private void btnLoadTileSheet_Click(object sender, EventArgs e)
        {
            LoadSpriteSheet(cmbUrls.Text);
        }
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            ofdTileSetDialog.ShowDialog();
        }
        private void ofdTileSetDialog_FileOk(object sender, CancelEventArgs e)
        {
            cmbUrls.Text = ofdTileSetDialog.FileName;
        }
    }
}
