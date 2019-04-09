namespace PP3_GestionMatos
{
    partial class GestionMatos_Interventions
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
            this.label_com = new System.Windows.Forms.Label();
            this.label_technicien = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_inter_com = new System.Windows.Forms.TextBox();
            this.interventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PP3_GestionMatos.PPE3_GestionMatosDataSet();
            this.techniciensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_inter_date = new System.Windows.Forms.TextBox();
            this.textBox_inter_id = new System.Windows.Forms.TextBox();
            this.listBox_inter = new System.Windows.Forms.ListBox();
            this.interventionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.interventionsTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter();
            this.techniciensTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter();
            this.comboBox_inter_techId = new System.Windows.Forms.ComboBox();
            this.interventionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.interventionsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_inter_techNom = new System.Windows.Forms.TextBox();
            this.techniciensBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.editionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource3)).BeginInit();
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
            this.editionGroupBox.Controls.Add(this.label1);
            this.editionGroupBox.Controls.Add(this.textBox_inter_techNom);
            this.editionGroupBox.Controls.Add(this.comboBox_inter_techId);
            this.editionGroupBox.Controls.Add(this.abandonnerButton);
            this.editionGroupBox.Controls.Add(this.validerButton);
            this.editionGroupBox.Controls.Add(this.label_com);
            this.editionGroupBox.Controls.Add(this.label_technicien);
            this.editionGroupBox.Controls.Add(this.label_date);
            this.editionGroupBox.Controls.Add(this.label_id);
            this.editionGroupBox.Controls.Add(this.textBox_inter_com);
            this.editionGroupBox.Controls.Add(this.textBox_inter_date);
            this.editionGroupBox.Controls.Add(this.textBox_inter_id);
            this.editionGroupBox.Location = new System.Drawing.Point(175, 44);
            this.editionGroupBox.Name = "editionGroupBox";
            this.editionGroupBox.Size = new System.Drawing.Size(591, 277);
            this.editionGroupBox.TabIndex = 8;
            this.editionGroupBox.TabStop = false;
            this.editionGroupBox.Text = "Edition";
            this.editionGroupBox.Enter += new System.EventHandler(this.editionGroupBox_Enter);
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
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Location = new System.Drawing.Point(27, 186);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(68, 13);
            this.label_com.TabIndex = 8;
            this.label_com.Text = "Commentaire";
            // 
            // label_technicien
            // 
            this.label_technicien.AutoSize = true;
            this.label_technicien.Location = new System.Drawing.Point(27, 117);
            this.label_technicien.Name = "label_technicien";
            this.label_technicien.Size = new System.Drawing.Size(85, 13);
            this.label_technicien.TabIndex = 7;
            this.label_technicien.Text = "ID du technicien";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(27, 77);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 6;
            this.label_date.Text = "Date";
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
            // textBox_inter_com
            // 
            this.textBox_inter_com.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventionsBindingSource, "inter_com", true));
            this.textBox_inter_com.Location = new System.Drawing.Point(137, 179);
            this.textBox_inter_com.Name = "textBox_inter_com";
            this.textBox_inter_com.Size = new System.Drawing.Size(282, 20);
            this.textBox_inter_com.TabIndex = 3;
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
            // techniciensBindingSource
            // 
            this.techniciensBindingSource.DataMember = "Techniciens";
            this.techniciensBindingSource.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // textBox_inter_date
            // 
            this.textBox_inter_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventionsBindingSource, "inter_date", true));
            this.textBox_inter_date.Location = new System.Drawing.Point(137, 74);
            this.textBox_inter_date.Name = "textBox_inter_date";
            this.textBox_inter_date.Size = new System.Drawing.Size(282, 20);
            this.textBox_inter_date.TabIndex = 1;
            // 
            // textBox_inter_id
            // 
            this.textBox_inter_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.interventionsBindingSource, "inter_id", true));
            this.textBox_inter_id.Location = new System.Drawing.Point(137, 41);
            this.textBox_inter_id.Name = "textBox_inter_id";
            this.textBox_inter_id.Size = new System.Drawing.Size(282, 20);
            this.textBox_inter_id.TabIndex = 0;
            // 
            // listBox_inter
            // 
            this.listBox_inter.DataSource = this.interventionsBindingSource1;
            this.listBox_inter.DisplayMember = "inter_date";
            this.listBox_inter.FormattingEnabled = true;
            this.listBox_inter.Location = new System.Drawing.Point(35, 44);
            this.listBox_inter.Name = "listBox_inter";
            this.listBox_inter.Size = new System.Drawing.Size(120, 277);
            this.listBox_inter.TabIndex = 7;
            this.listBox_inter.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // interventionsBindingSource1
            // 
            this.interventionsBindingSource1.DataMember = "Interventions";
            this.interventionsBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // interventionsTableAdapter
            // 
            this.interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // techniciensTableAdapter
            // 
            this.techniciensTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_inter_techId
            // 
            this.comboBox_inter_techId.DataSource = this.techniciensBindingSource3;
            this.comboBox_inter_techId.DisplayMember = "tech_id";
            this.comboBox_inter_techId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inter_techId.FormattingEnabled = true;
            this.comboBox_inter_techId.Location = new System.Drawing.Point(137, 109);
            this.comboBox_inter_techId.Name = "comboBox_inter_techId";
            this.comboBox_inter_techId.Size = new System.Drawing.Size(282, 21);
            this.comboBox_inter_techId.TabIndex = 11;
            // 
            // interventionsBindingSource2
            // 
            this.interventionsBindingSource2.DataMember = "Interventions";
            this.interventionsBindingSource2.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // techniciensBindingSource1
            // 
            this.techniciensBindingSource1.DataMember = "Techniciens";
            this.techniciensBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // interventionsBindingSource3
            // 
            this.interventionsBindingSource3.DataMember = "Interventions";
            this.interventionsBindingSource3.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom du technicien";
            // 
            // textBox_inter_techNom
            // 
            this.textBox_inter_techNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource2, "tech_nom", true));
            this.textBox_inter_techNom.Location = new System.Drawing.Point(137, 144);
            this.textBox_inter_techNom.Name = "textBox_inter_techNom";
            this.textBox_inter_techNom.Size = new System.Drawing.Size(282, 20);
            this.textBox_inter_techNom.TabIndex = 12;
            // 
            // techniciensBindingSource2
            // 
            this.techniciensBindingSource2.DataMember = "Techniciens";
            this.techniciensBindingSource2.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // techniciensBindingSource3
            // 
            this.techniciensBindingSource3.DataMember = "Techniciens";
            this.techniciensBindingSource3.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // GestionMatos_Interventions
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
            this.Controls.Add(this.listBox_inter);
            this.Name = "GestionMatos_Interventions";
            this.Text = "GESTION MATOS - Interventions";
            this.Load += new System.EventHandler(this.GestionMatos_Interventions_Load);
            this.editionGroupBox.ResumeLayout(false);
            this.editionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource3)).EndInit();
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
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.Label label_technicien;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_inter_com;
        private System.Windows.Forms.TextBox textBox_inter_date;
        private System.Windows.Forms.TextBox textBox_inter_id;
        private System.Windows.Forms.ListBox listBox_inter;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource interventionsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter interventionsTableAdapter;
        private System.Windows.Forms.BindingSource techniciensBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter techniciensTableAdapter;
        private System.Windows.Forms.BindingSource interventionsBindingSource1;
        private System.Windows.Forms.BindingSource techniciensBindingSource1;
        private System.Windows.Forms.BindingSource interventionsBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_inter_techNom;
        private System.Windows.Forms.BindingSource interventionsBindingSource3;
        private System.Windows.Forms.BindingSource techniciensBindingSource2;
        protected System.Windows.Forms.ComboBox comboBox_inter_techId;
        private System.Windows.Forms.BindingSource techniciensBindingSource3;
    }
}