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
    public partial class saldos_media : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=bd-media");

        public saldos_media()
        {
            InitializeComponent();
            listaSaldos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            llenar();
        }

        public void llenar()
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from saldos_media", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaSaldos.Rows.Add();
                    listaSaldos.Rows[n].Cells[0].Value = item["id_saldos"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["clave_hann"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["siglas"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["folio_m"].ToString();
                    listaSaldos.Rows[n].Cells[4].Value = item["fecha"].ToString();
                    listaSaldos.Rows[n].Cells[5].Value = item["razon_social"].ToString();
                    listaSaldos.Rows[n].Cells[6].Value = item["nombre_comercial"].ToString();
                    listaSaldos.Rows[n].Cells[7].Value = item["monto_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[8].Value = item["divisa"].ToString();
                    listaSaldos.Rows[n].Cells[9].Value = item["pauta"].ToString();
                    listaSaldos.Rows[n].Cells[10].Value = item["market_manager"].ToString();
                    listaSaldos.Rows[n].Cells[11].Value = item["anticipo"].ToString();
                    listaSaldos.Rows[n].Cells[12].Value = item["estatus_cobrado"].ToString();
                    listaSaldos.Rows[n].Cells[13].Value = item["estatus_facturacion"].ToString();
                    listaSaldos.Rows[n].Cells[14].Value = item["enero"].ToString();
                    listaSaldos.Rows[n].Cells[15].Value = item["febrero"].ToString();
                    listaSaldos.Rows[n].Cells[16].Value = item["marzo"].ToString();
                    listaSaldos.Rows[n].Cells[17].Value = item["abril"].ToString();
                    listaSaldos.Rows[n].Cells[18].Value = item["mayo"].ToString();
                    listaSaldos.Rows[n].Cells[19].Value = item["junio"].ToString();
                    listaSaldos.Rows[n].Cells[20].Value = item["julio"].ToString();
                    listaSaldos.Rows[n].Cells[21].Value = item["agosto"].ToString();
                    listaSaldos.Rows[n].Cells[22].Value = item["septiembre"].ToString();
                    listaSaldos.Rows[n].Cells[23].Value = item["octubre"].ToString();
                    listaSaldos.Rows[n].Cells[24].Value = item["noviembre"].ToString();
                    listaSaldos.Rows[n].Cells[25].Value = item["diciembre"].ToString();
                    listaSaldos.Rows[n].Cells[26].Value = item["forma_pago"].ToString();
                    listaSaldos.Rows[n].Cells[27].Value = item["account_manager"].ToString();
                    listaSaldos.Rows[n].Cells[28].Value = item["daf"].ToString();
                    listaSaldos.Rows[n].Cells[29].Value = item["comentarios"].ToString();

                    con.Close();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void limpiar()
        {
            tRazon.Text = "";
            tNombre.Text = "";
            tMonto.Text = "";
            tDivisa.Text = "";
            tPauta.Text = "";
            tMarket.Text = "";
            tAnticipo.Text = "";
            tCobrado.Text = "";
            tFacturado.Text = "";
            tEnero.Text = "";
            tFebrero.Text = "";
            tMarzo.Text = "";
            tAbril.Text = "";
            tMayo.Text = "";
            tJunio.Text = "";
            tJulio.Text = "";
            tAgosto.Text = "";
            tSeptiembre.Text = "";
            tOctubre.Text = "";
            tNoviembre.Text = "";
            tDiciembre.Text = "";
            tForma.Text = "";
            tAccount.Text = "";
            tObservaciones.Text = "";

            listaSaldos.Rows.Clear();
            listaSaldos.Refresh();

            llenar();
        }

        private void listaSaldos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = listaSaldos.SelectedRows[0].Index;
                id.Text = listaSaldos.Rows[n].Cells[0].Value.ToString();
                tHann.Text = listaSaldos.Rows[n].Cells[1].Value.ToString();
                tSiglas.Text = listaSaldos.Rows[n].Cells[2].Value.ToString();
                tMedia.Text = listaSaldos.Rows[n].Cells[3].Value.ToString();
                tFecha.Text = listaSaldos.Rows[n].Cells[4].Value.ToString();
                tRazon.Text = listaSaldos.Rows[n].Cells[5].Value.ToString();
                tNombre.Text = listaSaldos.Rows[n].Cells[6].Value.ToString();
                tMonto.Text = listaSaldos.Rows[n].Cells[7].Value.ToString();
                tDivisa.Text = listaSaldos.Rows[n].Cells[8].Value.ToString();
                tPauta.Text = listaSaldos.Rows[n].Cells[9].Value.ToString();
                tMarket.Text = listaSaldos.Rows[n].Cells[10].Value.ToString();
                tAnticipo.Text = listaSaldos.Rows[n].Cells[11].Value.ToString();
                tCobrado.Text = listaSaldos.Rows[n].Cells[12].Value.ToString();
                tFacturado.Text = listaSaldos.Rows[n].Cells[13].Value.ToString();
                tEnero.Text = listaSaldos.Rows[n].Cells[14].Value.ToString();
                tFebrero.Text = listaSaldos.Rows[n].Cells[15].Value.ToString();
                tMarzo.Text = listaSaldos.Rows[n].Cells[16].Value.ToString();
                tAbril.Text = listaSaldos.Rows[n].Cells[17].Value.ToString();
                tMayo.Text = listaSaldos.Rows[n].Cells[18].Value.ToString();
                tJunio.Text = listaSaldos.Rows[n].Cells[19].Value.ToString();
                tJulio.Text = listaSaldos.Rows[n].Cells[20].Value.ToString();
                tAgosto.Text = listaSaldos.Rows[n].Cells[21].Value.ToString();
                tSeptiembre.Text = listaSaldos.Rows[n].Cells[22].Value.ToString();
                tOctubre.Text = listaSaldos.Rows[n].Cells[23].Value.ToString();
                tNoviembre.Text = listaSaldos.Rows[n].Cells[24].Value.ToString();
                tDiciembre.Text = listaSaldos.Rows[n].Cells[25].Value.ToString();
                tForma.Text = listaSaldos.Rows[n].Cells[26].Value.ToString();
                tAccount.Text = listaSaldos.Rows[n].Cells[27].Value.ToString();
                tDAF.Text = listaSaldos.Rows[n].Cells[28].Value.ToString();
                tObservaciones.Text = listaSaldos.Rows[n].Cells[29].Value.ToString();
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
                if (tRazon.Text == "" && tNombre.Text == "" && tMonto.Text == "" && tDivisa.Text == "" && tPauta.Text == "" && tMarket.Text == "" && tAnticipo.Text == "" && tCobrado.Text == "" && tFacturado.Text == "" && tForma.Text == "" && tAccount.Text == "" && tObservaciones.Text == "")
                {
                    MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO saldos_media (`clave_hann` , `siglas` , `folio_m` , `fecha` , `razon_social`, `nombre_comercial`, `monto_pauta` , `divisa`, `pauta`, `market_manager`, `anticipo`, `estatus_cobrado`, `estatus_facturacion`, `enero` , `febrero` , `marzo`  , `abril` , `mayo` , `junio` , `julio` , `agosto` , `septiembre` , `octubre`  , `noviembre` , `diciembre` , `forma_pago` , `account_manager` , `daf` , `comentarios`) VALUES ('" + tHann.Text + "','" + tSiglas.Text + "','" + tMedia.Text + "','" + tFecha.Text + "','" + tRazon.Text + "','" + tNombre.Text + "','" + tMonto.Text + "','" + tDivisa.Text + "','" + tPauta.Text + "','" + tMarket.Text + "','" + tAnticipo.Text + "','" + tCobrado.Text + "','" + tFacturado.Text + "','" + tEnero.Text + "','" + tFebrero.Text + "','" + tMarzo.Text + "','" + tAbril.Text + "','" + tMayo.Text + "','" + tJunio.Text + "','" + tJulio.Text + "','" + tAgosto.Text + "','" + tSeptiembre.Text + "','" + tOctubre.Text + "','" + tNoviembre.Text + "','" + tDiciembre.Text + "','" + tForma.Text + "','" + tAccount.Text + "','" + tDAF.Text + "','" + tObservaciones.Text + "' )", con);
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
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (tRazon.Text == "" && tNombre.Text == "" && tMonto.Text == "" && tDivisa.Text == "" && tPauta.Text == "" && tMarket.Text == "" && tAnticipo.Text == "" && tCobrado.Text == "" && tFacturado.Text == "" && tForma.Text == "" && tAccount.Text == "" && tObservaciones.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `saldos_media` SET `clave_hann`='" + tHann.Text + "', `siglas`='" + tSiglas.Text + "', `folio_m`='" + tMedia.Text + "', `fecha`='" + tFecha.Text + "', `razon_social`='" + tRazon.Text + "',`nombre_comercial`='" + tNombre.Text + "',`monto_pauta`='" + tMonto.Text + "',`divisa`='" + tDivisa.Text + "',`pauta`='" + tPauta.Text + "',`market_manager`='" + tMarket.Text + "',`anticipo`='" + tAnticipo.Text + "',`estatus_cobrado`='" + tCobrado.Text + "',`estatus_facturacion`='" + tFacturado.Text + "',`enero`='" + tEnero.Text + "',`febrero`='" + tFebrero.Text + "',`marzo`='" + tMarzo.Text + "',`abril`='" + tAbril.Text + "',`mayo`='" + tMayo.Text + "',`junio`='" + tJunio.Text + "',`julio`='" + tJulio.Text + "',`agosto`='" + tAgosto.Text + "',`septiembre`='" + tSeptiembre.Text + "',`octubre`='" + tOctubre.Text + "',`noviembre`='" + tNoviembre.Text + "',`diciembre`='" + tDiciembre.Text + "',`forma_pago`='" + tForma.Text + "',`account_manager`='" + tAccount.Text + "',`daf`='" + tDAF.Text + "',`comentarios`='" + tObservaciones.Text + "' WHERE id_saldos = '" + id.Text + "'", con);
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
            if (general.Privilegios == "admin")
            {
                //code
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `saldos_media` WHERE id_saldos ='" + id.Text + "'", con);
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
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toExcel_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
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

                    for (int i = 0; i < listaSaldos.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < listaSaldos.Columns.Count; j++)
                        {
                            if (cellRowIndex == 1)
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = listaSaldos.Columns[j].HeaderText;
                            }
                            else
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = listaSaldos.Rows[i].Cells[j].Value.ToString();
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
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            string busqueda = textFind.Text;

            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM saldos_media WHERE razon_social LIKE '%" + busqueda + "%'", con);
                DataTable dt = new DataTable();
                listaSaldos.Rows.Clear();
                listaSaldos.Refresh();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaSaldos.Rows.Add();
                    listaSaldos.Rows[n].Cells[0].Value = item["id_saldos"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["clave_hann"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["siglas"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["folio_m"].ToString();
                    listaSaldos.Rows[n].Cells[4].Value = item["fecha"].ToString();
                    listaSaldos.Rows[n].Cells[5].Value = item["razon_social"].ToString();
                    listaSaldos.Rows[n].Cells[6].Value = item["nombre_comercial"].ToString();
                    listaSaldos.Rows[n].Cells[7].Value = item["monto_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[8].Value = item["divisa"].ToString();
                    listaSaldos.Rows[n].Cells[9].Value = item["pauta"].ToString();
                    listaSaldos.Rows[n].Cells[10].Value = item["market_manager"].ToString();
                    listaSaldos.Rows[n].Cells[11].Value = item["anticipo"].ToString();
                    listaSaldos.Rows[n].Cells[12].Value = item["estatus_cobrado"].ToString();
                    listaSaldos.Rows[n].Cells[13].Value = item["estatus_facturacion"].ToString();
                    listaSaldos.Rows[n].Cells[14].Value = item["enero"].ToString();
                    listaSaldos.Rows[n].Cells[15].Value = item["febrero"].ToString();
                    listaSaldos.Rows[n].Cells[16].Value = item["marzo"].ToString();
                    listaSaldos.Rows[n].Cells[17].Value = item["abril"].ToString();
                    listaSaldos.Rows[n].Cells[18].Value = item["mayo"].ToString();
                    listaSaldos.Rows[n].Cells[19].Value = item["junio"].ToString();
                    listaSaldos.Rows[n].Cells[20].Value = item["julio"].ToString();
                    listaSaldos.Rows[n].Cells[21].Value = item["agosto"].ToString();
                    listaSaldos.Rows[n].Cells[22].Value = item["septiembre"].ToString();
                    listaSaldos.Rows[n].Cells[23].Value = item["octubre"].ToString();
                    listaSaldos.Rows[n].Cells[24].Value = item["noviembre"].ToString();
                    listaSaldos.Rows[n].Cells[25].Value = item["diciembre"].ToString();
                    listaSaldos.Rows[n].Cells[26].Value = item["forma_pago"].ToString();
                    listaSaldos.Rows[n].Cells[27].Value = item["account_manager"].ToString();
                    listaSaldos.Rows[n].Cells[28].Value = item["daf"].ToString();
                    listaSaldos.Rows[n].Cells[29].Value = item["comentarios"].ToString();
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

        }
    }
}
