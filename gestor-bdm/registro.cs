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
    public partial class registro : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        public registro()
        {
            InitializeComponent();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            if (tNombre.Text == "" && tUsuario.Text == "" && tPassword.Text == "" && tPasswordR.Text == "" && tCorreo.Text == "" && tPrivilegios.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string pass = tPassword.Text;
                    string passr = tPasswordR.Text;

                    if(pass == passr)
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (`nombre`, `usuario`, `password`, `correo`, `privilegios`) VALUES ('" + tNombre.Text + "','" + tUsuario.Text + "','" + tPasswordR.Text + "','" + tCorreo.Text + "','" + tPrivilegios.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();

                        tUsuario.Text = "";
                        tNombre.Text = "";
                        tPassword.Text = "";
                        tPasswordR.Text = "";
                        tPrivilegios.Text = "";
                        tCorreo.Text = "";

                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas no coinciden!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
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
