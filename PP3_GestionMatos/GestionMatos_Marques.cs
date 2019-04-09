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

namespace PP3_GestionMatos
{
    public partial class GestionMatos_Marques : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PPE3_GestionMatos; Integrated Security = True;");
        protected string mode = "";
        

        private void ClearForm()
        {
            textBox_marque_id.Text = textBox_marque_nom.Text = "";
        }

        public GestionMatos_Marques()
        {
            InitializeComponent();
        }

        private void GestionMatos_Marques_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Marques'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.marquesTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Marques);
            textBox_marque_id.Enabled = false;
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Marques (marque_nom) VALUES(@marque_nom)", con);
                cmd.Parameters.AddWithValue("@marque_nom", textBox_marque_nom.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                MessageBox.Show("Ajouté");
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Techniciens SET tech_nom = @tech_nom, tech_tel=@tech_tel WHERE tech_id =" + textBox_marque_id.Text, con);
                cmd.Parameters.AddWithValue("@marque_nom", textBox_marque_nom.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modifié");
            }
        }

        private void abandonnerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            editionGroupBox.Enabled = true;
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            mode = "update";
            editionGroupBox.Enabled = true;
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Marqyes WHERE marque_id ='" + textBox_marque_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supprimé");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
