using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPhotoViewer
{
    public class album
    {
        public string name { get; set; }

        public List<photo> images;

        public album()
        {
            images = new List<photo>();
        }
    }

    public class photo
    {
        public string path { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
