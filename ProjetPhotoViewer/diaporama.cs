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
        private FullScreen fullScreen = new FullScreen();

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
            suivant();
        }

        private void suivant()
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
            precedent();
        }

        private void precedent()
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

        private void fullscreen_Click(object sender, EventArgs e)
        {
            if (!this.fullScreen.IsFullScreen)
            {
                // Cacher les boutons et afficher les diapos en plein ecran
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.button3.Visible = false;
                this.button4.Visible = false;
                this.panel1.Dock = DockStyle.Fill;

                fullScreen.EnterFullScreen(this);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (this.fullScreen.IsFullScreen)
                {
                    // Reafficher les boutons et la page diapo
                    this.button1.Visible = true;
                    this.button2.Visible = true;
                    this.button3.Visible = true;
                    this.button4.Visible = true;
                    this.panel1.Dock = DockStyle.None;


                    fullScreen.LeaveFullScreen(this);
                }
                return true;
            }
            else if (keyData == Keys.Right)
            {
                suivant();
                return true;
            }
            else if (keyData == Keys.Left)
            {
                precedent();
                return true;
            }
            else if (keyData == Keys.Up)
            {
                if (timer1.Enabled == true)
                {
                    if (timer1.Interval < 10000)
                    {
                        timer1.Interval = timer1.Interval + 100;
                    }
                }
                
                return true;
            }
            else if (keyData == Keys.Down)
            {
                if (timer1.Enabled == true)
                {
                    if (timer1.Interval > 100)
                    {
                        timer1.Interval = timer1.Interval - 100;
                    }
                }
                return true;
            }


            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
