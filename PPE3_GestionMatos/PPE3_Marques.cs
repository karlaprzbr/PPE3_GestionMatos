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
    public partial class PPE3_Marques : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_marque_id.Text = textBox_marque_nom.Text = "";
        }

        public PPE3_Marques()
        {
            InitializeComponent();
        }

        private void groupBox_edition_clients_Enter(object sender, EventArgs e)
        {

        }

        private void PPE3_Marques_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Marques'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.marquesTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Marques);
            groupBox_edition_marque.Enabled = false;
            textBox_marque_id.Enabled = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            groupBox_edition_marque.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Marques(marque_nom) VALUES(@marque_nom)", con);
                cmd.Parameters.AddWithValue("@marque_nom", textBox_marque_nom.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Marques SET marque_nom = @marque_nom WHERE marque_id=" + textBox_marque_id.Text, con);
                cmd.Parameters.AddWithValue("@client_nom", textBox_marque_nom.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void button_abandonner_Click(object sender, EventArgs e)
        {
            groupBox_edition_marque.Enabled = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            groupBox_edition_marque.Enabled = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            mode = "update";
            groupBox_edition_marque.Enabled = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Marques WHERE marque_id = '" + textBox_marque_id.Text + "'", con);
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
