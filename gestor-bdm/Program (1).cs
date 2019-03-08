using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());

            //try
            //{
            //    MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=bd-media;Uid=root;pwd=;");
            //    con.Open();
            //    string sql = "SELECT usuario, privilegios FROM usuarios WHERE privilegios = 'admin' ";
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        Variables.Tipousuario = Convert.ToString(reader["usuario"]);
            //        Variables.Privilegios = Convert.ToString(reader["privilegios"]);
            //        if (Variables.Privilegios == "admin")
            //        {
            //            Application.Run(new login());
            //        }
            //    }
            //    else if (Variables.Privilegios != "admin" || Variables.Privilegios != "user")
            //    {
            //        Application.Run(new registro());
            //    }
            //}
            //catch (Exception m)
            //{
            //    MessageBox.Show(m.Message);
            //}
        }
    }
}
