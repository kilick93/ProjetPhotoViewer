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

namespace ProjetPhotoViewer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listViewFolder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.AllowDrop = true;
            //album monalbum = new album();
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
            }
        }

        private void btnLoadAlbum_Click(object sender, EventArgs e)
        {
            //foreach(string str in )
        }

    }
}
