﻿using System;
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

            facturadoEne.SelectedIndex = 12;
            facturadoFeb.SelectedIndex = 12;
            facturadoMar.SelectedIndex = 12;
            facturadoAbr.SelectedIndex = 12;
            facturadoMay.SelectedIndex = 12;
            facturadoJun.SelectedIndex = 12;
            facturadoJul.SelectedIndex = 12;
            facturadoAgo.SelectedIndex = 12;
            facturadoSep.SelectedIndex = 12;
            facturadoOct.SelectedIndex = 12;
            facturadoNov.SelectedIndex = 12;
            facturadoDic.SelectedIndex = 12;

            comboEne.SelectedIndex = 2;
            comboFeb.SelectedIndex = 2;
            comboMar.SelectedIndex = 2;
            comboAbr.SelectedIndex = 2;
            comboMay.SelectedIndex = 2;
            comboJun.SelectedIndex = 2;
            comboJul.SelectedIndex = 2;
            comboAgo.SelectedIndex = 2;
            comboSep.SelectedIndex = 2;
            comboOct.SelectedIndex = 2;
            comboNov.SelectedIndex = 2;
            comboBoxDic.SelectedIndex = 2;

            System.IO.Directory.CreateDirectory("C:\\PDF-OI\\");
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                //caratula
                PdfPTable caratula = new PdfPTable(1);
                caratula.WidthPercentage = 100;
                PdfPCell caratula_oi = new PdfPCell(new Phrase(string.Format("FOLIO DE REFERENCIA: " + OI_text.Text + "     " + "ORDEN DE INSERCIÓN" + "     " + "FECHA: " + DateTime.Now), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //pdfDoc.Add(new Paragraph(string.Format("Vendedor: " + Label1.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD)));
                caratula_oi.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                caratula_oi.HorizontalAlignment = 1; //0=Izquierda, 1=Centro, 2 = Derecha

                caratula.AddCell(caratula_oi);

                //fecha de firma
                string anio_firma, mes_firma, dia_firma = "";

                anio_firma = fechaFirma_text.Value.Year.ToString();
                mes_firma = fechaFirma_text.Value.Month.ToString();
                dia_firma = fechaFirma_text.Value.Day.ToString();


                if(mes_firma == "1")
                {
                    mes_firma = "Enero";
                }

                else if (mes_firma == "2")
                {
                    mes_firma = "Febrero";
                }

                else if (mes_firma == "3")
                {
                    mes_firma = "Marzo";
                }

                else if (mes_firma == "4")
                {
                    mes_firma = "Abril";
                }

                else if (mes_firma == "5")
                {
                    mes_firma = "Mayo";
                }

                else if (mes_firma == "6")
                {
                    mes_firma = "Junio";
                }

                else if (mes_firma == "7")
                {
                    mes_firma = "Julio";
                }

                else if (mes_firma == "8")
                {
                    mes_firma = "Agosto";
                }

                else if (mes_firma == "9")
                {
                    mes_firma = "Septiembre";
                }

                else if (mes_firma == "10")
                {
                    mes_firma = "Octubre";
                }

                else if (mes_firma == "11")
                {
                    mes_firma = "Noviembre";
                }

                else if (mes_firma == "12")
                {
                    mes_firma = "Diciembre";
                }

                PdfPTable fecha_firma = new PdfPTable(4);
                fecha_firma.WidthPercentage = 100;
                PdfPCell fecha_OI = new PdfPCell(new Phrase(string.Format("FECHA DE FIRMA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                fecha_OI.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                fecha_firma.AddCell(fecha_OI);

                fecha_OI = new PdfPCell(new Phrase(string.Format("Día: " + dia_firma + "     " + "Mes: " + " " + mes_firma + "     " + "Año: " + " " + anio_firma), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                fecha_OI.Colspan = 3;
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

                //desde

                if (desde_mes == "1")
                {
                    desde_mes = "Enero";
                }

                else if (desde_mes == "2")
                {
                    desde_mes = "Febrero";
                }

                else if (desde_mes == "3")
                {
                    desde_mes = "Marzo";
                }

                else if (desde_mes == "4")
                {
                    desde_mes = "Abril";
                }

                else if (desde_mes == "5")
                {
                    desde_mes = "Mayo";
                }

                else if (desde_mes == "6")
                {
                    desde_mes = "Junio";
                }

                else if (desde_mes == "7")
                {
                    desde_mes = "Julio";
                }

                else if (desde_mes == "8")
                {
                    desde_mes = "Agosto";
                }

                else if (desde_mes == "9")
                {
                    desde_mes = "Septiembre";
                }

                else if (desde_mes == "10")
                {
                    desde_mes = "Octubre";
                }

                else if (desde_mes == "11")
                {
                    desde_mes = "Noviembre";
                }

                else if (desde_mes == "12")
                {
                    desde_mes = "Diciembre";
                }

                //Hasta

                if (hasta_mes == "1")
                {
                    hasta_mes = "Enero";
                }

                else if (hasta_mes == "2")
                {
                    hasta_mes = "Febrero";
                }

                else if (hasta_mes == "3")
                {
                    hasta_mes = "Marzo";
                }

                else if (hasta_mes == "4")
                {
                    hasta_mes = "Abril";
                }

                else if (hasta_mes == "5")
                {
                    hasta_mes = "Mayo";
                }

                else if (hasta_mes == "6")
                {
                    hasta_mes = "Junio";
                }

                else if (hasta_mes == "7")
                {
                    hasta_mes = "Julio";
                }

                else if (hasta_mes == "8")
                {
                    hasta_mes = "Agosto";
                }

                else if (hasta_mes == "9")
                {
                    hasta_mes = "Septiembre";
                }

                else if (hasta_mes == "10")
                {
                    hasta_mes = "Octubre";
                }

                else if (hasta_mes == "11")
                {
                    hasta_mes = "Noviembre";
                }

                else if (hasta_mes == "12")
                {
                    hasta_mes = "Diciembre";
                }

                PdfPTable vigencia_pauta = new PdfPTable(4);
                vigencia_pauta.WidthPercentage = 100;
                PdfPCell vigencia_OI = new PdfPCell(new Phrase(string.Format("VIGENCIA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                vigencia_OI.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera

                vigencia_pauta.AddCell(vigencia_OI);

                vigencia_OI = new PdfPCell(new Phrase(string.Format("Del Día: " + " " + desde_dia + "   " + "Mes: " + " " + desde_mes + "   " + "Año: " + " " + desde_anio + "   " + "Al Día: " + " " + hasta_dia + "   " + "Mes: " + " " + hasta_mes + "   " + "Año: " + " " + hasta_anio), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                vigencia_OI.Colspan = 3;
                vigencia_OI.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                vigencia_pauta.AddCell(vigencia_OI);

                //clientes
                PdfPTable table_1 = new PdfPTable(4);
                table_1.WidthPercentage = 100;
                PdfPCell cliente = new PdfPCell(new Phrase(string.Format("EL CLIENTE"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cliente.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                cliente.HorizontalAlignment = 1;
                cliente.Colspan = 2;

                PdfPCell media = new PdfPCell(new Phrase(string.Format("BEST TRAVEL MEDIA"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                media.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                media.HorizontalAlignment = 1;
                media.Colspan = 2;

                table_1.AddCell(cliente);
                table_1.AddCell(media);

                PdfPCell bottom_cliente_1 = new PdfPCell(new Phrase(string.Format("Nombre comercial: " + clienteComercial.Text + "\n" + "Razón social contratante: " + clienteRazon.Text + "\n" + "ID Fiscal: " + clienteID.Text + "\n" + "Direccion: " + "\n" + "Calle: " + clienteCalle.Text + "\n" + "Ciudad/País: " + clientePais.Text + "\n" + "Código postal: " + clientePostal.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_cliente_1.Colspan = 2;
                table_1.AddCell(bottom_cliente_1);

                PdfPCell bottom_media_1 = new PdfPCell(new Phrase(string.Format("Razón Social Contratante: " + mediaRazon.Text + "\n" + "ID Fiscal: " + mediaID.Text + "\n" + "Direccion: " + "\n" + "Calle: " + mediaCalle.Text + "\n" + "Ciudad/País: " + mediaPais.Text + "\n" + "Código postal: " + mediaPostal.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_1.Colspan = 2;
                table_1.AddCell(bottom_media_1);


                //clientes_2
                PdfPTable table_2 = new PdfPTable(4);
                table_2.WidthPercentage = 100;
                PdfPCell cliente_2 = new PdfPCell(new Phrase(string.Format("Contacto de Cuentas por Pagar"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cliente_2.BackgroundColor = new BaseColor(6, 61, 150); 
                cliente_2.HorizontalAlignment = 1; 
                cliente_2.Colspan = 2;

                PdfPCell media_2 = new PdfPCell(new Phrase(string.Format("Contacto de Cuentas por Cobrar"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                media_2.BackgroundColor = new BaseColor(6, 61, 150); 
                media_2.HorizontalAlignment = 1; 
                media_2.Colspan = 2;

                table_2.AddCell(cliente_2);
                table_2.AddCell(media_2);

                PdfPCell bottom_cliente_2 = new PdfPCell(new Phrase(string.Format("Nombre: " + comercialNombre.Text + "\n" + "Teléfono: " + comercialTelefono.Text + "\n" + "Correo: " + comercialCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_cliente_2.Colspan = 2;
                table_2.AddCell(bottom_cliente_2);

                PdfPCell bottom_media_2 = new PdfPCell(new Phrase(string.Format("Nombre: " + facturacionNombre.Text + "\n" + "Teléfono: " + facturacionTelefono.Text + "\n" + "Correo: " + facturacionCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_2.Colspan = 2;
                table_2.AddCell(bottom_media_2);







                //clientes_2
                PdfPTable table_3 = new PdfPTable(4);
                table_3.WidthPercentage = 100;
                PdfPCell cliente_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial: " + seguimientoNombre.Text + "\n" + "Teléfono: " + seguimientoTelefono.Text + " " + "Correo: " + seguimientoCorreo.Text + "\n" + "\n" + "Contacto Pauta Medios: " + seguimientoNombre.Text + "\n" + "Teléfono: " + seguimientoTelefono.Text + " " + "Correo: " + seguimientoCorreo.Text + "\n" + "\n" + "Contacto Tour HotelDO: " + seguimientoNombre.Text + "\n" + "Teléfono: " + seguimientoTelefono.Text + " " + "Correo: " + seguimientoCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cliente_3.Colspan = 2;

                PdfPCell media_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial: " + hotelNombre.Text + "\n" + "Teléfono: " + HotelTelefono.Text + " " + "Correo: " + HotelTelefono.Text + "\n" + "\n" + "Contacto Pauta Medios: " + hotelNombre.Text + "\n" + "Teléfono: " + HotelTelefono.Text + " " + "Correo: " + HotelTelefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                media_3.Colspan = 2;

                table_3.AddCell(cliente_3);

                table_3.AddCell(media_3);




                //caratula
                string checked_cash_in = "";


                PdfPTable cash_in_1 = new PdfPTable(4);
                cash_in_1.WidthPercentage = 100;


                PdfPCell facturado_por = new PdfPCell(new Phrase(string.Format("FACTURAR POR "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                facturado_por.BackgroundColor = new BaseColor(6, 61, 150);

                cash_in_1.AddCell(facturado_por);

                PdfPCell facturado_por_2 = new PdfPCell(new Phrase(string.Format("Corporativo " + " " + "Hotel " + " "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                facturado_por_2.Colspan = 3;
                facturado_por_2.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                cash_in_1.AddCell(facturado_por_2);


                PdfPTable cash_in = new PdfPTable(1);
                cash_in.WidthPercentage = 100;

                PdfPCell cash_in_oi = new PdfPCell(new Phrase(string.Format("ESQUEMA COMERCIAL Y FORMA DE PAGO: " + "             " + "Cash IN: " + checked_cash_in), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cash_in_oi.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                cash_in_oi.HorizontalAlignment = 0; //0=Izquierda, 1=Centro, 2 = Derecha

                cash_in.AddCell(cash_in_oi);
                 

                //Marketing Found
                string desde_dia_mf, desde_mes_mf, desde_anio_mf, hasta_dia_mf, hasta_mes_mf, hasta_anio_mf, porcentaje_mf = "";

                string checked_mf_oi = "";

                desde_anio_mf = dateTimeMF_desde.Value.Year.ToString();
                desde_mes_mf = dateTimeMF_desde.Value.Month.ToString();
                desde_dia_mf = dateTimeMF_desde.Value.Day.ToString();

                hasta_anio_mf = dateTimeMF_hasta.Value.Year.ToString();
                hasta_mes_mf = dateTimeMF_hasta.Value.Month.ToString();
                hasta_dia_mf = dateTimeMF_hasta.Value.Day.ToString();

                //desde
                if (desde_mes_mf == "1")
                {
                    desde_mes_mf = "Enero";
                }

                else if (desde_mes_mf == "2")
                {
                    desde_mes_mf = "Febrero";
                }

                else if (desde_mes_mf == "3")
                {
                    desde_mes_mf = "Marzo";
                }

                else if (desde_mes_mf == "4")
                {
                    desde_mes_mf = "Abril";
                }

                else if (desde_mes_mf == "5")
                {
                    desde_mes_mf = "Mayo";
                }

                else if (desde_mes_mf == "6")
                {
                    desde_mes_mf = "Junio";
                }

                else if (desde_mes_mf == "7")
                {
                    desde_mes_mf = "Julio";
                }

                else if (desde_mes_mf == "8")
                {
                    desde_mes_mf = "Agosto";
                }

                else if (desde_mes_mf == "9")
                {
                    desde_mes_mf = "Septiembre";
                }

                else if (desde_mes_mf == "10")
                {
                    desde_mes_mf = "Octubre";
                }

                else if (desde_mes_mf == "11")
                {
                    desde_mes_mf = "Noviembre";
                }

                else if (desde_mes_mf == "12")
                {
                    desde_mes_mf = "Diciembre";
                }

                //hasta
                if (hasta_mes_mf == "1")
                {
                    hasta_mes_mf = "Enero";
                }

                else if (hasta_mes_mf == "2")
                {
                    hasta_mes_mf = "Febrero";
                }

                else if (hasta_mes_mf == "3")
                {
                    hasta_mes_mf = "Marzo";
                }

                else if (hasta_mes_mf == "4")
                {
                    hasta_mes_mf = "Abril";
                }

                else if (hasta_mes_mf == "5")
                {
                    hasta_mes_mf = "Mayo";
                }

                else if (hasta_mes_mf == "6")
                {
                    hasta_mes_mf = "Junio";
                }

                else if (hasta_mes_mf == "7")
                {
                    hasta_mes_mf = "Julio";
                }

                else if (hasta_mes_mf == "8")
                {
                    hasta_mes_mf = "Agosto";
                }

                else if (hasta_mes_mf == "9")
                {
                    hasta_mes_mf = "Septiembre";
                }

                else if (hasta_mes_mf == "10")
                {
                    hasta_mes_mf = "Octubre";
                }

                else if (hasta_mes_mf == "11")
                {
                    hasta_mes_mf = "Noviembre";
                }

                else if (hasta_mes_mf == "12")
                {
                    hasta_mes_mf = "Diciembre";
                }

                PdfPTable vigencia_pauta_mf = new PdfPTable(4);
                vigencia_pauta_mf.WidthPercentage = 100;

                if (checkBoxMF.Checked == true)
                {
                    checked_mf_oi = "X";

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. MARKETING FUND: " + " " + checked_mf_oi), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    vigencia_OI_mf.BackgroundColor = new BaseColor(6, 61, 150);

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf);

                    PdfPCell vigencia_OI_mf_2 = new PdfPCell(new Phrase(string.Format("   " + porcentajeMF_box.Text + "%" + " " + "De Fecha: " + " " + desde_dia_mf + " " + "Mes: " + " " + desde_mes_mf + " " + "Año: " + " " + desde_anio_mf + " " + "Hasta Fecha: " + " " + hasta_dia_mf + " " + "Mes: " + " " + hasta_mes_mf + " " + "Año: " + " " + hasta_anio_mf), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    vigencia_OI_mf_2.Colspan = 3;
                    vigencia_OI_mf_2.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf_2);
                }

                else if (checkBoxMF.Checked == false)
                {
                    checked_mf_oi = " ";

                    desde_anio_mf = " ";
                    desde_mes_mf = " ";
                    desde_dia_mf = " ";

                    hasta_anio_mf = " ";
                    hasta_mes_mf = " ";
                    hasta_dia_mf = " ";

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. MARKETING FUND: " + "  "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    vigencia_OI_mf.BackgroundColor = new BaseColor(6, 61, 150);

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf);

                    PdfPCell vigencia_OI_mf_2 = new PdfPCell(new Phrase(string.Format("   " + porcentajeMF_box.Text + "%" + " " + "De Fecha: " + " " + desde_dia_mf + " " + "Mes: " + " " + desde_mes_mf + " " + "Año: " + " " + desde_anio_mf + " " + "Hasta Fecha: " + " " + hasta_dia_mf + " " + "Mes: " + " " + hasta_mes_mf + " " + "Año: " + " " + hasta_anio_mf), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    vigencia_OI_mf_2.Colspan = 3;
                    vigencia_OI_mf_2.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf_2);
                }

                //Forma de calculo
                PdfPTable forma_calculo = new PdfPTable(4);
                forma_calculo.WidthPercentage = 100;

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

                PdfPCell cell_fc_1 = new PdfPCell(new Phrase(string.Format("FORMA DE CALCULO"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fc_1.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                cell_fc_1.Colspan = 1;

                forma_calculo.AddCell(cell_fc_1);

                PdfPCell cell_fc_2 = new PdfPCell(new Phrase(string.Format("Producción: " + produccion_io_c + "     " + "Pagos Emitidos " + pago_emitido_io), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell_fc_2.Colspan = 3;

                forma_calculo.AddCell(cell_fc_2);


                //Facturacion mensual
                string facturacion_mensual = " ";

                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;

                PdfPCell cell = new PdfPCell(new Phrase(string.Format("\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "2. VÍA FACTURACIÓN MENSUAL"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell.Rowspan = 13;
                cell.Colspan = 1;
                cell.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(cell);

                PdfPCell cell_fm_1 = new PdfPCell(new Phrase(string.Format("Mes"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_1.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_1);

                PdfPCell cell_fm_2 = new PdfPCell(new Phrase(string.Format("Importe"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_2.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_2);


                PdfPCell cell_fm_5 = new PdfPCell(new Phrase(string.Format("Divisa"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_5.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_5);


                PdfPCell cell_fm_4 = new PdfPCell(new Phrase(string.Format("Información"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_4.Colspan = 3;
                cell_fm_4.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_4);

                //ENE
                cell = new PdfPCell(new Phrase(string.Format(facturadoEne.Text + " " + anioEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //FEB
                cell = new PdfPCell(new Phrase(string.Format(facturadoFeb.Text + " " + anioFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //MAR
                cell = new PdfPCell(new Phrase(string.Format(facturadoMar.Text + " " + anioMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //ABR
                cell = new PdfPCell(new Phrase(string.Format(facturadoAbr.Text + " " + anioAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //MAY
                cell = new PdfPCell(new Phrase(string.Format(facturadoMay.Text) + " " + anioMay.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //JUN
                cell = new PdfPCell(new Phrase(string.Format(facturadoJun.Text + " " + anioJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //JUL
                cell = new PdfPCell(new Phrase(string.Format(facturadoJul.Text + " " + anioJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //AGO
                cell = new PdfPCell(new Phrase(string.Format(facturadoAgo.Text + " " + anioAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //SEP
                cell = new PdfPCell(new Phrase(string.Format(facturadoSep.Text + " " + anioSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //OCT
                cell = new PdfPCell(new Phrase(string.Format(facturadoOct.Text + " " + anioOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //NOV
                cell = new PdfPCell(new Phrase(string.Format(facturadoNov.Text + " " + anioNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);


                cell = new PdfPCell(new Phrase(string.Format(comboNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //DIC
                cell = new PdfPCell(new Phrase(string.Format(facturadoDic.Text + " " + anioDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textDocDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(comboBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                PdfPCell cell_fm_3 = new PdfPCell(new Phrase(string.Format("Total con IVA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_3.Colspan = 2;
                cell_fm_3.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(cell_fm_3);


                int cant_ene, cant_feb, cant_mar, cant_abr, cant_may, cant_jun, cant_jul, cant_ago, cant_sep, cant_oct, cant_nov, cant_dic = 0;

                if (string.IsNullOrEmpty(textDocEne.Text))
                {
                    cant_ene = 0;
                }
                else
                {
                    cant_ene = Convert.ToInt32(textDocEne.Text);
                }


                if (string.IsNullOrEmpty(textDocFeb.Text))
                {
                    cant_feb = 0;
                }
                else
                {
                    cant_feb = Convert.ToInt32(textDocFeb.Text);
                }


                if (string.IsNullOrEmpty(textDocMar.Text))
                {
                    cant_mar = 0;
                }
                else
                {
                    cant_mar = Convert.ToInt32(textDocMar.Text);
                }


                if (string.IsNullOrEmpty(textDocAbr.Text))
                {
                    cant_abr = 0;
                }
                else
                {
                    cant_abr = Convert.ToInt32(textDocAbr.Text);
                }


                if (string.IsNullOrEmpty(textDocMay.Text))
                {
                    cant_may = 0;
                }
                else
                {
                    cant_may = Convert.ToInt32(textDocMay.Text);
                }


                if (string.IsNullOrEmpty(textDocJun.Text))
                {
                    cant_jun = 0;
                }
                else
                {
                    cant_jun = Convert.ToInt32(textDocJun.Text);
                }


                if (string.IsNullOrEmpty(textDocJul.Text))
                {
                    cant_jul = 0;
                }
                else
                {
                    cant_jul = Convert.ToInt32(textDocJul.Text);
                }


                if (string.IsNullOrEmpty(textDocAgo.Text))
                {
                    cant_ago = 0;
                }
                else
                {
                    cant_ago = Convert.ToInt32(textDocAgo.Text);
                }


                if (string.IsNullOrEmpty(textDocSep.Text))
                {
                    cant_sep = 0;
                }
                else
                {
                    cant_sep = Convert.ToInt32(textDocSep.Text);
                }


                if (string.IsNullOrEmpty(textDocOct.Text))
                {
                    cant_oct = 0;
                }
                else
                {
                    cant_oct = Convert.ToInt32(textDocOct.Text);
                }


                if (string.IsNullOrEmpty(textDocNov.Text))
                {
                    cant_nov = 0;
                }
                else
                {
                    cant_nov = Convert.ToInt32(textDocNov.Text);
                }


                if (string.IsNullOrEmpty(textDocDic.Text))
                {
                    cant_dic = 0;
                }
                else
                {
                    cant_dic = Convert.ToInt32(textDocDic.Text);
                }


                int total = 0;

                total = cant_ene + cant_feb + cant_mar + cant_abr + cant_may + cant_jun + cant_jul + cant_ago + cant_sep + cant_oct + cant_nov + cant_dic;


                cell = new PdfPCell(new Phrase(string.Format(Convert.ToString(total + " " + comboEne.Text)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 5;
                table.AddCell(cell);

                //cell = new PdfPCell(new Phrase(string.Format("     "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                //table.AddCell(cell);


                //forma de pago
                PdfPCell forma_pago_table = new PdfPCell(new Phrase(string.Format("FORMA DE PAGO"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                forma_pago_table.Colspan = 2;
                forma_pago_table.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(forma_pago_table);

                string trans_banca_c = " ";

                string compen_fact_c = " ";

                if (c_c_facturas.Checked == true)
                {
                    compen_fact_c = "X";
                }

                if(c_t_bancaria.Checked == true)
                {
                    trans_banca_c = "X";
                }

                forma_pago_table = new PdfPCell(new Phrase(string.Format("Transferencia Bancaria: " + trans_banca_c), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                forma_pago_table.Colspan = 2;
                table.AddCell(forma_pago_table);

                forma_pago_table = new PdfPCell(new Phrase(string.Format("Compensación y Facturas: " + compen_fact_c), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                forma_pago_table.Colspan = 3;
                table.AddCell(forma_pago_table);


                //condiciones comerciales
                PdfPTable table_c_C = new PdfPTable(3);
                table_c_C.WidthPercentage = 100;

                PdfPCell cell_c_C = new PdfPCell(new Phrase(string.Format("CONDICIONES COMERCIALES"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cell_c_C.Rowspan = 2;
                //cell_c_C.Colspan = 2;
                cell_c_C.BackgroundColor = new BaseColor(6, 61, 150);
                table_c_C.AddCell(cell_c_C);

                cell_c_C = new PdfPCell(new Phrase(textCondiciones.Text));
                cell_c_C.Rowspan = 2;
                cell_c_C.Colspan = 2;
                table_c_C.AddCell(cell_c_C);

                cell_c_C = new PdfPCell(new Phrase(" "));
                cell_c_C.BackgroundColor = new BaseColor(6, 61, 150);
                table_c_C.AddCell(cell_c_C);


                //datos generales
                PdfPTable datos_C_c = new PdfPTable(1);
                datos_C_c.WidthPercentage = 100;
                PdfPCell datos_IO_CC = new PdfPCell(new Phrase(string.Format("- El CLIENTE conoce, se sujeta y obliga al cumplimiento de los Términos y Condiciones Best Travel Media establecidos en el Reverso de la presente Orden de Inserción y la Pauta de Medios. " + "\n" + "- El CLIENTE manifiesta bajo protesta de decir verdad que cuenta con la capacidad y facultades necesarias para obligar a su representada al cumplimiento de las obligaciones establecidas en los presentes Términos y  ondiciones Best Travel Media. " + "\n" + " - La Razón Social Contratante señalada en la carátula bajo protesta de decir verdad, manifiesta que actúa en nombre y representación de las propiedades señaladas en el Anexo A de la presente Orden de Inserción."), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                datos_IO_CC.HorizontalAlignment = 0; //0=Izquierda, 1=Centro, 2 = Derecha

                datos_C_c.AddCell(datos_IO_CC);


                //parte final
                PdfPTable table_4 = new PdfPTable(6);
                table_4.WidthPercentage = 100;

                PdfPCell cliente_4 = new PdfPCell(new Phrase(string.Format("EL CLIENTE"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cliente_4.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                cliente_4.Colspan = 3;
                cliente_4.HorizontalAlignment = 1;

                PdfPCell media_4 = new PdfPCell(new Phrase(string.Format("BEST TRAVEL MEDIA"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                media_4.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                media_4.Colspan = 3;
                media_4.HorizontalAlignment = 1;

                table_4.AddCell(cliente_4);
                table_4.AddCell(media_4);

                PdfPCell bottom_cliente_4 = new PdfPCell(new Phrase(string.Format("FIRMA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_4.Colspan = 1;
                bottom_cliente_4.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_4);

                PdfPCell bottom_media_4 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_4.Colspan = 2;
                table_4.AddCell(bottom_media_4);

                PdfPCell bottom_cliente_5 = new PdfPCell(new Phrase(string.Format("FIRMA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_5.Colspan = 1;
                bottom_cliente_5.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_5);

                PdfPCell bottom_media_5 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_5.Colspan = 2;
                table_4.AddCell(bottom_media_5);

                PdfPCell bottom_cliente_6 = new PdfPCell(new Phrase(string.Format("NOMBRE: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_6.Colspan = 1;
                bottom_cliente_6.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_6);
                 
                PdfPCell bottom_media_6 = new PdfPCell(new Phrase(string.Format(textNombre_c.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_6.Colspan = 2;
                table_4.AddCell(bottom_media_6);

                PdfPCell bottom_cliente_7 = new PdfPCell(new Phrase(string.Format("NOMBRE: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_7.Colspan = 1;
                bottom_cliente_7.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_7);

                PdfPCell bottom_media_7 = new PdfPCell(new Phrase(string.Format(textNombre_m.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_7.Colspan = 2;
                table_4.AddCell(bottom_media_7);

                PdfPCell bottom_cliente_8 = new PdfPCell(new Phrase(string.Format("CARGO: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_8.Colspan = 1;
                bottom_cliente_8.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_8);

                PdfPCell bottom_media_8 = new PdfPCell(new Phrase(string.Format(textCargo_c.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_8.Colspan = 2;
                table_4.AddCell(bottom_media_8);

                PdfPCell bottom_cliente_9 = new PdfPCell(new Phrase(string.Format("CARGO: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_9.Colspan = 1;
                bottom_cliente_9.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_9);

                PdfPCell bottom_media_9 = new PdfPCell(new Phrase(string.Format(textCargo_m.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_9.Colspan = 2;
                table_4.AddCell(bottom_media_9);

                PdfPCell bottom_cliente_10 = new PdfPCell(new Phrase(string.Format("Fecha firma: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_10.Colspan = 1;
                bottom_cliente_10.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_10);

                PdfPCell bottom_media_10 = new PdfPCell(new Phrase(string.Format(textFechaCliente.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                bottom_media_10.Colspan = 2;
                table_4.AddCell(bottom_media_10);

                PdfPCell bottom_cliente_11 = new PdfPCell(new Phrase(string.Format("Fecha firma: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_11.Colspan = 1;
                bottom_cliente_11.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_11);

                PdfPCell bottom_media_11 = new PdfPCell(new Phrase(string.Format(textFechaMedia.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                bottom_media_11.Colspan = 2;
                table_4.AddCell(bottom_media_11);


                //segunda pagina y agregando una imagen
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0002.jpg");
                imagen.BorderWidth = 0;
                imagen.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                imagen.ScaleToFit(730f, 765.25f);


                //tercera hoja
                iTextSharp.text.Image imagen_h_1 = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0001.png");
                imagen_h_1.BorderWidth = 0;
                imagen_h_1.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                imagen_h_1.ScaleToFit(100f, 135.25f);


                PdfPTable table_final = new PdfPTable(6);
                table_final.WidthPercentage = 100;

                PdfPCell cell_final = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("E-mail de contacto " + "\n" + " de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(uno_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format("Información Adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final.BackgroundColor = new BaseColor(6, 61, 150);
                table_final.AddCell(cell_final);


                cell_final = new PdfPCell(new Phrase(string.Format(Additional_1.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final.Rowspan = 1;
                cell_final.Colspan = 2;
                table_final.AddCell(cell_final);



                //2
                PdfPTable table_final_1 = new PdfPTable(6);
                table_final_1.WidthPercentage = 100;


                PdfPCell cell_final_1 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);

                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);

                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("E-mail de contacto " + "\n" + " de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);



                cell_final_1 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);



                cell_final_1 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(dos_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format("Información Adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_1.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_1.AddCell(cell_final_1);


                cell_final_1 = new PdfPCell(new Phrase(string.Format(Additional_2.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_1.Rowspan = 1;
                cell_final_1.Colspan = 2;
                table_final_1.AddCell(cell_final_1);



                //3
                PdfPTable table_final_2 = new PdfPTable(6);
                table_final_2.WidthPercentage = 100;


                PdfPCell cell_final_2 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_Razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("E-mail de contacto " + "\n" + " de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(tres_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format("Información adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_2.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_2.AddCell(cell_final_2);


                cell_final_2 = new PdfPCell(new Phrase(string.Format(Additional_3.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_2.Rowspan = 1;
                cell_final_2.Colspan = 2;
                table_final_2.AddCell(cell_final_2);


                //4
                PdfPTable table_final_3 = new PdfPTable(6);
                table_final_3.WidthPercentage = 100;


                PdfPCell cell_final_3 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Contacto De Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("E-mail de contacto" + "\n" + "de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(cuatro_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format("Información adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_3.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_3.AddCell(cell_final_3);


                cell_final_3 = new PdfPCell(new Phrase(string.Format(Additional_4.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_3.Rowspan = 1;
                cell_final_3.Colspan = 2;
                table_final_3.AddCell(cell_final_3);


                //5
                PdfPTable table_final_4 = new PdfPTable(6);
                table_final_4.WidthPercentage = 100;


                PdfPCell cell_final_4 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("E-mail de contacto " + "\n" + " de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);



                cell_final_4 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(cinco_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format("Información adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_4.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_4.AddCell(cell_final_4);


                cell_final_4 = new PdfPCell(new Phrase(string.Format(Additional_5.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_4.Rowspan = 1;
                cell_final_4.Colspan = 2;
                table_final_4.AddCell(cell_final_4);



                //5
                PdfPTable table_final_5 = new PdfPTable(6);
                table_final_5.WidthPercentage = 100;


                PdfPCell cell_final_5 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("E-mail de contacto " + "\n" + " de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);



                cell_final_5 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(seis_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format("Información adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_5.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_5.AddCell(cell_final_5);


                cell_final_5 = new PdfPCell(new Phrase(string.Format(Additional_6.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_5.Rowspan = 1;
                cell_final_5.Colspan = 2;
                table_final_5.AddCell(cell_final_5);



                //6
                PdfPTable table_final_6 = new PdfPTable(6);
                table_final_6.WidthPercentage = 100;


                PdfPCell cell_final_6 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("Contacto Comercial"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("E-mail de contacto " + "\n" + " de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);



                cell_final_6 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(siete_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format("Información adicional"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_final_6.BackgroundColor = new BaseColor(6, 61, 150);
                table_final_6.AddCell(cell_final_6);


                cell_final_6 = new PdfPCell(new Phrase(string.Format(Additional_7.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                cell_final_6.Rowspan = 1;
                cell_final_6.Colspan = 2;
                table_final_6.AddCell(cell_final_6);


                //imagen footer
                iTextSharp.text.Image imagen_f_1 = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0003.png");
                imagen_f_1.BorderWidth = 0;
                imagen_f_1.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                imagen_f_1.ScaleToFit(265f, 320.25f);


                ////cuarta hoja
                //iTextSharp.text.Image imagen_hs_1 = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0001.png");
                //imagen_hs_1.BorderWidth = 0;
                //imagen_hs_1.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                //imagen_hs_1.ScaleToFit(100f, 135.25f);

                //PdfPTable tables_finals = new PdfPTable(5);
                //tables_finals.WidthPercentage = 100;

                //PdfPCell cells_finals = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 4;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 4;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 4;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 4;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 4;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 4;
                //tables_finals.AddCell(cells_finals);



                //cells_finals = new PdfPCell(new Phrase(string.Format("E-mail de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 2;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 2;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format(uno_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 2;
                //tables_finals.AddCell(cells_finals);


                //cells_finals = new PdfPCell(new Phrase(string.Format("Nombre y Cargo"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals.BackgroundColor = new BaseColor(6, 61, 150);
                //cells_finals.Rowspan = 1;
                //cells_finals.Colspan = 2;
                //cells_finals.HorizontalAlignment = 1;
                //tables_finals.AddCell(cells_finals);


                ////2
                //PdfPTable tables_finals_1 = new PdfPTable(5);
                //tables_finals_1.WidthPercentage = 100;


                //PdfPCell cells_finals_1 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 4;
                //tables_finals_1.AddCell(cells_finals_1);



                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 4;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 4;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 4;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 4;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);

                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 4;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("E-mail de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 2;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 2;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format(dos_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 2;
                //tables_finals_1.AddCell(cells_finals_1);


                //cells_finals_1 = new PdfPCell(new Phrase(string.Format("Nombre y Cargo"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_1.BackgroundColor = new BaseColor(6, 61, 150);
                //cells_finals_1.Rowspan = 1;
                //cells_finals_1.Colspan = 2;
                //cells_finals_1.HorizontalAlignment = 1;
                //tables_finals_1.AddCell(cells_finals_1);


                ////3
                //PdfPTable tables_finals_2 = new PdfPTable(5);
                //tables_finals_2.WidthPercentage = 100;


                //PdfPCell cells_finals_2 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 4;
                //tables_finals_2.AddCell(cells_finals_2);



                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_Razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 4;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 4;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 4;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 4;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 4;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("E-mail de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 2;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 2;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format(tres_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 2;
                //tables_finals_2.AddCell(cells_finals_2);


                //cells_finals_2 = new PdfPCell(new Phrase(string.Format("Nombre y Cargo"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_2.BackgroundColor = new BaseColor(6, 61, 150);
                //cells_finals_2.Rowspan = 1;
                //cells_finals_2.Colspan = 2;
                //cells_finals_2.HorizontalAlignment = 1;
                //tables_finals_2.AddCell(cells_finals_2);


                ////4
                //PdfPTable tables_finals_3 = new PdfPTable(5);
                //tables_finals_3.WidthPercentage = 100;


                //PdfPCell cells_finals_3 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 4;
                //tables_finals_3.AddCell(cells_finals_3);



                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 4;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 4;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 4;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 4;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 4;
                //tables_finals_3.AddCell(cells_finals_3);




                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("E-mail de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 2;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 2;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format(cuatro_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 2;
                //tables_finals_3.AddCell(cells_finals_3);


                //cells_finals_3 = new PdfPCell(new Phrase(string.Format("Nombre y Cargo"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_3.BackgroundColor = new BaseColor(6, 61, 150);
                //cells_finals_3.Rowspan = 1;
                //cells_finals_3.Colspan = 2;
                //cells_finals_3.HorizontalAlignment = 1;
                //tables_finals_3.AddCell(cells_finals_3);

                ////5
                //PdfPTable tables_finals_4 = new PdfPTable(5);
                //tables_finals_4.WidthPercentage = 100;


                //PdfPCell cells_finals_4 = new PdfPCell(new Phrase(string.Format("Hotel"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_hotel.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 4;
                //tables_finals_4.AddCell(cells_finals_4);



                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("Razón Social"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_razon.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 4;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("RFC - TAX ID"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_rfc.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 4;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("Dirección Fiscal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_direccion.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 4;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("Código Postal"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_codigo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 4;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("Contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_contacto.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 4;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("E-mail de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_email.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 2;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 2;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("Teléfono de contacto de Facturación"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format(cinco_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 2;
                //tables_finals_4.AddCell(cells_finals_4);


                //cells_finals_4 = new PdfPCell(new Phrase(string.Format("Nombre y Cargo"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //cells_finals_4.BackgroundColor = new BaseColor(6, 61, 150);
                //cells_finals_4.Rowspan = 1;
                //cells_finals_4.Colspan = 2;
                //cells_finals_4.HorizontalAlignment = 1;
                //tables_finals_4.AddCell(cells_finals_4);

                //imagen footer
                //iTextSharp.text.Image imagen_fs_1 = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0003.png");
                //imagen_fs_1.BorderWidth = 0;
                //imagen_fs_1.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                //imagen_fs_1.ScaleToFit(250f, 305.25f);



                //imagen header
                iTextSharp.text.Image imagen_h = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0001.png");
                imagen_h.BorderWidth = 0;
                imagen_h.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                imagen_h.ScaleToFit(120f, 155.25f);


                //imagen footer
                iTextSharp.text.Image imagen_f = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0003.png");
                imagen_f.BorderWidth = 0;
                imagen_f.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                imagen_f.ScaleToFit(280f, 335.25f);


                //Exporting to PDF
                string folderPath = @"C:\PDF-OI\";
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string formato = ".pdf";

                string nombre_archivo = folderPath + "OI-" + fecha + "-" + OI_text.Text + formato;

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(nombre_archivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.LETTER, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(imagen_h);

                    pdfDoc.Add(caratula);

                    pdfDoc.Add(fecha_firma);

                    pdfDoc.Add(vigencia_pauta);

                    //pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_1);

                    pdfDoc.Add(table_2);

                    pdfDoc.Add(table_3);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(cash_in_1);

                    pdfDoc.Add(cash_in);

                    pdfDoc.Add(vigencia_pauta_mf);

                    pdfDoc.Add(forma_calculo);

                    pdfDoc.Add(table);

                    pdfDoc.Add(table_c_C);

                    pdfDoc.Add(datos_C_c);

                    pdfDoc.Add(table_4);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(imagen_f);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(imagen);

                    pdfDoc.Add(imagen_h);

                    pdfDoc.Add(table_final);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_final_1);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_final_2);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_final_3);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_final_4);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_final_5);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(table_final_6);
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(imagen_f_1);
                    pdfDoc.Add(new Paragraph(" "));

                    //4ta
                    //pdfDoc.Add(new Paragraph(" "));
                    //pdfDoc.Add(imagen_hs_1);

                    //pdfDoc.Add(tables_finals);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(tables_finals_1);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(tables_finals_2);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(tables_finals_3);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(tables_finals_4);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(imagen_fs_1);

                    pdfDoc.Close();

                    System.Diagnostics.Process.Start(nombre_archivo);

                    stream.Close();
                }
                MessageBox.Show("Documento creado.", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            int cant_ene, cant_feb, cant_mar, cant_abr, cant_may, cant_jun, cant_jul, cant_ago, cant_sep, cant_oct, cant_nov, cant_dic = 0;

            if (string.IsNullOrEmpty(textDocEne.Text))
            {
                cant_ene = 0;
            }
            else
            {
                cant_ene = Convert.ToInt32(textDocEne.Text);
            }


            if (string.IsNullOrEmpty(textDocFeb.Text))
            {
                cant_feb = 0;
            }
            else
            {
                cant_feb = Convert.ToInt32(textDocFeb.Text);
            }


            if (string.IsNullOrEmpty(textDocMar.Text))
            {
                cant_mar = 0;
            }
            else
            {
                cant_mar = Convert.ToInt32(textDocMar.Text);
            }


            if (string.IsNullOrEmpty(textDocAbr.Text))
            {
                cant_abr = 0;
            }
            else
            {
                cant_abr = Convert.ToInt32(textDocAbr.Text);
            }


            if (string.IsNullOrEmpty(textDocMay.Text))
            {
                cant_may = 0;
            }
            else
            {
                cant_may = Convert.ToInt32(textDocMay.Text);
            }


            if (string.IsNullOrEmpty(textDocJun.Text))
            {
                cant_jun = 0;
            }
            else
            {
                cant_jun = Convert.ToInt32(textDocJun.Text);
            }


            if (string.IsNullOrEmpty(textDocJul.Text))
            {
                cant_jul = 0;
            }
            else
            {
                cant_jul = Convert.ToInt32(textDocJul.Text);
            }


            if (string.IsNullOrEmpty(textDocAgo.Text))
            {
                cant_ago = 0;
            }
            else
            {
                cant_ago = Convert.ToInt32(textDocAgo.Text);
            }


            if (string.IsNullOrEmpty(textDocSep.Text))
            {
                cant_sep = 0;
            }
            else
            {
                cant_sep = Convert.ToInt32(textDocSep.Text);
            }


            if (string.IsNullOrEmpty(textDocOct.Text))
            {
                cant_oct = 0;
            }
            else
            {
                cant_oct = Convert.ToInt32(textDocOct.Text);
            }


            if (string.IsNullOrEmpty(textDocNov.Text))
            {
                cant_nov = 0;
            }
            else
            {
                cant_nov = Convert.ToInt32(textDocNov.Text);
            }


            if (string.IsNullOrEmpty(textDocDic.Text))
            {
                cant_dic = 0;
            }
            else
            {
                cant_dic = Convert.ToInt32(textDocDic.Text);
            }


            int total = 0;

            total = cant_ene + cant_feb + cant_mar + cant_abr + cant_may + cant_jun + cant_jul + cant_ago + cant_sep + cant_oct + cant_nov + cant_dic;

            textTotalIVA.Text = Convert.ToString(total);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
