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

namespace PPE3_GestionMatos
{

    public partial class PPE3_Techniciens : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_tech_id.Text = textBox_tech_nom.Text = textBox_tech_tel.Text = "";
        }

        public PPE3_Techniciens()
        {
            InitializeComponent();
        }

        private void label_client_tel_Click(object sender, EventArgs e)
        {

        }

        private void PPE3_Techniciens_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Techniciens'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.techniciensTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Techniciens);
            groupBox_edition_tech.Enabled = false;
            textBox_tech_id.Enabled = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            groupBox_edition_tech.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Techniciens(tech_nom,tech_tel) VALUES(@tech_nom,@tech_tel)", con);
                cmd.Parameters.AddWithValue("@tech_nom", textBox_tech_nom.Text);
                cmd.Parameters.AddWithValue("@tech_tel", textBox_tech_tel.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Techniciens SET tech_nom = @tech_nom, tech_tel = @tech_tel WHERE tech_id=" + textBox_tech_id.Text, con);
                cmd.Parameters.AddWithValue("@tech_nom", textBox_tech_nom.Text);
                cmd.Parameters.AddWithValue("@tech _tel", textBox_tech_tel.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void button_abandonner_Click(object sender, EventArgs e)
        {
            groupBox_edition_tech.Enabled = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            groupBox_edition_tech.Enabled = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            mode = "update";
            groupBox_edition_tech.Enabled = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Techniciens WHERE tech_id = '" + textBox_tech_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
