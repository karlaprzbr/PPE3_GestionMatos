namespace PPE3_GestionMatos
{
    partial class PPE3_Accueil
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
            this.button_clients = new System.Windows.Forms.Button();
            this.button_interventions = new System.Windows.Forms.Button();
            this.button_typeMatos = new System.Windows.Forms.Button();
            this.button_techniciens = new System.Windows.Forms.Button();
            this.button_marques = new System.Windows.Forms.Button();
            this.button_materiels = new System.Windows.Forms.Button();
            this.groupBox_interventions = new System.Windows.Forms.GroupBox();
            this.listBox_inter_dates = new System.Windows.Forms.ListBox();
            this.textBox_inter_tech = new System.Windows.Forms.TextBox();
            this.label_tech = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.groupBox_materiel = new System.Windows.Forms.GroupBox();
            this.label_accueil = new System.Windows.Forms.Label();
            this.button_deconnexion = new System.Windows.Forms.Button();
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.interventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interventionsTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter();
            this.techniciensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter();
            this.groupBox_interventions.SuspendLayout();
            this.groupBox_materiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_clients
            // 
            this.button_clients.Location = new System.Drawing.Point(177, 131);
            this.button_clients.Name = "button_clients";
            this.button_clients.Size = new System.Drawing.Size(191, 23);
            this.button_clients.TabIndex = 5;
            this.button_clients.Text = "Liste des clients";
            this.button_clients.UseVisualStyleBackColor = true;
            this.button_clients.Click += new System.EventHandler(this.button_clients_Click);
            // 
            // button_interventions
            // 
            this.button_interventions.Location = new System.Drawing.Point(177, 73);
            this.button_interventions.Name = "button_interventions";
            this.button_interventions.Size = new System.Drawing.Size(191, 23);
            this.button_interventions.TabIndex = 3;
            this.button_interventions.Text = "Editer les interventions";
            this.button_interventions.UseVisualStyleBackColor = true;
            this.button_interventions.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_typeMatos
            // 
            this.button_typeMatos.Location = new System.Drawing.Point(75, 102);
            this.button_typeMatos.Name = "button_typeMatos";
            this.button_typeMatos.Size = new System.Drawing.Size(118, 23);
            this.button_typeMatos.TabIndex = 8;
            this.button_typeMatos.Text = "Types de matériel";
            this.button_typeMatos.UseVisualStyleBackColor = true;
            this.button_typeMatos.Click += new System.EventHandler(this.button_typeMatos_Click);
            // 
            // button_techniciens
            // 
            this.button_techniciens.Location = new System.Drawing.Point(177, 102);
            this.button_techniciens.Name = "button_techniciens";
            this.button_techniciens.Size = new System.Drawing.Size(191, 23);
            this.button_techniciens.TabIndex = 4;
            this.button_techniciens.Text = "Liste des techniciens";
            this.button_techniciens.UseVisualStyleBackColor = true;
            this.button_techniciens.Click += new System.EventHandler(this.button_techniciens_Click);
            // 
            // button_marques
            // 
            this.button_marques.Location = new System.Drawing.Point(75, 73);
            this.button_marques.Name = "button_marques";
            this.button_marques.Size = new System.Drawing.Size(118, 23);
            this.button_marques.TabIndex = 7;
            this.button_marques.Text = "Liste des marques";
            this.button_marques.UseVisualStyleBackColor = true;
            this.button_marques.Click += new System.EventHandler(this.button_marques_Click);
            // 
            // button_materiels
            // 
            this.button_materiels.Location = new System.Drawing.Point(75, 44);
            this.button_materiels.Name = "button_materiels";
            this.button_materiels.Size = new System.Drawing.Size(118, 23);
            this.button_materiels.TabIndex = 6;
            this.button_materiels.Text = "Liste des matériels";
            this.button_materiels.UseVisualStyleBackColor = true;
            this.button_materiels.Click += new System.EventHandler(this.button_materiels_Click);
            // 
            // groupBox_interventions
            // 
            this.groupBox_interventions.Controls.Add(this.listBox_inter_dates);
            this.groupBox_interventions.Controls.Add(this.textBox_inter_tech);
            this.groupBox_interventions.Controls.Add(this.label_tech);
            this.groupBox_interventions.Controls.Add(this.label_date);
            this.groupBox_interventions.Controls.Add(this.button_techniciens);
            this.groupBox_interventions.Controls.Add(this.button_clients);
            this.groupBox_interventions.Controls.Add(this.button_interventions);
            this.groupBox_interventions.Location = new System.Drawing.Point(37, 130);
            this.groupBox_interventions.Name = "groupBox_interventions";
            this.groupBox_interventions.Size = new System.Drawing.Size(418, 204);
            this.groupBox_interventions.TabIndex = 0;
            this.groupBox_interventions.TabStop = false;
            this.groupBox_interventions.Text = "Prochaines interventions";
            // 
            // listBox_inter_dates
            // 
            this.listBox_inter_dates.DataSource = this.interventionsBindingSource;
            this.listBox_inter_dates.DisplayMember = "inter_date";
            this.listBox_inter_dates.FormattingEnabled = true;
            this.listBox_inter_dates.Location = new System.Drawing.Point(21, 41);
            this.listBox_inter_dates.Name = "listBox_inter_dates";
            this.listBox_inter_dates.Size = new System.Drawing.Size(120, 147);
            this.listBox_inter_dates.TabIndex = 1;
            // 
            // textBox_inter_tech
            // 
            this.textBox_inter_tech.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_nom", true));
            this.textBox_inter_tech.Location = new System.Drawing.Point(177, 44);
            this.textBox_inter_tech.Name = "textBox_inter_tech";
            this.textBox_inter_tech.Size = new System.Drawing.Size(191, 20);
            this.textBox_inter_tech.TabIndex = 2;
            // 
            // label_tech
            // 
            this.label_tech.AutoSize = true;
            this.label_tech.Location = new System.Drawing.Point(174, 27);
            this.label_tech.Name = "label_tech";
            this.label_tech.Size = new System.Drawing.Size(60, 13);
            this.label_tech.TabIndex = 1;
            this.label_tech.Text = "Technicien";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(18, 27);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Date";
            // 
            // groupBox_materiel
            // 
            this.groupBox_materiel.Controls.Add(this.button_materiels);
            this.groupBox_materiel.Controls.Add(this.button_marques);
            this.groupBox_materiel.Controls.Add(this.button_typeMatos);
            this.groupBox_materiel.Location = new System.Drawing.Point(484, 130);
            this.groupBox_materiel.Name = "groupBox_materiel";
            this.groupBox_materiel.Size = new System.Drawing.Size(264, 204);
            this.groupBox_materiel.TabIndex = 0;
            this.groupBox_materiel.TabStop = false;
            this.groupBox_materiel.Text = "Matériel";
            // 
            // label_accueil
            // 
            this.label_accueil.AutoSize = true;
            this.label_accueil.Location = new System.Drawing.Point(391, 66);
            this.label_accueil.Name = "label_accueil";
            this.label_accueil.Size = new System.Drawing.Size(52, 13);
            this.label_accueil.TabIndex = 0;
            this.label_accueil.Text = "ACCUEIL";
            // 
            // button_deconnexion
            // 
            this.button_deconnexion.Location = new System.Drawing.Point(669, 371);
            this.button_deconnexion.Name = "button_deconnexion";
            this.button_deconnexion.Size = new System.Drawing.Size(79, 23);
            this.button_deconnexion.TabIndex = 9;
            this.button_deconnexion.Text = "Déconnexion";
            this.button_deconnexion.UseVisualStyleBackColor = true;
            this.button_deconnexion.Click += new System.EventHandler(this.button_deconnexion_Click);
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
            // interventionsTableAdapter
            // 
            this.interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // techniciensBindingSource
            // 
            this.techniciensBindingSource.DataMember = "Techniciens";
            this.techniciensBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // techniciensTableAdapter
            // 
            this.techniciensTableAdapter.ClearBeforeFill = true;
            // 
            // PPE3_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_deconnexion);
            this.Controls.Add(this.label_accueil);
            this.Controls.Add(this.groupBox_materiel);
            this.Controls.Add(this.groupBox_interventions);
            this.Name = "PPE3_Accueil";
            this.Text = "GESTION MATOS - Accueil";
            this.Load += new System.EventHandler(this.PPE3_Accueil_Load);
            this.groupBox_interventions.ResumeLayout(false);
            this.groupBox_interventions.PerformLayout();
            this.groupBox_materiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clients;
        private System.Windows.Forms.Button button_interventions;
        private System.Windows.Forms.Button button_typeMatos;
        private System.Windows.Forms.Button button_techniciens;
        private System.Windows.Forms.Button button_marques;
        private System.Windows.Forms.Button button_materiels;
        private System.Windows.Forms.GroupBox groupBox_interventions;
        private System.Windows.Forms.ListBox listBox_inter_dates;
        private System.Windows.Forms.TextBox textBox_inter_tech;
        private System.Windows.Forms.Label label_tech;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.GroupBox groupBox_materiel;
        private System.Windows.Forms.Label label_accueil;
        private System.Windows.Forms.Button button_deconnexion;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource interventionsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter interventionsTableAdapter;
        private System.Windows.Forms.BindingSource techniciensBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter techniciensTableAdapter;
    }
}