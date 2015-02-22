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
            string path = Environment.CurrentDirectory + @"\studentslist.xml";
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
        public static void SaveXmlFile(List<album> students)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<album>));
            string path = Environment.CurrentDirectory + @"\studentslist.xml";
            using (StreamWriter sw = new StreamWriter(path))
            {
                xs.Serialize(sw, students);
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
            if(openFileDialog1.ShowDialog()==DialogResult.OK && listViewAlbum.SelectedIndices[0] >= 0)
            {
                //album monalbum = new album();
                photo myphoto = new photo();
                myphoto.path = openFileDialog1.FileName;
                mesalbums[listViewAlbum.SelectedIndices[0]].images.Add(myphoto);
                //monalbum.images.Add(openFileDialog1.FileName);
                foreach (photo pic in mesalbums[listViewAlbum.SelectedIndices[0]].images)
                {
                    PictureBox pb = new PictureBox();
                    pb.ImageLocation = pic.path;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpAlbumViewer.Controls.Add(pb);
                }
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
                listViewAlbum.Items.Clear();
                //affichage de chaque album dans mesalbums dans la listviewalbum
                foreach (album album in mesalbums)
                {
                    string fileName = album.name;
                    ListViewItem item = new ListViewItem(fileName);
                    //item.Tag = file;
                    item.Text = fileName;
                    listViewAlbum.Items.Add(item);
                }
            }
        }

    }
}
