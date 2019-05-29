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
    public partial class accounts : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        public accounts()
        {
            InitializeComponent();
            comboStatus.SelectedIndex = 0;
            account();
        }

        private void comboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboAccounts.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT * FROM `account_manager` WHERE nombre = '" + comboAccounts.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int Ids = Convert.ToInt32(reader["id"]);
                    string nombreAccount = Convert.ToString(reader["nombre"]);
                    string t_area = Convert.ToString(reader["area"]);
                    string t_correo = Convert.ToString(reader["correo"]);
                    string t_status = Convert.ToString(reader["status"]);

                    if(t_status == "Activo")
                    {
                        comboStatus.SelectedIndex = 0;
                    }
                    else if (t_status == "Inactivo")
                    {
                        comboStatus.SelectedIndex = 1;
                    }

                    id.Text = Convert.ToString(Ids);
                    name.Text = nombreAccount;
                    area.Text = t_area;
                    mail.Text = t_correo;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void account()
        {
            try
            {
                string selectQuery = "select * from account_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboAccounts.ValueMember = "id";
                comboAccounts.DisplayMember = "nombre";
                comboAccounts.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                if (name.Text == "" && area.Text == "" && mail.Text == "" )
                {
                    MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        con.Open();

                        string valor = "";

                        if (comboStatus.SelectedIndex== 0)
                        {
                            valor = "Activo";
                        }
                        else
                        {
                            valor = "Inactivo";
                        }

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO account_manager (`nombre` , `area` , `correo` , `status`) VALUES ('" + name.Text + "','" + area.Text + "','" + mail.Text + "','" + valor + "' )", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();

                        name.Text = "";
                        area.Text = "";
                        mail.Text = "";
                    }
                    catch (Exception m)
                    {
                        MessageBox.Show(m.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (name.Text == "" && area.Text == "" && mail.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string valor = "";

                    if (comboStatus.SelectedIndex == 0)
                    {
                        valor = "Activo";
                    }
                    else
                    {
                        valor = "Inactivo";
                    }

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `account_manager` SET `nombre`='" + name.Text + "',`area`='" + area.Text + "',`correo`='" + mail.Text + "',`status`='" + valor + "' WHERE id = '" + id.Text + "'", con);
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                //code
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `account_manager` WHERE id ='" + id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    name.Text = "";
                    area.Text = "";
                    mail.Text = "";
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
