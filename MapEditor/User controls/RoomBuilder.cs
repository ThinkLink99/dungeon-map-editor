using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor.User_controls
{
    public partial class RoomBuilder : UserControl
    {
        List<Room> rooms;

        public event Action<Room> onSelectedRoomChanged;
        public event Action<Tile> onSelectedTileChanged;

        public PictureBox SelectedTileImage { get => pbTile; set => pbTile = value; }
        public Tile SelectedTile { get; set; }

        public PropertyGrid TileProperties { get => ptyTile; set => ptyTile = value; }

        public List<Room> Rooms { get => rooms; set => rooms = value; }

        public Room SelectedRoom 
        { 
            get 
            { 
                if (rooms.Count > 0) 
                { 
                    return rooms[treeRooms.SelectedNode == null ? 0 : treeRooms.SelectedNode.Index]; 
                } 
                else 
                { 
                    return null; 
                } 
            } 
            set 
            { 
                if (rooms.Count > 0) 
                { 
                    rooms[treeRooms.SelectedNode == null ? 0 : treeRooms.SelectedNode.Index] = value; 
                } 
            } 
        }

        public RoomBuilder()
        {
            InitializeComponent();
            rooms = new List<Room>();
        }

        public void RefreshTree()
        {
            foreach (var room in rooms)
            {
                treeRooms.Nodes.Add($"Room {room.ID}");
            }
        }

        private void SelectedRoomChanged()
        {
            if (treeRooms.SelectedNode == null) { onSelectedRoomChanged?.Invoke(null); }
            else { onSelectedRoomChanged?.Invoke(rooms[treeRooms.SelectedNode.Index]); }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var id = rooms.Count == 0 || 
                     rooms[treeRooms.Nodes.Count - 1] == null ? treeRooms.Nodes.Count + 1 : rooms[treeRooms.Nodes.Count - 1].ID + 1;
            treeRooms.Nodes.Add($"Room {id}");
            rooms.Add(new Room() { ID = id });
        }
        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            treeRooms.Nodes.Remove(treeRooms.SelectedNode);
            if (treeRooms.SelectedNode == null)
            {
                rooms.RemoveAt(0);
            }
            else
            {
                rooms.RemoveAt(treeRooms.SelectedNode.Index);
            }
            SelectedRoomChanged();
        }

        private void RoomBuilder_Load(object sender, EventArgs e)
        {
            splitContainer4.SplitterDistance = 25;
        }
        private void treeRooms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedRoomChanged();
        }

        private void ptyTile_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            onSelectedTileChanged?.Invoke(SelectedTile);
        }
    }
}
