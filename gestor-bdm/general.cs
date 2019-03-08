using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_bdm
{
    class general
    {
        //Datos Privilegios
        private static string privilegios = "admin", tipousuario = "";

        public static string Tipousuario
        {
            get { return general.tipousuario; }
            set { general.tipousuario = value; }
        }

        public static string Privilegios
        {
            get { return general.privilegios; }
            set { general.privilegios = value; }
        }

        //Datos Usuarios
        public static string usuario = "", pass = "", filename2 = "";

        public static string Filename2
        {
            get { return general.filename2; }
            set { general.filename2 = value; }
        }

        public static string Pass
        {
            get { return general.pass; }
            set { general.pass = value; }
        }

        public static string Usuario
        {
            get { return general.usuario; }
            set { general.usuario = value; }
        }
    }
}
