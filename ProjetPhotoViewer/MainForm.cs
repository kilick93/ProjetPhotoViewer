﻿using System;
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
                ofdPhoto.InitialDirectory = @"C:\";
                ofdPhoto.Title = "Selectionner une image";
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

    }
}
