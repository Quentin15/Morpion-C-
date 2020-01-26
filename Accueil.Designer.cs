namespace Morpion
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.LblAccueil = new System.Windows.Forms.Label();
            this.BtnMode1vs1 = new System.Windows.Forms.Button();
            this.BtnModeIANormal = new System.Windows.Forms.Button();
            this.BtnModeIARapide = new System.Windows.Forms.Button();
            this.LblChoixMode = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leMorpionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CkBxSons = new System.Windows.Forms.CheckBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.Pic6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAccueil
            // 
            this.LblAccueil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAccueil.AutoSize = true;
            this.LblAccueil.BackColor = System.Drawing.Color.Transparent;
            this.LblAccueil.Font = new System.Drawing.Font("Gabriola", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAccueil.Location = new System.Drawing.Point(162, 75);
            this.LblAccueil.Name = "LblAccueil";
            this.LblAccueil.Size = new System.Drawing.Size(219, 68);
            this.LblAccueil.TabIndex = 0;
            this.LblAccueil.Text = "Jeu du Morpion";
            // 
            // BtnMode1vs1
            // 
            this.BtnMode1vs1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMode1vs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMode1vs1.Location = new System.Drawing.Point(174, 248);
            this.BtnMode1vs1.Name = "BtnMode1vs1";
            this.BtnMode1vs1.Size = new System.Drawing.Size(191, 23);
            this.BtnMode1vs1.TabIndex = 1;
            this.BtnMode1vs1.Text = "----- 1 vs 1 -----";
            this.BtnMode1vs1.UseVisualStyleBackColor = true;
            this.BtnMode1vs1.Click += new System.EventHandler(this.BtnMode1vs1_Click);
            this.BtnMode1vs1.MouseEnter += new System.EventHandler(this.BtnMode1vs1_MouseEnter);
            this.BtnMode1vs1.MouseLeave += new System.EventHandler(this.BtnMode1vs1_MouseLeave);
            // 
            // BtnModeIANormal
            // 
            this.BtnModeIANormal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModeIANormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModeIANormal.Location = new System.Drawing.Point(174, 277);
            this.BtnModeIANormal.Name = "BtnModeIANormal";
            this.BtnModeIANormal.Size = new System.Drawing.Size(191, 23);
            this.BtnModeIANormal.TabIndex = 2;
            this.BtnModeIANormal.Text = "----- IA - Normale -----";
            this.BtnModeIANormal.UseVisualStyleBackColor = true;
            this.BtnModeIANormal.Click += new System.EventHandler(this.BtnModeIANormal_Click);
            this.BtnModeIANormal.MouseEnter += new System.EventHandler(this.BtnModeIANormal_MouseEnter);
            this.BtnModeIANormal.MouseLeave += new System.EventHandler(this.BtnModeIANormal_MouseLeave);
            // 
            // BtnModeIARapide
            // 
            this.BtnModeIARapide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModeIARapide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModeIARapide.Location = new System.Drawing.Point(174, 306);
            this.BtnModeIARapide.Name = "BtnModeIARapide";
            this.BtnModeIARapide.Size = new System.Drawing.Size(191, 23);
            this.BtnModeIARapide.TabIndex = 3;
            this.BtnModeIARapide.Text = "----- IA - Rapide -----";
            this.BtnModeIARapide.UseVisualStyleBackColor = true;
            this.BtnModeIARapide.Click += new System.EventHandler(this.BtnModeIARapide_Click);
            this.BtnModeIARapide.MouseEnter += new System.EventHandler(this.BtnModeIARapide_MouseEnter);
            this.BtnModeIARapide.MouseLeave += new System.EventHandler(this.BtnModeIARapide_MouseLeave);
            // 
            // LblChoixMode
            // 
            this.LblChoixMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblChoixMode.AutoSize = true;
            this.LblChoixMode.BackColor = System.Drawing.Color.Transparent;
            this.LblChoixMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChoixMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblChoixMode.Location = new System.Drawing.Point(149, 185);
            this.LblChoixMode.Name = "LblChoixMode";
            this.LblChoixMode.Size = new System.Drawing.Size(242, 24);
            this.LblChoixMode.TabIndex = 4;
            this.LblChoixMode.Text = "Choisissez le mode de jeu :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsToolStripMenuItem,
            this.règlesToolStripMenuItem,
            this.leMorpionToolStripMenuItem});
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.àProposToolStripMenuItem.Text = "À propos";
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.informationsToolStripMenuItem.Text = "Informations";
            this.informationsToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // règlesToolStripMenuItem
            // 
            this.règlesToolStripMenuItem.Name = "règlesToolStripMenuItem";
            this.règlesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.règlesToolStripMenuItem.Text = "Règles";
            this.règlesToolStripMenuItem.Click += new System.EventHandler(this.règlesToolStripMenuItem_Click);
            // 
            // leMorpionToolStripMenuItem
            // 
            this.leMorpionToolStripMenuItem.Name = "leMorpionToolStripMenuItem";
            this.leMorpionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.leMorpionToolStripMenuItem.Text = "Le Morpion";
            this.leMorpionToolStripMenuItem.Click += new System.EventHandler(this.leMorpionToolStripMenuItem_Click);
            // 
            // CkBxSons
            // 
            this.CkBxSons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkBxSons.AutoSize = true;
            this.CkBxSons.BackColor = System.Drawing.Color.Transparent;
            this.CkBxSons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBxSons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CkBxSons.Location = new System.Drawing.Point(198, 348);
            this.CkBxSons.Name = "CkBxSons";
            this.CkBxSons.Size = new System.Drawing.Size(137, 20);
            this.CkBxSons.TabIndex = 6;
            this.CkBxSons.Text = "Activer les sons";
            this.CkBxSons.UseVisualStyleBackColor = false;
            this.CkBxSons.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Pic2
            // 
            this.Pic2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic2.BackColor = System.Drawing.Color.Transparent;
            this.Pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic2.BackgroundImage")));
            this.Pic2.Location = new System.Drawing.Point(108, 265);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(60, 50);
            this.Pic2.TabIndex = 7;
            this.Pic2.TabStop = false;
            this.Pic2.Visible = false;
            // 
            // Pic1
            // 
            this.Pic1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic1.BackColor = System.Drawing.Color.Transparent;
            this.Pic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic1.BackgroundImage")));
            this.Pic1.Location = new System.Drawing.Point(108, 237);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(60, 50);
            this.Pic1.TabIndex = 8;
            this.Pic1.TabStop = false;
            this.Pic1.Visible = false;
            // 
            // Pic3
            // 
            this.Pic3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic3.BackColor = System.Drawing.Color.Transparent;
            this.Pic3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic3.BackgroundImage")));
            this.Pic3.Location = new System.Drawing.Point(108, 293);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(60, 48);
            this.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic3.TabIndex = 9;
            this.Pic3.TabStop = false;
            this.Pic3.Visible = false;
            // 
            // Pic4
            // 
            this.Pic4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic4.BackColor = System.Drawing.Color.Transparent;
            this.Pic4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic4.BackgroundImage")));
            this.Pic4.Location = new System.Drawing.Point(371, 237);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(60, 50);
            this.Pic4.TabIndex = 10;
            this.Pic4.TabStop = false;
            this.Pic4.Visible = false;
            // 
            // Pic5
            // 
            this.Pic5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic5.BackColor = System.Drawing.Color.Transparent;
            this.Pic5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic5.BackgroundImage")));
            this.Pic5.Location = new System.Drawing.Point(371, 265);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(60, 50);
            this.Pic5.TabIndex = 11;
            this.Pic5.TabStop = false;
            this.Pic5.Visible = false;
            // 
            // Pic6
            // 
            this.Pic6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic6.BackColor = System.Drawing.Color.Transparent;
            this.Pic6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic6.BackgroundImage")));
            this.Pic6.Location = new System.Drawing.Point(371, 291);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(60, 50);
            this.Pic6.TabIndex = 12;
            this.Pic6.TabStop = false;
            this.Pic6.Visible = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 421);
            this.Controls.Add(this.Pic6);
            this.Controls.Add(this.Pic5);
            this.Controls.Add(this.Pic4);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.CkBxSons);
            this.Controls.Add(this.LblChoixMode);
            this.Controls.Add(this.BtnModeIARapide);
            this.Controls.Add(this.BtnModeIANormal);
            this.Controls.Add(this.BtnMode1vs1);
            this.Controls.Add(this.LblAccueil);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du Morpion";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAccueil;
        private System.Windows.Forms.Button BtnMode1vs1;
        private System.Windows.Forms.Button BtnModeIANormal;
        private System.Windows.Forms.Button BtnModeIARapide;
        private System.Windows.Forms.Label LblChoixMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leMorpionToolStripMenuItem;
        private System.Windows.Forms.CheckBox CkBxSons;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.PictureBox Pic3;
        private System.Windows.Forms.PictureBox Pic4;
        private System.Windows.Forms.PictureBox Pic5;
        private System.Windows.Forms.PictureBox Pic6;
    }
}