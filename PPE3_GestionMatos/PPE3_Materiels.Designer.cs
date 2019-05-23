namespace PPE3_GestionMatos
{
    partial class PPE3_Materiels
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
            this.button_fermer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.groupBox_edition_mater = new System.Windows.Forms.GroupBox();
            this.comboBox_mat_inter = new System.Windows.Forms.ComboBox();
            this.materielsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.interventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_mat_client = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_mat_marque = new System.Windows.Forms.ComboBox();
            this.marquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_mat_type = new System.Windows.Forms.ComboBox();
            this.typesMaterielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mat_dateInstall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mat_mtbf = new System.Windows.Forms.TextBox();
            this.textBox_mat_numSer = new System.Windows.Forms.TextBox();
            this.textBox_mat_nom = new System.Windows.Forms.TextBox();
            this.textBox_mat_id = new System.Windows.Forms.TextBox();
            this.label_client_tel = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.label_client_adresse = new System.Windows.Forms.Label();
            this.label_client_nom = new System.Windows.Forms.Label();
            this.label_client_id = new System.Windows.Forms.Label();
            this.listBox_mat_nom = new System.Windows.Forms.ListBox();
            this.materielsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.MaterielsTableAdapter();
            this.types_MaterielTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.Types_MaterielTableAdapter();
            this.marquesTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.MarquesTableAdapter();
            this.clientsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter();
            this.interventionsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter();
            this.groupBox_edition_mater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materielsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesMaterielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(685, 372);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(75, 23);
            this.button_fermer.TabIndex = 21;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(416, 372);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 19;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(323, 372);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 18;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(231, 372);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 17;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // groupBox_edition_mater
            // 
            this.groupBox_edition_mater.Controls.Add(this.comboBox_mat_inter);
            this.groupBox_edition_mater.Controls.Add(this.comboBox_mat_client);
            this.groupBox_edition_mater.Controls.Add(this.comboBox_mat_marque);
            this.groupBox_edition_mater.Controls.Add(this.comboBox_mat_type);
            this.groupBox_edition_mater.Controls.Add(this.label5);
            this.groupBox_edition_mater.Controls.Add(this.label4);
            this.groupBox_edition_mater.Controls.Add(this.label3);
            this.groupBox_edition_mater.Controls.Add(this.label2);
            this.groupBox_edition_mater.Controls.Add(this.textBox_mat_dateInstall);
            this.groupBox_edition_mater.Controls.Add(this.label1);
            this.groupBox_edition_mater.Controls.Add(this.textBox_mat_mtbf);
            this.groupBox_edition_mater.Controls.Add(this.textBox_mat_numSer);
            this.groupBox_edition_mater.Controls.Add(this.textBox_mat_nom);
            this.groupBox_edition_mater.Controls.Add(this.textBox_mat_id);
            this.groupBox_edition_mater.Controls.Add(this.label_client_tel);
            this.groupBox_edition_mater.Controls.Add(this.button_valider);
            this.groupBox_edition_mater.Controls.Add(this.button_abandonner);
            this.groupBox_edition_mater.Controls.Add(this.label_client_adresse);
            this.groupBox_edition_mater.Controls.Add(this.label_client_nom);
            this.groupBox_edition_mater.Controls.Add(this.label_client_id);
            this.groupBox_edition_mater.Location = new System.Drawing.Point(231, 55);
            this.groupBox_edition_mater.Name = "groupBox_edition_mater";
            this.groupBox_edition_mater.Size = new System.Drawing.Size(529, 277);
            this.groupBox_edition_mater.TabIndex = 16;
            this.groupBox_edition_mater.TabStop = false;
            this.groupBox_edition_mater.Text = "Edition";
            // 
            // comboBox_mat_inter
            // 
            this.comboBox_mat_inter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materielsBindingSource, "mater_inter", true));
            this.comboBox_mat_inter.DataSource = this.interventionsBindingSource;
            this.comboBox_mat_inter.DisplayMember = "inter_numero";
            this.comboBox_mat_inter.FormattingEnabled = true;
            this.comboBox_mat_inter.Location = new System.Drawing.Point(142, 236);
            this.comboBox_mat_inter.Name = "comboBox_mat_inter";
            this.comboBox_mat_inter.Size = new System.Drawing.Size(231, 21);
            this.comboBox_mat_inter.TabIndex = 23;
            this.comboBox_mat_inter.ValueMember = "inter_id";
            // 
            // materielsBindingSource
            // 
            this.materielsBindingSource.DataMember = "Materiels";
            this.materielsBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // pPE3_GestionMatosDataSet
            // 
            this.pPE3_GestionMatosDataSet.DataSetName = "PPE3_GestionMatosDataSet";
            this.pPE3_GestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // interventionsBindingSource
            // 
            this.interventionsBindingSource.DataMember = "Interventions";
            this.interventionsBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // comboBox_mat_client
            // 
            this.comboBox_mat_client.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materielsBindingSource, "mater_client", true));
            this.comboBox_mat_client.DataSource = this.clientsBindingSource;
            this.comboBox_mat_client.DisplayMember = "client_nom";
            this.comboBox_mat_client.FormattingEnabled = true;
            this.comboBox_mat_client.Location = new System.Drawing.Point(142, 210);
            this.comboBox_mat_client.Name = "comboBox_mat_client";
            this.comboBox_mat_client.Size = new System.Drawing.Size(231, 21);
            this.comboBox_mat_client.TabIndex = 22;
            this.comboBox_mat_client.ValueMember = "client_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // comboBox_mat_marque
            // 
            this.comboBox_mat_marque.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materielsBindingSource, "mater_marque", true));
            this.comboBox_mat_marque.DataSource = this.marquesBindingSource;
            this.comboBox_mat_marque.DisplayMember = "marque_nom";
            this.comboBox_mat_marque.FormattingEnabled = true;
            this.comboBox_mat_marque.Location = new System.Drawing.Point(142, 159);
            this.comboBox_mat_marque.Name = "comboBox_mat_marque";
            this.comboBox_mat_marque.Size = new System.Drawing.Size(231, 21);
            this.comboBox_mat_marque.TabIndex = 21;
            this.comboBox_mat_marque.ValueMember = "marque_id";
            // 
            // marquesBindingSource
            // 
            this.marquesBindingSource.DataMember = "Marques";
            this.marquesBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // comboBox_mat_type
            // 
            this.comboBox_mat_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materielsBindingSource, "mater_type", true));
            this.comboBox_mat_type.DataSource = this.typesMaterielBindingSource;
            this.comboBox_mat_type.DisplayMember = "type_nom";
            this.comboBox_mat_type.FormattingEnabled = true;
            this.comboBox_mat_type.Location = new System.Drawing.Point(142, 132);
            this.comboBox_mat_type.Name = "comboBox_mat_type";
            this.comboBox_mat_type.Size = new System.Drawing.Size(231, 21);
            this.comboBox_mat_type.TabIndex = 20;
            this.comboBox_mat_type.ValueMember = "type_id";
            // 
            // typesMaterielBindingSource
            // 
            this.typesMaterielBindingSource.DataMember = "Types_Materiel";
            this.typesMaterielBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "N# d\'intervention";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type de matériel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Client";
            // 
            // textBox_mat_dateInstall
            // 
            this.textBox_mat_dateInstall.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materielsBindingSource, "mater_date_install", true));
            this.textBox_mat_dateInstall.Location = new System.Drawing.Point(142, 184);
            this.textBox_mat_dateInstall.Name = "textBox_mat_dateInstall";
            this.textBox_mat_dateInstall.Size = new System.Drawing.Size(231, 20);
            this.textBox_mat_dateInstall.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date d\'installation";
            // 
            // textBox_mat_mtbf
            // 
            this.textBox_mat_mtbf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materielsBindingSource, "mater_MTBF", true));
            this.textBox_mat_mtbf.Location = new System.Drawing.Point(142, 108);
            this.textBox_mat_mtbf.Name = "textBox_mat_mtbf";
            this.textBox_mat_mtbf.Size = new System.Drawing.Size(231, 20);
            this.textBox_mat_mtbf.TabIndex = 7;
            // 
            // textBox_mat_numSer
            // 
            this.textBox_mat_numSer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materielsBindingSource, "mater_num_ser", true));
            this.textBox_mat_numSer.Location = new System.Drawing.Point(142, 82);
            this.textBox_mat_numSer.Name = "textBox_mat_numSer";
            this.textBox_mat_numSer.Size = new System.Drawing.Size(231, 20);
            this.textBox_mat_numSer.TabIndex = 6;
            // 
            // textBox_mat_nom
            // 
            this.textBox_mat_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materielsBindingSource, "mater_nom", true));
            this.textBox_mat_nom.Location = new System.Drawing.Point(142, 56);
            this.textBox_mat_nom.Name = "textBox_mat_nom";
            this.textBox_mat_nom.Size = new System.Drawing.Size(231, 20);
            this.textBox_mat_nom.TabIndex = 5;
            // 
            // textBox_mat_id
            // 
            this.textBox_mat_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materielsBindingSource, "mater_id", true));
            this.textBox_mat_id.Location = new System.Drawing.Point(142, 30);
            this.textBox_mat_id.Name = "textBox_mat_id";
            this.textBox_mat_id.Size = new System.Drawing.Size(231, 20);
            this.textBox_mat_id.TabIndex = 4;
            // 
            // label_client_tel
            // 
            this.label_client_tel.AutoSize = true;
            this.label_client_tel.Location = new System.Drawing.Point(43, 111);
            this.label_client_tel.Name = "label_client_tel";
            this.label_client_tel.Size = new System.Drawing.Size(36, 13);
            this.label_client_tel.TabIndex = 3;
            this.label_client_tel.Text = "MTBF";
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(423, 67);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 8;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_abandonner
            // 
            this.button_abandonner.Location = new System.Drawing.Point(423, 132);
            this.button_abandonner.Name = "button_abandonner";
            this.button_abandonner.Size = new System.Drawing.Size(75, 23);
            this.button_abandonner.TabIndex = 9;
            this.button_abandonner.Text = "Abandonner";
            this.button_abandonner.UseVisualStyleBackColor = true;
            this.button_abandonner.Click += new System.EventHandler(this.button_abandonner_Click);
            // 
            // label_client_adresse
            // 
            this.label_client_adresse.AutoSize = true;
            this.label_client_adresse.Location = new System.Drawing.Point(43, 85);
            this.label_client_adresse.Name = "label_client_adresse";
            this.label_client_adresse.Size = new System.Drawing.Size(62, 13);
            this.label_client_adresse.TabIndex = 2;
            this.label_client_adresse.Text = "N# de série";
            // 
            // label_client_nom
            // 
            this.label_client_nom.AutoSize = true;
            this.label_client_nom.Location = new System.Drawing.Point(43, 58);
            this.label_client_nom.Name = "label_client_nom";
            this.label_client_nom.Size = new System.Drawing.Size(29, 13);
            this.label_client_nom.TabIndex = 1;
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
            // listBox_mat_nom
            // 
            this.listBox_mat_nom.DataSource = this.materielsBindingSource;
            this.listBox_mat_nom.DisplayMember = "mater_nom";
            this.listBox_mat_nom.FormattingEnabled = true;
            this.listBox_mat_nom.Location = new System.Drawing.Point(41, 55);
            this.listBox_mat_nom.Name = "listBox_mat_nom";
            this.listBox_mat_nom.Size = new System.Drawing.Size(167, 238);
            this.listBox_mat_nom.TabIndex = 15;
            // 
            // materielsTableAdapter
            // 
            this.materielsTableAdapter.ClearBeforeFill = true;
            // 
            // types_MaterielTableAdapter
            // 
            this.types_MaterielTableAdapter.ClearBeforeFill = true;
            // 
            // marquesTableAdapter
            // 
            this.marquesTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // interventionsTableAdapter
            // 
            this.interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // PPE3_Materiels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox_edition_mater);
            this.Controls.Add(this.listBox_mat_nom);
            this.Name = "PPE3_Materiels";
            this.Text = "GESTION MATOS - Matériels";
            this.Load += new System.EventHandler(this.PPE3_Materiels_Load);
            this.groupBox_edition_mater.ResumeLayout(false);
            this.groupBox_edition_mater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materielsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesMaterielBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.GroupBox groupBox_edition_mater;
        private System.Windows.Forms.TextBox textBox_mat_mtbf;
        private System.Windows.Forms.TextBox textBox_mat_numSer;
        private System.Windows.Forms.TextBox textBox_mat_nom;
        private System.Windows.Forms.TextBox textBox_mat_id;
        private System.Windows.Forms.Label label_client_tel;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Label label_client_adresse;
        private System.Windows.Forms.Label label_client_nom;
        private System.Windows.Forms.Label label_client_id;
        private System.Windows.Forms.ListBox listBox_mat_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mat_dateInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_mat_inter;
        private System.Windows.Forms.ComboBox comboBox_mat_client;
        private System.Windows.Forms.ComboBox comboBox_mat_marque;
        private System.Windows.Forms.ComboBox comboBox_mat_type;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource materielsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.MaterielsTableAdapter materielsTableAdapter;
        private System.Windows.Forms.BindingSource typesMaterielBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.Types_MaterielTableAdapter types_MaterielTableAdapter;
        private System.Windows.Forms.BindingSource marquesBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.MarquesTableAdapter marquesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource interventionsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter interventionsTableAdapter;
    }
}