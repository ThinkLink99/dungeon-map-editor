namespace MapEditor.User_controls
{
    partial class TilesheetLoader
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoadTileSheet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUrls = new System.Windows.Forms.ComboBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.panTileSet = new System.Windows.Forms.FlowLayoutPanel();
            this.ofdTileSetDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadTileSheet);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panTileSet);
            this.splitContainer1.Size = new System.Drawing.Size(228, 114);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnLoadTileSheet
            // 
            this.btnLoadTileSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTileSheet.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTileSheet.Location = new System.Drawing.Point(86, 84);
            this.btnLoadTileSheet.Name = "btnLoadTileSheet";
            this.btnLoadTileSheet.Size = new System.Drawing.Size(137, 25);
            this.btnLoadTileSheet.TabIndex = 11;
            this.btnLoadTileSheet.Text = "Load Tile Sheet";
            this.btnLoadTileSheet.UseVisualStyleBackColor = true;
            this.btnLoadTileSheet.Click += new System.EventHandler(this.btnLoadTileSheet_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmbUrls);
            this.panel1.Controls.Add(this.btnOpenFileDialog);
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 28);
            this.panel1.TabIndex = 9;
            // 
            // cmbUrls
            // 
            this.cmbUrls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUrls.FormattingEnabled = true;
            this.cmbUrls.Location = new System.Drawing.Point(3, 3);
            this.cmbUrls.Name = "cmbUrls";
            this.cmbUrls.Size = new System.Drawing.Size(162, 21);
            this.cmbUrls.TabIndex = 0;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFileDialog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileDialog.Location = new System.Drawing.Point(171, 3);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(43, 21);
            this.btnOpenFileDialog.TabIndex = 10;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // panTileSet
            // 
            this.panTileSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTileSet.AutoScroll = true;
            this.panTileSet.Location = new System.Drawing.Point(3, 51);
            this.panTileSet.Name = "panTileSet";
            this.panTileSet.Size = new System.Drawing.Size(220, 31);
            this.panTileSet.TabIndex = 3;
            // 
            // ofdTileSetDialog
            // 
            this.ofdTileSetDialog.FileName = "openFileDialog1";
            this.ofdTileSetDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdTileSetDialog_FileOk);
            // 
            // TilesheetLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TilesheetLoader";
            this.Size = new System.Drawing.Size(228, 114);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbUrls;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.FlowLayoutPanel panTileSet;
        private System.Windows.Forms.Button btnLoadTileSheet;
        private System.Windows.Forms.OpenFileDialog ofdTileSetDialog;
    }
}
