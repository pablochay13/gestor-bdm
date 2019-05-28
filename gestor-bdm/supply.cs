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
    public partial class supply : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public supply()
        {
            InitializeComponent();
            account();
            pais();
        }

        public void account()
        {
            try
            {
                string selectQuery = "select * from supply_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboSupply.ValueMember = "id";
                comboSupply.DisplayMember = "nombre";
                comboSupply.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pais()
        {
            try
            {
                string selectQuery = "select id, region from paises";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboPais.ValueMember = "id";
                comboPais.DisplayMember = "region";
                comboPais.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboSupply.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT * FROM `supply_manager` WHERE nombre = '" + comboSupply.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int Ids = Convert.ToInt32(reader["id"]);
                    string nombreAccount = Convert.ToString(reader["nombre"]);
                    string t_area = Convert.ToString(reader["region"]);
                    string t_correo = Convert.ToString(reader["correo"]);

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

        private void add_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                if (name.Text == "" && area.Text == "" && mail.Text == "")
                {
                    MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        con.Open();

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO supply_manager (`nombre` , `region` , `correo`) VALUES ('" + name.Text + "','" + comboPais.Text + "','" + mail.Text + "' )", con);
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
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `supply_manager` SET `nombre`='" + name.Text + "',`region`='" + comboPais.Text + "',`correo`='" + mail.Text + "' WHERE id = '" + id.Text + "'", con);
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `supply_manager` WHERE id ='" + id.Text + "'", con);
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

        private void Supply_Load(object sender, EventArgs e)
        {

        }
    }
}
