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
    public partial class PPE3_Interventions : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_inter_id.Text = textBox_inter_date.Text = textBox_inter_numero.Text = "";
        }

        public PPE3_Interventions()
        {
            InitializeComponent();
        }

        private void groupBox_edition_clients_Enter(object sender, EventArgs e)
        {

        }

        private void PPE3_Interventions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Clients);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Techniciens'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.techniciensTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Techniciens);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Materiels'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.materielsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Materiels);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Interventions);
            groupBox_edition_inter.Enabled = false;
            textBox_inter_id.Enabled = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox_inter_id_tech.SelectedText);
            groupBox_edition_inter.Enabled = false;
            /**if(comboBox_inter_id_tech.SelectedItem != null)
            {
                int id_tech = int.Parse(comboBox_inter_id_tech.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Renseignez l'ID d'un technicien.");
            }
            if(comboBox_inter_id_client.SelectedItem != null)
            {
                int id_client = int.Parse(comboBox_inter_id_client.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Renseignez l'ID d'un client.");
            }**/
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Interventions(inter_date,inter_numero,inter_tech,inter_client) VALUES(@inter_date,@inter_numero,@inter_tech,@inter_client)", con);
                cmd.Parameters.AddWithValue("@inter_date", textBox_inter_date.Text);
                cmd.Parameters.AddWithValue("@inter_numero", textBox_inter_numero.Text);
                cmd.Parameters.AddWithValue("@inter_tech", comboBox_inter_id_tech.SelectedValue);
                cmd.Parameters.AddWithValue("@inter_client", comboBox_inter_id_client.SelectedValue);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Interventions SET inter_date = @inter_date, inter_numero = @inter_numero, inter_tech = @inter_tech, inter_client = @inter_client WHERE inter_id=" + textBox_inter_id.Text, con);
                cmd.Parameters.AddWithValue("@inter_date", textBox_inter_date.Text);
                cmd.Parameters.AddWithValue("@inter_numero", textBox_inter_numero.Text);
                cmd.Parameters.AddWithValue("@inter_tech", comboBox_inter_id_tech.SelectedValue);
                cmd.Parameters.AddWithValue("@inter_client", comboBox_inter_id_client.SelectedValue);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void button_abandonner_Click(object sender, EventArgs e)
        {
            groupBox_edition_inter.Enabled = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            groupBox_edition_inter.Enabled = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            mode = "update";
            groupBox_edition_inter.Enabled = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Interventions WHERE inter_id = '" + textBox_inter_id.Text + "'", con);
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
