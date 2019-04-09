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
            GestionMatos_Clients client = new GestionMatos_Clients();
            client.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionMateriel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = PPE3_GestionMatos; Integrated Security = True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM Gestionnaires WHERE gest_util='" +textBox_util.Text + "' AND gest_mdp='" +textBox_mdp.Text + "'", con);
            DataTable con_Result = new DataTable();
            sda.Fill(con_Result);
            if (con_Result.Rows[0][0].ToString()=="1")
            {
                GestionMatos_Home home = new GestionMatos_Home();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Merci de bien vouloir entrer un identifiant et un mot de passe valide.");
            }
        }
    }
}
