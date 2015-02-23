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
    public partial class diaporama : Form
    {
        public string[] folderFile = null;
        public int selected;
        public int begin;
        public int end;
        public album monalbum;

        public diaporama(album modalbum)
        {
            InitializeComponent();
            monalbum = modalbum;
            selected = 0;
            begin = 0;
            end = monalbum.images.Count;
            showImage(monalbum.images.ElementAt(selected));
                    
        }

        private void showImage(photo myphoto)
        {
            Image imgtemp = Image.FromFile(myphoto.path);
            pictureBox1.Image = imgtemp;
        }

        private void next_photo(object sender, EventArgs e)
        {
            if (selected == monalbum.images.Count - 1)
            {
                selected = 0;
                showImage(monalbum.images.ElementAt(selected));
            }
            else
            {
                selected = selected + 1;
                showImage(monalbum.images.ElementAt(selected));
            }
        }

        private void prev_photo(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                selected = monalbum.images.Count - 1;
                showImage(monalbum.images.ElementAt(selected));
            }
            else
            {
                selected = selected - 1;
                showImage(monalbum.images.ElementAt(selected));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selected < monalbum.images.Count)
            {
                showImage(monalbum.images.ElementAt(selected));
                selected++;
            }
            if (selected == monalbum.images.Count)
            {
                selected = 0;
            }
        }

        private void lancerdiap(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Interval = 2000;
                timer1.Start();
                timer1.Enabled = true;
                button3.Text = "Arretez le diaporama";
            }
            else
            {
                timer1.Enabled = false;
                button3.Text = "Lancer le diaporama";
            }
        }
    }
}
