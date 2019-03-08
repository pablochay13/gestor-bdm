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
                    MySqlCommand cmd = new MySqlCommand("UPDATE `clientes` SET `cliente`='" + textRegion.Text + "',`razon_social`='" + textRazon.Text + "',`nombre_comercial`='" + textComercial.Text + "',`id_hanna`='" + textIDHanna.Text + "',`siglas_hanna`='" + textSiglaHanna.Text + "',`sigla_hotel`='" + comboSiglasHoteles.Text + "',`abrev_hotel`='" + textHoteles.Text + "' WHERE id_clientes = '" + textId.Text + "'", con);
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
    }
}
