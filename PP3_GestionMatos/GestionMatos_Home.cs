using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP3_GestionMatos
{
    public partial class GestionMatos_Home : Form
    {
        public GestionMatos_Home()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionMatos_Clients clients = new GestionMatos_Clients();
            clients.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionMatos_Interventions inter = new GestionMatos_Interventions();
            inter.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionMatos_Techniciens tech = new GestionMatos_Techniciens();
            tech.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestionMatos_Sites sites = new GestionMatos_Sites();
            sites.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GestionMatos_Materiels materiels = new GestionMatos_Materiels();
            materiels.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GestionMatos_Marques marques = new GestionMatos_Marques();
            marques.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GestionMatos_Types_Materiel typesMatos = new GestionMatos_Types_Materiel();
            typesMatos.ShowDialog();
        }

        private void GestionMatos_Home_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Techniciens'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.techniciensTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Techniciens);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Interventions);
            textBox_tech.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
