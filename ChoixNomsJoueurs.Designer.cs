namespace Morpion
{
    partial class ChoixNomsJoueurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixNomsJoueurs));
            this.LblJoueur1 = new System.Windows.Forms.Label();
            this.LblJoueur2 = new System.Windows.Forms.Label();
            this.LblConsigne = new System.Windows.Forms.Label();
            this.TxtJoueur1 = new System.Windows.Forms.TextBox();
            this.TxtJoueur2 = new System.Windows.Forms.TextBox();
            this.BtnValider = new System.Windows.Forms.Button();
            this.LblAffX = new System.Windows.Forms.Label();
            this.LblAffO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblJoueur1
            // 
            this.LblJoueur1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblJoueur1.AutoSize = true;
            this.LblJoueur1.BackColor = System.Drawing.Color.Transparent;
            this.LblJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJoueur1.ForeColor = System.Drawing.Color.Yellow;
            this.LblJoueur1.Location = new System.Drawing.Point(44, 71);
            this.LblJoueur1.Name = "LblJoueur1";
            this.LblJoueur1.Size = new System.Drawing.Size(75, 16);
            this.LblJoueur1.TabIndex = 0;
            this.LblJoueur1.Text = "Joueur 1 :";
            // 
            // LblJoueur2
            // 
            this.LblJoueur2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblJoueur2.AutoSize = true;
            this.LblJoueur2.BackColor = System.Drawing.Color.Transparent;
            this.LblJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJoueur2.ForeColor = System.Drawing.Color.Yellow;
            this.LblJoueur2.Location = new System.Drawing.Point(44, 105);
            this.LblJoueur2.Name = "LblJoueur2";
            this.LblJoueur2.Size = new System.Drawing.Size(75, 16);
            this.LblJoueur2.TabIndex = 1;
            this.LblJoueur2.Text = "Joueur 2 :";
            // 
            // LblConsigne
            // 
            this.LblConsigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblConsigne.AutoSize = true;
            this.LblConsigne.BackColor = System.Drawing.Color.Transparent;
            this.LblConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsigne.ForeColor = System.Drawing.Color.Yellow;
            this.LblConsigne.Location = new System.Drawing.Point(96, 23);
            this.LblConsigne.Name = "LblConsigne";
            this.LblConsigne.Size = new System.Drawing.Size(227, 16);
            this.LblConsigne.TabIndex = 2;
            this.LblConsigne.Text = "Entrez le nom des deux joueurs.";
            // 
            // TxtJoueur1
            // 
            this.TxtJoueur1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJoueur1.Location = new System.Drawing.Point(125, 71);
            this.TxtJoueur1.Name = "TxtJoueur1";
            this.TxtJoueur1.Size = new System.Drawing.Size(166, 22);
            this.TxtJoueur1.TabIndex = 1;
            this.TxtJoueur1.TextChanged += new System.EventHandler(this.TxtJoueur_TextChanged);
            this.TxtJoueur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJoueur_KeyPress);
            // 
            // TxtJoueur2
            // 
            this.TxtJoueur2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJoueur2.Location = new System.Drawing.Point(125, 105);
            this.TxtJoueur2.Name = "TxtJoueur2";
            this.TxtJoueur2.Size = new System.Drawing.Size(166, 22);
            this.TxtJoueur2.TabIndex = 3;
            this.TxtJoueur2.TextChanged += new System.EventHandler(this.TxtJoueur_TextChanged);
            this.TxtJoueur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJoueur_KeyPress);
            // 
            // BtnValider
            // 
            this.BtnValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnValider.Enabled = false;
            this.BtnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValider.Location = new System.Drawing.Point(130, 148);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(151, 23);
            this.BtnValider.TabIndex = 5;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // LblAffX
            // 
            this.LblAffX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAffX.AutoSize = true;
            this.LblAffX.BackColor = System.Drawing.Color.Transparent;
            this.LblAffX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAffX.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblAffX.Location = new System.Drawing.Point(295, 74);
            this.LblAffX.Name = "LblAffX";
            this.LblAffX.Size = new System.Drawing.Size(17, 16);
            this.LblAffX.TabIndex = 6;
            this.LblAffX.Text = "X";
            // 
            // LblAffO
            // 
            this.LblAffO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAffO.AutoSize = true;
            this.LblAffO.BackColor = System.Drawing.Color.Transparent;
            this.LblAffO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAffO.ForeColor = System.Drawing.Color.Tomato;
            this.LblAffO.Location = new System.Drawing.Point(295, 108);
            this.LblAffO.Name = "LblAffO";
            this.LblAffO.Size = new System.Drawing.Size(19, 16);
            this.LblAffO.TabIndex = 7;
            this.LblAffO.Text = "O";
            // 
            // ChoixNomsJoueurs
            // 
            this.AcceptButton = this.BtnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(394, 183);
            this.Controls.Add(this.LblAffO);
            this.Controls.Add(this.LblAffX);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.TxtJoueur2);
            this.Controls.Add(this.TxtJoueur1);
            this.Controls.Add(this.LblConsigne);
            this.Controls.Add(this.LblJoueur2);
            this.Controls.Add(this.LblJoueur1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChoixNomsJoueurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morpion - Choix des joueurs";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChoixNomsJoueurs_FormClosing);
            this.Load += new System.EventHandler(this.ChoixNomsJoueurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblJoueur1;
        private System.Windows.Forms.Label LblJoueur2;
        private System.Windows.Forms.Label LblConsigne;
        private System.Windows.Forms.TextBox TxtJoueur1;
        private System.Windows.Forms.TextBox TxtJoueur2;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Label LblAffX;
        private System.Windows.Forms.Label LblAffO;
    }
}