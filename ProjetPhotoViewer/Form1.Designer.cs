﻿namespace ProjetPhotoViewer
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
            this.listViewFolder = new System.Windows.Forms.ListView();
            this.columnFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnAddtoAlbum = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadAlbum = new System.Windows.Forms.Button();
            this.flpAlbumViewer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // listViewFolder
            // 
            this.listViewFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilename});
            this.listViewFolder.Location = new System.Drawing.Point(13, 13);
            this.listViewFolder.Name = "listViewFolder";
            this.listViewFolder.Size = new System.Drawing.Size(121, 370);
            this.listViewFolder.TabIndex = 0;
            this.listViewFolder.UseCompatibleStateImageBehavior = false;
            this.listViewFolder.View = System.Windows.Forms.View.List;
            this.listViewFolder.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnFilename
            // 
            this.columnFilename.Text = "Filename";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(47, 389);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(87, 23);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
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
            // flpAlbumViewer
            // 
            this.flpAlbumViewer.Location = new System.Drawing.Point(141, 13);
            this.flpAlbumViewer.Name = "flpAlbumViewer";
            this.flpAlbumViewer.Size = new System.Drawing.Size(497, 370);
            this.flpAlbumViewer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 423);
            this.Controls.Add(this.flpAlbumViewer);
            this.Controls.Add(this.btnLoadAlbum);
            this.Controls.Add(this.btnAddtoAlbum);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.listViewFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.ColumnHeader columnFilename;
        private System.Windows.Forms.Button btnAddtoAlbum;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadAlbum;
        private System.Windows.Forms.FlowLayoutPanel flpAlbumViewer;
    }
}
