namespace Morpion
{
    partial class FrmMorpion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMorpion));
            this.MnuJeu = new System.Windows.Forms.MenuStrip();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRapide = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1v1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLeMorpion = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblModeJeu1 = new System.Windows.Forms.Label();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.LblModeJeu2 = new System.Windows.Forms.Label();
            this.LblEgalite = new System.Windows.Forms.Label();
            this.GrpBxScore = new System.Windows.Forms.GroupBox();
            this.LblO = new System.Windows.Forms.Label();
            this.LblX = new System.Windows.Forms.Label();
            this.LblScoreNul = new System.Windows.Forms.Label();
            this.LblScoreO = new System.Windows.Forms.Label();
            this.LblScoreX = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnRejouer = new System.Windows.Forms.Button();
            this.BtnChangeJoueur = new System.Windows.Forms.Button();
            this.CkBxSons2 = new System.Windows.Forms.CheckBox();
            this.TxtAdversaire = new System.Windows.Forms.TextBox();
            this.TxtNul = new System.Windows.Forms.TextBox();
            this.TxtFinal = new System.Windows.Forms.TextBox();
            this.MnuJeu.SuspendLayout();
            this.GrpBxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuJeu
            // 
            this.MnuJeu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MnuJeu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.àProposToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.MnuJeu.Location = new System.Drawing.Point(0, 0);
            this.MnuJeu.Name = "MnuJeu";
            this.MnuJeu.Size = new System.Drawing.Size(615, 25);
            this.MnuJeu.TabIndex = 0;
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vsIAToolStripMenuItem,
            this.Menu1v1});
            this.nouvellePartieToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(109, 21);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            // 
            // vsIAToolStripMenuItem
            // 
            this.vsIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRapide,
            this.MenuNormal});
            this.vsIAToolStripMenuItem.Name = "vsIAToolStripMenuItem";
            this.vsIAToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.vsIAToolStripMenuItem.Text = "1 vs IA";
            // 
            // MenuRapide
            // 
            this.MenuRapide.Name = "MenuRapide";
            this.MenuRapide.Size = new System.Drawing.Size(156, 22);
            this.MenuRapide.Text = "Mode rapide";
            this.MenuRapide.Click += new System.EventHandler(this.MenuRapide_Click);
            // 
            // MenuNormal
            // 
            this.MenuNormal.Name = "MenuNormal";
            this.MenuNormal.Size = new System.Drawing.Size(156, 22);
            this.MenuNormal.Text = "Mode normal";
            this.MenuNormal.Click += new System.EventHandler(this.MenuNormal_Click);
            // 
            // Menu1v1
            // 
            this.Menu1v1.Name = "Menu1v1";
            this.Menu1v1.Size = new System.Drawing.Size(114, 22);
            this.Menu1v1.Text = "1 vs 1";
            this.Menu1v1.Click += new System.EventHandler(this.Menu1v1_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInfo,
            this.MenuRegles,
            this.MenuLeMorpion});
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.àProposToolStripMenuItem.Text = "À propos";
            // 
            // MenuInfo
            // 
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(142, 22);
            this.MenuInfo.Text = "Informations";
            this.MenuInfo.Click += new System.EventHandler(this.MenuInfo_Click);
            // 
            // MenuRegles
            // 
            this.MenuRegles.Name = "MenuRegles";
            this.MenuRegles.Size = new System.Drawing.Size(142, 22);
            this.MenuRegles.Text = "Règles";
            this.MenuRegles.Click += new System.EventHandler(this.MenuRegles_Click);
            // 
            // MenuLeMorpion
            // 
            this.MenuLeMorpion.Name = "MenuLeMorpion";
            this.MenuLeMorpion.Size = new System.Drawing.Size(142, 22);
            this.MenuLeMorpion.Text = "Le Morpion";
            this.MenuLeMorpion.Click += new System.EventHandler(this.MenuLeMorpion_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // LblModeJeu1
            // 
            this.LblModeJeu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblModeJeu1.AutoSize = true;
            this.LblModeJeu1.BackColor = System.Drawing.Color.Transparent;
            this.LblModeJeu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModeJeu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblModeJeu1.Location = new System.Drawing.Point(389, 132);
            this.LblModeJeu1.Name = "LblModeJeu1";
            this.LblModeJeu1.Size = new System.Drawing.Size(102, 16);
            this.LblModeJeu1.TabIndex = 1;
            this.LblModeJeu1.Text = "Mode de jeu :";
            // 
            // Btn3
            // 
            this.Btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn3.BackColor = System.Drawing.SystemColors.Window;
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(268, 108);
            this.Btn3.Name = "Btn3";
            this.Btn3.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn3.Size = new System.Drawing.Size(75, 75);
            this.Btn3.TabIndex = 6;
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.bouton);
            // 
            // Btn7
            // 
            this.Btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn7.BackColor = System.Drawing.SystemColors.Window;
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(120, 256);
            this.Btn7.Name = "Btn7";
            this.Btn7.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn7.Size = new System.Drawing.Size(75, 75);
            this.Btn7.TabIndex = 11;
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.bouton);
            // 
            // Btn2
            // 
            this.Btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn2.BackColor = System.Drawing.SystemColors.Window;
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(194, 108);
            this.Btn2.Name = "Btn2";
            this.Btn2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn2.Size = new System.Drawing.Size(75, 75);
            this.Btn2.TabIndex = 7;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.bouton);
            // 
            // Btn4
            // 
            this.Btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn4.BackColor = System.Drawing.SystemColors.Window;
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(120, 182);
            this.Btn4.Name = "Btn4";
            this.Btn4.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn4.Size = new System.Drawing.Size(75, 75);
            this.Btn4.TabIndex = 5;
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.bouton);
            // 
            // Btn1
            // 
            this.Btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn1.BackColor = System.Drawing.SystemColors.Window;
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn1.Location = new System.Drawing.Point(120, 108);
            this.Btn1.Name = "Btn1";
            this.Btn1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn1.Size = new System.Drawing.Size(75, 75);
            this.Btn1.TabIndex = 8;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.bouton);
            // 
            // Btn6
            // 
            this.Btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn6.BackColor = System.Drawing.SystemColors.Window;
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(268, 182);
            this.Btn6.Name = "Btn6";
            this.Btn6.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn6.Size = new System.Drawing.Size(75, 75);
            this.Btn6.TabIndex = 5;
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.bouton);
            // 
            // Btn8
            // 
            this.Btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn8.BackColor = System.Drawing.SystemColors.Window;
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(194, 256);
            this.Btn8.Name = "Btn8";
            this.Btn8.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn8.Size = new System.Drawing.Size(75, 75);
            this.Btn8.TabIndex = 10;
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.bouton);
            // 
            // Btn9
            // 
            this.Btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn9.BackColor = System.Drawing.SystemColors.Window;
            this.Btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(268, 256);
            this.Btn9.Name = "Btn9";
            this.Btn9.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn9.Size = new System.Drawing.Size(75, 75);
            this.Btn9.TabIndex = 12;
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.bouton);
            // 
            // Btn5
            // 
            this.Btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn5.BackColor = System.Drawing.SystemColors.Window;
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Microsoft YaHei UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(194, 182);
            this.Btn5.Name = "Btn5";
            this.Btn5.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.Btn5.Size = new System.Drawing.Size(75, 75);
            this.Btn5.TabIndex = 1;
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.bouton);
            // 
            // LblModeJeu2
            // 
            this.LblModeJeu2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblModeJeu2.AutoSize = true;
            this.LblModeJeu2.BackColor = System.Drawing.Color.Transparent;
            this.LblModeJeu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModeJeu2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblModeJeu2.Location = new System.Drawing.Point(486, 132);
            this.LblModeJeu2.Name = "LblModeJeu2";
            this.LblModeJeu2.Size = new System.Drawing.Size(48, 16);
            this.LblModeJeu2.TabIndex = 17;
            this.LblModeJeu2.Text = "1 vs 1";
            // 
            // LblEgalite
            // 
            this.LblEgalite.AutoSize = true;
            this.LblEgalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEgalite.ForeColor = System.Drawing.SystemColors.Window;
            this.LblEgalite.Location = new System.Drawing.Point(6, 72);
            this.LblEgalite.Name = "LblEgalite";
            this.LblEgalite.Size = new System.Drawing.Size(65, 16);
            this.LblEgalite.TabIndex = 20;
            this.LblEgalite.Text = "Égalité :";
            // 
            // GrpBxScore
            // 
            this.GrpBxScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrpBxScore.BackColor = System.Drawing.Color.Transparent;
            this.GrpBxScore.Controls.Add(this.LblO);
            this.GrpBxScore.Controls.Add(this.LblX);
            this.GrpBxScore.Controls.Add(this.LblScoreNul);
            this.GrpBxScore.Controls.Add(this.LblScoreO);
            this.GrpBxScore.Controls.Add(this.LblScoreX);
            this.GrpBxScore.Controls.Add(this.LblEgalite);
            this.GrpBxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxScore.ForeColor = System.Drawing.Color.Yellow;
            this.GrpBxScore.Location = new System.Drawing.Point(392, 150);
            this.GrpBxScore.Name = "GrpBxScore";
            this.GrpBxScore.Size = new System.Drawing.Size(174, 100);
            this.GrpBxScore.TabIndex = 21;
            this.GrpBxScore.TabStop = false;
            this.GrpBxScore.Text = "Score";
            // 
            // LblO
            // 
            this.LblO.AutoSize = true;
            this.LblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblO.ForeColor = System.Drawing.Color.Tomato;
            this.LblO.Location = new System.Drawing.Point(6, 48);
            this.LblO.Name = "LblO";
            this.LblO.Size = new System.Drawing.Size(27, 16);
            this.LblO.TabIndex = 25;
            this.LblO.Text = "O :";
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblX.Location = new System.Drawing.Point(6, 25);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(25, 16);
            this.LblX.TabIndex = 24;
            this.LblX.Text = "X :";
            // 
            // LblScoreNul
            // 
            this.LblScoreNul.AutoSize = true;
            this.LblScoreNul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreNul.ForeColor = System.Drawing.SystemColors.Window;
            this.LblScoreNul.Location = new System.Drawing.Point(149, 74);
            this.LblScoreNul.Name = "LblScoreNul";
            this.LblScoreNul.Size = new System.Drawing.Size(16, 16);
            this.LblScoreNul.TabIndex = 23;
            this.LblScoreNul.Text = "0";
            // 
            // LblScoreO
            // 
            this.LblScoreO.AutoSize = true;
            this.LblScoreO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreO.ForeColor = System.Drawing.Color.Tomato;
            this.LblScoreO.Location = new System.Drawing.Point(149, 48);
            this.LblScoreO.Name = "LblScoreO";
            this.LblScoreO.Size = new System.Drawing.Size(16, 16);
            this.LblScoreO.TabIndex = 22;
            this.LblScoreO.Text = "0";
            // 
            // LblScoreX
            // 
            this.LblScoreX.AutoSize = true;
            this.LblScoreX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreX.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblScoreX.Location = new System.Drawing.Point(149, 25);
            this.LblScoreX.Name = "LblScoreX";
            this.LblScoreX.Size = new System.Drawing.Size(16, 16);
            this.LblScoreX.TabIndex = 21;
            this.LblScoreX.Text = "0";
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.Black;
            this.BtnReset.Location = new System.Drawing.Point(407, 256);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(146, 23);
            this.BtnReset.TabIndex = 22;
            this.BtnReset.Text = "Réinitialiser";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnRejouer
            // 
            this.BtnRejouer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRejouer.Location = new System.Drawing.Point(179, 339);
            this.BtnRejouer.Name = "BtnRejouer";
            this.BtnRejouer.Size = new System.Drawing.Size(111, 23);
            this.BtnRejouer.TabIndex = 23;
            this.BtnRejouer.Text = "Rejouer";
            this.BtnRejouer.UseVisualStyleBackColor = true;
            this.BtnRejouer.Visible = false;
            this.BtnRejouer.Click += new System.EventHandler(this.BtnRejouer_Click);
            // 
            // BtnChangeJoueur
            // 
            this.BtnChangeJoueur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnChangeJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeJoueur.Location = new System.Drawing.Point(407, 285);
            this.BtnChangeJoueur.Name = "BtnChangeJoueur";
            this.BtnChangeJoueur.Size = new System.Drawing.Size(146, 23);
            this.BtnChangeJoueur.TabIndex = 24;
            this.BtnChangeJoueur.Text = "Changer de joueurs";
            this.BtnChangeJoueur.UseVisualStyleBackColor = true;
            this.BtnChangeJoueur.Click += new System.EventHandler(this.BtnChangeJoueur_Click);
            // 
            // CkBxSons2
            // 
            this.CkBxSons2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkBxSons2.AutoSize = true;
            this.CkBxSons2.BackColor = System.Drawing.Color.Transparent;
            this.CkBxSons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBxSons2.ForeColor = System.Drawing.SystemColors.Control;
            this.CkBxSons2.Location = new System.Drawing.Point(416, 311);
            this.CkBxSons2.Name = "CkBxSons2";
            this.CkBxSons2.Size = new System.Drawing.Size(137, 20);
            this.CkBxSons2.TabIndex = 25;
            this.CkBxSons2.Text = "Activer les sons";
            this.CkBxSons2.UseVisualStyleBackColor = false;
            this.CkBxSons2.CheckedChanged += new System.EventHandler(this.CkBxSons_CheckedChanged);
            // 
            // TxtAdversaire
            // 
            this.TxtAdversaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAdversaire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtAdversaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdversaire.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtAdversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdversaire.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtAdversaire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtAdversaire.Location = new System.Drawing.Point(120, 337);
            this.TxtAdversaire.Name = "TxtAdversaire";
            this.TxtAdversaire.ReadOnly = true;
            this.TxtAdversaire.Size = new System.Drawing.Size(223, 19);
            this.TxtAdversaire.TabIndex = 26;
            this.TxtAdversaire.TabStop = false;
            this.TxtAdversaire.Text = "Les X jouent.";
            this.TxtAdversaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNul
            // 
            this.TxtNul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNul.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtNul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNul.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtNul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNul.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtNul.Location = new System.Drawing.Point(102, 76);
            this.TxtNul.Name = "TxtNul";
            this.TxtNul.ReadOnly = true;
            this.TxtNul.Size = new System.Drawing.Size(256, 19);
            this.TxtNul.TabIndex = 27;
            this.TxtNul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNul.Visible = false;
            // 
            // TxtFinal
            // 
            this.TxtFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFinal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFinal.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFinal.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtFinal.Location = new System.Drawing.Point(102, 76);
            this.TxtFinal.Name = "TxtFinal";
            this.TxtFinal.ReadOnly = true;
            this.TxtFinal.Size = new System.Drawing.Size(256, 19);
            this.TxtFinal.TabIndex = 28;
            this.TxtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFinal.Visible = false;
            // 
            // FrmMorpion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(615, 408);
            this.Controls.Add(this.TxtFinal);
            this.Controls.Add(this.TxtNul);
            this.Controls.Add(this.TxtAdversaire);
            this.Controls.Add(this.CkBxSons2);
            this.Controls.Add(this.BtnChangeJoueur);
            this.Controls.Add(this.BtnRejouer);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.GrpBxScore);
            this.Controls.Add(this.LblModeJeu2);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.LblModeJeu1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.MnuJeu);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuJeu;
            this.Name = "FrmMorpion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du Morpion";
            this.Activated += new System.EventHandler(this.FrmMorpion_Enter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMorpion_FormClosing);
            this.Load += new System.EventHandler(this.FrmMorpion_Load);
            this.MnuJeu.ResumeLayout(false);
            this.MnuJeu.PerformLayout();
            this.GrpBxScore.ResumeLayout(false);
            this.GrpBxScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MnuJeu;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRapide;
        private System.Windows.Forms.ToolStripMenuItem MenuNormal;
        private System.Windows.Forms.ToolStripMenuItem Menu1v1;
        private System.Windows.Forms.Label LblModeJeu1;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Label LblModeJeu2;
        private System.Windows.Forms.Label LblEgalite;
        private System.Windows.Forms.GroupBox GrpBxScore;
        private System.Windows.Forms.Label LblScoreNul;
        private System.Windows.Forms.Label LblScoreO;
        private System.Windows.Forms.Label LblScoreX;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnRejouer;
        private System.Windows.Forms.Button BtnChangeJoueur;
        private System.Windows.Forms.Label LblO;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.CheckBox CkBxSons2;
        private System.Windows.Forms.TextBox TxtAdversaire;
        private System.Windows.Forms.TextBox TxtNul;
        private System.Windows.Forms.TextBox TxtFinal;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuRegles;
        private System.Windows.Forms.ToolStripMenuItem MenuLeMorpion;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

