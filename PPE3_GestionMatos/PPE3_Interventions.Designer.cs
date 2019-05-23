namespace PPE3_GestionMatos
{
    partial class PPE3_Interventions
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
            this.groupBox_edition_inter = new System.Windows.Forms.GroupBox();
            this.comboBox_inter_id_client = new System.Windows.Forms.ComboBox();
            this.interventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_inter_nom_tech = new System.Windows.Forms.Label();
            this.comboBox_inter_id_tech = new System.Windows.Forms.ComboBox();
            this.techniciensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_inter_nom_client = new System.Windows.Forms.Label();
            this.textBox_inter_numero = new System.Windows.Forms.TextBox();
            this.textBox_inter_date = new System.Windows.Forms.TextBox();
            this.textBox_inter_id = new System.Windows.Forms.TextBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.label_inter_numero = new System.Windows.Forms.Label();
            this.label_inter_date = new System.Windows.Forms.Label();
            this.label_inter_id = new System.Windows.Forms.Label();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox_inter_date = new System.Windows.Forms.ListBox();
            this.interventionsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter();
            this.fKMaterielsInterventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materielsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.MaterielsTableAdapter();
            this.interventionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter();
            this.clientsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter();
            this.interventionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.interventionsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_edition_inter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMaterielsInterventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource3)).BeginInit();
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
            // groupBox_edition_inter
            // 
            this.groupBox_edition_inter.Controls.Add(this.comboBox_inter_id_client);
            this.groupBox_edition_inter.Controls.Add(this.label_inter_nom_tech);
            this.groupBox_edition_inter.Controls.Add(this.comboBox_inter_id_tech);
            this.groupBox_edition_inter.Controls.Add(this.label_inter_nom_client);
            this.groupBox_edition_inter.Controls.Add(this.textBox_inter_numero);
            this.groupBox_edition_inter.Controls.Add(this.textBox_inter_date);
            this.groupBox_edition_inter.Controls.Add(this.textBox_inter_id);
            this.groupBox_edition_inter.Controls.Add(this.button_valider);
            this.groupBox_edition_inter.Controls.Add(this.button_abandonner);
            this.groupBox_edition_inter.Controls.Add(this.label_inter_numero);
            this.groupBox_edition_inter.Controls.Add(this.label_inter_date);
            this.groupBox_edition_inter.Controls.Add(this.label_inter_id);
            this.groupBox_edition_inter.Location = new System.Drawing.Point(231, 55);
            this.groupBox_edition_inter.Name = "groupBox_edition_inter";
            this.groupBox_edition_inter.Size = new System.Drawing.Size(529, 280);
            this.groupBox_edition_inter.TabIndex = 16;
            this.groupBox_edition_inter.TabStop = false;
            this.groupBox_edition_inter.Text = "Edition";
            this.groupBox_edition_inter.Enter += new System.EventHandler(this.groupBox_edition_clients_Enter);
            // 
            // comboBox_inter_id_client
            // 
            this.comboBox_inter_id_client.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.interventionsBindingSource, "inter_client", true));
            this.comboBox_inter_id_client.DataSource = this.clientsBindingSource;
            this.comboBox_inter_id_client.DisplayMember = "client_nom";
            this.comboBox_inter_id_client.FormattingEnabled = true;
            this.comboBox_inter_id_client.Location = new System.Drawing.Point(142, 176);
            this.comboBox_inter_id_client.Name = "comboBox_inter_id_client";
            this.comboBox_inter_id_client.Size = new System.Drawing.Size(231, 21);
            this.comboBox_inter_id_client.TabIndex = 16;
            this.comboBox_inter_id_client.ValueMember = "client_id";
            // 
            // interventionsBindingSource
            // 
            this.interventionsBindingSource.DataMember = "Interventions";
            this.interventionsBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // pPE3_GestionMatosDataSet
            // 
            this.pPE3_GestionMatosDataSet.DataSetName = "PPE3_GestionMatosDataSet";
            this.pPE3_GestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // label_inter_nom_tech
            // 
            this.label_inter_nom_tech.AutoSize = true;
            this.label_inter_nom_tech.Location = new System.Drawing.Point(43, 142);
            this.label_inter_nom_tech.Name = "label_inter_nom_tech";
            this.label_inter_nom_tech.Size = new System.Drawing.Size(60, 13);
            this.label_inter_nom_tech.TabIndex = 13;
            this.label_inter_nom_tech.Text = "Technicien";
            // 
            // comboBox_inter_id_tech
            // 
            this.comboBox_inter_id_tech.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.interventionsBindingSource, "inter_tech", true));
            this.comboBox_inter_id_tech.DataSource = this.techniciensBindingSource;
            this.comboBox_inter_id_tech.DisplayMember = "tech_nom";
            this.comboBox_inter_id_tech.FormattingEnabled = true;
            this.comboBox_inter_id_tech.Location = new System.Drawing.Point(142, 139);
            this.comboBox_inter_id_tech.Name = "comboBox_inter_id_tech";
            this.comboBox_inter_id_tech.Size = new System.Drawing.Size(231, 21);
            this.comboBox_inter_id_tech.TabIndex = 12;
            this.comboBox_inter_id_tech.ValueMember = "tech_id";
            // 
            // techniciensBindingSource
            // 
            this.techniciensBindingSource.DataMember = "Techniciens";
            this.techniciensBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // label_inter_nom_client
            // 
            this.label_inter_nom_client.AutoSize = true;
            this.label_inter_nom_client.Location = new System.Drawing.Point(43, 179);
            this.label_inter_nom_client.Name = "label_inter_nom_client";
            this.label_inter_nom_client.Size = new System.Drawing.Size(33, 13);
            this.label_inter_nom_client.TabIndex = 10;
            this.label_inter_nom_client.Text = "Client";
            // 
            // textBox_inter_numero
            // 
            this.textBox_inter_numero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventionsBindingSource, "inter_numero", true));
            this.textBox_inter_numero.Location = new System.Drawing.Point(142, 106);
            this.textBox_inter_numero.Name = "textBox_inter_numero";
            this.textBox_inter_numero.Size = new System.Drawing.Size(231, 20);
            this.textBox_inter_numero.TabIndex = 6;
            // 
            // textBox_inter_date
            // 
            this.textBox_inter_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventionsBindingSource, "inter_date", true));
            this.textBox_inter_date.Location = new System.Drawing.Point(142, 69);
            this.textBox_inter_date.Name = "textBox_inter_date";
            this.textBox_inter_date.Size = new System.Drawing.Size(231, 20);
            this.textBox_inter_date.TabIndex = 5;
            // 
            // textBox_inter_id
            // 
            this.textBox_inter_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventionsBindingSource, "inter_id", true));
            this.textBox_inter_id.Location = new System.Drawing.Point(142, 30);
            this.textBox_inter_id.Name = "textBox_inter_id";
            this.textBox_inter_id.Size = new System.Drawing.Size(231, 20);
            this.textBox_inter_id.TabIndex = 4;
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
            // label_inter_numero
            // 
            this.label_inter_numero.AutoSize = true;
            this.label_inter_numero.Location = new System.Drawing.Point(43, 109);
            this.label_inter_numero.Name = "label_inter_numero";
            this.label_inter_numero.Size = new System.Drawing.Size(88, 13);
            this.label_inter_numero.TabIndex = 2;
            this.label_inter_numero.Text = "N# d\'intervention";
            // 
            // label_inter_date
            // 
            this.label_inter_date.AutoSize = true;
            this.label_inter_date.Location = new System.Drawing.Point(43, 71);
            this.label_inter_date.Name = "label_inter_date";
            this.label_inter_date.Size = new System.Drawing.Size(30, 13);
            this.label_inter_date.TabIndex = 1;
            this.label_inter_date.Text = "Date";
            // 
            // label_inter_id
            // 
            this.label_inter_id.AutoSize = true;
            this.label_inter_id.Location = new System.Drawing.Point(43, 33);
            this.label_inter_id.Name = "label_inter_id";
            this.label_inter_id.Size = new System.Drawing.Size(18, 13);
            this.label_inter_id.TabIndex = 0;
            this.label_inter_id.Text = "ID";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "Clients";
            this.clientsBindingSource2.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // techniciensBindingSource1
            // 
            this.techniciensBindingSource1.DataMember = "Techniciens";
            this.techniciensBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // listBox_inter_date
            // 
            this.listBox_inter_date.DataSource = this.interventionsBindingSource;
            this.listBox_inter_date.DisplayMember = "inter_date";
            this.listBox_inter_date.FormattingEnabled = true;
            this.listBox_inter_date.Location = new System.Drawing.Point(41, 55);
            this.listBox_inter_date.Name = "listBox_inter_date";
            this.listBox_inter_date.Size = new System.Drawing.Size(167, 238);
            this.listBox_inter_date.TabIndex = 15;
            // 
            // interventionsTableAdapter
            // 
            this.interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // fKMaterielsInterventionsBindingSource
            // 
            this.fKMaterielsInterventionsBindingSource.DataMember = "FK_Materiels_Interventions";
            this.fKMaterielsInterventionsBindingSource.DataSource = this.interventionsBindingSource;
            // 
            // materielsTableAdapter
            // 
            this.materielsTableAdapter.ClearBeforeFill = true;
            // 
            // interventionsBindingSource1
            // 
            this.interventionsBindingSource1.DataMember = "Interventions";
            this.interventionsBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // techniciensTableAdapter
            // 
            this.techniciensTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // interventionsBindingSource2
            // 
            this.interventionsBindingSource2.DataMember = "Interventions";
            this.interventionsBindingSource2.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // interventionsBindingSource3
            // 
            this.interventionsBindingSource3.DataMember = "Interventions";
            this.interventionsBindingSource3.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // PPE3_Interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox_edition_inter);
            this.Controls.Add(this.listBox_inter_date);
            this.Name = "PPE3_Interventions";
            this.Text = "Interventions";
            this.Load += new System.EventHandler(this.PPE3_Interventions_Load);
            this.groupBox_edition_inter.ResumeLayout(false);
            this.groupBox_edition_inter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMaterielsInterventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.GroupBox groupBox_edition_inter;
        private System.Windows.Forms.TextBox textBox_inter_numero;
        private System.Windows.Forms.TextBox textBox_inter_date;
        private System.Windows.Forms.TextBox textBox_inter_id;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Label label_inter_numero;
        private System.Windows.Forms.Label label_inter_date;
        private System.Windows.Forms.Label label_inter_id;
        private System.Windows.Forms.ListBox listBox_inter_date;
        private System.Windows.Forms.Label label_inter_nom_client;
        private System.Windows.Forms.Label label_inter_nom_tech;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource interventionsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter interventionsTableAdapter;
        private System.Windows.Forms.BindingSource fKMaterielsInterventionsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.MaterielsTableAdapter materielsTableAdapter;
        private System.Windows.Forms.BindingSource interventionsBindingSource1;
        private System.Windows.Forms.BindingSource techniciensBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter techniciensTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource interventionsBindingSource2;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private System.Windows.Forms.BindingSource techniciensBindingSource1;
        private System.Windows.Forms.ComboBox comboBox_inter_id_client;
        private System.Windows.Forms.ComboBox comboBox_inter_id_tech;
        private System.Windows.Forms.BindingSource interventionsBindingSource3;
    }
}