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
            this.SuspendLayout();
            // 
            // tbNameALbum
            // 
            this.tbNameALbum.Location = new System.Drawing.Point(12, 40);
            this.tbNameALbum.Name = "tbNameALbum";
            this.tbNameALbum.Size = new System.Drawing.Size(100, 20);
            this.tbNameALbum.TabIndex = 0;
            this.tbNameALbum.Text = "mon album";
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(12, 130);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAlbum.TabIndex = 1;
            this.btnSaveAlbum.Text = "save";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // labelNameAlbum
            // 
            this.labelNameAlbum.AutoSize = true;
            this.labelNameAlbum.Location = new System.Drawing.Point(13, 13);
            this.labelNameAlbum.Name = "labelNameAlbum";
            this.labelNameAlbum.Size = new System.Drawing.Size(97, 13);
            this.labelNameAlbum.TabIndex = 2;
            this.labelNameAlbum.Text = "Name of the Album";
            this.labelNameAlbum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelNameAlbum);
            this.Controls.Add(this.btnSaveAlbum);
            this.Controls.Add(this.tbNameALbum);
            this.Name = "createAlbum";
            this.Text = "createAlbum";
            this.Load += new System.EventHandler(this.createAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameALbum;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.Label labelNameAlbum;
    }
}