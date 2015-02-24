using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjetPhotoViewer
{

    public partial class MainForm : Form
    {
        List<album> mesalbums;
        public int index;
        //Chargement des données sauvegardées depuis le fichier myphotoalbum.xml
        public static List<album> LoadXmlFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<album>));
            string path = Environment.CurrentDirectory + @"\myphotoalbum.xml";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return xs.Deserialize(sr) as List<album>;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.ToString());
            }
            catch
            {
                return new List<album>();
            }

            return new List<album>();
        }
        //Sauvegarde de la List<album> dans le fichier myphotoalbum.xml
        public static void SaveXmlFile(List<album> album)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<album>));
            string path = Environment.CurrentDirectory + @"\myphotoalbum.xml";
            using (StreamWriter sw = new StreamWriter(path))
            {
                xs.Serialize(sw, album);
            }
        }
        public MainForm()
        {
            mesalbums = new List<album>();
            InitializeComponent();
            listViewAlbum.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.AllowDrop = true;
            btnAddtoAlbum.Enabled = false;
            btnDiapo.Enabled = false;
            mesalbums = LoadXmlFile();
            refreshAlbumView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Désactivation des boutons diaporamas et ajout de photo si aucun album n'est sélectionné
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAlbum.SelectedItems.Count == 1)
            {
                btnAddtoAlbum.Enabled = true;
                btnDiapo.Enabled = true;
            }
            else
            {
                btnAddtoAlbum.Enabled = false;
                btnDiapo.Enabled = false;
            }
        }
        //ajout d'une photo à un album depuis le stockage interne de l'ordinateur
        private void btnAddtoAlbum_Click(object sender, EventArgs e)
        {
            //si un album est sélectionné
            if (listViewAlbum.SelectedItems.Count == 1)
            {
                btnAddtoAlbum.Enabled = true;
                //Filtre pour ne permettre de ne sélectionner que des photos
                ofdPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                ofdPhoto.Title = "Selectionnez une image";
                //Après avoir choisi la photo, on l'ajoute dans l'album en enregistrant son path
                if (ofdPhoto.ShowDialog() == DialogResult.OK && listViewAlbum.SelectedIndices[0] >= 0)
                {
                    photo myphoto = new photo();
                    myphoto.path = ofdPhoto.FileName;
                    mesalbums[listViewAlbum.SelectedIndices[0]].images.Add(myphoto);
                    //mise à jour de l'affichage
                    refreshPhotoView();
                }
            }
            else
            {
                btnAddtoAlbum.Enabled = false;
            }
            
        }

        //Ouverture d'un formulaire pour créer un nouvel album
        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            createAlbum createA = new createAlbum();
            if(createA.ShowDialog() == DialogResult.OK)
            {
                album a = new album();
                a.name = createA.album.name;
                
                // Création d'un ToolStripMenuItem pour chaque album afin de gérer l'import de photo depuis la base interne via un click droit sur la photo
                ToolStripMenuItem TestToolStripMenuItem = new ToolStripMenuItem();
                this.addToAlbumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {TestToolStripMenuItem});
                TestToolStripMenuItem.Name = a.name;
                TestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                TestToolStripMenuItem.Text = a.name;
                TestToolStripMenuItem.Click += new System.EventHandler((sendera, ea) => TestToolStripMenuItem_Click(sender, e, a));


                //ajout de l'album qui vient d'être créé à la liste mesalbums
                mesalbums.Add(a);
                //affichage de chaque album dans mesalbums dans la listviewalbum
                refreshAlbumView();
            }
        }

        //suppression de l'album sélectionné
        private void deleteAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //on récupère l'indice de l'album sélectionné
            if(listViewAlbum.SelectedIndices[0] >= 0)
            {
                //suppression
                mesalbums.RemoveAt(listViewAlbum.SelectedIndices[0]);
                //mise à jour de l'affichage
                refreshAlbumView();
            }
        }

        //affichage des albums dans la listviewalbum
        private void refreshAlbumView()
        {
            //on efface tous les items déjà présents dans la listview
            listViewAlbum.Items.Clear();
            //on prend chaque album dans la liste mesalbums
            foreach (album album in mesalbums)
            {
                //on récupère le nom de l'album et on l'ajoute dans la listview
                string fileName = album.name;
                ListViewItem item = new ListViewItem(fileName);
                //item.Tag = file;
                item.Text = fileName;
                listViewAlbum.Items.Add(item);
            }
            SaveXmlFile(mesalbums);
        }
        //affichage des photos dans le listviewphoto
        private void refreshPhotoView()
        {
            //on efface tout les items déjà présents
            listViewPhoto.Items.Clear();
            ImageList picture = new ImageList();
            picture.ImageSize = new Size(56, 56);
            int i = 0;
            //Si un album est sélectionné
            if (listViewAlbum.SelectedItems.Count == 1)
                if(listViewAlbum.SelectedIndices[0] >= 0)
                {
                    album display = mesalbums[listViewAlbum.SelectedIndices[0]];
                    //on prend chaque photo de l'album et on les affiche
                    foreach(photo pic in mesalbums[listViewAlbum.SelectedIndices[0]].images)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = pic.path;
                        item.ImageIndex = i;
                        listViewPhoto.Items.Add(item);
                        i++;
                        Console.WriteLine(pic.path);
                        picture.Images.Add(Image.FromFile(pic.path));

                    
                    }
                }
            listViewPhoto.LargeImageList = picture;
            SaveXmlFile(mesalbums);
        }
        //Ouverture d'un form pour modifier les données d'un album
        private void modifyAlbumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listViewAlbum.SelectedIndices[0] >= 0)
            {
                //ouverture du form
                modifyAlbum modAl = new modifyAlbum(mesalbums[listViewAlbum.SelectedIndices[0]]);
                if (modAl.ShowDialog() == DialogResult.OK)
                {
                    //récupération des données modifiées
                    mesalbums[listViewAlbum.SelectedIndices[0]] = modAl.album;
                }
                //mise à jour de l'affichage
                refreshAlbumView();
            }
        }

        private void listViewPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Diaporama de l'album sélectionné
        private void diaporama_Click(object sender, EventArgs e)
        {
            //Si un album est sélectionné
            if (listViewAlbum.SelectedItems.Count == 1 && mesalbums[listViewAlbum.SelectedIndices[0]].images.Count!=0)
            {
                //On ouvre le form de diaporama
                diaporama diap = new diaporama(mesalbums[listViewAlbum.SelectedIndices[0]]);
                if (diap.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                btnDiapo.Enabled = false;
            }
        }

        private void listViewAlbum_Click(object sender, EventArgs e)
        {
            refreshPhotoView();
        }

        //Ouverture d'un form pour modifier les données d'une photo(rating, comment, etc...)
        private void modifyPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listViewAlbum.SelectedIndices[0] >= 0 && listViewPhoto.SelectedIndices[0] >= 0)
            {
                ModifyPhotoProperty modPic = new ModifyPhotoProperty(mesalbums[listViewAlbum.SelectedIndices[0]].images[listViewPhoto.SelectedIndices[0]]);
                if(modPic.ShowDialog() == DialogResult.OK)
                {
                    mesalbums[listViewAlbum.SelectedIndices[0]].images[listViewPhoto.SelectedIndices[0]] = modPic.photo;
                }
               
            }
        }
        //Suppression d'une photo dans un album
        private void deletePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si un album et une photo sont sélectionnés
            if (listViewAlbum.SelectedIndices[0] >= 0 && listViewPhoto.SelectedIndices[0] >= 0)
            {
                //suppression de la photo
                mesalbums[listViewAlbum.SelectedIndices[0]].images.RemoveAt(listViewPhoto.SelectedIndices[0]);
            }
            //Mise à jour de l'affichage
            refreshPhotoView();
        }


        // Fonction gérant le click Ajouter à l'album pour une photo d'un album A à un album B. Récupère l'album a en paramètre
        private void TestToolStripMenuItem_Click(object sender, EventArgs e, album a)
        {
            Console.WriteLine(a.name);
            for (int i = 0; i < mesalbums.Count; i++ )
            {
                if(mesalbums[i].name== a.name)
                {
                    index = i;
                }
            }
            mesalbums[index].images.Add(mesalbums[listViewAlbum.SelectedIndices[0]].images[listViewPhoto.SelectedIndices[0]]);
            refreshPhotoView();


        }

        private void listViewAlbum_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }

        private void listViewAlbum_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void listViewAlbum_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void listViewAlbum_DragLeave(object sender, EventArgs e)
        {

        }

        private void listViewAlbum_DragOver(object sender, DragEventArgs e)
        {

        }

        private void listViewPhoto_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }

        /// <summary>
        /// Pour ajouter des fichiers depuis l'explorer
        /// Alors ce qui se passe :
        /// 
        /// Dans le DragEnter
        /// On récupère un fichier depuis l'explorer (FileDrop)
        /// Le type de fichier n'est pas géré
        /// 
        /// Dans le DragDrop
        /// On récupère de la tableau de string les data pour chaque fichier sélectionné
        /// on va copier le path dans myphoto.path et puis on l'envoie et enfin on refresh
        /// 
        /// NB : Ne pas oublier de sélectionner l'album avant de le faire ! ! ! ! ! !
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void listViewPhoto_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
           {
                foreach (string file in files)
                {
                    //listViewPhoto.Items.Add(file);
                    photo myphoto = new photo();
                    //myphoto.path = file;
                    myphoto.path = System.IO.Path.GetFullPath(file);
                    if (listViewAlbum.SelectedItems.Count == 1)
                    {
                        mesalbums[listViewAlbum.SelectedIndices[0]].images.Add(myphoto);
                        refreshPhotoView();
                    }
                }
            }
            catch (NullReferenceException)
           {
               return;
           }

         //   Point point = listViewPhoto.PointToClient(new Point(e.X, e.Y));
            //int index = this.listViewPhoto.TabIndex(point);
        }

        private void listViewPhoto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void listViewPhoto_DragLeave(object sender, EventArgs e)
        {

        }

        private void listViewPhoto_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listViewPhoto.SelectedItems == null) return;
            this.listViewPhoto.DoDragDrop(this.listViewPhoto.SelectedItems, DragDropEffects.Move);
        }
    }
}
