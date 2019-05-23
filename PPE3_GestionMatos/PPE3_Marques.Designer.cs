namespace PPE3_GestionMatos
{
    partial class PPE3_Marques
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
            this.groupBox_edition_marque = new System.Windows.Forms.GroupBox();
            this.textBox_marque_nom = new System.Windows.Forms.TextBox();
            this.marquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.textBox_marque_id = new System.Windows.Forms.TextBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.label_marque_nom = new System.Windows.Forms.Label();
            this.label_marque_id = new System.Windows.Forms.Label();
            this.listBox_marques_nom = new System.Windows.Forms.ListBox();
            this.marquesTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.MarquesTableAdapter();
            this.groupBox_edition_marque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(685, 372);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(75, 23);
            this.button_fermer.TabIndex = 5;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(416, 372);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 4;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(323, 372);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 3;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(231, 372);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 2;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // groupBox_edition_marque
            // 
            this.groupBox_edition_marque.Controls.Add(this.textBox_marque_nom);
            this.groupBox_edition_marque.Controls.Add(this.textBox_marque_id);
            this.groupBox_edition_marque.Controls.Add(this.button_valider);
            this.groupBox_edition_marque.Controls.Add(this.button_abandonner);
            this.groupBox_edition_marque.Controls.Add(this.label_marque_nom);
            this.groupBox_edition_marque.Controls.Add(this.label_marque_id);
            this.groupBox_edition_marque.Location = new System.Drawing.Point(231, 55);
            this.groupBox_edition_marque.Name = "groupBox_edition_marque";
            this.groupBox_edition_marque.Size = new System.Drawing.Size(529, 238);
            this.groupBox_edition_marque.TabIndex = 0;
            this.groupBox_edition_marque.TabStop = false;
            this.groupBox_edition_marque.Text = "Edition";
            this.groupBox_edition_marque.Enter += new System.EventHandler(this.groupBox_edition_clients_Enter);
            // 
            // textBox_marque_nom
            // 
            this.textBox_marque_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marquesBindingSource, "marque_nom", true));
            this.textBox_marque_nom.Location = new System.Drawing.Point(143, 119);
            this.textBox_marque_nom.Name = "textBox_marque_nom";
            this.textBox_marque_nom.Size = new System.Drawing.Size(231, 20);
            this.textBox_marque_nom.TabIndex = 6;
            // 
            // marquesBindingSource
            // 
            this.marquesBindingSource.DataMember = "Marques";
            this.marquesBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // pPE3_GestionMatosDataSet
            // 
            this.pPE3_GestionMatosDataSet.DataSetName = "PPE3_GestionMatosDataSet";
            this.pPE3_GestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_marque_id
            // 
            this.textBox_marque_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marquesBindingSource, "marque_id", true));
            this.textBox_marque_id.Location = new System.Drawing.Point(143, 80);
            this.textBox_marque_id.Name = "textBox_marque_id";
            this.textBox_marque_id.Size = new System.Drawing.Size(231, 20);
            this.textBox_marque_id.TabIndex = 0;
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(423, 77);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 7;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_abandonner
            // 
            this.button_abandonner.Location = new System.Drawing.Point(423, 117);
            this.button_abandonner.Name = "button_abandonner";
            this.button_abandonner.Size = new System.Drawing.Size(75, 23);
            this.button_abandonner.TabIndex = 8;
            this.button_abandonner.Text = "Abandonner";
            this.button_abandonner.UseVisualStyleBackColor = true;
            this.button_abandonner.Click += new System.EventHandler(this.button_abandonner_Click);
            // 
            // label_marque_nom
            // 
            this.label_marque_nom.AutoSize = true;
            this.label_marque_nom.Location = new System.Drawing.Point(44, 121);
            this.label_marque_nom.Name = "label_marque_nom";
            this.label_marque_nom.Size = new System.Drawing.Size(29, 13);
            this.label_marque_nom.TabIndex = 0;
            this.label_marque_nom.Text = "Nom";
            // 
            // label_marque_id
            // 
            this.label_marque_id.AutoSize = true;
            this.label_marque_id.Location = new System.Drawing.Point(44, 83);
            this.label_marque_id.Name = "label_marque_id";
            this.label_marque_id.Size = new System.Drawing.Size(18, 13);
            this.label_marque_id.TabIndex = 0;
            this.label_marque_id.Text = "ID";
            // 
            // listBox_marques_nom
            // 
            this.listBox_marques_nom.DataSource = this.marquesBindingSource;
            this.listBox_marques_nom.DisplayMember = "marque_nom";
            this.listBox_marques_nom.FormattingEnabled = true;
            this.listBox_marques_nom.Location = new System.Drawing.Point(41, 55);
            this.listBox_marques_nom.Name = "listBox_marques_nom";
            this.listBox_marques_nom.Size = new System.Drawing.Size(167, 238);
            this.listBox_marques_nom.TabIndex = 1;
            // 
            // marquesTableAdapter
            // 
            this.marquesTableAdapter.ClearBeforeFill = true;
            // 
            // PPE3_Marques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox_edition_marque);
            this.Controls.Add(this.listBox_marques_nom);
            this.Name = "PPE3_Marques";
            this.Text = "GESTION MATOS - Marques";
            this.Load += new System.EventHandler(this.PPE3_Marques_Load);
            this.groupBox_edition_marque.ResumeLayout(false);
            this.groupBox_edition_marque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.GroupBox groupBox_edition_marque;
        private System.Windows.Forms.TextBox textBox_marque_nom;
        private System.Windows.Forms.TextBox textBox_marque_id;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Label label_marque_nom;
        private System.Windows.Forms.Label label_marque_id;
        private System.Windows.Forms.ListBox listBox_marques_nom;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource marquesBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.MarquesTableAdapter marquesTableAdapter;
    }
}