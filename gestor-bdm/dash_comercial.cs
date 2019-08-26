using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestor_bdm
{
    public partial class dash_comercial : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=bd-media");
        public dash_comercial()
        {
            InitializeComponent();

            llenar();
            clientes();
            tipoPauta();

            comboClientes.SelectedIndex = 0;
            comboPais.SelectedIndex = 0;
            comboTipoCliente.SelectedIndex = 0;
            comboTipoInversion.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            comboMercado.SelectedIndex = 0;
            comboTemporada.SelectedIndex = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textShare.Text == "" && textCanal.Text == "" && textAnticipacion.Text == "" && textEstancia.Text == "" && textSell.Text == "" && textBanco.Text == "" && textBancoPorcentaje.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO dash_comercial (`cliente`, `pais`, `tipo_cliente`, `tipo_inversion`, `status`, `mercado_domestico`, `share` , `canal` , `temporada_venta` , `anticipacion` , `estancia` , `sell_rate` , `banco` , `porcentaje_banco` , `comentarios`) VALUES ('" + comboClientes.Text + "','" + comboPais.Text + "','" + comboTipoCliente.Text + "','" + comboTipoInversion.Text + "','" + comboStatus.Text + "','" + comboMercado.Text + "','" + textShare.Text + "','" + textCanal.Text + "','" + comboTemporada.Text + "','" + textAnticipacion.Text + "','" + textEstancia.Text + "','" + textSell.Text + "','" + textBanco.Text + "','" + textBancoPorcentaje.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    llenar();
                    //limpiar();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (textShare.Text == "" && textCanal.Text == "" && textAnticipacion.Text == "" && textEstancia.Text == "" && textSell.Text == "" && textBanco.Text == "" && textBancoPorcentaje.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `dash_comercial` SET `cliente`='" + comboClientes.Text + "',`pais`='" + comboPais.Text + "',`tipo_cliente`='" + comboTipoCliente.Text + "',`tipo_inversion`='" + comboTipoInversion.Text + "',`status`='" + comboStatus.Text + "',`mercado_domestico`='" + comboMercado.Text + "',`share`='" + textShare.Text + "',`canal`='" + textCanal.Text + "',`temporada_venta`='" + comboTemporada.Text + "',`anticipacion`='" + textAnticipacion.Text + "',`estancia`='" + textEstancia.Text + "',`sell_rate`='" + textSell.Text + "',`banco`='" + textBanco.Text + "',`porcentaje_banco`='" + textBancoPorcentaje.Text + "',`comentarios`='" + textComentarios.Text + "' WHERE id = '" + textId.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    llenar();
                    //limpiar();
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `dash_comercial` WHERE id ='" + textId.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                llenar();
                //limpiar();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void clientes()
        {
            try
            {
                con.Close();

                string selectQuery = "select id_clientes, nombre_comercial from clientes";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboClientes.ValueMember = "id_clientes";
                comboClientes.DisplayMember = "nombre_comercial";
                comboClientes.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tipoPauta()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, nombre from abrev_pauta";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboTipoInversion.ValueMember = "id";
                comboTipoInversion.DisplayMember = "nombre";
                comboTipoInversion.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenar()
        {
            try
            {
                tableDatos.Rows.Clear();

                con.Close();

                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from dash_comercial", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = tableDatos.Rows.Add();
                    tableDatos.Rows[n].Cells[0].Value = item["id"].ToString();
                    tableDatos.Rows[n].Cells[1].Value = item["cliente"].ToString();
                    tableDatos.Rows[n].Cells[2].Value = item["pais"].ToString();
                    tableDatos.Rows[n].Cells[3].Value = item["tipo_cliente"].ToString();
                    tableDatos.Rows[n].Cells[4].Value = item["tipo_inversion"].ToString();
                    tableDatos.Rows[n].Cells[5].Value = item["status"].ToString();
                    tableDatos.Rows[n].Cells[6].Value = item["mercado_domestico"].ToString();
                    tableDatos.Rows[n].Cells[7].Value = item["share"].ToString();
                    tableDatos.Rows[n].Cells[8].Value = item["canal"].ToString();
                    tableDatos.Rows[n].Cells[9].Value = item["temporada_venta"].ToString();
                    tableDatos.Rows[n].Cells[10].Value = item["anticipacion"].ToString();
                    tableDatos.Rows[n].Cells[11].Value = item["estancia"].ToString();
                    tableDatos.Rows[n].Cells[12].Value = item["sell_rate"].ToString();
                    tableDatos.Rows[n].Cells[13].Value = item["banco"].ToString();
                    tableDatos.Rows[n].Cells[14].Value = item["porcentaje_banco"].ToString();
                    tableDatos.Rows[n].Cells[15].Value = item["comentarios"].ToString();

                    con.Close();
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void ExportarExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Datos";
            // Cabeceras
            for (int i = 1; i < tableDatos.Columns.Count + 1; i++)
            {
                if (i > 1 && i < tableDatos.Columns.Count)
                {
                    worksheet.Cells[1, i] = tableDatos.Columns[i - 1].HeaderText;
                }
            }
            // Valores
            for (int i = 0; i < tableDatos.Rows.Count - 1; i++)
            {
                for (int j = 0; j < tableDatos.Columns.Count; j++)
                {
                    if (j > 0 && j < tableDatos.Columns.Count - 1)
                    {
                        worksheet.Cells[i + 2, j + 1] = tableDatos.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = "Datos ordenes de inserción";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }

            MessageBox.Show("Archivo generado", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TableDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = tableDatos.SelectedRows[0].Index;
                textId.Text = tableDatos.Rows[n].Cells[0].Value.ToString();
                comboClientes.Text = tableDatos.Rows[n].Cells[1].Value.ToString();
                comboPais.Text = tableDatos.Rows[n].Cells[2].Value.ToString();
                comboTipoCliente.Text = tableDatos.Rows[n].Cells[3].Value.ToString();
                comboTipoInversion.Text = tableDatos.Rows[n].Cells[4].Value.ToString();
                comboStatus.Text = tableDatos.Rows[n].Cells[5].Value.ToString();
                comboMercado.Text = tableDatos.Rows[n].Cells[6].Value.ToString();
                textShare.Text = tableDatos.Rows[n].Cells[7].Value.ToString();
                textCanal.Text = tableDatos.Rows[n].Cells[8].Value.ToString();
                comboTemporada.Text = tableDatos.Rows[n].Cells[9].Value.ToString();
                textAnticipacion.Text = tableDatos.Rows[n].Cells[10].Value.ToString();
                textEstancia.Text = tableDatos.Rows[n].Cells[11].Value.ToString();
                textSell.Text = tableDatos.Rows[n].Cells[12].Value.ToString();
                textBanco.Text = tableDatos.Rows[n].Cells[13].Value.ToString();
                textBancoPorcentaje.Text = tableDatos.Rows[n].Cells[14].Value.ToString();
                textComentarios.Text = tableDatos.Rows[n].Cells[15].Value.ToString();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void ToExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }
    }
}
