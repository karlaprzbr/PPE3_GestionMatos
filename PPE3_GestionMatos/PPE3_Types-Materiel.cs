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
    public partial class PPE3_Types_Materiel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
        protected string mode = "";

        private void ClearForm()
        {
            textBox_typeMater_id.Text = textBox_typeMater_type.Text = "";
        }

        public PPE3_Types_Materiel()
        {
            InitializeComponent();
        }

        private void PPE3_Types_Materiel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Types_Materiel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.types_MaterielTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Types_Materiel);
            groupBox_edition_typeMater.Enabled = false;
            textBox_typeMater_id.Enabled = false;
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            groupBox_edition_typeMater.Enabled = false;
            if (mode == "add")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Types_Materiel(type_nom) VALUES(@type_nom)", con);
                cmd.Parameters.AddWithValue("@type_nom", textBox_typeMater_type.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
            else if (mode == "update")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Types_Materiel SET type_nom = @type_nom WHERE type_id=" + textBox_typeMater_id.Text, con);
                cmd.Parameters.AddWithValue("@type_nom", textBox_typeMater_type.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void button_abandonner_Click(object sender, EventArgs e)
        {
            groupBox_edition_typeMater.Enabled = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            mode = "add";
            ClearForm();
            groupBox_edition_typeMater.Enabled = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            mode = "update";
            groupBox_edition_typeMater.Enabled = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Attention", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Types_Materiel WHERE type_id = '" + textBox_typeMater_id.Text + "'", con);
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
