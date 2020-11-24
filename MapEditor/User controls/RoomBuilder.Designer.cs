namespace MapEditor.User_controls
{
    partial class RoomBuilder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.treeRooms = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ptyTile = new System.Windows.Forms.PropertyGrid();
            this.pbTile = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(223, 371);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(215, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Room Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.treeRooms);
            this.splitContainer4.Size = new System.Drawing.Size(209, 339);
            this.splitContainer4.SplitterDistance = 122;
            this.splitContainer4.TabIndex = 1;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnAddRoom);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnRemoveRoom);
            this.splitContainer5.Size = new System.Drawing.Size(209, 122);
            this.splitContainer5.SplitterDistance = 95;
            this.splitContainer5.TabIndex = 8;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRoom.Location = new System.Drawing.Point(0, 0);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(95, 122);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveRoom.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(110, 122);
            this.btnRemoveRoom.TabIndex = 6;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // treeRooms
            // 
            this.treeRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeRooms.Location = new System.Drawing.Point(0, 0);
            this.treeRooms.Name = "treeRooms";
            this.treeRooms.Size = new System.Drawing.Size(209, 213);
            this.treeRooms.TabIndex = 1;
            this.treeRooms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeRooms_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ptyTile);
            this.tabPage2.Controls.Add(this.pbTile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(215, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tile Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ptyTile
            // 
            this.ptyTile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptyTile.Location = new System.Drawing.Point(6, 62);
            this.ptyTile.Name = "ptyTile";
            this.ptyTile.Size = new System.Drawing.Size(203, 277);
            this.ptyTile.TabIndex = 3;
            this.ptyTile.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ptyTile_PropertyValueChanged);
            // 
            // pbTile
            // 
            this.pbTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTile.Location = new System.Drawing.Point(6, 6);
            this.pbTile.Name = "pbTile";
            this.pbTile.Size = new System.Drawing.Size(50, 50);
            this.pbTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTile.TabIndex = 2;
            this.pbTile.TabStop = false;
            // 
            // RoomBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "RoomBuilder";
            this.Size = new System.Drawing.Size(223, 371);
            this.Load += new System.EventHandler(this.RoomBuilder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.TreeView treeRooms;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid ptyTile;
        private System.Windows.Forms.PictureBox pbTile;
    }
}
