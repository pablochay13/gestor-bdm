using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;

namespace gestor_bdm
{
    public partial class generador : Form
    {
        public generador()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory("C:\\temp\\");
        }

        public void CopyToClipboardWithHeaders(DataGridView _dgv)
        {
            _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = _dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void findImgHM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta\n Ejemplo: NombreHotel-Header.jpg", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "BestDay Media";
            //fdlg.InitialDirectory = @"c:\";
            //fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            //fdlg.FilterIndex = 2;
            //fdlg.RestoreDirectory = true;
            //if (fdlg.ShowDialog() == DialogResult.OK)
            //{
            //    linkHeaderM.Text = fdlg.FileName;
            //    nombreImgHM.Text = Path.GetFileName(linkHeaderM.Text);
            //}

            //variables.RutaImgHM = fdlg.FileName;
            //variables.NombreImgHM = Convert.ToString(nombreImgHM.Text);
        }

        private void uploadImgHM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //try
            //{
            //    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://files.000webhost.com/images/" + variables.NombreImgHM);
            //    request.Method = WebRequestMethods.Ftp.UploadFile;
            //    request.Credentials = new NetworkCredential("bdmediaprueba", "Chay0s1318");
            //    request.UsePassive = true;
            //    request.UseBinary = true;
            //    request.KeepAlive = true;
            //    FileStream stream = File.OpenRead(variables.RutaImgHM);
            //    byte[] buffer = new byte[stream.Length];
            //    stream.Read(buffer, 0, buffer.Length);
            //    stream.Close();
            //    Stream reqStream = request.GetRequestStream();
            //    reqStream.Write(buffer, 0, buffer.Length);
            //    reqStream.Flush();
            //    MessageBox.Show("Imagen subida correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    linkHeaderM.Text = "files.000webhost.com/images/" + variables.NombreImgHM;
            //    nombreImgHM.Text = "";
            //    reqStream.Close();
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void addInfoHM_Click(object sender, EventArgs e)
        {
            try
            {
                if (linkHeaderM.Text == "")
                {
                    MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string linkH, codigoFull = "";
                    linkH = Convert.ToString(linkHeaderM.Text);
                    codigoFull = "<div class='container-fluid bg-img'><img src='" + linkH + "' alt=' ' class='img-responsive img-w'></div>";
                    contentM.Rows.Add(codigoFull);
                    linkHeaderM.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addDescM_Click(object sender, EventArgs e)
        {
            try
            {
                if (descHotelM.Text == "")
                {
                    MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string desc, codigoFull = "";
                    desc = Convert.ToString(descHotelM.Text);
                    codigoFull = "<p class='text-justify'>" + desc + "</p>";
                    contentM.Rows.Add(codigoFull);
                    descHotelM.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findImgBM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta\n Ejemplo: NombreHotel.jpg", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "BestDay Media";
            //fdlg.InitialDirectory = @"c:\";
            //fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            //fdlg.FilterIndex = 2;
            //fdlg.RestoreDirectory = true;
            //if (fdlg.ShowDialog() == DialogResult.OK)
            //{
            //    linkImgM.Text = fdlg.FileName;
            //    nombreImgBM.Text = Path.GetFileName(linkImgM.Text);
            //}

            //variables.RutaImgBM = fdlg.FileName;
            //variables.NombreImgBM = Convert.ToString(nombreImgBM.Text);
        }

        private void uploadImgBM_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://files.000webhost.com/images/" + variables.NombreImgBM);
            //    request.Method = WebRequestMethods.Ftp.UploadFile;
            //    request.Credentials = new NetworkCredential("bdmediaprueba", "Chay0s1318");
            //    request.UsePassive = true;
            //    request.UseBinary = true;
            //    request.KeepAlive = true;
            //    FileStream stream = File.OpenRead(variables.RutaImgBM);
            //    byte[] buffer = new byte[stream.Length];
            //    stream.Read(buffer, 0, buffer.Length);
            //    stream.Close();
            //    Stream reqStream = request.GetRequestStream();
            //    reqStream.Write(buffer, 0, buffer.Length);
            //    reqStream.Flush();
            //    MessageBox.Show("Imagen subida correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    linkImgM.Text = "files.000webhost.com/images/" + variables.NombreImgBM;
            //    nombreImgBM.Text = "";
            //    reqStream.Close();
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            MessageBox.Show("Opción no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addInfoBM_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreHotelM.Text == "" && urlHotelM.Text == "" && destinoHotelM.Text == "")
                {
                    MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string hotel, url, imagen, destino, codigoFull = "";

                    hotel = Convert.ToString(nombreHotelM.Text);
                    url = Convert.ToString(urlHotelM.Text);
                    imagen = Convert.ToString(linkImgM.Text);
                    destino = Convert.ToString(destinoHotelM.Text);

                    codigoFull = "<div class='col-sm-6 col-md-4 hvr-float'><div class='thumbnail caja text-center'><a class='lightbox' href='" + url + "' target='_blank'><img src='" + imagen + "' alt='" + hotel + "'/></a><div class='caption'><h3>" + hotel + "</h3><p>" + destino + "</p><a href='" + url + " ' target='_blank' class='btn-viaja red hvr-buzz-out'>Ver más</a></div></div></div>";

                    contentM.Rows.Add(codigoFull);

                    nombreHotelM.Text = "";
                    urlHotelM.Text = "";
                    linkImgM.Text = "";
                    destinoHotelM.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newM_Click(object sender, EventArgs e)
        {
            //micrositio
            contentM.Rows.Clear();
            contentM.Refresh();
        }

        private void deleteM_Click(object sender, EventArgs e)
        {
            contentM.Rows.RemoveAt(contentM.CurrentRow.Index);
        }

        private void clipboardM_Click(object sender, EventArgs e)
        {
            contentM.SelectAll();
            CopyToClipboardWithHeaders(contentM);
            contentM.ClearSelection();
            MessageBox.Show("Contenido copiado en el portapapeles", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void exportM_Click(object sender, EventArgs e)
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

                for (int i = 0; i < contentM.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < contentM.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = contentM.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = contentM.Rows[i].Cells[j].Value.ToString();
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
                    MessageBox.Show("Archivo generado", "Code Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void add_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (hotel.Text == "" && url.Text == "" && img.Text == "" && destino.Text == "" && corp.Text == "")
                {
                    MessageBox.Show("No puedes dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string hotel1, url1 , url2, imagen1, destino1, codigoVol, codigLiverp = "";

                    hotel1 = Convert.ToString(hotel.Text);
                    url1 = Convert.ToString(url.Text);
                    url2 = Convert.ToString(hotel.Text);
                    imagen1 = Convert.ToString(img.Text);
                    destino1 = Convert.ToString(destino.Text);

                    if(volaris.Checked == true)
                    {
                        codigoVol = "<div class='col-4 hvr-float'><div class='thumbnail caja text-center'><a class='lightbox' href='" + url1 + "' target='_blank'><img src=' " + imagen1 + "  ' alt=' " + hotel1 + "' class='img - fluid' /></a><div class='caption' style='margin: 5px; '><h3> " + hotel1 + "  </h3><p class='text - left'> " + destino1 + "  </p></div></div></div>";

                        grid.Rows.Add(codigoVol);
                    }
                    else if (liverp.Checked==true)
                    {
                        codigLiverp = "<div class='col-lg-4 col-md-12 mb-4'><div class='view overlay z-depth-1-half'><img src=' " + imagen1 + "  ' class='img-fluid' alt=''><div class='mask rgba-white-slight'></div></div><h4 class='my-4 font-weight-bold'> " + hotel1 + "  </h4><p class='grey-text'></p><a href=' " + url2 + "  ' target='_blank'><button type='button' class='btn'>Hotel</button></a><a href=' " + url1 + "  ' target='_blank'><button type='button' class='btn'>Avión + Hotel</button></a></div>";

                        grid.Rows.Add(codigLiverp);
                    }

                    string filename2 = nombreIMGH.Text;
                    string rutaIMG = @"C:\temp\";
                    //string nombreimagen = Convert.ToString(nombreIMGH.Text);
                    preview.Image.Save(rutaIMG + filename2, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Imagen guardada correctamente", "Best Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    hotel.Text = "";
                    url.Text = "";
                    urlLiverp.Text = "";
                    hotel.Text = "";
                    img.Text = "";
                    destino.Text = "";
                    ruta.Text = "";
                    nombreIMGH.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void excel_MouseClick(object sender, MouseEventArgs e)
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

                for (int i = 0; i < contentM.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < contentM.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = contentM.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = contentM.Rows[i].Cells[j].Value.ToString();
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
                    MessageBox.Show("Archivo generado", "Code Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void zip_MouseClick(object sender, MouseEventArgs e)
        {
            string nombre = corp.Text;

            var zipFile = @"C:\temp\" + nombre + ".zip";
            var files = Directory.GetFiles(@"c:\temp");

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                foreach (var fPath in files)
                {
                    archive.CreateEntryFromFile(fPath, Path.GetFileName(fPath));
                }
            }

            MessageBox.Show("Archivo generado", "Code Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void imgbox_MouseClick_1(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Solo imagenes en PNG", "Best Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            string corporativo = Convert.ToString(corp.Text);

            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Imágenes | *.png";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Buscar Imagen";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = ruta.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                if (volaris.Checked == true)
                {
                    ruta.Text = BuscarImagen.FileName;
                    //img.Text = Path.GetFileName(ruta.Text);
                    string nombreIMG = Path.GetFileName(ruta.Text);
                    nombreIMGH.Text = Path.GetFileName(ruta.Text);
                    string rutaF = "_lib/volaris5/Media/" + corporativo + "/" + nombreIMG;

                    img.Text = rutaF;
                    string Direccion = BuscarImagen.FileName;
                    preview.ImageLocation = Direccion;
                    preview.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (liverp.Checked == true)
                {
                    ruta.Text = BuscarImagen.FileName;
                    //img.Text = Path.GetFileName(ruta.Text);
                    string nombreIMG = Path.GetFileName(ruta.Text);
                    nombreIMGH.Text = Path.GetFileName(ruta.Text);
                    string rutaF = "_lib/Liverp/Media/" + corporativo + "/" + nombreIMG;

                    img.Text = rutaF;
                    string Direccion = BuscarImagen.FileName;
                    preview.ImageLocation = Direccion;
                    preview.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void copy_MouseClick(object sender, MouseEventArgs e)
        {
            grid.SelectAll();
            CopyToClipboardWithHeaders(grid);
            grid.ClearSelection();
            MessageBox.Show("Contenido copiado en el portapapeles", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void delete_MouseClick(object sender, MouseEventArgs e)
        {
            grid.Rows.RemoveAt(grid.CurrentRow.Index);
        }

        private void nuevo_MouseClick(object sender, MouseEventArgs e)
        {
            grid.Rows.Clear();
            grid.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.travelsolution.mx/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.travelsolution.mx/");
        }

        private void corp_TextChanged(object sender, EventArgs e)
        {

        }

        private void corp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
