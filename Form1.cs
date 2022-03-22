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
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis
        List<int> carte = new List<int>();     //list de carte a trouver

        bool premier_tour = true; // nombre de carte retourner
        int numero_carte_routener = 100; // c'est la première carte retourner  j'initialiser à 100 car c'est un nombre impossible et il y as une vérification sur cette varibale
        int nombre_de_paire_a_trouver = 100; // cette variable nous permet de savoir quand l'utilisateur a fini le jeux 

        public Form1()
        {
            InitializeComponent();
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void dite_merci(object sender, EventArgs e, int numero_carte)
        {
            // liste de verification avant actions
            if (numero_carte_routener == numero_carte) // quand on appuis plussieur foois sur la même carte
            {
                // on peux faire un petit message d'erreur 
                MessageBox.Show("Il faut cliquer sur deux cases différentes !");
                return;
            }
            void perdu_retourner_les_carte()
            {
                Control ctrl1 = tableLayoutPanel1.Controls[numero_carte];
                PictureBox photo1;
                photo1 = (PictureBox)ctrl1;
                photo1.Image = ilSabotDeCartes.Images[0];
                Control ctrl2 = tableLayoutPanel1.Controls[numero_carte_routener];
                PictureBox photo2;
                photo2 = (PictureBox)ctrl2;
                photo2.Image = ilSabotDeCartes.Images[0];
            }
            Control ctrl = tableLayoutPanel1.Controls[numero_carte];
            PictureBox photo;
            photo = (PictureBox)ctrl;
            photo.Image = ilSabotDeCartes.Images[carte[numero_carte]];
            if (premier_tour) {
                // si nous avons à carte retourner on retourne la premier et un l'enregistre pour faire la comparaisson par la suite

         
                numero_carte_routener = numero_carte;
                premier_tour = false ;
            } else {
                // on retourner la carte on fait les comparaision puis on attend 1 second avant de retourner les deux cartes
               

                if (carte[numero_carte_routener] == carte[numero_carte])
                {
                    // la paire est trouver il faut compter les points et regarde si la partie est terminer 
                    nombre_de_paire_a_trouver--;
                    if (nombre_de_paire_a_trouver == 0)
                    {
                        MessageBox.Show("Tu as gagner bravo");
                        nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;
                        nbCartesSurTapis = tableLayoutPanel1.Controls.Count;
                        Distribution_Aleatoire();    // avoir la liste des cartes
                        bp_retourne_Click(sender, e); // affihcer les carte retourner 
                    }
                }
                else
                {
                    // perdu relance le tour 
                    wait(1000);
                    perdu_retourner_les_carte();
                }
                //netoyer les variable pour les prochain tours 
                numero_carte_routener = 100;
                premier_tour = true;
            }

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

            // initialiser les valeurs pour la partie 
            nombre_de_paire_a_trouver = nbCartesSurTapis / 2;
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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dite_merci(sender, e, 3);
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
