using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class opciones : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public opciones()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory("C:\\BDM\\BaseDatos\\");
        }

        private void backupBD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MessageBox.Show("Desea hacer respaldo de la Base de Datos?", "BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string constring = "server=172.20.3.45; database=bd-media; Uid=root; pwd=Medi@@dm1n!!;";
                string file = Path.Combine("C:\\BDM\\BaseDatos\\BD-Media" + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".sql");
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("Respaldo realizado correctamente", "BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al realizar el respaldo", "BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exc.Message);
            }
        }

        private void restoreBD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                MessageBox.Show("Desea Restaurar la Base de Datos ?", "BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                OpenFileDialog BuscarSQL = new OpenFileDialog();
                BuscarSQL.Filter = "Base Datos |*.sql";
                BuscarSQL.FileName = "";
                BuscarSQL.Title = "Base Datos";
                BuscarSQL.InitialDirectory = "C:\\BDM\\BaseDatos\\"; BuscarSQL.FileName = this.filee.Text;
                if (BuscarSQL.ShowDialog() == DialogResult.OK)
                {
                    this.filee.Text = BuscarSQL.FileName;
                    String Direccion = BuscarSQL.FileName;
                }

                string constring = "server=172.20.3.45; database=bd-media; Uid=root; pwd=Medi@@dm1n!!;";
                String file = filee.Text;
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("Base de Datos restaurada correctamente", "BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al restaurar Base de Datos", "BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
