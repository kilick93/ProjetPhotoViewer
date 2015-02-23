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

        // Defintions des propriétés

        public int selected; // photo selectionnée
        public album monalbum;
        private FullScreen fullScreen = new FullScreen();

        // Initialisation de la fenetre de diaporama

        public diaporama(album modalbum)
        {
            InitializeComponent();
            // on recupère l'album selectionné en paramètre 
            monalbum = modalbum;
            selected = 0;
            // on affiche de la première photo de la liste des photos de l'album
            showImage(monalbum.images.ElementAt(selected));
                    
        }

        // Fonction d'affichage d'une photo avec son path
        private void showImage(photo myphoto)
        {
            Image imgtemp = Image.FromFile(myphoto.path);
            pboxDiap.Image = imgtemp;
        }

        // Evenement clic sur Next
        private void next_photo(object sender, EventArgs e)
        {
            suivant();
        }

        // Fonction pour passer à la photo suivante
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

        // Evenement clic sur precedent
        private void prev_photo(object sender, EventArgs e)
        {
            precedent();
        }

        // Fonction d'affichage de la photo précédente
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

        // Fonction d'affichage des images selon le tick du timer
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

        // Evenement pour lancer ou desactiver le diaporama 
        private void lancerdiap(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Interval = 2000;
                timer1.Start();
                timer1.Enabled = true;
                btnDiap.Text = "Arretez le diaporama";
            }
            else
            {
                timer1.Enabled = false;
                btnDiap.Text = "Lancer le diaporama";
            }
        }

        // Fonction permettant l'affichage en fullscreen
        private void fullscreen_Click(object sender, EventArgs e)
        {
            if (!this.fullScreen.IsFullScreen)
            {
                // Cacher les boutons et afficher les diapos en plein ecran
                this.btnPrec.Visible = false;
                this.btnSuiv.Visible = false;
                this.btnDiap.Visible = false;
                this.btnFullScreen.Visible = false;
                this.PanelDiap.Dock = DockStyle.Fill;

                fullScreen.EnterFullScreen(this);
            }
        }

        // Gestion des touches claviers :
        // Escape : quitter plein ecran
        // Right : photo suivante
        // Left : photo précédente
        // + : augmentation du timer de 100
        // - : diminution du timer de 100
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Touche Escape
            if (keyData == Keys.Escape)
            {
                if (this.fullScreen.IsFullScreen)
                {
                    // Reafficher les boutons et la page diapo
                    this.btnPrec.Visible = true;
                    this.btnSuiv.Visible = true;
                    this.btnDiap.Visible = true;
                    this.btnFullScreen.Visible = true;
                    this.PanelDiap.Dock = DockStyle.None;


                    fullScreen.LeaveFullScreen(this);
                }
                return true;
            }
            
            // Touche -> Right suivant
            else if (keyData == Keys.Right)
            {
                suivant();
                return true;
            }

            // Touche <- Left précédent
            else if (keyData == Keys.Left)
            {
                precedent();
                return true;
            }

            // Touche + Timer
            else if (keyData == Keys.Add)
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
            // Touche - Timer
            else if (keyData == Keys.Subtract)  
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

        private void diaporama_Load(object sender, EventArgs e)
        {

        }
    }
}
