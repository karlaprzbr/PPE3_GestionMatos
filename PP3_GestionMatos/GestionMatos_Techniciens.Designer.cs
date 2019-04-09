namespace PP3_GestionMatos
{
    partial class GestionMatos_Techniciens
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
            this.annulerButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.supprimerButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.editionGroupBox = new System.Windows.Forms.GroupBox();
            this.abandonnerButton = new System.Windows.Forms.Button();
            this.validerButton = new System.Windows.Forms.Button();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.techniciensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PP3_GestionMatos.PPE3_GestionMatosDataSet();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.listBox_tech = new System.Windows.Forms.ListBox();
            this.techniciensTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter();
            this.editionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(691, 383);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 13;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(579, 383);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // supprimerButton
            // 
            this.supprimerButton.Location = new System.Drawing.Point(476, 383);
            this.supprimerButton.Name = "supprimerButton";
            this.supprimerButton.Size = new System.Drawing.Size(75, 23);
            this.supprimerButton.TabIndex = 11;
            this.supprimerButton.Text = "Supprimer";
            this.supprimerButton.UseVisualStyleBackColor = true;
            this.supprimerButton.Click += new System.EventHandler(this.supprimerButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(359, 383);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(75, 23);
            this.modifierButton.TabIndex = 10;
            this.modifierButton.Text = "Modifier";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // ajouterButton
            // 
            this.ajouterButton.Location = new System.Drawing.Point(261, 383);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(75, 23);
            this.ajouterButton.TabIndex = 9;
            this.ajouterButton.Text = "Ajouter";
            this.ajouterButton.UseVisualStyleBackColor = true;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // editionGroupBox
            // 
            this.editionGroupBox.Controls.Add(this.abandonnerButton);
            this.editionGroupBox.Controls.Add(this.validerButton);
            this.editionGroupBox.Controls.Add(this.label_tel);
            this.editionGroupBox.Controls.Add(this.label_nom);
            this.editionGroupBox.Controls.Add(this.label_id);
            this.editionGroupBox.Controls.Add(this.textBox_tel);
            this.editionGroupBox.Controls.Add(this.textBox_nom);
            this.editionGroupBox.Controls.Add(this.textBox_id);
            this.editionGroupBox.Location = new System.Drawing.Point(175, 44);
            this.editionGroupBox.Name = "editionGroupBox";
            this.editionGroupBox.Size = new System.Drawing.Size(591, 277);
            this.editionGroupBox.TabIndex = 8;
            this.editionGroupBox.TabStop = false;
            this.editionGroupBox.Text = "Edition";
            // 
            // abandonnerButton
            // 
            this.abandonnerButton.Location = new System.Drawing.Point(475, 117);
            this.abandonnerButton.Name = "abandonnerButton";
            this.abandonnerButton.Size = new System.Drawing.Size(75, 23);
            this.abandonnerButton.TabIndex = 2;
            this.abandonnerButton.Text = "Abandonner";
            this.abandonnerButton.UseVisualStyleBackColor = true;
            this.abandonnerButton.Click += new System.EventHandler(this.abandonnerButton_Click);
            // 
            // validerButton
            // 
            this.validerButton.Location = new System.Drawing.Point(475, 38);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(75, 23);
            this.validerButton.TabIndex = 10;
            this.validerButton.Text = "Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Location = new System.Drawing.Point(27, 124);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(58, 13);
            this.label_tel.TabIndex = 8;
            this.label_tel.Text = "Télephone";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(27, 77);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(29, 13);
            this.label_nom.TabIndex = 6;
            this.label_nom.Text = "Nom";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(27, 48);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "ID";
            // 
            // textBox_tel
            // 
            this.textBox_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_tel", true));
            this.textBox_tel.Location = new System.Drawing.Point(117, 117);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(302, 20);
            this.textBox_tel.TabIndex = 3;
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
            // textBox_nom
            // 
            this.textBox_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_nom", true));
            this.textBox_nom.Location = new System.Drawing.Point(117, 74);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(302, 20);
            this.textBox_nom.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_id", true));
            this.textBox_id.Location = new System.Drawing.Point(117, 41);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(302, 20);
            this.textBox_id.TabIndex = 0;
            // 
            // listBox_tech
            // 
            this.listBox_tech.DataSource = this.techniciensBindingSource;
            this.listBox_tech.DisplayMember = "tech_nom";
            this.listBox_tech.FormattingEnabled = true;
            this.listBox_tech.Location = new System.Drawing.Point(35, 44);
            this.listBox_tech.Name = "listBox_tech";
            this.listBox_tech.Size = new System.Drawing.Size(120, 277);
            this.listBox_tech.TabIndex = 7;
            // 
            // techniciensTableAdapter
            // 
            this.techniciensTableAdapter.ClearBeforeFill = true;
            // 
            // GestionMatos_Techniciens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.supprimerButton);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.ajouterButton);
            this.Controls.Add(this.editionGroupBox);
            this.Controls.Add(this.listBox_tech);
            this.Name = "GestionMatos_Techniciens";
            this.Text = "GESTION MATOS - Techniciens";
            this.Load += new System.EventHandler(this.GestionMatos_Techniciens_Load);
            this.editionGroupBox.ResumeLayout(false);
            this.editionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button supprimerButton;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.GroupBox editionGroupBox;
        private System.Windows.Forms.Button abandonnerButton;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ListBox listBox_tech;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource techniciensBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter techniciensTableAdapter;
    }
}