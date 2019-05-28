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
    public partial class clientes : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=bd-media");

        public clientes()
        {
            InitializeComponent();
            razonSocial();
        }

        public void limpiar()
        {
            textId.Text = "";
            textHoteles.Text = "";
            textRazon.Text = "";
            textComercial.Text = "";
            textIDHanna.Text = "";
            textSiglaHanna.Text = "";
            textHoteles.Text = "";
            comboSiglasHoteles.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textRegion.Text == "" && textRazon.Text == "" && textComercial.Text == "" && textIDHanna.Text == "" && textSiglaHanna.Text == "" && textHoteles.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO clientes (`region`, `razon_social`, `nombre_comercial`, `id_hanna`, `siglas_hanna`, `sigla_hotel`, `abrev_hotel`) VALUES ('" + textRegion.Text + "','" + textRazon.Text + "','" + textComercial.Text + "','" + textIDHanna.Text + "','" + textSiglaHanna.Text + "','" + comboSiglasHoteles.Text + "','" + textHoteles.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    limpiar();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (textRegion.Text == "" && textRazon.Text == "" && textComercial.Text == "" && textIDHanna.Text == "" && textSiglaHanna.Text == "" && textHoteles.Text == "")

            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `clientes` SET `region`='" + textRegion.Text + "',`razon_social`='" + textRazon.Text + "',`nombre_comercial`='" + textComercial.Text + "',`id_hanna`='" + textIDHanna.Text + "',`siglas_hanna`='" + textSiglaHanna.Text + "',`sigla_hoteles`='" + comboSiglasHoteles.Text + "',`abrev_hotel`='" + textHoteles.Text + "' WHERE id_clientes = '" + textId.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    limpiar();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `clientes` WHERE id_clientes ='" + textId.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                limpiar();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboClientes.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT * FROM clientes WHERE razon_social = '" + comboClientes.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string t_id = Convert.ToString(reader["id_clientes"]);
                    string t_region = Convert.ToString(reader["region"]);
                    string t_social = Convert.ToString(reader["nombre_comercial"]);
                    string t_id_hanna = Convert.ToString(reader["id_hanna"]);
                    string t_sigla_hanna = Convert.ToString(reader["siglas_hanna"]);
                    string t_razon = Convert.ToString(reader["razon_social"]);
                    string t_hoteles = Convert.ToString(reader["sigla_hoteles"]);
                    string t_abrev = Convert.ToString(reader["abrev_hotel"]);

                    textId.Text = t_id;
                    textRazon.Text = t_razon;
                    textComercial.Text = t_social;
                    textIDHanna.Text = t_id_hanna;
                    textSiglaHanna.Text = t_sigla_hanna;
                    comboSiglasHoteles.Text = t_hoteles;
                    textHoteles.Text = t_abrev;
                    textRegion.Text = t_region;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void razonSocial()
        {
            try
            {
                con.Close();

                //string selectQuery = "select id_clientes, razon_social from clientes where region = '" + clave_pais + "'";
                string selectQuery = "select id_clientes, razon_social from clientes";

                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboClientes.ValueMember = "id_clientes";
                comboClientes.DisplayMember = "razon_social";
                comboClientes.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clavePais()
        {
            try
            {
                con.Close();

                //string selectQuery = "select id_clientes, razon_social from clientes where region = '" + clave_pais + "'";
                string selectQuery = "select id, abrv from paises";

                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboRegion.ValueMember = "id";
                comboRegion.DisplayMember = "abrev";
                comboRegion.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
