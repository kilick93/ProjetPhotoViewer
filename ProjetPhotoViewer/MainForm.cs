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
        public static List<album> LoadXmlFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<album>));
            string path = Environment.CurrentDirectory + @"\myphotoalbum.xml";
            try
            {
                //XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
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
        //Sauvegarde de la List<Student> dans le fichier studentslist.xml
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddtoAlbum_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Selectionner une image";
            if(openFileDialog1.ShowDialog()==DialogResult.OK && listViewAlbum.SelectedIndices[0] >= 0)
            {
                //album monalbum = new album();
                photo myphoto = new photo();
                myphoto.path = openFileDialog1.FileName;
                mesalbums[listViewAlbum.SelectedIndices[0]].images.Add(myphoto);
                //monalbum.images.Add(openFileDialog1.FileName);
                /*foreach (photo pic in mesalbums[listViewAlbum.SelectedIndices[0]].images)
                {
                    PictureBox pb = new PictureBox();
                    pb.ImageLocation = pic.path;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    // A CHANGER
                    //flpAlbumViewer.Controls.Add(pb);
                }*/
                refreshPhotoView();
            }
        }

        private void btnLoadAlbum_Click(object sender, EventArgs e)
        {           SaveXmlFile(mesalbums);
        }

        //Ouverture d'un formulaire pour créer un nouvel album
        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            createAlbum createA = new createAlbum();
            if(createA.ShowDialog() == DialogResult.OK)
            {
                album a = new album();
                a.name = createA.album.name;
                //ajout de l'album qui vient d'être créé à la liste mesalbums
                mesalbums.Add(a);
                //affichage de chaque album dans mesalbums dans la listviewalbum
                refreshAlbumView();
            }
        }

        //suppression de l'album sélectionné

        private void deleteAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listViewAlbum.SelectedIndices[0] >= 0)
            {
                mesalbums.RemoveAt(listViewAlbum.SelectedIndices[0]);
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
        }
        private void refreshPhotoView()
        {
            Console.WriteLine("biaaaatch");
            listViewPhoto.Items.Clear();
            ImageList picture = new ImageList();
            picture.ImageSize = new Size(56, 56);
            int i = 0;
            if(listViewAlbum.SelectedIndices[0] >= 0)
            {
                Console.WriteLine("biatch"+listViewAlbum.SelectedIndices[0]);
                album display = mesalbums[listViewAlbum.SelectedIndices[0]];
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
        }

        private void modifyAlbumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listViewAlbum.SelectedIndices[0] >= 0)
            {
                modifyAlbum modAl = new modifyAlbum(mesalbums[listViewAlbum.SelectedIndices[0]]);
                if (modAl.ShowDialog() == DialogResult.OK)
                {
                    mesalbums[listViewAlbum.SelectedIndices[0]] = modAl.album;
                }
                refreshAlbumView();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            refreshPhotoView();
        }

        private void listViewPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void diaporama_Click(object sender, EventArgs e)
        {
            if (listViewAlbum.SelectedIndices[0] >= 0)
            {
                diaporama diap = new diaporama(mesalbums[listViewAlbum.SelectedIndices[0]]);
                if (diap.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void listViewAlbum_Click(object sender, EventArgs e)
        {
            refreshPhotoView();
        }

        private void modifyPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("indice album : " + listViewAlbum.SelectedIndices[0]);
            Console.WriteLine("indice photo : " + listViewPhoto.SelectedIndices[0]);
            if(listViewAlbum.SelectedIndices[0] >= 0 && listViewPhoto.SelectedIndices[0] >= 0)
            {
                ModifyPhotoProperty modPic = new ModifyPhotoProperty(mesalbums[listViewAlbum.SelectedIndices[0]].images[listViewPhoto.SelectedIndices[0]]);
                if(modPic.ShowDialog() == DialogResult.OK)
                {
                    mesalbums[listViewAlbum.SelectedIndices[0]].images[listViewPhoto.SelectedIndices[0]] = modPic.photo;
                }
               
            }
        }

        private void deletePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewAlbum.SelectedIndices[0] >= 0 && listViewPhoto.SelectedIndices[0] >= 0)
            {
                mesalbums[listViewAlbum.SelectedIndices[0]].images.RemoveAt(listViewPhoto.SelectedIndices[0]);
            }
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
            foreach (string file in files)
            {
                //listViewPhoto.Items.Add(file);
                photo myphoto = new photo();
                //myphoto.path = file;
                myphoto.path = System.IO.Path.GetFullPath(file);
                mesalbums[listViewAlbum.SelectedIndices[0]].images.Add(myphoto);
                refreshPhotoView();
            }
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

        }

    }
}
