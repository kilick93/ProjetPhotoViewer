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

    public partial class Form1 : Form
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
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            refreshPhotoView();
        }

        private void listViewPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
