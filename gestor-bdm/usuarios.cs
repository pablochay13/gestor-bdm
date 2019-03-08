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
    public partial class usuarios : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        public usuarios()
        {
            InitializeComponent();
            listaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            llenar();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (tNombre.Text == "" && tUsuario.Text == "" && tPassword.Text == "" && tPasswordR.Text == "" && tCorreo.Text == "" && tPrivilegios.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string pass = tPassword.Text;
                    string passr = tPasswordR.Text;

                    if (pass == passr)
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (`nombre`, `usuario`, `password`, `correo`, `privilegios`) VALUES ('" + tNombre.Text + "','" + tUsuario.Text + "','" + tPasswordR.Text + "','" + tCorreo.Text + "','" + tPrivilegios.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();

                        tUsuario.Text = "";
                        tNombre.Text = "";
                        tPassword.Text = "";
                        tPasswordR.Text = "";
                        tPrivilegios.Text = "";
                        tCorreo.Text = "";

                        listaUsuarios.Rows.Clear();
                        listaUsuarios.Refresh();

                        llenar();
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas no coinciden!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (tNombre.Text == "" && tUsuario.Text == "" && tPassword.Text == "" && tPasswordR.Text == "" && tCorreo.Text == "" && tPrivilegios.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `usuarios` SET `nombre`='" + tNombre.Text + "',`usuario`='" + tUsuario.Text + "',`password`='" + tPassword.Text + "',`correo`='" + tCorreo.Text + "',`privilegios`='" + tPrivilegios.Text + "' WHERE id_usuarios = '" + textId.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                    tUsuario.Text = "";
                    tNombre.Text = "";
                    tPassword.Text = "";
                    tPasswordR.Text = "";
                    tPrivilegios.Text = "";
                    tCorreo.Text = "";

                    listaUsuarios.Rows.Clear();
                    listaUsuarios.Refresh();

                    llenar();
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `usuarios` WHERE id_usuarios ='" + textId.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                listaUsuarios.Rows.Clear();
                listaUsuarios.Refresh();

                llenar();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void listaUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = listaUsuarios.SelectedRows[0].Index;
                textId.Text = listaUsuarios.Rows[n].Cells[0].Value.ToString();
                tNombre.Text = listaUsuarios.Rows[n].Cells[1].Value.ToString();
                tUsuario.Text = listaUsuarios.Rows[n].Cells[2].Value.ToString();
                tPassword.Text = listaUsuarios.Rows[n].Cells[3].Value.ToString();
                tCorreo.Text = listaUsuarios.Rows[n].Cells[4].Value.ToString();
                tPrivilegios.Text = listaUsuarios.Rows[n].Cells[5].Value.ToString();
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
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from usuarios", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaUsuarios.Rows.Add();
                    listaUsuarios.Rows[n].Cells[0].Value = item["id_usuarios"].ToString();
                    listaUsuarios.Rows[n].Cells[1].Value = item["nombre"].ToString();
                    listaUsuarios.Rows[n].Cells[2].Value = item["usuario"].ToString();
                    listaUsuarios.Rows[n].Cells[3].Value = item["password"].ToString();
                    listaUsuarios.Rows[n].Cells[4].Value = item["correo"].ToString();
                    listaUsuarios.Rows[n].Cells[5].Value = item["privilegios"].ToString();
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
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < listaUsuarios.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listaUsuarios.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = listaUsuarios.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void toExcel_Click_1(object sender, EventArgs e)
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

                for (int i = 0; i < listaUsuarios.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listaUsuarios.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaUsuarios.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaUsuarios.Rows[i].Cells[j].Value.ToString();
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

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            tUsuario.Text = "";
            tNombre.Text = "";
            tPassword.Text = "";
            tPasswordR.Text = "";
            tPrivilegios.Text = "";
            tCorreo.Text = "";
        }
    }
}
