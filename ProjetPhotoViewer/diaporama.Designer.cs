namespace ProjetPhotoViewer
{
    partial class diaporama
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
            this.components = new System.ComponentModel.Container();
            this.PanelDiap = new System.Windows.Forms.Panel();
            this.pboxDiap = new System.Windows.Forms.PictureBox();
            this.btnPrec = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnDiap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.grpBoxDiap = new System.Windows.Forms.GroupBox();
            this.PanelDiap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiap)).BeginInit();
            this.grpBoxDiap.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDiap
            // 
            this.PanelDiap.AutoSize = true;
            this.PanelDiap.BackColor = System.Drawing.Color.Black;
            this.PanelDiap.Controls.Add(this.pboxDiap);
            this.PanelDiap.Location = new System.Drawing.Point(0, 3);
            this.PanelDiap.Name = "PanelDiap";
            this.PanelDiap.Size = new System.Drawing.Size(1168, 549);
            this.PanelDiap.TabIndex = 1;
            // 
            // pboxDiap
            // 
            this.pboxDiap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxDiap.Location = new System.Drawing.Point(0, 0);
            this.pboxDiap.Name = "pboxDiap";
            this.pboxDiap.Size = new System.Drawing.Size(1168, 549);
            this.pboxDiap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxDiap.TabIndex = 0;
            this.pboxDiap.TabStop = false;
            // 
            // btnPrec
            // 
            this.btnPrec.Location = new System.Drawing.Point(74, 10);
            this.btnPrec.Name = "btnPrec";
            this.btnPrec.Size = new System.Drawing.Size(216, 39);
            this.btnPrec.TabIndex = 1;
            this.btnPrec.Text = "<< Précédent";
            this.btnPrec.UseVisualStyleBackColor = true;
            this.btnPrec.Click += new System.EventHandler(this.prev_photo);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Location = new System.Drawing.Point(915, 10);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(235, 39);
            this.btnSuiv.TabIndex = 2;
            this.btnSuiv.Text = "Suivant >>";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.next_photo);
            // 
            // btnDiap
            // 
            this.btnDiap.Location = new System.Drawing.Point(637, 10);
            this.btnDiap.Name = "btnDiap";
            this.btnDiap.Size = new System.Drawing.Size(230, 40);
            this.btnDiap.TabIndex = 3;
            this.btnDiap.Text = "Lancer le diaporama";
            this.btnDiap.UseVisualStyleBackColor = true;
            this.btnDiap.Click += new System.EventHandler(this.lancerdiap);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(338, 9);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(250, 40);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.fullscreen_Click);
            // 
            // grpBoxDiap
            // 
            this.grpBoxDiap.Controls.Add(this.btnSuiv);
            this.grpBoxDiap.Controls.Add(this.btnDiap);
            this.grpBoxDiap.Controls.Add(this.btnFullScreen);
            this.grpBoxDiap.Controls.Add(this.btnPrec);
            this.grpBoxDiap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDiap.Location = new System.Drawing.Point(12, 558);
            this.grpBoxDiap.Name = "grpBoxDiap";
            this.grpBoxDiap.Size = new System.Drawing.Size(1156, 50);
            this.grpBoxDiap.TabIndex = 5;
            this.grpBoxDiap.TabStop = false;
            this.grpBoxDiap.Text = "Diaporama";
            // 
            // diaporama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1169, 622);
            this.Controls.Add(this.grpBoxDiap);
            this.Controls.Add(this.PanelDiap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "diaporama";
            this.Text = "Diaporama Viewer";
            this.Load += new System.EventHandler(this.diaporama_Load);
            this.PanelDiap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiap)).EndInit();
            this.grpBoxDiap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDiap;
        private System.Windows.Forms.PictureBox pboxDiap;
        private System.Windows.Forms.Button btnPrec;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnDiap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.GroupBox grpBoxDiap;
    }
}