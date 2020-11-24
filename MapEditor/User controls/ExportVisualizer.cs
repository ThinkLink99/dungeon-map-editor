using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonGeneration;

namespace MapEditor.User_controls
{
    public partial class ExportVisualizer : UserControl
    {
        public event Action<int,int,int> onNodeChanged;
        public ExportVisualizer()
        {
            InitializeComponent();
        }

        public void BuildTree(List<Room> nodes)
        {
            foreach(Room node in nodes)
            {
                tvExportTree.Nodes.Add($"Room #{node.ID}");
                if (node.Tiles.Count > 0) { BuildTree(node.Tiles, tvExportTree.Nodes[tvExportTree.Nodes.Count - 1]); }
            }
        }
        private void BuildTree(List<Tile<Bitmap>> nodes, TreeNode lastNode)
        {
            foreach (Tile<Bitmap> node in nodes)
            {
                lastNode.Nodes.Add(node.ID.ToString());
            }
        }

        public void DisplayText (string text)
        {
            rtbExportText.Text = text;
        }

        private void tvExportTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (tvExportTree.SelectedNode.Level == 0)
            //{
                onNodeChanged?.Invoke(tvExportTree.SelectedNode.Level, tvExportTree.SelectedNode.Index, tvExportTree.SelectedNode.Parent == null ? 0 : tvExportTree.SelectedNode.Parent.Index);
            //}
        }
    }
}
