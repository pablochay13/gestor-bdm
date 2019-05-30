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
    public partial class clientes_tabla : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=bd-media");
        public clientes_tabla()
        {
            InitializeComponent();
            listaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            llenar();
            hotelOrden();
            comboStatus.SelectedIndex = 0;
        }

        public void llenar()
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from clientes", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaClientes.Rows.Add();
                    listaClientes.Rows[n].Cells[0].Value = item["id_clientes"].ToString();
                    listaClientes.Rows[n].Cells[1].Value = item["region"].ToString();
                    listaClientes.Rows[n].Cells[2].Value = item["razon_social"].ToString();
                    listaClientes.Rows[n].Cells[3].Value = item["nombre_comercial"].ToString();
                    listaClientes.Rows[n].Cells[4].Value = item["id_hanna"].ToString();
                    listaClientes.Rows[n].Cells[5].Value = item["siglas_hanna"].ToString();
                    listaClientes.Rows[n].Cells[6].Value = item["sigla_hoteles"].ToString();
                    listaClientes.Rows[n].Cells[7].Value = item["abrev_hotel"].ToString();
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void toExcel_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < listaClientes.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listaClientes.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaClientes.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaClientes.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Archivo generado", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textFind.Text;

                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM clientes WHERE razon_social LIKE '%" + busqueda + "%'", con);
                DataTable dt = new DataTable();
                listaClientes.Rows.Clear();
                listaClientes.Refresh();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaClientes.Rows.Add();
                    listaClientes.Rows[n].Cells[0].Value = item["id_clientes"].ToString();
                    listaClientes.Rows[n].Cells[1].Value = item["region"].ToString();
                    listaClientes.Rows[n].Cells[2].Value = item["razon_social"].ToString();
                    listaClientes.Rows[n].Cells[3].Value = item["nombre_comercial"].ToString();
                    listaClientes.Rows[n].Cells[4].Value = item["id_hanna"].ToString();
                    listaClientes.Rows[n].Cells[5].Value = item["siglas_hanna"].ToString();
                    listaClientes.Rows[n].Cells[6].Value = item["sigla_hoteles"].ToString();
                    listaClientes.Rows[n].Cells[7].Value = item["abrev_hoteles"].ToString();
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            textFind.Text = "";

            try
            {
                listaClientes.Rows.Clear();
                listaClientes.Refresh();

                llenar();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void listaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO clientes (`region`, `razon_social`, `nombre_comercial`, `id_hanna`, `siglas_hanna`, `sigla_hotel`, `abrev_hotel` , `status`) VALUES ('" + textRegion.Text + "','" + textRazon.Text + "','" + textComercial.Text + "','" + textIDHanna.Text + "','" + textSiglaHanna.Text + "','" + comboHoteles.Text + "','" + textHoteles.Text + "','" + comboStatus.Text + "' )", con);
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

        private void Edit_Click(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("UPDATE `clientes` SET `region`='" + textRegion.Text + "',`razon_social`='" + textRazon.Text + "',`nombre_comercial`='" + textComercial.Text + "',`id_hanna`='" + textIDHanna.Text + "',`siglas_hanna`='" + textSiglaHanna.Text + "',`sigla_hoteles`='" + comboHoteles.Text + "',`abrev_hotel`='" + textHoteles.Text + "',`status`='" + comboStatus.Text + "' WHERE id_clientes = '" + textId.Text + "'", con);
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

        private void Delete_Click(object sender, EventArgs e)
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

        private void Clean_Click(object sender, EventArgs e)
        {
            limpiar();
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

        private void ListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = listaClientes.SelectedRows[0].Index;
                textId.Text = listaClientes.Rows[n].Cells[0].Value.ToString();
                textRegion.Text = listaClientes.Rows[n].Cells[1].Value.ToString();
                textRazon.Text = listaClientes.Rows[n].Cells[2].Value.ToString();
                textComercial.Text = listaClientes.Rows[n].Cells[3].Value.ToString();
                textIDHanna.Text = listaClientes.Rows[n].Cells[4].Value.ToString();
                textSiglaHanna.Text = listaClientes.Rows[n].Cells[5].Value.ToString();
                comboHoteles.Text = listaClientes.Rows[n].Cells[6].Value.ToString();
                textHoteles.Text = listaClientes.Rows[n].Cells[7].Value.ToString();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void hotelOrden()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, hotel from abrev_hoteles";
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

        private void ComboHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboHoteles.SelectedIndex);
                int idCombo = valor + 1;
                con.Close();
                con.Open();
                string sql = "SELECT `abreviatura_hotel` FROM `abrev_hoteles` WHERE id = '" + idCombo + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nombreHotel = Convert.ToString(reader["abreviatura_hotel"]);
                    labelHotel.Text = nombreHotel;
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
