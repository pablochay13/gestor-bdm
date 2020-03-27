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
    public partial class create_OI_en : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public create_OI_en()
        {
            InitializeComponent();

            metroTabControl1.TabPages.Remove(metroTabPage2);

            supply();
            account();

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

            comboSupply.SelectedIndex = 0;
            comboAccounts.SelectedIndex = 0;

            System.IO.Directory.CreateDirectory("C:\\PDF-OI\\");
        }

        private void create_OI_en_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
        }

        private void generar_OI_Click(object sender, EventArgs e)
        {
            try
            {
                //caratula
                PdfPTable caratula = new PdfPTable(1);
                caratula.WidthPercentage = 100;
                PdfPCell caratula_oi = new PdfPCell(new Phrase(string.Format("REFERENCE FOLIO: " + OI_text.Text + "     " + "INSERTION ORDER" + "     " + "DATE: " + DateTime.Now), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                //pdfDoc.Add(new Paragraph(string.Format("Vendedor: " + Label1.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD)));
                caratula_oi.BackgroundColor = new BaseColor(6, 61, 150);
                caratula_oi.HorizontalAlignment = 1;

                caratula.AddCell(caratula_oi);

                //fecha de firma
                string anio_firma, mes_firma, dia_firma = "";

                anio_firma = fechaFirma_text.Value.Year.ToString();
                mes_firma = fechaFirma_text.Value.Month.ToString();
                dia_firma = fechaFirma_text.Value.Day.ToString();


                if (mes_firma == "1")
                {
                    mes_firma = "January";
                }

                else if (mes_firma == "2")
                {
                    mes_firma = "February";
                }

                else if (mes_firma == "3")
                {
                    mes_firma = "March";
                }

                else if (mes_firma == "4")
                {
                    mes_firma = "April";
                }

                else if (mes_firma == "5")
                {
                    mes_firma = "May";
                }

                else if (mes_firma == "6")
                {
                    mes_firma = "June";
                }

                else if (mes_firma == "7")
                {
                    mes_firma = "July";
                }

                else if (mes_firma == "8")
                {
                    mes_firma = "August";
                }

                else if (mes_firma == "9")
                {
                    mes_firma = "September";
                }

                else if (mes_firma == "10")
                {
                    mes_firma = "October";
                }

                else if (mes_firma == "11")
                {
                    mes_firma = "November";
                }

                else if (mes_firma == "12")
                {
                    mes_firma = "December";
                }

                PdfPTable fecha_firma = new PdfPTable(4);
                fecha_firma.WidthPercentage = 100;
                PdfPCell fecha_OI = new PdfPCell(new Phrase(string.Format("signature Date: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                fecha_OI.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                fecha_firma.AddCell(fecha_OI);

                fecha_OI = new PdfPCell(new Phrase(string.Format("Day: " + dia_firma + "     " + "Month: " + " " + mes_firma + "     " + "Year: " + " " + anio_firma), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    desde_mes = "January";
                }

                else if (desde_mes == "2")
                {
                    desde_mes = "February";
                }

                else if (desde_mes == "3")
                {
                    desde_mes = "March";
                }

                else if (desde_mes == "4")
                {
                    desde_mes = "April";
                }

                else if (desde_mes == "5")
                {
                    desde_mes = "May";
                }

                else if (desde_mes == "6")
                {
                    desde_mes = "June";
                }

                else if (desde_mes == "7")
                {
                    desde_mes = "July";
                }

                else if (desde_mes == "8")
                {
                    desde_mes = "August";
                }

                else if (desde_mes == "9")
                {
                    desde_mes = "September";
                }

                else if (desde_mes == "10")
                {
                    desde_mes = "October";
                }

                else if (desde_mes == "11")
                {
                    desde_mes = "November";
                }

                else if (desde_mes == "12")
                {
                    desde_mes = "December";
                }

                //Hasta

                if (hasta_mes == "1")
                {
                    hasta_mes = "January";
                }

                else if (hasta_mes == "2")
                {
                    hasta_mes = "February";
                }

                else if (hasta_mes == "3")
                {
                    hasta_mes = "March";
                }

                else if (hasta_mes == "4")
                {
                    hasta_mes = "April";
                }

                else if (hasta_mes == "5")
                {
                    hasta_mes = "May";
                }

                else if (hasta_mes == "6")
                {
                    hasta_mes = "June";
                }

                else if (hasta_mes == "7")
                {
                    hasta_mes = "July";
                }

                else if (hasta_mes == "8")
                {
                    hasta_mes = "August";
                }

                else if (hasta_mes == "9")
                {
                    hasta_mes = "September";
                }

                else if (hasta_mes == "10")
                {
                    hasta_mes = "October";
                }

                else if (hasta_mes == "11")
                {
                    hasta_mes = "November";
                }

                else if (hasta_mes == "12")
                {
                    hasta_mes = "December";
                }

                PdfPTable vigencia_pauta = new PdfPTable(4);
                vigencia_pauta.WidthPercentage = 100;
                PdfPCell vigencia_OI = new PdfPCell(new Phrase(string.Format("VALIDITY: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                vigencia_OI.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera

                vigencia_pauta.AddCell(vigencia_OI);

                vigencia_OI = new PdfPCell(new Phrase(string.Format("From Day: " + " " + desde_dia + "   " + "Month: " + " " + desde_mes + "   " + "Year: " + " " + desde_anio + "   " + "Up to day: " + " " + hasta_dia + "   " + "Mes: " + " " + hasta_mes + "   " + "Año: " + " " + hasta_anio), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                vigencia_OI.Colspan = 3;
                vigencia_OI.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                vigencia_pauta.AddCell(vigencia_OI);

                //clientes
                PdfPTable table_1 = new PdfPTable(4);
                table_1.WidthPercentage = 100;
                PdfPCell cliente = new PdfPCell(new Phrase(string.Format("THE CLIENT"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cliente.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                cliente.HorizontalAlignment = 1;
                cliente.Colspan = 2;

                PdfPCell media = new PdfPCell(new Phrase(string.Format("MEDIA"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                media.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                media.HorizontalAlignment = 1;
                media.Colspan = 2;

                table_1.AddCell(cliente);
                table_1.AddCell(media);

                PdfPCell bottom_cliente_1 = new PdfPCell(new Phrase(string.Format("Tradename: " + clienteComercial.Text + "\n" + "Registered Corporate Name: " + clienteRazon.Text + "\n" + "Tax ID: " + clienteID.Text + "\n" + "Address: " + "\n" + "Street: " + clienteCalle.Text + "\n" + "City/Country: " + clientePais.Text + "\n" + "Zip Code: " + clientePostal.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_cliente_1.Colspan = 2;
                table_1.AddCell(bottom_cliente_1);

                PdfPCell bottom_media_1 = new PdfPCell(new Phrase(string.Format("Corporate name: " + mediaRazon.Text + "\n" + "Tax ID: " + mediaID.Text + "\n" + "Address: " + "\n" + "Street: " + mediaCalle.Text + "\n" + "City/Country: " + mediaPais.Text + "\n" + "Zip Code: " + mediaPostal.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_1.Colspan = 2;
                table_1.AddCell(bottom_media_1);


                //clientes_2
                PdfPTable table_2 = new PdfPTable(4);
                table_2.WidthPercentage = 100;
                PdfPCell cliente_2 = new PdfPCell(new Phrase(string.Format("Accounts Payable Contact"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cliente_2.BackgroundColor = new BaseColor(6, 61, 150);
                cliente_2.HorizontalAlignment = 1;
                cliente_2.Colspan = 2;

                PdfPCell media_2 = new PdfPCell(new Phrase(string.Format("Accounts Receivable Contact"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                media_2.BackgroundColor = new BaseColor(6, 61, 150);
                media_2.HorizontalAlignment = 1;
                media_2.Colspan = 2;

                table_2.AddCell(cliente_2);
                table_2.AddCell(media_2);

                PdfPCell bottom_cliente_2 = new PdfPCell(new Phrase(string.Format("Name: " + cxpNombre.Text + "\n" + "Phone: " + cxpTelefono.Text + "\n" + "Mail: " + cxpCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_cliente_2.Colspan = 2;
                table_2.AddCell(bottom_cliente_2);

                PdfPCell bottom_media_2 = new PdfPCell(new Phrase(string.Format("Name: " + cxcNombre.Text + "\n" + "Phone: " + cxcTelefono.Text + "\n" + "Mail: " + cxcCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_2.Colspan = 2;
                table_2.AddCell(bottom_media_2);


                //clientes_2
                PdfPTable table_3 = new PdfPTable(4);
                table_3.WidthPercentage = 100;
                PdfPCell cliente_3 = new PdfPCell(new Phrase(string.Format("Business contact: " + NComercial.Text + "\n" + "Phone: " + TComercial.Text + " " + "Mail: " + CComercial.Text + "\n" + "\n" + "Media Guideline Contact: " + PNombre.Text + "\n" + "Phone: " + PTelefono.Text + " " + "Mail: " + PCorreo.Text + "\n" + "\n" + "HotelDO Tour Contact: " + HNombre.Text + "\n" + "Phone: " + HTelefono.Text + " " + "Mail: " + HCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cliente_3.Colspan = 2;

                PdfPCell media_3 = new PdfPCell(new Phrase(string.Format("Business contact: " + comboSupply.Text + "\n" + "Phone: " + mediaCTelefono.Text + " " + "Mail: " + mediaCCorreo.Text + "\n" + "\n" + "Media Guideline Contact: " + comboAccounts.Text + "\n" + "Phone: " + mediaPTelefono.Text + " " + "Mail: " + mediaPEmail.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                media_3.Colspan = 2;

                table_3.AddCell(cliente_3);

                table_3.AddCell(media_3);


                //caratula
                string checked_cash_in = "";


                PdfPTable cash_in_1 = new PdfPTable(4);
                cash_in_1.WidthPercentage = 100;


                PdfPCell facturado_por = new PdfPCell(new Phrase(string.Format("BILL FOR "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                facturado_por.BackgroundColor = new BaseColor(6, 61, 150);

                cash_in_1.AddCell(facturado_por);

                PdfPCell facturado_por_2 = new PdfPCell(new Phrase(string.Format("Corporate   " + " " + "Hotel " + " "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                facturado_por_2.Colspan = 3;
                facturado_por_2.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                cash_in_1.AddCell(facturado_por_2);


                PdfPTable cash_in = new PdfPTable(1);
                cash_in.WidthPercentage = 100;

                PdfPCell cash_in_oi = new PdfPCell(new Phrase(string.Format("COMMERCIAL SCHEME AND PAYMENT METHOD: " + "             " + "Cash In: " + checked_cash_in), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
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
                    desde_mes_mf = "January";
                }

                else if (desde_mes_mf == "2")
                {
                    desde_mes_mf = "February";
                }

                else if (desde_mes_mf == "3")
                {
                    desde_mes_mf = "March";
                }

                else if (desde_mes_mf == "4")
                {
                    desde_mes_mf = "April";
                }

                else if (desde_mes_mf == "5")
                {
                    desde_mes_mf = "May";
                }

                else if (desde_mes_mf == "6")
                {
                    desde_mes_mf = "June";
                }

                else if (desde_mes_mf == "7")
                {
                    desde_mes_mf = "July";
                }

                else if (desde_mes_mf == "8")
                {
                    desde_mes_mf = "August";
                }

                else if (desde_mes_mf == "9")
                {
                    desde_mes_mf = "September";
                }

                else if (desde_mes_mf == "10")
                {
                    desde_mes_mf = "October";
                }

                else if (desde_mes_mf == "11")
                {
                    desde_mes_mf = "November";
                }

                else if (desde_mes_mf == "12")
                {
                    desde_mes_mf = "December";
                }

                //hasta
                if (hasta_mes_mf == "1")
                {
                    hasta_mes_mf = "January";
                }

                else if (hasta_mes_mf == "2")
                {
                    hasta_mes_mf = "February";
                }

                else if (hasta_mes_mf == "3")
                {
                    hasta_mes_mf = "March";
                }

                else if (hasta_mes_mf == "4")
                {
                    hasta_mes_mf = "April";
                }

                else if (hasta_mes_mf == "5")
                {
                    hasta_mes_mf = "May";
                }

                else if (hasta_mes_mf == "6")
                {
                    hasta_mes_mf = "June";
                }

                else if (hasta_mes_mf == "7")
                {
                    hasta_mes_mf = "July";
                }

                else if (hasta_mes_mf == "8")
                {
                    hasta_mes_mf = "August";
                }

                else if (hasta_mes_mf == "9")
                {
                    hasta_mes_mf = "September";
                }

                else if (hasta_mes_mf == "10")
                {
                    hasta_mes_mf = "October";
                }

                else if (hasta_mes_mf == "11")
                {
                    hasta_mes_mf = "November";
                }

                else if (hasta_mes_mf == "12")
                {
                    hasta_mes_mf = "December";
                }

                PdfPTable vigencia_pauta_mf = new PdfPTable(4);
                vigencia_pauta_mf.WidthPercentage = 100;

                if (checkBoxMF.Checked == true)
                {
                    checked_mf_oi = "X";

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. ADVERTISING FUND: " + " " + checked_mf_oi), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    vigencia_OI_mf.BackgroundColor = new BaseColor(6, 61, 150);

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf);

                    PdfPCell vigencia_OI_mf_2 = new PdfPCell(new Phrase(string.Format("   " + porcentajeMF_box.Text + "%" + " " + "From Date: " + " " + desde_dia_mf + " " + "Month: " + " " + desde_mes_mf + " " + "Year: " + " " + desde_anio_mf + " " + "Until Date: " + " " + hasta_dia_mf + " " + "Month: " + " " + hasta_mes_mf + " " + "Year: " + " " + hasta_anio_mf), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. ADVERTISING FUND: " + "  "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    vigencia_OI_mf.BackgroundColor = new BaseColor(6, 61, 150);

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf);

                    PdfPCell vigencia_OI_mf_2 = new PdfPCell(new Phrase(string.Format("   " + porcentajeMF_box.Text + "%" + " " + "From Date: " + " " + desde_dia_mf + " " + "Month: " + " " + desde_mes_mf + " " + "Year: " + " " + desde_anio_mf + " " + "Until Date: " + " " + hasta_dia_mf + " " + "Month: " + " " + hasta_mes_mf + " " + "Year: " + " " + hasta_anio_mf), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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

                PdfPCell cell_fc_2 = new PdfPCell(new Phrase(string.Format("Production: " + produccion_io_c + "     " + "Issued Payments " + pago_emitido_io), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell_fc_2.Colspan = 3;

                forma_calculo.AddCell(cell_fc_2);


                //Facturacion mensual
                string facturacion_mensual = " ";

                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;

                PdfPCell cell = new PdfPCell(new Phrase(string.Format("\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "2. VIA MONTHLY BILLING (BEST MEDIA)"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell.Rowspan = 13;
                cell.Colspan = 1;
                cell.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(cell);

                PdfPCell cell_fm_1 = new PdfPCell(new Phrase(string.Format("Month"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_1.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_1);

                PdfPCell cell_fm_2 = new PdfPCell(new Phrase(string.Format("Amount"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_2.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_2);


                PdfPCell cell_fm_5 = new PdfPCell(new Phrase(string.Format("Badge"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_5.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_5);


                PdfPCell cell_fm_4 = new PdfPCell(new Phrase(string.Format("Information"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_4.Colspan = 3;
                cell_fm_4.BackgroundColor = new BaseColor(6, 61, 150);
                table.AddCell(cell_fm_4);

                //ENE
                cell = new PdfPCell(new Phrase(string.Format(facturadoEne.Text + " " + anioEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);


                if (textDocEne.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }

                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }


                cell = new PdfPCell(new Phrase(string.Format(comboEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //FEB
                cell = new PdfPCell(new Phrase(string.Format(facturadoFeb.Text + " " + anioFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocFeb.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //MAR
                cell = new PdfPCell(new Phrase(string.Format(facturadoMar.Text + " " + anioMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocMar.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //ABR
                cell = new PdfPCell(new Phrase(string.Format(facturadoAbr.Text + " " + anioAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocAbr.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //MAY
                cell = new PdfPCell(new Phrase(string.Format(facturadoMay.Text) + " " + anioMay.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocMay.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //JUN
                cell = new PdfPCell(new Phrase(string.Format(facturadoJun.Text + " " + anioJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocJun.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //JUL
                cell = new PdfPCell(new Phrase(string.Format(facturadoJul.Text + " " + anioJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                table.AddCell(cell);

                if (textDocJul.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //AGO
                cell = new PdfPCell(new Phrase(string.Format(facturadoAgo.Text + " " + anioAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocAgo.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //SEP
                cell = new PdfPCell(new Phrase(string.Format(facturadoSep.Text + " " + anioSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocSep.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //OCT
                cell = new PdfPCell(new Phrase(string.Format(facturadoOct.Text + " " + anioOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocOct.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //NOV
                cell = new PdfPCell(new Phrase(string.Format(facturadoNov.Text + " " + anioNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocNov.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }


                cell = new PdfPCell(new Phrase(string.Format(comboNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //DIC
                cell = new PdfPCell(new Phrase(string.Format(facturadoDic.Text + " " + anioDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocDic.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                PdfPCell cell_fm_3 = new PdfPCell(new Phrase(string.Format("Total with VAT: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_3.Colspan = 2;
                cell_fm_3.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(cell_fm_3);

                double total = 0;

                total = Convert.ToDouble(textDocEne.Text) + Convert.ToDouble(textDocFeb.Text) + Convert.ToDouble(textDocMar.Text) + Convert.ToDouble(textDocAbr.Text) + Convert.ToDouble(textDocMay.Text) + Convert.ToDouble(textDocJun.Text) + +Convert.ToDouble(textDocJul.Text) + Convert.ToDouble(textDocAgo.Text) + Convert.ToDouble(textDocSep.Text) + Convert.ToDouble(textDocOct.Text) + Convert.ToDouble(textDocNov.Text) + Convert.ToDouble(textDocDic.Text);


                if (textTotalIVA.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(Convert.ToString(total)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(Convert.ToString(total)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                }

                //cell = new PdfPCell(new Phrase(string.Format("     "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                //table.AddCell(cell);


                //forma de pago
                PdfPCell forma_pago_table = new PdfPCell(new Phrase(string.Format("PAYMENT METHOD"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                forma_pago_table.Colspan = 2;
                forma_pago_table.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(forma_pago_table);

                string trans_banca_c = " ";

                string compen_fact_c = " ";

                if (c_c_facturas.Checked == true)
                {
                    compen_fact_c = "X";
                }

                if (c_t_bancaria.Checked == true)
                {
                    trans_banca_c = "X";
                }

                forma_pago_table = new PdfPCell(new Phrase(string.Format("Bank Transfer: " + trans_banca_c), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                forma_pago_table.Colspan = 2;
                table.AddCell(forma_pago_table);

                forma_pago_table = new PdfPCell(new Phrase(string.Format("Compensation and Bills: " + compen_fact_c), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                forma_pago_table.Colspan = 3;
                table.AddCell(forma_pago_table);


                //condiciones comerciales
                PdfPTable table_c_C = new PdfPTable(3);
                table_c_C.WidthPercentage = 100;

                PdfPCell cell_c_C = new PdfPCell(new Phrase(string.Format("BUSINESS TERMS"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
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
                PdfPCell datos_IO_CC = new PdfPCell(new Phrase(string.Format("- -	The CLIENT knows, is subject to and is bound to comply with the Best Travel Media Terms and Conditions established in the Reverse of this Insertion Order and the Media Guidelines. " + "\n" + "- -	The CLIENT declares under protest to tell the truth that has the capacity and powers necessary to compel its represented to comply with the obligations set out in these Best Travel Media Terms and Conditions. " + "\n" + " - -	The Contracting Corporate Name appearing on the title page under protest of telling the truth, states that it acts in the name and representation of the properties indicated in Annex A of the present Insertion Order."), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
                datos_IO_CC.HorizontalAlignment = 0;

                datos_C_c.AddCell(datos_IO_CC);


                //parte final
                PdfPTable table_4 = new PdfPTable(6);
                table_4.WidthPercentage = 100;

                PdfPCell cliente_4 = new PdfPCell(new Phrase(string.Format("THE CLIENT:"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cliente_4.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                cliente_4.Colspan = 3;
                cliente_4.HorizontalAlignment = 1;

                PdfPCell media_4 = new PdfPCell(new Phrase(string.Format("MEDIA"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                media_4.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                media_4.Colspan = 3;
                media_4.HorizontalAlignment = 1;

                table_4.AddCell(cliente_4);
                table_4.AddCell(media_4);

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                PdfPCell bottom_cliente_4 = new PdfPCell(new Phrase(string.Format("SIGNATURE: " + "\n" + " "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_4.Rowspan = 2;
                bottom_cliente_4.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_4);

                PdfPCell bottom_media_4 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_4.Rowspan = 2;
                bottom_media_4.Colspan = 2;
                table_4.AddCell(bottom_media_4);

                PdfPCell bottom_cliente_5 = new PdfPCell(new Phrase(string.Format("SIGNATURE: " + "\n" + " "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_5.Rowspan = 2;
                bottom_cliente_5.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_5);

                PdfPCell bottom_media_5 = new PdfPCell(new Phrase(string.Format(" "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_5.Rowspan = 2;
                bottom_media_5.Colspan = 2;
                table_4.AddCell(bottom_media_5);

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                PdfPCell bottom_cliente_6 = new PdfPCell(new Phrase(string.Format("NAME: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_6.Colspan = 1;
                bottom_cliente_6.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_6);

                PdfPCell bottom_media_6 = new PdfPCell(new Phrase(string.Format(textNombre_c.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_6.Colspan = 2;
                table_4.AddCell(bottom_media_6);

                PdfPCell bottom_cliente_7 = new PdfPCell(new Phrase(string.Format("NAME: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_7.Colspan = 1;
                bottom_cliente_7.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_7);

                PdfPCell bottom_media_7 = new PdfPCell(new Phrase(string.Format(textNombre_m.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_7.Colspan = 2;
                table_4.AddCell(bottom_media_7);

                PdfPCell bottom_cliente_8 = new PdfPCell(new Phrase(string.Format("TITLE: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_8.Colspan = 1;
                bottom_cliente_8.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_8);

                PdfPCell bottom_media_8 = new PdfPCell(new Phrase(string.Format(textCargo_c.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_8.Colspan = 2;
                table_4.AddCell(bottom_media_8);

                PdfPCell bottom_cliente_9 = new PdfPCell(new Phrase(string.Format("TITLE: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_9.Colspan = 1;
                bottom_cliente_9.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_9);

                PdfPCell bottom_media_9 = new PdfPCell(new Phrase(string.Format(textCargo_m.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_9.Colspan = 2;
                table_4.AddCell(bottom_media_9);

                PdfPCell bottom_cliente_10 = new PdfPCell(new Phrase(string.Format("SIGNATURE DATE: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_10.Colspan = 1;
                bottom_cliente_10.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_10);

                PdfPCell bottom_media_10 = new PdfPCell(new Phrase(string.Format(textFechaCliente.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                bottom_media_10.Colspan = 2;
                table_4.AddCell(bottom_media_10);

                PdfPCell bottom_cliente_11 = new PdfPCell(new Phrase(string.Format("SIGNATURE DATE: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                bottom_cliente_11.Colspan = 1;
                bottom_cliente_11.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table_4.AddCell(bottom_cliente_11);

                PdfPCell bottom_media_11 = new PdfPCell(new Phrase(string.Format(textFechaMedia.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                bottom_media_11.Colspan = 2;
                table_4.AddCell(bottom_media_11);


                //segunda pagina y agregando una imagen
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("http://bestravelmedia.com/img/log/0002-en.jpg");
                imagen.BorderWidth = 0;
                imagen.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                imagen.ScaleToFit(715f, 750.25f);


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


                cell_final_2 = new PdfPCell(new Phrase(string.Format(cuatro_telefono.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)));
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

                    //pdfDoc.Add(imagen_h);

                    //pdfDoc.Add(table_final);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(table_final_1);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(table_final_2);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(table_final_3);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(table_final_4);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(table_final_5);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(table_final_6);
                    //pdfDoc.Add(new Paragraph(" "));

                    //pdfDoc.Add(imagen_f_1);
                    //pdfDoc.Add(new Paragraph(" "));


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

        private void Sumar_Click_1(object sender, EventArgs e)
        {
            double total = 0;

            total = Convert.ToDouble(textDocEne.Text) + Convert.ToDouble(textDocFeb.Text) + Convert.ToDouble(textDocMar.Text) + Convert.ToDouble(textDocAbr.Text) + Convert.ToDouble(textDocMay.Text) + Convert.ToDouble(textDocJun.Text) + +Convert.ToDouble(textDocJul.Text) + Convert.ToDouble(textDocAgo.Text) + Convert.ToDouble(textDocSep.Text) + Convert.ToDouble(textDocOct.Text) + Convert.ToDouble(textDocNov.Text) + Convert.ToDouble(textDocDic.Text);

            textTotalIVA.Text = Convert.ToString(total);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void comboSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboSupply.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT * FROM supply_manager WHERE nombre = '" + comboSupply.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string t_correo = Convert.ToString(reader["correo"]);

                    mediaCCorreo.Text = t_correo;
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }
        public void supply()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, nombre from supply_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboSupply.ValueMember = "id";
                comboSupply.DisplayMember = "nombre";
                comboSupply.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboSupply.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT * FROM account_manager WHERE nombre = '" + comboAccounts.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string t_correo = Convert.ToString(reader["correo"]);

                    mediaPEmail.Text = t_correo;
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void account()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, nombre from account_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboAccounts.ValueMember = "id";
                comboAccounts.DisplayMember = "nombre";
                comboAccounts.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
