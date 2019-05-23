using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_GestionMatos
{
    public partial class PPE3_Accueil : Form
    {
        public PPE3_Accueil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PPE3_Interventions interventions = new PPE3_Interventions();
            interventions.ShowDialog();
        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            PPE3_Clients clients = new PPE3_Clients();
            clients.ShowDialog();
        }

        private void button_deconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_materiels_Click(object sender, EventArgs e)
        {
            PPE3_Materiels materiels = new PPE3_Materiels();
            materiels.ShowDialog();
        }

        private void button_marques_Click(object sender, EventArgs e)
        {
            PPE3_Marques marques = new PPE3_Marques();
            marques.ShowDialog();
        }

        private void button_techniciens_Click(object sender, EventArgs e)
        {
            PPE3_Techniciens techniciens = new PPE3_Techniciens();
            techniciens.ShowDialog();
        }

        private void button_typeMatos_Click(object sender, EventArgs e)
        {
            PPE3_Types_Materiel types_Materiel = new PPE3_Types_Materiel();
            types_Materiel.ShowDialog();
        }

        private void PPE3_Accueil_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Techniciens'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.techniciensTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Techniciens);
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Interventions);
        }
    }
}
