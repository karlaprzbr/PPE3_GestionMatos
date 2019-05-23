namespace PPE3_GestionMatos
{
    partial class PPE3_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_gest_util = new System.Windows.Forms.TextBox();
            this.textBox_gest_mdp = new System.Windows.Forms.TextBox();
            this.button_connexion = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION MATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identifiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe";
            // 
            // textBox_gest_util
            // 
            this.textBox_gest_util.Location = new System.Drawing.Point(205, 195);
            this.textBox_gest_util.Name = "textBox_gest_util";
            this.textBox_gest_util.Size = new System.Drawing.Size(143, 20);
            this.textBox_gest_util.TabIndex = 3;
            // 
            // textBox_gest_mdp
            // 
            this.textBox_gest_mdp.Location = new System.Drawing.Point(443, 195);
            this.textBox_gest_mdp.Name = "textBox_gest_mdp";
            this.textBox_gest_mdp.PasswordChar = '*';
            this.textBox_gest_mdp.Size = new System.Drawing.Size(157, 20);
            this.textBox_gest_mdp.TabIndex = 4;
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(352, 258);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(75, 23);
            this.button_connexion.TabIndex = 5;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(352, 296);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 6;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // PPE3_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.textBox_gest_mdp);
            this.Controls.Add(this.textBox_gest_util);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PPE3_Login";
            this.Text = "GESTION MATOS - Connexion";
            this.Load += new System.EventHandler(this.PPE3_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_gest_util;
        private System.Windows.Forms.TextBox textBox_gest_mdp;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.Button button_annuler;
    }
}

