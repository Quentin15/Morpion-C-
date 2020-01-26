using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Diagnostics; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
    public partial class FrmMorpion : Form
    {
        ChoixNomsJoueurs choix = new ChoixNomsJoueurs(); 


        public FrmMorpion()
        {
            InitializeComponent();
        }


        int Total = 0; 

        bool IAtour = true;

        bool tourfixe = true;
        int tour = 1;

        bool IAgagner = false; 
        bool IAnul = true;
        bool IApresquegagne = false;

        bool IAreflechit = false; 

        Color rouge = Color.Red;
        Color bleu = Color.Blue;
        Color jaune = Color.Yellow; 

        int scoreX; 
        int scoreO; 
        int scoreNul; 
        bool plus1score = true; 

        bool rejouerson = true;



        private void FrmMorpion_Load(object sender, EventArgs e)
        {
            choix.ShowDialog();
            if (Données_publiques.joueur1 == null)
            {
                LblX.Text = "X :";
                LblO.Text = "O :";
                TxtAdversaire.Text = "Les X jouent.";
            }
            else
            {
                LblX.Text = Données_publiques.joueur1;
                LblO.Text = Données_publiques.joueur2;
                TxtAdversaire.Text = Données_publiques.joueur1 + " joue.";
            }
            if (Données_publiques.rapidenormal == 1)
            {
                BtnChangeJoueur.Visible = false;
                relancer();
                menuIARapide();
            }
            else if (Données_publiques.rapidenormal == 2)
            {
                BtnChangeJoueur.Visible = false;
                relancer();
                menuIANormal();
            }

            if (Données_publiques.sonorités == true)
            {
                CkBxSons2.Checked = true;
            }
            else
            {
                CkBxSons2.Checked = false;
            }

            if (Données_publiques.rapidenormal != 1 && Données_publiques.rapidenormal !=2 && Données_publiques.declancherchoix != true)
            {
                Application.Exit();
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmMorpion_Enter(object sender, EventArgs e)
        {
            if (Données_publiques.joueur1 != null && Données_publiques.joueur2 != null)
            {
                LblX.Text = Données_publiques.joueur1;
                LblO.Text = Données_publiques.joueur2;
                TxtAdversaire.Text = Données_publiques.joueur1 + " joue.";
            }
        }
        private void BtnChangeJoueur_Click(object sender, EventArgs e)
        {
            SoundPlayer curseur = new SoundPlayer(Morpion.Properties.Resources.Curseur);
            curseur.Play();
            Données_publiques.declancherchoix = true;
            choix.ShowDialog();
            relancer();
            BtnRejouer.Visible = false;
        }

        private void MenuInfo_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer info = new SoundPlayer(Morpion.Properties.Resources.Info);
                info.Play();
            }
            MessageBox.Show("Jeu développé par Quentin Perea\r\n  Version finale - Décembre 2019 \r\n Sons inspirés de l'univers Zelda", "Informations");
        }
        private void MenuRegles_Click(object sender, EventArgs e)
        {
            if (Données_publiques.sonorités == true)
            {
                SoundPlayer info = new SoundPlayer(Morpion.Properties.Resources.Info);
                info.Play();
            }
            MessageBox.Show("Deux joueurs remplissent à leur tour une case de la grille avec le symbole qui leur est attribué : O ou X.\r\nUn joueur gagne s'il aligne trois symboles identiques horizontalement, verticalement ou en diagonale.", "Règles du jeu",MessageBoxButtons.OK);
        }

        void relancer()
        {
            Btn1.Text = null;
            Btn2.Text = null;
            Btn3.Text = null;
            Btn4.Text = null;
            Btn5.Text = null;
            Btn6.Text = null;
            Btn7.Text = null;
            Btn8.Text = null;
            Btn9.Text = null;
            Color blanc = System.Drawing.Color.White;
            Color noir = Color.Black;
            Btn1.BackColor = blanc;
            Btn2.BackColor = blanc;
            Btn3.BackColor = blanc;
            Btn4.BackColor = blanc;
            Btn5.BackColor = blanc;
            Btn6.BackColor = blanc;
            Btn7.BackColor = blanc;
            Btn8.BackColor = blanc;
            Btn9.BackColor = blanc;
            Btn1.ForeColor = noir;
            Btn2.ForeColor = noir;
            Btn3.ForeColor = noir;
            Btn4.ForeColor = noir;
            Btn5.ForeColor = noir;
            Btn6.ForeColor = noir;
            Btn7.ForeColor = noir;
            Btn8.ForeColor = noir;
            Btn9.ForeColor = noir;
            TxtFinal.Visible = false;
            TxtNul.Visible = false;
            Total = 0;
            plus1score = true;
            IAnul = false;
            IApresquegagne = false;
            rejouerson = true;
            TxtAdversaire.Visible = true;
            TxtFinal.Visible = false;
            TxtNul.Visible = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            resetscore();
        }

        private void BtnRejouer_Click(object sender, EventArgs e)
        {
            BtnRejouer.Visible = false;
            relancer();
            if (LblModeJeu2.Text == "1 vs 1")
            {
                menu1vs1();
            }
            else if (LblModeJeu2.Text == "IA - Rapide")
            {
                menuIARapide();
            }
            else
            {
                menuIANormal();
            }
        }

        void resetscore()
        {
            LblScoreNul.Text = Convert.ToString(0);
            LblScoreO.Text = Convert.ToString(0);
            LblScoreX.Text = Convert.ToString(0);
        }

        private void CkBxSons_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBxSons2.Checked)
            {
                Données_publiques.sonorités = true;
            }
            else
            {
                Données_publiques.sonorités = false;
            }
        }

        void menu1vs1()
        {
            BtnChangeJoueur.Visible = true;
            LblModeJeu2.Text = "1 vs 1";
            if (Données_publiques.joueur1 != null)
            {
                TxtAdversaire.Text = Données_publiques.joueur1 + " joue.";
            }
            else
            {
                TxtAdversaire.Text = "Les X jouent.";
            }
            
            LblModeJeu2.ForeColor = System.Drawing.Color.White;
            BtnRejouer.Visible = false;
        }
        void menuIANormal()
        {
            TxtFinal.Visible = false;
            TxtAdversaire.Text = "À vous de jouer.";
            LblX.Text = "X :";
            LblO.Text = "O :";
            TxtNul.Visible = false;
            LblModeJeu2.Text = "IA - Normal";
            LblModeJeu2.ForeColor = jaune;
            tourfixe = true;
            tour = 1;
            IAgagner = false;
            BtnRejouer.Visible = false;
        }

        void menuIARapide()
        {
            TxtFinal.Visible = false;
            TxtAdversaire.Text = "À vous de jouer.";
            LblX.Text = "X :";
            LblO.Text = "O :";
            TxtNul.Visible = false;
            LblModeJeu2.Text = "IA - Rapide";
            LblModeJeu2.ForeColor = jaune;
            tourfixe = true;
            tour = 1;
            IAgagner = false;
            BtnRejouer.Visible = false;
        }

        void IAjoue()
        {
            IAO(Btn1, Btn4, Btn7);
            IAO(Btn2, Btn5, Btn8);
            IAO(Btn3, Btn6, Btn9);
            IAO(Btn1, Btn2, Btn3);
            IAO(Btn4, Btn5, Btn6);
            IAO(Btn7, Btn8, Btn9);
            IAO(Btn1, Btn5, Btn9);
            IAO(Btn3, Btn5, Btn7);
            IAX(Btn1, Btn4, Btn7);
            IAX(Btn2, Btn5, Btn8);
            IAX(Btn3, Btn6, Btn9);
            IAX(Btn1, Btn2, Btn3);
            IAX(Btn4, Btn5, Btn6);
            IAX(Btn7, Btn8, Btn9);
            IAX(Btn1, Btn5, Btn9);
            IAX(Btn3, Btn5, Btn7);

        }
        
        void IAO(Button b1, Button b2, Button b3)
        {
            if (IAgagner == false)
            {
                if (IAtour == true)
                {
                    if ((b1.Text == "O" && b2.Text == "O") || (b1.Text == "O" && b3.Text == "O") || (b3.Text == "O" && b2.Text == "O"))
                    {
                        if ((b1.Text == "O" && b2.Text == "O"))
                        {
                            if (String.IsNullOrEmpty(b3.Text))
                            {
                                b3.Text = "O";
                                b3.ForeColor = rouge;
                                IAtour = false;
                                tourfixe = false;
                            }
                        }
                        else if ((b2.Text == "O" && b3.Text == "O"))
                        {
                            if (String.IsNullOrEmpty(b1.Text))
                            {
                                b1.Text = "O";
                                b1.ForeColor = rouge;
                                IAtour = false;
                                tourfixe = false;
                            }

                        }
                        else if ((b1.Text == "O" && b3.Text == "O"))
                        {
                            if (String.IsNullOrEmpty(b2.Text))
                            {
                                b2.Text = "O";
                                b2.ForeColor = rouge;
                                IAtour = false;
                                tourfixe = false;
                            }
                        }
                    }
                }
            }
        }

   
        void IAX(Button b1, Button b2, Button b3)
        {
            if (IAgagner == false)
            {
                if (IAtour == true)
                {
                    if ((b1.Text == "X" && b2.Text == "X") || (b1.Text == "X" && b3.Text == "X") || (b3.Text == "X" && b2.Text == "X"))
                    {
                        if ((b1.Text == "X" && b2.Text == "X"))
                        {
                            if (String.IsNullOrEmpty(b3.Text))
                            {
                                b3.Text = "O";
                                b3.ForeColor = rouge;
                                IAtour = false;
                                tourfixe = false;
                            }
                        }
                        else if ((b2.Text == "X" && b3.Text == "X"))
                        {
                            if (String.IsNullOrEmpty(b1.Text))
                            {
                                b1.Text = "O";
                                b1.ForeColor = rouge;
                                IAtour = false;
                                tourfixe = false;
                            }
                        }
                        else if ((b1.Text == "X" && b3.Text == "X"))
                        {
                            if (String.IsNullOrEmpty(b2.Text))
                            {
                                b2.Text = "O";
                                b2.ForeColor = rouge;
                                IAtour = false;
                                tourfixe = false;
                            }
                        }
                    }
                }
            }
        }

        void IAfixe()
        {
            if (tourfixe == true)
            {
                if (tour == 1)
                {
                    if (Btn7.Text == "X" || Btn8.Text == "X" || Btn2.Text == "X" || Btn6.Text == "X" || Btn1.Text == "X")
                    {
                        placementO(Btn5);
                    }
                    else if (Btn3.Text == "X")
                    {
                        placementO(Btn5);
                    }
                    else if (String.IsNullOrEmpty(Btn1.Text))
                    {
                        placementO(Btn1);
                    }
                    else if (Btn1.Text == "X")
                    {
                        placementO(Btn3);
                    }
                }
                else if (tour == 2)
                {
                    if (Btn7.Text == "X" && Btn6.Text == "X" && String.IsNullOrEmpty(Btn9.Text))
                    {
                        placementO(Btn9);
                    }
                    else if (Btn8.Text == "X" && Btn4.Text == "X" && String.IsNullOrEmpty(Btn7.Text))
                    {
                        placementO(Btn7);
                    }
                    else if (Btn7.Text == "X" && Btn3.Text == "X" && Btn5.Text == "O" && String.IsNullOrEmpty(Btn6.Text))
                    {
                        placementO(Btn6);
                    }
                    else if (Btn7.Text == "O" && Btn9.Text == "X" && Btn3.Text == "X" && Btn6.Text == "O" && String.IsNullOrEmpty(Btn2.Text))
                    {
                        placementO(Btn2);
                    }
                    else if (Btn7.Text == "X" && Btn2.Text == "X" && String.IsNullOrEmpty(Btn1.Text))
                    {
                        placementO(Btn1);
                    }
                    else if (String.IsNullOrEmpty(Btn3.Text))
                    {
                        placementO(Btn3);
                    }
                    else if (String.IsNullOrEmpty(Btn9.Text))
                    {
                        placementO(Btn9);
                    }
                    else if (String.IsNullOrEmpty(Btn7.Text))
                    {
                        placementO(Btn7);
                    }
                    else if ((Btn9.Text == "X") && (Btn6.Text == "X"))
                    {
                        placementO(Btn7);
                    }
                    else if ((Btn1.Text == "O" && Btn8.Text == "O" && Btn3.Text == "O") && (String.IsNullOrEmpty(Btn6.Text)))
                    {
                        placementO(Btn6);
                    }
                    else if ((Btn1.Text == "O" && Btn6.Text == "O" && Btn7.Text == "O") && (String.IsNullOrEmpty(Btn2.Text)))
                    {
                        placementO(Btn2);
                    }
                    else if ((Btn3.Text == "O" && Btn9.Text == "O" && Btn4.Text == "O") && (String.IsNullOrEmpty(Btn8.Text)))
                    {
                        placementO(Btn8);
                    }
                }
                else if (tour == 3)
                {
                    if (Btn7.Text == "X" && Btn2.Text == "X" && Btn9.Text == "X" && Btn4.Text == "X" && Btn8.Text == "O")
                    {
                        placementO(Btn6);
                    }
                    else if (Btn2.Text == "X" && Btn6.Text == "X" && Btn7.Text == "X" && Btn5.Text == "O")
                    {
                        placementO(Btn1);
                    }
                    else if ((Btn2.Text == "X" && ((Btn4.Text == "X" && Btn9.Text == "X") || (Btn7.Text == "X" && Btn6.Text == "X"))))
                    {
                        placementO(Btn5);
                    }
                    else if (Btn7.Text == "X" && Btn6.Text == "X" && Btn1.Text == "X" && Btn8.Text == "X")
                    {
                        placementO(Btn2);
                    }
                    else if (String.IsNullOrEmpty(Btn9.Text))
                    {
                        placementO(Btn9);
                    }
                    else if (String.IsNullOrEmpty(Btn7.Text))
                    {
                        placementO(Btn7);
                    }
                    else if ((Btn9.Text == "X") && (Btn3.Text == "X") && (String.IsNullOrEmpty(Btn5.Text)))
                    {
                        if (Btn8.Text == "X")
                        {
                            placementO(Btn5);
                        }
                        else
                        {
                            placementO(Btn8);
                        }
                    }
                    else if ((Btn1.Text == "O" && Btn8.Text == "O" && Btn3.Text == "O") && (String.IsNullOrEmpty(Btn6.Text)))
                    {
                        placementO(Btn6);
                    }
                }
            }
        }

        void placementO(Button bt1)
        {
            if (String.IsNullOrEmpty(bt1.Text))
            {
                bt1.Text = "O";
                bt1.ForeColor = rouge;
                IAtour = false;
                tourfixe = false;
                tour = tour + 1;
            }
        }

        void Xgagne()
        {
            scoreX = Convert.ToInt32(LblScoreX.Text);
            if (Données_publiques.joueur1 != null && LblModeJeu2.Text == "1 vs 1")
            {
                TxtFinal.Text = Données_publiques.joueur1 + " a gagné !";
            }
            else
            { 
                TxtFinal.Text = "Les X ont gagné !";
            }
            if (LblModeJeu2.Text != "1 vs 1")
            {
                TxtFinal.Text = "Vous avez gagné !";
            }
            TxtAdversaire.Visible = false;
            TxtFinal.Visible = true;
            Total = 2;
            BtnRejouer.Visible = true;
            if (plus1score == true)
            {
                LblScoreX.Text = Convert.ToString(scoreX + 1);
                plus1score = false;
            }
            if (Données_publiques.sonorités == true)
            {
                if (rejouerson == true)
                {
                    SoundPlayer victoire = new SoundPlayer(Morpion.Properties.Resources.Victoire);
                    victoire.Play();
                    rejouerson = false;
                }
            }
                
            if (LblModeJeu2.Text == "1 vs 1")
            {
                BtnChangeJoueur.Visible = true;
            }
        }
        void Ogagne()
        {
            scoreO = Convert.ToInt32(LblScoreO.Text);
            if (Données_publiques.joueur1 != null && LblModeJeu2.Text == "1 vs 1")
            {
                TxtFinal.Text = Données_publiques.joueur2 + " a gagné !";
            }
            else
            {
                TxtFinal.Text = "Les O ont gagné !";
            }
            if (LblModeJeu2.Text != "1 vs 1")
            {
                TxtFinal.Text = "Vous avez perdu.";
            }
            TxtAdversaire.Visible = false;
            TxtFinal.Visible = true;
            Total = 2;
            BtnRejouer.Visible = true;
            if (plus1score == true)
            {
                LblScoreO.Text = Convert.ToString(scoreO + 1);
                plus1score = false;
            }
            if (LblModeJeu2.Text != "1 vs 1")
            {
                if (Données_publiques.sonorités == true)
                {
                    if (rejouerson == true)
                    {
                        SoundPlayer defaite = new SoundPlayer(Morpion.Properties.Resources.Défaite);
                        defaite.Play();
                        rejouerson = false;
                    }
                }
            }
            else
            {
                if (Données_publiques.sonorités == true)
                {
                    if (rejouerson == true)
                    {
                        SoundPlayer victoire = new SoundPlayer(Morpion.Properties.Resources.Victoire);
                        victoire.Play();
                        rejouerson = false;
                    }
                }
            }
            if (LblModeJeu2.Text == "1 vs 1")
            {
                BtnChangeJoueur.Visible = true;
            }
        }


        void win(Button b1, Button b2, Button b3)
        {
            Color couleurfond = Color.Yellow;
            b1.BackColor = couleurfond;
            b2.BackColor = couleurfond;
            b3.BackColor = couleurfond;

            if (b1.Text == "X")
            {
                Xgagne();
            }
            else
            {
                Ogagne();
            }
            IAgagner = true;
        }
        void gagner()
        {
            if ((Btn1.Text == "X" && Btn2.Text == "X" && Btn3.Text == "X") || (Btn1.Text == "O" && Btn2.Text == "O" && Btn3.Text == "O"))
            {
                win(Btn1, Btn2, Btn3);
            }
            if ((Btn4.Text == "X" && Btn5.Text == "X" && Btn6.Text == "X") || (Btn4.Text == "O" && Btn5.Text == "O" && Btn6.Text == "O"))
            {
                win(Btn4, Btn5, Btn6);
            }
            if ((Btn7.Text == "X" && Btn8.Text == "X" && Btn9.Text == "X") || (Btn7.Text == "O" && Btn8.Text == "O" && Btn9.Text == "O"))
            {
                win(Btn7, Btn8, Btn9);
            }
            if ((Btn1.Text == "X" && Btn4.Text == "X" && Btn7.Text == "X") || (Btn1.Text == "O" && Btn4.Text == "O" && Btn7.Text == "O"))
            {
                win(Btn1, Btn4, Btn7);
            }
            if ((Btn2.Text == "X" && Btn5.Text == "X" && Btn8.Text == "X") || (Btn2.Text == "O" && Btn5.Text == "O" && Btn8.Text == "O"))
            {
                win(Btn2, Btn5, Btn8);
            }
            if ((Btn3.Text == "X" && Btn6.Text == "X" && Btn9.Text == "X") || (Btn3.Text == "O" && Btn6.Text == "O" && Btn9.Text == "O"))
            {
                win(Btn3, Btn6, Btn9);
            }
            if ((Btn1.Text == "X" && Btn5.Text == "X" && Btn9.Text == "X") || (Btn1.Text == "O" && Btn5.Text == "O" && Btn9.Text == "O"))
            {
                win(Btn1, Btn5, Btn9);
            }
            if ((Btn3.Text == "X" && Btn5.Text == "X" && Btn7.Text == "X") || (Btn3.Text == "O" && Btn5.Text == "O" && Btn7.Text == "O"))
            {
                win(Btn3, Btn5, Btn7);
            }

            matchnul();
        }

        void matchnul()
        {
            if ((!String.IsNullOrEmpty(Btn1.Text) && !String.IsNullOrEmpty(Btn2.Text) && (!String.IsNullOrEmpty(Btn3.Text)) && (!String.IsNullOrEmpty(Btn4.Text)) && (!String.IsNullOrEmpty(Btn5.Text)) && (!String.IsNullOrEmpty(Btn6.Text)) && (!String.IsNullOrEmpty(Btn7.Text)) && (!String.IsNullOrEmpty(Btn8.Text)) && (!String.IsNullOrEmpty(Btn9.Text) && (TxtFinal.Visible == false))))
            {
                IAnul = true;
                scoreNul = Convert.ToInt32(LblScoreNul.Text);
                TxtNul.Visible = true;
                TxtNul.Text = "Match nul !";
                TxtAdversaire.Visible = false;
                BtnRejouer.Visible = true;
                if (LblModeJeu2.Text == "1 vs 1")
                {
                    BtnChangeJoueur.Visible = true;
                }

                if (plus1score == true)
                {
                    LblScoreNul.Text = Convert.ToString(scoreNul + 1);
                    plus1score = false;
                }
                if (Données_publiques.sonorités == true)
                {
                    if (rejouerson == true)
                    {
                        SoundPlayer egalite = new SoundPlayer(Morpion.Properties.Resources.Egalité);
                        egalite.Play();
                        rejouerson = false;
                    }
                }
            }
        }

        void analyseIANorm()
        {
            IAvagagner(Btn1, Btn2, Btn3);
            IAvagagner(Btn4, Btn5, Btn6);
            IAvagagner(Btn7, Btn8, Btn9);
            IAvagagner(Btn1, Btn4, Btn7);
            IAvagagner(Btn2, Btn5, Btn8);
            IAvagagner(Btn3, Btn6, Btn9);
            IAvagagner(Btn1, Btn5, Btn9);
            IAvagagner(Btn3, Btn5, Btn7);
        }

        void IAvagagner(Button B1, Button B2, Button B3)
        {
            if ((B1.Text == "O" && B2.Text == "O" && B3.Text != "X") || (B1.Text == "O" && B3.Text == "O" && B2.Text != "X") || (B2.Text == "O" && B3.Text == "O" && B1.Text != "X"))
            {
                IApresquegagne = true;
            }
        }

        void bouton(object sender, EventArgs e)
        {
            Button bouton = (Button)sender;
            BtnChangeJoueur.Visible = false;
            if (LblModeJeu2.Text == "1 vs 1")
            {
                if (String.IsNullOrEmpty(bouton.Text))
                {
                    if (Total == 0)
                    {
                        Total = 1;
                        bouton.ForeColor = bleu;
                        bouton.Text = "X";
                        if (Données_publiques.joueur1 != null)
                        {
                            TxtAdversaire.Text = Données_publiques.joueur2 + " joue.";
                        }
                        else
                        {
                            TxtAdversaire.Text = "Les O jouent.";
                        }
                    }

                    else if (Total == 1)
                    {
                        Total = 0;
                        bouton.ForeColor = rouge;
                        bouton.Text = "O";
                        if (Données_publiques.joueur1 != null)
                        {
                            TxtAdversaire.Text = Données_publiques.joueur1 + " joue.";
                        }
                        else
                        {
                            TxtAdversaire.Text = "Les X jouent.";
                        }
                    }
                }
                gagner();

            }
            else if (LblModeJeu2.Text == "IA - Rapide")
            {
                if (IAgagner == false)
                {
                    if (String.IsNullOrEmpty(bouton.Text))
                    {
                        IAtour = true;
                        tourfixe = true;
                        bouton.ForeColor = bleu;
                        bouton.Text = "X";
                        gagner();
                        TxtAdversaire.Text = "À vous de jouer.";
                        IAjoue();
                        IAfixe();
                    }
                }
                gagner();
            }
            else if (LblModeJeu2.Text == "IA - Normal")
            {
                if (IAgagner == false)
                {
                    if (String.IsNullOrEmpty(bouton.Text))
                    {
                        if (IAreflechit == false)
                        {
                            IAnul = false;
                            IApresquegagne = false;
                            IAtour = true;
                            tourfixe = true;
                            bouton.ForeColor = bleu;

                            bouton.Text = "X";
                            IAreflechit = true;
                            gagner();
                            analyseIANorm();
                            Application.DoEvents();
                            if (IAnul == false && IApresquegagne == false)
                            {
                                TxtAdversaire.Text = "L'IA réfléchit...";
                                Application.DoEvents();
                                System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(900));
                            }
                            Application.DoEvents();
                            TxtAdversaire.Text = null;
                            Application.DoEvents();
                            if (IAnul == false && IApresquegagne == false)
                            {
                                System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(350));

                            }
                            IAjoue();
                            IAfixe();
                            Application.DoEvents();
                            TxtAdversaire.Text = "À vous de jouer.";
                            IAreflechit = false;
                        }
                    }
                }
                gagner();
            }
        }

        private void Menu1v1_Click(object sender, EventArgs e)
        {
            BtnChangeJoueur.Visible = true;
            if (Données_publiques.rapidenormal == 1 || Données_publiques.rapidenormal == 2)
            {
                if (Données_publiques.show1efoischoix == true)
                {
                    SoundPlayer curseur = new SoundPlayer(Morpion.Properties.Resources.Curseur);
                    curseur.Play();
                    Données_publiques.declancherchoix = true;
                    choix.ShowDialog();
                    Données_publiques.show1efoischoix = false;
                }
            }
            relancer();
            menu1vs1();
            if (Données_publiques.joueur1 != null)
            {
                LblX.Text = Données_publiques.joueur1;
                LblO.Text = Données_publiques.joueur2;
                TxtAdversaire.Text = Données_publiques.joueur1 + " joue.";
            }
            else
            {
                LblX.Text = "X :";
                LblO.Text = "O :";
                TxtAdversaire.Text = "Les X jouent.";
            }
        }
        private void MenuNormal_Click(object sender, EventArgs e)
        {
            BtnChangeJoueur.Visible = false;
            relancer();
            menuIANormal();
        }
        private void MenuRapide_Click(object sender, EventArgs e)
        {
            BtnChangeJoueur.Visible = false;
            relancer();
            menuIARapide();
        }

        private void FrmMorpion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Données_publiques.messagedefin == true)
            {
                SoundPlayer fin = new SoundPlayer(Morpion.Properties.Resources.Fin);
                fin.Play();
                MessageBox.Show("Merci d'avoir joué ! 😉");
            }
        }

        private void MenuLeMorpion_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "https://fr.wikipedia.org/wiki/Tic-tac-toe";
            p.Start();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer curseur = new SoundPlayer(Morpion.Properties.Resources.Curseur);
            curseur.Play();
            DialogResult messagedefin = MessageBox.Show("Voulez-vous quitter le jeu ?", "Fermeture du jeu", MessageBoxButtons.YesNo);
            if (messagedefin == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (messagedefin == DialogResult.No)
            {
                SoundPlayer prevalide = new SoundPlayer(Morpion.Properties.Resources.Prevalide);
                prevalide.Play();
            }
        }
    }
}



