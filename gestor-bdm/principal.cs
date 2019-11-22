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
            orden_insercion ventana = new orden_insercion();
            ventana.Show();
        }
    }
}
