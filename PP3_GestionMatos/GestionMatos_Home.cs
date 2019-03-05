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
    public partial class GestionMateriel : Form
    {
        public GestionMateriel()
        {
            InitializeComponent();
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.ShowDialog();
        }
    }
}
