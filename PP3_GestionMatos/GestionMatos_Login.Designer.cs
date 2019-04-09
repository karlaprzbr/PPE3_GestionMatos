namespace PP3_GestionMatos
{
    partial class GestionMateriel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techniciensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesDeMatérielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_mdp = new System.Windows.Forms.Label();
            this.button_connexion = new System.Windows.Forms.Button();
            this.textBox_util = new System.Windows.Forms.TextBox();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.tESTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sauvegarderToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.techniciensToolStripMenuItem,
            this.matérielsToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.marquesToolStripMenuItem,
            this.interventionToolStripMenuItem,
            this.typesDeMatérielsToolStripMenuItem});
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.tESTToolStripMenuItem.Text = "TEST";
            this.tESTToolStripMenuItem.Click += new System.EventHandler(this.tESTToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // techniciensToolStripMenuItem
            // 
            this.techniciensToolStripMenuItem.Name = "techniciensToolStripMenuItem";
            this.techniciensToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.techniciensToolStripMenuItem.Text = "Techniciens";
            // 
            // matérielsToolStripMenuItem
            // 
            this.matérielsToolStripMenuItem.Name = "matérielsToolStripMenuItem";
            this.matérielsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.matérielsToolStripMenuItem.Text = "Matériels";
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.marquesToolStripMenuItem.Text = "Marques";
            // 
            // interventionToolStripMenuItem
            // 
            this.interventionToolStripMenuItem.Name = "interventionToolStripMenuItem";
            this.interventionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.interventionToolStripMenuItem.Text = "Intervention";
            // 
            // typesDeMatérielsToolStripMenuItem
            // 
            this.typesDeMatérielsToolStripMenuItem.Name = "typesDeMatérielsToolStripMenuItem";
            this.typesDeMatérielsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.typesDeMatérielsToolStripMenuItem.Text = "Types de matériels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION MATOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(303, 196);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(53, 13);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "Identifiant";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Location = new System.Drawing.Point(498, 196);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(71, 13);
            this.label_mdp.TabIndex = 3;
            this.label_mdp.Text = "Mot de passe";
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(392, 285);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(75, 23);
            this.button_connexion.TabIndex = 4;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_util
            // 
            this.textBox_util.Location = new System.Drawing.Point(236, 212);
            this.textBox_util.Name = "textBox_util";
            this.textBox_util.Size = new System.Drawing.Size(179, 20);
            this.textBox_util.TabIndex = 6;
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.Location = new System.Drawing.Point(444, 212);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.PasswordChar = '*';
            this.textBox_mdp.Size = new System.Drawing.Size(179, 20);
            this.textBox_mdp.TabIndex = 7;
            // 
            // GestionMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_mdp);
            this.Controls.Add(this.textBox_util);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionMateriel";
            this.Text = "GESTION MATOS - Connexion";
            this.Load += new System.EventHandler(this.GestionMateriel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techniciensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesDeMatérielsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.TextBox textBox_util;
        private System.Windows.Forms.TextBox textBox_mdp;
    }
}

