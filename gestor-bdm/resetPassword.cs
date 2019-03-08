using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
        }

        private void recover_Click(object sender, EventArgs e)
        {
            try
            {
                if (tUser.Text == "")
                {
                    MessageBox.Show("Campo en blanco", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=bd-media;Uid=root;pwd=;");
                    con.Open();
                    string sql = "SELECT correo, password FROM usuarios WHERE usuario ='" + tUser.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string user = Convert.ToString(reader["correo"]);
                        string pass = Convert.ToString(reader["password"]);

                        Correos Cr = new Correos();
                        MailMessage mnsj = new MailMessage();

                        mnsj.Subject = "Contraseña acceso BDM";
                        mnsj.To.Add(new MailAddress(user));
                        mnsj.From = new MailAddress("pabloc.hay@outlook.com", "Sistema BestDay Media");
                        mnsj.Body = "Tu contraseña de acceso es: " + pass;

                        Cr.MandarCorreo(mnsj);

                        MessageBox.Show("Correo Enviado Correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
