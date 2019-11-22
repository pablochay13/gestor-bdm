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
    public partial class main : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        int last_id = 0;
        double tc_diario = 0;
        double tc_financiera = 0;
        DateTime fecha_hoy;
        public main()
        {
            InitializeComponent();

            try
            {
                con.Close();

                con.Open();
                string sql = "SELECT * FROM tc ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    last_id = Convert.ToInt32(reader["id"]);
                    tc_diario = Convert.ToDouble(reader["diario_oficial"]);
                    tc_financiera = Convert.ToDouble(reader["planeacion_financiera"]);
                    fecha_hoy = Convert.ToDateTime(reader["fecha"]);
                }


                DateTime todaysDate = DateTime.Now.Date;
                int year = todaysDate.Year;
                int month = todaysDate.Month;
                int day = todaysDate.Day;

                int year_d = fecha_hoy.Date.Year;
                int month_d = fecha_hoy.Date.Month;
                int day_d = fecha_hoy.Date.Day;

                //MessageBox.Show(Convert.ToString(year_d));
                //MessageBox.Show(Convert.ToString(year));

                if (month == month_d)
                {
                    
                }

                if (year == year_d && month == month_d && day == day_d)
                {
                    MessageBox.Show("TC del día registrado", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    tc_registro ventana = new tc_registro();
                    ventana.MdiParent = this;
                    ventana.Show();
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void landingsBaseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            landings ventana = new landings();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes_tabla ventana = new clientes_tabla();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medios ventana = new medios();
            ventana.MdiParent = this;
            ventana.Show();

            //medios frm = new medios();
            //frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(general.Privilegios == "admin")
            {
                usuarios ventana = new usuarios();
                ventana.MdiParent = this;
                ventana.Show();
            }
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generadorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generador ventana = new generador();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void exampleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                opciones ventana = new opciones();
                ventana.MdiParent = this;
                ventana.Show();
            }
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void saldosEdiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OI ventana = new OI();
            //ventana.MdiParent = this;
            //ventana.Show();
            //saldos_media ventana = new saldos_media();
            //ventana.MdiParent = this;
            //ventana.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //consulta TC existente
            
        }

        private void accountsManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accounts ventana = new accounts();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void supplyManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supply ventana = new supply();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void ejecutivosDAFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daf ventana = new daf();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tc ventana = new tc();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void siglasHotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotel ventana = new hotel();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void cerrarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Close();
        }

        private void DashComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dash_comercial ventana = new dash_comercial();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void BaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OI ventana = new OI();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void GeneradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generador_OI ventana = new generador_OI();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
