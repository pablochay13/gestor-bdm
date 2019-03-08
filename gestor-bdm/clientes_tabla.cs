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
                    listaClientes.Rows[n].Cells[1].Value = item["cliente"].ToString();
                    listaClientes.Rows[n].Cells[2].Value = item["marca"].ToString();
                    listaClientes.Rows[n].Cells[3].Value = item["inversion_usd"].ToString();
                    listaClientes.Rows[n].Cells[4].Value = item["inversion_mxn"].ToString();
                    listaClientes.Rows[n].Cells[5].Value = item["mf_paquete"].ToString();
                    listaClientes.Rows[n].Cells[6].Value = item["reinversion"].ToString();
                    listaClientes.Rows[n].Cells[7].Value = item["contacto"].ToString();
                    listaClientes.Rows[n].Cells[8].Value = item["email"].ToString();
                    listaClientes.Rows[n].Cells[9].Value = item["telefono"].ToString();
                    listaClientes.Rows[n].Cells[10].Value = item["tipo"].ToString();
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
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM clientes WHERE cliente LIKE '%" + busqueda + "%'", con);
                DataTable dt = new DataTable();
                listaClientes.Rows.Clear();
                listaClientes.Refresh();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaClientes.Rows.Add();
                    listaClientes.Rows[n].Cells[0].Value = item["id_clientes"].ToString();
                    listaClientes.Rows[n].Cells[1].Value = item["cliente"].ToString();
                    listaClientes.Rows[n].Cells[2].Value = item["marca"].ToString();
                    listaClientes.Rows[n].Cells[3].Value = item["inversion_usd"].ToString();
                    listaClientes.Rows[n].Cells[4].Value = item["inversion_mxn"].ToString();
                    listaClientes.Rows[n].Cells[5].Value = item["mf_paquete"].ToString();
                    listaClientes.Rows[n].Cells[6].Value = item["reinversion"].ToString();
                    listaClientes.Rows[n].Cells[7].Value = item["contacto"].ToString();
                    listaClientes.Rows[n].Cells[8].Value = item["email"].ToString();
                    listaClientes.Rows[n].Cells[9].Value = item["telefono"].ToString();
                    listaClientes.Rows[n].Cells[10].Value = item["tipo"].ToString();
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
            //try
            //{
            //    int n = listaClientes.SelectedRows[0].Index;
            //    textId.Text = listaClientes.Rows[n].Cells[0].Value.ToString();
            //    textCliente.Text = listaClientes.Rows[n].Cells[1].Value.ToString();
            //    textMarca.Text = listaClientes.Rows[n].Cells[2].Value.ToString();
            //    textUSD.Text = listaClientes.Rows[n].Cells[3].Value.ToString();
            //    textMXN.Text = listaClientes.Rows[n].Cells[4].Value.ToString();
            //    textPaquete.Text = listaClientes.Rows[n].Cells[5].Value.ToString();
            //    textReinver.Text = listaClientes.Rows[n].Cells[6].Value.ToString();
            //    textContacto.Text = listaClientes.Rows[n].Cells[7].Value.ToString();
            //    textEmail.Text = listaClientes.Rows[n].Cells[8].Value.ToString();
            //    textTelefono.Text = listaClientes.Rows[n].Cells[9].Value.ToString();
            //    textTipo.Text = listaClientes.Rows[n].Cells[10].Value.ToString();
            //}
            //catch (Exception m)
            //{
            //    MessageBox.Show(m.Message);
            //}
        }
    }
}
