﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPhotoViewer
{
    public partial class createAlbum : Form
    {
        public album album { get; set; }
        public createAlbum()
        {
            album = new album();
            InitializeComponent();
        }

        private void createAlbum_Load(object sender, EventArgs e)
        {
            

        }

        //sauvegarde de l'album avec comme nom tbNameAlbum.text
        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            if(this.tbNameALbum.Text != null)
                album.name = this.tbNameALbum.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
