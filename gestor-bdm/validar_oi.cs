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
    public partial class validar_oi : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public validar_oi()
        {
            InitializeComponent();

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(validar_oi));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.generar_OI = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.hotelbox = new MetroFramework.Controls.MetroRadioButton();
            this.corbox = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textFechaMedia = new MetroFramework.Controls.MetroTextBox();
            this.textCargo_m = new MetroFramework.Controls.MetroTextBox();
            this.textNombre_m = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel55 = new MetroFramework.Controls.MetroLabel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textFechaCliente = new MetroFramework.Controls.MetroTextBox();
            this.textCargo_c = new MetroFramework.Controls.MetroTextBox();
            this.textNombre_c = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textCondiciones = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.metroLabel119 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.textTotalIVA = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.c_c_facturas = new MetroFramework.Controls.MetroCheckBox();
            this.c_t_bancaria = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.Sumar = new MetroFramework.Controls.MetroButton();
            this.metroLabel47 = new MetroFramework.Controls.MetroLabel();
            this.textBoxDic = new MetroFramework.Controls.MetroTextBox();
            this.textBoxNov = new MetroFramework.Controls.MetroTextBox();
            this.textBoxOct = new MetroFramework.Controls.MetroTextBox();
            this.textBoxSep = new MetroFramework.Controls.MetroTextBox();
            this.textBoxAgo = new MetroFramework.Controls.MetroTextBox();
            this.textBoxJul = new MetroFramework.Controls.MetroTextBox();
            this.textBoxJun = new MetroFramework.Controls.MetroTextBox();
            this.textBoxMay = new MetroFramework.Controls.MetroTextBox();
            this.textBoxAbr = new MetroFramework.Controls.MetroTextBox();
            this.textBoxMar = new MetroFramework.Controls.MetroTextBox();
            this.textBoxFeb = new MetroFramework.Controls.MetroTextBox();
            this.textBoxEne = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel46 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxDic = new MetroFramework.Controls.MetroComboBox();
            this.comboNov = new MetroFramework.Controls.MetroComboBox();
            this.comboOct = new MetroFramework.Controls.MetroComboBox();
            this.comboSep = new MetroFramework.Controls.MetroComboBox();
            this.comboAgo = new MetroFramework.Controls.MetroComboBox();
            this.comboJul = new MetroFramework.Controls.MetroComboBox();
            this.comboJun = new MetroFramework.Controls.MetroComboBox();
            this.comboMay = new MetroFramework.Controls.MetroComboBox();
            this.comboAbr = new MetroFramework.Controls.MetroComboBox();
            this.comboMar = new MetroFramework.Controls.MetroComboBox();
            this.comboFeb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel45 = new MetroFramework.Controls.MetroLabel();
            this.comboEne = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel44 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.anioDic = new MetroFramework.Controls.MetroComboBox();
            this.anioNov = new MetroFramework.Controls.MetroComboBox();
            this.anioOct = new MetroFramework.Controls.MetroComboBox();
            this.anioSep = new MetroFramework.Controls.MetroComboBox();
            this.anioAgo = new MetroFramework.Controls.MetroComboBox();
            this.anioJul = new MetroFramework.Controls.MetroComboBox();
            this.anioJun = new MetroFramework.Controls.MetroComboBox();
            this.anioMay = new MetroFramework.Controls.MetroComboBox();
            this.anioAbr = new MetroFramework.Controls.MetroComboBox();
            this.anioMar = new MetroFramework.Controls.MetroComboBox();
            this.anioFeb = new MetroFramework.Controls.MetroComboBox();
            this.anioEne = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel42 = new MetroFramework.Controls.MetroLabel();
            this.facturadoDic = new MetroFramework.Controls.MetroComboBox();
            this.facturadoNov = new MetroFramework.Controls.MetroComboBox();
            this.facturadoOct = new MetroFramework.Controls.MetroComboBox();
            this.facturadoSep = new MetroFramework.Controls.MetroComboBox();
            this.facturadoAgo = new MetroFramework.Controls.MetroComboBox();
            this.facturadoJul = new MetroFramework.Controls.MetroComboBox();
            this.facturadoJun = new MetroFramework.Controls.MetroComboBox();
            this.facturadoMay = new MetroFramework.Controls.MetroComboBox();
            this.facturadoAbr = new MetroFramework.Controls.MetroComboBox();
            this.facturadoMar = new MetroFramework.Controls.MetroComboBox();
            this.facturadoFeb = new MetroFramework.Controls.MetroComboBox();
            this.facturadoEne = new MetroFramework.Controls.MetroComboBox();
            this.textDocDic = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocNov = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocOct = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocSep = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocAgo = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocJul = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocJun = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocMay = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocAbr = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocMar = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocFeb = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.textDocEne = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.dateTimeMF_hasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeMF_desde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.checkFacturas = new MetroFramework.Controls.MetroCheckBox();
            this.checkPagos = new MetroFramework.Controls.MetroCheckBox();
            this.checkBancaria = new MetroFramework.Controls.MetroCheckBox();
            this.checkProduccion = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.porcentajeMF_box = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.checkBoxMF = new MetroFramework.Controls.MetroCheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboAccounts = new MetroFramework.Controls.MetroComboBox();
            this.mediaPEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.mediaPTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboSupply = new MetroFramework.Controls.MetroComboBox();
            this.mediaCCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.mediaCTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mediaPostal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.mediaPais = new MetroFramework.Controls.MetroTextBox();
            this.mediaCalle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.mediaID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.mediaRazon = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cxcCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.cxcTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.cxcNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.HCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.HTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.HNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.PCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.PTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.PNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.NComercial = new MetroFramework.Controls.MetroTextBox();
            this.CComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.clientePostal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.clientePais = new MetroFramework.Controls.MetroTextBox();
            this.clienteCalle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.clienteID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.clienteRazon = new MetroFramework.Controls.MetroTextBox();
            this.lanbel9999 = new MetroFramework.Controls.MetroLabel();
            this.clienteComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cxpCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cxpTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cxpNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vigenciaHasta_text = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.vigenciaDesde_text = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.fechaFirma_text = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.OI_text = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.Additional_6 = new MetroFramework.Controls.MetroTextBox();
            this.seis_telefono = new MetroFramework.Controls.MetroTextBox();
            this.seis_email = new MetroFramework.Controls.MetroTextBox();
            this.seis_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel110 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel111 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel112 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel113 = new MetroFramework.Controls.MetroLabel();
            this.seis_codigo = new MetroFramework.Controls.MetroTextBox();
            this.seis_direccion = new MetroFramework.Controls.MetroTextBox();
            this.seis_rfc = new MetroFramework.Controls.MetroTextBox();
            this.seis_razon = new MetroFramework.Controls.MetroTextBox();
            this.seis_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel114 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel115 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel116 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel117 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel118 = new MetroFramework.Controls.MetroLabel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.Additional_5 = new MetroFramework.Controls.MetroTextBox();
            this.cinco_telefono = new MetroFramework.Controls.MetroTextBox();
            this.cinco_email = new MetroFramework.Controls.MetroTextBox();
            this.cinco_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel101 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel102 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel103 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel104 = new MetroFramework.Controls.MetroLabel();
            this.cinco_codigo = new MetroFramework.Controls.MetroTextBox();
            this.cinco_direccion = new MetroFramework.Controls.MetroTextBox();
            this.cinco_rfc = new MetroFramework.Controls.MetroTextBox();
            this.cinco_razon = new MetroFramework.Controls.MetroTextBox();
            this.cinco_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel105 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel106 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel107 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel108 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel109 = new MetroFramework.Controls.MetroLabel();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.Additional_4 = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_telefono = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_email = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel92 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel93 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel94 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel95 = new MetroFramework.Controls.MetroLabel();
            this.cuatro_codigo = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_direccion = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_rfc = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_razon = new MetroFramework.Controls.MetroTextBox();
            this.cuatro_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel96 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel97 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel98 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel99 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel100 = new MetroFramework.Controls.MetroLabel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.Additional_3 = new MetroFramework.Controls.MetroTextBox();
            this.tres_telefono = new MetroFramework.Controls.MetroTextBox();
            this.tres_email = new MetroFramework.Controls.MetroTextBox();
            this.tres_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel83 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel84 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel85 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel86 = new MetroFramework.Controls.MetroLabel();
            this.tres_codigo = new MetroFramework.Controls.MetroTextBox();
            this.tres_direccion = new MetroFramework.Controls.MetroTextBox();
            this.tres_rfc = new MetroFramework.Controls.MetroTextBox();
            this.tres_Razon = new MetroFramework.Controls.MetroTextBox();
            this.tres_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel87 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel88 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel89 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel90 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel91 = new MetroFramework.Controls.MetroLabel();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.Additional_7 = new MetroFramework.Controls.MetroTextBox();
            this.siete_telefono = new MetroFramework.Controls.MetroTextBox();
            this.siete_email = new MetroFramework.Controls.MetroTextBox();
            this.siete_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel74 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel75 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel76 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel77 = new MetroFramework.Controls.MetroLabel();
            this.siete_codigo = new MetroFramework.Controls.MetroTextBox();
            this.siete_direccion = new MetroFramework.Controls.MetroTextBox();
            this.siete_rfc = new MetroFramework.Controls.MetroTextBox();
            this.siete_razon = new MetroFramework.Controls.MetroTextBox();
            this.siete_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel78 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel79 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel80 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel81 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel82 = new MetroFramework.Controls.MetroLabel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.Additional_2 = new MetroFramework.Controls.MetroTextBox();
            this.dos_telefono = new MetroFramework.Controls.MetroTextBox();
            this.dos_email = new MetroFramework.Controls.MetroTextBox();
            this.dos_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel65 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel66 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel67 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel68 = new MetroFramework.Controls.MetroLabel();
            this.dos_codigo = new MetroFramework.Controls.MetroTextBox();
            this.dos_direccion = new MetroFramework.Controls.MetroTextBox();
            this.dos_rfc = new MetroFramework.Controls.MetroTextBox();
            this.dos_razon = new MetroFramework.Controls.MetroTextBox();
            this.dos_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel69 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel70 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel71 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel72 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel73 = new MetroFramework.Controls.MetroLabel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.Additional_1 = new MetroFramework.Controls.MetroTextBox();
            this.uno_telefono = new MetroFramework.Controls.MetroTextBox();
            this.uno_email = new MetroFramework.Controls.MetroTextBox();
            this.uno_contacto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel64 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel63 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel62 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel61 = new MetroFramework.Controls.MetroLabel();
            this.uno_codigo = new MetroFramework.Controls.MetroTextBox();
            this.uno_direccion = new MetroFramework.Controls.MetroTextBox();
            this.uno_rfc = new MetroFramework.Controls.MetroTextBox();
            this.uno_razon = new MetroFramework.Controls.MetroTextBox();
            this.uno_hotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel60 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel59 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel58 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel57 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel56 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.preliminar_button = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTotalIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocDic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocNov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocSep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocAgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocJul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocJun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocAbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocMar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocFeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocEne)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeMF_box)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // generar_OI
            // 
            this.generar_OI.ActiveControl = null;
            this.generar_OI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(88)))));
            this.generar_OI.ForeColor = System.Drawing.Color.Black;
            this.generar_OI.Location = new System.Drawing.Point(1063, 636);
            this.generar_OI.Name = "generar_OI";
            this.generar_OI.Size = new System.Drawing.Size(167, 41);
            this.generar_OI.Style = MetroFramework.MetroColorStyle.Lime;
            this.generar_OI.TabIndex = 0;
            this.generar_OI.Text = "Autorizar OI";
            this.generar_OI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generar_OI.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.generar_OI.UseCustomForeColor = true;
            this.generar_OI.UseSelectable = true;
            this.generar_OI.Click += new System.EventHandler(this.Generar_OI_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1220, 556);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.groupBox25);
            this.metroTabPage1.Controls.Add(this.groupBox9);
            this.metroTabPage1.Controls.Add(this.groupBox10);
            this.metroTabPage1.Controls.Add(this.groupBox4);
            this.metroTabPage1.Controls.Add(this.groupBox3);
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1212, 514);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Orden de Inserción";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox25
            // 
            this.groupBox25.BackColor = System.Drawing.Color.White;
            this.groupBox25.Controls.Add(this.hotelbox);
            this.groupBox25.Controls.Add(this.corbox);
            this.groupBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox25.Location = new System.Drawing.Point(614, 906);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(576, 138);
            this.groupBox25.TabIndex = 279;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Facturar por";
            // 
            // hotelbox
            // 
            this.hotelbox.AutoSize = true;
            this.hotelbox.Location = new System.Drawing.Point(17, 91);
            this.hotelbox.Name = "hotelbox";
            this.hotelbox.Size = new System.Drawing.Size(52, 15);
            this.hotelbox.TabIndex = 3;
            this.hotelbox.Text = "Hotel";
            this.hotelbox.UseSelectable = true;
            // 
            // corbox
            // 
            this.corbox.AutoSize = true;
            this.corbox.Location = new System.Drawing.Point(17, 50);
            this.corbox.Name = "corbox";
            this.corbox.Size = new System.Drawing.Size(86, 15);
            this.corbox.TabIndex = 2;
            this.corbox.Text = "Corporativo";
            this.corbox.UseSelectable = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.textFechaMedia);
            this.groupBox9.Controls.Add(this.textCargo_m);
            this.groupBox9.Controls.Add(this.textNombre_m);
            this.groupBox9.Controls.Add(this.metroLabel53);
            this.groupBox9.Controls.Add(this.metroLabel54);
            this.groupBox9.Controls.Add(this.metroLabel55);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(614, 1974);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(576, 150);
            this.groupBox9.TabIndex = 283;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Best Travel Media";
            // 
            // textFechaMedia
            // 
            // 
            // 
            // 
            this.textFechaMedia.CustomButton.Image = null;
            this.textFechaMedia.CustomButton.Location = new System.Drawing.Point(432, 1);
            this.textFechaMedia.CustomButton.Name = "";
            this.textFechaMedia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textFechaMedia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textFechaMedia.CustomButton.TabIndex = 1;
            this.textFechaMedia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textFechaMedia.CustomButton.UseSelectable = true;
            this.textFechaMedia.CustomButton.Visible = false;
            this.textFechaMedia.Lines = new string[] {
        " "};
            this.textFechaMedia.Location = new System.Drawing.Point(101, 103);
            this.textFechaMedia.MaxLength = 32767;
            this.textFechaMedia.Name = "textFechaMedia";
            this.textFechaMedia.PasswordChar = '\0';
            this.textFechaMedia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFechaMedia.SelectedText = "";
            this.textFechaMedia.SelectionLength = 0;
            this.textFechaMedia.SelectionStart = 0;
            this.textFechaMedia.ShortcutsEnabled = true;
            this.textFechaMedia.Size = new System.Drawing.Size(454, 23);
            this.textFechaMedia.TabIndex = 282;
            this.textFechaMedia.Text = " ";
            this.textFechaMedia.UseSelectable = true;
            this.textFechaMedia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFechaMedia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textCargo_m
            // 
            // 
            // 
            // 
            this.textCargo_m.CustomButton.Image = null;
            this.textCargo_m.CustomButton.Location = new System.Drawing.Point(454, 1);
            this.textCargo_m.CustomButton.Name = "";
            this.textCargo_m.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textCargo_m.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textCargo_m.CustomButton.TabIndex = 1;
            this.textCargo_m.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textCargo_m.CustomButton.UseSelectable = true;
            this.textCargo_m.CustomButton.Visible = false;
            this.textCargo_m.Lines = new string[] {
        " Supply Manager"};
            this.textCargo_m.Location = new System.Drawing.Point(79, 74);
            this.textCargo_m.MaxLength = 32767;
            this.textCargo_m.Name = "textCargo_m";
            this.textCargo_m.PasswordChar = '\0';
            this.textCargo_m.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textCargo_m.SelectedText = "";
            this.textCargo_m.SelectionLength = 0;
            this.textCargo_m.SelectionStart = 0;
            this.textCargo_m.ShortcutsEnabled = true;
            this.textCargo_m.Size = new System.Drawing.Size(476, 23);
            this.textCargo_m.TabIndex = 281;
            this.textCargo_m.Text = " Supply Manager";
            this.textCargo_m.UseSelectable = true;
            this.textCargo_m.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textCargo_m.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textNombre_m
            // 
            // 
            // 
            // 
            this.textNombre_m.CustomButton.Image = null;
            this.textNombre_m.CustomButton.Location = new System.Drawing.Point(454, 1);
            this.textNombre_m.CustomButton.Name = "";
            this.textNombre_m.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textNombre_m.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textNombre_m.CustomButton.TabIndex = 1;
            this.textNombre_m.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textNombre_m.CustomButton.UseSelectable = true;
            this.textNombre_m.CustomButton.Visible = false;
            this.textNombre_m.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textNombre_m.Lines = new string[] {
        " "};
            this.textNombre_m.Location = new System.Drawing.Point(79, 45);
            this.textNombre_m.MaxLength = 32767;
            this.textNombre_m.Name = "textNombre_m";
            this.textNombre_m.PasswordChar = '\0';
            this.textNombre_m.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textNombre_m.SelectedText = "";
            this.textNombre_m.SelectionLength = 0;
            this.textNombre_m.SelectionStart = 0;
            this.textNombre_m.ShortcutsEnabled = true;
            this.textNombre_m.Size = new System.Drawing.Size(476, 23);
            this.textNombre_m.TabIndex = 280;
            this.textNombre_m.Text = " ";
            this.textNombre_m.UseSelectable = true;
            this.textNombre_m.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textNombre_m.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel53
            // 
            this.metroLabel53.AutoSize = true;
            this.metroLabel53.Location = new System.Drawing.Point(11, 103);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(84, 19);
            this.metroLabel53.TabIndex = 279;
            this.metroLabel53.Text = "Fecha Firma:";
            // 
            // metroLabel54
            // 
            this.metroLabel54.AutoSize = true;
            this.metroLabel54.Location = new System.Drawing.Point(11, 74);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(49, 19);
            this.metroLabel54.TabIndex = 278;
            this.metroLabel54.Text = "Cargo:";
            // 
            // metroLabel55
            // 
            this.metroLabel55.AutoSize = true;
            this.metroLabel55.Location = new System.Drawing.Point(11, 45);
            this.metroLabel55.Name = "metroLabel55";
            this.metroLabel55.Size = new System.Drawing.Size(62, 19);
            this.metroLabel55.TabIndex = 277;
            this.metroLabel55.Text = "Nombre:";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.White;
            this.groupBox10.Controls.Add(this.textFechaCliente);
            this.groupBox10.Controls.Add(this.textCargo_c);
            this.groupBox10.Controls.Add(this.textNombre_c);
            this.groupBox10.Controls.Add(this.metroLabel52);
            this.groupBox10.Controls.Add(this.metroLabel51);
            this.groupBox10.Controls.Add(this.metroLabel50);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox10.Location = new System.Drawing.Point(5, 1978);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(576, 146);
            this.groupBox10.TabIndex = 282;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "El Cliente";
            // 
            // textFechaCliente
            // 
            // 
            // 
            // 
            this.textFechaCliente.CustomButton.Image = null;
            this.textFechaCliente.CustomButton.Location = new System.Drawing.Point(440, 1);
            this.textFechaCliente.CustomButton.Name = "";
            this.textFechaCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textFechaCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textFechaCliente.CustomButton.TabIndex = 1;
            this.textFechaCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textFechaCliente.CustomButton.UseSelectable = true;
            this.textFechaCliente.CustomButton.Visible = false;
            this.textFechaCliente.Lines = new string[] {
        " "};
            this.textFechaCliente.Location = new System.Drawing.Point(100, 99);
            this.textFechaCliente.MaxLength = 32767;
            this.textFechaCliente.Name = "textFechaCliente";
            this.textFechaCliente.PasswordChar = '\0';
            this.textFechaCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFechaCliente.SelectedText = "";
            this.textFechaCliente.SelectionLength = 0;
            this.textFechaCliente.SelectionStart = 0;
            this.textFechaCliente.ShortcutsEnabled = true;
            this.textFechaCliente.Size = new System.Drawing.Size(462, 23);
            this.textFechaCliente.TabIndex = 279;
            this.textFechaCliente.Text = " ";
            this.textFechaCliente.UseSelectable = true;
            this.textFechaCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textFechaCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textCargo_c
            // 
            // 
            // 
            // 
            this.textCargo_c.CustomButton.Image = null;
            this.textCargo_c.CustomButton.Location = new System.Drawing.Point(462, 1);
            this.textCargo_c.CustomButton.Name = "";
            this.textCargo_c.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textCargo_c.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textCargo_c.CustomButton.TabIndex = 1;
            this.textCargo_c.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textCargo_c.CustomButton.UseSelectable = true;
            this.textCargo_c.CustomButton.Visible = false;
            this.textCargo_c.Lines = new string[] {
        " "};
            this.textCargo_c.Location = new System.Drawing.Point(78, 70);
            this.textCargo_c.MaxLength = 32767;
            this.textCargo_c.Name = "textCargo_c";
            this.textCargo_c.PasswordChar = '\0';
            this.textCargo_c.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textCargo_c.SelectedText = "";
            this.textCargo_c.SelectionLength = 0;
            this.textCargo_c.SelectionStart = 0;
            this.textCargo_c.ShortcutsEnabled = true;
            this.textCargo_c.Size = new System.Drawing.Size(484, 23);
            this.textCargo_c.TabIndex = 278;
            this.textCargo_c.Text = " ";
            this.textCargo_c.UseSelectable = true;
            this.textCargo_c.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textCargo_c.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textNombre_c
            // 
            // 
            // 
            // 
            this.textNombre_c.CustomButton.Image = null;
            this.textNombre_c.CustomButton.Location = new System.Drawing.Point(462, 1);
            this.textNombre_c.CustomButton.Name = "";
            this.textNombre_c.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textNombre_c.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textNombre_c.CustomButton.TabIndex = 1;
            this.textNombre_c.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textNombre_c.CustomButton.UseSelectable = true;
            this.textNombre_c.CustomButton.Visible = false;
            this.textNombre_c.Lines = new string[] {
        "  "};
            this.textNombre_c.Location = new System.Drawing.Point(78, 41);
            this.textNombre_c.MaxLength = 32767;
            this.textNombre_c.Name = "textNombre_c";
            this.textNombre_c.PasswordChar = '\0';
            this.textNombre_c.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textNombre_c.SelectedText = "";
            this.textNombre_c.SelectionLength = 0;
            this.textNombre_c.SelectionStart = 0;
            this.textNombre_c.ShortcutsEnabled = true;
            this.textNombre_c.Size = new System.Drawing.Size(484, 23);
            this.textNombre_c.TabIndex = 277;
            this.textNombre_c.Text = "  ";
            this.textNombre_c.UseSelectable = true;
            this.textNombre_c.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textNombre_c.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.Location = new System.Drawing.Point(10, 104);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(84, 19);
            this.metroLabel52.TabIndex = 276;
            this.metroLabel52.Text = "Fecha Firma:";
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.Location = new System.Drawing.Point(10, 73);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(49, 19);
            this.metroLabel51.TabIndex = 275;
            this.metroLabel51.Text = "Cargo:";
            // 
            // metroLabel50
            // 
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.Location = new System.Drawing.Point(10, 40);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(62, 19);
            this.metroLabel50.TabIndex = 274;
            this.metroLabel50.Text = "Nombre:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.textCondiciones);
            this.groupBox4.Controls.Add(this.metroLabel49);
            this.groupBox4.Controls.Add(this.groupBox21);
            this.groupBox4.Controls.Add(this.groupBox20);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(5, 1057);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1185, 903);
            this.groupBox4.TabIndex = 281;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Esquema Comercial y Forma de Pago";
            // 
            // textCondiciones
            // 
            // 
            // 
            // 
            this.textCondiciones.CustomButton.Image = null;
            this.textCondiciones.CustomButton.Location = new System.Drawing.Point(1060, 1);
            this.textCondiciones.CustomButton.Name = "";
            this.textCondiciones.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.textCondiciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textCondiciones.CustomButton.TabIndex = 1;
            this.textCondiciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textCondiciones.CustomButton.UseSelectable = true;
            this.textCondiciones.CustomButton.Visible = false;
            this.textCondiciones.Lines = new string[] {
        " "};
            this.textCondiciones.Location = new System.Drawing.Point(10, 793);
            this.textCondiciones.MaxLength = 32767;
            this.textCondiciones.Multiline = true;
            this.textCondiciones.Name = "textCondiciones";
            this.textCondiciones.PasswordChar = '\0';
            this.textCondiciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textCondiciones.SelectedText = "";
            this.textCondiciones.SelectionLength = 0;
            this.textCondiciones.SelectionStart = 0;
            this.textCondiciones.ShortcutsEnabled = true;
            this.textCondiciones.Size = new System.Drawing.Size(1154, 95);
            this.textCondiciones.TabIndex = 338;
            this.textCondiciones.Text = " ";
            this.textCondiciones.UseSelectable = true;
            this.textCondiciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textCondiciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.Location = new System.Drawing.Point(10, 760);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(87, 19);
            this.metroLabel49.TabIndex = 337;
            this.metroLabel49.Text = "Comentarios:";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.metroLabel119);
            this.groupBox21.Controls.Add(this.metroCheckBox1);
            this.groupBox21.Controls.Add(this.textTotalIVA);
            this.groupBox21.Controls.Add(this.c_c_facturas);
            this.groupBox21.Controls.Add(this.c_t_bancaria);
            this.groupBox21.Controls.Add(this.metroLabel48);
            this.groupBox21.Controls.Add(this.Sumar);
            this.groupBox21.Controls.Add(this.metroLabel47);
            this.groupBox21.Controls.Add(this.textBoxDic);
            this.groupBox21.Controls.Add(this.textBoxNov);
            this.groupBox21.Controls.Add(this.textBoxOct);
            this.groupBox21.Controls.Add(this.textBoxSep);
            this.groupBox21.Controls.Add(this.textBoxAgo);
            this.groupBox21.Controls.Add(this.textBoxJul);
            this.groupBox21.Controls.Add(this.textBoxJun);
            this.groupBox21.Controls.Add(this.textBoxMay);
            this.groupBox21.Controls.Add(this.textBoxAbr);
            this.groupBox21.Controls.Add(this.textBoxMar);
            this.groupBox21.Controls.Add(this.textBoxFeb);
            this.groupBox21.Controls.Add(this.textBoxEne);
            this.groupBox21.Controls.Add(this.metroLabel46);
            this.groupBox21.Controls.Add(this.comboBoxDic);
            this.groupBox21.Controls.Add(this.comboNov);
            this.groupBox21.Controls.Add(this.comboOct);
            this.groupBox21.Controls.Add(this.comboSep);
            this.groupBox21.Controls.Add(this.comboAgo);
            this.groupBox21.Controls.Add(this.comboJul);
            this.groupBox21.Controls.Add(this.comboJun);
            this.groupBox21.Controls.Add(this.comboMay);
            this.groupBox21.Controls.Add(this.comboAbr);
            this.groupBox21.Controls.Add(this.comboMar);
            this.groupBox21.Controls.Add(this.comboFeb);
            this.groupBox21.Controls.Add(this.metroLabel45);
            this.groupBox21.Controls.Add(this.comboEne);
            this.groupBox21.Controls.Add(this.metroLabel44);
            this.groupBox21.Controls.Add(this.metroLabel43);
            this.groupBox21.Controls.Add(this.anioDic);
            this.groupBox21.Controls.Add(this.anioNov);
            this.groupBox21.Controls.Add(this.anioOct);
            this.groupBox21.Controls.Add(this.anioSep);
            this.groupBox21.Controls.Add(this.anioAgo);
            this.groupBox21.Controls.Add(this.anioJul);
            this.groupBox21.Controls.Add(this.anioJun);
            this.groupBox21.Controls.Add(this.anioMay);
            this.groupBox21.Controls.Add(this.anioAbr);
            this.groupBox21.Controls.Add(this.anioMar);
            this.groupBox21.Controls.Add(this.anioFeb);
            this.groupBox21.Controls.Add(this.anioEne);
            this.groupBox21.Controls.Add(this.metroLabel42);
            this.groupBox21.Controls.Add(this.facturadoDic);
            this.groupBox21.Controls.Add(this.facturadoNov);
            this.groupBox21.Controls.Add(this.facturadoOct);
            this.groupBox21.Controls.Add(this.facturadoSep);
            this.groupBox21.Controls.Add(this.facturadoAgo);
            this.groupBox21.Controls.Add(this.facturadoJul);
            this.groupBox21.Controls.Add(this.facturadoJun);
            this.groupBox21.Controls.Add(this.facturadoMay);
            this.groupBox21.Controls.Add(this.facturadoAbr);
            this.groupBox21.Controls.Add(this.facturadoMar);
            this.groupBox21.Controls.Add(this.facturadoFeb);
            this.groupBox21.Controls.Add(this.facturadoEne);
            this.groupBox21.Controls.Add(this.textDocDic);
            this.groupBox21.Controls.Add(this.textDocNov);
            this.groupBox21.Controls.Add(this.textDocOct);
            this.groupBox21.Controls.Add(this.textDocSep);
            this.groupBox21.Controls.Add(this.textDocAgo);
            this.groupBox21.Controls.Add(this.textDocJul);
            this.groupBox21.Controls.Add(this.textDocJun);
            this.groupBox21.Controls.Add(this.textDocMay);
            this.groupBox21.Controls.Add(this.textDocAbr);
            this.groupBox21.Controls.Add(this.textDocMar);
            this.groupBox21.Controls.Add(this.textDocFeb);
            this.groupBox21.Controls.Add(this.textDocEne);
            this.groupBox21.Location = new System.Drawing.Point(10, 161);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(1163, 580);
            this.groupBox21.TabIndex = 336;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Vía de Facturación Mensual";
            // 
            // metroLabel119
            // 
            this.metroLabel119.AutoSize = true;
            this.metroLabel119.Location = new System.Drawing.Point(217, 530);
            this.metroLabel119.Name = "metroLabel119";
            this.metroLabel119.Size = new System.Drawing.Size(13, 19);
            this.metroLabel119.TabIndex = 482;
            this.metroLabel119.Text = " ";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(244, 2);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox1.TabIndex = 370;
            this.metroCheckBox1.Text = " ";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // textTotalIVA
            // 
            this.textTotalIVA.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textTotalIVA.DoubleValue = 0D;
            this.textTotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalIVA.Location = new System.Drawing.Point(111, 527);
            this.textTotalIVA.Name = "textTotalIVA";
            this.textTotalIVA.Size = new System.Drawing.Size(100, 22);
            this.textTotalIVA.TabIndex = 481;
            this.textTotalIVA.Text = "0.00";
            // 
            // c_c_facturas
            // 
            this.c_c_facturas.AutoSize = true;
            this.c_c_facturas.Location = new System.Drawing.Point(610, 531);
            this.c_c_facturas.Name = "c_c_facturas";
            this.c_c_facturas.Size = new System.Drawing.Size(166, 15);
            this.c_c_facturas.TabIndex = 480;
            this.c_c_facturas.Text = "Compensación en Facturas";
            this.c_c_facturas.UseSelectable = true;
            // 
            // c_t_bancaria
            // 
            this.c_t_bancaria.AutoSize = true;
            this.c_t_bancaria.Location = new System.Drawing.Point(449, 531);
            this.c_t_bancaria.Name = "c_t_bancaria";
            this.c_t_bancaria.Size = new System.Drawing.Size(140, 15);
            this.c_t_bancaria.TabIndex = 479;
            this.c_t_bancaria.Text = "Transferencia Bancaria";
            this.c_t_bancaria.UseSelectable = true;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Location = new System.Drawing.Point(339, 527);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(104, 19);
            this.metroLabel48.TabIndex = 478;
            this.metroLabel48.Text = "Forma de Pago:";
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(1044, 488);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(99, 23);
            this.Sumar.Style = MetroFramework.MetroColorStyle.Orange;
            this.Sumar.TabIndex = 477;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseSelectable = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // metroLabel47
            // 
            this.metroLabel47.AutoSize = true;
            this.metroLabel47.Location = new System.Drawing.Point(18, 527);
            this.metroLabel47.Name = "metroLabel47";
            this.metroLabel47.Size = new System.Drawing.Size(87, 19);
            this.metroLabel47.TabIndex = 475;
            this.metroLabel47.Text = "Total con IVA:";
            // 
            // textBoxDic
            // 
            // 
            // 
            // 
            this.textBoxDic.CustomButton.Image = null;
            this.textBoxDic.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxDic.CustomButton.Name = "";
            this.textBoxDic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxDic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDic.CustomButton.TabIndex = 1;
            this.textBoxDic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDic.CustomButton.UseSelectable = true;
            this.textBoxDic.CustomButton.Visible = false;
            this.textBoxDic.Lines = new string[] {
        " "};
            this.textBoxDic.Location = new System.Drawing.Point(627, 450);
            this.textBoxDic.MaxLength = 32767;
            this.textBoxDic.Name = "textBoxDic";
            this.textBoxDic.PasswordChar = '\0';
            this.textBoxDic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDic.SelectedText = "";
            this.textBoxDic.SelectionLength = 0;
            this.textBoxDic.SelectionStart = 0;
            this.textBoxDic.ShortcutsEnabled = true;
            this.textBoxDic.Size = new System.Drawing.Size(516, 23);
            this.textBoxDic.TabIndex = 474;
            this.textBoxDic.Text = " ";
            this.textBoxDic.UseSelectable = true;
            this.textBoxDic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxNov
            // 
            // 
            // 
            // 
            this.textBoxNov.CustomButton.Image = null;
            this.textBoxNov.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxNov.CustomButton.Name = "";
            this.textBoxNov.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxNov.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxNov.CustomButton.TabIndex = 1;
            this.textBoxNov.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxNov.CustomButton.UseSelectable = true;
            this.textBoxNov.CustomButton.Visible = false;
            this.textBoxNov.Lines = new string[] {
        " "};
            this.textBoxNov.Location = new System.Drawing.Point(627, 415);
            this.textBoxNov.MaxLength = 32767;
            this.textBoxNov.Name = "textBoxNov";
            this.textBoxNov.PasswordChar = '\0';
            this.textBoxNov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxNov.SelectedText = "";
            this.textBoxNov.SelectionLength = 0;
            this.textBoxNov.SelectionStart = 0;
            this.textBoxNov.ShortcutsEnabled = true;
            this.textBoxNov.Size = new System.Drawing.Size(516, 23);
            this.textBoxNov.TabIndex = 473;
            this.textBoxNov.Text = " ";
            this.textBoxNov.UseSelectable = true;
            this.textBoxNov.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxNov.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxOct
            // 
            // 
            // 
            // 
            this.textBoxOct.CustomButton.Image = null;
            this.textBoxOct.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxOct.CustomButton.Name = "";
            this.textBoxOct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxOct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxOct.CustomButton.TabIndex = 1;
            this.textBoxOct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxOct.CustomButton.UseSelectable = true;
            this.textBoxOct.CustomButton.Visible = false;
            this.textBoxOct.Lines = new string[] {
        " "};
            this.textBoxOct.Location = new System.Drawing.Point(627, 380);
            this.textBoxOct.MaxLength = 32767;
            this.textBoxOct.Name = "textBoxOct";
            this.textBoxOct.PasswordChar = '\0';
            this.textBoxOct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxOct.SelectedText = "";
            this.textBoxOct.SelectionLength = 0;
            this.textBoxOct.SelectionStart = 0;
            this.textBoxOct.ShortcutsEnabled = true;
            this.textBoxOct.Size = new System.Drawing.Size(516, 23);
            this.textBoxOct.TabIndex = 472;
            this.textBoxOct.Text = " ";
            this.textBoxOct.UseSelectable = true;
            this.textBoxOct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxOct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxSep
            // 
            // 
            // 
            // 
            this.textBoxSep.CustomButton.Image = null;
            this.textBoxSep.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxSep.CustomButton.Name = "";
            this.textBoxSep.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSep.CustomButton.TabIndex = 1;
            this.textBoxSep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSep.CustomButton.UseSelectable = true;
            this.textBoxSep.CustomButton.Visible = false;
            this.textBoxSep.Lines = new string[] {
        " "};
            this.textBoxSep.Location = new System.Drawing.Point(627, 345);
            this.textBoxSep.MaxLength = 32767;
            this.textBoxSep.Name = "textBoxSep";
            this.textBoxSep.PasswordChar = '\0';
            this.textBoxSep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSep.SelectedText = "";
            this.textBoxSep.SelectionLength = 0;
            this.textBoxSep.SelectionStart = 0;
            this.textBoxSep.ShortcutsEnabled = true;
            this.textBoxSep.Size = new System.Drawing.Size(516, 23);
            this.textBoxSep.TabIndex = 471;
            this.textBoxSep.Text = " ";
            this.textBoxSep.UseSelectable = true;
            this.textBoxSep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxAgo
            // 
            // 
            // 
            // 
            this.textBoxAgo.CustomButton.Image = null;
            this.textBoxAgo.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxAgo.CustomButton.Name = "";
            this.textBoxAgo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxAgo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxAgo.CustomButton.TabIndex = 1;
            this.textBoxAgo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxAgo.CustomButton.UseSelectable = true;
            this.textBoxAgo.CustomButton.Visible = false;
            this.textBoxAgo.Lines = new string[] {
        " "};
            this.textBoxAgo.Location = new System.Drawing.Point(627, 310);
            this.textBoxAgo.MaxLength = 32767;
            this.textBoxAgo.Name = "textBoxAgo";
            this.textBoxAgo.PasswordChar = '\0';
            this.textBoxAgo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAgo.SelectedText = "";
            this.textBoxAgo.SelectionLength = 0;
            this.textBoxAgo.SelectionStart = 0;
            this.textBoxAgo.ShortcutsEnabled = true;
            this.textBoxAgo.Size = new System.Drawing.Size(516, 23);
            this.textBoxAgo.TabIndex = 470;
            this.textBoxAgo.Text = " ";
            this.textBoxAgo.UseSelectable = true;
            this.textBoxAgo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxAgo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxJul
            // 
            // 
            // 
            // 
            this.textBoxJul.CustomButton.Image = null;
            this.textBoxJul.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxJul.CustomButton.Name = "";
            this.textBoxJul.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxJul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxJul.CustomButton.TabIndex = 1;
            this.textBoxJul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxJul.CustomButton.UseSelectable = true;
            this.textBoxJul.CustomButton.Visible = false;
            this.textBoxJul.Lines = new string[] {
        " "};
            this.textBoxJul.Location = new System.Drawing.Point(627, 275);
            this.textBoxJul.MaxLength = 32767;
            this.textBoxJul.Name = "textBoxJul";
            this.textBoxJul.PasswordChar = '\0';
            this.textBoxJul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxJul.SelectedText = "";
            this.textBoxJul.SelectionLength = 0;
            this.textBoxJul.SelectionStart = 0;
            this.textBoxJul.ShortcutsEnabled = true;
            this.textBoxJul.Size = new System.Drawing.Size(516, 23);
            this.textBoxJul.TabIndex = 469;
            this.textBoxJul.Text = " ";
            this.textBoxJul.UseSelectable = true;
            this.textBoxJul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxJul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxJun
            // 
            // 
            // 
            // 
            this.textBoxJun.CustomButton.Image = null;
            this.textBoxJun.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxJun.CustomButton.Name = "";
            this.textBoxJun.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxJun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxJun.CustomButton.TabIndex = 1;
            this.textBoxJun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxJun.CustomButton.UseSelectable = true;
            this.textBoxJun.CustomButton.Visible = false;
            this.textBoxJun.Lines = new string[] {
        " "};
            this.textBoxJun.Location = new System.Drawing.Point(627, 240);
            this.textBoxJun.MaxLength = 32767;
            this.textBoxJun.Name = "textBoxJun";
            this.textBoxJun.PasswordChar = '\0';
            this.textBoxJun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxJun.SelectedText = "";
            this.textBoxJun.SelectionLength = 0;
            this.textBoxJun.SelectionStart = 0;
            this.textBoxJun.ShortcutsEnabled = true;
            this.textBoxJun.Size = new System.Drawing.Size(516, 23);
            this.textBoxJun.TabIndex = 468;
            this.textBoxJun.Text = " ";
            this.textBoxJun.UseSelectable = true;
            this.textBoxJun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxJun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxMay
            // 
            // 
            // 
            // 
            this.textBoxMay.CustomButton.Image = null;
            this.textBoxMay.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxMay.CustomButton.Name = "";
            this.textBoxMay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxMay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxMay.CustomButton.TabIndex = 1;
            this.textBoxMay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxMay.CustomButton.UseSelectable = true;
            this.textBoxMay.CustomButton.Visible = false;
            this.textBoxMay.Lines = new string[] {
        " "};
            this.textBoxMay.Location = new System.Drawing.Point(627, 205);
            this.textBoxMay.MaxLength = 32767;
            this.textBoxMay.Name = "textBoxMay";
            this.textBoxMay.PasswordChar = '\0';
            this.textBoxMay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMay.SelectedText = "";
            this.textBoxMay.SelectionLength = 0;
            this.textBoxMay.SelectionStart = 0;
            this.textBoxMay.ShortcutsEnabled = true;
            this.textBoxMay.Size = new System.Drawing.Size(516, 23);
            this.textBoxMay.TabIndex = 467;
            this.textBoxMay.Text = " ";
            this.textBoxMay.UseSelectable = true;
            this.textBoxMay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxMay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxAbr
            // 
            // 
            // 
            // 
            this.textBoxAbr.CustomButton.Image = null;
            this.textBoxAbr.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxAbr.CustomButton.Name = "";
            this.textBoxAbr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxAbr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxAbr.CustomButton.TabIndex = 1;
            this.textBoxAbr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxAbr.CustomButton.UseSelectable = true;
            this.textBoxAbr.CustomButton.Visible = false;
            this.textBoxAbr.Lines = new string[] {
        " "};
            this.textBoxAbr.Location = new System.Drawing.Point(627, 170);
            this.textBoxAbr.MaxLength = 32767;
            this.textBoxAbr.Name = "textBoxAbr";
            this.textBoxAbr.PasswordChar = '\0';
            this.textBoxAbr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAbr.SelectedText = "";
            this.textBoxAbr.SelectionLength = 0;
            this.textBoxAbr.SelectionStart = 0;
            this.textBoxAbr.ShortcutsEnabled = true;
            this.textBoxAbr.Size = new System.Drawing.Size(516, 23);
            this.textBoxAbr.TabIndex = 466;
            this.textBoxAbr.Text = " ";
            this.textBoxAbr.UseSelectable = true;
            this.textBoxAbr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxAbr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxMar
            // 
            // 
            // 
            // 
            this.textBoxMar.CustomButton.Image = null;
            this.textBoxMar.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxMar.CustomButton.Name = "";
            this.textBoxMar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxMar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxMar.CustomButton.TabIndex = 1;
            this.textBoxMar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxMar.CustomButton.UseSelectable = true;
            this.textBoxMar.CustomButton.Visible = false;
            this.textBoxMar.Lines = new string[] {
        " "};
            this.textBoxMar.Location = new System.Drawing.Point(627, 135);
            this.textBoxMar.MaxLength = 32767;
            this.textBoxMar.Name = "textBoxMar";
            this.textBoxMar.PasswordChar = '\0';
            this.textBoxMar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMar.SelectedText = "";
            this.textBoxMar.SelectionLength = 0;
            this.textBoxMar.SelectionStart = 0;
            this.textBoxMar.ShortcutsEnabled = true;
            this.textBoxMar.Size = new System.Drawing.Size(516, 23);
            this.textBoxMar.TabIndex = 465;
            this.textBoxMar.Text = " ";
            this.textBoxMar.UseSelectable = true;
            this.textBoxMar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxMar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxFeb
            // 
            // 
            // 
            // 
            this.textBoxFeb.CustomButton.Image = null;
            this.textBoxFeb.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxFeb.CustomButton.Name = "";
            this.textBoxFeb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxFeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxFeb.CustomButton.TabIndex = 1;
            this.textBoxFeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxFeb.CustomButton.UseSelectable = true;
            this.textBoxFeb.CustomButton.Visible = false;
            this.textBoxFeb.Lines = new string[] {
        " "};
            this.textBoxFeb.Location = new System.Drawing.Point(627, 100);
            this.textBoxFeb.MaxLength = 32767;
            this.textBoxFeb.Name = "textBoxFeb";
            this.textBoxFeb.PasswordChar = '\0';
            this.textBoxFeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxFeb.SelectedText = "";
            this.textBoxFeb.SelectionLength = 0;
            this.textBoxFeb.SelectionStart = 0;
            this.textBoxFeb.ShortcutsEnabled = true;
            this.textBoxFeb.Size = new System.Drawing.Size(516, 23);
            this.textBoxFeb.TabIndex = 464;
            this.textBoxFeb.Text = " ";
            this.textBoxFeb.UseSelectable = true;
            this.textBoxFeb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxFeb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxEne
            // 
            // 
            // 
            // 
            this.textBoxEne.CustomButton.Image = null;
            this.textBoxEne.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.textBoxEne.CustomButton.Name = "";
            this.textBoxEne.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxEne.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxEne.CustomButton.TabIndex = 1;
            this.textBoxEne.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxEne.CustomButton.UseSelectable = true;
            this.textBoxEne.CustomButton.Visible = false;
            this.textBoxEne.Lines = new string[] {
        " "};
            this.textBoxEne.Location = new System.Drawing.Point(627, 65);
            this.textBoxEne.MaxLength = 32767;
            this.textBoxEne.Name = "textBoxEne";
            this.textBoxEne.PasswordChar = '\0';
            this.textBoxEne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEne.SelectedText = "";
            this.textBoxEne.SelectionLength = 0;
            this.textBoxEne.SelectionStart = 0;
            this.textBoxEne.ShortcutsEnabled = true;
            this.textBoxEne.Size = new System.Drawing.Size(516, 23);
            this.textBoxEne.TabIndex = 463;
            this.textBoxEne.Text = " ";
            this.textBoxEne.UseSelectable = true;
            this.textBoxEne.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxEne.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel46
            // 
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.Location = new System.Drawing.Point(627, 37);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(140, 19);
            this.metroLabel46.TabIndex = 462;
            this.metroLabel46.Text = "Información Adicional:";
            // 
            // comboBoxDic
            // 
            this.comboBoxDic.FormattingEnabled = true;
            this.comboBoxDic.ItemHeight = 23;
            this.comboBoxDic.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboBoxDic.Location = new System.Drawing.Point(472, 444);
            this.comboBoxDic.Name = "comboBoxDic";
            this.comboBoxDic.Size = new System.Drawing.Size(121, 29);
            this.comboBoxDic.TabIndex = 461;
            this.comboBoxDic.UseSelectable = true;
            this.comboBoxDic.SelectedIndexChanged += new System.EventHandler(this.comboBoxDic_SelectedIndexChanged);
            // 
            // comboNov
            // 
            this.comboNov.FormattingEnabled = true;
            this.comboNov.ItemHeight = 23;
            this.comboNov.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboNov.Location = new System.Drawing.Point(472, 409);
            this.comboNov.Name = "comboNov";
            this.comboNov.Size = new System.Drawing.Size(121, 29);
            this.comboNov.TabIndex = 460;
            this.comboNov.UseSelectable = true;
            this.comboNov.SelectedIndexChanged += new System.EventHandler(this.comboNov_SelectedIndexChanged);
            // 
            // comboOct
            // 
            this.comboOct.FormattingEnabled = true;
            this.comboOct.ItemHeight = 23;
            this.comboOct.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboOct.Location = new System.Drawing.Point(472, 374);
            this.comboOct.Name = "comboOct";
            this.comboOct.Size = new System.Drawing.Size(121, 29);
            this.comboOct.TabIndex = 459;
            this.comboOct.UseSelectable = true;
            this.comboOct.SelectedIndexChanged += new System.EventHandler(this.comboOct_SelectedIndexChanged);
            // 
            // comboSep
            // 
            this.comboSep.FormattingEnabled = true;
            this.comboSep.ItemHeight = 23;
            this.comboSep.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboSep.Location = new System.Drawing.Point(472, 339);
            this.comboSep.Name = "comboSep";
            this.comboSep.Size = new System.Drawing.Size(121, 29);
            this.comboSep.TabIndex = 458;
            this.comboSep.UseSelectable = true;
            this.comboSep.SelectedIndexChanged += new System.EventHandler(this.comboSep_SelectedIndexChanged);
            // 
            // comboAgo
            // 
            this.comboAgo.FormattingEnabled = true;
            this.comboAgo.ItemHeight = 23;
            this.comboAgo.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboAgo.Location = new System.Drawing.Point(472, 304);
            this.comboAgo.Name = "comboAgo";
            this.comboAgo.Size = new System.Drawing.Size(121, 29);
            this.comboAgo.TabIndex = 457;
            this.comboAgo.UseSelectable = true;
            this.comboAgo.SelectedIndexChanged += new System.EventHandler(this.comboAgo_SelectedIndexChanged);
            // 
            // comboJul
            // 
            this.comboJul.FormattingEnabled = true;
            this.comboJul.ItemHeight = 23;
            this.comboJul.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboJul.Location = new System.Drawing.Point(472, 269);
            this.comboJul.Name = "comboJul";
            this.comboJul.Size = new System.Drawing.Size(121, 29);
            this.comboJul.TabIndex = 456;
            this.comboJul.UseSelectable = true;
            this.comboJul.SelectedIndexChanged += new System.EventHandler(this.comboJul_SelectedIndexChanged);
            // 
            // comboJun
            // 
            this.comboJun.FormattingEnabled = true;
            this.comboJun.ItemHeight = 23;
            this.comboJun.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboJun.Location = new System.Drawing.Point(472, 234);
            this.comboJun.Name = "comboJun";
            this.comboJun.Size = new System.Drawing.Size(121, 29);
            this.comboJun.TabIndex = 455;
            this.comboJun.UseSelectable = true;
            this.comboJun.SelectedIndexChanged += new System.EventHandler(this.comboJun_SelectedIndexChanged);
            // 
            // comboMay
            // 
            this.comboMay.FormattingEnabled = true;
            this.comboMay.ItemHeight = 23;
            this.comboMay.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboMay.Location = new System.Drawing.Point(472, 199);
            this.comboMay.Name = "comboMay";
            this.comboMay.Size = new System.Drawing.Size(121, 29);
            this.comboMay.TabIndex = 454;
            this.comboMay.UseSelectable = true;
            this.comboMay.SelectedIndexChanged += new System.EventHandler(this.comboMay_SelectedIndexChanged);
            // 
            // comboAbr
            // 
            this.comboAbr.FormattingEnabled = true;
            this.comboAbr.ItemHeight = 23;
            this.comboAbr.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboAbr.Location = new System.Drawing.Point(472, 164);
            this.comboAbr.Name = "comboAbr";
            this.comboAbr.Size = new System.Drawing.Size(121, 29);
            this.comboAbr.TabIndex = 453;
            this.comboAbr.UseSelectable = true;
            this.comboAbr.SelectedIndexChanged += new System.EventHandler(this.comboAbr_SelectedIndexChanged);
            // 
            // comboMar
            // 
            this.comboMar.FormattingEnabled = true;
            this.comboMar.ItemHeight = 23;
            this.comboMar.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboMar.Location = new System.Drawing.Point(472, 129);
            this.comboMar.Name = "comboMar";
            this.comboMar.Size = new System.Drawing.Size(121, 29);
            this.comboMar.TabIndex = 452;
            this.comboMar.UseSelectable = true;
            this.comboMar.SelectedIndexChanged += new System.EventHandler(this.comboMar_SelectedIndexChanged);
            // 
            // comboFeb
            // 
            this.comboFeb.FormattingEnabled = true;
            this.comboFeb.ItemHeight = 23;
            this.comboFeb.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboFeb.Location = new System.Drawing.Point(472, 94);
            this.comboFeb.Name = "comboFeb";
            this.comboFeb.Size = new System.Drawing.Size(121, 29);
            this.comboFeb.TabIndex = 451;
            this.comboFeb.UseSelectable = true;
            this.comboFeb.SelectedIndexChanged += new System.EventHandler(this.comboFeb_SelectedIndexChanged);
            // 
            // metroLabel45
            // 
            this.metroLabel45.AutoSize = true;
            this.metroLabel45.Location = new System.Drawing.Point(472, 37);
            this.metroLabel45.Name = "metroLabel45";
            this.metroLabel45.Size = new System.Drawing.Size(45, 19);
            this.metroLabel45.TabIndex = 450;
            this.metroLabel45.Text = "Divisa:";
            // 
            // comboEne
            // 
            this.comboEne.FormattingEnabled = true;
            this.comboEne.ItemHeight = 23;
            this.comboEne.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboEne.Location = new System.Drawing.Point(472, 59);
            this.comboEne.Name = "comboEne";
            this.comboEne.Size = new System.Drawing.Size(121, 29);
            this.comboEne.TabIndex = 449;
            this.comboEne.UseSelectable = true;
            this.comboEne.SelectedIndexChanged += new System.EventHandler(this.comboEne_SelectedIndexChanged);
            // 
            // metroLabel44
            // 
            this.metroLabel44.AutoSize = true;
            this.metroLabel44.Location = new System.Drawing.Point(303, 36);
            this.metroLabel44.Name = "metroLabel44";
            this.metroLabel44.Size = new System.Drawing.Size(108, 19);
            this.metroLabel44.TabIndex = 448;
            this.metroLabel44.Text = "Importe con IVA:";
            // 
            // metroLabel43
            // 
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.Location = new System.Drawing.Point(158, 37);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(36, 19);
            this.metroLabel43.TabIndex = 447;
            this.metroLabel43.Text = "Año:";
            // 
            // anioDic
            // 
            this.anioDic.FormattingEnabled = true;
            this.anioDic.ItemHeight = 23;
            this.anioDic.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioDic.Location = new System.Drawing.Point(158, 443);
            this.anioDic.Name = "anioDic";
            this.anioDic.Size = new System.Drawing.Size(121, 29);
            this.anioDic.TabIndex = 446;
            this.anioDic.UseSelectable = true;
            // 
            // anioNov
            // 
            this.anioNov.FormattingEnabled = true;
            this.anioNov.ItemHeight = 23;
            this.anioNov.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioNov.Location = new System.Drawing.Point(158, 408);
            this.anioNov.Name = "anioNov";
            this.anioNov.Size = new System.Drawing.Size(121, 29);
            this.anioNov.TabIndex = 445;
            this.anioNov.UseSelectable = true;
            // 
            // anioOct
            // 
            this.anioOct.FormattingEnabled = true;
            this.anioOct.ItemHeight = 23;
            this.anioOct.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioOct.Location = new System.Drawing.Point(158, 373);
            this.anioOct.Name = "anioOct";
            this.anioOct.Size = new System.Drawing.Size(121, 29);
            this.anioOct.TabIndex = 444;
            this.anioOct.UseSelectable = true;
            // 
            // anioSep
            // 
            this.anioSep.FormattingEnabled = true;
            this.anioSep.ItemHeight = 23;
            this.anioSep.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioSep.Location = new System.Drawing.Point(158, 339);
            this.anioSep.Name = "anioSep";
            this.anioSep.Size = new System.Drawing.Size(121, 29);
            this.anioSep.TabIndex = 443;
            this.anioSep.UseSelectable = true;
            // 
            // anioAgo
            // 
            this.anioAgo.FormattingEnabled = true;
            this.anioAgo.ItemHeight = 23;
            this.anioAgo.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioAgo.Location = new System.Drawing.Point(158, 304);
            this.anioAgo.Name = "anioAgo";
            this.anioAgo.Size = new System.Drawing.Size(121, 29);
            this.anioAgo.TabIndex = 442;
            this.anioAgo.UseSelectable = true;
            // 
            // anioJul
            // 
            this.anioJul.FormattingEnabled = true;
            this.anioJul.ItemHeight = 23;
            this.anioJul.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioJul.Location = new System.Drawing.Point(158, 269);
            this.anioJul.Name = "anioJul";
            this.anioJul.Size = new System.Drawing.Size(121, 29);
            this.anioJul.TabIndex = 441;
            this.anioJul.UseSelectable = true;
            // 
            // anioJun
            // 
            this.anioJun.FormattingEnabled = true;
            this.anioJun.ItemHeight = 23;
            this.anioJun.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioJun.Location = new System.Drawing.Point(158, 234);
            this.anioJun.Name = "anioJun";
            this.anioJun.Size = new System.Drawing.Size(121, 29);
            this.anioJun.TabIndex = 440;
            this.anioJun.UseSelectable = true;
            // 
            // anioMay
            // 
            this.anioMay.FormattingEnabled = true;
            this.anioMay.ItemHeight = 23;
            this.anioMay.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioMay.Location = new System.Drawing.Point(158, 199);
            this.anioMay.Name = "anioMay";
            this.anioMay.Size = new System.Drawing.Size(121, 29);
            this.anioMay.TabIndex = 439;
            this.anioMay.UseSelectable = true;
            // 
            // anioAbr
            // 
            this.anioAbr.FormattingEnabled = true;
            this.anioAbr.ItemHeight = 23;
            this.anioAbr.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioAbr.Location = new System.Drawing.Point(158, 164);
            this.anioAbr.Name = "anioAbr";
            this.anioAbr.Size = new System.Drawing.Size(121, 29);
            this.anioAbr.TabIndex = 438;
            this.anioAbr.UseSelectable = true;
            // 
            // anioMar
            // 
            this.anioMar.FormattingEnabled = true;
            this.anioMar.ItemHeight = 23;
            this.anioMar.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioMar.Location = new System.Drawing.Point(158, 129);
            this.anioMar.Name = "anioMar";
            this.anioMar.Size = new System.Drawing.Size(121, 29);
            this.anioMar.TabIndex = 437;
            this.anioMar.UseSelectable = true;
            // 
            // anioFeb
            // 
            this.anioFeb.FormattingEnabled = true;
            this.anioFeb.ItemHeight = 23;
            this.anioFeb.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioFeb.Location = new System.Drawing.Point(158, 94);
            this.anioFeb.Name = "anioFeb";
            this.anioFeb.Size = new System.Drawing.Size(121, 29);
            this.anioFeb.TabIndex = 436;
            this.anioFeb.UseSelectable = true;
            // 
            // anioEne
            // 
            this.anioEne.FormattingEnabled = true;
            this.anioEne.ItemHeight = 23;
            this.anioEne.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            " "});
            this.anioEne.Location = new System.Drawing.Point(158, 59);
            this.anioEne.Name = "anioEne";
            this.anioEne.Size = new System.Drawing.Size(121, 29);
            this.anioEne.TabIndex = 435;
            this.anioEne.UseSelectable = true;
            // 
            // metroLabel42
            // 
            this.metroLabel42.AutoSize = true;
            this.metroLabel42.Location = new System.Drawing.Point(14, 36);
            this.metroLabel42.Name = "metroLabel42";
            this.metroLabel42.Size = new System.Drawing.Size(36, 19);
            this.metroLabel42.TabIndex = 434;
            this.metroLabel42.Text = "Mes:";
            // 
            // facturadoDic
            // 
            this.facturadoDic.FormattingEnabled = true;
            this.facturadoDic.ItemHeight = 23;
            this.facturadoDic.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoDic.Location = new System.Drawing.Point(14, 444);
            this.facturadoDic.Name = "facturadoDic";
            this.facturadoDic.Size = new System.Drawing.Size(121, 29);
            this.facturadoDic.TabIndex = 433;
            this.facturadoDic.UseSelectable = true;
            // 
            // facturadoNov
            // 
            this.facturadoNov.FormattingEnabled = true;
            this.facturadoNov.ItemHeight = 23;
            this.facturadoNov.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoNov.Location = new System.Drawing.Point(15, 409);
            this.facturadoNov.Name = "facturadoNov";
            this.facturadoNov.Size = new System.Drawing.Size(121, 29);
            this.facturadoNov.TabIndex = 431;
            this.facturadoNov.UseSelectable = true;
            // 
            // facturadoOct
            // 
            this.facturadoOct.FormattingEnabled = true;
            this.facturadoOct.ItemHeight = 23;
            this.facturadoOct.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoOct.Location = new System.Drawing.Point(14, 374);
            this.facturadoOct.Name = "facturadoOct";
            this.facturadoOct.Size = new System.Drawing.Size(121, 29);
            this.facturadoOct.TabIndex = 430;
            this.facturadoOct.UseSelectable = true;
            // 
            // facturadoSep
            // 
            this.facturadoSep.FormattingEnabled = true;
            this.facturadoSep.ItemHeight = 23;
            this.facturadoSep.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoSep.Location = new System.Drawing.Point(14, 339);
            this.facturadoSep.Name = "facturadoSep";
            this.facturadoSep.Size = new System.Drawing.Size(121, 29);
            this.facturadoSep.TabIndex = 429;
            this.facturadoSep.UseSelectable = true;
            // 
            // facturadoAgo
            // 
            this.facturadoAgo.FormattingEnabled = true;
            this.facturadoAgo.ItemHeight = 23;
            this.facturadoAgo.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoAgo.Location = new System.Drawing.Point(15, 304);
            this.facturadoAgo.Name = "facturadoAgo";
            this.facturadoAgo.Size = new System.Drawing.Size(121, 29);
            this.facturadoAgo.TabIndex = 428;
            this.facturadoAgo.UseSelectable = true;
            // 
            // facturadoJul
            // 
            this.facturadoJul.FormattingEnabled = true;
            this.facturadoJul.ItemHeight = 23;
            this.facturadoJul.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoJul.Location = new System.Drawing.Point(15, 269);
            this.facturadoJul.Name = "facturadoJul";
            this.facturadoJul.Size = new System.Drawing.Size(121, 29);
            this.facturadoJul.TabIndex = 427;
            this.facturadoJul.UseSelectable = true;
            // 
            // facturadoJun
            // 
            this.facturadoJun.FormattingEnabled = true;
            this.facturadoJun.ItemHeight = 23;
            this.facturadoJun.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoJun.Location = new System.Drawing.Point(15, 234);
            this.facturadoJun.Name = "facturadoJun";
            this.facturadoJun.Size = new System.Drawing.Size(121, 29);
            this.facturadoJun.TabIndex = 426;
            this.facturadoJun.UseSelectable = true;
            // 
            // facturadoMay
            // 
            this.facturadoMay.FormattingEnabled = true;
            this.facturadoMay.ItemHeight = 23;
            this.facturadoMay.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoMay.Location = new System.Drawing.Point(15, 199);
            this.facturadoMay.Name = "facturadoMay";
            this.facturadoMay.Size = new System.Drawing.Size(121, 29);
            this.facturadoMay.TabIndex = 425;
            this.facturadoMay.UseSelectable = true;
            // 
            // facturadoAbr
            // 
            this.facturadoAbr.FormattingEnabled = true;
            this.facturadoAbr.ItemHeight = 23;
            this.facturadoAbr.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoAbr.Location = new System.Drawing.Point(15, 164);
            this.facturadoAbr.Name = "facturadoAbr";
            this.facturadoAbr.Size = new System.Drawing.Size(121, 29);
            this.facturadoAbr.TabIndex = 424;
            this.facturadoAbr.UseSelectable = true;
            // 
            // facturadoMar
            // 
            this.facturadoMar.FormattingEnabled = true;
            this.facturadoMar.ItemHeight = 23;
            this.facturadoMar.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoMar.Location = new System.Drawing.Point(15, 129);
            this.facturadoMar.Name = "facturadoMar";
            this.facturadoMar.Size = new System.Drawing.Size(121, 29);
            this.facturadoMar.TabIndex = 423;
            this.facturadoMar.UseSelectable = true;
            // 
            // facturadoFeb
            // 
            this.facturadoFeb.FormattingEnabled = true;
            this.facturadoFeb.ItemHeight = 23;
            this.facturadoFeb.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoFeb.Location = new System.Drawing.Point(14, 94);
            this.facturadoFeb.Name = "facturadoFeb";
            this.facturadoFeb.Size = new System.Drawing.Size(121, 29);
            this.facturadoFeb.TabIndex = 422;
            this.facturadoFeb.UseSelectable = true;
            // 
            // facturadoEne
            // 
            this.facturadoEne.FormattingEnabled = true;
            this.facturadoEne.ItemHeight = 23;
            this.facturadoEne.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio ",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoEne.Location = new System.Drawing.Point(14, 59);
            this.facturadoEne.Name = "facturadoEne";
            this.facturadoEne.Size = new System.Drawing.Size(121, 29);
            this.facturadoEne.TabIndex = 421;
            this.facturadoEne.UseSelectable = true;
            // 
            // textDocDic
            // 
            this.textDocDic.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocDic.DoubleValue = 0D;
            this.textDocDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocDic.Location = new System.Drawing.Point(303, 451);
            this.textDocDic.Name = "textDocDic";
            this.textDocDic.Size = new System.Drawing.Size(140, 22);
            this.textDocDic.TabIndex = 419;
            this.textDocDic.Text = "0.00";
            // 
            // textDocNov
            // 
            this.textDocNov.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocNov.DoubleValue = 0D;
            this.textDocNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocNov.Location = new System.Drawing.Point(303, 416);
            this.textDocNov.Name = "textDocNov";
            this.textDocNov.Size = new System.Drawing.Size(140, 22);
            this.textDocNov.TabIndex = 418;
            this.textDocNov.Text = "0.00";
            // 
            // textDocOct
            // 
            this.textDocOct.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocOct.DoubleValue = 0D;
            this.textDocOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocOct.Location = new System.Drawing.Point(303, 381);
            this.textDocOct.Name = "textDocOct";
            this.textDocOct.Size = new System.Drawing.Size(140, 22);
            this.textDocOct.TabIndex = 417;
            this.textDocOct.Text = "0.00";
            // 
            // textDocSep
            // 
            this.textDocSep.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocSep.DoubleValue = 0D;
            this.textDocSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocSep.Location = new System.Drawing.Point(303, 346);
            this.textDocSep.Name = "textDocSep";
            this.textDocSep.Size = new System.Drawing.Size(140, 22);
            this.textDocSep.TabIndex = 416;
            this.textDocSep.Text = "0.00";
            // 
            // textDocAgo
            // 
            this.textDocAgo.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocAgo.DoubleValue = 0D;
            this.textDocAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocAgo.Location = new System.Drawing.Point(303, 311);
            this.textDocAgo.Name = "textDocAgo";
            this.textDocAgo.Size = new System.Drawing.Size(140, 22);
            this.textDocAgo.TabIndex = 415;
            this.textDocAgo.Text = "0.00";
            // 
            // textDocJul
            // 
            this.textDocJul.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocJul.DoubleValue = 0D;
            this.textDocJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocJul.Location = new System.Drawing.Point(303, 276);
            this.textDocJul.Name = "textDocJul";
            this.textDocJul.Size = new System.Drawing.Size(140, 22);
            this.textDocJul.TabIndex = 414;
            this.textDocJul.Text = "0.00";
            // 
            // textDocJun
            // 
            this.textDocJun.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocJun.DoubleValue = 0D;
            this.textDocJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocJun.Location = new System.Drawing.Point(303, 241);
            this.textDocJun.Name = "textDocJun";
            this.textDocJun.Size = new System.Drawing.Size(140, 22);
            this.textDocJun.TabIndex = 413;
            this.textDocJun.Text = "0.00";
            // 
            // textDocMay
            // 
            this.textDocMay.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocMay.DoubleValue = 0D;
            this.textDocMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocMay.Location = new System.Drawing.Point(303, 206);
            this.textDocMay.Name = "textDocMay";
            this.textDocMay.Size = new System.Drawing.Size(140, 22);
            this.textDocMay.TabIndex = 412;
            this.textDocMay.Text = "0.00";
            // 
            // textDocAbr
            // 
            this.textDocAbr.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocAbr.DoubleValue = 0D;
            this.textDocAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocAbr.Location = new System.Drawing.Point(303, 171);
            this.textDocAbr.Name = "textDocAbr";
            this.textDocAbr.Size = new System.Drawing.Size(140, 22);
            this.textDocAbr.TabIndex = 411;
            this.textDocAbr.Text = "0.00";
            // 
            // textDocMar
            // 
            this.textDocMar.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocMar.DoubleValue = 0D;
            this.textDocMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocMar.Location = new System.Drawing.Point(303, 136);
            this.textDocMar.Name = "textDocMar";
            this.textDocMar.Size = new System.Drawing.Size(140, 22);
            this.textDocMar.TabIndex = 410;
            this.textDocMar.Text = "0.00";
            // 
            // textDocFeb
            // 
            this.textDocFeb.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocFeb.DoubleValue = 0D;
            this.textDocFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocFeb.Location = new System.Drawing.Point(303, 101);
            this.textDocFeb.Name = "textDocFeb";
            this.textDocFeb.Size = new System.Drawing.Size(140, 22);
            this.textDocFeb.TabIndex = 409;
            this.textDocFeb.Text = "0.00";
            // 
            // textDocEne
            // 
            this.textDocEne.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textDocEne.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocEne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.textDocEne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDocEne.DoubleValue = 0D;
            this.textDocEne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocEne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textDocEne.Location = new System.Drawing.Point(303, 66);
            this.textDocEne.Name = "textDocEne";
            this.textDocEne.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textDocEne.Size = new System.Drawing.Size(140, 22);
            this.textDocEne.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.textDocEne.TabIndex = 408;
            this.textDocEne.Text = "0.00";
            this.textDocEne.ThemeName = "Office2016White";
            this.textDocEne.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.dateTimeMF_hasta);
            this.groupBox20.Controls.Add(this.metroLabel24);
            this.groupBox20.Controls.Add(this.dateTimeMF_desde);
            this.groupBox20.Controls.Add(this.metroLabel23);
            this.groupBox20.Controls.Add(this.checkFacturas);
            this.groupBox20.Controls.Add(this.checkPagos);
            this.groupBox20.Controls.Add(this.checkBancaria);
            this.groupBox20.Controls.Add(this.checkProduccion);
            this.groupBox20.Controls.Add(this.metroLabel38);
            this.groupBox20.Controls.Add(this.metroLabel25);
            this.groupBox20.Controls.Add(this.porcentajeMF_box);
            this.groupBox20.Controls.Add(this.checkBoxMF);
            this.groupBox20.Controls.Add(this.label37);
            this.groupBox20.Location = new System.Drawing.Point(10, 37);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1163, 105);
            this.groupBox20.TabIndex = 335;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Fondo de Publicidad";
            // 
            // dateTimeMF_hasta
            // 
            this.dateTimeMF_hasta.Location = new System.Drawing.Point(262, 68);
            this.dateTimeMF_hasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeMF_hasta.Name = "dateTimeMF_hasta";
            this.dateTimeMF_hasta.Size = new System.Drawing.Size(290, 29);
            this.dateTimeMF_hasta.TabIndex = 373;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(169, 72);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(82, 19);
            this.metroLabel24.TabIndex = 372;
            this.metroLabel24.Text = "Hasta Fecha:";
            // 
            // dateTimeMF_desde
            // 
            this.dateTimeMF_desde.Location = new System.Drawing.Point(262, 33);
            this.dateTimeMF_desde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeMF_desde.Name = "dateTimeMF_desde";
            this.dateTimeMF_desde.Size = new System.Drawing.Size(290, 29);
            this.dateTimeMF_desde.TabIndex = 371;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(169, 39);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(66, 19);
            this.metroLabel23.TabIndex = 370;
            this.metroLabel23.Text = "De Fecha:";
            // 
            // checkFacturas
            // 
            this.checkFacturas.AutoSize = true;
            this.checkFacturas.Location = new System.Drawing.Point(961, 75);
            this.checkFacturas.Name = "checkFacturas";
            this.checkFacturas.Size = new System.Drawing.Size(166, 15);
            this.checkFacturas.TabIndex = 369;
            this.checkFacturas.Text = "Compensación en Facturas";
            this.checkFacturas.UseSelectable = true;
            // 
            // checkPagos
            // 
            this.checkPagos.AutoSize = true;
            this.checkPagos.Location = new System.Drawing.Point(700, 75);
            this.checkPagos.Name = "checkPagos";
            this.checkPagos.Size = new System.Drawing.Size(104, 15);
            this.checkPagos.TabIndex = 366;
            this.checkPagos.Text = "Pagos Emitidos";
            this.checkPagos.UseSelectable = true;
            // 
            // checkBancaria
            // 
            this.checkBancaria.AutoSize = true;
            this.checkBancaria.Location = new System.Drawing.Point(961, 44);
            this.checkBancaria.Name = "checkBancaria";
            this.checkBancaria.Size = new System.Drawing.Size(140, 15);
            this.checkBancaria.TabIndex = 368;
            this.checkBancaria.Text = "Transferencia Bancaria";
            this.checkBancaria.UseSelectable = true;
            // 
            // checkProduccion
            // 
            this.checkProduccion.AutoSize = true;
            this.checkProduccion.Location = new System.Drawing.Point(700, 42);
            this.checkProduccion.Name = "checkProduccion";
            this.checkProduccion.Size = new System.Drawing.Size(84, 15);
            this.checkProduccion.TabIndex = 365;
            this.checkProduccion.Text = "Producción";
            this.checkProduccion.UseSelectable = true;
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Location = new System.Drawing.Point(843, 40);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(104, 19);
            this.metroLabel38.TabIndex = 367;
            this.metroLabel38.Text = "Forma de Pago:";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(582, 38);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(117, 19);
            this.metroLabel25.TabIndex = 364;
            this.metroLabel25.Text = "Forma de Cálculo:";
            // 
            // porcentajeMF_box
            // 
            this.porcentajeMF_box.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.porcentajeMF_box.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.porcentajeMF_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.porcentajeMF_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.porcentajeMF_box.DoubleValue = 0D;
            this.porcentajeMF_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentajeMF_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.porcentajeMF_box.Location = new System.Drawing.Point(42, 37);
            this.porcentajeMF_box.Name = "porcentajeMF_box";
            this.porcentajeMF_box.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.porcentajeMF_box.Size = new System.Drawing.Size(66, 22);
            this.porcentajeMF_box.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.porcentajeMF_box.TabIndex = 360;
            this.porcentajeMF_box.Text = "0.00";
            this.porcentajeMF_box.ThemeName = "Metro";
            this.porcentajeMF_box.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // checkBoxMF
            // 
            this.checkBoxMF.AutoSize = true;
            this.checkBoxMF.Location = new System.Drawing.Point(185, 2);
            this.checkBoxMF.Name = "checkBoxMF";
            this.checkBoxMF.Size = new System.Drawing.Size(26, 15);
            this.checkBoxMF.TabIndex = 359;
            this.checkBoxMF.Text = " ";
            this.checkBoxMF.UseSelectable = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label37.Location = new System.Drawing.Point(113, 39);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 20);
            this.label37.TabIndex = 44;
            this.label37.Text = "%";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(614, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 787);
            this.groupBox3.TabIndex = 280;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Best Travel Media";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboAccounts);
            this.groupBox5.Controls.Add(this.mediaPEmail);
            this.groupBox5.Controls.Add(this.metroLabel26);
            this.groupBox5.Controls.Add(this.mediaPTelefono);
            this.groupBox5.Controls.Add(this.metroLabel27);
            this.groupBox5.Controls.Add(this.metroLabel28);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 621);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(558, 145);
            this.groupBox5.TabIndex = 278;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contacto Pauta Medios";
            // 
            // comboAccounts
            // 
            this.comboAccounts.FormattingEnabled = true;
            this.comboAccounts.ItemHeight = 23;
            this.comboAccounts.Location = new System.Drawing.Point(83, 38);
            this.comboAccounts.Name = "comboAccounts";
            this.comboAccounts.Size = new System.Drawing.Size(466, 29);
            this.comboAccounts.TabIndex = 47;
            this.comboAccounts.UseSelectable = true;
            this.comboAccounts.SelectedIndexChanged += new System.EventHandler(this.comboAccounts_SelectedIndexChanged);
            // 
            // mediaPEmail
            // 
            // 
            // 
            // 
            this.mediaPEmail.CustomButton.Image = null;
            this.mediaPEmail.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaPEmail.CustomButton.Name = "";
            this.mediaPEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaPEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaPEmail.CustomButton.TabIndex = 1;
            this.mediaPEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaPEmail.CustomButton.UseSelectable = true;
            this.mediaPEmail.CustomButton.Visible = false;
            this.mediaPEmail.Lines = new string[] {
        " "};
            this.mediaPEmail.Location = new System.Drawing.Point(83, 106);
            this.mediaPEmail.MaxLength = 32767;
            this.mediaPEmail.Name = "mediaPEmail";
            this.mediaPEmail.PasswordChar = '\0';
            this.mediaPEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaPEmail.SelectedText = "";
            this.mediaPEmail.SelectionLength = 0;
            this.mediaPEmail.SelectionStart = 0;
            this.mediaPEmail.ShortcutsEnabled = true;
            this.mediaPEmail.Size = new System.Drawing.Size(466, 23);
            this.mediaPEmail.TabIndex = 51;
            this.mediaPEmail.Text = " ";
            this.mediaPEmail.UseSelectable = true;
            this.mediaPEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaPEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(15, 106);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(54, 19);
            this.metroLabel26.TabIndex = 50;
            this.metroLabel26.Text = "Correo:";
            // 
            // mediaPTelefono
            // 
            // 
            // 
            // 
            this.mediaPTelefono.CustomButton.Image = null;
            this.mediaPTelefono.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaPTelefono.CustomButton.Name = "";
            this.mediaPTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaPTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaPTelefono.CustomButton.TabIndex = 1;
            this.mediaPTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaPTelefono.CustomButton.UseSelectable = true;
            this.mediaPTelefono.CustomButton.Visible = false;
            this.mediaPTelefono.Lines = new string[] {
        "998 8811300"};
            this.mediaPTelefono.Location = new System.Drawing.Point(83, 73);
            this.mediaPTelefono.MaxLength = 32767;
            this.mediaPTelefono.Name = "mediaPTelefono";
            this.mediaPTelefono.PasswordChar = '\0';
            this.mediaPTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaPTelefono.SelectedText = "";
            this.mediaPTelefono.SelectionLength = 0;
            this.mediaPTelefono.SelectionStart = 0;
            this.mediaPTelefono.ShortcutsEnabled = true;
            this.mediaPTelefono.Size = new System.Drawing.Size(466, 23);
            this.mediaPTelefono.TabIndex = 49;
            this.mediaPTelefono.Text = "998 8811300";
            this.mediaPTelefono.UseSelectable = true;
            this.mediaPTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaPTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(15, 73);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(61, 19);
            this.metroLabel27.TabIndex = 48;
            this.metroLabel27.Text = "Teléfono:";
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(15, 39);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(62, 19);
            this.metroLabel28.TabIndex = 46;
            this.metroLabel28.Text = "Nombre:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboSupply);
            this.groupBox6.Controls.Add(this.mediaCCorreo);
            this.groupBox6.Controls.Add(this.metroLabel29);
            this.groupBox6.Controls.Add(this.mediaCTelefono);
            this.groupBox6.Controls.Add(this.metroLabel30);
            this.groupBox6.Controls.Add(this.metroLabel31);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 475);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(558, 140);
            this.groupBox6.TabIndex = 277;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Contacto Comercial";
            // 
            // comboSupply
            // 
            this.comboSupply.FormattingEnabled = true;
            this.comboSupply.ItemHeight = 23;
            this.comboSupply.Location = new System.Drawing.Point(83, 36);
            this.comboSupply.Name = "comboSupply";
            this.comboSupply.Size = new System.Drawing.Size(466, 29);
            this.comboSupply.TabIndex = 46;
            this.comboSupply.UseSelectable = true;
            this.comboSupply.SelectedIndexChanged += new System.EventHandler(this.comboSupply_SelectedIndexChanged);
            // 
            // mediaCCorreo
            // 
            // 
            // 
            // 
            this.mediaCCorreo.CustomButton.Image = null;
            this.mediaCCorreo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaCCorreo.CustomButton.Name = "";
            this.mediaCCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaCCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaCCorreo.CustomButton.TabIndex = 1;
            this.mediaCCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaCCorreo.CustomButton.UseSelectable = true;
            this.mediaCCorreo.CustomButton.Visible = false;
            this.mediaCCorreo.Lines = new string[] {
        " "};
            this.mediaCCorreo.Location = new System.Drawing.Point(83, 103);
            this.mediaCCorreo.MaxLength = 32767;
            this.mediaCCorreo.Name = "mediaCCorreo";
            this.mediaCCorreo.PasswordChar = '\0';
            this.mediaCCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaCCorreo.SelectedText = "";
            this.mediaCCorreo.SelectionLength = 0;
            this.mediaCCorreo.SelectionStart = 0;
            this.mediaCCorreo.ShortcutsEnabled = true;
            this.mediaCCorreo.Size = new System.Drawing.Size(466, 23);
            this.mediaCCorreo.TabIndex = 45;
            this.mediaCCorreo.Text = " ";
            this.mediaCCorreo.UseSelectable = true;
            this.mediaCCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaCCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(15, 103);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(54, 19);
            this.metroLabel29.TabIndex = 44;
            this.metroLabel29.Text = "Correo:";
            // 
            // mediaCTelefono
            // 
            // 
            // 
            // 
            this.mediaCTelefono.CustomButton.Image = null;
            this.mediaCTelefono.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaCTelefono.CustomButton.Name = "";
            this.mediaCTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaCTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaCTelefono.CustomButton.TabIndex = 1;
            this.mediaCTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaCTelefono.CustomButton.UseSelectable = true;
            this.mediaCTelefono.CustomButton.Visible = false;
            this.mediaCTelefono.Lines = new string[] {
        "998 8811300 Ext. "};
            this.mediaCTelefono.Location = new System.Drawing.Point(83, 70);
            this.mediaCTelefono.MaxLength = 32767;
            this.mediaCTelefono.Name = "mediaCTelefono";
            this.mediaCTelefono.PasswordChar = '\0';
            this.mediaCTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaCTelefono.SelectedText = "";
            this.mediaCTelefono.SelectionLength = 0;
            this.mediaCTelefono.SelectionStart = 0;
            this.mediaCTelefono.ShortcutsEnabled = true;
            this.mediaCTelefono.Size = new System.Drawing.Size(466, 23);
            this.mediaCTelefono.TabIndex = 43;
            this.mediaCTelefono.Text = "998 8811300 Ext. ";
            this.mediaCTelefono.UseSelectable = true;
            this.mediaCTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaCTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(15, 70);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(61, 19);
            this.metroLabel30.TabIndex = 42;
            this.metroLabel30.Text = "Teléfono:";
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Location = new System.Drawing.Point(15, 36);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(62, 19);
            this.metroLabel31.TabIndex = 40;
            this.metroLabel31.Text = "Nombre:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mediaPostal);
            this.groupBox7.Controls.Add(this.metroLabel32);
            this.groupBox7.Controls.Add(this.mediaPais);
            this.groupBox7.Controls.Add(this.mediaCalle);
            this.groupBox7.Controls.Add(this.metroLabel33);
            this.groupBox7.Controls.Add(this.metroLabel34);
            this.groupBox7.Controls.Add(this.metroLabel35);
            this.groupBox7.Controls.Add(this.mediaID);
            this.groupBox7.Controls.Add(this.metroLabel36);
            this.groupBox7.Controls.Add(this.mediaRazon);
            this.groupBox7.Controls.Add(this.metroLabel37);
            this.groupBox7.Location = new System.Drawing.Point(6, 35);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(558, 284);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Datos Generales";
            // 
            // mediaPostal
            // 
            // 
            // 
            // 
            this.mediaPostal.CustomButton.Image = null;
            this.mediaPostal.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.mediaPostal.CustomButton.Name = "";
            this.mediaPostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaPostal.CustomButton.TabIndex = 1;
            this.mediaPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaPostal.CustomButton.UseSelectable = true;
            this.mediaPostal.CustomButton.Visible = false;
            this.mediaPostal.Lines = new string[] {
        "77500"};
            this.mediaPostal.Location = new System.Drawing.Point(115, 206);
            this.mediaPostal.MaxLength = 32767;
            this.mediaPostal.Name = "mediaPostal";
            this.mediaPostal.PasswordChar = '\0';
            this.mediaPostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaPostal.SelectedText = "";
            this.mediaPostal.SelectionLength = 0;
            this.mediaPostal.SelectionStart = 0;
            this.mediaPostal.ShortcutsEnabled = true;
            this.mediaPostal.Size = new System.Drawing.Size(434, 23);
            this.mediaPostal.TabIndex = 38;
            this.mediaPostal.Text = "77500";
            this.mediaPostal.UseSelectable = true;
            this.mediaPostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaPostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Location = new System.Drawing.Point(15, 206);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(94, 19);
            this.metroLabel32.TabIndex = 37;
            this.metroLabel32.Text = "Código Postal:";
            // 
            // mediaPais
            // 
            // 
            // 
            // 
            this.mediaPais.CustomButton.Image = null;
            this.mediaPais.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.mediaPais.CustomButton.Name = "";
            this.mediaPais.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaPais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaPais.CustomButton.TabIndex = 1;
            this.mediaPais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaPais.CustomButton.UseSelectable = true;
            this.mediaPais.CustomButton.Visible = false;
            this.mediaPais.Lines = new string[] {
        "Cancún, Quintana Roo, México"};
            this.mediaPais.Location = new System.Drawing.Point(103, 170);
            this.mediaPais.MaxLength = 32767;
            this.mediaPais.Name = "mediaPais";
            this.mediaPais.PasswordChar = '\0';
            this.mediaPais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaPais.SelectedText = "";
            this.mediaPais.SelectionLength = 0;
            this.mediaPais.SelectionStart = 0;
            this.mediaPais.ShortcutsEnabled = true;
            this.mediaPais.Size = new System.Drawing.Size(446, 23);
            this.mediaPais.TabIndex = 36;
            this.mediaPais.Text = "Cancún, Quintana Roo, México";
            this.mediaPais.UseSelectable = true;
            this.mediaPais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaPais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mediaCalle
            // 
            // 
            // 
            // 
            this.mediaCalle.CustomButton.Image = null;
            this.mediaCalle.CustomButton.Location = new System.Drawing.Point(465, 1);
            this.mediaCalle.CustomButton.Name = "";
            this.mediaCalle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaCalle.CustomButton.TabIndex = 1;
            this.mediaCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaCalle.CustomButton.UseSelectable = true;
            this.mediaCalle.CustomButton.Visible = false;
            this.mediaCalle.Lines = new string[] {
        "Av. Bonampak, SM 10, Mz 2, Lote 7 Torre \"B\""};
            this.mediaCalle.Location = new System.Drawing.Point(62, 138);
            this.mediaCalle.MaxLength = 32767;
            this.mediaCalle.Name = "mediaCalle";
            this.mediaCalle.PasswordChar = '\0';
            this.mediaCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaCalle.SelectedText = "";
            this.mediaCalle.SelectionLength = 0;
            this.mediaCalle.SelectionStart = 0;
            this.mediaCalle.ShortcutsEnabled = true;
            this.mediaCalle.Size = new System.Drawing.Size(487, 23);
            this.mediaCalle.TabIndex = 35;
            this.mediaCalle.Text = "Av. Bonampak, SM 10, Mz 2, Lote 7 Torre \"B\"";
            this.mediaCalle.UseSelectable = true;
            this.mediaCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(15, 170);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(82, 19);
            this.metroLabel33.TabIndex = 34;
            this.metroLabel33.Text = "Ciudad/país:";
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(15, 138);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(41, 19);
            this.metroLabel34.TabIndex = 33;
            this.metroLabel34.Text = "Calle:";
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(15, 106);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(66, 19);
            this.metroLabel35.TabIndex = 32;
            this.metroLabel35.Text = "Dirección:";
            // 
            // mediaID
            // 
            // 
            // 
            // 
            this.mediaID.CustomButton.Image = null;
            this.mediaID.CustomButton.Location = new System.Drawing.Point(447, 1);
            this.mediaID.CustomButton.Name = "";
            this.mediaID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaID.CustomButton.TabIndex = 1;
            this.mediaID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaID.CustomButton.UseSelectable = true;
            this.mediaID.CustomButton.Visible = false;
            this.mediaID.Lines = new string[] {
        "VBE840427HI7"};
            this.mediaID.Location = new System.Drawing.Point(80, 69);
            this.mediaID.MaxLength = 32767;
            this.mediaID.Name = "mediaID";
            this.mediaID.PasswordChar = '\0';
            this.mediaID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaID.SelectedText = "";
            this.mediaID.SelectionLength = 0;
            this.mediaID.SelectionStart = 0;
            this.mediaID.ShortcutsEnabled = true;
            this.mediaID.Size = new System.Drawing.Size(469, 23);
            this.mediaID.TabIndex = 31;
            this.mediaID.Text = "VBE840427HI7";
            this.mediaID.UseSelectable = true;
            this.mediaID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Location = new System.Drawing.Point(15, 69);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(46, 19);
            this.metroLabel36.TabIndex = 30;
            this.metroLabel36.Text = "Tax ID:";
            // 
            // mediaRazon
            // 
            // 
            // 
            // 
            this.mediaRazon.CustomButton.Image = null;
            this.mediaRazon.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.mediaRazon.CustomButton.Name = "";
            this.mediaRazon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaRazon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaRazon.CustomButton.TabIndex = 1;
            this.mediaRazon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaRazon.CustomButton.UseSelectable = true;
            this.mediaRazon.CustomButton.Visible = false;
            this.mediaRazon.Lines = new string[] {
        " Viajes Beda, SA de CV"};
            this.mediaRazon.Location = new System.Drawing.Point(180, 38);
            this.mediaRazon.MaxLength = 32767;
            this.mediaRazon.Name = "mediaRazon";
            this.mediaRazon.PasswordChar = '\0';
            this.mediaRazon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaRazon.SelectedText = "";
            this.mediaRazon.SelectionLength = 0;
            this.mediaRazon.SelectionStart = 0;
            this.mediaRazon.ShortcutsEnabled = true;
            this.mediaRazon.Size = new System.Drawing.Size(369, 23);
            this.mediaRazon.TabIndex = 29;
            this.mediaRazon.Text = " Viajes Beda, SA de CV";
            this.mediaRazon.UseSelectable = true;
            this.mediaRazon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaRazon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Location = new System.Drawing.Point(15, 38);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(159, 19);
            this.metroLabel37.TabIndex = 28;
            this.metroLabel37.Text = "Razón Social Contratante:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cxcCorreo);
            this.groupBox8.Controls.Add(this.metroLabel39);
            this.groupBox8.Controls.Add(this.cxcTelefono);
            this.groupBox8.Controls.Add(this.metroLabel40);
            this.groupBox8.Controls.Add(this.cxcNombre);
            this.groupBox8.Controls.Add(this.metroLabel41);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(6, 325);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(558, 144);
            this.groupBox8.TabIndex = 276;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Contacto Cuentas por Cobrar";
            // 
            // cxcCorreo
            // 
            // 
            // 
            // 
            this.cxcCorreo.CustomButton.Image = null;
            this.cxcCorreo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.cxcCorreo.CustomButton.Name = "";
            this.cxcCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cxcCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cxcCorreo.CustomButton.TabIndex = 1;
            this.cxcCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cxcCorreo.CustomButton.UseSelectable = true;
            this.cxcCorreo.CustomButton.Visible = false;
            this.cxcCorreo.Lines = new string[] {
        "ladominguez@bestday.com"};
            this.cxcCorreo.Location = new System.Drawing.Point(83, 105);
            this.cxcCorreo.MaxLength = 32767;
            this.cxcCorreo.Name = "cxcCorreo";
            this.cxcCorreo.PasswordChar = '\0';
            this.cxcCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxcCorreo.SelectedText = "";
            this.cxcCorreo.SelectionLength = 0;
            this.cxcCorreo.SelectionStart = 0;
            this.cxcCorreo.ShortcutsEnabled = true;
            this.cxcCorreo.Size = new System.Drawing.Size(466, 23);
            this.cxcCorreo.TabIndex = 39;
            this.cxcCorreo.Text = "ladominguez@bestday.com";
            this.cxcCorreo.UseSelectable = true;
            this.cxcCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxcCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Location = new System.Drawing.Point(15, 105);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(54, 19);
            this.metroLabel39.TabIndex = 38;
            this.metroLabel39.Text = "Correo:";
            // 
            // cxcTelefono
            // 
            // 
            // 
            // 
            this.cxcTelefono.CustomButton.Image = null;
            this.cxcTelefono.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.cxcTelefono.CustomButton.Name = "";
            this.cxcTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cxcTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cxcTelefono.CustomButton.TabIndex = 1;
            this.cxcTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cxcTelefono.CustomButton.UseSelectable = true;
            this.cxcTelefono.CustomButton.Visible = false;
            this.cxcTelefono.Lines = new string[] {
        " 998 881 1300 Ext. 1255"};
            this.cxcTelefono.Location = new System.Drawing.Point(83, 72);
            this.cxcTelefono.MaxLength = 32767;
            this.cxcTelefono.Name = "cxcTelefono";
            this.cxcTelefono.PasswordChar = '\0';
            this.cxcTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxcTelefono.SelectedText = "";
            this.cxcTelefono.SelectionLength = 0;
            this.cxcTelefono.SelectionStart = 0;
            this.cxcTelefono.ShortcutsEnabled = true;
            this.cxcTelefono.Size = new System.Drawing.Size(466, 23);
            this.cxcTelefono.TabIndex = 37;
            this.cxcTelefono.Text = " 998 881 1300 Ext. 1255";
            this.cxcTelefono.UseSelectable = true;
            this.cxcTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxcTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.Location = new System.Drawing.Point(15, 72);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(61, 19);
            this.metroLabel40.TabIndex = 36;
            this.metroLabel40.Text = "Teléfono:";
            // 
            // cxcNombre
            // 
            // 
            // 
            // 
            this.cxcNombre.CustomButton.Image = null;
            this.cxcNombre.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.cxcNombre.CustomButton.Name = "";
            this.cxcNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cxcNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cxcNombre.CustomButton.TabIndex = 1;
            this.cxcNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cxcNombre.CustomButton.UseSelectable = true;
            this.cxcNombre.CustomButton.Visible = false;
            this.cxcNombre.Lines = new string[] {
        " Landy Dominguez"};
            this.cxcNombre.Location = new System.Drawing.Point(83, 38);
            this.cxcNombre.MaxLength = 32767;
            this.cxcNombre.Name = "cxcNombre";
            this.cxcNombre.PasswordChar = '\0';
            this.cxcNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxcNombre.SelectedText = "";
            this.cxcNombre.SelectionLength = 0;
            this.cxcNombre.SelectionStart = 0;
            this.cxcNombre.ShortcutsEnabled = true;
            this.cxcNombre.Size = new System.Drawing.Size(466, 23);
            this.cxcNombre.TabIndex = 35;
            this.cxcNombre.Text = " Landy Dominguez";
            this.cxcNombre.UseSelectable = true;
            this.cxcNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxcNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Location = new System.Drawing.Point(15, 38);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(62, 19);
            this.metroLabel41.TabIndex = 34;
            this.metroLabel41.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox15);
            this.groupBox2.Controls.Add(this.groupBox14);
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Controls.Add(this.groupBox12);
            this.groupBox2.Controls.Add(this.groupBox18);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(3, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 931);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.HCorreo);
            this.groupBox15.Controls.Add(this.metroLabel20);
            this.groupBox15.Controls.Add(this.HTelefono);
            this.groupBox15.Controls.Add(this.metroLabel21);
            this.groupBox15.Controls.Add(this.HNombre);
            this.groupBox15.Controls.Add(this.metroLabel22);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(6, 772);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(558, 143);
            this.groupBox15.TabIndex = 279;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Contacto Tour HotelDO";
            // 
            // HCorreo
            // 
            // 
            // 
            // 
            this.HCorreo.CustomButton.Image = null;
            this.HCorreo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.HCorreo.CustomButton.Name = "";
            this.HCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.HCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HCorreo.CustomButton.TabIndex = 1;
            this.HCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HCorreo.CustomButton.UseSelectable = true;
            this.HCorreo.CustomButton.Visible = false;
            this.HCorreo.Lines = new string[] {
        " "};
            this.HCorreo.Location = new System.Drawing.Point(83, 104);
            this.HCorreo.MaxLength = 32767;
            this.HCorreo.Name = "HCorreo";
            this.HCorreo.PasswordChar = '\0';
            this.HCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HCorreo.SelectedText = "";
            this.HCorreo.SelectionLength = 0;
            this.HCorreo.SelectionStart = 0;
            this.HCorreo.ShortcutsEnabled = true;
            this.HCorreo.Size = new System.Drawing.Size(466, 23);
            this.HCorreo.TabIndex = 51;
            this.HCorreo.Text = " ";
            this.HCorreo.UseSelectable = true;
            this.HCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(15, 104);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(54, 19);
            this.metroLabel20.TabIndex = 50;
            this.metroLabel20.Text = "Correo:";
            // 
            // HTelefono
            // 
            // 
            // 
            // 
            this.HTelefono.CustomButton.Image = null;
            this.HTelefono.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.HTelefono.CustomButton.Name = "";
            this.HTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.HTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HTelefono.CustomButton.TabIndex = 1;
            this.HTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HTelefono.CustomButton.UseSelectable = true;
            this.HTelefono.CustomButton.Visible = false;
            this.HTelefono.Lines = new string[] {
        " "};
            this.HTelefono.Location = new System.Drawing.Point(83, 71);
            this.HTelefono.MaxLength = 32767;
            this.HTelefono.Name = "HTelefono";
            this.HTelefono.PasswordChar = '\0';
            this.HTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HTelefono.SelectedText = "";
            this.HTelefono.SelectionLength = 0;
            this.HTelefono.SelectionStart = 0;
            this.HTelefono.ShortcutsEnabled = true;
            this.HTelefono.Size = new System.Drawing.Size(466, 23);
            this.HTelefono.TabIndex = 49;
            this.HTelefono.Text = " ";
            this.HTelefono.UseSelectable = true;
            this.HTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(15, 71);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(61, 19);
            this.metroLabel21.TabIndex = 48;
            this.metroLabel21.Text = "Teléfono:";
            // 
            // HNombre
            // 
            // 
            // 
            // 
            this.HNombre.CustomButton.Image = null;
            this.HNombre.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.HNombre.CustomButton.Name = "";
            this.HNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.HNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HNombre.CustomButton.TabIndex = 1;
            this.HNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HNombre.CustomButton.UseSelectable = true;
            this.HNombre.CustomButton.Visible = false;
            this.HNombre.Lines = new string[] {
        " "};
            this.HNombre.Location = new System.Drawing.Point(83, 37);
            this.HNombre.MaxLength = 32767;
            this.HNombre.Name = "HNombre";
            this.HNombre.PasswordChar = '\0';
            this.HNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HNombre.SelectedText = "";
            this.HNombre.SelectionLength = 0;
            this.HNombre.SelectionStart = 0;
            this.HNombre.ShortcutsEnabled = true;
            this.HNombre.Size = new System.Drawing.Size(466, 23);
            this.HNombre.TabIndex = 47;
            this.HNombre.Text = " ";
            this.HNombre.UseSelectable = true;
            this.HNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(15, 37);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(62, 19);
            this.metroLabel22.TabIndex = 46;
            this.metroLabel22.Text = "Nombre:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.PCorreo);
            this.groupBox14.Controls.Add(this.metroLabel17);
            this.groupBox14.Controls.Add(this.PTelefono);
            this.groupBox14.Controls.Add(this.metroLabel18);
            this.groupBox14.Controls.Add(this.PNombre);
            this.groupBox14.Controls.Add(this.metroLabel19);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(6, 621);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(558, 145);
            this.groupBox14.TabIndex = 278;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Contacto Pauta Medios";
            // 
            // PCorreo
            // 
            // 
            // 
            // 
            this.PCorreo.CustomButton.Image = null;
            this.PCorreo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.PCorreo.CustomButton.Name = "";
            this.PCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PCorreo.CustomButton.TabIndex = 1;
            this.PCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PCorreo.CustomButton.UseSelectable = true;
            this.PCorreo.CustomButton.Visible = false;
            this.PCorreo.Lines = new string[] {
        " "};
            this.PCorreo.Location = new System.Drawing.Point(83, 106);
            this.PCorreo.MaxLength = 32767;
            this.PCorreo.Name = "PCorreo";
            this.PCorreo.PasswordChar = '\0';
            this.PCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PCorreo.SelectedText = "";
            this.PCorreo.SelectionLength = 0;
            this.PCorreo.SelectionStart = 0;
            this.PCorreo.ShortcutsEnabled = true;
            this.PCorreo.Size = new System.Drawing.Size(466, 23);
            this.PCorreo.TabIndex = 51;
            this.PCorreo.Text = " ";
            this.PCorreo.UseSelectable = true;
            this.PCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(15, 106);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(54, 19);
            this.metroLabel17.TabIndex = 50;
            this.metroLabel17.Text = "Correo:";
            // 
            // PTelefono
            // 
            // 
            // 
            // 
            this.PTelefono.CustomButton.Image = null;
            this.PTelefono.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.PTelefono.CustomButton.Name = "";
            this.PTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PTelefono.CustomButton.TabIndex = 1;
            this.PTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PTelefono.CustomButton.UseSelectable = true;
            this.PTelefono.CustomButton.Visible = false;
            this.PTelefono.Lines = new string[] {
        " "};
            this.PTelefono.Location = new System.Drawing.Point(83, 73);
            this.PTelefono.MaxLength = 32767;
            this.PTelefono.Name = "PTelefono";
            this.PTelefono.PasswordChar = '\0';
            this.PTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PTelefono.SelectedText = "";
            this.PTelefono.SelectionLength = 0;
            this.PTelefono.SelectionStart = 0;
            this.PTelefono.ShortcutsEnabled = true;
            this.PTelefono.Size = new System.Drawing.Size(466, 23);
            this.PTelefono.TabIndex = 49;
            this.PTelefono.Text = " ";
            this.PTelefono.UseSelectable = true;
            this.PTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(15, 73);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(61, 19);
            this.metroLabel18.TabIndex = 48;
            this.metroLabel18.Text = "Teléfono:";
            // 
            // PNombre
            // 
            // 
            // 
            // 
            this.PNombre.CustomButton.Image = null;
            this.PNombre.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.PNombre.CustomButton.Name = "";
            this.PNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PNombre.CustomButton.TabIndex = 1;
            this.PNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PNombre.CustomButton.UseSelectable = true;
            this.PNombre.CustomButton.Visible = false;
            this.PNombre.Lines = new string[] {
        " "};
            this.PNombre.Location = new System.Drawing.Point(83, 39);
            this.PNombre.MaxLength = 32767;
            this.PNombre.Name = "PNombre";
            this.PNombre.PasswordChar = '\0';
            this.PNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PNombre.SelectedText = "";
            this.PNombre.SelectionLength = 0;
            this.PNombre.SelectionStart = 0;
            this.PNombre.ShortcutsEnabled = true;
            this.PNombre.Size = new System.Drawing.Size(466, 23);
            this.PNombre.TabIndex = 47;
            this.PNombre.Text = " ";
            this.PNombre.UseSelectable = true;
            this.PNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(15, 39);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(62, 19);
            this.metroLabel19.TabIndex = 46;
            this.metroLabel19.Text = "Nombre:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.NComercial);
            this.groupBox13.Controls.Add(this.CComercial);
            this.groupBox13.Controls.Add(this.metroLabel14);
            this.groupBox13.Controls.Add(this.TComercial);
            this.groupBox13.Controls.Add(this.metroLabel15);
            this.groupBox13.Controls.Add(this.metroLabel16);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(6, 475);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(558, 140);
            this.groupBox13.TabIndex = 277;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Contacto Comercial";
            // 
            // NComercial
            // 
            // 
            // 
            // 
            this.NComercial.CustomButton.Image = null;
            this.NComercial.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.NComercial.CustomButton.Name = "";
            this.NComercial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NComercial.CustomButton.TabIndex = 1;
            this.NComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NComercial.CustomButton.UseSelectable = true;
            this.NComercial.CustomButton.Visible = false;
            this.NComercial.Lines = new string[] {
        " "};
            this.NComercial.Location = new System.Drawing.Point(83, 36);
            this.NComercial.MaxLength = 32767;
            this.NComercial.Name = "NComercial";
            this.NComercial.PasswordChar = '\0';
            this.NComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NComercial.SelectedText = "";
            this.NComercial.SelectionLength = 0;
            this.NComercial.SelectionStart = 0;
            this.NComercial.ShortcutsEnabled = true;
            this.NComercial.Size = new System.Drawing.Size(466, 23);
            this.NComercial.TabIndex = 46;
            this.NComercial.Text = " ";
            this.NComercial.UseSelectable = true;
            this.NComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CComercial
            // 
            // 
            // 
            // 
            this.CComercial.CustomButton.Image = null;
            this.CComercial.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.CComercial.CustomButton.Name = "";
            this.CComercial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CComercial.CustomButton.TabIndex = 1;
            this.CComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CComercial.CustomButton.UseSelectable = true;
            this.CComercial.CustomButton.Visible = false;
            this.CComercial.Lines = new string[] {
        " "};
            this.CComercial.Location = new System.Drawing.Point(83, 103);
            this.CComercial.MaxLength = 32767;
            this.CComercial.Name = "CComercial";
            this.CComercial.PasswordChar = '\0';
            this.CComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CComercial.SelectedText = "";
            this.CComercial.SelectionLength = 0;
            this.CComercial.SelectionStart = 0;
            this.CComercial.ShortcutsEnabled = true;
            this.CComercial.Size = new System.Drawing.Size(466, 23);
            this.CComercial.TabIndex = 45;
            this.CComercial.Text = " ";
            this.CComercial.UseSelectable = true;
            this.CComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(15, 103);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(54, 19);
            this.metroLabel14.TabIndex = 44;
            this.metroLabel14.Text = "Correo:";
            // 
            // TComercial
            // 
            // 
            // 
            // 
            this.TComercial.CustomButton.Image = null;
            this.TComercial.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.TComercial.CustomButton.Name = "";
            this.TComercial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TComercial.CustomButton.TabIndex = 1;
            this.TComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TComercial.CustomButton.UseSelectable = true;
            this.TComercial.CustomButton.Visible = false;
            this.TComercial.Lines = new string[] {
        " "};
            this.TComercial.Location = new System.Drawing.Point(83, 70);
            this.TComercial.MaxLength = 32767;
            this.TComercial.Name = "TComercial";
            this.TComercial.PasswordChar = '\0';
            this.TComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TComercial.SelectedText = "";
            this.TComercial.SelectionLength = 0;
            this.TComercial.SelectionStart = 0;
            this.TComercial.ShortcutsEnabled = true;
            this.TComercial.Size = new System.Drawing.Size(466, 23);
            this.TComercial.TabIndex = 43;
            this.TComercial.Text = " ";
            this.TComercial.UseSelectable = true;
            this.TComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(15, 70);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(61, 19);
            this.metroLabel15.TabIndex = 42;
            this.metroLabel15.Text = "Teléfono:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(15, 36);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 40;
            this.metroLabel16.Text = "Nombre:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.clientePostal);
            this.groupBox12.Controls.Add(this.metroLabel10);
            this.groupBox12.Controls.Add(this.clientePais);
            this.groupBox12.Controls.Add(this.clienteCalle);
            this.groupBox12.Controls.Add(this.metroLabel9);
            this.groupBox12.Controls.Add(this.metroLabel8);
            this.groupBox12.Controls.Add(this.metroLabel7);
            this.groupBox12.Controls.Add(this.clienteID);
            this.groupBox12.Controls.Add(this.metroLabel6);
            this.groupBox12.Controls.Add(this.clienteRazon);
            this.groupBox12.Controls.Add(this.lanbel9999);
            this.groupBox12.Controls.Add(this.clienteComercial);
            this.groupBox12.Controls.Add(this.metroLabel5);
            this.groupBox12.Location = new System.Drawing.Point(6, 35);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(558, 284);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Datos Generales";
            // 
            // clientePostal
            // 
            // 
            // 
            // 
            this.clientePostal.CustomButton.Image = null;
            this.clientePostal.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.clientePostal.CustomButton.Name = "";
            this.clientePostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientePostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientePostal.CustomButton.TabIndex = 1;
            this.clientePostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientePostal.CustomButton.UseSelectable = true;
            this.clientePostal.CustomButton.Visible = false;
            this.clientePostal.Lines = new string[] {
        " "};
            this.clientePostal.Location = new System.Drawing.Point(115, 237);
            this.clientePostal.MaxLength = 32767;
            this.clientePostal.Name = "clientePostal";
            this.clientePostal.PasswordChar = '\0';
            this.clientePostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientePostal.SelectedText = "";
            this.clientePostal.SelectionLength = 0;
            this.clientePostal.SelectionStart = 0;
            this.clientePostal.ShortcutsEnabled = true;
            this.clientePostal.Size = new System.Drawing.Size(434, 23);
            this.clientePostal.TabIndex = 38;
            this.clientePostal.Text = " ";
            this.clientePostal.UseSelectable = true;
            this.clientePostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientePostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(15, 237);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(94, 19);
            this.metroLabel10.TabIndex = 37;
            this.metroLabel10.Text = "Código Postal:";
            // 
            // clientePais
            // 
            // 
            // 
            // 
            this.clientePais.CustomButton.Image = null;
            this.clientePais.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.clientePais.CustomButton.Name = "";
            this.clientePais.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientePais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientePais.CustomButton.TabIndex = 1;
            this.clientePais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientePais.CustomButton.UseSelectable = true;
            this.clientePais.CustomButton.Visible = false;
            this.clientePais.Lines = new string[] {
        " "};
            this.clientePais.Location = new System.Drawing.Point(103, 201);
            this.clientePais.MaxLength = 32767;
            this.clientePais.Name = "clientePais";
            this.clientePais.PasswordChar = '\0';
            this.clientePais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientePais.SelectedText = "";
            this.clientePais.SelectionLength = 0;
            this.clientePais.SelectionStart = 0;
            this.clientePais.ShortcutsEnabled = true;
            this.clientePais.Size = new System.Drawing.Size(446, 23);
            this.clientePais.TabIndex = 36;
            this.clientePais.Text = " ";
            this.clientePais.UseSelectable = true;
            this.clientePais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientePais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clienteCalle
            // 
            // 
            // 
            // 
            this.clienteCalle.CustomButton.Image = null;
            this.clienteCalle.CustomButton.Location = new System.Drawing.Point(465, 1);
            this.clienteCalle.CustomButton.Name = "";
            this.clienteCalle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clienteCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clienteCalle.CustomButton.TabIndex = 1;
            this.clienteCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clienteCalle.CustomButton.UseSelectable = true;
            this.clienteCalle.CustomButton.Visible = false;
            this.clienteCalle.Lines = new string[] {
        " "};
            this.clienteCalle.Location = new System.Drawing.Point(62, 169);
            this.clienteCalle.MaxLength = 32767;
            this.clienteCalle.Name = "clienteCalle";
            this.clienteCalle.PasswordChar = '\0';
            this.clienteCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clienteCalle.SelectedText = "";
            this.clienteCalle.SelectionLength = 0;
            this.clienteCalle.SelectionStart = 0;
            this.clienteCalle.ShortcutsEnabled = true;
            this.clienteCalle.Size = new System.Drawing.Size(487, 23);
            this.clienteCalle.TabIndex = 35;
            this.clienteCalle.Text = " ";
            this.clienteCalle.UseSelectable = true;
            this.clienteCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(15, 201);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Ciudad/país:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 169);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 33;
            this.metroLabel8.Text = "Calle:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 137);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Dirección:";
            // 
            // clienteID
            // 
            // 
            // 
            // 
            this.clienteID.CustomButton.Image = null;
            this.clienteID.CustomButton.Location = new System.Drawing.Point(447, 1);
            this.clienteID.CustomButton.Name = "";
            this.clienteID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clienteID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clienteID.CustomButton.TabIndex = 1;
            this.clienteID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clienteID.CustomButton.UseSelectable = true;
            this.clienteID.CustomButton.Visible = false;
            this.clienteID.Lines = new string[] {
        " "};
            this.clienteID.Location = new System.Drawing.Point(80, 100);
            this.clienteID.MaxLength = 32767;
            this.clienteID.Name = "clienteID";
            this.clienteID.PasswordChar = '\0';
            this.clienteID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clienteID.SelectedText = "";
            this.clienteID.SelectionLength = 0;
            this.clienteID.SelectionStart = 0;
            this.clienteID.ShortcutsEnabled = true;
            this.clienteID.Size = new System.Drawing.Size(469, 23);
            this.clienteID.TabIndex = 31;
            this.clienteID.Text = " ";
            this.clienteID.UseSelectable = true;
            this.clienteID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 100);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Tax ID:";
            // 
            // clienteRazon
            // 
            // 
            // 
            // 
            this.clienteRazon.CustomButton.Image = null;
            this.clienteRazon.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.clienteRazon.CustomButton.Name = "";
            this.clienteRazon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clienteRazon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clienteRazon.CustomButton.TabIndex = 1;
            this.clienteRazon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clienteRazon.CustomButton.UseSelectable = true;
            this.clienteRazon.CustomButton.Visible = false;
            this.clienteRazon.Lines = new string[] {
        " "};
            this.clienteRazon.Location = new System.Drawing.Point(180, 69);
            this.clienteRazon.MaxLength = 32767;
            this.clienteRazon.Name = "clienteRazon";
            this.clienteRazon.PasswordChar = '\0';
            this.clienteRazon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clienteRazon.SelectedText = "";
            this.clienteRazon.SelectionLength = 0;
            this.clienteRazon.SelectionStart = 0;
            this.clienteRazon.ShortcutsEnabled = true;
            this.clienteRazon.Size = new System.Drawing.Size(369, 23);
            this.clienteRazon.TabIndex = 29;
            this.clienteRazon.Text = " ";
            this.clienteRazon.UseSelectable = true;
            this.clienteRazon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteRazon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lanbel9999
            // 
            this.lanbel9999.AutoSize = true;
            this.lanbel9999.Location = new System.Drawing.Point(15, 69);
            this.lanbel9999.Name = "lanbel9999";
            this.lanbel9999.Size = new System.Drawing.Size(159, 19);
            this.lanbel9999.TabIndex = 28;
            this.lanbel9999.Text = "Razón Social Contratante:";
            // 
            // clienteComercial
            // 
            // 
            // 
            // 
            this.clienteComercial.CustomButton.Image = null;
            this.clienteComercial.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.clienteComercial.CustomButton.Name = "";
            this.clienteComercial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clienteComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clienteComercial.CustomButton.TabIndex = 1;
            this.clienteComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clienteComercial.CustomButton.UseSelectable = true;
            this.clienteComercial.CustomButton.Visible = false;
            this.clienteComercial.Lines = new string[] {
        " "};
            this.clienteComercial.Location = new System.Drawing.Point(147, 38);
            this.clienteComercial.MaxLength = 32767;
            this.clienteComercial.Name = "clienteComercial";
            this.clienteComercial.PasswordChar = '\0';
            this.clienteComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clienteComercial.SelectedText = "";
            this.clienteComercial.SelectionLength = 0;
            this.clienteComercial.SelectionStart = 0;
            this.clienteComercial.ShortcutsEnabled = true;
            this.clienteComercial.Size = new System.Drawing.Size(402, 23);
            this.clienteComercial.TabIndex = 27;
            this.clienteComercial.Text = " ";
            this.clienteComercial.UseSelectable = true;
            this.clienteComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 38);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(126, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Nombre Comercial:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.cxpCorreo);
            this.groupBox18.Controls.Add(this.metroLabel13);
            this.groupBox18.Controls.Add(this.cxpTelefono);
            this.groupBox18.Controls.Add(this.metroLabel12);
            this.groupBox18.Controls.Add(this.cxpNombre);
            this.groupBox18.Controls.Add(this.metroLabel11);
            this.groupBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox18.Location = new System.Drawing.Point(6, 325);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(558, 144);
            this.groupBox18.TabIndex = 276;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Contacto Cuentas por Pagar";
            // 
            // cxpCorreo
            // 
            // 
            // 
            // 
            this.cxpCorreo.CustomButton.Image = null;
            this.cxpCorreo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.cxpCorreo.CustomButton.Name = "";
            this.cxpCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cxpCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cxpCorreo.CustomButton.TabIndex = 1;
            this.cxpCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cxpCorreo.CustomButton.UseSelectable = true;
            this.cxpCorreo.CustomButton.Visible = false;
            this.cxpCorreo.Lines = new string[] {
        " "};
            this.cxpCorreo.Location = new System.Drawing.Point(83, 105);
            this.cxpCorreo.MaxLength = 32767;
            this.cxpCorreo.Name = "cxpCorreo";
            this.cxpCorreo.PasswordChar = '\0';
            this.cxpCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxpCorreo.SelectedText = "";
            this.cxpCorreo.SelectionLength = 0;
            this.cxpCorreo.SelectionStart = 0;
            this.cxpCorreo.ShortcutsEnabled = true;
            this.cxpCorreo.Size = new System.Drawing.Size(466, 23);
            this.cxpCorreo.TabIndex = 39;
            this.cxpCorreo.Text = " ";
            this.cxpCorreo.UseSelectable = true;
            this.cxpCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxpCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(15, 105);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(54, 19);
            this.metroLabel13.TabIndex = 38;
            this.metroLabel13.Text = "Correo:";
            // 
            // cxpTelefono
            // 
            // 
            // 
            // 
            this.cxpTelefono.CustomButton.Image = null;
            this.cxpTelefono.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.cxpTelefono.CustomButton.Name = "";
            this.cxpTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cxpTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cxpTelefono.CustomButton.TabIndex = 1;
            this.cxpTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cxpTelefono.CustomButton.UseSelectable = true;
            this.cxpTelefono.CustomButton.Visible = false;
            this.cxpTelefono.Lines = new string[] {
        " "};
            this.cxpTelefono.Location = new System.Drawing.Point(83, 72);
            this.cxpTelefono.MaxLength = 32767;
            this.cxpTelefono.Name = "cxpTelefono";
            this.cxpTelefono.PasswordChar = '\0';
            this.cxpTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxpTelefono.SelectedText = "";
            this.cxpTelefono.SelectionLength = 0;
            this.cxpTelefono.SelectionStart = 0;
            this.cxpTelefono.ShortcutsEnabled = true;
            this.cxpTelefono.Size = new System.Drawing.Size(466, 23);
            this.cxpTelefono.TabIndex = 37;
            this.cxpTelefono.Text = " ";
            this.cxpTelefono.UseSelectable = true;
            this.cxpTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxpTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(15, 72);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 19);
            this.metroLabel12.TabIndex = 36;
            this.metroLabel12.Text = "Teléfono:";
            // 
            // cxpNombre
            // 
            // 
            // 
            // 
            this.cxpNombre.CustomButton.Image = null;
            this.cxpNombre.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.cxpNombre.CustomButton.Name = "";
            this.cxpNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cxpNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cxpNombre.CustomButton.TabIndex = 1;
            this.cxpNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cxpNombre.CustomButton.UseSelectable = true;
            this.cxpNombre.CustomButton.Visible = false;
            this.cxpNombre.Lines = new string[] {
        " "};
            this.cxpNombre.Location = new System.Drawing.Point(83, 38);
            this.cxpNombre.MaxLength = 32767;
            this.cxpNombre.Name = "cxpNombre";
            this.cxpNombre.PasswordChar = '\0';
            this.cxpNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxpNombre.SelectedText = "";
            this.cxpNombre.SelectionLength = 0;
            this.cxpNombre.SelectionStart = 0;
            this.cxpNombre.ShortcutsEnabled = true;
            this.cxpNombre.Size = new System.Drawing.Size(466, 23);
            this.cxpNombre.TabIndex = 35;
            this.cxpNombre.Text = " ";
            this.cxpNombre.UseSelectable = true;
            this.cxpNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxpNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(15, 38);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(62, 19);
            this.metroLabel11.TabIndex = 34;
            this.metroLabel11.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.vigenciaHasta_text);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.vigenciaDesde_text);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.fechaFirma_text);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.OI_text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1187, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caratula";
            // 
            // vigenciaHasta_text
            // 
            this.vigenciaHasta_text.CalendarForeColor = System.Drawing.Color.Black;
            this.vigenciaHasta_text.CalendarMonthBackground = System.Drawing.Color.White;
            this.vigenciaHasta_text.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.vigenciaHasta_text.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.vigenciaHasta_text.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.vigenciaHasta_text.Location = new System.Drawing.Point(965, 38);
            this.vigenciaHasta_text.MinimumSize = new System.Drawing.Size(0, 29);
            this.vigenciaHasta_text.Name = "vigenciaHasta_text";
            this.vigenciaHasta_text.Size = new System.Drawing.Size(216, 29);
            this.vigenciaHasta_text.TabIndex = 23;
            this.vigenciaHasta_text.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vigenciaHasta_text.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(940, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(19, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "al";
            // 
            // vigenciaDesde_text
            // 
            this.vigenciaDesde_text.CalendarForeColor = System.Drawing.Color.Black;
            this.vigenciaDesde_text.CalendarMonthBackground = System.Drawing.Color.White;
            this.vigenciaDesde_text.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.vigenciaDesde_text.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.vigenciaDesde_text.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.vigenciaDesde_text.Location = new System.Drawing.Point(716, 38);
            this.vigenciaDesde_text.MinimumSize = new System.Drawing.Size(0, 29);
            this.vigenciaDesde_text.Name = "vigenciaDesde_text";
            this.vigenciaDesde_text.Size = new System.Drawing.Size(218, 29);
            this.vigenciaDesde_text.TabIndex = 21;
            this.vigenciaDesde_text.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vigenciaDesde_text.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(575, 42);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(135, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Periodo de campaña:";
            // 
            // fechaFirma_text
            // 
            this.fechaFirma_text.CalendarForeColor = System.Drawing.Color.Black;
            this.fechaFirma_text.CalendarMonthBackground = System.Drawing.Color.White;
            this.fechaFirma_text.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.fechaFirma_text.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.fechaFirma_text.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.fechaFirma_text.Location = new System.Drawing.Point(338, 38);
            this.fechaFirma_text.MinimumSize = new System.Drawing.Size(0, 29);
            this.fechaFirma_text.Name = "fechaFirma_text";
            this.fechaFirma_text.Size = new System.Drawing.Size(217, 29);
            this.fechaFirma_text.TabIndex = 19;
            this.fechaFirma_text.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fechaFirma_text.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(286, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Fecha:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(174, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Orden de inserción número:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // OI_text
            // 
            // 
            // 
            // 
            this.OI_text.CustomButton.Image = null;
            this.OI_text.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.OI_text.CustomButton.Name = "";
            this.OI_text.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.OI_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OI_text.CustomButton.TabIndex = 1;
            this.OI_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OI_text.CustomButton.UseSelectable = true;
            this.OI_text.CustomButton.Visible = false;
            this.OI_text.Lines = new string[] {
        " "};
            this.OI_text.Location = new System.Drawing.Point(186, 42);
            this.OI_text.MaxLength = 32767;
            this.OI_text.Name = "OI_text";
            this.OI_text.PasswordChar = '\0';
            this.OI_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OI_text.SelectedText = "";
            this.OI_text.SelectionLength = 0;
            this.OI_text.SelectionStart = 0;
            this.OI_text.ShortcutsEnabled = true;
            this.OI_text.Size = new System.Drawing.Size(88, 23);
            this.OI_text.TabIndex = 16;
            this.OI_text.Text = " ";
            this.OI_text.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OI_text.UseSelectable = true;
            this.OI_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OI_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.OI_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OI_text_KeyPress);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.Controls.Add(this.groupBox24);
            this.metroTabPage2.Controls.Add(this.groupBox23);
            this.metroTabPage2.Controls.Add(this.groupBox22);
            this.metroTabPage2.Controls.Add(this.groupBox19);
            this.metroTabPage2.Controls.Add(this.groupBox17);
            this.metroTabPage2.Controls.Add(this.groupBox16);
            this.metroTabPage2.Controls.Add(this.groupBox11);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1212, 517);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Anexo A";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // groupBox24
            // 
            this.groupBox24.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox24.Controls.Add(this.Additional_6);
            this.groupBox24.Controls.Add(this.seis_telefono);
            this.groupBox24.Controls.Add(this.seis_email);
            this.groupBox24.Controls.Add(this.seis_contacto);
            this.groupBox24.Controls.Add(this.metroLabel110);
            this.groupBox24.Controls.Add(this.metroLabel111);
            this.groupBox24.Controls.Add(this.metroLabel112);
            this.groupBox24.Controls.Add(this.metroLabel113);
            this.groupBox24.Controls.Add(this.seis_codigo);
            this.groupBox24.Controls.Add(this.seis_direccion);
            this.groupBox24.Controls.Add(this.seis_rfc);
            this.groupBox24.Controls.Add(this.seis_razon);
            this.groupBox24.Controls.Add(this.seis_hotel);
            this.groupBox24.Controls.Add(this.metroLabel114);
            this.groupBox24.Controls.Add(this.metroLabel115);
            this.groupBox24.Controls.Add(this.metroLabel116);
            this.groupBox24.Controls.Add(this.metroLabel117);
            this.groupBox24.Controls.Add(this.metroLabel118);
            this.groupBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox24.Location = new System.Drawing.Point(6, 1137);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(1175, 218);
            this.groupBox24.TabIndex = 307;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Sexto";
            // 
            // Additional_6
            // 
            // 
            // 
            // 
            this.Additional_6.CustomButton.Image = null;
            this.Additional_6.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_6.CustomButton.Name = "";
            this.Additional_6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_6.CustomButton.TabIndex = 1;
            this.Additional_6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_6.CustomButton.UseSelectable = true;
            this.Additional_6.CustomButton.Visible = false;
            this.Additional_6.Lines = new string[0];
            this.Additional_6.Location = new System.Drawing.Point(687, 143);
            this.Additional_6.MaxLength = 32767;
            this.Additional_6.Name = "Additional_6";
            this.Additional_6.PasswordChar = '\0';
            this.Additional_6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_6.SelectedText = "";
            this.Additional_6.SelectionLength = 0;
            this.Additional_6.SelectionStart = 0;
            this.Additional_6.ShortcutsEnabled = true;
            this.Additional_6.Size = new System.Drawing.Size(473, 23);
            this.Additional_6.TabIndex = 301;
            this.Additional_6.UseSelectable = true;
            this.Additional_6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_telefono
            // 
            // 
            // 
            // 
            this.seis_telefono.CustomButton.Image = null;
            this.seis_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.seis_telefono.CustomButton.Name = "";
            this.seis_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_telefono.CustomButton.TabIndex = 1;
            this.seis_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_telefono.CustomButton.UseSelectable = true;
            this.seis_telefono.CustomButton.Visible = false;
            this.seis_telefono.Lines = new string[] {
        " "};
            this.seis_telefono.Location = new System.Drawing.Point(773, 109);
            this.seis_telefono.MaxLength = 32767;
            this.seis_telefono.Name = "seis_telefono";
            this.seis_telefono.PasswordChar = '\0';
            this.seis_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_telefono.SelectedText = "";
            this.seis_telefono.SelectionLength = 0;
            this.seis_telefono.SelectionStart = 0;
            this.seis_telefono.ShortcutsEnabled = true;
            this.seis_telefono.Size = new System.Drawing.Size(387, 23);
            this.seis_telefono.TabIndex = 300;
            this.seis_telefono.Text = " ";
            this.seis_telefono.UseSelectable = true;
            this.seis_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_email
            // 
            // 
            // 
            // 
            this.seis_email.CustomButton.Image = null;
            this.seis_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.seis_email.CustomButton.Name = "";
            this.seis_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_email.CustomButton.TabIndex = 1;
            this.seis_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_email.CustomButton.UseSelectable = true;
            this.seis_email.CustomButton.Visible = false;
            this.seis_email.Lines = new string[] {
        " "};
            this.seis_email.Location = new System.Drawing.Point(762, 75);
            this.seis_email.MaxLength = 32767;
            this.seis_email.Name = "seis_email";
            this.seis_email.PasswordChar = '\0';
            this.seis_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_email.SelectedText = "";
            this.seis_email.SelectionLength = 0;
            this.seis_email.SelectionStart = 0;
            this.seis_email.ShortcutsEnabled = true;
            this.seis_email.Size = new System.Drawing.Size(398, 23);
            this.seis_email.TabIndex = 299;
            this.seis_email.Text = " ";
            this.seis_email.UseSelectable = true;
            this.seis_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_contacto
            // 
            // 
            // 
            // 
            this.seis_contacto.CustomButton.Image = null;
            this.seis_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.seis_contacto.CustomButton.Name = "";
            this.seis_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_contacto.CustomButton.TabIndex = 1;
            this.seis_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_contacto.CustomButton.UseSelectable = true;
            this.seis_contacto.CustomButton.Visible = false;
            this.seis_contacto.Lines = new string[] {
        " "};
            this.seis_contacto.Location = new System.Drawing.Point(701, 41);
            this.seis_contacto.MaxLength = 32767;
            this.seis_contacto.Name = "seis_contacto";
            this.seis_contacto.PasswordChar = '\0';
            this.seis_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_contacto.SelectedText = "";
            this.seis_contacto.SelectionLength = 0;
            this.seis_contacto.SelectionStart = 0;
            this.seis_contacto.ShortcutsEnabled = true;
            this.seis_contacto.Size = new System.Drawing.Size(459, 23);
            this.seis_contacto.TabIndex = 298;
            this.seis_contacto.Text = " ";
            this.seis_contacto.UseSelectable = true;
            this.seis_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel110
            // 
            this.metroLabel110.AutoSize = true;
            this.metroLabel110.Location = new System.Drawing.Point(541, 143);
            this.metroLabel110.Name = "metroLabel110";
            this.metroLabel110.Size = new System.Drawing.Size(140, 19);
            this.metroLabel110.TabIndex = 297;
            this.metroLabel110.Text = "Información Adicional:";
            // 
            // metroLabel111
            // 
            this.metroLabel111.AutoSize = true;
            this.metroLabel111.Location = new System.Drawing.Point(541, 109);
            this.metroLabel111.Name = "metroLabel111";
            this.metroLabel111.Size = new System.Drawing.Size(226, 19);
            this.metroLabel111.TabIndex = 296;
            this.metroLabel111.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel112
            // 
            this.metroLabel112.AutoSize = true;
            this.metroLabel112.Location = new System.Drawing.Point(541, 75);
            this.metroLabel112.Name = "metroLabel112";
            this.metroLabel112.Size = new System.Drawing.Size(215, 19);
            this.metroLabel112.TabIndex = 295;
            this.metroLabel112.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel113
            // 
            this.metroLabel113.AutoSize = true;
            this.metroLabel113.Location = new System.Drawing.Point(541, 41);
            this.metroLabel113.Name = "metroLabel113";
            this.metroLabel113.Size = new System.Drawing.Size(154, 19);
            this.metroLabel113.TabIndex = 294;
            this.metroLabel113.Text = "Contacto de Facturación:";
            // 
            // seis_codigo
            // 
            // 
            // 
            // 
            this.seis_codigo.CustomButton.Image = null;
            this.seis_codigo.CustomButton.Location = new System.Drawing.Point(407, 1);
            this.seis_codigo.CustomButton.Name = "";
            this.seis_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_codigo.CustomButton.TabIndex = 1;
            this.seis_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_codigo.CustomButton.UseSelectable = true;
            this.seis_codigo.CustomButton.Visible = false;
            this.seis_codigo.Lines = new string[] {
        " "};
            this.seis_codigo.Location = new System.Drawing.Point(106, 178);
            this.seis_codigo.MaxLength = 32767;
            this.seis_codigo.Name = "seis_codigo";
            this.seis_codigo.PasswordChar = '\0';
            this.seis_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_codigo.SelectedText = "";
            this.seis_codigo.SelectionLength = 0;
            this.seis_codigo.SelectionStart = 0;
            this.seis_codigo.ShortcutsEnabled = true;
            this.seis_codigo.Size = new System.Drawing.Size(429, 23);
            this.seis_codigo.TabIndex = 293;
            this.seis_codigo.Text = " ";
            this.seis_codigo.UseSelectable = true;
            this.seis_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_direccion
            // 
            // 
            // 
            // 
            this.seis_direccion.CustomButton.Image = null;
            this.seis_direccion.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.seis_direccion.CustomButton.Name = "";
            this.seis_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_direccion.CustomButton.TabIndex = 1;
            this.seis_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_direccion.CustomButton.UseSelectable = true;
            this.seis_direccion.CustomButton.Visible = false;
            this.seis_direccion.Lines = new string[] {
        " "};
            this.seis_direccion.Location = new System.Drawing.Point(113, 143);
            this.seis_direccion.MaxLength = 32767;
            this.seis_direccion.Name = "seis_direccion";
            this.seis_direccion.PasswordChar = '\0';
            this.seis_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_direccion.SelectedText = "";
            this.seis_direccion.SelectionLength = 0;
            this.seis_direccion.SelectionStart = 0;
            this.seis_direccion.ShortcutsEnabled = true;
            this.seis_direccion.Size = new System.Drawing.Size(422, 23);
            this.seis_direccion.TabIndex = 292;
            this.seis_direccion.Text = " ";
            this.seis_direccion.UseSelectable = true;
            this.seis_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_rfc
            // 
            // 
            // 
            // 
            this.seis_rfc.CustomButton.Image = null;
            this.seis_rfc.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.seis_rfc.CustomButton.Name = "";
            this.seis_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_rfc.CustomButton.TabIndex = 1;
            this.seis_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_rfc.CustomButton.UseSelectable = true;
            this.seis_rfc.CustomButton.Visible = false;
            this.seis_rfc.Lines = new string[] {
        " "};
            this.seis_rfc.Location = new System.Drawing.Point(98, 109);
            this.seis_rfc.MaxLength = 32767;
            this.seis_rfc.Name = "seis_rfc";
            this.seis_rfc.PasswordChar = '\0';
            this.seis_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_rfc.SelectedText = "";
            this.seis_rfc.SelectionLength = 0;
            this.seis_rfc.SelectionStart = 0;
            this.seis_rfc.ShortcutsEnabled = true;
            this.seis_rfc.Size = new System.Drawing.Size(437, 23);
            this.seis_rfc.TabIndex = 291;
            this.seis_rfc.Text = " ";
            this.seis_rfc.UseSelectable = true;
            this.seis_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_razon
            // 
            // 
            // 
            // 
            this.seis_razon.CustomButton.Image = null;
            this.seis_razon.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.seis_razon.CustomButton.Name = "";
            this.seis_razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_razon.CustomButton.TabIndex = 1;
            this.seis_razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_razon.CustomButton.UseSelectable = true;
            this.seis_razon.CustomButton.Visible = false;
            this.seis_razon.Lines = new string[] {
        " "};
            this.seis_razon.Location = new System.Drawing.Point(98, 75);
            this.seis_razon.MaxLength = 32767;
            this.seis_razon.Name = "seis_razon";
            this.seis_razon.PasswordChar = '\0';
            this.seis_razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_razon.SelectedText = "";
            this.seis_razon.SelectionLength = 0;
            this.seis_razon.SelectionStart = 0;
            this.seis_razon.ShortcutsEnabled = true;
            this.seis_razon.Size = new System.Drawing.Size(437, 23);
            this.seis_razon.TabIndex = 290;
            this.seis_razon.Text = " ";
            this.seis_razon.UseSelectable = true;
            this.seis_razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seis_hotel
            // 
            // 
            // 
            // 
            this.seis_hotel.CustomButton.Image = null;
            this.seis_hotel.CustomButton.Location = new System.Drawing.Point(458, 1);
            this.seis_hotel.CustomButton.Name = "";
            this.seis_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seis_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seis_hotel.CustomButton.TabIndex = 1;
            this.seis_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seis_hotel.CustomButton.UseSelectable = true;
            this.seis_hotel.CustomButton.Visible = false;
            this.seis_hotel.Lines = new string[] {
        " "};
            this.seis_hotel.Location = new System.Drawing.Point(55, 41);
            this.seis_hotel.MaxLength = 32767;
            this.seis_hotel.Name = "seis_hotel";
            this.seis_hotel.PasswordChar = '\0';
            this.seis_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seis_hotel.SelectedText = "";
            this.seis_hotel.SelectionLength = 0;
            this.seis_hotel.SelectionStart = 0;
            this.seis_hotel.ShortcutsEnabled = true;
            this.seis_hotel.Size = new System.Drawing.Size(480, 23);
            this.seis_hotel.TabIndex = 289;
            this.seis_hotel.Text = " ";
            this.seis_hotel.UseSelectable = true;
            this.seis_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seis_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel114
            // 
            this.metroLabel114.AutoSize = true;
            this.metroLabel114.Location = new System.Drawing.Point(6, 178);
            this.metroLabel114.Name = "metroLabel114";
            this.metroLabel114.Size = new System.Drawing.Size(94, 19);
            this.metroLabel114.TabIndex = 288;
            this.metroLabel114.Text = "Código Postal:";
            // 
            // metroLabel115
            // 
            this.metroLabel115.AutoSize = true;
            this.metroLabel115.Location = new System.Drawing.Point(6, 143);
            this.metroLabel115.Name = "metroLabel115";
            this.metroLabel115.Size = new System.Drawing.Size(101, 19);
            this.metroLabel115.TabIndex = 287;
            this.metroLabel115.Text = "Dirección Fiscal:";
            // 
            // metroLabel116
            // 
            this.metroLabel116.AutoSize = true;
            this.metroLabel116.Location = new System.Drawing.Point(6, 109);
            this.metroLabel116.Name = "metroLabel116";
            this.metroLabel116.Size = new System.Drawing.Size(84, 19);
            this.metroLabel116.TabIndex = 286;
            this.metroLabel116.Text = "RFC - Tax ID:";
            // 
            // metroLabel117
            // 
            this.metroLabel117.AutoSize = true;
            this.metroLabel117.Location = new System.Drawing.Point(6, 75);
            this.metroLabel117.Name = "metroLabel117";
            this.metroLabel117.Size = new System.Drawing.Size(86, 19);
            this.metroLabel117.TabIndex = 285;
            this.metroLabel117.Text = "Razón Social:";
            // 
            // metroLabel118
            // 
            this.metroLabel118.AutoSize = true;
            this.metroLabel118.Location = new System.Drawing.Point(6, 41);
            this.metroLabel118.Name = "metroLabel118";
            this.metroLabel118.Size = new System.Drawing.Size(43, 19);
            this.metroLabel118.TabIndex = 284;
            this.metroLabel118.Text = "Hotel:";
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox23.Controls.Add(this.Additional_5);
            this.groupBox23.Controls.Add(this.cinco_telefono);
            this.groupBox23.Controls.Add(this.cinco_email);
            this.groupBox23.Controls.Add(this.cinco_contacto);
            this.groupBox23.Controls.Add(this.metroLabel101);
            this.groupBox23.Controls.Add(this.metroLabel102);
            this.groupBox23.Controls.Add(this.metroLabel103);
            this.groupBox23.Controls.Add(this.metroLabel104);
            this.groupBox23.Controls.Add(this.cinco_codigo);
            this.groupBox23.Controls.Add(this.cinco_direccion);
            this.groupBox23.Controls.Add(this.cinco_rfc);
            this.groupBox23.Controls.Add(this.cinco_razon);
            this.groupBox23.Controls.Add(this.cinco_hotel);
            this.groupBox23.Controls.Add(this.metroLabel105);
            this.groupBox23.Controls.Add(this.metroLabel106);
            this.groupBox23.Controls.Add(this.metroLabel107);
            this.groupBox23.Controls.Add(this.metroLabel108);
            this.groupBox23.Controls.Add(this.metroLabel109);
            this.groupBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox23.Location = new System.Drawing.Point(6, 913);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(1175, 218);
            this.groupBox23.TabIndex = 306;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Quinto";
            // 
            // Additional_5
            // 
            // 
            // 
            // 
            this.Additional_5.CustomButton.Image = null;
            this.Additional_5.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_5.CustomButton.Name = "";
            this.Additional_5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_5.CustomButton.TabIndex = 1;
            this.Additional_5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_5.CustomButton.UseSelectable = true;
            this.Additional_5.CustomButton.Visible = false;
            this.Additional_5.Lines = new string[0];
            this.Additional_5.Location = new System.Drawing.Point(687, 143);
            this.Additional_5.MaxLength = 32767;
            this.Additional_5.Name = "Additional_5";
            this.Additional_5.PasswordChar = '\0';
            this.Additional_5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_5.SelectedText = "";
            this.Additional_5.SelectionLength = 0;
            this.Additional_5.SelectionStart = 0;
            this.Additional_5.ShortcutsEnabled = true;
            this.Additional_5.Size = new System.Drawing.Size(473, 23);
            this.Additional_5.TabIndex = 301;
            this.Additional_5.UseSelectable = true;
            this.Additional_5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_telefono
            // 
            // 
            // 
            // 
            this.cinco_telefono.CustomButton.Image = null;
            this.cinco_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.cinco_telefono.CustomButton.Name = "";
            this.cinco_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_telefono.CustomButton.TabIndex = 1;
            this.cinco_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_telefono.CustomButton.UseSelectable = true;
            this.cinco_telefono.CustomButton.Visible = false;
            this.cinco_telefono.Lines = new string[] {
        " "};
            this.cinco_telefono.Location = new System.Drawing.Point(773, 109);
            this.cinco_telefono.MaxLength = 32767;
            this.cinco_telefono.Name = "cinco_telefono";
            this.cinco_telefono.PasswordChar = '\0';
            this.cinco_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_telefono.SelectedText = "";
            this.cinco_telefono.SelectionLength = 0;
            this.cinco_telefono.SelectionStart = 0;
            this.cinco_telefono.ShortcutsEnabled = true;
            this.cinco_telefono.Size = new System.Drawing.Size(387, 23);
            this.cinco_telefono.TabIndex = 300;
            this.cinco_telefono.Text = " ";
            this.cinco_telefono.UseSelectable = true;
            this.cinco_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_email
            // 
            // 
            // 
            // 
            this.cinco_email.CustomButton.Image = null;
            this.cinco_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.cinco_email.CustomButton.Name = "";
            this.cinco_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_email.CustomButton.TabIndex = 1;
            this.cinco_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_email.CustomButton.UseSelectable = true;
            this.cinco_email.CustomButton.Visible = false;
            this.cinco_email.Lines = new string[] {
        " "};
            this.cinco_email.Location = new System.Drawing.Point(762, 75);
            this.cinco_email.MaxLength = 32767;
            this.cinco_email.Name = "cinco_email";
            this.cinco_email.PasswordChar = '\0';
            this.cinco_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_email.SelectedText = "";
            this.cinco_email.SelectionLength = 0;
            this.cinco_email.SelectionStart = 0;
            this.cinco_email.ShortcutsEnabled = true;
            this.cinco_email.Size = new System.Drawing.Size(398, 23);
            this.cinco_email.TabIndex = 299;
            this.cinco_email.Text = " ";
            this.cinco_email.UseSelectable = true;
            this.cinco_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_contacto
            // 
            // 
            // 
            // 
            this.cinco_contacto.CustomButton.Image = null;
            this.cinco_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.cinco_contacto.CustomButton.Name = "";
            this.cinco_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_contacto.CustomButton.TabIndex = 1;
            this.cinco_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_contacto.CustomButton.UseSelectable = true;
            this.cinco_contacto.CustomButton.Visible = false;
            this.cinco_contacto.Lines = new string[] {
        " "};
            this.cinco_contacto.Location = new System.Drawing.Point(701, 41);
            this.cinco_contacto.MaxLength = 32767;
            this.cinco_contacto.Name = "cinco_contacto";
            this.cinco_contacto.PasswordChar = '\0';
            this.cinco_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_contacto.SelectedText = "";
            this.cinco_contacto.SelectionLength = 0;
            this.cinco_contacto.SelectionStart = 0;
            this.cinco_contacto.ShortcutsEnabled = true;
            this.cinco_contacto.Size = new System.Drawing.Size(459, 23);
            this.cinco_contacto.TabIndex = 298;
            this.cinco_contacto.Text = " ";
            this.cinco_contacto.UseSelectable = true;
            this.cinco_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel101
            // 
            this.metroLabel101.AutoSize = true;
            this.metroLabel101.Location = new System.Drawing.Point(541, 143);
            this.metroLabel101.Name = "metroLabel101";
            this.metroLabel101.Size = new System.Drawing.Size(140, 19);
            this.metroLabel101.TabIndex = 297;
            this.metroLabel101.Text = "Información Adicional:";
            // 
            // metroLabel102
            // 
            this.metroLabel102.AutoSize = true;
            this.metroLabel102.Location = new System.Drawing.Point(541, 109);
            this.metroLabel102.Name = "metroLabel102";
            this.metroLabel102.Size = new System.Drawing.Size(226, 19);
            this.metroLabel102.TabIndex = 296;
            this.metroLabel102.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel103
            // 
            this.metroLabel103.AutoSize = true;
            this.metroLabel103.Location = new System.Drawing.Point(541, 75);
            this.metroLabel103.Name = "metroLabel103";
            this.metroLabel103.Size = new System.Drawing.Size(215, 19);
            this.metroLabel103.TabIndex = 295;
            this.metroLabel103.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel104
            // 
            this.metroLabel104.AutoSize = true;
            this.metroLabel104.Location = new System.Drawing.Point(541, 41);
            this.metroLabel104.Name = "metroLabel104";
            this.metroLabel104.Size = new System.Drawing.Size(154, 19);
            this.metroLabel104.TabIndex = 294;
            this.metroLabel104.Text = "Contacto de Facturación:";
            // 
            // cinco_codigo
            // 
            // 
            // 
            // 
            this.cinco_codigo.CustomButton.Image = null;
            this.cinco_codigo.CustomButton.Location = new System.Drawing.Point(407, 1);
            this.cinco_codigo.CustomButton.Name = "";
            this.cinco_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_codigo.CustomButton.TabIndex = 1;
            this.cinco_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_codigo.CustomButton.UseSelectable = true;
            this.cinco_codigo.CustomButton.Visible = false;
            this.cinco_codigo.Lines = new string[] {
        " "};
            this.cinco_codigo.Location = new System.Drawing.Point(106, 178);
            this.cinco_codigo.MaxLength = 32767;
            this.cinco_codigo.Name = "cinco_codigo";
            this.cinco_codigo.PasswordChar = '\0';
            this.cinco_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_codigo.SelectedText = "";
            this.cinco_codigo.SelectionLength = 0;
            this.cinco_codigo.SelectionStart = 0;
            this.cinco_codigo.ShortcutsEnabled = true;
            this.cinco_codigo.Size = new System.Drawing.Size(429, 23);
            this.cinco_codigo.TabIndex = 293;
            this.cinco_codigo.Text = " ";
            this.cinco_codigo.UseSelectable = true;
            this.cinco_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_direccion
            // 
            // 
            // 
            // 
            this.cinco_direccion.CustomButton.Image = null;
            this.cinco_direccion.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.cinco_direccion.CustomButton.Name = "";
            this.cinco_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_direccion.CustomButton.TabIndex = 1;
            this.cinco_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_direccion.CustomButton.UseSelectable = true;
            this.cinco_direccion.CustomButton.Visible = false;
            this.cinco_direccion.Lines = new string[] {
        " "};
            this.cinco_direccion.Location = new System.Drawing.Point(113, 143);
            this.cinco_direccion.MaxLength = 32767;
            this.cinco_direccion.Name = "cinco_direccion";
            this.cinco_direccion.PasswordChar = '\0';
            this.cinco_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_direccion.SelectedText = "";
            this.cinco_direccion.SelectionLength = 0;
            this.cinco_direccion.SelectionStart = 0;
            this.cinco_direccion.ShortcutsEnabled = true;
            this.cinco_direccion.Size = new System.Drawing.Size(422, 23);
            this.cinco_direccion.TabIndex = 292;
            this.cinco_direccion.Text = " ";
            this.cinco_direccion.UseSelectable = true;
            this.cinco_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_rfc
            // 
            // 
            // 
            // 
            this.cinco_rfc.CustomButton.Image = null;
            this.cinco_rfc.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.cinco_rfc.CustomButton.Name = "";
            this.cinco_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_rfc.CustomButton.TabIndex = 1;
            this.cinco_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_rfc.CustomButton.UseSelectable = true;
            this.cinco_rfc.CustomButton.Visible = false;
            this.cinco_rfc.Lines = new string[] {
        " "};
            this.cinco_rfc.Location = new System.Drawing.Point(98, 109);
            this.cinco_rfc.MaxLength = 32767;
            this.cinco_rfc.Name = "cinco_rfc";
            this.cinco_rfc.PasswordChar = '\0';
            this.cinco_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_rfc.SelectedText = "";
            this.cinco_rfc.SelectionLength = 0;
            this.cinco_rfc.SelectionStart = 0;
            this.cinco_rfc.ShortcutsEnabled = true;
            this.cinco_rfc.Size = new System.Drawing.Size(437, 23);
            this.cinco_rfc.TabIndex = 291;
            this.cinco_rfc.Text = " ";
            this.cinco_rfc.UseSelectable = true;
            this.cinco_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_razon
            // 
            // 
            // 
            // 
            this.cinco_razon.CustomButton.Image = null;
            this.cinco_razon.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.cinco_razon.CustomButton.Name = "";
            this.cinco_razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_razon.CustomButton.TabIndex = 1;
            this.cinco_razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_razon.CustomButton.UseSelectable = true;
            this.cinco_razon.CustomButton.Visible = false;
            this.cinco_razon.Lines = new string[] {
        " "};
            this.cinco_razon.Location = new System.Drawing.Point(98, 75);
            this.cinco_razon.MaxLength = 32767;
            this.cinco_razon.Name = "cinco_razon";
            this.cinco_razon.PasswordChar = '\0';
            this.cinco_razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_razon.SelectedText = "";
            this.cinco_razon.SelectionLength = 0;
            this.cinco_razon.SelectionStart = 0;
            this.cinco_razon.ShortcutsEnabled = true;
            this.cinco_razon.Size = new System.Drawing.Size(437, 23);
            this.cinco_razon.TabIndex = 290;
            this.cinco_razon.Text = " ";
            this.cinco_razon.UseSelectable = true;
            this.cinco_razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cinco_hotel
            // 
            // 
            // 
            // 
            this.cinco_hotel.CustomButton.Image = null;
            this.cinco_hotel.CustomButton.Location = new System.Drawing.Point(458, 1);
            this.cinco_hotel.CustomButton.Name = "";
            this.cinco_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cinco_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cinco_hotel.CustomButton.TabIndex = 1;
            this.cinco_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cinco_hotel.CustomButton.UseSelectable = true;
            this.cinco_hotel.CustomButton.Visible = false;
            this.cinco_hotel.Lines = new string[] {
        " "};
            this.cinco_hotel.Location = new System.Drawing.Point(55, 41);
            this.cinco_hotel.MaxLength = 32767;
            this.cinco_hotel.Name = "cinco_hotel";
            this.cinco_hotel.PasswordChar = '\0';
            this.cinco_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cinco_hotel.SelectedText = "";
            this.cinco_hotel.SelectionLength = 0;
            this.cinco_hotel.SelectionStart = 0;
            this.cinco_hotel.ShortcutsEnabled = true;
            this.cinco_hotel.Size = new System.Drawing.Size(480, 23);
            this.cinco_hotel.TabIndex = 289;
            this.cinco_hotel.Text = " ";
            this.cinco_hotel.UseSelectable = true;
            this.cinco_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cinco_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel105
            // 
            this.metroLabel105.AutoSize = true;
            this.metroLabel105.Location = new System.Drawing.Point(6, 178);
            this.metroLabel105.Name = "metroLabel105";
            this.metroLabel105.Size = new System.Drawing.Size(94, 19);
            this.metroLabel105.TabIndex = 288;
            this.metroLabel105.Text = "Código Postal:";
            // 
            // metroLabel106
            // 
            this.metroLabel106.AutoSize = true;
            this.metroLabel106.Location = new System.Drawing.Point(6, 143);
            this.metroLabel106.Name = "metroLabel106";
            this.metroLabel106.Size = new System.Drawing.Size(101, 19);
            this.metroLabel106.TabIndex = 287;
            this.metroLabel106.Text = "Dirección Fiscal:";
            // 
            // metroLabel107
            // 
            this.metroLabel107.AutoSize = true;
            this.metroLabel107.Location = new System.Drawing.Point(6, 109);
            this.metroLabel107.Name = "metroLabel107";
            this.metroLabel107.Size = new System.Drawing.Size(84, 19);
            this.metroLabel107.TabIndex = 286;
            this.metroLabel107.Text = "RFC - Tax ID:";
            // 
            // metroLabel108
            // 
            this.metroLabel108.AutoSize = true;
            this.metroLabel108.Location = new System.Drawing.Point(6, 75);
            this.metroLabel108.Name = "metroLabel108";
            this.metroLabel108.Size = new System.Drawing.Size(86, 19);
            this.metroLabel108.TabIndex = 285;
            this.metroLabel108.Text = "Razón Social:";
            // 
            // metroLabel109
            // 
            this.metroLabel109.AutoSize = true;
            this.metroLabel109.Location = new System.Drawing.Point(6, 41);
            this.metroLabel109.Name = "metroLabel109";
            this.metroLabel109.Size = new System.Drawing.Size(43, 19);
            this.metroLabel109.TabIndex = 284;
            this.metroLabel109.Text = "Hotel:";
            // 
            // groupBox22
            // 
            this.groupBox22.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox22.Controls.Add(this.Additional_4);
            this.groupBox22.Controls.Add(this.cuatro_telefono);
            this.groupBox22.Controls.Add(this.cuatro_email);
            this.groupBox22.Controls.Add(this.cuatro_contacto);
            this.groupBox22.Controls.Add(this.metroLabel92);
            this.groupBox22.Controls.Add(this.metroLabel93);
            this.groupBox22.Controls.Add(this.metroLabel94);
            this.groupBox22.Controls.Add(this.metroLabel95);
            this.groupBox22.Controls.Add(this.cuatro_codigo);
            this.groupBox22.Controls.Add(this.cuatro_direccion);
            this.groupBox22.Controls.Add(this.cuatro_rfc);
            this.groupBox22.Controls.Add(this.cuatro_razon);
            this.groupBox22.Controls.Add(this.cuatro_hotel);
            this.groupBox22.Controls.Add(this.metroLabel96);
            this.groupBox22.Controls.Add(this.metroLabel97);
            this.groupBox22.Controls.Add(this.metroLabel98);
            this.groupBox22.Controls.Add(this.metroLabel99);
            this.groupBox22.Controls.Add(this.metroLabel100);
            this.groupBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox22.Location = new System.Drawing.Point(6, 689);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(1175, 218);
            this.groupBox22.TabIndex = 305;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Cuarto";
            // 
            // Additional_4
            // 
            // 
            // 
            // 
            this.Additional_4.CustomButton.Image = null;
            this.Additional_4.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_4.CustomButton.Name = "";
            this.Additional_4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_4.CustomButton.TabIndex = 1;
            this.Additional_4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_4.CustomButton.UseSelectable = true;
            this.Additional_4.CustomButton.Visible = false;
            this.Additional_4.Lines = new string[0];
            this.Additional_4.Location = new System.Drawing.Point(687, 143);
            this.Additional_4.MaxLength = 32767;
            this.Additional_4.Name = "Additional_4";
            this.Additional_4.PasswordChar = '\0';
            this.Additional_4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_4.SelectedText = "";
            this.Additional_4.SelectionLength = 0;
            this.Additional_4.SelectionStart = 0;
            this.Additional_4.ShortcutsEnabled = true;
            this.Additional_4.Size = new System.Drawing.Size(473, 23);
            this.Additional_4.TabIndex = 301;
            this.Additional_4.UseSelectable = true;
            this.Additional_4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_telefono
            // 
            // 
            // 
            // 
            this.cuatro_telefono.CustomButton.Image = null;
            this.cuatro_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.cuatro_telefono.CustomButton.Name = "";
            this.cuatro_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_telefono.CustomButton.TabIndex = 1;
            this.cuatro_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_telefono.CustomButton.UseSelectable = true;
            this.cuatro_telefono.CustomButton.Visible = false;
            this.cuatro_telefono.Lines = new string[] {
        " "};
            this.cuatro_telefono.Location = new System.Drawing.Point(773, 109);
            this.cuatro_telefono.MaxLength = 32767;
            this.cuatro_telefono.Name = "cuatro_telefono";
            this.cuatro_telefono.PasswordChar = '\0';
            this.cuatro_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_telefono.SelectedText = "";
            this.cuatro_telefono.SelectionLength = 0;
            this.cuatro_telefono.SelectionStart = 0;
            this.cuatro_telefono.ShortcutsEnabled = true;
            this.cuatro_telefono.Size = new System.Drawing.Size(387, 23);
            this.cuatro_telefono.TabIndex = 300;
            this.cuatro_telefono.Text = " ";
            this.cuatro_telefono.UseSelectable = true;
            this.cuatro_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_email
            // 
            // 
            // 
            // 
            this.cuatro_email.CustomButton.Image = null;
            this.cuatro_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.cuatro_email.CustomButton.Name = "";
            this.cuatro_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_email.CustomButton.TabIndex = 1;
            this.cuatro_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_email.CustomButton.UseSelectable = true;
            this.cuatro_email.CustomButton.Visible = false;
            this.cuatro_email.Lines = new string[] {
        " "};
            this.cuatro_email.Location = new System.Drawing.Point(762, 75);
            this.cuatro_email.MaxLength = 32767;
            this.cuatro_email.Name = "cuatro_email";
            this.cuatro_email.PasswordChar = '\0';
            this.cuatro_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_email.SelectedText = "";
            this.cuatro_email.SelectionLength = 0;
            this.cuatro_email.SelectionStart = 0;
            this.cuatro_email.ShortcutsEnabled = true;
            this.cuatro_email.Size = new System.Drawing.Size(398, 23);
            this.cuatro_email.TabIndex = 299;
            this.cuatro_email.Text = " ";
            this.cuatro_email.UseSelectable = true;
            this.cuatro_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_contacto
            // 
            // 
            // 
            // 
            this.cuatro_contacto.CustomButton.Image = null;
            this.cuatro_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.cuatro_contacto.CustomButton.Name = "";
            this.cuatro_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_contacto.CustomButton.TabIndex = 1;
            this.cuatro_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_contacto.CustomButton.UseSelectable = true;
            this.cuatro_contacto.CustomButton.Visible = false;
            this.cuatro_contacto.Lines = new string[] {
        " "};
            this.cuatro_contacto.Location = new System.Drawing.Point(701, 41);
            this.cuatro_contacto.MaxLength = 32767;
            this.cuatro_contacto.Name = "cuatro_contacto";
            this.cuatro_contacto.PasswordChar = '\0';
            this.cuatro_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_contacto.SelectedText = "";
            this.cuatro_contacto.SelectionLength = 0;
            this.cuatro_contacto.SelectionStart = 0;
            this.cuatro_contacto.ShortcutsEnabled = true;
            this.cuatro_contacto.Size = new System.Drawing.Size(459, 23);
            this.cuatro_contacto.TabIndex = 298;
            this.cuatro_contacto.Text = " ";
            this.cuatro_contacto.UseSelectable = true;
            this.cuatro_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel92
            // 
            this.metroLabel92.AutoSize = true;
            this.metroLabel92.Location = new System.Drawing.Point(541, 143);
            this.metroLabel92.Name = "metroLabel92";
            this.metroLabel92.Size = new System.Drawing.Size(140, 19);
            this.metroLabel92.TabIndex = 297;
            this.metroLabel92.Text = "Información Adicional:";
            // 
            // metroLabel93
            // 
            this.metroLabel93.AutoSize = true;
            this.metroLabel93.Location = new System.Drawing.Point(541, 109);
            this.metroLabel93.Name = "metroLabel93";
            this.metroLabel93.Size = new System.Drawing.Size(226, 19);
            this.metroLabel93.TabIndex = 296;
            this.metroLabel93.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel94
            // 
            this.metroLabel94.AutoSize = true;
            this.metroLabel94.Location = new System.Drawing.Point(541, 75);
            this.metroLabel94.Name = "metroLabel94";
            this.metroLabel94.Size = new System.Drawing.Size(215, 19);
            this.metroLabel94.TabIndex = 295;
            this.metroLabel94.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel95
            // 
            this.metroLabel95.AutoSize = true;
            this.metroLabel95.Location = new System.Drawing.Point(541, 41);
            this.metroLabel95.Name = "metroLabel95";
            this.metroLabel95.Size = new System.Drawing.Size(154, 19);
            this.metroLabel95.TabIndex = 294;
            this.metroLabel95.Text = "Contacto de Facturación:";
            // 
            // cuatro_codigo
            // 
            // 
            // 
            // 
            this.cuatro_codigo.CustomButton.Image = null;
            this.cuatro_codigo.CustomButton.Location = new System.Drawing.Point(407, 1);
            this.cuatro_codigo.CustomButton.Name = "";
            this.cuatro_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_codigo.CustomButton.TabIndex = 1;
            this.cuatro_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_codigo.CustomButton.UseSelectable = true;
            this.cuatro_codigo.CustomButton.Visible = false;
            this.cuatro_codigo.Lines = new string[] {
        " "};
            this.cuatro_codigo.Location = new System.Drawing.Point(106, 178);
            this.cuatro_codigo.MaxLength = 32767;
            this.cuatro_codigo.Name = "cuatro_codigo";
            this.cuatro_codigo.PasswordChar = '\0';
            this.cuatro_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_codigo.SelectedText = "";
            this.cuatro_codigo.SelectionLength = 0;
            this.cuatro_codigo.SelectionStart = 0;
            this.cuatro_codigo.ShortcutsEnabled = true;
            this.cuatro_codigo.Size = new System.Drawing.Size(429, 23);
            this.cuatro_codigo.TabIndex = 293;
            this.cuatro_codigo.Text = " ";
            this.cuatro_codigo.UseSelectable = true;
            this.cuatro_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_direccion
            // 
            // 
            // 
            // 
            this.cuatro_direccion.CustomButton.Image = null;
            this.cuatro_direccion.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.cuatro_direccion.CustomButton.Name = "";
            this.cuatro_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_direccion.CustomButton.TabIndex = 1;
            this.cuatro_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_direccion.CustomButton.UseSelectable = true;
            this.cuatro_direccion.CustomButton.Visible = false;
            this.cuatro_direccion.Lines = new string[] {
        " "};
            this.cuatro_direccion.Location = new System.Drawing.Point(113, 143);
            this.cuatro_direccion.MaxLength = 32767;
            this.cuatro_direccion.Name = "cuatro_direccion";
            this.cuatro_direccion.PasswordChar = '\0';
            this.cuatro_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_direccion.SelectedText = "";
            this.cuatro_direccion.SelectionLength = 0;
            this.cuatro_direccion.SelectionStart = 0;
            this.cuatro_direccion.ShortcutsEnabled = true;
            this.cuatro_direccion.Size = new System.Drawing.Size(422, 23);
            this.cuatro_direccion.TabIndex = 292;
            this.cuatro_direccion.Text = " ";
            this.cuatro_direccion.UseSelectable = true;
            this.cuatro_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_rfc
            // 
            // 
            // 
            // 
            this.cuatro_rfc.CustomButton.Image = null;
            this.cuatro_rfc.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.cuatro_rfc.CustomButton.Name = "";
            this.cuatro_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_rfc.CustomButton.TabIndex = 1;
            this.cuatro_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_rfc.CustomButton.UseSelectable = true;
            this.cuatro_rfc.CustomButton.Visible = false;
            this.cuatro_rfc.Lines = new string[] {
        " "};
            this.cuatro_rfc.Location = new System.Drawing.Point(98, 109);
            this.cuatro_rfc.MaxLength = 32767;
            this.cuatro_rfc.Name = "cuatro_rfc";
            this.cuatro_rfc.PasswordChar = '\0';
            this.cuatro_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_rfc.SelectedText = "";
            this.cuatro_rfc.SelectionLength = 0;
            this.cuatro_rfc.SelectionStart = 0;
            this.cuatro_rfc.ShortcutsEnabled = true;
            this.cuatro_rfc.Size = new System.Drawing.Size(437, 23);
            this.cuatro_rfc.TabIndex = 291;
            this.cuatro_rfc.Text = " ";
            this.cuatro_rfc.UseSelectable = true;
            this.cuatro_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_razon
            // 
            // 
            // 
            // 
            this.cuatro_razon.CustomButton.Image = null;
            this.cuatro_razon.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.cuatro_razon.CustomButton.Name = "";
            this.cuatro_razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_razon.CustomButton.TabIndex = 1;
            this.cuatro_razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_razon.CustomButton.UseSelectable = true;
            this.cuatro_razon.CustomButton.Visible = false;
            this.cuatro_razon.Lines = new string[] {
        " "};
            this.cuatro_razon.Location = new System.Drawing.Point(98, 75);
            this.cuatro_razon.MaxLength = 32767;
            this.cuatro_razon.Name = "cuatro_razon";
            this.cuatro_razon.PasswordChar = '\0';
            this.cuatro_razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_razon.SelectedText = "";
            this.cuatro_razon.SelectionLength = 0;
            this.cuatro_razon.SelectionStart = 0;
            this.cuatro_razon.ShortcutsEnabled = true;
            this.cuatro_razon.Size = new System.Drawing.Size(437, 23);
            this.cuatro_razon.TabIndex = 290;
            this.cuatro_razon.Text = " ";
            this.cuatro_razon.UseSelectable = true;
            this.cuatro_razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cuatro_hotel
            // 
            // 
            // 
            // 
            this.cuatro_hotel.CustomButton.Image = null;
            this.cuatro_hotel.CustomButton.Location = new System.Drawing.Point(458, 1);
            this.cuatro_hotel.CustomButton.Name = "";
            this.cuatro_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cuatro_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cuatro_hotel.CustomButton.TabIndex = 1;
            this.cuatro_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cuatro_hotel.CustomButton.UseSelectable = true;
            this.cuatro_hotel.CustomButton.Visible = false;
            this.cuatro_hotel.Lines = new string[] {
        " "};
            this.cuatro_hotel.Location = new System.Drawing.Point(55, 41);
            this.cuatro_hotel.MaxLength = 32767;
            this.cuatro_hotel.Name = "cuatro_hotel";
            this.cuatro_hotel.PasswordChar = '\0';
            this.cuatro_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuatro_hotel.SelectedText = "";
            this.cuatro_hotel.SelectionLength = 0;
            this.cuatro_hotel.SelectionStart = 0;
            this.cuatro_hotel.ShortcutsEnabled = true;
            this.cuatro_hotel.Size = new System.Drawing.Size(480, 23);
            this.cuatro_hotel.TabIndex = 289;
            this.cuatro_hotel.Text = " ";
            this.cuatro_hotel.UseSelectable = true;
            this.cuatro_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cuatro_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel96
            // 
            this.metroLabel96.AutoSize = true;
            this.metroLabel96.Location = new System.Drawing.Point(6, 178);
            this.metroLabel96.Name = "metroLabel96";
            this.metroLabel96.Size = new System.Drawing.Size(94, 19);
            this.metroLabel96.TabIndex = 288;
            this.metroLabel96.Text = "Código Postal:";
            // 
            // metroLabel97
            // 
            this.metroLabel97.AutoSize = true;
            this.metroLabel97.Location = new System.Drawing.Point(6, 143);
            this.metroLabel97.Name = "metroLabel97";
            this.metroLabel97.Size = new System.Drawing.Size(101, 19);
            this.metroLabel97.TabIndex = 287;
            this.metroLabel97.Text = "Dirección Fiscal:";
            // 
            // metroLabel98
            // 
            this.metroLabel98.AutoSize = true;
            this.metroLabel98.Location = new System.Drawing.Point(6, 109);
            this.metroLabel98.Name = "metroLabel98";
            this.metroLabel98.Size = new System.Drawing.Size(84, 19);
            this.metroLabel98.TabIndex = 286;
            this.metroLabel98.Text = "RFC - Tax ID:";
            // 
            // metroLabel99
            // 
            this.metroLabel99.AutoSize = true;
            this.metroLabel99.Location = new System.Drawing.Point(6, 75);
            this.metroLabel99.Name = "metroLabel99";
            this.metroLabel99.Size = new System.Drawing.Size(86, 19);
            this.metroLabel99.TabIndex = 285;
            this.metroLabel99.Text = "Razón Social:";
            // 
            // metroLabel100
            // 
            this.metroLabel100.AutoSize = true;
            this.metroLabel100.Location = new System.Drawing.Point(6, 41);
            this.metroLabel100.Name = "metroLabel100";
            this.metroLabel100.Size = new System.Drawing.Size(43, 19);
            this.metroLabel100.TabIndex = 284;
            this.metroLabel100.Text = "Hotel:";
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox19.Controls.Add(this.Additional_3);
            this.groupBox19.Controls.Add(this.tres_telefono);
            this.groupBox19.Controls.Add(this.tres_email);
            this.groupBox19.Controls.Add(this.tres_contacto);
            this.groupBox19.Controls.Add(this.metroLabel83);
            this.groupBox19.Controls.Add(this.metroLabel84);
            this.groupBox19.Controls.Add(this.metroLabel85);
            this.groupBox19.Controls.Add(this.metroLabel86);
            this.groupBox19.Controls.Add(this.tres_codigo);
            this.groupBox19.Controls.Add(this.tres_direccion);
            this.groupBox19.Controls.Add(this.tres_rfc);
            this.groupBox19.Controls.Add(this.tres_Razon);
            this.groupBox19.Controls.Add(this.tres_hotel);
            this.groupBox19.Controls.Add(this.metroLabel87);
            this.groupBox19.Controls.Add(this.metroLabel88);
            this.groupBox19.Controls.Add(this.metroLabel89);
            this.groupBox19.Controls.Add(this.metroLabel90);
            this.groupBox19.Controls.Add(this.metroLabel91);
            this.groupBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox19.Location = new System.Drawing.Point(6, 465);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1175, 218);
            this.groupBox19.TabIndex = 304;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Tercero";
            // 
            // Additional_3
            // 
            // 
            // 
            // 
            this.Additional_3.CustomButton.Image = null;
            this.Additional_3.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_3.CustomButton.Name = "";
            this.Additional_3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_3.CustomButton.TabIndex = 1;
            this.Additional_3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_3.CustomButton.UseSelectable = true;
            this.Additional_3.CustomButton.Visible = false;
            this.Additional_3.Lines = new string[0];
            this.Additional_3.Location = new System.Drawing.Point(687, 143);
            this.Additional_3.MaxLength = 32767;
            this.Additional_3.Name = "Additional_3";
            this.Additional_3.PasswordChar = '\0';
            this.Additional_3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_3.SelectedText = "";
            this.Additional_3.SelectionLength = 0;
            this.Additional_3.SelectionStart = 0;
            this.Additional_3.ShortcutsEnabled = true;
            this.Additional_3.Size = new System.Drawing.Size(473, 23);
            this.Additional_3.TabIndex = 301;
            this.Additional_3.UseSelectable = true;
            this.Additional_3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_telefono
            // 
            // 
            // 
            // 
            this.tres_telefono.CustomButton.Image = null;
            this.tres_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.tres_telefono.CustomButton.Name = "";
            this.tres_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_telefono.CustomButton.TabIndex = 1;
            this.tres_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_telefono.CustomButton.UseSelectable = true;
            this.tres_telefono.CustomButton.Visible = false;
            this.tres_telefono.Lines = new string[] {
        " "};
            this.tres_telefono.Location = new System.Drawing.Point(773, 109);
            this.tres_telefono.MaxLength = 32767;
            this.tres_telefono.Name = "tres_telefono";
            this.tres_telefono.PasswordChar = '\0';
            this.tres_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_telefono.SelectedText = "";
            this.tres_telefono.SelectionLength = 0;
            this.tres_telefono.SelectionStart = 0;
            this.tres_telefono.ShortcutsEnabled = true;
            this.tres_telefono.Size = new System.Drawing.Size(387, 23);
            this.tres_telefono.TabIndex = 300;
            this.tres_telefono.Text = " ";
            this.tres_telefono.UseSelectable = true;
            this.tres_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_email
            // 
            // 
            // 
            // 
            this.tres_email.CustomButton.Image = null;
            this.tres_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.tres_email.CustomButton.Name = "";
            this.tres_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_email.CustomButton.TabIndex = 1;
            this.tres_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_email.CustomButton.UseSelectable = true;
            this.tres_email.CustomButton.Visible = false;
            this.tres_email.Lines = new string[] {
        " "};
            this.tres_email.Location = new System.Drawing.Point(762, 75);
            this.tres_email.MaxLength = 32767;
            this.tres_email.Name = "tres_email";
            this.tres_email.PasswordChar = '\0';
            this.tres_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_email.SelectedText = "";
            this.tres_email.SelectionLength = 0;
            this.tres_email.SelectionStart = 0;
            this.tres_email.ShortcutsEnabled = true;
            this.tres_email.Size = new System.Drawing.Size(398, 23);
            this.tres_email.TabIndex = 299;
            this.tres_email.Text = " ";
            this.tres_email.UseSelectable = true;
            this.tres_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_contacto
            // 
            // 
            // 
            // 
            this.tres_contacto.CustomButton.Image = null;
            this.tres_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.tres_contacto.CustomButton.Name = "";
            this.tres_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_contacto.CustomButton.TabIndex = 1;
            this.tres_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_contacto.CustomButton.UseSelectable = true;
            this.tres_contacto.CustomButton.Visible = false;
            this.tres_contacto.Lines = new string[] {
        " "};
            this.tres_contacto.Location = new System.Drawing.Point(701, 41);
            this.tres_contacto.MaxLength = 32767;
            this.tres_contacto.Name = "tres_contacto";
            this.tres_contacto.PasswordChar = '\0';
            this.tres_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_contacto.SelectedText = "";
            this.tres_contacto.SelectionLength = 0;
            this.tres_contacto.SelectionStart = 0;
            this.tres_contacto.ShortcutsEnabled = true;
            this.tres_contacto.Size = new System.Drawing.Size(459, 23);
            this.tres_contacto.TabIndex = 298;
            this.tres_contacto.Text = " ";
            this.tres_contacto.UseSelectable = true;
            this.tres_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel83
            // 
            this.metroLabel83.AutoSize = true;
            this.metroLabel83.Location = new System.Drawing.Point(541, 143);
            this.metroLabel83.Name = "metroLabel83";
            this.metroLabel83.Size = new System.Drawing.Size(140, 19);
            this.metroLabel83.TabIndex = 297;
            this.metroLabel83.Text = "Información Adicional:";
            // 
            // metroLabel84
            // 
            this.metroLabel84.AutoSize = true;
            this.metroLabel84.Location = new System.Drawing.Point(541, 109);
            this.metroLabel84.Name = "metroLabel84";
            this.metroLabel84.Size = new System.Drawing.Size(226, 19);
            this.metroLabel84.TabIndex = 296;
            this.metroLabel84.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel85
            // 
            this.metroLabel85.AutoSize = true;
            this.metroLabel85.Location = new System.Drawing.Point(541, 75);
            this.metroLabel85.Name = "metroLabel85";
            this.metroLabel85.Size = new System.Drawing.Size(215, 19);
            this.metroLabel85.TabIndex = 295;
            this.metroLabel85.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel86
            // 
            this.metroLabel86.AutoSize = true;
            this.metroLabel86.Location = new System.Drawing.Point(541, 41);
            this.metroLabel86.Name = "metroLabel86";
            this.metroLabel86.Size = new System.Drawing.Size(154, 19);
            this.metroLabel86.TabIndex = 294;
            this.metroLabel86.Text = "Contacto de Facturación:";
            // 
            // tres_codigo
            // 
            // 
            // 
            // 
            this.tres_codigo.CustomButton.Image = null;
            this.tres_codigo.CustomButton.Location = new System.Drawing.Point(407, 1);
            this.tres_codigo.CustomButton.Name = "";
            this.tres_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_codigo.CustomButton.TabIndex = 1;
            this.tres_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_codigo.CustomButton.UseSelectable = true;
            this.tres_codigo.CustomButton.Visible = false;
            this.tres_codigo.Lines = new string[] {
        " "};
            this.tres_codigo.Location = new System.Drawing.Point(106, 178);
            this.tres_codigo.MaxLength = 32767;
            this.tres_codigo.Name = "tres_codigo";
            this.tres_codigo.PasswordChar = '\0';
            this.tres_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_codigo.SelectedText = "";
            this.tres_codigo.SelectionLength = 0;
            this.tres_codigo.SelectionStart = 0;
            this.tres_codigo.ShortcutsEnabled = true;
            this.tres_codigo.Size = new System.Drawing.Size(429, 23);
            this.tres_codigo.TabIndex = 293;
            this.tres_codigo.Text = " ";
            this.tres_codigo.UseSelectable = true;
            this.tres_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_direccion
            // 
            // 
            // 
            // 
            this.tres_direccion.CustomButton.Image = null;
            this.tres_direccion.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.tres_direccion.CustomButton.Name = "";
            this.tres_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_direccion.CustomButton.TabIndex = 1;
            this.tres_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_direccion.CustomButton.UseSelectable = true;
            this.tres_direccion.CustomButton.Visible = false;
            this.tres_direccion.Lines = new string[] {
        " "};
            this.tres_direccion.Location = new System.Drawing.Point(113, 143);
            this.tres_direccion.MaxLength = 32767;
            this.tres_direccion.Name = "tres_direccion";
            this.tres_direccion.PasswordChar = '\0';
            this.tres_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_direccion.SelectedText = "";
            this.tres_direccion.SelectionLength = 0;
            this.tres_direccion.SelectionStart = 0;
            this.tres_direccion.ShortcutsEnabled = true;
            this.tres_direccion.Size = new System.Drawing.Size(422, 23);
            this.tres_direccion.TabIndex = 292;
            this.tres_direccion.Text = " ";
            this.tres_direccion.UseSelectable = true;
            this.tres_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_rfc
            // 
            // 
            // 
            // 
            this.tres_rfc.CustomButton.Image = null;
            this.tres_rfc.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.tres_rfc.CustomButton.Name = "";
            this.tres_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_rfc.CustomButton.TabIndex = 1;
            this.tres_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_rfc.CustomButton.UseSelectable = true;
            this.tres_rfc.CustomButton.Visible = false;
            this.tres_rfc.Lines = new string[] {
        " "};
            this.tres_rfc.Location = new System.Drawing.Point(98, 109);
            this.tres_rfc.MaxLength = 32767;
            this.tres_rfc.Name = "tres_rfc";
            this.tres_rfc.PasswordChar = '\0';
            this.tres_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_rfc.SelectedText = "";
            this.tres_rfc.SelectionLength = 0;
            this.tres_rfc.SelectionStart = 0;
            this.tres_rfc.ShortcutsEnabled = true;
            this.tres_rfc.Size = new System.Drawing.Size(437, 23);
            this.tres_rfc.TabIndex = 291;
            this.tres_rfc.Text = " ";
            this.tres_rfc.UseSelectable = true;
            this.tres_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_Razon
            // 
            // 
            // 
            // 
            this.tres_Razon.CustomButton.Image = null;
            this.tres_Razon.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.tres_Razon.CustomButton.Name = "";
            this.tres_Razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_Razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_Razon.CustomButton.TabIndex = 1;
            this.tres_Razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_Razon.CustomButton.UseSelectable = true;
            this.tres_Razon.CustomButton.Visible = false;
            this.tres_Razon.Lines = new string[] {
        " "};
            this.tres_Razon.Location = new System.Drawing.Point(98, 75);
            this.tres_Razon.MaxLength = 32767;
            this.tres_Razon.Name = "tres_Razon";
            this.tres_Razon.PasswordChar = '\0';
            this.tres_Razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_Razon.SelectedText = "";
            this.tres_Razon.SelectionLength = 0;
            this.tres_Razon.SelectionStart = 0;
            this.tres_Razon.ShortcutsEnabled = true;
            this.tres_Razon.Size = new System.Drawing.Size(437, 23);
            this.tres_Razon.TabIndex = 290;
            this.tres_Razon.Text = " ";
            this.tres_Razon.UseSelectable = true;
            this.tres_Razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_Razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tres_hotel
            // 
            // 
            // 
            // 
            this.tres_hotel.CustomButton.Image = null;
            this.tres_hotel.CustomButton.Location = new System.Drawing.Point(458, 1);
            this.tres_hotel.CustomButton.Name = "";
            this.tres_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tres_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tres_hotel.CustomButton.TabIndex = 1;
            this.tres_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tres_hotel.CustomButton.UseSelectable = true;
            this.tres_hotel.CustomButton.Visible = false;
            this.tres_hotel.Lines = new string[] {
        " "};
            this.tres_hotel.Location = new System.Drawing.Point(55, 41);
            this.tres_hotel.MaxLength = 32767;
            this.tres_hotel.Name = "tres_hotel";
            this.tres_hotel.PasswordChar = '\0';
            this.tres_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tres_hotel.SelectedText = "";
            this.tres_hotel.SelectionLength = 0;
            this.tres_hotel.SelectionStart = 0;
            this.tres_hotel.ShortcutsEnabled = true;
            this.tres_hotel.Size = new System.Drawing.Size(480, 23);
            this.tres_hotel.TabIndex = 289;
            this.tres_hotel.Text = " ";
            this.tres_hotel.UseSelectable = true;
            this.tres_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tres_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel87
            // 
            this.metroLabel87.AutoSize = true;
            this.metroLabel87.Location = new System.Drawing.Point(6, 178);
            this.metroLabel87.Name = "metroLabel87";
            this.metroLabel87.Size = new System.Drawing.Size(94, 19);
            this.metroLabel87.TabIndex = 288;
            this.metroLabel87.Text = "Código Postal:";
            // 
            // metroLabel88
            // 
            this.metroLabel88.AutoSize = true;
            this.metroLabel88.Location = new System.Drawing.Point(6, 143);
            this.metroLabel88.Name = "metroLabel88";
            this.metroLabel88.Size = new System.Drawing.Size(101, 19);
            this.metroLabel88.TabIndex = 287;
            this.metroLabel88.Text = "Dirección Fiscal:";
            // 
            // metroLabel89
            // 
            this.metroLabel89.AutoSize = true;
            this.metroLabel89.Location = new System.Drawing.Point(6, 109);
            this.metroLabel89.Name = "metroLabel89";
            this.metroLabel89.Size = new System.Drawing.Size(84, 19);
            this.metroLabel89.TabIndex = 286;
            this.metroLabel89.Text = "RFC - Tax ID:";
            // 
            // metroLabel90
            // 
            this.metroLabel90.AutoSize = true;
            this.metroLabel90.Location = new System.Drawing.Point(6, 75);
            this.metroLabel90.Name = "metroLabel90";
            this.metroLabel90.Size = new System.Drawing.Size(86, 19);
            this.metroLabel90.TabIndex = 285;
            this.metroLabel90.Text = "Razón Social:";
            // 
            // metroLabel91
            // 
            this.metroLabel91.AutoSize = true;
            this.metroLabel91.Location = new System.Drawing.Point(6, 41);
            this.metroLabel91.Name = "metroLabel91";
            this.metroLabel91.Size = new System.Drawing.Size(43, 19);
            this.metroLabel91.TabIndex = 284;
            this.metroLabel91.Text = "Hotel:";
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox17.Controls.Add(this.Additional_7);
            this.groupBox17.Controls.Add(this.siete_telefono);
            this.groupBox17.Controls.Add(this.siete_email);
            this.groupBox17.Controls.Add(this.siete_contacto);
            this.groupBox17.Controls.Add(this.metroLabel74);
            this.groupBox17.Controls.Add(this.metroLabel75);
            this.groupBox17.Controls.Add(this.metroLabel76);
            this.groupBox17.Controls.Add(this.metroLabel77);
            this.groupBox17.Controls.Add(this.siete_codigo);
            this.groupBox17.Controls.Add(this.siete_direccion);
            this.groupBox17.Controls.Add(this.siete_rfc);
            this.groupBox17.Controls.Add(this.siete_razon);
            this.groupBox17.Controls.Add(this.siete_hotel);
            this.groupBox17.Controls.Add(this.metroLabel78);
            this.groupBox17.Controls.Add(this.metroLabel79);
            this.groupBox17.Controls.Add(this.metroLabel80);
            this.groupBox17.Controls.Add(this.metroLabel81);
            this.groupBox17.Controls.Add(this.metroLabel82);
            this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox17.Location = new System.Drawing.Point(5, 1361);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1176, 218);
            this.groupBox17.TabIndex = 303;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Septimo";
            // 
            // Additional_7
            // 
            // 
            // 
            // 
            this.Additional_7.CustomButton.Image = null;
            this.Additional_7.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_7.CustomButton.Name = "";
            this.Additional_7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_7.CustomButton.TabIndex = 1;
            this.Additional_7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_7.CustomButton.UseSelectable = true;
            this.Additional_7.CustomButton.Visible = false;
            this.Additional_7.Lines = new string[0];
            this.Additional_7.Location = new System.Drawing.Point(688, 143);
            this.Additional_7.MaxLength = 32767;
            this.Additional_7.Name = "Additional_7";
            this.Additional_7.PasswordChar = '\0';
            this.Additional_7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_7.SelectedText = "";
            this.Additional_7.SelectionLength = 0;
            this.Additional_7.SelectionStart = 0;
            this.Additional_7.ShortcutsEnabled = true;
            this.Additional_7.Size = new System.Drawing.Size(473, 23);
            this.Additional_7.TabIndex = 301;
            this.Additional_7.UseSelectable = true;
            this.Additional_7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_telefono
            // 
            // 
            // 
            // 
            this.siete_telefono.CustomButton.Image = null;
            this.siete_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.siete_telefono.CustomButton.Name = "";
            this.siete_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_telefono.CustomButton.TabIndex = 1;
            this.siete_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_telefono.CustomButton.UseSelectable = true;
            this.siete_telefono.CustomButton.Visible = false;
            this.siete_telefono.Lines = new string[] {
        " "};
            this.siete_telefono.Location = new System.Drawing.Point(774, 109);
            this.siete_telefono.MaxLength = 32767;
            this.siete_telefono.Name = "siete_telefono";
            this.siete_telefono.PasswordChar = '\0';
            this.siete_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_telefono.SelectedText = "";
            this.siete_telefono.SelectionLength = 0;
            this.siete_telefono.SelectionStart = 0;
            this.siete_telefono.ShortcutsEnabled = true;
            this.siete_telefono.Size = new System.Drawing.Size(387, 23);
            this.siete_telefono.TabIndex = 300;
            this.siete_telefono.Text = " ";
            this.siete_telefono.UseSelectable = true;
            this.siete_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_email
            // 
            // 
            // 
            // 
            this.siete_email.CustomButton.Image = null;
            this.siete_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.siete_email.CustomButton.Name = "";
            this.siete_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_email.CustomButton.TabIndex = 1;
            this.siete_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_email.CustomButton.UseSelectable = true;
            this.siete_email.CustomButton.Visible = false;
            this.siete_email.Lines = new string[] {
        " "};
            this.siete_email.Location = new System.Drawing.Point(763, 75);
            this.siete_email.MaxLength = 32767;
            this.siete_email.Name = "siete_email";
            this.siete_email.PasswordChar = '\0';
            this.siete_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_email.SelectedText = "";
            this.siete_email.SelectionLength = 0;
            this.siete_email.SelectionStart = 0;
            this.siete_email.ShortcutsEnabled = true;
            this.siete_email.Size = new System.Drawing.Size(398, 23);
            this.siete_email.TabIndex = 299;
            this.siete_email.Text = " ";
            this.siete_email.UseSelectable = true;
            this.siete_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_contacto
            // 
            // 
            // 
            // 
            this.siete_contacto.CustomButton.Image = null;
            this.siete_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.siete_contacto.CustomButton.Name = "";
            this.siete_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_contacto.CustomButton.TabIndex = 1;
            this.siete_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_contacto.CustomButton.UseSelectable = true;
            this.siete_contacto.CustomButton.Visible = false;
            this.siete_contacto.Lines = new string[] {
        " "};
            this.siete_contacto.Location = new System.Drawing.Point(702, 41);
            this.siete_contacto.MaxLength = 32767;
            this.siete_contacto.Name = "siete_contacto";
            this.siete_contacto.PasswordChar = '\0';
            this.siete_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_contacto.SelectedText = "";
            this.siete_contacto.SelectionLength = 0;
            this.siete_contacto.SelectionStart = 0;
            this.siete_contacto.ShortcutsEnabled = true;
            this.siete_contacto.Size = new System.Drawing.Size(459, 23);
            this.siete_contacto.TabIndex = 298;
            this.siete_contacto.Text = " ";
            this.siete_contacto.UseSelectable = true;
            this.siete_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel74
            // 
            this.metroLabel74.AutoSize = true;
            this.metroLabel74.Location = new System.Drawing.Point(542, 143);
            this.metroLabel74.Name = "metroLabel74";
            this.metroLabel74.Size = new System.Drawing.Size(140, 19);
            this.metroLabel74.TabIndex = 297;
            this.metroLabel74.Text = "Información Adicional:";
            // 
            // metroLabel75
            // 
            this.metroLabel75.AutoSize = true;
            this.metroLabel75.Location = new System.Drawing.Point(542, 109);
            this.metroLabel75.Name = "metroLabel75";
            this.metroLabel75.Size = new System.Drawing.Size(226, 19);
            this.metroLabel75.TabIndex = 296;
            this.metroLabel75.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel76
            // 
            this.metroLabel76.AutoSize = true;
            this.metroLabel76.Location = new System.Drawing.Point(542, 75);
            this.metroLabel76.Name = "metroLabel76";
            this.metroLabel76.Size = new System.Drawing.Size(215, 19);
            this.metroLabel76.TabIndex = 295;
            this.metroLabel76.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel77
            // 
            this.metroLabel77.AutoSize = true;
            this.metroLabel77.Location = new System.Drawing.Point(542, 41);
            this.metroLabel77.Name = "metroLabel77";
            this.metroLabel77.Size = new System.Drawing.Size(154, 19);
            this.metroLabel77.TabIndex = 294;
            this.metroLabel77.Text = "Contacto de Facturación:";
            // 
            // siete_codigo
            // 
            // 
            // 
            // 
            this.siete_codigo.CustomButton.Image = null;
            this.siete_codigo.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.siete_codigo.CustomButton.Name = "";
            this.siete_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_codigo.CustomButton.TabIndex = 1;
            this.siete_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_codigo.CustomButton.UseSelectable = true;
            this.siete_codigo.CustomButton.Visible = false;
            this.siete_codigo.Lines = new string[] {
        " "};
            this.siete_codigo.Location = new System.Drawing.Point(106, 178);
            this.siete_codigo.MaxLength = 32767;
            this.siete_codigo.Name = "siete_codigo";
            this.siete_codigo.PasswordChar = '\0';
            this.siete_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_codigo.SelectedText = "";
            this.siete_codigo.SelectionLength = 0;
            this.siete_codigo.SelectionStart = 0;
            this.siete_codigo.ShortcutsEnabled = true;
            this.siete_codigo.Size = new System.Drawing.Size(430, 23);
            this.siete_codigo.TabIndex = 293;
            this.siete_codigo.Text = " ";
            this.siete_codigo.UseSelectable = true;
            this.siete_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_direccion
            // 
            // 
            // 
            // 
            this.siete_direccion.CustomButton.Image = null;
            this.siete_direccion.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.siete_direccion.CustomButton.Name = "";
            this.siete_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_direccion.CustomButton.TabIndex = 1;
            this.siete_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_direccion.CustomButton.UseSelectable = true;
            this.siete_direccion.CustomButton.Visible = false;
            this.siete_direccion.Lines = new string[] {
        " "};
            this.siete_direccion.Location = new System.Drawing.Point(113, 143);
            this.siete_direccion.MaxLength = 32767;
            this.siete_direccion.Name = "siete_direccion";
            this.siete_direccion.PasswordChar = '\0';
            this.siete_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_direccion.SelectedText = "";
            this.siete_direccion.SelectionLength = 0;
            this.siete_direccion.SelectionStart = 0;
            this.siete_direccion.ShortcutsEnabled = true;
            this.siete_direccion.Size = new System.Drawing.Size(423, 23);
            this.siete_direccion.TabIndex = 292;
            this.siete_direccion.Text = " ";
            this.siete_direccion.UseSelectable = true;
            this.siete_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_rfc
            // 
            // 
            // 
            // 
            this.siete_rfc.CustomButton.Image = null;
            this.siete_rfc.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.siete_rfc.CustomButton.Name = "";
            this.siete_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_rfc.CustomButton.TabIndex = 1;
            this.siete_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_rfc.CustomButton.UseSelectable = true;
            this.siete_rfc.CustomButton.Visible = false;
            this.siete_rfc.Lines = new string[] {
        " "};
            this.siete_rfc.Location = new System.Drawing.Point(98, 109);
            this.siete_rfc.MaxLength = 32767;
            this.siete_rfc.Name = "siete_rfc";
            this.siete_rfc.PasswordChar = '\0';
            this.siete_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_rfc.SelectedText = "";
            this.siete_rfc.SelectionLength = 0;
            this.siete_rfc.SelectionStart = 0;
            this.siete_rfc.ShortcutsEnabled = true;
            this.siete_rfc.Size = new System.Drawing.Size(438, 23);
            this.siete_rfc.TabIndex = 291;
            this.siete_rfc.Text = " ";
            this.siete_rfc.UseSelectable = true;
            this.siete_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_razon
            // 
            // 
            // 
            // 
            this.siete_razon.CustomButton.Image = null;
            this.siete_razon.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.siete_razon.CustomButton.Name = "";
            this.siete_razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_razon.CustomButton.TabIndex = 1;
            this.siete_razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_razon.CustomButton.UseSelectable = true;
            this.siete_razon.CustomButton.Visible = false;
            this.siete_razon.Lines = new string[] {
        " "};
            this.siete_razon.Location = new System.Drawing.Point(98, 75);
            this.siete_razon.MaxLength = 32767;
            this.siete_razon.Name = "siete_razon";
            this.siete_razon.PasswordChar = '\0';
            this.siete_razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_razon.SelectedText = "";
            this.siete_razon.SelectionLength = 0;
            this.siete_razon.SelectionStart = 0;
            this.siete_razon.ShortcutsEnabled = true;
            this.siete_razon.Size = new System.Drawing.Size(438, 23);
            this.siete_razon.TabIndex = 290;
            this.siete_razon.Text = " ";
            this.siete_razon.UseSelectable = true;
            this.siete_razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siete_hotel
            // 
            // 
            // 
            // 
            this.siete_hotel.CustomButton.Image = null;
            this.siete_hotel.CustomButton.Location = new System.Drawing.Point(459, 1);
            this.siete_hotel.CustomButton.Name = "";
            this.siete_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siete_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siete_hotel.CustomButton.TabIndex = 1;
            this.siete_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siete_hotel.CustomButton.UseSelectable = true;
            this.siete_hotel.CustomButton.Visible = false;
            this.siete_hotel.Lines = new string[] {
        " "};
            this.siete_hotel.Location = new System.Drawing.Point(55, 41);
            this.siete_hotel.MaxLength = 32767;
            this.siete_hotel.Name = "siete_hotel";
            this.siete_hotel.PasswordChar = '\0';
            this.siete_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siete_hotel.SelectedText = "";
            this.siete_hotel.SelectionLength = 0;
            this.siete_hotel.SelectionStart = 0;
            this.siete_hotel.ShortcutsEnabled = true;
            this.siete_hotel.Size = new System.Drawing.Size(481, 23);
            this.siete_hotel.TabIndex = 289;
            this.siete_hotel.Text = " ";
            this.siete_hotel.UseSelectable = true;
            this.siete_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siete_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel78
            // 
            this.metroLabel78.AutoSize = true;
            this.metroLabel78.Location = new System.Drawing.Point(6, 178);
            this.metroLabel78.Name = "metroLabel78";
            this.metroLabel78.Size = new System.Drawing.Size(94, 19);
            this.metroLabel78.TabIndex = 288;
            this.metroLabel78.Text = "Código Postal:";
            // 
            // metroLabel79
            // 
            this.metroLabel79.AutoSize = true;
            this.metroLabel79.Location = new System.Drawing.Point(6, 143);
            this.metroLabel79.Name = "metroLabel79";
            this.metroLabel79.Size = new System.Drawing.Size(101, 19);
            this.metroLabel79.TabIndex = 287;
            this.metroLabel79.Text = "Dirección Fiscal:";
            // 
            // metroLabel80
            // 
            this.metroLabel80.AutoSize = true;
            this.metroLabel80.Location = new System.Drawing.Point(6, 109);
            this.metroLabel80.Name = "metroLabel80";
            this.metroLabel80.Size = new System.Drawing.Size(84, 19);
            this.metroLabel80.TabIndex = 286;
            this.metroLabel80.Text = "RFC - Tax ID:";
            // 
            // metroLabel81
            // 
            this.metroLabel81.AutoSize = true;
            this.metroLabel81.Location = new System.Drawing.Point(6, 75);
            this.metroLabel81.Name = "metroLabel81";
            this.metroLabel81.Size = new System.Drawing.Size(86, 19);
            this.metroLabel81.TabIndex = 285;
            this.metroLabel81.Text = "Razón Social:";
            // 
            // metroLabel82
            // 
            this.metroLabel82.AutoSize = true;
            this.metroLabel82.Location = new System.Drawing.Point(6, 41);
            this.metroLabel82.Name = "metroLabel82";
            this.metroLabel82.Size = new System.Drawing.Size(43, 19);
            this.metroLabel82.TabIndex = 284;
            this.metroLabel82.Text = "Hotel:";
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox16.Controls.Add(this.Additional_2);
            this.groupBox16.Controls.Add(this.dos_telefono);
            this.groupBox16.Controls.Add(this.dos_email);
            this.groupBox16.Controls.Add(this.dos_contacto);
            this.groupBox16.Controls.Add(this.metroLabel65);
            this.groupBox16.Controls.Add(this.metroLabel66);
            this.groupBox16.Controls.Add(this.metroLabel67);
            this.groupBox16.Controls.Add(this.metroLabel68);
            this.groupBox16.Controls.Add(this.dos_codigo);
            this.groupBox16.Controls.Add(this.dos_direccion);
            this.groupBox16.Controls.Add(this.dos_rfc);
            this.groupBox16.Controls.Add(this.dos_razon);
            this.groupBox16.Controls.Add(this.dos_hotel);
            this.groupBox16.Controls.Add(this.metroLabel69);
            this.groupBox16.Controls.Add(this.metroLabel70);
            this.groupBox16.Controls.Add(this.metroLabel71);
            this.groupBox16.Controls.Add(this.metroLabel72);
            this.groupBox16.Controls.Add(this.metroLabel73);
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox16.Location = new System.Drawing.Point(5, 241);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(1176, 218);
            this.groupBox16.TabIndex = 302;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Segundo";
            // 
            // Additional_2
            // 
            // 
            // 
            // 
            this.Additional_2.CustomButton.Image = null;
            this.Additional_2.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_2.CustomButton.Name = "";
            this.Additional_2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_2.CustomButton.TabIndex = 1;
            this.Additional_2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_2.CustomButton.UseSelectable = true;
            this.Additional_2.CustomButton.Visible = false;
            this.Additional_2.Lines = new string[0];
            this.Additional_2.Location = new System.Drawing.Point(688, 143);
            this.Additional_2.MaxLength = 32767;
            this.Additional_2.Name = "Additional_2";
            this.Additional_2.PasswordChar = '\0';
            this.Additional_2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_2.SelectedText = "";
            this.Additional_2.SelectionLength = 0;
            this.Additional_2.SelectionStart = 0;
            this.Additional_2.ShortcutsEnabled = true;
            this.Additional_2.Size = new System.Drawing.Size(473, 23);
            this.Additional_2.TabIndex = 301;
            this.Additional_2.UseSelectable = true;
            this.Additional_2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_telefono
            // 
            // 
            // 
            // 
            this.dos_telefono.CustomButton.Image = null;
            this.dos_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.dos_telefono.CustomButton.Name = "";
            this.dos_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_telefono.CustomButton.TabIndex = 1;
            this.dos_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_telefono.CustomButton.UseSelectable = true;
            this.dos_telefono.CustomButton.Visible = false;
            this.dos_telefono.Lines = new string[] {
        " "};
            this.dos_telefono.Location = new System.Drawing.Point(774, 109);
            this.dos_telefono.MaxLength = 32767;
            this.dos_telefono.Name = "dos_telefono";
            this.dos_telefono.PasswordChar = '\0';
            this.dos_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_telefono.SelectedText = "";
            this.dos_telefono.SelectionLength = 0;
            this.dos_telefono.SelectionStart = 0;
            this.dos_telefono.ShortcutsEnabled = true;
            this.dos_telefono.Size = new System.Drawing.Size(387, 23);
            this.dos_telefono.TabIndex = 300;
            this.dos_telefono.Text = " ";
            this.dos_telefono.UseSelectable = true;
            this.dos_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_email
            // 
            // 
            // 
            // 
            this.dos_email.CustomButton.Image = null;
            this.dos_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.dos_email.CustomButton.Name = "";
            this.dos_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_email.CustomButton.TabIndex = 1;
            this.dos_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_email.CustomButton.UseSelectable = true;
            this.dos_email.CustomButton.Visible = false;
            this.dos_email.Lines = new string[] {
        " "};
            this.dos_email.Location = new System.Drawing.Point(763, 75);
            this.dos_email.MaxLength = 32767;
            this.dos_email.Name = "dos_email";
            this.dos_email.PasswordChar = '\0';
            this.dos_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_email.SelectedText = "";
            this.dos_email.SelectionLength = 0;
            this.dos_email.SelectionStart = 0;
            this.dos_email.ShortcutsEnabled = true;
            this.dos_email.Size = new System.Drawing.Size(398, 23);
            this.dos_email.TabIndex = 299;
            this.dos_email.Text = " ";
            this.dos_email.UseSelectable = true;
            this.dos_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_contacto
            // 
            // 
            // 
            // 
            this.dos_contacto.CustomButton.Image = null;
            this.dos_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.dos_contacto.CustomButton.Name = "";
            this.dos_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_contacto.CustomButton.TabIndex = 1;
            this.dos_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_contacto.CustomButton.UseSelectable = true;
            this.dos_contacto.CustomButton.Visible = false;
            this.dos_contacto.Lines = new string[] {
        " "};
            this.dos_contacto.Location = new System.Drawing.Point(702, 41);
            this.dos_contacto.MaxLength = 32767;
            this.dos_contacto.Name = "dos_contacto";
            this.dos_contacto.PasswordChar = '\0';
            this.dos_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_contacto.SelectedText = "";
            this.dos_contacto.SelectionLength = 0;
            this.dos_contacto.SelectionStart = 0;
            this.dos_contacto.ShortcutsEnabled = true;
            this.dos_contacto.Size = new System.Drawing.Size(459, 23);
            this.dos_contacto.TabIndex = 298;
            this.dos_contacto.Text = " ";
            this.dos_contacto.UseSelectable = true;
            this.dos_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel65
            // 
            this.metroLabel65.AutoSize = true;
            this.metroLabel65.Location = new System.Drawing.Point(542, 143);
            this.metroLabel65.Name = "metroLabel65";
            this.metroLabel65.Size = new System.Drawing.Size(140, 19);
            this.metroLabel65.TabIndex = 297;
            this.metroLabel65.Text = "Información Adicional:";
            // 
            // metroLabel66
            // 
            this.metroLabel66.AutoSize = true;
            this.metroLabel66.Location = new System.Drawing.Point(542, 109);
            this.metroLabel66.Name = "metroLabel66";
            this.metroLabel66.Size = new System.Drawing.Size(226, 19);
            this.metroLabel66.TabIndex = 296;
            this.metroLabel66.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel67
            // 
            this.metroLabel67.AutoSize = true;
            this.metroLabel67.Location = new System.Drawing.Point(542, 75);
            this.metroLabel67.Name = "metroLabel67";
            this.metroLabel67.Size = new System.Drawing.Size(215, 19);
            this.metroLabel67.TabIndex = 295;
            this.metroLabel67.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel68
            // 
            this.metroLabel68.AutoSize = true;
            this.metroLabel68.Location = new System.Drawing.Point(542, 41);
            this.metroLabel68.Name = "metroLabel68";
            this.metroLabel68.Size = new System.Drawing.Size(154, 19);
            this.metroLabel68.TabIndex = 294;
            this.metroLabel68.Text = "Contacto de Facturación:";
            // 
            // dos_codigo
            // 
            // 
            // 
            // 
            this.dos_codigo.CustomButton.Image = null;
            this.dos_codigo.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.dos_codigo.CustomButton.Name = "";
            this.dos_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_codigo.CustomButton.TabIndex = 1;
            this.dos_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_codigo.CustomButton.UseSelectable = true;
            this.dos_codigo.CustomButton.Visible = false;
            this.dos_codigo.Lines = new string[] {
        " "};
            this.dos_codigo.Location = new System.Drawing.Point(106, 178);
            this.dos_codigo.MaxLength = 32767;
            this.dos_codigo.Name = "dos_codigo";
            this.dos_codigo.PasswordChar = '\0';
            this.dos_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_codigo.SelectedText = "";
            this.dos_codigo.SelectionLength = 0;
            this.dos_codigo.SelectionStart = 0;
            this.dos_codigo.ShortcutsEnabled = true;
            this.dos_codigo.Size = new System.Drawing.Size(430, 23);
            this.dos_codigo.TabIndex = 293;
            this.dos_codigo.Text = " ";
            this.dos_codigo.UseSelectable = true;
            this.dos_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_direccion
            // 
            // 
            // 
            // 
            this.dos_direccion.CustomButton.Image = null;
            this.dos_direccion.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.dos_direccion.CustomButton.Name = "";
            this.dos_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_direccion.CustomButton.TabIndex = 1;
            this.dos_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_direccion.CustomButton.UseSelectable = true;
            this.dos_direccion.CustomButton.Visible = false;
            this.dos_direccion.Lines = new string[] {
        " "};
            this.dos_direccion.Location = new System.Drawing.Point(113, 143);
            this.dos_direccion.MaxLength = 32767;
            this.dos_direccion.Name = "dos_direccion";
            this.dos_direccion.PasswordChar = '\0';
            this.dos_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_direccion.SelectedText = "";
            this.dos_direccion.SelectionLength = 0;
            this.dos_direccion.SelectionStart = 0;
            this.dos_direccion.ShortcutsEnabled = true;
            this.dos_direccion.Size = new System.Drawing.Size(423, 23);
            this.dos_direccion.TabIndex = 292;
            this.dos_direccion.Text = " ";
            this.dos_direccion.UseSelectable = true;
            this.dos_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_rfc
            // 
            // 
            // 
            // 
            this.dos_rfc.CustomButton.Image = null;
            this.dos_rfc.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.dos_rfc.CustomButton.Name = "";
            this.dos_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_rfc.CustomButton.TabIndex = 1;
            this.dos_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_rfc.CustomButton.UseSelectable = true;
            this.dos_rfc.CustomButton.Visible = false;
            this.dos_rfc.Lines = new string[] {
        " "};
            this.dos_rfc.Location = new System.Drawing.Point(98, 109);
            this.dos_rfc.MaxLength = 32767;
            this.dos_rfc.Name = "dos_rfc";
            this.dos_rfc.PasswordChar = '\0';
            this.dos_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_rfc.SelectedText = "";
            this.dos_rfc.SelectionLength = 0;
            this.dos_rfc.SelectionStart = 0;
            this.dos_rfc.ShortcutsEnabled = true;
            this.dos_rfc.Size = new System.Drawing.Size(438, 23);
            this.dos_rfc.TabIndex = 291;
            this.dos_rfc.Text = " ";
            this.dos_rfc.UseSelectable = true;
            this.dos_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_razon
            // 
            // 
            // 
            // 
            this.dos_razon.CustomButton.Image = null;
            this.dos_razon.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.dos_razon.CustomButton.Name = "";
            this.dos_razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_razon.CustomButton.TabIndex = 1;
            this.dos_razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_razon.CustomButton.UseSelectable = true;
            this.dos_razon.CustomButton.Visible = false;
            this.dos_razon.Lines = new string[] {
        " "};
            this.dos_razon.Location = new System.Drawing.Point(98, 75);
            this.dos_razon.MaxLength = 32767;
            this.dos_razon.Name = "dos_razon";
            this.dos_razon.PasswordChar = '\0';
            this.dos_razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_razon.SelectedText = "";
            this.dos_razon.SelectionLength = 0;
            this.dos_razon.SelectionStart = 0;
            this.dos_razon.ShortcutsEnabled = true;
            this.dos_razon.Size = new System.Drawing.Size(438, 23);
            this.dos_razon.TabIndex = 290;
            this.dos_razon.Text = " ";
            this.dos_razon.UseSelectable = true;
            this.dos_razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dos_hotel
            // 
            // 
            // 
            // 
            this.dos_hotel.CustomButton.Image = null;
            this.dos_hotel.CustomButton.Location = new System.Drawing.Point(459, 1);
            this.dos_hotel.CustomButton.Name = "";
            this.dos_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dos_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dos_hotel.CustomButton.TabIndex = 1;
            this.dos_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dos_hotel.CustomButton.UseSelectable = true;
            this.dos_hotel.CustomButton.Visible = false;
            this.dos_hotel.Lines = new string[] {
        " "};
            this.dos_hotel.Location = new System.Drawing.Point(55, 41);
            this.dos_hotel.MaxLength = 32767;
            this.dos_hotel.Name = "dos_hotel";
            this.dos_hotel.PasswordChar = '\0';
            this.dos_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dos_hotel.SelectedText = "";
            this.dos_hotel.SelectionLength = 0;
            this.dos_hotel.SelectionStart = 0;
            this.dos_hotel.ShortcutsEnabled = true;
            this.dos_hotel.Size = new System.Drawing.Size(481, 23);
            this.dos_hotel.TabIndex = 289;
            this.dos_hotel.Text = " ";
            this.dos_hotel.UseSelectable = true;
            this.dos_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dos_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel69
            // 
            this.metroLabel69.AutoSize = true;
            this.metroLabel69.Location = new System.Drawing.Point(6, 178);
            this.metroLabel69.Name = "metroLabel69";
            this.metroLabel69.Size = new System.Drawing.Size(94, 19);
            this.metroLabel69.TabIndex = 288;
            this.metroLabel69.Text = "Código Postal:";
            // 
            // metroLabel70
            // 
            this.metroLabel70.AutoSize = true;
            this.metroLabel70.Location = new System.Drawing.Point(6, 143);
            this.metroLabel70.Name = "metroLabel70";
            this.metroLabel70.Size = new System.Drawing.Size(101, 19);
            this.metroLabel70.TabIndex = 287;
            this.metroLabel70.Text = "Dirección Fiscal:";
            // 
            // metroLabel71
            // 
            this.metroLabel71.AutoSize = true;
            this.metroLabel71.Location = new System.Drawing.Point(6, 109);
            this.metroLabel71.Name = "metroLabel71";
            this.metroLabel71.Size = new System.Drawing.Size(84, 19);
            this.metroLabel71.TabIndex = 286;
            this.metroLabel71.Text = "RFC - Tax ID:";
            // 
            // metroLabel72
            // 
            this.metroLabel72.AutoSize = true;
            this.metroLabel72.Location = new System.Drawing.Point(6, 75);
            this.metroLabel72.Name = "metroLabel72";
            this.metroLabel72.Size = new System.Drawing.Size(86, 19);
            this.metroLabel72.TabIndex = 285;
            this.metroLabel72.Text = "Razón Social:";
            // 
            // metroLabel73
            // 
            this.metroLabel73.AutoSize = true;
            this.metroLabel73.Location = new System.Drawing.Point(6, 41);
            this.metroLabel73.Name = "metroLabel73";
            this.metroLabel73.Size = new System.Drawing.Size(43, 19);
            this.metroLabel73.TabIndex = 284;
            this.metroLabel73.Text = "Hotel:";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox11.Controls.Add(this.Additional_1);
            this.groupBox11.Controls.Add(this.uno_telefono);
            this.groupBox11.Controls.Add(this.uno_email);
            this.groupBox11.Controls.Add(this.uno_contacto);
            this.groupBox11.Controls.Add(this.metroLabel64);
            this.groupBox11.Controls.Add(this.metroLabel63);
            this.groupBox11.Controls.Add(this.metroLabel62);
            this.groupBox11.Controls.Add(this.metroLabel61);
            this.groupBox11.Controls.Add(this.uno_codigo);
            this.groupBox11.Controls.Add(this.uno_direccion);
            this.groupBox11.Controls.Add(this.uno_rfc);
            this.groupBox11.Controls.Add(this.uno_razon);
            this.groupBox11.Controls.Add(this.uno_hotel);
            this.groupBox11.Controls.Add(this.metroLabel60);
            this.groupBox11.Controls.Add(this.metroLabel59);
            this.groupBox11.Controls.Add(this.metroLabel58);
            this.groupBox11.Controls.Add(this.metroLabel57);
            this.groupBox11.Controls.Add(this.metroLabel56);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox11.Location = new System.Drawing.Point(5, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1176, 218);
            this.groupBox11.TabIndex = 31;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Primero";
            // 
            // Additional_1
            // 
            // 
            // 
            // 
            this.Additional_1.CustomButton.Image = null;
            this.Additional_1.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.Additional_1.CustomButton.Name = "";
            this.Additional_1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Additional_1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Additional_1.CustomButton.TabIndex = 1;
            this.Additional_1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Additional_1.CustomButton.UseSelectable = true;
            this.Additional_1.CustomButton.Visible = false;
            this.Additional_1.Lines = new string[0];
            this.Additional_1.Location = new System.Drawing.Point(688, 143);
            this.Additional_1.MaxLength = 32767;
            this.Additional_1.Name = "Additional_1";
            this.Additional_1.PasswordChar = '\0';
            this.Additional_1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Additional_1.SelectedText = "";
            this.Additional_1.SelectionLength = 0;
            this.Additional_1.SelectionStart = 0;
            this.Additional_1.ShortcutsEnabled = true;
            this.Additional_1.Size = new System.Drawing.Size(473, 23);
            this.Additional_1.TabIndex = 301;
            this.Additional_1.UseSelectable = true;
            this.Additional_1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Additional_1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_telefono
            // 
            // 
            // 
            // 
            this.uno_telefono.CustomButton.Image = null;
            this.uno_telefono.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.uno_telefono.CustomButton.Name = "";
            this.uno_telefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_telefono.CustomButton.TabIndex = 1;
            this.uno_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_telefono.CustomButton.UseSelectable = true;
            this.uno_telefono.CustomButton.Visible = false;
            this.uno_telefono.Lines = new string[] {
        " "};
            this.uno_telefono.Location = new System.Drawing.Point(774, 109);
            this.uno_telefono.MaxLength = 32767;
            this.uno_telefono.Name = "uno_telefono";
            this.uno_telefono.PasswordChar = '\0';
            this.uno_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_telefono.SelectedText = "";
            this.uno_telefono.SelectionLength = 0;
            this.uno_telefono.SelectionStart = 0;
            this.uno_telefono.ShortcutsEnabled = true;
            this.uno_telefono.Size = new System.Drawing.Size(387, 23);
            this.uno_telefono.TabIndex = 300;
            this.uno_telefono.Text = " ";
            this.uno_telefono.UseSelectable = true;
            this.uno_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_telefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_email
            // 
            // 
            // 
            // 
            this.uno_email.CustomButton.Image = null;
            this.uno_email.CustomButton.Location = new System.Drawing.Point(376, 1);
            this.uno_email.CustomButton.Name = "";
            this.uno_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_email.CustomButton.TabIndex = 1;
            this.uno_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_email.CustomButton.UseSelectable = true;
            this.uno_email.CustomButton.Visible = false;
            this.uno_email.Lines = new string[] {
        " "};
            this.uno_email.Location = new System.Drawing.Point(763, 75);
            this.uno_email.MaxLength = 32767;
            this.uno_email.Name = "uno_email";
            this.uno_email.PasswordChar = '\0';
            this.uno_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_email.SelectedText = "";
            this.uno_email.SelectionLength = 0;
            this.uno_email.SelectionStart = 0;
            this.uno_email.ShortcutsEnabled = true;
            this.uno_email.Size = new System.Drawing.Size(398, 23);
            this.uno_email.TabIndex = 299;
            this.uno_email.Text = " ";
            this.uno_email.UseSelectable = true;
            this.uno_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_contacto
            // 
            // 
            // 
            // 
            this.uno_contacto.CustomButton.Image = null;
            this.uno_contacto.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.uno_contacto.CustomButton.Name = "";
            this.uno_contacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_contacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_contacto.CustomButton.TabIndex = 1;
            this.uno_contacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_contacto.CustomButton.UseSelectable = true;
            this.uno_contacto.CustomButton.Visible = false;
            this.uno_contacto.Lines = new string[] {
        " "};
            this.uno_contacto.Location = new System.Drawing.Point(702, 41);
            this.uno_contacto.MaxLength = 32767;
            this.uno_contacto.Name = "uno_contacto";
            this.uno_contacto.PasswordChar = '\0';
            this.uno_contacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_contacto.SelectedText = "";
            this.uno_contacto.SelectionLength = 0;
            this.uno_contacto.SelectionStart = 0;
            this.uno_contacto.ShortcutsEnabled = true;
            this.uno_contacto.Size = new System.Drawing.Size(459, 23);
            this.uno_contacto.TabIndex = 298;
            this.uno_contacto.Text = " ";
            this.uno_contacto.UseSelectable = true;
            this.uno_contacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_contacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel64
            // 
            this.metroLabel64.AutoSize = true;
            this.metroLabel64.Location = new System.Drawing.Point(542, 143);
            this.metroLabel64.Name = "metroLabel64";
            this.metroLabel64.Size = new System.Drawing.Size(140, 19);
            this.metroLabel64.TabIndex = 297;
            this.metroLabel64.Text = "Información Adicional:";
            // 
            // metroLabel63
            // 
            this.metroLabel63.AutoSize = true;
            this.metroLabel63.Location = new System.Drawing.Point(542, 109);
            this.metroLabel63.Name = "metroLabel63";
            this.metroLabel63.Size = new System.Drawing.Size(226, 19);
            this.metroLabel63.TabIndex = 296;
            this.metroLabel63.Text = "Teléfono de Contacto de Facturación:";
            // 
            // metroLabel62
            // 
            this.metroLabel62.AutoSize = true;
            this.metroLabel62.Location = new System.Drawing.Point(542, 75);
            this.metroLabel62.Name = "metroLabel62";
            this.metroLabel62.Size = new System.Drawing.Size(215, 19);
            this.metroLabel62.TabIndex = 295;
            this.metroLabel62.Text = "E-mail de Contacto de Facturación:";
            // 
            // metroLabel61
            // 
            this.metroLabel61.AutoSize = true;
            this.metroLabel61.Location = new System.Drawing.Point(542, 41);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(154, 19);
            this.metroLabel61.TabIndex = 294;
            this.metroLabel61.Text = "Contacto de Facturación:";
            // 
            // uno_codigo
            // 
            // 
            // 
            // 
            this.uno_codigo.CustomButton.Image = null;
            this.uno_codigo.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.uno_codigo.CustomButton.Name = "";
            this.uno_codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_codigo.CustomButton.TabIndex = 1;
            this.uno_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_codigo.CustomButton.UseSelectable = true;
            this.uno_codigo.CustomButton.Visible = false;
            this.uno_codigo.Lines = new string[] {
        " "};
            this.uno_codigo.Location = new System.Drawing.Point(106, 178);
            this.uno_codigo.MaxLength = 32767;
            this.uno_codigo.Name = "uno_codigo";
            this.uno_codigo.PasswordChar = '\0';
            this.uno_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_codigo.SelectedText = "";
            this.uno_codigo.SelectionLength = 0;
            this.uno_codigo.SelectionStart = 0;
            this.uno_codigo.ShortcutsEnabled = true;
            this.uno_codigo.Size = new System.Drawing.Size(430, 23);
            this.uno_codigo.TabIndex = 293;
            this.uno_codigo.Text = " ";
            this.uno_codigo.UseSelectable = true;
            this.uno_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_direccion
            // 
            // 
            // 
            // 
            this.uno_direccion.CustomButton.Image = null;
            this.uno_direccion.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.uno_direccion.CustomButton.Name = "";
            this.uno_direccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_direccion.CustomButton.TabIndex = 1;
            this.uno_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_direccion.CustomButton.UseSelectable = true;
            this.uno_direccion.CustomButton.Visible = false;
            this.uno_direccion.Lines = new string[] {
        " "};
            this.uno_direccion.Location = new System.Drawing.Point(113, 143);
            this.uno_direccion.MaxLength = 32767;
            this.uno_direccion.Name = "uno_direccion";
            this.uno_direccion.PasswordChar = '\0';
            this.uno_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_direccion.SelectedText = "";
            this.uno_direccion.SelectionLength = 0;
            this.uno_direccion.SelectionStart = 0;
            this.uno_direccion.ShortcutsEnabled = true;
            this.uno_direccion.Size = new System.Drawing.Size(423, 23);
            this.uno_direccion.TabIndex = 292;
            this.uno_direccion.Text = " ";
            this.uno_direccion.UseSelectable = true;
            this.uno_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_rfc
            // 
            // 
            // 
            // 
            this.uno_rfc.CustomButton.Image = null;
            this.uno_rfc.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.uno_rfc.CustomButton.Name = "";
            this.uno_rfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_rfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_rfc.CustomButton.TabIndex = 1;
            this.uno_rfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_rfc.CustomButton.UseSelectable = true;
            this.uno_rfc.CustomButton.Visible = false;
            this.uno_rfc.Lines = new string[] {
        " "};
            this.uno_rfc.Location = new System.Drawing.Point(98, 109);
            this.uno_rfc.MaxLength = 32767;
            this.uno_rfc.Name = "uno_rfc";
            this.uno_rfc.PasswordChar = '\0';
            this.uno_rfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_rfc.SelectedText = "";
            this.uno_rfc.SelectionLength = 0;
            this.uno_rfc.SelectionStart = 0;
            this.uno_rfc.ShortcutsEnabled = true;
            this.uno_rfc.Size = new System.Drawing.Size(438, 23);
            this.uno_rfc.TabIndex = 291;
            this.uno_rfc.Text = " ";
            this.uno_rfc.UseSelectable = true;
            this.uno_rfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_rfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_razon
            // 
            // 
            // 
            // 
            this.uno_razon.CustomButton.Image = null;
            this.uno_razon.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.uno_razon.CustomButton.Name = "";
            this.uno_razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_razon.CustomButton.TabIndex = 1;
            this.uno_razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_razon.CustomButton.UseSelectable = true;
            this.uno_razon.CustomButton.Visible = false;
            this.uno_razon.Lines = new string[] {
        " "};
            this.uno_razon.Location = new System.Drawing.Point(98, 75);
            this.uno_razon.MaxLength = 32767;
            this.uno_razon.Name = "uno_razon";
            this.uno_razon.PasswordChar = '\0';
            this.uno_razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_razon.SelectedText = "";
            this.uno_razon.SelectionLength = 0;
            this.uno_razon.SelectionStart = 0;
            this.uno_razon.ShortcutsEnabled = true;
            this.uno_razon.Size = new System.Drawing.Size(438, 23);
            this.uno_razon.TabIndex = 290;
            this.uno_razon.Text = " ";
            this.uno_razon.UseSelectable = true;
            this.uno_razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uno_hotel
            // 
            // 
            // 
            // 
            this.uno_hotel.CustomButton.Image = null;
            this.uno_hotel.CustomButton.Location = new System.Drawing.Point(459, 1);
            this.uno_hotel.CustomButton.Name = "";
            this.uno_hotel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uno_hotel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uno_hotel.CustomButton.TabIndex = 1;
            this.uno_hotel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uno_hotel.CustomButton.UseSelectable = true;
            this.uno_hotel.CustomButton.Visible = false;
            this.uno_hotel.Lines = new string[] {
        " "};
            this.uno_hotel.Location = new System.Drawing.Point(55, 41);
            this.uno_hotel.MaxLength = 32767;
            this.uno_hotel.Name = "uno_hotel";
            this.uno_hotel.PasswordChar = '\0';
            this.uno_hotel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uno_hotel.SelectedText = "";
            this.uno_hotel.SelectionLength = 0;
            this.uno_hotel.SelectionStart = 0;
            this.uno_hotel.ShortcutsEnabled = true;
            this.uno_hotel.Size = new System.Drawing.Size(481, 23);
            this.uno_hotel.TabIndex = 289;
            this.uno_hotel.Text = " ";
            this.uno_hotel.UseSelectable = true;
            this.uno_hotel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uno_hotel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.Location = new System.Drawing.Point(6, 178);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(94, 19);
            this.metroLabel60.TabIndex = 288;
            this.metroLabel60.Text = "Código Postal:";
            // 
            // metroLabel59
            // 
            this.metroLabel59.AutoSize = true;
            this.metroLabel59.Location = new System.Drawing.Point(6, 143);
            this.metroLabel59.Name = "metroLabel59";
            this.metroLabel59.Size = new System.Drawing.Size(101, 19);
            this.metroLabel59.TabIndex = 287;
            this.metroLabel59.Text = "Dirección Fiscal:";
            // 
            // metroLabel58
            // 
            this.metroLabel58.AutoSize = true;
            this.metroLabel58.Location = new System.Drawing.Point(6, 109);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(84, 19);
            this.metroLabel58.TabIndex = 286;
            this.metroLabel58.Text = "RFC - Tax ID:";
            // 
            // metroLabel57
            // 
            this.metroLabel57.AutoSize = true;
            this.metroLabel57.Location = new System.Drawing.Point(6, 75);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(86, 19);
            this.metroLabel57.TabIndex = 285;
            this.metroLabel57.Text = "Razón Social:";
            // 
            // metroLabel56
            // 
            this.metroLabel56.AutoSize = true;
            this.metroLabel56.Location = new System.Drawing.Point(6, 41);
            this.metroLabel56.Name = "metroLabel56";
            this.metroLabel56.Size = new System.Drawing.Size(43, 19);
            this.metroLabel56.TabIndex = 284;
            this.metroLabel56.Text = "Hotel:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1036, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // preliminar_button
            // 
            this.preliminar_button.ActiveControl = null;
            this.preliminar_button.Location = new System.Drawing.Point(890, 636);
            this.preliminar_button.Name = "preliminar_button";
            this.preliminar_button.Size = new System.Drawing.Size(167, 41);
            this.preliminar_button.TabIndex = 3;
            this.preliminar_button.Text = "Preliminar";
            this.preliminar_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.preliminar_button.UseSelectable = true;
            this.preliminar_button.Click += new System.EventHandler(this.preliminar_button_Click);
            // 
            // validar_oi
            // 
            this.ClientSize = new System.Drawing.Size(1247, 689);
            this.Controls.Add(this.preliminar_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.generar_OI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "validar_oi";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Validador de Ordenes de Inserción";
            this.Load += new System.EventHandler(this.generador_OI_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTotalIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocDic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocNov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocSep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocAgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocJul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocJun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocAbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocMar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocFeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDocEne)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeMF_box)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Generar_OI_Click(object sender, EventArgs e)
        {
            try
            {
                //caratula
                PdfPTable caratula = new PdfPTable(1);
                caratula.WidthPercentage = 100;
                PdfPCell caratula_oi = new PdfPCell(new Phrase(string.Format("FOLIO DE REFERENCIA: " + OI_text.Text + "     " + "ORDEN DE INSERCIÓN" + "     " + "FECHA: " + DateTime.Now), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
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

                PdfPCell bottom_cliente_2 = new PdfPCell(new Phrase(string.Format("Nombre: " + cxpNombre.Text + "\n" + "Teléfono: " + cxpTelefono.Text + "\n" + "Correo: " + cxpCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_cliente_2.Colspan = 2;
                table_2.AddCell(bottom_cliente_2);

                PdfPCell bottom_media_2 = new PdfPCell(new Phrase(string.Format("Nombre: " + cxcNombre.Text + "\n" + "Teléfono: " + cxcTelefono.Text + "\n" + "Correo: " + cxcCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_2.Colspan = 2;
                table_2.AddCell(bottom_media_2);


                //clientes_2
                PdfPTable table_3 = new PdfPTable(4);
                table_3.WidthPercentage = 100;
                PdfPCell cliente_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial: " + NComercial.Text + "\n" + "Teléfono: " + TComercial.Text + " " + "Correo: " + CComercial.Text + "\n" + "\n" + "Contacto Pauta Medios: " + PNombre.Text + "\n" + "Teléfono: " + PTelefono.Text + " " + "Correo: " + PCorreo.Text + "\n" + "\n" + "Contacto Tour HotelDO: " + HNombre.Text + "\n" + "Teléfono: " + HTelefono.Text + " " + "Correo: " + HCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cliente_3.Colspan = 2;

                PdfPCell media_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial: " + comboSupply.Text + "\n" + "Teléfono: " + mediaCTelefono.Text + " " + "Correo: " + mediaCCorreo.Text + "\n" + "\n" + "Contacto Pauta Medios: " + comboAccounts.Text + "\n" + "Teléfono: " + mediaPTelefono.Text + " " + "Correo: " + mediaPEmail.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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

                string facturadopor = "";


                if (corbox.Checked == true)
                {
                    facturadopor = "Corporativo";
                }

                if (hotelbox.Checked == true)
                {
                    facturadopor = "Hotel";
                }

                PdfPCell facturado_por_2 = new PdfPCell(new Phrase(string.Format(" " + facturadopor + " "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. FONDO DE PUBLICIDAD: " + " " + checked_mf_oi), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    vigencia_OI_mf.BackgroundColor = new BaseColor(6, 61, 150);

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf);

                    PdfPCell vigencia_OI_mf_2 = new PdfPCell(new Phrase(string.Format("   " + porcentajeMF_box.Text + "%" + " " + "De Fecha: " + " " + desde_dia_mf + " " + "Mes: " + " " + desde_mes_mf + " " + "Año: " + " " + desde_anio_mf + " " + "Hasta Fecha: " + " " + hasta_dia_mf + " " + "Mes: " + " " + hasta_mes_mf + " " + "Año: " + " " + hasta_anio_mf), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    vigencia_OI_mf_2.Colspan = 3;
                    vigencia_OI_mf_2.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf_2);
                }

                else if (metroCheckBox1.Checked == true)
                {
                    checked_mf_oi = " ";

                    desde_anio_mf = " ";
                    desde_mes_mf = " ";
                    desde_dia_mf = " ";

                    hasta_anio_mf = " ";
                    hasta_mes_mf = " ";
                    hasta_dia_mf = " ";

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. FONDO DE PUBLICIDAD: " + "  "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
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


                if (textDocEne.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }

                else
                {
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //JUL
                cell = new PdfPCell(new Phrase(string.Format(facturadoJul.Text + " " + anioJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocJul.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                PdfPCell cell_fm_3 = new PdfPCell(new Phrase(string.Format("Total con IVA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_3.Colspan = 2;
                cell_fm_3.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(cell_fm_3);

                double total = 0;

                total = Convert.ToDouble(textDocEne.Text) + Convert.ToDouble(textDocFeb.Text) + Convert.ToDouble(textDocMar.Text) + Convert.ToDouble(textDocAbr.Text) + Convert.ToDouble(textDocMay.Text) + Convert.ToDouble(textDocJun.Text) + +Convert.ToDouble(textDocJul.Text) + Convert.ToDouble(textDocAgo.Text) + Convert.ToDouble(textDocSep.Text) + Convert.ToDouble(textDocOct.Text) + Convert.ToDouble(textDocNov.Text) + Convert.ToDouble(textDocDic.Text);


                if (textTotalIVA.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(Convert.ToString(textTotalIVA.Text)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(Convert.ToString("$" + textTotalIVA.Text + " " + metroLabel119.Text)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                }

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

                if (c_t_bancaria.Checked == true)
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
                datos_IO_CC.HorizontalAlignment = 0;

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
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("http://cdn.bestday.net/_lib/HTML/BD-Media/log/0002.jpg");
                imagen.BorderWidth = 0;
                imagen.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                imagen.ScaleToFit(730f, 765.25f);


                //tercera hoja
                iTextSharp.text.Image imagen_h_1 = iTextSharp.text.Image.GetInstance("http://cdn.bestday.net/_lib/HTML/BD-Media/log/0001.png");
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
                iTextSharp.text.Image imagen_f_1 = iTextSharp.text.Image.GetInstance("http://cdn.bestday.net/_lib/HTML/BD-Media/log/0003.png");
                imagen_f_1.BorderWidth = 0;
                imagen_f_1.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                imagen_f_1.ScaleToFit(265f, 320.25f);



                //imagen header
                iTextSharp.text.Image imagen_h = iTextSharp.text.Image.GetInstance("http://cdn.bestday.net/_lib/HTML/BD-Media/log/0001.png");
                imagen_h.BorderWidth = 0;
                imagen_h.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                imagen_h.ScaleToFit(120f, 155.25f);


                //imagen footer
                iTextSharp.text.Image imagen_f = iTextSharp.text.Image.GetInstance("http://cdn.bestday.net/_lib/HTML/BD-Media/log/0003.png");
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


                    pdfDoc.Close();

                    System.Diagnostics.Process.Start(nombre_archivo);

                    stream.Close();
                }

                string fondo_publicidad = "";
                string fact_por = "";
                string forma_pag = "";
                string forma_calc = "";
                string forma_calc2 = "";
                string facturacion_mensual_text = "";

                //facturado por
                if (corbox.Checked == true)
                {
                    fact_por = "Corporativo";
                }
                else if (corbox.Checked == true)
                {
                    fact_por = "Hotel";
                }

                //forma calculo
                if (checkProduccion.Checked == true)
                {
                    forma_calc = "Producción";
                }
                else if (checkPagos.Checked == true)
                {
                    forma_calc = "Pagos Emitidos";
                }

                //forma pago
                if (checkBancaria.Checked == true)
                {
                    forma_pag = "Transferencia Bancaria";
                }
                else if (checkFacturas.Checked == true)
                {
                    forma_pag = "Compensación en Facturas";
                }

                //forma calculo 2
                if (c_t_bancaria.Checked == true)
                {
                    forma_calc2 = "Trnasferencia Bancaria";
                }
                else if (c_c_facturas.Checked == true)
                {
                    forma_calc2 = "Compensación en facturas";
                }


                try
                {
                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO oi_pdf (`numero_oi`,`fecha`,`periodo_ini`,`periodo_fin`,`cliente_nombre_comercial`,`cliente_razon_social`,`cliente_tax`,`cliente_calle`,`cliente_ciudad`,`cliente_cp`,`bd_razon`,`bd_tax`,`bd_calle`,`bd_ciudad`,`bd_cp`,`cliente_cxp_nombre`,`cliente_cxp_telefono`,`cliente_cxp_mail`,`bd_cxc_nombre`,`bd_cxc_telefono`,`bd_cxc_mail`,`cliente_comercial_nombre`,`cliente_comercial_telefono`,`cliente_comercial_mail`,`bd_comercial_nombre`,`bd_comercial_telefono`,`bd_comercial_correo`,`comercial_pauta_nombre`,`comercial_pauta_telefono`,`comercial_pauta_correo`,`bd_pauta_nombre`,`bd_pauta_telefono`,`bd_pauta_mail`,`cliente_hdo_nombre`,`cliente_hdo_telefono`,`cliente_hdo_mail`,`facturar_por`,`fondo_publicidad`,`porcentaje_publicidad`,`publicidad_ini`,`publicidad_fin`,`publicidad_forma_calculo`,`publicidad_forma_pago`,`facturacion_mensual`,`mes_uno`,`anio_uno`,`importe_uno`,`divisa_uno`,`comen_uno`,`mes_dos`,`anio_dos`,`importe_dos`,`divisa_dos`,`comen_dos`,`mes_tres`,`anio_tres`,`importe_tres`,`divisa_tres`,`comen_tres`,`mes_cuatro`,`anio_cuatro`,`importe_cuatro`,`divisa_cuatro`,`comen_cuatro`,`mes_cinco`,`anio_cinco`,`importe_cinco`,`divisa_cinco`,`comen_cinco`,`mes_seis`,`anio_seis`,`importe_seis`,`divisa_seis`,`comen_seis`,`mes_siete`,`anio_siete`,`importe_siente`,`divisa_siete`,`comen_siete`,`mes_ocho`,`anio_ocho`,`importe_ocho`,`divisa_ocho`,`comen_ocho`,`mes_nueve`,`anio_nueve`,`importe_nueve`,`divisa_nueve`,`comen_nueve`,`mes_diez`,`anio_diez`,`importe_diez`,`divisa_diez`,`comen_diez`,`mes_once`,`anio_once`,`importe_once`,`divisa_once`,`comen_once`,`mes_doce`,`anio_doce`,`importe_doce`,`divisa_doce`,`comen_doce`,`total_iva`,`forma_pago_fact`,`comentatios_fact`,`cliente_fact_nombre`,`cliente_fact_cargo`,`cliente_fact_fecha`,`bd_fact_nombre`,`bd_fact_cargo`,`bd_fact_fecha`) VALUES ('" + OI_text.Text + "','" + fechaFirma_text.Value.ToString("yyyy-MM-dd") + "','" + vigenciaDesde_text.Value.ToString("yyyy-MM-dd") + "','" + vigenciaHasta_text.Value.ToString("yyyy-MM-dd") + "','" + clienteComercial.Text + "','" + clienteRazon.Text + "','" + clienteID.Text + "','" + clienteCalle.Text + "','" + clientePais.Text + "','" + clientePostal.Text + "','" + mediaRazon.Text + "','" + mediaID.Text + "','" + mediaCalle.Text + "','" + mediaPais.Text + "','" + mediaPostal.Text + "','" + cxpNombre.Text + "','" + cxpTelefono.Text + "','" + cxpCorreo.Text + "','" + cxcNombre.Text + "','" + cxcTelefono.Text + "','" + cxcCorreo.Text + "','" + NComercial.Text + "','" + TComercial.Text + "','" + CComercial.Text + "','" + comboSupply.Text + "','" + mediaCTelefono.Text + "','" + mediaCCorreo.Text + "','" + PNombre.Text + "','" + PTelefono.Text + "','" + PCorreo.Text + "','" + comboAccounts.Text + "','" + mediaPTelefono.Text + "','" + mediaPEmail.Text + "','" + HNombre.Text + "','" + HCorreo.Text + "','" + HTelefono.Text + "','" + fact_por + "','" + fondo_publicidad + "','" + porcentajeMF_box.Text + "','" + dateTimeMF_desde.Value.ToString("yyyy-MM-dd") + "','" + dateTimeMF_hasta.Value.ToString("yyyy-MM-dd") + "','" + forma_calc + "','" + forma_pag + "','" + facturacion_mensual_text + "','" + facturadoEne.Text + "','" + anioEne.Text + "','" + textDocEne.Text + "','" + comboEne.Text + "','" + textBoxEne.Text + "','" + facturadoFeb.Text + "','" + anioFeb.Text + "','" + textDocFeb.Text + "','" + comboFeb.Text + "','" + textBoxFeb.Text + "','" + facturadoMar.Text + "','" + anioMar.Text + "','" + textDocMar.Text + "','" + comboMar.Text + "','" + textBoxMar.Text + "','" + facturadoAbr.Text + "','" + anioAbr.Text + "','" + textDocAbr.Text + "','" + comboAbr.Text + "','" + textBoxAbr.Text + "','" + facturadoMay.Text + "','" + anioMay.Text + "','" + textDocMay.Text + "','" + comboMay.Text + "','" + textBoxMay.Text + "','" + facturadoJun.Text + "','" + anioJun.Text + "','" + textDocJun.Text + "','" + comboJun.Text + "','" + textBoxJun.Text + "','" + facturadoJul.Text + "','" + anioJul.Text + "','" + textDocJul.Text + "','" + comboJul.Text + "','" + textBoxJul.Text + "','" + facturadoAgo.Text + "','" + anioAgo.Text + "','" + textDocAgo.Text + "','" + comboAgo.Text + "','" + textBoxAgo.Text + "','" + facturadoSep.Text + "','" + anioSep.Text + "','" + textDocSep.Text + "','" + comboSep.Text + "','" + textBoxSep.Text + "','" + facturadoOct.Text + "','" + anioOct.Text + "','" + textDocOct.Text + "','" + comboOct.Text + "','" + textBoxOct.Text + "','" + facturadoNov.Text + "','" + anioNov.Text + "','" + textDocNov.Text + "','" + comboNov.Text + "','" + textBoxNov.Text + "','" + facturadoDic.Text + "','" + anioDic.Text + "','" + textDocDic.Text + "','" + comboBoxDic.Text + "','" + textBoxDic.Text + "','" + textTotalIVA.Text + "','" + forma_calc2 + "','" + textCondiciones.Text + "','" + textNombre_c.Text + "','" + textCargo_c.Text + "','" + textFechaCliente.Text + "','" + textNombre_m.Text + "','" + textCargo_m.Text + "','" + textFechaMedia.Text + "' )", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
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
            double total = 0;

            total = Convert.ToDouble(textDocEne.Text) + Convert.ToDouble(textDocFeb.Text) + Convert.ToDouble(textDocMar.Text) + Convert.ToDouble(textDocAbr.Text) + Convert.ToDouble(textDocMay.Text) + Convert.ToDouble(textDocJun.Text) + +Convert.ToDouble(textDocJul.Text) + Convert.ToDouble(textDocAgo.Text) + Convert.ToDouble(textDocSep.Text) + Convert.ToDouble(textDocOct.Text) + Convert.ToDouble(textDocNov.Text) + Convert.ToDouble(textDocDic.Text);

            textTotalIVA.Text = Convert.ToString(total);
        }

        private void generador_OI_Load_1(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                    textNombre_m.Text = comboSupply.Text;
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

        private void comboEne_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboEne.Text;
        }

        private void comboFeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboFeb.Text;
        }

        private void comboMar_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboMar.Text;
        }

        private void comboAbr_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboAbr.Text;
        }

        private void comboMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboMay.Text;
        }

        private void comboJun_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboJun.Text;
        }

        private void comboJul_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboJul.Text;
        }

        private void comboAgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboAgo.Text;
        }

        private void comboSep_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboSep.Text;
        }

        private void comboOct_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboOct.Text;
        }

        private void comboNov_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboNov.Text;
        }

        private void comboBoxDic_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel119.Text = comboBoxDic.Text;
        }

        private void preliminar_button_Click(object sender, EventArgs e)
        {
            try
            {
                //caratula
                PdfPTable caratula = new PdfPTable(1);
                caratula.WidthPercentage = 100;
                PdfPCell caratula_oi = new PdfPCell(new Phrase(string.Format("FOLIO DE REFERENCIA: " + OI_text.Text + "     " + "ORDEN DE INSERCIÓN" + "     " + "FECHA: " + DateTime.Now), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
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

                PdfPCell bottom_cliente_2 = new PdfPCell(new Phrase(string.Format("Nombre: " + cxpNombre.Text + "\n" + "Teléfono: " + cxpTelefono.Text + "\n" + "Correo: " + cxpCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_cliente_2.Colspan = 2;
                table_2.AddCell(bottom_cliente_2);

                PdfPCell bottom_media_2 = new PdfPCell(new Phrase(string.Format("Nombre: " + cxcNombre.Text + "\n" + "Teléfono: " + cxcTelefono.Text + "\n" + "Correo: " + cxcCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                bottom_media_2.Colspan = 2;
                table_2.AddCell(bottom_media_2);


                //clientes_2
                PdfPTable table_3 = new PdfPTable(4);
                table_3.WidthPercentage = 100;
                PdfPCell cliente_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial: " + NComercial.Text + "\n" + "Teléfono: " + TComercial.Text + " " + "Correo: " + CComercial.Text + "\n" + "\n" + "Contacto Pauta Medios: " + PNombre.Text + "\n" + "Teléfono: " + PTelefono.Text + " " + "Correo: " + PCorreo.Text + "\n" + "\n" + "Contacto Tour HotelDO: " + HNombre.Text + "\n" + "Teléfono: " + HTelefono.Text + " " + "Correo: " + HCorreo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cliente_3.Colspan = 2;

                PdfPCell media_3 = new PdfPCell(new Phrase(string.Format("Contacto Comercial: " + comboSupply.Text + "\n" + "Teléfono: " + mediaCTelefono.Text + " " + "Correo: " + mediaCCorreo.Text + "\n" + "\n" + "Contacto Pauta Medios: " + comboAccounts.Text + "\n" + "Teléfono: " + mediaPTelefono.Text + " " + "Correo: " + mediaPEmail.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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

                string facturadopor = "";


                if (corbox.Checked == true)
                {
                    facturadopor = "Corporativo";
                }

                if (hotelbox.Checked == true)
                {
                    facturadopor = "Hotel";
                }

                PdfPCell facturado_por_2 = new PdfPCell(new Phrase(string.Format(" " + facturadopor + " "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. FONDO DE PUBLICIDAD: " + " " + checked_mf_oi), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    vigencia_OI_mf.BackgroundColor = new BaseColor(6, 61, 150);

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf);

                    PdfPCell vigencia_OI_mf_2 = new PdfPCell(new Phrase(string.Format("   " + porcentajeMF_box.Text + "%" + " " + "De Fecha: " + " " + desde_dia_mf + " " + "Mes: " + " " + desde_mes_mf + " " + "Año: " + " " + desde_anio_mf + " " + "Hasta Fecha: " + " " + hasta_dia_mf + " " + "Mes: " + " " + hasta_mes_mf + " " + "Año: " + " " + hasta_anio_mf), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    vigencia_OI_mf_2.Colspan = 3;
                    vigencia_OI_mf_2.BackgroundColor = ExtendedColor.WHITE; //cambiar color cabecera

                    vigencia_pauta_mf.AddCell(vigencia_OI_mf_2);
                }

                else if (metroCheckBox1.Checked == true)
                {
                    checked_mf_oi = " ";

                    desde_anio_mf = " ";
                    desde_mes_mf = " ";
                    desde_dia_mf = " ";

                    hasta_anio_mf = " ";
                    hasta_mes_mf = " ";
                    hasta_dia_mf = " ";

                    PdfPCell vigencia_OI_mf = new PdfPCell(new Phrase(string.Format("1. FONDO DE PUBLICIDAD: " + "  "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
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


                if (textDocEne.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }

                else
                {
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocEne.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocFeb.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocMar.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocAbr.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocMay.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxJun.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                //JUL
                cell = new PdfPCell(new Phrase(string.Format(facturadoJul.Text + " " + anioJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                if (textDocJul.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocJul.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocAgo.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocSep.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocOct.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocNov.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
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
                    cell = new PdfPCell(new Phrase(string.Format("$" + textDocDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    table.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase(string.Format(comboBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(string.Format(textBoxDic.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 3;
                table.AddCell(cell);


                PdfPCell cell_fm_3 = new PdfPCell(new Phrase(string.Format("Total con IVA: "), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell_fm_3.Colspan = 2;
                cell_fm_3.BackgroundColor = new BaseColor(6, 61, 150); //cambiar color cabecera
                table.AddCell(cell_fm_3);

                double total = 0;

                total = Convert.ToDouble(textDocEne.Text) + Convert.ToDouble(textDocFeb.Text) + Convert.ToDouble(textDocMar.Text) + Convert.ToDouble(textDocAbr.Text) + Convert.ToDouble(textDocMay.Text) + Convert.ToDouble(textDocJun.Text) + +Convert.ToDouble(textDocJul.Text) + Convert.ToDouble(textDocAgo.Text) + Convert.ToDouble(textDocSep.Text) + Convert.ToDouble(textDocOct.Text) + Convert.ToDouble(textDocNov.Text) + Convert.ToDouble(textDocDic.Text);


                if (textTotalIVA.Text == "0.00")
                {
                    cell = new PdfPCell(new Phrase(string.Format(Convert.ToString(textTotalIVA.Text)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase(string.Format(Convert.ToString("$" + textTotalIVA.Text + " " + metroLabel119.Text)), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                }

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

                if (c_t_bancaria.Checked == true)
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
                datos_IO_CC.HorizontalAlignment = 0;

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
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("http://ccascarudocun.com/images/log/0002.jpg");
                imagen.BorderWidth = 0;
                imagen.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                imagen.ScaleToFit(730f, 765.25f);


                //tercera hoja
                iTextSharp.text.Image imagen_h_1 = iTextSharp.text.Image.GetInstance("http://ccascarudocun.com/images/log/0001.png");
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
                iTextSharp.text.Image imagen_f_1 = iTextSharp.text.Image.GetInstance("http://ccascarudocun.com/images/log/0003.png");
                imagen_f_1.BorderWidth = 0;
                imagen_f_1.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                imagen_f_1.ScaleToFit(265f, 320.25f);



                //imagen header
                iTextSharp.text.Image imagen_h = iTextSharp.text.Image.GetInstance("http://ccascarudocun.com/images/log/0001.png");
                imagen_h.BorderWidth = 0;
                imagen_h.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                imagen_h.ScaleToFit(120f, 155.25f);


                //imagen footer
                iTextSharp.text.Image imagen_f = iTextSharp.text.Image.GetInstance("http://ccascarudocun.com/images/log/0003.png");
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


                    pdfDoc.Close();

                    System.Diagnostics.Process.Start(nombre_archivo);

                    stream.Close();
                }

                string fondo_publicidad = "";
                string fact_por = "";
                string forma_pag = "";
                string forma_calc = "";
                string forma_calc2 = "";
                string facturacion_mensual_text = "";

                //facturado por
                if (corbox.Checked == true)
                {
                    fact_por = "Corporativo";
                }
                else if (corbox.Checked == true)
                {
                    fact_por = "Hotel";
                }

                //forma calculo
                if (checkProduccion.Checked == true)
                {
                    forma_calc = "Producción";
                }
                else if (checkPagos.Checked == true)
                {
                    forma_calc = "Pagos Emitidos";
                }

                //forma pago
                if (checkBancaria.Checked == true)
                {
                    forma_pag = "Transferencia Bancaria";
                }
                else if (checkFacturas.Checked == true)
                {
                    forma_pag = "Compensación en Facturas";
                }

                //forma calculo 2
                if (c_t_bancaria.Checked == true)
                {
                    forma_calc2 = "Trnasferencia Bancaria";
                }
                else if (c_c_facturas.Checked == true)
                {
                    forma_calc2 = "Compensación en facturas";
                }

                MessageBox.Show("Documento creado.", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void OI_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    con.Close();

                    con.Open();
                    string sql = "SELECT * FROM oi_pdf_temp WHERE numero_oi ='" + OI_text.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        fechaFirma_text.Value = Convert.ToDateTime(reader["fecha"]);

                        vigenciaDesde_text.Value = Convert.ToDateTime(reader["periodo_ini"]);

                        vigenciaHasta_text.Value = Convert.ToDateTime(reader["periodo_fin"]);

                        clienteComercial.Text = Convert.ToString(reader["cliente_nombre_comercial"]);

                        clienteRazon.Text = Convert.ToString(reader["cliente_razon_social"]);

                        clienteID.Text = Convert.ToString(reader["cliente_tax"]);

                        clienteCalle.Text = Convert.ToString(reader["cliente_calle"]);

                        clientePais.Text = Convert.ToString(reader["cliente_ciudad"]);

                        clientePostal.Text = Convert.ToString(reader["cliente_cp"]);

                        cxpNombre.Text = Convert.ToString(reader["cliente_cxp_nombre"]);

                        cxpTelefono.Text = Convert.ToString(reader["cliente_cxp_telefono"]);

                        cxpCorreo.Text = Convert.ToString(reader["cliente_cxp_mail"]);

                        NComercial.Text = Convert.ToString(reader["cliente_comercial_nombre"]);

                        CComercial.Text = Convert.ToString(reader["cliente_comercial_telefono"]);

                        TComercial.Text = Convert.ToString(reader["cliente_comercial_mail"]);

                        comboSupply.Text = Convert.ToString(reader["bd_comercial_nombre"]);

                        //mediaCTelefono.Text = Convert.ToString(reader["bd_comercial_telefono"]);

                        //mediaCCorreo.Text = Convert.ToString(reader["bd_comercial_correo"]);

                        PNombre.Text = Convert.ToString(reader["comercial_pauta_nombre"]);

                        PTelefono.Text = Convert.ToString(reader["comercial_pauta_telefono"]);

                        PCorreo.Text = Convert.ToString(reader["comercial_pauta_correo"]);

                        comboAccounts.Text = Convert.ToString(reader["bd_pauta_nombre"]);

                        //mediaPTelefono.Text = Convert.ToString(reader["bd_pauta_telefono"]);

                        //mediaPEmail.Text = Convert.ToString(reader["bd_pauta_mail"]);

                        HNombre.Text = Convert.ToString(reader["cliente_hdo_nombre"]);

                        HTelefono.Text = Convert.ToString(reader["cliente_hdo_telefono"]);

                        HCorreo.Text = Convert.ToString(reader["cliente_hdo_mail"]);

                        string valor_facturado_por = Convert.ToString(reader["facturar_por"]);

                        if (valor_facturado_por == "Corporativo")
                        {
                            corbox.Checked = true;
                        }
                        else
                        {
                            hotelbox.Checked = true;
                        }

                        //FALTA FONDO DE PUBLICIDAD

                        porcentajeMF_box.Text = Convert.ToString(reader["porcentaje_publicidad"]);

                        dateTimeMF_desde.Value = Convert.ToDateTime(reader["publicidad_ini"]);

                        dateTimeMF_hasta.Value = Convert.ToDateTime(reader["publicidad_fin"]);

                        string valor_forma_calc = Convert.ToString(reader["publicidad_forma_calculo"]);

                        if (valor_forma_calc == "Producción")
                        {
                            checkProduccion.Checked = true;
                        }
                        else
                        {
                            checkPagos.Checked = true;
                        }

                        string valor_forma_pago = Convert.ToString(reader["publicidad_forma_pago"]);

                        if (valor_forma_pago == "Transferencia Bancaria")
                        {
                            checkBancaria.Checked = true;
                        }
                        else
                        {
                            checkFacturas.Checked = true;
                        }

                        facturadoEne.Text = Convert.ToString(reader["mes_uno"]);

                        anioEne.Text = Convert.ToString(reader["anio_uno"]);

                        textDocEne.Text = Convert.ToString(reader["importe_uno"]);

                        comboEne.Text = Convert.ToString(reader["divisa_uno"]);

                        textBoxEne.Text = Convert.ToString(reader["comen_uno"]);

                        facturadoFeb.Text = Convert.ToString(reader["mes_dos"]);

                        anioFeb.Text = Convert.ToString(reader["anio_dos"]);

                        textDocFeb.Text = Convert.ToString(reader["importe_dos"]);

                        comboFeb.Text = Convert.ToString(reader["divisa_dos"]);

                        textBoxFeb.Text = Convert.ToString(reader["comen_dos"]);

                        facturadoMar.Text = Convert.ToString(reader["mes_tres"]);

                        anioMar.Text = Convert.ToString(reader["anio_tres"]);

                        textDocMar.Text = Convert.ToString(reader["importe_tres"]);

                        comboMar.Text = Convert.ToString(reader["divisa_tres"]);

                        textBoxMar.Text = Convert.ToString(reader["comen_tres"]);

                        facturadoAbr.Text = Convert.ToString(reader["mes_cuatro"]);

                        anioAbr.Text = Convert.ToString(reader["anio_cuatro"]);

                        textDocAbr.Text = Convert.ToString(reader["importe_cuatro"]);

                        comboAbr.Text = Convert.ToString(reader["divisa_cuatro"]);

                        textBoxAbr.Text = Convert.ToString(reader["comen_cuatro"]);

                        facturadoMay.Text = Convert.ToString(reader["mes_cinco"]);

                        anioMay.Text = Convert.ToString(reader["anio_cinco"]);

                        textDocMay.Text = Convert.ToString(reader["importe_cinco"]);

                        comboMay.Text = Convert.ToString(reader["divisa_cinco"]);

                        textBoxMay.Text = Convert.ToString(reader["comen_cinco"]);

                        facturadoJun.Text = Convert.ToString(reader["mes_seis"]);

                        anioJun.Text = Convert.ToString(reader["anio_seis"]);

                        textDocJun.Text = Convert.ToString(reader["importe_seis"]);

                        comboJun.Text = Convert.ToString(reader["divisa_seis"]);

                        textBoxJun.Text = Convert.ToString(reader["comen_seis"]);

                        facturadoJul.Text = Convert.ToString(reader["mes_siete"]);

                        anioJul.Text = Convert.ToString(reader["anio_siete"]);

                        textDocJul.Text = Convert.ToString(reader["importe_siente"]);

                        comboJul.Text = Convert.ToString(reader["divisa_siete"]);

                        textBoxJul.Text = Convert.ToString(reader["comen_siete"]);

                        facturadoAgo.Text = Convert.ToString(reader["mes_ocho"]);

                        anioAgo.Text = Convert.ToString(reader["anio_ocho"]);

                        textDocAgo.Text = Convert.ToString(reader["importe_ocho"]);

                        comboAgo.Text = Convert.ToString(reader["divisa_ocho"]);

                        textBoxAgo.Text = Convert.ToString(reader["comen_ocho"]);

                        facturadoSep.Text = Convert.ToString(reader["mes_nueve"]);

                        anioSep.Text = Convert.ToString(reader["anio_nueve"]);

                        textDocSep.Text = Convert.ToString(reader["importe_nueve"]);

                        comboSep.Text = Convert.ToString(reader["divisa_nueve"]);

                        textBoxSep.Text = Convert.ToString(reader["comen_nueve"]);

                        facturadoOct.Text = Convert.ToString(reader["mes_diez"]);

                        anioOct.Text = Convert.ToString(reader["anio_diez"]);

                        textDocOct.Text = Convert.ToString(reader["importe_diez"]);

                        comboOct.Text = Convert.ToString(reader["divisa_diez"]);

                        textBoxOct.Text = Convert.ToString(reader["comen_diez"]);

                        facturadoNov.Text = Convert.ToString(reader["mes_once"]);

                        anioNov.Text = Convert.ToString(reader["anio_once"]);

                        textDocNov.Text = Convert.ToString(reader["importe_once"]);

                        comboNov.Text = Convert.ToString(reader["divisa_once"]);

                        textBoxNov.Text = Convert.ToString(reader["comen_once"]);

                        facturadoDic.Text = Convert.ToString(reader["mes_doce"]);

                        anioDic.Text = Convert.ToString(reader["anio_doce"]);

                        textDocDic.Text = Convert.ToString(reader["importe_doce"]);

                        comboBoxDic.Text = Convert.ToString(reader["divisa_doce"]);

                        textBoxDic.Text = Convert.ToString(reader["comen_doce"]);

                        textTotalIVA.Text = Convert.ToString(reader["total_iva"]);

                        string valor_forma_pago_fact = Convert.ToString(reader["forma_pago_fact"]);

                        if (valor_forma_pago_fact == "Transferencia Bancaria")
                        {
                            c_t_bancaria.Checked = true;
                        }
                        else
                        {
                            c_c_facturas.Checked = true;
                        }

                        textCondiciones.Text = Convert.ToString(reader["comentatios_fact"]);

                        textNombre_c.Text = Convert.ToString(reader["cliente_fact_nombre"]);

                        textCargo_c.Text = Convert.ToString(reader["cliente_fact_cargo"]);

                        textFechaCliente.Text = Convert.ToString(reader["cliente_fact_fecha"]);

                        textNombre_m.Text = Convert.ToString(reader["bd_fact_nombre"]);

                        textCargo_m.Text = Convert.ToString(reader["bd_fact_cargo"]);

                        textFechaMedia.Text = Convert.ToString(reader["bd_fact_fecha"]);
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }
    }
}

