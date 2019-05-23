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

    public partial class PPE3_Login : Form
    {
        public PPE3_Login()
        {
            InitializeComponent();
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PPE3_GestionMatos;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) from Gestionnaires WHERE gest_util='" + textBox_gest_util.Text + "' AND gest_mdp = '" + textBox_gest_mdp.Text + "'", con);
            DataTable con_result = new DataTable();
            sda.Fill(con_result);
            if(con_result.Rows[0][0].ToString()=="1")
            {
                PPE3_Accueil accueil = new PPE3_Accueil();
                accueil.ShowDialog();
            }
            else
            {
                MessageBox.Show("Merci de bien vouloir entrer un identifiant et un mot de passe valide.");
            }
        }

        private void PPE3_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
