using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class menu_opciones : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public menu_opciones()
        {
            InitializeComponent();
        }

        private void menu_opciones_Load(object sender, EventArgs e)
        {

        }

        private void database_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                opciones ventana = new opciones();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tipo_cambio_Click(object sender, EventArgs e)
        {
            tc ventana = new tc();
            ventana.Show();
        }

        private void account_Click(object sender, EventArgs e)
        {
            accounts ventana = new accounts();
            ventana.Show();
        }

        private void supply_Click(object sender, EventArgs e)
        {
            supply ventana = new supply();
            ventana.Show();
        }

        private void daf_Click(object sender, EventArgs e)
        {
            daf ventana = new daf();
            ventana.Show();
        }

        private void hotels_Click(object sender, EventArgs e)
        {
            hotel ventana = new hotel();
            ventana.Show();
        }

        private void close_con_Click(object sender, EventArgs e)
        {
            con.Close();
        }
    }
}
