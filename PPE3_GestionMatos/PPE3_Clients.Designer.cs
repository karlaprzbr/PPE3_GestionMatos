namespace PPE3_GestionMatos
{
    partial class PPE3_Clients
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
            this.components = new System.ComponentModel.Container();
            this.listBox_client_nom = new System.Windows.Forms.ListBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.groupBox_edition_clients = new System.Windows.Forms.GroupBox();
            this.textBox_client_tel = new System.Windows.Forms.TextBox();
            this.textBox_client_adresse = new System.Windows.Forms.TextBox();
            this.textBox_client_nom = new System.Windows.Forms.TextBox();
            this.textBox_client_id = new System.Windows.Forms.TextBox();
            this.label_client_tel = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.label_client_adresse = new System.Windows.Forms.Label();
            this.label_client_nom = new System.Windows.Forms.Label();
            this.label_client_id = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_fermer = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            this.groupBox_edition_clients.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_client_nom
            // 
            this.listBox_client_nom.DataSource = this.clientsBindingSource;
            this.listBox_client_nom.DisplayMember = "client_nom";
            this.listBox_client_nom.FormattingEnabled = true;
            this.listBox_client_nom.Location = new System.Drawing.Point(24, 63);
            this.listBox_client_nom.Name = "listBox_client_nom";
            this.listBox_client_nom.Size = new System.Drawing.Size(167, 238);
            this.listBox_client_nom.TabIndex = 1;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // pPE3_GestionMatosDataSet
            // 
            this.pPE3_GestionMatosDataSet.DataSetName = "PPE3_GestionMatosDataSet";
            this.pPE3_GestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox_edition_clients
            // 
            this.groupBox_edition_clients.Controls.Add(this.textBox_client_tel);
            this.groupBox_edition_clients.Controls.Add(this.textBox_client_adresse);
            this.groupBox_edition_clients.Controls.Add(this.textBox_client_nom);
            this.groupBox_edition_clients.Controls.Add(this.textBox_client_id);
            this.groupBox_edition_clients.Controls.Add(this.label_client_tel);
            this.groupBox_edition_clients.Controls.Add(this.button_valider);
            this.groupBox_edition_clients.Controls.Add(this.button_abandonner);
            this.groupBox_edition_clients.Controls.Add(this.label_client_adresse);
            this.groupBox_edition_clients.Controls.Add(this.label_client_nom);
            this.groupBox_edition_clients.Controls.Add(this.label_client_id);
            this.groupBox_edition_clients.Location = new System.Drawing.Point(214, 63);
            this.groupBox_edition_clients.Name = "groupBox_edition_clients";
            this.groupBox_edition_clients.Size = new System.Drawing.Size(529, 238);
            this.groupBox_edition_clients.TabIndex = 0;
            this.groupBox_edition_clients.TabStop = false;
            this.groupBox_edition_clients.Text = "Edition";
            // 
            // textBox_client_tel
            // 
            this.textBox_client_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_tel", true));
            this.textBox_client_tel.Location = new System.Drawing.Point(142, 139);
            this.textBox_client_tel.Name = "textBox_client_tel";
            this.textBox_client_tel.Size = new System.Drawing.Size(231, 20);
            this.textBox_client_tel.TabIndex = 9;
            // 
            // textBox_client_adresse
            // 
            this.textBox_client_adresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_adresse", true));
            this.textBox_client_adresse.Location = new System.Drawing.Point(142, 106);
            this.textBox_client_adresse.Name = "textBox_client_adresse";
            this.textBox_client_adresse.Size = new System.Drawing.Size(231, 20);
            this.textBox_client_adresse.TabIndex = 8;
            // 
            // textBox_client_nom
            // 
            this.textBox_client_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_nom", true));
            this.textBox_client_nom.Location = new System.Drawing.Point(142, 69);
            this.textBox_client_nom.Name = "textBox_client_nom";
            this.textBox_client_nom.Size = new System.Drawing.Size(231, 20);
            this.textBox_client_nom.TabIndex = 7;
            // 
            // textBox_client_id
            // 
            this.textBox_client_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_id", true));
            this.textBox_client_id.Location = new System.Drawing.Point(142, 30);
            this.textBox_client_id.Name = "textBox_client_id";
            this.textBox_client_id.Size = new System.Drawing.Size(231, 20);
            this.textBox_client_id.TabIndex = 6;
            // 
            // label_client_tel
            // 
            this.label_client_tel.AutoSize = true;
            this.label_client_tel.Location = new System.Drawing.Point(43, 142);
            this.label_client_tel.Name = "label_client_tel";
            this.label_client_tel.Size = new System.Drawing.Size(58, 13);
            this.label_client_tel.TabIndex = 0;
            this.label_client_tel.Text = "Téléphone";
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(423, 67);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 10;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_abandonner
            // 
            this.button_abandonner.Location = new System.Drawing.Point(423, 132);
            this.button_abandonner.Name = "button_abandonner";
            this.button_abandonner.Size = new System.Drawing.Size(75, 23);
            this.button_abandonner.TabIndex = 11;
            this.button_abandonner.Text = "Abandonner";
            this.button_abandonner.UseVisualStyleBackColor = true;
            this.button_abandonner.Click += new System.EventHandler(this.button_abandonner_Click);
            // 
            // label_client_adresse
            // 
            this.label_client_adresse.AutoSize = true;
            this.label_client_adresse.Location = new System.Drawing.Point(43, 109);
            this.label_client_adresse.Name = "label_client_adresse";
            this.label_client_adresse.Size = new System.Drawing.Size(45, 13);
            this.label_client_adresse.TabIndex = 0;
            this.label_client_adresse.Text = "Adresse";
            // 
            // label_client_nom
            // 
            this.label_client_nom.AutoSize = true;
            this.label_client_nom.Location = new System.Drawing.Point(43, 71);
            this.label_client_nom.Name = "label_client_nom";
            this.label_client_nom.Size = new System.Drawing.Size(29, 13);
            this.label_client_nom.TabIndex = 0;
            this.label_client_nom.Text = "Nom";
            // 
            // label_client_id
            // 
            this.label_client_id.AutoSize = true;
            this.label_client_id.Location = new System.Drawing.Point(43, 33);
            this.label_client_id.Name = "label_client_id";
            this.label_client_id.Size = new System.Drawing.Size(18, 13);
            this.label_client_id.TabIndex = 0;
            this.label_client_id.Text = "ID";
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(214, 380);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 2;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(306, 380);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 3;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(399, 380);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 4;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(668, 380);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(75, 23);
            this.button_fermer.TabIndex = 5;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // PPE3_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox_edition_clients);
            this.Controls.Add(this.listBox_client_nom);
            this.Name = "PPE3_Clients";
            this.Text = "GESTION MATOS - Clients";
            this.Load += new System.EventHandler(this.PPE3_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            this.groupBox_edition_clients.ResumeLayout(false);
            this.groupBox_edition_clients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_client_nom;
        private System.Windows.Forms.GroupBox groupBox_edition_clients;
        private System.Windows.Forms.TextBox textBox_client_tel;
        private System.Windows.Forms.TextBox textBox_client_adresse;
        private System.Windows.Forms.TextBox textBox_client_nom;
        private System.Windows.Forms.TextBox textBox_client_id;
        private System.Windows.Forms.Label label_client_tel;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Label label_client_adresse;
        private System.Windows.Forms.Label label_client_nom;
        private System.Windows.Forms.Label label_client_id;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_fermer;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}