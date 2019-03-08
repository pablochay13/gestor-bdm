using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_bdm
{
    class Variables
    {
        private static string sentencia = "server=172.20.3.45; database=bd-media; Uid=root; pwd=Medi@@dm1n!!;";
        //private static string sentencia = "server=localhost; database=bd-media; Uid=root; pwd=;Allow Zero Datetime=False;Convert Zero Datetime=True";

        private static string privilegios = "admin", tipousuario = "";

        public static string Tipousuario
        {
            get { return Variables.tipousuario; }
            set { Variables.tipousuario = value; }
        }

        public static string Privilegios
        {
            get { return Variables.privilegios; }
            set { Variables.privilegios = value; }
        }

        public static string Ene
        {
            get
            {
                return ene;
            }

            set
            {
                ene = value;
            }
        }

        public static string Feb
        {
            get
            {
                return feb;
            }

            set
            {
                feb = value;
            }
        }

        public static string Mar
        {
            get
            {
                return mar;
            }

            set
            {
                mar = value;
            }
        }

        public static string Abr
        {
            get
            {
                return abr;
            }

            set
            {
                abr = value;
            }
        }

        public static string Jun
        {
            get
            {
                return jun;
            }

            set
            {
                jun = value;
            }
        }

        public static string Jul
        {
            get
            {
                return jul;
            }

            set
            {
                jul = value;
            }
        }

        public static string Ago
        {
            get
            {
                return ago;
            }

            set
            {
                ago = value;
            }
        }

        public static string Sep
        {
            get
            {
                return sep;
            }

            set
            {
                sep = value;
            }
        }

        public static string Oct
        {
            get
            {
                return oct;
            }

            set
            {
                oct = value; 
            }
        }

        public static string Nov
        {
            get
            {
                return nov;
            }

            set
            {
                nov = value;
            }
        }

        public static string Dic
        {
            get
            {
                return dic;
            }

            set
            {
                dic = value;
            }
        }

        public static string Sentencia
        {
            get
            {
                return sentencia;
            }

            set
            {
                sentencia = value;
            }
        }


        //meses

        private static string ene, feb, mar, abr, jun, jul, ago, sep, oct, nov, dic = ""; 


    }
}
