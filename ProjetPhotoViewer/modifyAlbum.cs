using System;
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
    public partial class modifyAlbum : Form
    {
        public album album { get; set; }
        public modifyAlbum(album modalbum)
        {
            InitializeComponent();
            album = new album();
            album.name = modalbum.name;
            tbNameAlbum.Text = modalbum.name;
        }

        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            if (this.tbNameAlbum.Text != null)
                album.name = this.tbNameAlbum.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
