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
    public partial class principal : MetroFramework.Forms.MetroForm
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void oi_btn_Click(object sender, EventArgs e)
        {
            menu_oi ventana = new menu_oi();
            ventana.Show();
        }

        private void clientes_btn_Click(object sender, EventArgs e)
        {
            clientes ventana = new clientes();
            ventana.Show();
        }

        private void medios_btn_Click(object sender, EventArgs e)
        {
            medios_media ventana = new medios_media();
            ventana.Show();
        }

        private void comercial_btn_Click(object sender, EventArgs e)
        {
            dash_comercial_media ventana = new dash_comercial_media();
            ventana.Show();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            usuarios ventana = new usuarios();
            ventana.Show();
        }

        private void opciones_btn_Click(object sender, EventArgs e)
        {
            menu_opciones ventana = new menu_opciones();
            ventana.Show();
        }
    }
}
