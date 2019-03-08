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
    public partial class landings : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=bd-media");

        public landings()
        {
            InitializeComponent();
            listaLandings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            llenar();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textHotel.Text == "" && textUrl.Text == "" && textSolicitud.Text == "" && textEntrega.Text == "" && textAccount.Text == "" && textTipo.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO landings (`hotel`, `url`, `fecha_solicitud`, `fecha_entrega`, `account`, `tipo` , `activa`) VALUES ('" + textHotel.Text + "','" + textUrl.Text + "','" + textSolicitud.Text + "','" + textEntrega.Text + "','" + textAccount.Text + "','" + textTipo.Text + "' )", con);
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `landings` WHERE id_landings ='" + textId.Text + "'", con);
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

        private void edit_Click(object sender, EventArgs e)
        {
            if (textHotel.Text == "" && textUrl.Text == "" && textSolicitud.Text == "" && textEntrega.Text == "" && textAccount.Text == "" && textTipo.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `landings` SET `hotel`='" + textHotel.Text + "',`url`='" + textUrl.Text + "',`fecha_solicitud`='" + textSolicitud.Text + "',`fecha_entrega`='" + textEntrega.Text + "',`account`='" + textAccount.Text + "',`tipo`='" + textTipo.Text + "' WHERE id_landings = '" + textId.Text + "'", con);
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

        private void listaLandings_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = listaLandings.SelectedRows[0].Index;
                textId.Text = listaLandings.Rows[n].Cells[0].Value.ToString();
                textHotel.Text = listaLandings.Rows[n].Cells[1].Value.ToString();
                textUrl.Text = listaLandings.Rows[n].Cells[2].Value.ToString();
                textSolicitud.Text = listaLandings.Rows[n].Cells[3].Value.ToString();
                textEntrega.Text = listaLandings.Rows[n].Cells[4].Value.ToString();
                textAccount.Text = listaLandings.Rows[n].Cells[5].Value.ToString();
                textTipo.Text = listaLandings.Rows[n].Cells[6].Value.ToString();
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
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from landings", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaLandings.Rows.Add();
                    listaLandings.Rows[n].Cells[0].Value = item["id_landings"].ToString();
                    listaLandings.Rows[n].Cells[1].Value = item["hotel"].ToString();
                    listaLandings.Rows[n].Cells[2].Value = item["url"].ToString();
                    listaLandings.Rows[n].Cells[3].Value = item["fecha_solicitud"].ToString();
                    listaLandings.Rows[n].Cells[4].Value = item["fecha_entrega"].ToString();
                    listaLandings.Rows[n].Cells[5].Value = item["account"].ToString();
                    listaLandings.Rows[n].Cells[6].Value = item["tipo"].ToString();
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

                for (int i = 0; i < listaLandings.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listaLandings.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaLandings.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaLandings.Rows[i].Cells[j].Value.ToString();
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
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM landings WHERE hotel LIKE '%" + busqueda + "%'", con);
                DataTable dt = new DataTable();
                listaLandings.Rows.Clear();
                listaLandings.Refresh();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaLandings.Rows.Add();
                    listaLandings.Rows[n].Cells[0].Value = item["id_landings"].ToString();
                    listaLandings.Rows[n].Cells[1].Value = item["hotel"].ToString();
                    listaLandings.Rows[n].Cells[2].Value = item["url"].ToString();
                    listaLandings.Rows[n].Cells[3].Value = item["fecha_solicitud"].ToString();
                    listaLandings.Rows[n].Cells[4].Value = item["fecha_entrega"].ToString();
                    listaLandings.Rows[n].Cells[5].Value = item["account"].ToString();
                    listaLandings.Rows[n].Cells[6].Value = item["tipo"].ToString();
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
                listaLandings.Rows.Clear();
                listaLandings.Refresh();

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
            textHotel.Text = "";
            textUrl.Text = "";
            textSolicitud.Text = "";
            textEntrega.Text = "";
            textAccount.Text = "";
            textTipo.Text = "";

            listaLandings.Rows.Clear();
            listaLandings.Refresh();

            llenar();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textHotel.Text = "";
            textUrl.Text = "";
            textSolicitud.Text = "";
            textEntrega.Text = "";
            textAccount.Text = "";
            textTipo.Text = "";
        }
    }
}
