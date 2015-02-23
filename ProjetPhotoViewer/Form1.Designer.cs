namespace ProjetPhotoViewer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewAlbum = new System.Windows.Forms.ListView();
            this.columnFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAddtoAlbum = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadAlbum = new System.Windows.Forms.Button();
            this.btnCreateAlbum = new System.Windows.Forms.Button();
            this.listViewPhoto = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmsAlbum.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAlbum
            // 
            this.listViewAlbum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilename});
            this.listViewAlbum.ContextMenuStrip = this.cmsAlbum;
            this.listViewAlbum.Location = new System.Drawing.Point(13, 13);
            this.listViewAlbum.MultiSelect = false;
            this.listViewAlbum.Name = "listViewAlbum";
            this.listViewAlbum.Size = new System.Drawing.Size(121, 370);
            this.listViewAlbum.TabIndex = 0;
            this.listViewAlbum.UseCompatibleStateImageBehavior = false;
            this.listViewAlbum.View = System.Windows.Forms.View.List;
            this.listViewAlbum.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnFilename
            // 
            this.columnFilename.Text = "Filename";
            // 
            // cmsAlbum
            // 
            this.cmsAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAlbumToolStripMenuItem,
            this.modifyAlbumToolStripMenuItem});
            this.cmsAlbum.Name = "cmsAlbum";
            this.cmsAlbum.Size = new System.Drawing.Size(150, 48);
            // 
            // deleteAlbumToolStripMenuItem
            // 
            this.deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            this.deleteAlbumToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteAlbumToolStripMenuItem.Text = "delete album";
            this.deleteAlbumToolStripMenuItem.Click += new System.EventHandler(this.deleteAlbumToolStripMenuItem_Click);
            // 
            // modifyAlbumToolStripMenuItem
            // 
            this.modifyAlbumToolStripMenuItem.Name = "modifyAlbumToolStripMenuItem";
            this.modifyAlbumToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modifyAlbumToolStripMenuItem.Text = "modify album";
            this.modifyAlbumToolStripMenuItem.Click += new System.EventHandler(this.modifyAlbumToolStripMenuItem_Click_1);
            // 
            // btnAddtoAlbum
            // 
            this.btnAddtoAlbum.Location = new System.Drawing.Point(141, 388);
            this.btnAddtoAlbum.Name = "btnAddtoAlbum";
            this.btnAddtoAlbum.Size = new System.Drawing.Size(117, 23);
            this.btnAddtoAlbum.TabIndex = 2;
            this.btnAddtoAlbum.Text = "ajouter dans l\'album";
            this.btnAddtoAlbum.UseVisualStyleBackColor = true;
            this.btnAddtoAlbum.Click += new System.EventHandler(this.btnAddtoAlbum_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadAlbum
            // 
            this.btnLoadAlbum.Location = new System.Drawing.Point(264, 388);
            this.btnLoadAlbum.Name = "btnLoadAlbum";
            this.btnLoadAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAlbum.TabIndex = 3;
            this.btnLoadAlbum.Text = "load";
            this.btnLoadAlbum.UseVisualStyleBackColor = true;
            this.btnLoadAlbum.Click += new System.EventHandler(this.btnLoadAlbum_Click);
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateAlbum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCreateAlbum.Location = new System.Drawing.Point(13, 388);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(121, 23);
            this.btnCreateAlbum.TabIndex = 5;
            this.btnCreateAlbum.Text = "Create Album";
            this.btnCreateAlbum.UseVisualStyleBackColor = true;
            this.btnCreateAlbum.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // listViewPhoto
            // 
            this.listViewPhoto.Location = new System.Drawing.Point(141, 13);
            this.listViewPhoto.Name = "listViewPhoto";
            this.listViewPhoto.Size = new System.Drawing.Size(497, 370);
            this.listViewPhoto.TabIndex = 6;
            this.listViewPhoto.UseCompatibleStateImageBehavior = false;
            this.listViewPhoto.SelectedIndexChanged += new System.EventHandler(this.listViewPhoto_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Diaporama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.diaporama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewPhoto);
            this.Controls.Add(this.btnCreateAlbum);
            this.Controls.Add(this.btnLoadAlbum);
            this.Controls.Add(this.btnAddtoAlbum);
            this.Controls.Add(this.listViewAlbum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsAlbum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlbum;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.ColumnHeader columnFilename;
        private System.Windows.Forms.Button btnAddtoAlbum;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadAlbum;
        private System.Windows.Forms.Button btnCreateAlbum;
        private System.Windows.Forms.ContextMenuStrip cmsAlbum;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAlbumToolStripMenuItem;
        private System.Windows.Forms.ListView listViewPhoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

