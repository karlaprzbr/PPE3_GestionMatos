using System;
using System.Windows.Forms;

namespace PP3_GestionMatos
{
    partial class GestionMatos_Clients
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
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PP3_GestionMatos.PPE3_GestionMatosDataSet();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editionGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_abandonner = new System.Windows.Forms.Button();
            this.button_valider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_client_mail = new System.Windows.Forms.TextBox();
            this.textBox_client_tel = new System.Windows.Forms.TextBox();
            this.textBox_client_adresse = new System.Windows.Forms.TextBox();
            this.textBox_client_nom = new System.Windows.Forms.TextBox();
            this.textBox_client_id = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.types_MaterielTableAdapter1 = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.Types_MaterielTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.editionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_clients
            // 
            this.listBox_clients.DataSource = this.clientsBindingSource;
            this.listBox_clients.DisplayMember = "client_nom";
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.Location = new System.Drawing.Point(34, 55);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(120, 277);
            this.listBox_clients.TabIndex = 0;
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
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
            // 
            // editionGroupBox
            // 
            this.editionGroupBox.Controls.Add(this.pictureBox_logo);
            this.editionGroupBox.Controls.Add(this.button_abandonner);
            this.editionGroupBox.Controls.Add(this.button_valider);
            this.editionGroupBox.Controls.Add(this.label5);
            this.editionGroupBox.Controls.Add(this.tel);
            this.editionGroupBox.Controls.Add(this.Adresse);
            this.editionGroupBox.Controls.Add(this.label2);
            this.editionGroupBox.Controls.Add(this.label1);
            this.editionGroupBox.Controls.Add(this.textBox_client_mail);
            this.editionGroupBox.Controls.Add(this.textBox_client_tel);
            this.editionGroupBox.Controls.Add(this.textBox_client_adresse);
            this.editionGroupBox.Controls.Add(this.textBox_client_nom);
            this.editionGroupBox.Controls.Add(this.textBox_client_id);
            this.editionGroupBox.Location = new System.Drawing.Point(174, 55);
            this.editionGroupBox.Name = "editionGroupBox";
            this.editionGroupBox.Size = new System.Drawing.Size(591, 277);
            this.editionGroupBox.TabIndex = 1;
            this.editionGroupBox.TabStop = false;
            this.editionGroupBox.Text = "Edition";
            this.editionGroupBox.Enter += new System.EventHandler(this.editionGroupBox_Enter);
            this.editionGroupBox.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.groupBox1_Enter);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Location = new System.Drawing.Point(480, 41);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 11;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_abandonner
            // 
            this.button_abandonner.Location = new System.Drawing.Point(475, 188);
            this.button_abandonner.Name = "button_abandonner";
            this.button_abandonner.Size = new System.Drawing.Size(75, 23);
            this.button_abandonner.TabIndex = 2;
            this.button_abandonner.Text = "Abandonner";
            this.button_abandonner.UseVisualStyleBackColor = true;
            this.button_abandonner.Click += new System.EventHandler(this.abandonnerButton_Click);
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(475, 137);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 10;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mail";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(27, 156);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(58, 13);
            this.tel.TabIndex = 8;
            this.tel.Text = "Télephone";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(27, 117);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(45, 13);
            this.Adresse.TabIndex = 7;
            this.Adresse.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // textBox_client_mail
            // 
            this.textBox_client_mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_mail", true));
            this.textBox_client_mail.Location = new System.Drawing.Point(117, 186);
            this.textBox_client_mail.Name = "textBox_client_mail";
            this.textBox_client_mail.Size = new System.Drawing.Size(302, 20);
            this.textBox_client_mail.TabIndex = 4;
            // 
            // textBox_client_tel
            // 
            this.textBox_client_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_tel", true));
            this.textBox_client_tel.Location = new System.Drawing.Point(117, 149);
            this.textBox_client_tel.Name = "textBox_client_tel";
            this.textBox_client_tel.Size = new System.Drawing.Size(302, 20);
            this.textBox_client_tel.TabIndex = 3;
            // 
            // textBox_client_adresse
            // 
            this.textBox_client_adresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_adresse", true));
            this.textBox_client_adresse.Location = new System.Drawing.Point(117, 110);
            this.textBox_client_adresse.Name = "textBox_client_adresse";
            this.textBox_client_adresse.Size = new System.Drawing.Size(302, 20);
            this.textBox_client_adresse.TabIndex = 2;
            // 
            // textBox_client_nom
            // 
            this.textBox_client_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_nom", true));
            this.textBox_client_nom.Location = new System.Drawing.Point(117, 74);
            this.textBox_client_nom.Name = "textBox_client_nom";
            this.textBox_client_nom.Size = new System.Drawing.Size(302, 20);
            this.textBox_client_nom.TabIndex = 1;
            // 
            // textBox_client_id
            // 
            this.textBox_client_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_id", true));
            this.textBox_client_id.Location = new System.Drawing.Point(117, 41);
            this.textBox_client_id.Name = "textBox_client_id";
            this.textBox_client_id.Size = new System.Drawing.Size(302, 20);
            this.textBox_client_id.TabIndex = 0;
            this.textBox_client_id.TextChanged += new System.EventHandler(this.textBox_client_id_TextChanged);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(260, 394);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 2;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(358, 394);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 3;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(475, 394);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 4;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.supprimerButton_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(578, 394);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(690, 394);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 6;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button7_Click);
            // 
            // types_MaterielTableAdapter1
            // 
            this.types_MaterielTableAdapter1.ClearBeforeFill = true;
            // 
            // GestionMatos_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.editionGroupBox);
            this.Controls.Add(this.listBox_clients);
            this.Name = "GestionMatos_Clients";
            this.Text = "GESTION MATOS - Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.editionGroupBox.ResumeLayout(false);
            this.editionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, UICuesEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editionGroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ListBox listBox_clients;
        private System.Windows.Forms.GroupBox editionGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_client_mail;
        private System.Windows.Forms.TextBox textBox_client_tel;
        private System.Windows.Forms.TextBox textBox_client_adresse;
        private System.Windows.Forms.TextBox textBox_client_nom;
        private System.Windows.Forms.TextBox textBox_client_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label Adresse;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.Button button_abandonner;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_annuler;
        private PictureBox pictureBox_logo;
        private PPE3_GestionMatosDataSetTableAdapters.Types_MaterielTableAdapter types_MaterielTableAdapter1;
    }
}