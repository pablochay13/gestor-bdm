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
    public partial class menu_oi : MetroFramework.Forms.MetroForm
    {
        public menu_oi()
        {
            InitializeComponent();
        }

        private void menu_oi_Load(object sender, EventArgs e)
        {

        }

        private void generar_Click(object sender, EventArgs e)
        {
            generador_OI ventana = new generador_OI();
            ventana.Show();

            this.Close();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            orden_insercion ventana = new orden_insercion();
            ventana.Show();

            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            create_OI_en ventana = new create_OI_en();
            ventana.Show();

            this.Close();
        }
    }
}
