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
    public partial class PPE3_Materiels : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_mat_id.Text = textBox_mat_nom.Text = textBox_mat_numSer.Text = textBox_mat_mtbf.Text = textBox_mat_dateInstall.Text = "";
        }

        public PPE3_Materiels()
        {
            InitializeComponent();
        }

        private void PPE3_Materiels_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Interventions);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Clients);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Marques'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.marquesTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Marques);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Types_Materiel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.types_MaterielTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Types_Materiel);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Materiels'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.materielsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Materiels);
            groupBox_edition_mater.Enabled = false;
            textBox_mat_id.Enabled = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            groupBox_edition_mater.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Materiels(mater_nom,mater_num_ser,mater_MTBF,mater_date_install,mater_client,mater_marque,mater_type,mater_inter) VALUES(@mater_nom,@mater_num_ser,@mater_MTBF,@mater_date_install,@mater_client,@mater_marque,@mater_type,@mater_inter)", con);
                cmd.Parameters.AddWithValue("@mater_nom", textBox_mat_nom.Text);
                cmd.Parameters.AddWithValue("@mater_num_ser", textBox_mat_numSer.Text);
                cmd.Parameters.AddWithValue("@mater_MTBF", textBox_mat_mtbf.Text);
                cmd.Parameters.AddWithValue("@mater_date_install", textBox_mat_dateInstall.Text);
                cmd.Parameters.AddWithValue("@mater_client", comboBox_mat_client.SelectedValue);
                cmd.Parameters.AddWithValue("@mater_marque", comboBox_mat_marque.SelectedValue);
                cmd.Parameters.AddWithValue("@mater_type", comboBox_mat_type.SelectedValue);
                cmd.Parameters.AddWithValue("@mater_inter", comboBox_mat_inter.SelectedValue);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Materiels SET mater_nom = @mater_nom, mater_num_ser = @mater_num_ser, mater_MTBF = @mater_MTBF, mater_date_install = @mater_date_install, mater_client = @mater_client, mater_marque = @mater_marque, mater_type = @mater_type, mater_inter = @mater_inter WHERE mater_id=" + textBox_mat_id.Text, con);
                cmd.Parameters.AddWithValue("@mater_nom", textBox_mat_nom.Text);
                cmd.Parameters.AddWithValue("@mater_num_ser", textBox_mat_numSer.Text);
                cmd.Parameters.AddWithValue("@mater_MTBF", textBox_mat_mtbf.Text);
                cmd.Parameters.AddWithValue("@mater_date_install", textBox_mat_dateInstall.Text);
                cmd.Parameters.AddWithValue("@mater_client", comboBox_mat_client.SelectedValue);
                cmd.Parameters.AddWithValue("@mater_marque", comboBox_mat_marque.SelectedValue);
                cmd.Parameters.AddWithValue("@mater_type", comboBox_mat_type.SelectedValue);
                cmd.Parameters.AddWithValue("@mater_inter", comboBox_mat_inter.SelectedValue);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void button_abandonner_Click(object sender, EventArgs e)
        {
            groupBox_edition_mater.Enabled = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            groupBox_edition_mater.Enabled = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            mode = "update";
            groupBox_edition_mater.Enabled = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Materiels WHERE client_id = '" + textBox_mat_id.Text + "'", con);
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
