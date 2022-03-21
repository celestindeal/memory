using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importer le 'pakage' pour avoir des nombres 
using dllLoto;


namespace meory
{
    public partial class Form1 : Form
    {
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre
                               // d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis
        List<int> carte = new List<int>();     //list de carte a trouver


        public Form1()
        {
            InitializeComponent();
        }

        private void dite_merci(object sender, EventArgs e, int numero_carte)
        {
            Control ctrl = tableLayoutPanel1.Controls[numero_carte];
            PictureBox photo;
            photo = (PictureBox)ctrl;
            photo.Image = ilSabotDeCartes.Images[carte[numero_carte]];
            if(sender.GetType() != typeof(PictureBox))
            {
                return;
            }
            PictureBox thisBox = (PictureBox)sender;
            Guid id_de_l_image = thisBox.Image.RawFormat.Guid;
            Guid id_image_cache = ilSabotDeCartes.Images[0].RawFormat.Guid;

            if ( id_de_l_image.CompareTo(id_image_cache) == 0)
            {
                Console.WriteLine("carte 0 on affiche la bonne carte");
            }

         }

        private void pb_01(object sender, EventArgs e)
        {
            dite_merci (sender, e, 7);
        }

        private void pb_02(object sender, EventArgs e)
        {
            dite_merci(sender, e, 6);
        }

        private void pb_03(object sender, EventArgs e)
        {
            dite_merci(sender, e, 5);
        }

        private void pb_04(object sender, EventArgs e)
        {
            dite_merci(sender, e, 4);
        }

        private void Distribution_Aleatoire()
        {   
            // on init toutes les variables 
            carte.Clear();
            LotoMachine hasard = new LotoMachine(40);
            int[] tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis, false);
            // on crer une list de nombre de la taille du tapis avec doublons 
            for (int i_carte = 1; i_carte < (nbCartesSurTapis/2)+1; i_carte++)
            {
                carte.Add(tImagesCartes[i_carte]);
                carte.Add(tImagesCartes[i_carte]);
            }
            // on melange non chiffres 
            tImagesCartes = carte.OrderBy(n => Guid.NewGuid()).ToArray();
            carte = tImagesCartes.ToList();


            // on affecte les photos au tapis 

            /*      PictureBox photo;
                  int numero = 0;
                  foreach (Control ctrl in tableLayoutPanel1.Controls)
                  {
                      photo = (PictureBox)ctrl;
                      photo.Image = ilSabotDeCartes.Images[tImagesCartes[numero]];
                      numero++;
                  }
            */
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
            
            nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
            nbCartesSurTapis = tableLayoutPanel1.Controls.Count;
            Distribution_Aleatoire();    // avoir la liste des cartes
            bp_retourne_Click(sender,e); // affihcer les carte retourner 

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dite_merci(sender, e, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dite_merci(sender, e, 2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dite_merci(sender, e, 1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            dite_merci(sender, e, 0);
        }
    }
}
