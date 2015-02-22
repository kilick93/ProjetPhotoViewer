namespace ProjetPhotoViewer
{
    partial class modifyAlbum
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
            this.labelNameAlbum = new System.Windows.Forms.Label();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.tbNameAlbum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNameAlbum
            // 
            this.labelNameAlbum.AutoSize = true;
            this.labelNameAlbum.Location = new System.Drawing.Point(12, 9);
            this.labelNameAlbum.Name = "labelNameAlbum";
            this.labelNameAlbum.Size = new System.Drawing.Size(97, 13);
            this.labelNameAlbum.TabIndex = 5;
            this.labelNameAlbum.Text = "Name of the Album";
            this.labelNameAlbum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(11, 126);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAlbum.TabIndex = 4;
            this.btnSaveAlbum.Text = "save";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // tbNameAlbum
            // 
            this.tbNameAlbum.Location = new System.Drawing.Point(15, 25);
            this.tbNameAlbum.Name = "tbNameAlbum";
            this.tbNameAlbum.Size = new System.Drawing.Size(100, 20);
            this.tbNameAlbum.TabIndex = 6;
            // 
            // modifyAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbNameAlbum);
            this.Controls.Add(this.labelNameAlbum);
            this.Controls.Add(this.btnSaveAlbum);
            this.Name = "modifyAlbum";
            this.Text = "modifyAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameAlbum;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.TextBox tbNameAlbum;
    }
}