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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPE3_GestionMatosDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.pPE3_GestionMatosDataSet.Clients);
            editionGroupBox.Enabled = false;
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = true;
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = true;
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
        }

        private void abandonnerButton_Click(object sender, EventArgs e)
        {
            editionGroupBox.Enabled = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
