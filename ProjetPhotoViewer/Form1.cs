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
            listViewFolder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.AllowDrop = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
               
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                listViewFolder.Items.Clear();
                string[] files = Directory.GetFiles(folderBrowser.SelectedPath);
                foreach (string file in files)
                {

                    string fileName = Path.GetFileName(file);
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;
                    item.Text = fileName;
                    listViewFolder.Items.Add(item);
                }
            }

        }

        private void btnAddtoAlbum_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                album monalbum = new album();
                
                monalbum.name = "album 1";
                monalbum.images.Add(openFileDialog1.FileName);
                foreach(string str in monalbum.images)
                {
                    PictureBox pb = new PictureBox();
                    pb.ImageLocation = str;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpAlbumViewer.Controls.Add(pb);
                }
                mesalbums.Add(monalbum);
            }
        }

        private void btnLoadAlbum_Click(object sender, EventArgs e)
        {           SaveXmlFile(mesalbums);
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            createAlbum createA = new createAlbum();
            if(createA.ShowDialog() == DialogResult.OK)
            {
                album a = new album();
                a.name = createA.album.name;
                mesalbums.Add(a);

            }
        }

    }
}
