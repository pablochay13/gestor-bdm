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
    public partial class tc_registro : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public tc_registro()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (tcDiario.Text == "" && tcPlaneacion.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();

                    string date = fecha.Value.ToString("yyyy-MM-dd"); ;

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO tc (`diario_oficial` , `planeacion_financiera` , `fecha`) VALUES ('" + tcDiario.Text + "','" + tcPlaneacion.Text + "','" + date + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    this.Close();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void tc_registro_Load(object sender, EventArgs e)
        {
            //textoInicio.Text = "Fecha de hoy:" + " " + DateTime.Now;
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
