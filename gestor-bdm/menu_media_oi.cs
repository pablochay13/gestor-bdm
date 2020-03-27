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
    public partial class menu_media_oi : MetroFramework.Forms.MetroForm
    {
        public menu_media_oi()
        {
            InitializeComponent();
        }

        private void menu_media_oi_Load(object sender, EventArgs e)
        {

        }

        private void oi_esp_Click(object sender, EventArgs e)
        {
            generador_OI ventana = new generador_OI();
            ventana.Show();
            //this.Close();
        }

        private void oi_en_Click(object sender, EventArgs e)
        {
            create_OI_en ventana = new create_OI_en();
            ventana.Show();
            //this.Close();
        }

        private void oi_modifica_Click(object sender, EventArgs e)
        {
            generador_oi_modificatoria ventana = new generador_oi_modificatoria();
            ventana.Show();
        }
    }
}
