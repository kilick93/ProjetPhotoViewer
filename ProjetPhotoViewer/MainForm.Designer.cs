namespace ProjetPhotoViewer
{
    partial class MainForm
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
            this.ofdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.btnCreateAlbum = new System.Windows.Forms.Button();
            this.listViewPhoto = new System.Windows.Forms.ListView();
            this.cmsPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiapo = new System.Windows.Forms.Button();
            this.grpBoxAlbum = new System.Windows.Forms.GroupBox();
            this.grpBoxPhoto = new System.Windows.Forms.GroupBox();
            this.cmsAlbum.SuspendLayout();
            this.cmsPhoto.SuspendLayout();
            this.grpBoxAlbum.SuspendLayout();
            this.grpBoxPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAlbum
            // 
            this.listViewAlbum.AllowDrop = true;
            this.listViewAlbum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilename});
            this.listViewAlbum.ContextMenuStrip = this.cmsAlbum;
            this.listViewAlbum.Location = new System.Drawing.Point(10, 19);
            this.listViewAlbum.MultiSelect = false;
            this.listViewAlbum.Name = "listViewAlbum";
            this.listViewAlbum.Size = new System.Drawing.Size(122, 329);
            this.listViewAlbum.TabIndex = 0;
            this.listViewAlbum.UseCompatibleStateImageBehavior = false;
            this.listViewAlbum.View = System.Windows.Forms.View.List;
            this.listViewAlbum.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewAlbum_ItemDrag);
            this.listViewAlbum.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewAlbum.Click += new System.EventHandler(this.listViewAlbum_Click);
            this.listViewAlbum.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewAlbum_DragDrop);
            this.listViewAlbum.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewAlbum_DragEnter);
            this.listViewAlbum.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewAlbum_DragOver);
            this.listViewAlbum.DragLeave += new System.EventHandler(this.listViewAlbum_DragLeave);
            // 
            // columnFilename
            // 
            this.columnFilename.Text = "Filename";
            this.columnFilename.Width = 120;
            // 
            // cmsAlbum
            // 
            this.cmsAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAlbumToolStripMenuItem,
            this.modifyAlbumToolStripMenuItem});
            this.cmsAlbum.Name = "cmsAlbum";
            this.cmsAlbum.Size = new System.Drawing.Size(173, 48);
            // 
            // deleteAlbumToolStripMenuItem
            // 
            this.deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            this.deleteAlbumToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteAlbumToolStripMenuItem.Text = "Supprimer l\'album";
            this.deleteAlbumToolStripMenuItem.Click += new System.EventHandler(this.deleteAlbumToolStripMenuItem_Click);
            // 
            // modifyAlbumToolStripMenuItem
            // 
            this.modifyAlbumToolStripMenuItem.Name = "modifyAlbumToolStripMenuItem";
            this.modifyAlbumToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifyAlbumToolStripMenuItem.Text = "Modifier l\'album";
            this.modifyAlbumToolStripMenuItem.Click += new System.EventHandler(this.modifyAlbumToolStripMenuItem_Click_1);
            // 
            // btnAddtoAlbum
            // 
            this.btnAddtoAlbum.Location = new System.Drawing.Point(6, 354);
            this.btnAddtoAlbum.Name = "btnAddtoAlbum";
            this.btnAddtoAlbum.Size = new System.Drawing.Size(136, 39);
            this.btnAddtoAlbum.TabIndex = 2;
            this.btnAddtoAlbum.Text = "Ajouter Photo";
            this.btnAddtoAlbum.UseVisualStyleBackColor = true;
            this.btnAddtoAlbum.Click += new System.EventHandler(this.btnAddtoAlbum_Click);
            // 
            // ofdPhoto
            // 
            this.ofdPhoto.FileName = "openFileDialog1";
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateAlbum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCreateAlbum.Location = new System.Drawing.Point(10, 354);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(122, 39);
            this.btnCreateAlbum.TabIndex = 5;
            this.btnCreateAlbum.Text = "Créer un album";
            this.btnCreateAlbum.UseVisualStyleBackColor = true;
            this.btnCreateAlbum.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // listViewPhoto
            // 
            this.listViewPhoto.AllowDrop = true;
            this.listViewPhoto.ContextMenuStrip = this.cmsPhoto;
            this.listViewPhoto.Location = new System.Drawing.Point(8, 19);
            this.listViewPhoto.Name = "listViewPhoto";
            this.listViewPhoto.Size = new System.Drawing.Size(458, 329);
            this.listViewPhoto.TabIndex = 6;
            this.listViewPhoto.UseCompatibleStateImageBehavior = false;
            this.listViewPhoto.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewPhoto_ItemDrag);
            this.listViewPhoto.SelectedIndexChanged += new System.EventHandler(this.listViewPhoto_SelectedIndexChanged);
            this.listViewPhoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPhoto_DragDrop);
            this.listViewPhoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewPhoto_DragEnter);
            this.listViewPhoto.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewPhoto_DragOver);
            this.listViewPhoto.DragLeave += new System.EventHandler(this.listViewPhoto_DragLeave);
            this.listViewPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewPhoto_MouseDown);
            // 
            // cmsPhoto
            // 
            this.cmsPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyPhotoToolStripMenuItem,
            this.deletePhotoToolStripMenuItem,
            this.addToAlbumToolStripMenuItem});
            this.cmsPhoto.Name = "cmsPhoto";
            this.cmsPhoto.Size = new System.Drawing.Size(177, 70);
            // 
            // modifyPhotoToolStripMenuItem
            // 
            this.modifyPhotoToolStripMenuItem.Name = "modifyPhotoToolStripMenuItem";
            this.modifyPhotoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modifyPhotoToolStripMenuItem.Text = "Modifier la photo";
            this.modifyPhotoToolStripMenuItem.Click += new System.EventHandler(this.modifyPhotoToolStripMenuItem_Click);
            // 
            // deletePhotoToolStripMenuItem
            // 
            this.deletePhotoToolStripMenuItem.Name = "deletePhotoToolStripMenuItem";
            this.deletePhotoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deletePhotoToolStripMenuItem.Text = "Supprimer la photo";
            this.deletePhotoToolStripMenuItem.Click += new System.EventHandler(this.deletePhotoToolStripMenuItem_Click);
            // 
            // addToAlbumToolStripMenuItem
            // 
            this.addToAlbumToolStripMenuItem.Name = "addToAlbumToolStripMenuItem";
            this.addToAlbumToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addToAlbumToolStripMenuItem.Text = "Ajouter à l\'album";
            // 
            // btnDiapo
            // 
            this.btnDiapo.Location = new System.Drawing.Point(159, 354);
            this.btnDiapo.Name = "btnDiapo";
            this.btnDiapo.Size = new System.Drawing.Size(134, 39);
            this.btnDiapo.TabIndex = 8;
            this.btnDiapo.Text = "Diaporama";
            this.btnDiapo.UseVisualStyleBackColor = true;
            this.btnDiapo.Click += new System.EventHandler(this.diaporama_Click);
            // 
            // grpBoxAlbum
            // 
            this.grpBoxAlbum.Controls.Add(this.listViewAlbum);
            this.grpBoxAlbum.Controls.Add(this.btnCreateAlbum);
            this.grpBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAlbum.Location = new System.Drawing.Point(13, 12);
            this.grpBoxAlbum.Name = "grpBoxAlbum";
            this.grpBoxAlbum.Size = new System.Drawing.Size(138, 399);
            this.grpBoxAlbum.TabIndex = 9;
            this.grpBoxAlbum.TabStop = false;
            this.grpBoxAlbum.Text = "Albums";
            // 
            // grpBoxPhoto
            // 
            this.grpBoxPhoto.Controls.Add(this.listViewPhoto);
            this.grpBoxPhoto.Controls.Add(this.btnAddtoAlbum);
            this.grpBoxPhoto.Controls.Add(this.btnDiapo);
            this.grpBoxPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPhoto.Location = new System.Drawing.Point(166, 12);
            this.grpBoxPhoto.Name = "grpBoxPhoto";
            this.grpBoxPhoto.Size = new System.Drawing.Size(472, 399);
            this.grpBoxPhoto.TabIndex = 10;
            this.grpBoxPhoto.TabStop = false;
            this.grpBoxPhoto.Text = "Photos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(650, 423);
            this.Controls.Add(this.grpBoxPhoto);
            this.Controls.Add(this.grpBoxAlbum);
            this.Name = "MainForm";
            this.Text = "Projet Photo Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsAlbum.ResumeLayout(false);
            this.cmsPhoto.ResumeLayout(false);
            this.grpBoxAlbum.ResumeLayout(false);
            this.grpBoxPhoto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlbum;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.ColumnHeader columnFilename;
        private System.Windows.Forms.Button btnAddtoAlbum;
        private System.Windows.Forms.OpenFileDialog ofdPhoto;
        private System.Windows.Forms.Button btnCreateAlbum;
        private System.Windows.Forms.ContextMenuStrip cmsAlbum;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAlbumToolStripMenuItem;
        private System.Windows.Forms.ListView listViewPhoto;
        private System.Windows.Forms.Button btnDiapo;
        private System.Windows.Forms.ContextMenuStrip cmsPhoto;
        private System.Windows.Forms.ToolStripMenuItem modifyPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToAlbumToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxAlbum;
        private System.Windows.Forms.GroupBox grpBoxPhoto;
    }
}

