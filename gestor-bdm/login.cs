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
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        //MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=root;Uid=rootPwd=");
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE usuario='" + user.Text + "'AND password='" + password.Text + "' ", con);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                MessageBox.Show("Bienvenido " + user.Text + "!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Information);
                general.usuario = user.Text;
                general.Privilegios = Convert.ToString(leer["privilegios"]);
                this.Hide();

                main ss = new main();
                ss.Show();

                con.Close();
            }
            else
            {
                MessageBox.Show("Error!\n user y/o Contraseña invalido!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registro frm = new registro();
            frm.Show();
            this.Hide();
        }

        private void reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetPassword frm = new resetPassword();
            frm.Show();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
