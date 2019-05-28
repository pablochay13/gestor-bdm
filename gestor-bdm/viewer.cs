using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class viewer : Form
    {
        public viewer()
        {
            InitializeComponent();
        }

        private void viewer_Load(object sender, EventArgs e)
        {
            DownloadFTP("C:\\BDM\\Archivos", "ftp://172.20.3.45/" + Variables.Ruta_pdf, "chay0s", @"Chay0s1318");

            this.webBrowser1.Navigate("C:\\BDM\\Archivos\\" + Variables.Ruta_pdf);
        }

        public static void DownloadFTP(string LocalDirectory, string RemoteFile,
                            string Login, string Password)
        {
            // Creo el objeto ftp
            FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(RemoteFile);

            // Fijo las credenciales, usuario y contraseña
            ftp.Credentials = new NetworkCredential(Login, Password);

            // Le digo que no mantenga la conexión activa al terminar.
            ftp.KeepAlive = false;

            // Indicamos que la operación es descargar un archivo...
            ftp.Method = WebRequestMethods.Ftp.DownloadFile;

            // … en modo binario … (podria ser como ASCII)
            ftp.UseBinary = true;

            // Desactivo cualquier posible proxy http.
            // Ojo pues de saltar este paso podría usar 
            // un proxy configurado en iexplorer
            ftp.Proxy = null;

            // Activar si se dispone de SSL
            ftp.EnableSsl = false;

            // Configuro el buffer a 2 KBytes
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            LocalDirectory = Path.Combine(LocalDirectory, Path.GetFileName(RemoteFile));
            using (FileStream fs = new FileStream(LocalDirectory, FileMode.Create,
                                                  FileAccess.Write, FileShare.None))
            using (Stream strm = ftp.GetResponse().GetResponseStream())
            {
                // Leer del buffer 2kb cada vez
                contentLen = strm.Read(buff, 0, buffLength);

                // mientras haya datos en el buffer...
                while (contentLen != 0)
                {
                    // escribir en el stream del fichero
                    //el contenido del stream de conexión
                    fs.Write(buff, 0, contentLen);
                    contentLen = strm.Read(buff, 0, buffLength);
                }
            }
        }

        private void viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Delete a file by using File class static method...
            //if (System.IO.File.Exists(@"C:\\BDM\\Archivos\\" + Variables.Ruta_pdf))
            //{
            //    // Use a try block to catch IOExceptions, to
            //    // handle the case of the file already being
            //    // opened by another process.
            //    try
            //    {
            //        System.IO.File.Delete(@"C:\\BDM\\Archivos\\" + Variables.Ruta_pdf);
            //    }
            //    catch (System.IO.IOException m)
            //    {
            //        Console.WriteLine(m.Message);
            //        return;
            //    }
            //}
        }

        private void viewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Delete a file by using File class static method...
            //if (System.IO.File.Exists(@"C:\\BDM\\Archivos\\" + Variables.Ruta_pdf))
            //{
            //    // Use a try block to catch IOExceptions, to
            //    // handle the case of the file already being
            //    // opened by another process.
            //    try
            //    {
            //        System.IO.File.Delete(@"C:\\BDM\\Archivos\\" + Variables.Ruta_pdf);
            //    }
            //    catch (System.IO.IOException m)
            //    {
            //        Console.WriteLine(m.Message);
            //        return;
            //    }
            //}
        }
    }
}
