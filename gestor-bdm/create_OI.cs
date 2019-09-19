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
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace gestor_bdm
{
    public partial class create_OI : Form
    {
        public create_OI()
        {
            InitializeComponent();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                //caratula
                PdfPTable caratula = new PdfPTable(1);
                caratula.WidthPercentage = 100;
                PdfPCell caratula_oi = new PdfPCell(new Phrase("CARÁTULA DE ORDEN DE INSERCIÓN NÚMERO: " + OI_text.Text));
                caratula_oi.BackgroundColor = ExtendedColor.YELLOW; //cambiar color cabecera
                caratula_oi.HorizontalAlignment = 1; //0=Izquierda, 1=Centro, 2 = Derecha

                caratula.AddCell(caratula_oi);

                //fecha de firma
                string anio_firma, mes_firma, dia_firma = "";

                anio_firma = fechaFirma_text.Value.Year.ToString();
                mes_firma = fechaFirma_text.Value.Month.ToString();
                dia_firma = fechaFirma_text.Value.Day.ToString();

                PdfPTable fecha_firma = new PdfPTable(1);
                fecha_firma.WidthPercentage = 100;
                PdfPCell fecha_OI = new PdfPCell(new Phrase("FECHA DE FIRMA: " + "Día: " + dia_firma + " " + "Mes: " + " " + mes_firma + " " + "Año: " + " " + anio_firma));
                fecha_OI.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                fecha_firma.AddCell(fecha_OI);

                //vigencia pauta
                string desde_dia, desde_mes, desde_anio, hasta_dia, hasta_mes, hasta_anio = "";

                desde_anio = vigenciaDesde_text.Value.Year.ToString();
                desde_mes = vigenciaDesde_text.Value.Month.ToString();
                desde_dia = vigenciaDesde_text.Value.Day.ToString();

                hasta_anio = vigenciaHasta_text.Value.Year.ToString();
                hasta_mes = vigenciaHasta_text.Value.Month.ToString();
                hasta_dia = vigenciaHasta_text.Value.Day.ToString();

                PdfPTable vigencia_pauta = new PdfPTable(1);
                vigencia_pauta.WidthPercentage = 100;
                PdfPCell vigencia_OI = new PdfPCell(new Phrase("VIGENCIA: " + "Del Día: " + " " + desde_dia + " " + "Mes: " + " " + desde_mes + " " + "Año: " + " " + desde_anio + " " + "Al Día: " + " " + hasta_dia + " " + "Mes: " + " " + hasta_mes + " " + "Año: " + " " + hasta_anio));
                vigencia_OI.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                vigencia_pauta.AddCell(vigencia_OI);

                //clientes
                PdfPTable table_1 = new PdfPTable(4);
                table_1.WidthPercentage = 100;
                PdfPCell cliente = new PdfPCell(new Phrase("EL CLIENTE"));
                cliente.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                cliente.Colspan = 2;

                PdfPCell media = new PdfPCell(new Phrase("MEDIA"));
                media.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                media.Colspan = 2;

                table_1.AddCell(cliente);
                table_1.AddCell(media);

                PdfPCell bottom_cliente_1 = new PdfPCell(new Phrase("Nombre comercial: " + clienteComercial.Text + "\n" + "Razón social contratante: " + clienteRazon.Text + "\n" + "ID Fiscal: " + clienteID.Text + "\n" + "Direccion: " + "\n" + "Calle: " + clienteCalle.Text + "\n" + "Ciudad/País: " + clientePais.Text + "\n" + "Código postal: " + clientePostal.Text));
                bottom_cliente_1.Colspan = 2;
                table_1.AddCell(bottom_cliente_1);

                PdfPCell bottom_media_1 = new PdfPCell(new Phrase("Razón social contratante: " + mediaRazon.Text + "\n" + "ID Fiscal: " + mediaID.Text + "\n" + "Direccion: " + "\n" + "Calle: " + mediaCalle.Text + "\n" + "Ciudad/País: " + mediaPais.Text + "\n" + "Código postal: " + mediaPostal.Text));
                bottom_media_1.Colspan = 2;
                table_1.AddCell(bottom_media_1);


                //clientes_2
                PdfPTable table_2 = new PdfPTable(4);
                table_2.WidthPercentage = 100;
                PdfPCell cliente_2 = new PdfPCell(new Phrase("CONTACTO COMERCIAL"));
                cliente_2.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                cliente_2.Colspan = 2;

                PdfPCell media_2 = new PdfPCell(new Phrase("CONTACTO FACTURACIÓN"));
                media_2.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                media_2.Colspan = 2;

                table_2.AddCell(cliente_2);
                table_2.AddCell(media_2);

                PdfPCell bottom_cliente_2 = new PdfPCell(new Phrase("Nombre: " + comercialNombre.Text + "\n" + "Teléfono: " + comercialTelefono.Text + "\n" + "Correo: " + comercialCorreo.Text));
                bottom_cliente_2.Colspan = 2;
                table_2.AddCell(bottom_cliente_2);

                PdfPCell bottom_media_2 = new PdfPCell(new Phrase("Nombre: " + facturacionNombre.Text + "\n" + "Teléfono: " + facturacionTelefono.Text + "\n" + "Correo: " + facturacionCorreo.Text));
                bottom_media_2.Colspan = 2;
                table_2.AddCell(bottom_media_2);


                //clientes_2
                PdfPTable table_3 = new PdfPTable(4);
                table_3.WidthPercentage = 100;
                PdfPCell cliente_3 = new PdfPCell(new Phrase("CONTACTO DE SEGUIMIENTO DE PAUTA DE MEDIOS"));
                cliente_3.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                cliente_3.Colspan = 2;

                PdfPCell media_3 = new PdfPCell(new Phrase("CONTACTO DE SEGUIMIENTO DE PAUTA DE TOUR DE HOTELDO"));
                media_3.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                media_3.Colspan = 2;

                table_3.AddCell(cliente_3);
                table_3.AddCell(media_3);

                PdfPCell bottom_cliente_3 = new PdfPCell(new Phrase("Nombre: " + seguimientoNombre.Text + "\n" + "Teléfono: " + seguimientoTelefono.Text + "\n" + "Correo: " + seguimientoCorreo.Text));
                bottom_cliente_3.Colspan = 2;
                table_3.AddCell(bottom_cliente_3);

                PdfPCell bottom_media_3 = new PdfPCell(new Phrase("Nombre: " + hotelNombre.Text + "\n" + "Teléfono: " + HotelTelefono.Text + "\n" + "Correo: " + HotelTelefono.Text + "\n" + "*Indicar ciudades requeridas"));
                bottom_media_3.Colspan = 2;
                table_3.AddCell(bottom_media_3);


                //caratula
                string checked_cash_in = "";

                if (cash_in_checkBox.Checked == true)
                {
                    checked_cash_in = "X";
                }

                PdfPTable cash_in = new PdfPTable(1);
                cash_in.WidthPercentage = 100;
                PdfPCell cash_in_oi = new PdfPCell(new Phrase("ESQUEMA COMERCIAL Y FORMA DE PAGO: " + "             " + "Cash IN: " + checked_cash_in));
                cash_in_oi.BackgroundColor = ExtendedColor.YELLOW; //cambiar color cabecera
                cash_in_oi.HorizontalAlignment = 0; //0=Izquierda, 1=Centro, 2 = Derecha

                cash_in.AddCell(cash_in_oi);


                //Marketing Found
                string desde_dia_mf, desde_mes_mf, desde_anio_mf, hasta_dia_mf, hasta_mes_mf, hasta_anio_mf, porcentaje_mf = "";

                desde_anio_mf = dateTimeMF_desde.Value.Year.ToString();
                desde_mes_mf = dateTimeMF_desde.Value.Month.ToString();
                desde_dia_mf = dateTimeMF_desde.Value.Day.ToString();

                hasta_anio_mf = dateTimeMF_hasta.Value.Year.ToString();
                hasta_mes_mf = dateTimeMF_hasta.Value.Month.ToString();
                hasta_dia_mf = dateTimeMF_hasta.Value.Day.ToString();

                string checked_mf_oi = "";

                if (checkBoxMF.Checked == true)
                {
                    checked_mf_oi = "X";
                }

                PdfPTable vigencia_pauta_mf = new PdfPTable(1);
                vigencia_pauta_mf.WidthPercentage = 100;
                PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase("1. MARKETING FUND: " + " " + checked_mf_oi + " " + "Del" + " " + porcentajeMF_box.Text + "%" + " " + "De Fecha: " + " " + desde_dia_mf + " " + "Mes: " + " " + desde_mes_mf + " " + "Año: " + " " + desde_anio_mf + " " + "Hasta Fecha: " + " " + hasta_dia_mf + " " + "Mes: " + " " + hasta_mes_mf + " " + "Año: " + " " + hasta_anio_mf));
                vigencia_OI_mf.BackgroundColor = ExtendedColor.YELLOW; //cambiar color cabecera

                vigencia_pauta_mf.AddCell(vigencia_OI_mf);


                //Forma de calculo
                string pago_emitido_io = "";
                string produccion_io_c = "";

                if (checkProduccion.Checked == true)
                {
                    produccion_io_c = "X";
                }

                if (checkPagos.Checked == true)
                {
                    pago_emitido_io = "X";
                }

                PdfPTable forma_calculo = new PdfPTable(1);
                forma_calculo.WidthPercentage = 100;
                PdfPCell forma_calculo_io = new PdfPCell(new Phrase("ESQUEMA COMERCIAL Y FORMA DE PAGO: " + "             " + "Cash IN: " + produccion_io_c));
                forma_calculo_io.BackgroundColor = ExtendedColor.YELLOW; //cambiar color cabecera

                forma_calculo.AddCell(forma_calculo_io);


                //Facturacion mensual
                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;

                PdfPCell cell = new PdfPCell(new Phrase("VÏA FACTURACIÖN MENSUAL"));
                cell.Rowspan = 12;
                cell.Colspan = 1;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Total con IVA: "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("     "));
                table.AddCell(cell);


                //forma de pago
                PdfPCell forma_pago_table = new PdfPCell(new Phrase("FORMA DE PAGO"));
                table.AddCell(forma_pago_table);
                forma_pago_table = new PdfPCell(new Phrase("Transferencia Bancaria: "));
                table.AddCell(forma_pago_table);
                forma_pago_table = new PdfPCell(new Phrase("Compensación y Facturas: "));
                table.AddCell(forma_pago_table);


                //condiciones comerciales
                PdfPTable table_c_C = new PdfPTable(3);
                table_c_C.WidthPercentage = 100;

                PdfPCell cell_c_C = new PdfPCell(new Phrase("CONDICIONES COMERCIALES"));
                table_c_C.AddCell(cell_c_C);

                cell_c_C = new PdfPCell(new Phrase("          "));
                cell_c_C.Rowspan = 2;
                cell_c_C.Colspan = 2;
                table_c_C.AddCell(cell_c_C);

                cell_c_C = new PdfPCell(new Phrase(" "));
                table_c_C.AddCell(cell_c_C);


                //datos generales
                PdfPTable datos_C_c = new PdfPTable(1);
                datos_C_c.WidthPercentage = 100;
                PdfPCell datos_IO_CC = new PdfPCell(new Phrase("- El CLIENTE conoce, se sujeta y obliga al cumplimiento de los Términos y Condiciones Best Travel Media establecidos en el Reverso de la presente Orden de Inserción y la Pauta de Medios. " + "\n" + "- El CLIENTE manifiesta bajo protesta de decir verdad que cuenta con la capacidad y facultades necesarias para obligar a su representada al cumplimiento de las obligaciones establecidas en los presentes Términos y  ondiciones Best Travel Media. " + "\n" + " - La Razón Social Contratante señalada en la carátula bajo protesta de decir verdad, manifiesta que actúa en nombre y representación de las propiedades señaladas en el Anexo A de la presente Orden de Inserción."));
                datos_IO_CC.BackgroundColor = ExtendedColor.YELLOW; //cambiar color cabecera
                datos_IO_CC.HorizontalAlignment = 1; //0=Izquierda, 1=Centro, 2 = Derecha

                datos_C_c.AddCell(datos_IO_CC);


                //parte final
                PdfPTable table_4 = new PdfPTable(4);
                table_4.WidthPercentage = 100;
                PdfPCell cliente_4 = new PdfPCell(new Phrase("CONTACTO DE SEGUIMIENTO DE PAUTA DE MEDIOS"));
                cliente_4.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                cliente_4.Colspan = 2;

                PdfPCell media_4 = new PdfPCell(new Phrase("CONTACTO DE SEGUIMIENTO DE PAUTA DE TOUR DE HOTELDO"));
                media_4.BackgroundColor = ExtendedColor.ORANGE; //cambiar color cabecera
                media_4.Colspan = 2;

                table_4.AddCell(cliente_4);
                table_4.AddCell(media_4);

                PdfPCell bottom_cliente_4 = new PdfPCell(new Phrase("FIRMA: "));
                table_4.AddCell(bottom_cliente_4);

                PdfPCell bottom_media_4 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_4);

                PdfPCell bottom_cliente_5 = new PdfPCell(new Phrase("FIRMA: "));
                table_4.AddCell(bottom_cliente_5);

                PdfPCell bottom_media_5 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_5);




                PdfPCell bottom_cliente_6 = new PdfPCell(new Phrase("NOMBRE: "));
                table_4.AddCell(bottom_cliente_6);

                PdfPCell bottom_media_6 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_6);

                PdfPCell bottom_cliente_7 = new PdfPCell(new Phrase("NOMBRE: "));
                table_4.AddCell(bottom_cliente_7);

                PdfPCell bottom_media_7 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_7);




                PdfPCell bottom_cliente_8 = new PdfPCell(new Phrase("CARGO: "));
                table_4.AddCell(bottom_cliente_8);

                PdfPCell bottom_media_8 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_8);

                PdfPCell bottom_cliente_9 = new PdfPCell(new Phrase("CARGO: "));
                table_4.AddCell(bottom_cliente_9);

                PdfPCell bottom_media_9 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_9);




                PdfPCell bottom_cliente_10 = new PdfPCell(new Phrase("LUGAR: "));
                table_4.AddCell(bottom_cliente_10);

                PdfPCell bottom_media_10 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_10);

                PdfPCell bottom_cliente_11 = new PdfPCell(new Phrase("LUGAR: "));
                table_4.AddCell(bottom_cliente_11);

                PdfPCell bottom_media_11 = new PdfPCell(new Phrase(" "));
                table_4.AddCell(bottom_media_11);


                //segunda pagina
                //agregando una imagen
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:/log/0002.jpg");
                imagen.BorderWidth = 0;
                imagen.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                imagen.ScaleToFit(720f, 755.25f);



                //Exporting to PDF
                string folderPath = @"C:\Log\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "example.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.LETTER, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(caratula);
                    pdfDoc.Add(fecha_firma);
                    pdfDoc.Add(vigencia_pauta);

                    //pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_1);
                    pdfDoc.Add(new Paragraph(" "));
                    pdfDoc.Add(table_2);
                    pdfDoc.Add(table_3);
                    pdfDoc.Add(new Paragraph(" "));
                    pdfDoc.Add(cash_in);
                    pdfDoc.Add(vigencia_pauta_mf);
                    pdfDoc.Add(new Paragraph(" "));
                    pdfDoc.Add(table);
                    pdfDoc.Add(table_c_C);
                    pdfDoc.Add(datos_C_c);
                    pdfDoc.Add(table_4);
                    pdfDoc.Add(imagen);

                    pdfDoc.Close();

                    stream.Close();
                }
                MessageBox.Show("Documento creado.", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
