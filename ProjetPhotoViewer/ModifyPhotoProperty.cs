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
    public partial class ModifyPhotoProperty : Form
    {
        public photo photo { get; set; }
        public ModifyPhotoProperty(photo modphoto)
        {
            InitializeComponent();
            photo = new photo();
            photo.path = modphoto.path;
            pbPreview.ImageLocation = photo.path;
            photo.rating = modphoto.rating;
            tbRating.Text = photo.rating.ToString();
            photo.comment = modphoto.comment;
            rtbComment.Text = photo.comment;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int value;
            if(int.TryParse(tbRating.Text, out value))
            {
                photo.rating = value;
            }
            if(rtbComment.Text != null)
                photo.comment = rtbComment.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
