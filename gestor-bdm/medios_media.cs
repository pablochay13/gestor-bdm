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
    public partial class medios_media : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=bd-media");

        public medios_media()
        {
            InitializeComponent();
            listaMedios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            llenar();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (tMedio.Text == "" && tFormato.Text == "" && tSpecs.Text == "" && tCompra.Text == "" && tUnitario.Text == "" && tPais.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO medios (`medio`, `formato`, `specs`, `tipo_compra`, `precio_unitario`, `pais`, `division`) VALUES ('" + tMedio.Text + "','" + tFormato.Text + "','" + tSpecs.Text + "','" + tCompra.Text + "','" + tUnitario.Text + "','" + tPais.Text + "' ,'" + tDivision.Text + "' )", con);
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
            if (tMedio.Text == "" && tFormato.Text == "" && tSpecs.Text == "" && tCompra.Text == "" && tUnitario.Text == "" && tPais.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `medios` SET `medio`='" + tMedio.Text + "',`formato`='" + tFormato.Text + "',`specs`='" + tSpecs.Text + "',`tipo_compra`='" + tCompra.Text + "',`precio_unitario`='" + tUnitario.Text + "',`pais`='" + tPais.Text + "',`division`='" + tDivision.Text + "' WHERE id_medios = '" + textId.Text + "'", con);
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `medios` WHERE id_medios ='" + textId.Text + "'", con);
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

        private void listaMedios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = listaMedios.SelectedRows[0].Index;
                textId.Text = listaMedios.Rows[n].Cells[0].Value.ToString();
                tMedio.Text = listaMedios.Rows[n].Cells[1].Value.ToString();
                tFormato.Text = listaMedios.Rows[n].Cells[2].Value.ToString();
                tSpecs.Text = listaMedios.Rows[n].Cells[3].Value.ToString();
                tCompra.Text = listaMedios.Rows[n].Cells[4].Value.ToString();
                tUnitario.Text = listaMedios.Rows[n].Cells[5].Value.ToString();
                tPais.Text = listaMedios.Rows[n].Cells[6].Value.ToString();
                tDivision.Text = listaMedios.Rows[n].Cells[7].Value.ToString();

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void llenar()
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from medios", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaMedios.Rows.Add();
                    listaMedios.Rows[n].Cells[0].Value = item["id_medios"].ToString();
                    listaMedios.Rows[n].Cells[1].Value = item["medio"].ToString();
                    listaMedios.Rows[n].Cells[2].Value = item["formato"].ToString();
                    listaMedios.Rows[n].Cells[3].Value = item["specs"].ToString();
                    listaMedios.Rows[n].Cells[4].Value = item["tipo_compra"].ToString();
                    listaMedios.Rows[n].Cells[5].Value = item["precio_unitario"].ToString();
                    listaMedios.Rows[n].Cells[6].Value = item["pais"].ToString();
                    listaMedios.Rows[n].Cells[7].Value = item["division"].ToString();
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

                for (int i = 0; i < listaMedios.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listaMedios.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaMedios.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaMedios.Rows[i].Cells[j].Value.ToString();
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
            string busqueda = textFind.Text;

            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM medios WHERE medio LIKE '%" + busqueda + "%'", con);
                DataTable dt = new DataTable();
                listaMedios.Rows.Clear();
                listaMedios.Refresh();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaMedios.Rows.Add();
                    listaMedios.Rows[n].Cells[0].Value = item["id_medios"].ToString();
                    listaMedios.Rows[n].Cells[1].Value = item["medio"].ToString();
                    listaMedios.Rows[n].Cells[2].Value = item["formato"].ToString();
                    listaMedios.Rows[n].Cells[3].Value = item["specs"].ToString();
                    listaMedios.Rows[n].Cells[4].Value = item["tipo_compra"].ToString();
                    listaMedios.Rows[n].Cells[5].Value = item["precio_unitario"].ToString();
                    listaMedios.Rows[n].Cells[6].Value = item["pais"].ToString();
                    listaMedios.Rows[n].Cells[7].Value = item["division"].ToString();
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
                listaMedios.Rows.Clear();
                listaMedios.Refresh();

                llenar();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void limpiar()
        {
            textId.Text = "";
            tMedio.Text = "";
            tFormato.Text = "";
            tSpecs.Text = "";
            tCompra.Text = "";
            tUnitario.Text = "";
            tPais.Text = "";
            tDivision.Text = "";

            listaMedios.Rows.Clear();
            listaMedios.Refresh();

            llenar();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            tMedio.Text = "";
            tFormato.Text = "";
            tSpecs.Text = "";
            tCompra.Text = "";
            tUnitario.Text = "";
            tPais.Text = "";
            tDivision.Text = "";
        }
    }
}
