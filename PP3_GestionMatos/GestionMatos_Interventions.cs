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
    public partial class GestionMatos_Interventions : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PPE3_GestionMatos; Integrated Security = True;");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_inter_id.Text = textBox_inter_date.Text = textBox_inter_com.Text = textBox_inter_techNom.Text = "";
        }

        public GestionMatos_Interventions()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Interventions WHERE inter_id ='" + textBox_inter_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supprimé");
            }
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            mode = "update";
            editionGroupBox.Enabled = true;
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            editionGroupBox.Enabled = true;
        }

        private void editionGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionMatos_Interventions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Techniciens'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.techniciensTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Techniciens);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Interventions);
            editionGroupBox.Enabled = false;
            textBox_inter_id.Enabled = false;
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Interventions(inter_date,inter_com,inter_tech) VALUES(@inter_date,@inter_com,@inter_tech)", con);
                cmd.Parameters.AddWithValue("@inter_date", textBox_inter_date.Text);
                cmd.Parameters.AddWithValue("@inter_com", textBox_inter_com.Text);
                cmd.Parameters.AddWithValue("@inter_tech", comboBox_inter_techId.SelectedItem);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                MessageBox.Show("Ajouté");
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Interventions SET inter_date = @inter_date, inter_com = @inter_com, inter_tech = @inter_tech WHERE inter_id =" + textBox_inter_id.Text, con);
                cmd.Parameters.AddWithValue("@inter_date", textBox_inter_date.Text);
                cmd.Parameters.AddWithValue("@inter_com", textBox_inter_com.Text);
                cmd.Parameters.AddWithValue("@inter_tech", comboBox_inter_techId.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Modifié");
            }
        }

        private void abandonnerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
        }

        private void checkedListBox_inter_tech_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
