using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importer le 'pakage' pour avoir des nombres aléatoires
using System.Windows.Forms;
using dllLoto;

namespace meory
{
    public partial class Form1 : Form
    {
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre
                               // d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis


        public Form1()
        {
            InitializeComponent();
        }

        private void pb_01(object sender, EventArgs e)
        {
            
        }

        private void pb_02(object sender, EventArgs e)
        {

        }

        private void pb_03(object sender, EventArgs e)
        {

        }

        private void pb_04(object sender, EventArgs e)
        {

        }

        private void pb_05(object sender, EventArgs e)
        {

        }

        private void pb_06(object sender, EventArgs e)
        {

        }

        private void pb_07(object sender, EventArgs e)
        {

        }

        private void pb_08(object sender, EventArgs e)
        {

        }

        private void Distribution_Aleatoire()
        {
            LotoMachine hasard = new LotoMachine(10);
            int[] tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis, false);
            // La série d'entiers retournée par la LotoMachine correspondra
            // aux indices des cartes dans le "sabot"
            // Affectation des images aux picturebox
            PictureBox carte;
            int i_image;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {
                carte = (PictureBox)tableLayoutPanel1.Controls[i_carte];
                i_image = tImagesCartes[i_carte + 1]; // i_carte + 1 à cause
                                                      // des pbs d'indices
                carte.Image = ilSabotDeCartes.Images[i_image];
            }
        }

        private void btn_Distribuer(object sender, EventArgs e)
        {
            // On récupère le nombre d'images dans le réservoir :
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
    
            // s’il y a 40 images au total *
            // On récupère également le nombre de cartes à distribuées sur la tapis
            // autrement dit le nombre de contrôles présents sur le conteneur
            nbCartesSurTapis = tableLayoutPanel1.Controls.Count;
            // On effectue la distribution (aléatoire) proprement dite
            Distribution_Aleatoire();
        }


        private void bp_retourne_Click(object sender, EventArgs e)
        {
            PictureBox carte;
            int i_carte = 0;
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                carte = (PictureBox)ctrl;
                carte.Image = ilSabotDeCartes.Images[i_carte];
             
            }
        }

        private void btn_Jouer_Click(object sender, EventArgs e)
        {
            bp_retourne_Click(sender,e);
        }
    }
}
