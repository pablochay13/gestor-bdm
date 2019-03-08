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
    public partial class tc : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public tc()
        {
            InitializeComponent();

            try
            {
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string date = fecha.Value.ToString("yyyy-MM-dd");

                string sql = "SELECT * FROM `tc` WHERE fecha = '" + date + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int Ids = Convert.ToInt32(reader["id"]);
                    string diario = Convert.ToString(reader["diario_oficial"]);
                    string finan = Convert.ToString(reader["planeacion_financiera"]);
                    string fechas = Convert.ToString(reader["fecha"]);

                    //id.Text = Convert.ToString(Ids);
                    tcDiario.Text = diario;
                    tcPlaneacion.Text = finan;
                    fecha.Text = fechas;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (tcDiario.Text == "" && tcPlaneacion.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string date = fecha.Value.ToString("yyyy-MM-dd");

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE `tc` SET `diario_oficial`='" + tcDiario.Text + "',`planeacion_financiera`='" + tcPlaneacion.Text + "',`fecha`='" + date + "' WHERE fecha = '" + date + "'", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    con.Close();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
