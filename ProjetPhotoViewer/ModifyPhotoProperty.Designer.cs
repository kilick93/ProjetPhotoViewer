namespace ProjetPhotoViewer
{
    partial class ModifyPhotoProperty
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
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(172, 12);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(100, 98);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(12, 12);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(33, 13);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "rating";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(12, 51);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(51, 13);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "Comment";
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(12, 28);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(100, 20);
            this.tbRating.TabIndex = 3;
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(12, 67);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(154, 96);
            this.rtbComment.TabIndex = 5;
            this.rtbComment.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ModifyPhotoProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.pbPreview);
            this.Name = "ModifyPhotoProperty";
            this.Text = "ModifyPhotoProperty";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Button btnSave;
    }
}