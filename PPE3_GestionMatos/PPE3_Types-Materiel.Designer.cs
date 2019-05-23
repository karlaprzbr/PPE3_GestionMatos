namespace PPE3_GestionMatos
{
    partial class PPE3_Types_Materiel
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
            this.groupBox_edition_typeMater = new System.Windows.Forms.GroupBox();
            this.textBox_typeMater_type = new System.Windows.Forms.TextBox();
            this.typesMaterielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PPE3_GestionMatos.PPE3_GestionMatosDataSet();
            this.textBox_typeMater_id = new System.Windows.Forms.TextBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.label_typeMater_type = new System.Windows.Forms.Label();
            this.label_typeMater_id = new System.Windows.Forms.Label();
            this.listBox_typeMater_nom = new System.Windows.Forms.ListBox();
            this.types_MaterielTableAdapter = new PPE3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.Types_MaterielTableAdapter();
            this.groupBox_edition_typeMater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesMaterielBindingSource)).BeginInit();
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
            // groupBox_edition_typeMater
            // 
            this.groupBox_edition_typeMater.Controls.Add(this.textBox_typeMater_type);
            this.groupBox_edition_typeMater.Controls.Add(this.textBox_typeMater_id);
            this.groupBox_edition_typeMater.Controls.Add(this.button_valider);
            this.groupBox_edition_typeMater.Controls.Add(this.button_abandonner);
            this.groupBox_edition_typeMater.Controls.Add(this.label_typeMater_type);
            this.groupBox_edition_typeMater.Controls.Add(this.label_typeMater_id);
            this.groupBox_edition_typeMater.Location = new System.Drawing.Point(231, 55);
            this.groupBox_edition_typeMater.Name = "groupBox_edition_typeMater";
            this.groupBox_edition_typeMater.Size = new System.Drawing.Size(529, 238);
            this.groupBox_edition_typeMater.TabIndex = 16;
            this.groupBox_edition_typeMater.TabStop = false;
            this.groupBox_edition_typeMater.Text = "Edition";
            // 
            // textBox_typeMater_type
            // 
            this.textBox_typeMater_type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typesMaterielBindingSource, "type_nom", true));
            this.textBox_typeMater_type.Location = new System.Drawing.Point(145, 121);
            this.textBox_typeMater_type.Name = "textBox_typeMater_type";
            this.textBox_typeMater_type.Size = new System.Drawing.Size(231, 20);
            this.textBox_typeMater_type.TabIndex = 5;
            // 
            // typesMaterielBindingSource
            // 
            this.typesMaterielBindingSource.DataMember = "Types_Materiel";
            this.typesMaterielBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // pPE3_GestionMatosDataSet
            // 
            this.pPE3_GestionMatosDataSet.DataSetName = "PPE3_GestionMatosDataSet";
            this.pPE3_GestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_typeMater_id
            // 
            this.textBox_typeMater_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typesMaterielBindingSource, "type_id", true));
            this.textBox_typeMater_id.Location = new System.Drawing.Point(145, 82);
            this.textBox_typeMater_id.Name = "textBox_typeMater_id";
            this.textBox_typeMater_id.Size = new System.Drawing.Size(231, 20);
            this.textBox_typeMater_id.TabIndex = 4;
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(423, 82);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 8;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_abandonner
            // 
            this.button_abandonner.Location = new System.Drawing.Point(423, 118);
            this.button_abandonner.Name = "button_abandonner";
            this.button_abandonner.Size = new System.Drawing.Size(75, 23);
            this.button_abandonner.TabIndex = 9;
            this.button_abandonner.Text = "Abandonner";
            this.button_abandonner.UseVisualStyleBackColor = true;
            this.button_abandonner.Click += new System.EventHandler(this.button_abandonner_Click);
            // 
            // label_typeMater_type
            // 
            this.label_typeMater_type.AutoSize = true;
            this.label_typeMater_type.Location = new System.Drawing.Point(46, 123);
            this.label_typeMater_type.Name = "label_typeMater_type";
            this.label_typeMater_type.Size = new System.Drawing.Size(31, 13);
            this.label_typeMater_type.TabIndex = 1;
            this.label_typeMater_type.Text = "Type";
            // 
            // label_typeMater_id
            // 
            this.label_typeMater_id.AutoSize = true;
            this.label_typeMater_id.Location = new System.Drawing.Point(46, 85);
            this.label_typeMater_id.Name = "label_typeMater_id";
            this.label_typeMater_id.Size = new System.Drawing.Size(18, 13);
            this.label_typeMater_id.TabIndex = 0;
            this.label_typeMater_id.Text = "ID";
            // 
            // listBox_typeMater_nom
            // 
            this.listBox_typeMater_nom.DataSource = this.typesMaterielBindingSource;
            this.listBox_typeMater_nom.DisplayMember = "type_nom";
            this.listBox_typeMater_nom.FormattingEnabled = true;
            this.listBox_typeMater_nom.Location = new System.Drawing.Point(41, 55);
            this.listBox_typeMater_nom.Name = "listBox_typeMater_nom";
            this.listBox_typeMater_nom.Size = new System.Drawing.Size(167, 238);
            this.listBox_typeMater_nom.TabIndex = 15;
            // 
            // types_MaterielTableAdapter
            // 
            this.types_MaterielTableAdapter.ClearBeforeFill = true;
            // 
            // PPE3_Types_Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox_edition_typeMater);
            this.Controls.Add(this.listBox_typeMater_nom);
            this.Name = "PPE3_Types_Materiel";
            this.Text = "GESTION MATOS - Types de matériels";
            this.Load += new System.EventHandler(this.PPE3_Types_Materiel_Load);
            this.groupBox_edition_typeMater.ResumeLayout(false);
            this.groupBox_edition_typeMater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesMaterielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.GroupBox groupBox_edition_typeMater;
        private System.Windows.Forms.TextBox textBox_typeMater_type;
        private System.Windows.Forms.TextBox textBox_typeMater_id;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Label label_typeMater_type;
        private System.Windows.Forms.Label label_typeMater_id;
        private System.Windows.Forms.ListBox listBox_typeMater_nom;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource typesMaterielBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.Types_MaterielTableAdapter types_MaterielTableAdapter;
    }
}