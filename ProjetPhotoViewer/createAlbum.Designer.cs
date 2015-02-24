namespace ProjetPhotoViewer
{
    partial class createAlbum
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNameALbum = new System.Windows.Forms.TextBox();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.labelNameAlbum = new System.Windows.Forms.Label();
            this.grpBoxCreateAlbum = new System.Windows.Forms.GroupBox();
            this.grpBoxCreateAlbum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNameALbum
            // 
            this.tbNameALbum.Location = new System.Drawing.Point(6, 76);
            this.tbNameALbum.Name = "tbNameALbum";
            this.tbNameALbum.Size = new System.Drawing.Size(150, 20);
            this.tbNameALbum.TabIndex = 0;
            this.tbNameALbum.Text = "Mon Album";
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(6, 158);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(150, 36);
            this.btnSaveAlbum.TabIndex = 1;
            this.btnSaveAlbum.Text = "Enregistrer";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // labelNameAlbum
            // 
            this.labelNameAlbum.AutoSize = true;
            this.labelNameAlbum.Location = new System.Drawing.Point(3, 51);
            this.labelNameAlbum.Name = "labelNameAlbum";
            this.labelNameAlbum.Size = new System.Drawing.Size(79, 13);
            this.labelNameAlbum.TabIndex = 2;
            this.labelNameAlbum.Text = "Nom de l\'album";
            this.labelNameAlbum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpBoxCreateAlbum
            // 
            this.grpBoxCreateAlbum.Controls.Add(this.btnSaveAlbum);
            this.grpBoxCreateAlbum.Controls.Add(this.labelNameAlbum);
            this.grpBoxCreateAlbum.Controls.Add(this.tbNameALbum);
            this.grpBoxCreateAlbum.Location = new System.Drawing.Point(31, 12);
            this.grpBoxCreateAlbum.Name = "grpBoxCreateAlbum";
            this.grpBoxCreateAlbum.Size = new System.Drawing.Size(162, 212);
            this.grpBoxCreateAlbum.TabIndex = 3;
            this.grpBoxCreateAlbum.TabStop = false;
            this.grpBoxCreateAlbum.Text = "Création Album";
            // 
            // createAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(220, 247);
            this.Controls.Add(this.grpBoxCreateAlbum);
            this.Name = "createAlbum";
            this.Text = "Création Album";
            this.Load += new System.EventHandler(this.createAlbum_Load);
            this.grpBoxCreateAlbum.ResumeLayout(false);
            this.grpBoxCreateAlbum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameALbum;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.Label labelNameAlbum;
        private System.Windows.Forms.GroupBox grpBoxCreateAlbum;
    }
}