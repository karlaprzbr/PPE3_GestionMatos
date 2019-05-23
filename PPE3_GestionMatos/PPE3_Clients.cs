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
    public partial class PPE3_Clients : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
        protected string mode = "";

        public PPE3_Clients()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            textBox_client_id.Text = textBox_client_nom.Text = textBox_client_adresse.Text = textBox_client_tel.Text = "";
        }

        private void PPE3_Clients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Clients);
            groupBox_edition_clients.Enabled = false;
            textBox_client_id.Enabled = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            groupBox_edition_clients.Enabled = false;
            if(mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Clients(client_nom,client_adresse,client_tel) VALUES(@client_nom,@client_adresse,@client_tel)", con);
                cmd.Parameters.AddWithValue("@client_nom", textBox_client_nom.Text);
                cmd.Parameters.AddWithValue("@client_adresse", textBox_client_adresse.Text);
                cmd.Parameters.AddWithValue("@client_tel", textBox_client_tel.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
            else if(mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Clients SET client_nom = @client_nom, client_adresse = @client_adresse, client_tel = @client_tel WHERE client_id=" + textBox_client_id.Text, con);
                cmd.Parameters.AddWithValue("@client_nom", textBox_client_nom.Text);
                cmd.Parameters.AddWithValue("@client_adresse", textBox_client_adresse.Text);
                cmd.Parameters.AddWithValue("@client_tel", textBox_client_tel.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void button_abandonner_Click(object sender, EventArgs e)
        {
            groupBox_edition_clients.Enabled = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            groupBox_edition_clients.Enabled = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            mode = "update";
            groupBox_edition_clients.Enabled = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if(supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Clients WHERE client_id = '" + textBox_client_id.Text + "'", con);
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
