using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace PP3_GestionMatos
{
    public partial class GestionMatos_Techniciens : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PPE3_GestionMatos; Integrated Security = True;");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_id.Text = textBox_nom.Text = textBox_tel.Text = "";
        }

        public GestionMatos_Techniciens()
        {
            InitializeComponent();
        }

        private void GestionMatos_Techniciens_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Techniciens'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.techniciensTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Techniciens);
            editionGroupBox.Enabled = false;
            textBox_id.Enabled = false;
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            mode = "update";
            editionGroupBox.Enabled = true;
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Techniciens(tech_nom,tech_tel) VALUES(@tech_nom,@tech_tel)", con);
                cmd.Parameters.AddWithValue("@tech_nom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@tech_tel", textBox_tel.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                MessageBox.Show("Ajouté");
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Techniciens SET tech_nom = @tech_nom, tech_tel=@tech_tel WHERE tech_id ="+textBox_id.Text, con);
                cmd.Parameters.AddWithValue("@tech_nom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@tech_tel", textBox_tel.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modifié");
            }
            
        }

        private void abandonnerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            editionGroupBox.Enabled = true;
            
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes )
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Techniciens WHERE tech_id ='" + textBox_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supprimé");
            }
            
            
        }
    }
}
