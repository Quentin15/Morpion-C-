using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Media; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void BtnMode1vs1_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer curseur = new SoundPlayer(Morpion.Properties.Resources.Curseur);
                curseur.Play();
            }
            Données_publiques.declancherchoix = true;
            Données_publiques.messagedefin = true;
            this.Close();
        }

        private void BtnModeIANormal_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer valide = new SoundPlayer(Morpion.Properties.Resources.Valide);
                valide.Play();
            }
            this.Close();
            Données_publiques.declancherchoix = false;
            Données_publiques.rapidenormal = 2;
            Données_publiques.show1efoischoix = true;
            Données_publiques.messagedefin = true;
        }

        private void BtnModeIARapide_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer valide = new SoundPlayer(Morpion.Properties.Resources.Valide);
                valide.Play();
            }
            this.Close();
            Données_publiques.declancherchoix = false;
            Données_publiques.rapidenormal = 1;
            Données_publiques.show1efoischoix = true;
            Données_publiques.messagedefin = true;
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer info = new SoundPlayer(Morpion.Properties.Resources.Info);
                info.Play();
            }
            MessageBox.Show("Jeu développé par Quentin Perea\r\n  Version finale - Décembre 2019 \r\n Sons inspirés de l'univers Zelda", "Informations");
        }

        private void règlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer info = new SoundPlayer(Morpion.Properties.Resources.Info);
                info.Play();
            }
            MessageBox.Show("Deux joueurs remplissent à leur tour une case de la grille avec le symbole qui leur est attribué : O ou X.\r\nUn joueur gagne s'il aligne trois symboles identiques horizontalement, verticalement ou en diagonale.", "Règles du jeu", MessageBoxButtons.OK);
        }



        private void leMorpionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process s = new Process();
            s.StartInfo.FileName = "https://fr.wikipedia.org/wiki/Tic-tac-toe";
            s.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBxSons.Checked)
            {
                Données_publiques.sonorités = true;
            }
            else
            {
                Données_publiques.sonorités = false;
            }
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SoundPlayer intro = new SoundPlayer(Morpion.Properties.Resources.Intro);
            intro.Play();
        }

        private void BtnMode1vs1_MouseEnter(object sender, EventArgs e)
        {
            Pic1.Visible = true;
            Pic4.Visible = true;
        }

        private void BtnModeIANormal_MouseEnter(object sender, EventArgs e)
        {
            Pic2.Visible = true;
            Pic5.Visible = true;
        }

        private void BtnModeIARapide_MouseEnter(object sender, EventArgs e)
        {
            Pic6.Visible = true;
            Pic3.Visible = true;
        }

        private void BtnMode1vs1_MouseLeave(object sender, EventArgs e)
        {
            Pic1.Visible = false;
            Pic4.Visible = false;
        }

        private void BtnModeIANormal_MouseLeave(object sender, EventArgs e)
        {
            Pic2.Visible = false;
            Pic5.Visible = false;
        }

        private void BtnModeIARapide_MouseLeave(object sender, EventArgs e)
        {
            Pic3.Visible = false;
            Pic6.Visible = false;
        }
    }
}
