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
    public partial class hotel : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public hotel()
        {
            InitializeComponent();
            hoteles();
        }

        public void hoteles()
        {
            try
            {
                string selectQuery = "select * from abrev_hoteles";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboHoteles.ValueMember = "id";
                comboHoteles.DisplayMember = "hotel";
                comboHoteles.DataSource = dt;

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
                if (name.Text == "" && abrev.Text == "")
                {
                    MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        con.Open();

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO abrev_hoteles (`hotel` , `abreviatura_hotel`) VALUES ('" + name.Text + "','" + abrev.Text + "' )", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();

                        name.Text = "";
                        abrev.Text = "";
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
            if (name.Text == "" && abrev.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `abrev_hoteles` SET `hotel`='" + name.Text + "',`abreviatura_hotel`='" + abrev.Text +  "' WHERE id = '" + id.Text + "'", con);
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `abrev_hoteles` WHERE id ='" + id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    name.Text = "";
                    abrev.Text = "";
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboHoteles.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT * FROM `abrev_hoteles` WHERE id = '" + idCombo + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int Ids = Convert.ToInt32(reader["id"]);
                    string hotels = Convert.ToString(reader["hotel"]);
                    string abrevs = Convert.ToString(reader["abreviatura_hotel"]);

                    id.Text = Convert.ToString(Ids);
                    name.Text = hotels;
                    abrev.Text = abrevs;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
