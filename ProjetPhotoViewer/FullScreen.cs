using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetPhotoViewer
{
    public class FullScreen
    {
        private FormWindowState winState;
        private FormBorderStyle brdStyle;
        private bool topMost;
        private Rectangle bounds;

        public FullScreen()
        {
            IsFullScreen = false;
        }

        public bool IsFullScreen
        {
            get;
            set;
        }


        // Rentrez en mode plein ecran

        public void EnterFullScreen(Form targetForm)
        {
            if (!IsFullScreen)
            {
                Save(targetForm);  // Sauvegarde l'etat original de la form

                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.TopMost = true;
                targetForm.Bounds = Screen.GetBounds(targetForm);

                IsFullScreen = true;
            }
        }

        // Sauvegarde l'état actuel de la fenêtre

        private void Save(Form targetForm)
        {
            winState = targetForm.WindowState;
            brdStyle = targetForm.FormBorderStyle;
            topMost = targetForm.TopMost;
            bounds = targetForm.Bounds;
        }

        // Quitte le mode plein ecran et restore la fenetre à l'état initial

        public void LeaveFullScreen(Form targetForm)
        {
            if (IsFullScreen)
            {
                // restore à l'état initial la fenetre de base
                targetForm.WindowState = winState;
                targetForm.FormBorderStyle = brdStyle;
                targetForm.TopMost = topMost;
                targetForm.Bounds = bounds;

                IsFullScreen = false;
            }
        }
    }
}
