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
using System.Configuration;
using System.Web;
using PP3_GestionMatos.Helpers;
using System.Data.OleDb;

namespace PP3_GestionMatos
{
    

    public partial class GestionMatos_Clients : Form
    {
  
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PPE3_GestionMatos; Integrated Security = True;");
        protected string mode = "";

        public GestionMatos_Clients()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            textBox_client_id.Text = textBox_client_nom.Text = textBox_client_adresse.Text = textBox_client_tel.Text = textBox_client_mail.Text =  "";
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Clients);
            editionGroupBox.Enabled = false;
            textBox_client_id.Enabled = false;
            if (textBox_client_nom.Text == "Orange")
            {
                pictureBox_logo.Load("../../img/orange.png");
            }
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

        private void validerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Clients(client_nom,client_adresse,client_tel,client_mail) VALUES(@client_nom,@client_adresse,@client_tel,@client_mail)", con);
                cmd.Parameters.AddWithValue("@client_nom", textBox_client_nom.Text);
                cmd.Parameters.AddWithValue("@client_adresse", textBox_client_adresse.Text);
                cmd.Parameters.AddWithValue("@client_tel", textBox_client_tel.Text);
                cmd.Parameters.AddWithValue("@client_mail", textBox_client_mail.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                MessageBox.Show("Ajouté");
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CLients SET client_nom = @client_nom, client_adresse = @client_adresse, client_tel = @client_tel, client_mail = @client_mail WHERE client_id =" + textBox_client_id.Text, con);
                cmd.Parameters.AddWithValue("@tech_nom", textBox_client_nom.Text);
                cmd.Parameters.AddWithValue("@client_adresse", textBox_client_adresse.Text);
                cmd.Parameters.AddWithValue("@client_tel", textBox_client_tel.Text);
                cmd.Parameters.AddWithValue("@client_mail", textBox_client_mail.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Clients WHERE client_id ='" + textBox_client_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supprimé");
            }
        }

        private void textBox_client_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
