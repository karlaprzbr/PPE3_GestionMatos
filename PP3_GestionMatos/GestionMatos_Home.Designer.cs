namespace PP3_GestionMatos
{
    partial class GestionMatos_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMatos_Home));
            this.nextInter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.interDates = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tech = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pPE3_GestionMatosDataSet = new PP3_GestionMatos.PPE3_GestionMatosDataSet();
            this.interventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interventionsTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter();
            this.interventionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciensTableAdapter = new PP3_GestionMatos.PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter();
            this.nextInter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nextInter
            // 
            this.nextInter.Controls.Add(this.button4);
            this.nextInter.Controls.Add(this.button1);
            this.nextInter.Controls.Add(this.textBox_tech);
            this.nextInter.Controls.Add(this.label3);
            this.nextInter.Controls.Add(this.interDates);
            this.nextInter.Controls.Add(this.label1);
            resources.ApplyResources(this.nextInter, "nextInter");
            this.nextInter.Name = "nextInter";
            this.nextInter.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // interDates
            // 
            this.interDates.DataSource = this.interventionsBindingSource1;
            this.interDates.DisplayMember = "inter_date";
            this.interDates.FormattingEnabled = true;
            resources.ApplyResources(this.interDates, "interDates");
            this.interDates.Name = "interDates";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox_tech
            // 
            this.textBox_tech.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciensBindingSource, "tech_nom", true));
            resources.ApplyResources(this.textBox_tech, "textBox_tech");
            this.textBox_tech.Name = "textBox_tech";
            this.textBox_tech.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            // interventionsBindingSource1
            // 
            this.interventionsBindingSource1.DataMember = "Interventions";
            this.interventionsBindingSource1.DataSource = this.pPE3_GestionMatosDataSet;
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
            // GestionMatos_Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextInter);
            this.Name = "GestionMatos_Home";
            this.Load += new System.EventHandler(this.GestionMatos_Home_Load);
            this.nextInter.ResumeLayout(false);
            this.nextInter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciensBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox nextInter;
        private System.Windows.Forms.TextBox textBox_tech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox interDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private PPE3_GestionMatosDataSet pPE3_GestionMatosDataSet;
        private System.Windows.Forms.BindingSource interventionsBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.InterventionsTableAdapter interventionsTableAdapter;
        private System.Windows.Forms.BindingSource interventionsBindingSource1;
        private System.Windows.Forms.BindingSource techniciensBindingSource;
        private PPE3_GestionMatosDataSetTableAdapters.TechniciensTableAdapter techniciensTableAdapter;
    }
}