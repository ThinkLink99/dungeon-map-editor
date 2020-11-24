namespace MapEditor.User_controls
{
    partial class ExportVisualizer
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
            this.tvExportTree = new System.Windows.Forms.TreeView();
            this.rtbExportText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvExportTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbExportText);
            this.splitContainer1.Size = new System.Drawing.Size(456, 497);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvExportTree
            // 
            this.tvExportTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvExportTree.Location = new System.Drawing.Point(0, 0);
            this.tvExportTree.Name = "tvExportTree";
            this.tvExportTree.Size = new System.Drawing.Size(152, 497);
            this.tvExportTree.TabIndex = 1;
            this.tvExportTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExportTree_AfterSelect);
            // 
            // rtbExportText
            // 
            this.rtbExportText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbExportText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExportText.Location = new System.Drawing.Point(0, 0);
            this.rtbExportText.Name = "rtbExportText";
            this.rtbExportText.Size = new System.Drawing.Size(300, 497);
            this.rtbExportText.TabIndex = 0;
            this.rtbExportText.Text = "";
            // 
            // ExportVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ExportVisualizer";
            this.Size = new System.Drawing.Size(456, 497);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvExportTree;
        private System.Windows.Forms.RichTextBox rtbExportText;
    }
}
