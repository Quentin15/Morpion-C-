using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
    public partial class ChoixNomsJoueurs : Form
    {
        Accueil accueil = new Accueil();

        public ChoixNomsJoueurs()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e) 
        {
            string jr1 = TxtJoueur1.Text;
            string jr2 = TxtJoueur2.Text;
            SoundPlayer valide = new SoundPlayer(Morpion.Properties.Resources.Valide);
            valide.Play();


            if (Convert.ToBoolean(jr1.Length > 11))
            {
                Données_publiques.joueur1 = jr1.Substring(0, 11) + "...";
            }
            else
            {
                Données_publiques.joueur1 = jr1;
            }

            if (Convert.ToBoolean(jr2.Length > 11))
            {
                Données_publiques.joueur2 = jr2.Substring(0, 11) + "...";
            }
            else
            {
                Données_publiques.joueur2 = jr2;
            }
            this.Close();
   
            TxtJoueur1.Text = null;
            TxtJoueur2.Text = null;
        }


        private void ChoixNomsJoueurs_Load(object sender, EventArgs e)
        {
            this.Controls.Add(TxtJoueur1);
            if (Données_publiques.declancheraccueil == true) 
            {
                accueil.ShowDialog();
                Données_publiques.declancheraccueil = false;
            }
            if (Données_publiques.declancherchoix == false) 
            {
                this.Close();
            }
            TxtJoueur1.Text = null;
            TxtJoueur2.Text = null;
        }

  

        private void TxtJoueur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '²')
            {
                e.Handled = true;
            }
        }

       

        private void TxtJoueur_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtJoueur1.Text) && !String.IsNullOrEmpty(TxtJoueur2.Text))
            {
                BtnValider.Enabled = true;
            }
            else
            {
                BtnValider.Enabled = false;
            }
        }

 

        private void ChoixNomsJoueurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                if (Données_publiques.rapidenormal == 1 || Données_publiques.rapidenormal == 2 || Données_publiques.messagedefin == true)
                {
                    SoundPlayer valide = new SoundPlayer(Morpion.Properties.Resources.Valide);
                    valide.Play();
                }
            }
        }
    }
}
