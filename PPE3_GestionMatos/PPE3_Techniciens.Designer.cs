namespace PPE3_GestionMatos
{
    partial class PPE3_Techniciens
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
            this.groupBox_edition_tech = new System.Windows.Forms.GroupBox();
            this.textBox_tech_tel = new System.Windows.Forms.TextBox();
            this.techniciensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.textBox_tech_nom = new System.Windows.Forms.TextBox();
            this.textBox_tech_id = new System.Windows.Forms.TextBox();
            this.label_tech_tel = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.label_tech_nom = new System.Windows.Forms.Label();
            this.label_tech_id = new System.Windows.Forms.Label();
            this.listBox_tech_nom = new System.Windows.Forms.ListBox();
            this.techniciensTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter();
            this.groupBox_edition_tech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
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
            // groupBox_edition_tech
            // 
            this.groupBox_edition_tech.Controls.Add(this.textBox_tech_tel);
            this.groupBox_edition_tech.Controls.Add(this.textBox_tech_nom);
            this.groupBox_edition_tech.Controls.Add(this.textBox_tech_id);
            this.groupBox_edition_tech.Controls.Add(this.label_tech_tel);
            this.groupBox_edition_tech.Controls.Add(this.button_valider);
            this.groupBox_edition_tech.Controls.Add(this.button_abandonner);
            this.groupBox_edition_tech.Controls.Add(this.label_tech_nom);
            this.groupBox_edition_tech.Controls.Add(this.label_tech_id);
            this.groupBox_edition_tech.Location = new System.Drawing.Point(231, 55);
            this.groupBox_edition_tech.Name = "groupBox_edition_tech";
            this.groupBox_edition_tech.Size = new System.Drawing.Size(529, 238);
            this.groupBox_edition_tech.TabIndex = 16;
            this.groupBox_edition_tech.TabStop = false;
            this.groupBox_edition_tech.Text = "Edition";
            // 
            // textBox_tech_tel
            // 
            this.textBox_tech_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_tel", true));
            this.textBox_tech_tel.Location = new System.Drawing.Point(142, 139);
            this.textBox_tech_tel.Name = "textBox_tech_tel";
            this.textBox_tech_tel.Size = new System.Drawing.Size(231, 20);
            this.textBox_tech_tel.TabIndex = 7;
            // 
            // techniciensBindingSource
            // 
            this.techniciensBindingSource.DataMember = "Techniciens";
            this.techniciensBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // pPE3_GestionMatosDataSet
            // 
            this.pPE3_GestionMatosDataSet.DataSetName = "PPE3_GestionMatosDataSet";
            this.pPE3_GestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_tech_nom
            // 
            this.textBox_tech_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_nom", true));
            this.textBox_tech_nom.Location = new System.Drawing.Point(142, 106);
            this.textBox_tech_nom.Name = "textBox_tech_nom";
            this.textBox_tech_nom.Size = new System.Drawing.Size(231, 20);
            this.textBox_tech_nom.TabIndex = 5;
            // 
            // textBox_tech_id
            // 
            this.textBox_tech_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_id", true));
            this.textBox_tech_id.Location = new System.Drawing.Point(142, 67);
            this.textBox_tech_id.Name = "textBox_tech_id";
            this.textBox_tech_id.Size = new System.Drawing.Size(231, 20);
            this.textBox_tech_id.TabIndex = 4;
            // 
            // label_tech_tel
            // 
            this.label_tech_tel.AutoSize = true;
            this.label_tech_tel.Location = new System.Drawing.Point(43, 146);
            this.label_tech_tel.Name = "label_tech_tel";
            this.label_tech_tel.Size = new System.Drawing.Size(58, 13);
            this.label_tech_tel.TabIndex = 3;
            this.label_tech_tel.Text = "Téléphone";
            this.label_tech_tel.Click += new System.EventHandler(this.label_client_tel_Click);
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
            // label_tech_nom
            // 
            this.label_tech_nom.AutoSize = true;
            this.label_tech_nom.Location = new System.Drawing.Point(43, 108);
            this.label_tech_nom.Name = "label_tech_nom";
            this.label_tech_nom.Size = new System.Drawing.Size(29, 13);
            this.label_tech_nom.TabIndex = 1;
            this.label_tech_nom.Text = "Nom";
            // 
            // label_tech_id
            // 
            this.label_tech_id.AutoSize = true;
            this.label_tech_id.Location = new System.Drawing.Point(43, 70);
            this.label_tech_id.Name = "label_tech_id";
            this.label_tech_id.Size = new System.Drawing.Size(18, 13);
            this.label_tech_id.TabIndex = 0;
            this.label_tech_id.Text = "ID";
            // 
            // listBox_tech_nom
            // 
            this.listBox_tech_nom.DataSource = this.techniciensBindingSource;
            this.listBox_tech_nom.DisplayMember = "tech_nom";
            this.listBox_tech_nom.FormattingEnabled = true;
            this.listBox_tech_nom.Location = new System.Drawing.Point(41, 55);
            this.listBox_tech_nom.Name = "listBox_tech_nom";
            this.listBox_tech_nom.Size = new System.Drawing.Size(167, 238);
            this.listBox_tech_nom.TabIndex = 15;
            // 
            // techniciensTableAdapter
            // 
            this.techniciensTableAdapter.ClearBeforeFill = true;
            // 
            // PPE3_Techniciens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox_edition_tech);
            this.Controls.Add(this.listBox_tech_nom);
            this.Name = "PPE3_Techniciens";
            this.Text = "GESTION MATOS - Techniciens";
            this.Load += new System.EventHandler(this.PPE3_Techniciens_Load);
            this.groupBox_edition_tech.ResumeLayout(false);
            this.groupBox_edition_tech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.GroupBox groupBox_edition_tech;
        private System.Windows.Forms.TextBox textBox_tech_tel;
        private System.Windows.Forms.TextBox textBox_tech_nom;
        private System.Windows.Forms.TextBox textBox_tech_id;
        private System.Windows.Forms.Label label_tech_tel;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Label label_tech_nom;
        private System.Windows.Forms.Label label_tech_id;
        private System.Windows.Forms.ListBox listBox_tech_nom;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource techniciensBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter techniciensTableAdapter;
    }
}