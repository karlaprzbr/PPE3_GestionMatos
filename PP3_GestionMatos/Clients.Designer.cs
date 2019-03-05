using System;
using System.Windows.Forms;

namespace PP3_GestionMatos
{
    partial class Clients
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GestionMatosDataSet = new PP3_GestionMatos.PPE3_GestionMatosDataSet();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editionGroupBox = new System.Windows.Forms.GroupBox();
            this.abandonnerButton = new System.Windows.Forms.Button();
            this.validerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.supprimerButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.editionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.clientsBindingSource;
            this.listBox1.DisplayMember = "client_nom";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 277);
            this.listBox1.TabIndex = 0;
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
            this.editionGroupBox.Controls.Add(this.abandonnerButton);
            this.editionGroupBox.Controls.Add(this.validerButton);
            this.editionGroupBox.Controls.Add(this.label5);
            this.editionGroupBox.Controls.Add(this.tel);
            this.editionGroupBox.Controls.Add(this.Adresse);
            this.editionGroupBox.Controls.Add(this.label2);
            this.editionGroupBox.Controls.Add(this.label1);
            this.editionGroupBox.Controls.Add(this.textBox5);
            this.editionGroupBox.Controls.Add(this.textBox4);
            this.editionGroupBox.Controls.Add(this.textBox3);
            this.editionGroupBox.Controls.Add(this.textBox2);
            this.editionGroupBox.Controls.Add(this.textBox1);
            this.editionGroupBox.Location = new System.Drawing.Point(174, 55);
            this.editionGroupBox.Name = "editionGroupBox";
            this.editionGroupBox.Size = new System.Drawing.Size(591, 277);
            this.editionGroupBox.TabIndex = 1;
            this.editionGroupBox.TabStop = false;
            this.editionGroupBox.Text = "Edition";
            this.editionGroupBox.Enter += new System.EventHandler(this.editionGroupBox_Enter);
            this.editionGroupBox.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.groupBox1_Enter);
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
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_mail", true));
            this.textBox5.Location = new System.Drawing.Point(117, 186);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(302, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_tel", true));
            this.textBox4.Location = new System.Drawing.Point(117, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(302, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_adresse", true));
            this.textBox3.Location = new System.Drawing.Point(117, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_nom", true));
            this.textBox2.Location = new System.Drawing.Point(117, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_id", true));
            this.textBox1.Location = new System.Drawing.Point(117, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 0;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ajouterButton
            // 
            this.ajouterButton.Location = new System.Drawing.Point(260, 394);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(75, 23);
            this.ajouterButton.TabIndex = 2;
            this.ajouterButton.Text = "Ajouter";
            this.ajouterButton.UseVisualStyleBackColor = true;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(358, 394);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(75, 23);
            this.modifierButton.TabIndex = 3;
            this.modifierButton.Text = "Modifier";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // supprimerButton
            // 
            this.supprimerButton.Location = new System.Drawing.Point(475, 394);
            this.supprimerButton.Name = "supprimerButton";
            this.supprimerButton.Size = new System.Drawing.Size(75, 23);
            this.supprimerButton.TabIndex = 4;
            this.supprimerButton.Text = "Supprimer";
            this.supprimerButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(578, 394);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(690, 394);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 6;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // Clients
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
            this.Controls.Add(this.listBox1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.editionGroupBox.ResumeLayout(false);
            this.editionGroupBox.PerformLayout();
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

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox editionGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label Adresse;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.Button abandonnerButton;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.Button supprimerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button annulerButton;
    }
}