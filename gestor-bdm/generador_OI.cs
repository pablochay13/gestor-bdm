using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class generador_OI : MetroFramework.Forms.MetroForm
    {
        public generador_OI()
        {
            InitializeComponent();

        }

        private void Generador_OI_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generador_OI));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.generar_OI = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaFirma_text = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.OI_text = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.vigenciaDesde_text = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.vigenciaHasta_text = new MetroFramework.Controls.MetroDateTime();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.clienteComercial = new MetroFramework.Controls.MetroTextBox();
            this.lanbel9999 = new MetroFramework.Controls.MetroLabel();
            this.clienteRazon = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.clienteID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.clienteCalle = new MetroFramework.Controls.MetroTextBox();
            this.clientePais = new MetroFramework.Controls.MetroTextBox();
            this.clientePostal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cxpNombre = new MetroFramework.Controls.MetroTextBox();
            this.cxpTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cxpCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.CComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.NComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.PCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.PTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.PNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.HCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.HTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.HNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mediaPCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.mediaPTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.mediaPNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mediaCCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.mediaCTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.mediaCNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox14 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cxcCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.cxcTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.cxcNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.textTotalIVA = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
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
            this.Sumar = new System.Windows.Forms.Button();
            this.anioDic = new System.Windows.Forms.ComboBox();
            this.anioNov = new System.Windows.Forms.ComboBox();
            this.anioOct = new System.Windows.Forms.ComboBox();
            this.anioSep = new System.Windows.Forms.ComboBox();
            this.anioAgo = new System.Windows.Forms.ComboBox();
            this.anioJul = new System.Windows.Forms.ComboBox();
            this.anioJun = new System.Windows.Forms.ComboBox();
            this.anioMay = new System.Windows.Forms.ComboBox();
            this.anioAbr = new System.Windows.Forms.ComboBox();
            this.anioMar = new System.Windows.Forms.ComboBox();
            this.anioFeb = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.anioEne = new System.Windows.Forms.ComboBox();
            this.comboBoxDic = new System.Windows.Forms.ComboBox();
            this.comboNov = new System.Windows.Forms.ComboBox();
            this.comboOct = new System.Windows.Forms.ComboBox();
            this.comboSep = new System.Windows.Forms.ComboBox();
            this.comboAgo = new System.Windows.Forms.ComboBox();
            this.comboJul = new System.Windows.Forms.ComboBox();
            this.comboJun = new System.Windows.Forms.ComboBox();
            this.comboMay = new System.Windows.Forms.ComboBox();
            this.comboAbr = new System.Windows.Forms.ComboBox();
            this.comboMar = new System.Windows.Forms.ComboBox();
            this.comboFeb = new System.Windows.Forms.ComboBox();
            this.comboEne = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.textBoxEne = new System.Windows.Forms.TextBox();
            this.textBoxOct = new System.Windows.Forms.TextBox();
            this.textBoxJul = new System.Windows.Forms.TextBox();
            this.textBoxAbr = new System.Windows.Forms.TextBox();
            this.textBoxMar = new System.Windows.Forms.TextBox();
            this.textBoxNov = new System.Windows.Forms.TextBox();
            this.textBoxAgo = new System.Windows.Forms.TextBox();
            this.textBoxDic = new System.Windows.Forms.TextBox();
            this.textBoxMay = new System.Windows.Forms.TextBox();
            this.textBoxSep = new System.Windows.Forms.TextBox();
            this.textBoxFeb = new System.Windows.Forms.TextBox();
            this.textBoxJun = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.facturadoDic = new System.Windows.Forms.ComboBox();
            this.facturadoNov = new System.Windows.Forms.ComboBox();
            this.facturadoOct = new System.Windows.Forms.ComboBox();
            this.facturadoSep = new System.Windows.Forms.ComboBox();
            this.facturadoAgo = new System.Windows.Forms.ComboBox();
            this.facturadoJul = new System.Windows.Forms.ComboBox();
            this.facturadoJun = new System.Windows.Forms.ComboBox();
            this.facturadoMay = new System.Windows.Forms.ComboBox();
            this.facturadoAbr = new System.Windows.Forms.ComboBox();
            this.facturadoMar = new System.Windows.Forms.ComboBox();
            this.facturadoFeb = new System.Windows.Forms.ComboBox();
            this.facturadoEne = new System.Windows.Forms.ComboBox();
            this.c_c_facturas = new System.Windows.Forms.CheckBox();
            this.c_t_bancaria = new System.Windows.Forms.CheckBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textCondiciones = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBoxMF = new MetroFramework.Controls.MetroCheckBox();
            this.porcentajeMF_box = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeMF_desde = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeMF_hasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.checkProduccion = new MetroFramework.Controls.MetroCheckBox();
            this.checkPagos = new MetroFramework.Controls.MetroCheckBox();
            this.checkFacturas = new MetroFramework.Controls.MetroCheckBox();
            this.checkBancaria = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
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
            this.generar_OI.Text = "Generar OI";
            this.generar_OI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generar_OI.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.generar_OI.UseCustomForeColor = true;
            this.generar_OI.UseSelectable = true;
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
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
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
            this.OI_text.Lines = new string[0];
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
            this.OI_text.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OI_text.UseSelectable = true;
            this.OI_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OI_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1212, 569);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Anexos";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(940, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(19, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "al";
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
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.CComercial);
            this.groupBox13.Controls.Add(this.metroLabel14);
            this.groupBox13.Controls.Add(this.TComercial);
            this.groupBox13.Controls.Add(this.metroLabel15);
            this.groupBox13.Controls.Add(this.NComercial);
            this.groupBox13.Controls.Add(this.metroLabel16);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(6, 475);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(558, 140);
            this.groupBox13.TabIndex = 277;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Contacto Comercial";
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 38);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(126, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Nombre Comercial:";
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
            this.clienteComercial.Lines = new string[0];
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
            this.clienteComercial.UseSelectable = true;
            this.clienteComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.clienteRazon.Lines = new string[0];
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
            this.clienteRazon.UseSelectable = true;
            this.clienteRazon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteRazon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 100);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "ID Fiscal:";
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
            this.clienteID.Lines = new string[0];
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
            this.clienteID.UseSelectable = true;
            this.clienteID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 169);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 33;
            this.metroLabel8.Text = "Calle:";
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
            this.clienteCalle.Lines = new string[0];
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
            this.clienteCalle.UseSelectable = true;
            this.clienteCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clienteCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.clientePais.Lines = new string[0];
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
            this.clientePais.UseSelectable = true;
            this.clientePais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientePais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.clientePostal.Lines = new string[0];
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
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(15, 38);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(62, 19);
            this.metroLabel11.TabIndex = 34;
            this.metroLabel11.Text = "Nombre:";
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
            this.cxpNombre.Lines = new string[0];
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
            this.cxpNombre.UseSelectable = true;
            this.cxpNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cxpNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.cxpTelefono.Lines = new string[0];
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
            this.cxpCorreo.Lines = new string[0];
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
            this.CComercial.Lines = new string[0];
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
            this.TComercial.Lines = new string[0];
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
            this.NComercial.Lines = new string[0];
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
            this.NComercial.TabIndex = 41;
            this.NComercial.UseSelectable = true;
            this.NComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.PCorreo.Lines = new string[0];
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
            this.PTelefono.Lines = new string[0];
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
            this.PNombre.Lines = new string[0];
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
            this.HCorreo.Lines = new string[0];
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
            this.HTelefono.Lines = new string[0];
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
            this.HNombre.Lines = new string[0];
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
            this.groupBox3.Size = new System.Drawing.Size(576, 931);
            this.groupBox3.TabIndex = 280;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Best Travel Media";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mediaPCorreo);
            this.groupBox5.Controls.Add(this.metroLabel26);
            this.groupBox5.Controls.Add(this.mediaPTelefono);
            this.groupBox5.Controls.Add(this.metroLabel27);
            this.groupBox5.Controls.Add(this.mediaPNombre);
            this.groupBox5.Controls.Add(this.metroLabel28);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 621);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(558, 145);
            this.groupBox5.TabIndex = 278;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contacto Pauta Medios";
            // 
            // mediaPCorreo
            // 
            // 
            // 
            // 
            this.mediaPCorreo.CustomButton.Image = null;
            this.mediaPCorreo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaPCorreo.CustomButton.Name = "";
            this.mediaPCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaPCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaPCorreo.CustomButton.TabIndex = 1;
            this.mediaPCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaPCorreo.CustomButton.UseSelectable = true;
            this.mediaPCorreo.CustomButton.Visible = false;
            this.mediaPCorreo.Lines = new string[0];
            this.mediaPCorreo.Location = new System.Drawing.Point(83, 106);
            this.mediaPCorreo.MaxLength = 32767;
            this.mediaPCorreo.Name = "mediaPCorreo";
            this.mediaPCorreo.PasswordChar = '\0';
            this.mediaPCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaPCorreo.SelectedText = "";
            this.mediaPCorreo.SelectionLength = 0;
            this.mediaPCorreo.SelectionStart = 0;
            this.mediaPCorreo.ShortcutsEnabled = true;
            this.mediaPCorreo.Size = new System.Drawing.Size(466, 23);
            this.mediaPCorreo.TabIndex = 51;
            this.mediaPCorreo.UseSelectable = true;
            this.mediaPCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaPCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mediaPTelefono.Lines = new string[0];
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
            // mediaPNombre
            // 
            // 
            // 
            // 
            this.mediaPNombre.CustomButton.Image = null;
            this.mediaPNombre.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaPNombre.CustomButton.Name = "";
            this.mediaPNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaPNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaPNombre.CustomButton.TabIndex = 1;
            this.mediaPNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaPNombre.CustomButton.UseSelectable = true;
            this.mediaPNombre.CustomButton.Visible = false;
            this.mediaPNombre.Lines = new string[0];
            this.mediaPNombre.Location = new System.Drawing.Point(83, 39);
            this.mediaPNombre.MaxLength = 32767;
            this.mediaPNombre.Name = "mediaPNombre";
            this.mediaPNombre.PasswordChar = '\0';
            this.mediaPNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaPNombre.SelectedText = "";
            this.mediaPNombre.SelectionLength = 0;
            this.mediaPNombre.SelectionStart = 0;
            this.mediaPNombre.ShortcutsEnabled = true;
            this.mediaPNombre.Size = new System.Drawing.Size(466, 23);
            this.mediaPNombre.TabIndex = 47;
            this.mediaPNombre.UseSelectable = true;
            this.mediaPNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaPNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.groupBox6.Controls.Add(this.mediaCCorreo);
            this.groupBox6.Controls.Add(this.metroLabel29);
            this.groupBox6.Controls.Add(this.mediaCTelefono);
            this.groupBox6.Controls.Add(this.metroLabel30);
            this.groupBox6.Controls.Add(this.mediaCNombre);
            this.groupBox6.Controls.Add(this.metroLabel31);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 475);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(558, 140);
            this.groupBox6.TabIndex = 277;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Contacto Comercial";
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
            this.mediaCCorreo.Lines = new string[0];
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
            this.mediaCTelefono.Lines = new string[0];
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
            // mediaCNombre
            // 
            // 
            // 
            // 
            this.mediaCNombre.CustomButton.Image = null;
            this.mediaCNombre.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mediaCNombre.CustomButton.Name = "";
            this.mediaCNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mediaCNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mediaCNombre.CustomButton.TabIndex = 1;
            this.mediaCNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mediaCNombre.CustomButton.UseSelectable = true;
            this.mediaCNombre.CustomButton.Visible = false;
            this.mediaCNombre.Lines = new string[0];
            this.mediaCNombre.Location = new System.Drawing.Point(83, 36);
            this.mediaCNombre.MaxLength = 32767;
            this.mediaCNombre.Name = "mediaCNombre";
            this.mediaCNombre.PasswordChar = '\0';
            this.mediaCNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mediaCNombre.SelectedText = "";
            this.mediaCNombre.SelectionLength = 0;
            this.mediaCNombre.SelectionStart = 0;
            this.mediaCNombre.ShortcutsEnabled = true;
            this.mediaCNombre.Size = new System.Drawing.Size(466, 23);
            this.mediaCNombre.TabIndex = 41;
            this.mediaCNombre.UseSelectable = true;
            this.mediaCNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mediaCNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.groupBox7.Controls.Add(this.metroTextBox10);
            this.groupBox7.Controls.Add(this.metroLabel32);
            this.groupBox7.Controls.Add(this.metroTextBox11);
            this.groupBox7.Controls.Add(this.metroTextBox12);
            this.groupBox7.Controls.Add(this.metroLabel33);
            this.groupBox7.Controls.Add(this.metroLabel34);
            this.groupBox7.Controls.Add(this.metroLabel35);
            this.groupBox7.Controls.Add(this.metroTextBox13);
            this.groupBox7.Controls.Add(this.metroLabel36);
            this.groupBox7.Controls.Add(this.metroTextBox14);
            this.groupBox7.Controls.Add(this.metroLabel37);
            this.groupBox7.Location = new System.Drawing.Point(6, 35);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(558, 284);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Datos Generales";
            // 
            // metroTextBox10
            // 
            // 
            // 
            // 
            this.metroTextBox10.CustomButton.Image = null;
            this.metroTextBox10.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.metroTextBox10.CustomButton.Name = "";
            this.metroTextBox10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox10.CustomButton.TabIndex = 1;
            this.metroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox10.CustomButton.UseSelectable = true;
            this.metroTextBox10.CustomButton.Visible = false;
            this.metroTextBox10.Lines = new string[] {
        "77500"};
            this.metroTextBox10.Location = new System.Drawing.Point(115, 206);
            this.metroTextBox10.MaxLength = 32767;
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.PasswordChar = '\0';
            this.metroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox10.SelectedText = "";
            this.metroTextBox10.SelectionLength = 0;
            this.metroTextBox10.SelectionStart = 0;
            this.metroTextBox10.ShortcutsEnabled = true;
            this.metroTextBox10.Size = new System.Drawing.Size(434, 23);
            this.metroTextBox10.TabIndex = 38;
            this.metroTextBox10.Text = "77500";
            this.metroTextBox10.UseSelectable = true;
            this.metroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTextBox11
            // 
            // 
            // 
            // 
            this.metroTextBox11.CustomButton.Image = null;
            this.metroTextBox11.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.metroTextBox11.CustomButton.Name = "";
            this.metroTextBox11.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox11.CustomButton.TabIndex = 1;
            this.metroTextBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox11.CustomButton.UseSelectable = true;
            this.metroTextBox11.CustomButton.Visible = false;
            this.metroTextBox11.Lines = new string[] {
        "Cancún, Quintana Roo, México"};
            this.metroTextBox11.Location = new System.Drawing.Point(103, 170);
            this.metroTextBox11.MaxLength = 32767;
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.PasswordChar = '\0';
            this.metroTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox11.SelectedText = "";
            this.metroTextBox11.SelectionLength = 0;
            this.metroTextBox11.SelectionStart = 0;
            this.metroTextBox11.ShortcutsEnabled = true;
            this.metroTextBox11.Size = new System.Drawing.Size(446, 23);
            this.metroTextBox11.TabIndex = 36;
            this.metroTextBox11.Text = "Cancún, Quintana Roo, México";
            this.metroTextBox11.UseSelectable = true;
            this.metroTextBox11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox12
            // 
            // 
            // 
            // 
            this.metroTextBox12.CustomButton.Image = null;
            this.metroTextBox12.CustomButton.Location = new System.Drawing.Point(465, 1);
            this.metroTextBox12.CustomButton.Name = "";
            this.metroTextBox12.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox12.CustomButton.TabIndex = 1;
            this.metroTextBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox12.CustomButton.UseSelectable = true;
            this.metroTextBox12.CustomButton.Visible = false;
            this.metroTextBox12.Lines = new string[] {
        "Av. Bonampak, SM 10, Mz 2, Lote 7 Torre \"B\""};
            this.metroTextBox12.Location = new System.Drawing.Point(62, 138);
            this.metroTextBox12.MaxLength = 32767;
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.PasswordChar = '\0';
            this.metroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox12.SelectedText = "";
            this.metroTextBox12.SelectionLength = 0;
            this.metroTextBox12.SelectionStart = 0;
            this.metroTextBox12.ShortcutsEnabled = true;
            this.metroTextBox12.Size = new System.Drawing.Size(487, 23);
            this.metroTextBox12.TabIndex = 35;
            this.metroTextBox12.Text = "Av. Bonampak, SM 10, Mz 2, Lote 7 Torre \"B\"";
            this.metroTextBox12.UseSelectable = true;
            this.metroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTextBox13
            // 
            // 
            // 
            // 
            this.metroTextBox13.CustomButton.Image = null;
            this.metroTextBox13.CustomButton.Location = new System.Drawing.Point(447, 1);
            this.metroTextBox13.CustomButton.Name = "";
            this.metroTextBox13.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox13.CustomButton.TabIndex = 1;
            this.metroTextBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox13.CustomButton.UseSelectable = true;
            this.metroTextBox13.CustomButton.Visible = false;
            this.metroTextBox13.Lines = new string[] {
        "VBE840427HI7"};
            this.metroTextBox13.Location = new System.Drawing.Point(80, 69);
            this.metroTextBox13.MaxLength = 32767;
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.PasswordChar = '\0';
            this.metroTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox13.SelectedText = "";
            this.metroTextBox13.SelectionLength = 0;
            this.metroTextBox13.SelectionStart = 0;
            this.metroTextBox13.ShortcutsEnabled = true;
            this.metroTextBox13.Size = new System.Drawing.Size(469, 23);
            this.metroTextBox13.TabIndex = 31;
            this.metroTextBox13.Text = "VBE840427HI7";
            this.metroTextBox13.UseSelectable = true;
            this.metroTextBox13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Location = new System.Drawing.Point(15, 69);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(59, 19);
            this.metroLabel36.TabIndex = 30;
            this.metroLabel36.Text = "ID Fiscal:";
            // 
            // metroTextBox14
            // 
            // 
            // 
            // 
            this.metroTextBox14.CustomButton.Image = null;
            this.metroTextBox14.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.metroTextBox14.CustomButton.Name = "";
            this.metroTextBox14.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox14.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox14.CustomButton.TabIndex = 1;
            this.metroTextBox14.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox14.CustomButton.UseSelectable = true;
            this.metroTextBox14.CustomButton.Visible = false;
            this.metroTextBox14.Lines = new string[] {
        " Viajes Beda, SA de CV"};
            this.metroTextBox14.Location = new System.Drawing.Point(180, 38);
            this.metroTextBox14.MaxLength = 32767;
            this.metroTextBox14.Name = "metroTextBox14";
            this.metroTextBox14.PasswordChar = '\0';
            this.metroTextBox14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox14.SelectedText = "";
            this.metroTextBox14.SelectionLength = 0;
            this.metroTextBox14.SelectionStart = 0;
            this.metroTextBox14.ShortcutsEnabled = true;
            this.metroTextBox14.Size = new System.Drawing.Size(369, 23);
            this.metroTextBox14.TabIndex = 29;
            this.metroTextBox14.Text = " Viajes Beda, SA de CV";
            this.metroTextBox14.UseSelectable = true;
            this.metroTextBox14.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox14.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.cxcCorreo.Lines = new string[0];
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
            this.cxcTelefono.Lines = new string[0];
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
            this.cxcNombre.Lines = new string[0];
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.groupBox21);
            this.groupBox4.Controls.Add(this.groupBox20);
            this.groupBox4.Controls.Add(this.textCondiciones);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(5, 1057);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1185, 863);
            this.groupBox4.TabIndex = 281;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Esquema Comercial y Forma de Pago";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.textTotalIVA);
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
            this.groupBox21.Controls.Add(this.Sumar);
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
            this.groupBox21.Controls.Add(this.label95);
            this.groupBox21.Controls.Add(this.anioEne);
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
            this.groupBox21.Controls.Add(this.comboEne);
            this.groupBox21.Controls.Add(this.label94);
            this.groupBox21.Controls.Add(this.textBoxEne);
            this.groupBox21.Controls.Add(this.textBoxOct);
            this.groupBox21.Controls.Add(this.textBoxJul);
            this.groupBox21.Controls.Add(this.textBoxAbr);
            this.groupBox21.Controls.Add(this.textBoxMar);
            this.groupBox21.Controls.Add(this.textBoxNov);
            this.groupBox21.Controls.Add(this.textBoxAgo);
            this.groupBox21.Controls.Add(this.textBoxDic);
            this.groupBox21.Controls.Add(this.textBoxMay);
            this.groupBox21.Controls.Add(this.textBoxSep);
            this.groupBox21.Controls.Add(this.textBoxFeb);
            this.groupBox21.Controls.Add(this.textBoxJun);
            this.groupBox21.Controls.Add(this.label93);
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
            this.groupBox21.Controls.Add(this.c_c_facturas);
            this.groupBox21.Controls.Add(this.c_t_bancaria);
            this.groupBox21.Controls.Add(this.label41);
            this.groupBox21.Controls.Add(this.label40);
            this.groupBox21.Controls.Add(this.label51);
            this.groupBox21.Controls.Add(this.label50);
            this.groupBox21.Location = new System.Drawing.Point(10, 211);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(886, 516);
            this.groupBox21.TabIndex = 336;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Marketing Fijo";
            // 
            // textTotalIVA
            // 
            this.textTotalIVA.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textTotalIVA.DoubleValue = 0D;
            this.textTotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalIVA.Location = new System.Drawing.Point(121, 423);
            this.textTotalIVA.Name = "textTotalIVA";
            this.textTotalIVA.Size = new System.Drawing.Size(626, 26);
            this.textTotalIVA.TabIndex = 420;
            this.textTotalIVA.Text = "0.00";
            // 
            // textDocDic
            // 
            this.textDocDic.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocDic.DoubleValue = 0D;
            this.textDocDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocDic.Location = new System.Drawing.Point(213, 380);
            this.textDocDic.Name = "textDocDic";
            this.textDocDic.Size = new System.Drawing.Size(140, 26);
            this.textDocDic.TabIndex = 419;
            this.textDocDic.Text = "0.00";
            // 
            // textDocNov
            // 
            this.textDocNov.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocNov.DoubleValue = 0D;
            this.textDocNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocNov.Location = new System.Drawing.Point(213, 351);
            this.textDocNov.Name = "textDocNov";
            this.textDocNov.Size = new System.Drawing.Size(140, 26);
            this.textDocNov.TabIndex = 418;
            this.textDocNov.Text = "0.00";
            // 
            // textDocOct
            // 
            this.textDocOct.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocOct.DoubleValue = 0D;
            this.textDocOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocOct.Location = new System.Drawing.Point(213, 322);
            this.textDocOct.Name = "textDocOct";
            this.textDocOct.Size = new System.Drawing.Size(140, 26);
            this.textDocOct.TabIndex = 417;
            this.textDocOct.Text = "0.00";
            // 
            // textDocSep
            // 
            this.textDocSep.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocSep.DoubleValue = 0D;
            this.textDocSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocSep.Location = new System.Drawing.Point(213, 293);
            this.textDocSep.Name = "textDocSep";
            this.textDocSep.Size = new System.Drawing.Size(140, 26);
            this.textDocSep.TabIndex = 416;
            this.textDocSep.Text = "0.00";
            // 
            // textDocAgo
            // 
            this.textDocAgo.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocAgo.DoubleValue = 0D;
            this.textDocAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocAgo.Location = new System.Drawing.Point(213, 264);
            this.textDocAgo.Name = "textDocAgo";
            this.textDocAgo.Size = new System.Drawing.Size(140, 26);
            this.textDocAgo.TabIndex = 415;
            this.textDocAgo.Text = "0.00";
            // 
            // textDocJul
            // 
            this.textDocJul.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocJul.DoubleValue = 0D;
            this.textDocJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocJul.Location = new System.Drawing.Point(213, 235);
            this.textDocJul.Name = "textDocJul";
            this.textDocJul.Size = new System.Drawing.Size(140, 26);
            this.textDocJul.TabIndex = 414;
            this.textDocJul.Text = "0.00";
            // 
            // textDocJun
            // 
            this.textDocJun.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocJun.DoubleValue = 0D;
            this.textDocJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocJun.Location = new System.Drawing.Point(213, 206);
            this.textDocJun.Name = "textDocJun";
            this.textDocJun.Size = new System.Drawing.Size(140, 26);
            this.textDocJun.TabIndex = 413;
            this.textDocJun.Text = "0.00";
            // 
            // textDocMay
            // 
            this.textDocMay.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocMay.DoubleValue = 0D;
            this.textDocMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocMay.Location = new System.Drawing.Point(213, 177);
            this.textDocMay.Name = "textDocMay";
            this.textDocMay.Size = new System.Drawing.Size(140, 26);
            this.textDocMay.TabIndex = 412;
            this.textDocMay.Text = "0.00";
            // 
            // textDocAbr
            // 
            this.textDocAbr.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocAbr.DoubleValue = 0D;
            this.textDocAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocAbr.Location = new System.Drawing.Point(213, 148);
            this.textDocAbr.Name = "textDocAbr";
            this.textDocAbr.Size = new System.Drawing.Size(140, 26);
            this.textDocAbr.TabIndex = 411;
            this.textDocAbr.Text = "0.00";
            // 
            // textDocMar
            // 
            this.textDocMar.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocMar.DoubleValue = 0D;
            this.textDocMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocMar.Location = new System.Drawing.Point(213, 119);
            this.textDocMar.Name = "textDocMar";
            this.textDocMar.Size = new System.Drawing.Size(140, 26);
            this.textDocMar.TabIndex = 410;
            this.textDocMar.Text = "0.00";
            // 
            // textDocFeb
            // 
            this.textDocFeb.BeforeTouchSize = new System.Drawing.Size(66, 22);
            this.textDocFeb.DoubleValue = 0D;
            this.textDocFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocFeb.Location = new System.Drawing.Point(213, 90);
            this.textDocFeb.Name = "textDocFeb";
            this.textDocFeb.Size = new System.Drawing.Size(140, 26);
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
            this.textDocEne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDocEne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textDocEne.Location = new System.Drawing.Point(213, 59);
            this.textDocEne.Name = "textDocEne";
            this.textDocEne.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textDocEne.Size = new System.Drawing.Size(140, 26);
            this.textDocEne.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.textDocEne.TabIndex = 408;
            this.textDocEne.Text = "0.00";
            this.textDocEne.ThemeName = "Office2016White";
            this.textDocEne.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // Sumar
            // 
            this.Sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Sumar.Location = new System.Drawing.Point(753, 423);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(101, 27);
            this.Sumar.TabIndex = 407;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            // 
            // anioDic
            // 
            this.anioDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioDic.FormattingEnabled = true;
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
            "2029"});
            this.anioDic.Location = new System.Drawing.Point(122, 378);
            this.anioDic.Name = "anioDic";
            this.anioDic.Size = new System.Drawing.Size(85, 28);
            this.anioDic.TabIndex = 406;
            // 
            // anioNov
            // 
            this.anioNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioNov.FormattingEnabled = true;
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
            "2029"});
            this.anioNov.Location = new System.Drawing.Point(122, 349);
            this.anioNov.Name = "anioNov";
            this.anioNov.Size = new System.Drawing.Size(85, 28);
            this.anioNov.TabIndex = 405;
            // 
            // anioOct
            // 
            this.anioOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioOct.FormattingEnabled = true;
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
            "2029"});
            this.anioOct.Location = new System.Drawing.Point(122, 320);
            this.anioOct.Name = "anioOct";
            this.anioOct.Size = new System.Drawing.Size(85, 28);
            this.anioOct.TabIndex = 404;
            // 
            // anioSep
            // 
            this.anioSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioSep.FormattingEnabled = true;
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
            "2029"});
            this.anioSep.Location = new System.Drawing.Point(122, 291);
            this.anioSep.Name = "anioSep";
            this.anioSep.Size = new System.Drawing.Size(85, 28);
            this.anioSep.TabIndex = 403;
            // 
            // anioAgo
            // 
            this.anioAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioAgo.FormattingEnabled = true;
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
            "2029"});
            this.anioAgo.Location = new System.Drawing.Point(122, 262);
            this.anioAgo.Name = "anioAgo";
            this.anioAgo.Size = new System.Drawing.Size(85, 28);
            this.anioAgo.TabIndex = 402;
            // 
            // anioJul
            // 
            this.anioJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioJul.FormattingEnabled = true;
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
            "2029"});
            this.anioJul.Location = new System.Drawing.Point(122, 233);
            this.anioJul.Name = "anioJul";
            this.anioJul.Size = new System.Drawing.Size(85, 28);
            this.anioJul.TabIndex = 401;
            // 
            // anioJun
            // 
            this.anioJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioJun.FormattingEnabled = true;
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
            "2029"});
            this.anioJun.Location = new System.Drawing.Point(122, 204);
            this.anioJun.Name = "anioJun";
            this.anioJun.Size = new System.Drawing.Size(85, 28);
            this.anioJun.TabIndex = 400;
            // 
            // anioMay
            // 
            this.anioMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioMay.FormattingEnabled = true;
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
            "2029"});
            this.anioMay.Location = new System.Drawing.Point(122, 175);
            this.anioMay.Name = "anioMay";
            this.anioMay.Size = new System.Drawing.Size(85, 28);
            this.anioMay.TabIndex = 399;
            // 
            // anioAbr
            // 
            this.anioAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioAbr.FormattingEnabled = true;
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
            "2029"});
            this.anioAbr.Location = new System.Drawing.Point(122, 146);
            this.anioAbr.Name = "anioAbr";
            this.anioAbr.Size = new System.Drawing.Size(85, 28);
            this.anioAbr.TabIndex = 398;
            // 
            // anioMar
            // 
            this.anioMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioMar.FormattingEnabled = true;
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
            "2029"});
            this.anioMar.Location = new System.Drawing.Point(122, 117);
            this.anioMar.Name = "anioMar";
            this.anioMar.Size = new System.Drawing.Size(85, 28);
            this.anioMar.TabIndex = 397;
            // 
            // anioFeb
            // 
            this.anioFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioFeb.FormattingEnabled = true;
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
            "2029"});
            this.anioFeb.Location = new System.Drawing.Point(122, 88);
            this.anioFeb.Name = "anioFeb";
            this.anioFeb.Size = new System.Drawing.Size(85, 28);
            this.anioFeb.TabIndex = 396;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label95.Location = new System.Drawing.Point(126, 36);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(42, 20);
            this.label95.TabIndex = 395;
            this.label95.Text = "Año:";
            // 
            // anioEne
            // 
            this.anioEne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioEne.FormattingEnabled = true;
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
            "2029"});
            this.anioEne.Location = new System.Drawing.Point(122, 59);
            this.anioEne.Name = "anioEne";
            this.anioEne.Size = new System.Drawing.Size(85, 28);
            this.anioEne.TabIndex = 394;
            // 
            // comboBoxDic
            // 
            this.comboBoxDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDic.FormattingEnabled = true;
            this.comboBoxDic.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboBoxDic.Location = new System.Drawing.Point(359, 378);
            this.comboBoxDic.Name = "comboBoxDic";
            this.comboBoxDic.Size = new System.Drawing.Size(128, 28);
            this.comboBoxDic.TabIndex = 393;
            // 
            // comboNov
            // 
            this.comboNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNov.FormattingEnabled = true;
            this.comboNov.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboNov.Location = new System.Drawing.Point(359, 349);
            this.comboNov.Name = "comboNov";
            this.comboNov.Size = new System.Drawing.Size(128, 28);
            this.comboNov.TabIndex = 392;
            // 
            // comboOct
            // 
            this.comboOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOct.FormattingEnabled = true;
            this.comboOct.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboOct.Location = new System.Drawing.Point(359, 320);
            this.comboOct.Name = "comboOct";
            this.comboOct.Size = new System.Drawing.Size(128, 28);
            this.comboOct.TabIndex = 391;
            // 
            // comboSep
            // 
            this.comboSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSep.FormattingEnabled = true;
            this.comboSep.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboSep.Location = new System.Drawing.Point(359, 291);
            this.comboSep.Name = "comboSep";
            this.comboSep.Size = new System.Drawing.Size(128, 28);
            this.comboSep.TabIndex = 390;
            // 
            // comboAgo
            // 
            this.comboAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAgo.FormattingEnabled = true;
            this.comboAgo.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboAgo.Location = new System.Drawing.Point(359, 262);
            this.comboAgo.Name = "comboAgo";
            this.comboAgo.Size = new System.Drawing.Size(128, 28);
            this.comboAgo.TabIndex = 389;
            // 
            // comboJul
            // 
            this.comboJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboJul.FormattingEnabled = true;
            this.comboJul.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboJul.Location = new System.Drawing.Point(359, 233);
            this.comboJul.Name = "comboJul";
            this.comboJul.Size = new System.Drawing.Size(128, 28);
            this.comboJul.TabIndex = 388;
            // 
            // comboJun
            // 
            this.comboJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboJun.FormattingEnabled = true;
            this.comboJun.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboJun.Location = new System.Drawing.Point(359, 204);
            this.comboJun.Name = "comboJun";
            this.comboJun.Size = new System.Drawing.Size(128, 28);
            this.comboJun.TabIndex = 387;
            // 
            // comboMay
            // 
            this.comboMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMay.FormattingEnabled = true;
            this.comboMay.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboMay.Location = new System.Drawing.Point(359, 175);
            this.comboMay.Name = "comboMay";
            this.comboMay.Size = new System.Drawing.Size(128, 28);
            this.comboMay.TabIndex = 386;
            // 
            // comboAbr
            // 
            this.comboAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAbr.FormattingEnabled = true;
            this.comboAbr.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboAbr.Location = new System.Drawing.Point(359, 146);
            this.comboAbr.Name = "comboAbr";
            this.comboAbr.Size = new System.Drawing.Size(128, 28);
            this.comboAbr.TabIndex = 385;
            // 
            // comboMar
            // 
            this.comboMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMar.FormattingEnabled = true;
            this.comboMar.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboMar.Location = new System.Drawing.Point(359, 117);
            this.comboMar.Name = "comboMar";
            this.comboMar.Size = new System.Drawing.Size(128, 28);
            this.comboMar.TabIndex = 384;
            // 
            // comboFeb
            // 
            this.comboFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFeb.FormattingEnabled = true;
            this.comboFeb.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboFeb.Location = new System.Drawing.Point(359, 88);
            this.comboFeb.Name = "comboFeb";
            this.comboFeb.Size = new System.Drawing.Size(128, 28);
            this.comboFeb.TabIndex = 383;
            // 
            // comboEne
            // 
            this.comboEne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEne.FormattingEnabled = true;
            this.comboEne.Items.AddRange(new object[] {
            "MN",
            "USD",
            " "});
            this.comboEne.Location = new System.Drawing.Point(359, 57);
            this.comboEne.Name = "comboEne";
            this.comboEne.Size = new System.Drawing.Size(128, 28);
            this.comboEne.TabIndex = 382;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label94.Location = new System.Drawing.Point(501, 36);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(165, 20);
            this.label94.TabIndex = 381;
            this.label94.Text = "Información Adicional:";
            this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEne
            // 
            this.textBoxEne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEne.Location = new System.Drawing.Point(502, 59);
            this.textBoxEne.Name = "textBoxEne";
            this.textBoxEne.Size = new System.Drawing.Size(352, 26);
            this.textBoxEne.TabIndex = 369;
            this.textBoxEne.Text = " ";
            // 
            // textBoxOct
            // 
            this.textBoxOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOct.Location = new System.Drawing.Point(502, 320);
            this.textBoxOct.Name = "textBoxOct";
            this.textBoxOct.Size = new System.Drawing.Size(352, 26);
            this.textBoxOct.TabIndex = 377;
            this.textBoxOct.Text = " ";
            // 
            // textBoxJul
            // 
            this.textBoxJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJul.Location = new System.Drawing.Point(502, 233);
            this.textBoxJul.Name = "textBoxJul";
            this.textBoxJul.Size = new System.Drawing.Size(352, 26);
            this.textBoxJul.TabIndex = 376;
            this.textBoxJul.Text = " ";
            // 
            // textBoxAbr
            // 
            this.textBoxAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbr.Location = new System.Drawing.Point(502, 146);
            this.textBoxAbr.Name = "textBoxAbr";
            this.textBoxAbr.Size = new System.Drawing.Size(352, 26);
            this.textBoxAbr.TabIndex = 371;
            this.textBoxAbr.Text = " ";
            // 
            // textBoxMar
            // 
            this.textBoxMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMar.Location = new System.Drawing.Point(502, 117);
            this.textBoxMar.Name = "textBoxMar";
            this.textBoxMar.Size = new System.Drawing.Size(352, 26);
            this.textBoxMar.TabIndex = 372;
            this.textBoxMar.Text = " ";
            // 
            // textBoxNov
            // 
            this.textBoxNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNov.Location = new System.Drawing.Point(502, 349);
            this.textBoxNov.Name = "textBoxNov";
            this.textBoxNov.Size = new System.Drawing.Size(352, 26);
            this.textBoxNov.TabIndex = 379;
            this.textBoxNov.Text = " ";
            // 
            // textBoxAgo
            // 
            this.textBoxAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgo.Location = new System.Drawing.Point(502, 262);
            this.textBoxAgo.Name = "textBoxAgo";
            this.textBoxAgo.Size = new System.Drawing.Size(352, 26);
            this.textBoxAgo.TabIndex = 374;
            this.textBoxAgo.Text = " ";
            // 
            // textBoxDic
            // 
            this.textBoxDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDic.Location = new System.Drawing.Point(502, 378);
            this.textBoxDic.Name = "textBoxDic";
            this.textBoxDic.Size = new System.Drawing.Size(352, 26);
            this.textBoxDic.TabIndex = 380;
            this.textBoxDic.Text = " ";
            // 
            // textBoxMay
            // 
            this.textBoxMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMay.Location = new System.Drawing.Point(502, 175);
            this.textBoxMay.Name = "textBoxMay";
            this.textBoxMay.Size = new System.Drawing.Size(352, 26);
            this.textBoxMay.TabIndex = 375;
            this.textBoxMay.Text = " ";
            // 
            // textBoxSep
            // 
            this.textBoxSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSep.Location = new System.Drawing.Point(502, 291);
            this.textBoxSep.Name = "textBoxSep";
            this.textBoxSep.Size = new System.Drawing.Size(352, 26);
            this.textBoxSep.TabIndex = 378;
            this.textBoxSep.Text = " ";
            // 
            // textBoxFeb
            // 
            this.textBoxFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeb.Location = new System.Drawing.Point(502, 88);
            this.textBoxFeb.Name = "textBoxFeb";
            this.textBoxFeb.Size = new System.Drawing.Size(352, 26);
            this.textBoxFeb.TabIndex = 370;
            this.textBoxFeb.Text = " ";
            // 
            // textBoxJun
            // 
            this.textBoxJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJun.Location = new System.Drawing.Point(502, 204);
            this.textBoxJun.Name = "textBoxJun";
            this.textBoxJun.Size = new System.Drawing.Size(352, 26);
            this.textBoxJun.TabIndex = 373;
            this.textBoxJun.Text = " ";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label93.Location = new System.Drawing.Point(358, 36);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(55, 20);
            this.label93.TabIndex = 368;
            this.label93.Text = "Divisa:";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facturadoDic
            // 
            this.facturadoDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoDic.FormattingEnabled = true;
            this.facturadoDic.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoDic.Location = new System.Drawing.Point(5, 378);
            this.facturadoDic.Name = "facturadoDic";
            this.facturadoDic.Size = new System.Drawing.Size(111, 28);
            this.facturadoDic.TabIndex = 367;
            // 
            // facturadoNov
            // 
            this.facturadoNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoNov.FormattingEnabled = true;
            this.facturadoNov.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoNov.Location = new System.Drawing.Point(5, 349);
            this.facturadoNov.Name = "facturadoNov";
            this.facturadoNov.Size = new System.Drawing.Size(111, 28);
            this.facturadoNov.TabIndex = 366;
            // 
            // facturadoOct
            // 
            this.facturadoOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoOct.FormattingEnabled = true;
            this.facturadoOct.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoOct.Location = new System.Drawing.Point(5, 320);
            this.facturadoOct.Name = "facturadoOct";
            this.facturadoOct.Size = new System.Drawing.Size(111, 28);
            this.facturadoOct.TabIndex = 365;
            // 
            // facturadoSep
            // 
            this.facturadoSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoSep.FormattingEnabled = true;
            this.facturadoSep.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoSep.Location = new System.Drawing.Point(5, 291);
            this.facturadoSep.Name = "facturadoSep";
            this.facturadoSep.Size = new System.Drawing.Size(111, 28);
            this.facturadoSep.TabIndex = 364;
            // 
            // facturadoAgo
            // 
            this.facturadoAgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoAgo.FormattingEnabled = true;
            this.facturadoAgo.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoAgo.Location = new System.Drawing.Point(5, 262);
            this.facturadoAgo.Name = "facturadoAgo";
            this.facturadoAgo.Size = new System.Drawing.Size(111, 28);
            this.facturadoAgo.TabIndex = 363;
            // 
            // facturadoJul
            // 
            this.facturadoJul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoJul.FormattingEnabled = true;
            this.facturadoJul.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoJul.Location = new System.Drawing.Point(5, 233);
            this.facturadoJul.Name = "facturadoJul";
            this.facturadoJul.Size = new System.Drawing.Size(111, 28);
            this.facturadoJul.TabIndex = 362;
            // 
            // facturadoJun
            // 
            this.facturadoJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoJun.FormattingEnabled = true;
            this.facturadoJun.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoJun.Location = new System.Drawing.Point(5, 204);
            this.facturadoJun.Name = "facturadoJun";
            this.facturadoJun.Size = new System.Drawing.Size(111, 28);
            this.facturadoJun.TabIndex = 361;
            // 
            // facturadoMay
            // 
            this.facturadoMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoMay.FormattingEnabled = true;
            this.facturadoMay.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoMay.Location = new System.Drawing.Point(5, 175);
            this.facturadoMay.Name = "facturadoMay";
            this.facturadoMay.Size = new System.Drawing.Size(111, 28);
            this.facturadoMay.TabIndex = 360;
            // 
            // facturadoAbr
            // 
            this.facturadoAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoAbr.FormattingEnabled = true;
            this.facturadoAbr.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoAbr.Location = new System.Drawing.Point(5, 146);
            this.facturadoAbr.Name = "facturadoAbr";
            this.facturadoAbr.Size = new System.Drawing.Size(111, 28);
            this.facturadoAbr.TabIndex = 359;
            // 
            // facturadoMar
            // 
            this.facturadoMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoMar.FormattingEnabled = true;
            this.facturadoMar.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoMar.Location = new System.Drawing.Point(5, 117);
            this.facturadoMar.Name = "facturadoMar";
            this.facturadoMar.Size = new System.Drawing.Size(111, 28);
            this.facturadoMar.TabIndex = 358;
            // 
            // facturadoFeb
            // 
            this.facturadoFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoFeb.FormattingEnabled = true;
            this.facturadoFeb.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoFeb.Location = new System.Drawing.Point(5, 88);
            this.facturadoFeb.Name = "facturadoFeb";
            this.facturadoFeb.Size = new System.Drawing.Size(111, 28);
            this.facturadoFeb.TabIndex = 357;
            // 
            // facturadoEne
            // 
            this.facturadoEne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturadoEne.FormattingEnabled = true;
            this.facturadoEne.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            " "});
            this.facturadoEne.Location = new System.Drawing.Point(5, 59);
            this.facturadoEne.Name = "facturadoEne";
            this.facturadoEne.Size = new System.Drawing.Size(111, 28);
            this.facturadoEne.TabIndex = 356;
            // 
            // c_c_facturas
            // 
            this.c_c_facturas.AutoSize = true;
            this.c_c_facturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_c_facturas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.c_c_facturas.Location = new System.Drawing.Point(368, 480);
            this.c_c_facturas.Name = "c_c_facturas";
            this.c_c_facturas.Size = new System.Drawing.Size(218, 24);
            this.c_c_facturas.TabIndex = 355;
            this.c_c_facturas.Text = "Compensación en facturas";
            this.c_c_facturas.UseVisualStyleBackColor = true;
            // 
            // c_t_bancaria
            // 
            this.c_t_bancaria.AutoSize = true;
            this.c_t_bancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_t_bancaria.ForeColor = System.Drawing.SystemColors.Desktop;
            this.c_t_bancaria.Location = new System.Drawing.Point(155, 479);
            this.c_t_bancaria.Name = "c_t_bancaria";
            this.c_t_bancaria.Size = new System.Drawing.Size(190, 24);
            this.c_t_bancaria.TabIndex = 354;
            this.c_t_bancaria.Text = "Transferencia bancaria";
            this.c_t_bancaria.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label41.Location = new System.Drawing.Point(10, 479);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(121, 20);
            this.label41.TabIndex = 353;
            this.label41.Text = "Forma de pago:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label40.Location = new System.Drawing.Point(6, 426);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(109, 20);
            this.label40.TabIndex = 351;
            this.label40.Text = "Total con IVA:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label51.Location = new System.Drawing.Point(216, 36);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(129, 20);
            this.label51.TabIndex = 350;
            this.label51.Text = "Importe con IVA:";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label50.Location = new System.Drawing.Point(4, 36);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 20);
            this.label50.TabIndex = 337;
            this.label50.Text = "Mes:";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.checkFacturas);
            this.groupBox20.Controls.Add(this.checkPagos);
            this.groupBox20.Controls.Add(this.checkBancaria);
            this.groupBox20.Controls.Add(this.checkProduccion);
            this.groupBox20.Controls.Add(this.metroLabel38);
            this.groupBox20.Controls.Add(this.metroLabel25);
            this.groupBox20.Controls.Add(this.dateTimeMF_hasta);
            this.groupBox20.Controls.Add(this.metroLabel24);
            this.groupBox20.Controls.Add(this.dateTimeMF_desde);
            this.groupBox20.Controls.Add(this.metroLabel23);
            this.groupBox20.Controls.Add(this.porcentajeMF_box);
            this.groupBox20.Controls.Add(this.checkBoxMF);
            this.groupBox20.Controls.Add(this.label37);
            this.groupBox20.Location = new System.Drawing.Point(10, 37);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1163, 105);
            this.groupBox20.TabIndex = 335;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Marketing Fund";
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
            // textCondiciones
            // 
            this.textCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCondiciones.Location = new System.Drawing.Point(9, 770);
            this.textCondiciones.Multiline = true;
            this.textCondiciones.Name = "textCondiciones";
            this.textCondiciones.Size = new System.Drawing.Size(852, 77);
            this.textCondiciones.TabIndex = 270;
            this.textCondiciones.Text = " ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label42.Location = new System.Drawing.Point(6, 745);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(103, 20);
            this.label42.TabIndex = 269;
            this.label42.Text = "Comentarios:";
            // 
            // checkBoxMF
            // 
            this.checkBoxMF.AutoSize = true;
            this.checkBoxMF.Location = new System.Drawing.Point(141, 4);
            this.checkBoxMF.Name = "checkBoxMF";
            this.checkBoxMF.Size = new System.Drawing.Size(26, 15);
            this.checkBoxMF.TabIndex = 359;
            this.checkBoxMF.Text = " ";
            this.checkBoxMF.UseSelectable = true;
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
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(181, 38);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(66, 19);
            this.metroLabel23.TabIndex = 52;
            this.metroLabel23.Text = "De Fecha:";
            // 
            // dateTimeMF_desde
            // 
            this.dateTimeMF_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMF_desde.Location = new System.Drawing.Point(253, 32);
            this.dateTimeMF_desde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeMF_desde.Name = "dateTimeMF_desde";
            this.dateTimeMF_desde.Size = new System.Drawing.Size(95, 29);
            this.dateTimeMF_desde.TabIndex = 361;
            // 
            // dateTimeMF_hasta
            // 
            this.dateTimeMF_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMF_hasta.Location = new System.Drawing.Point(449, 32);
            this.dateTimeMF_hasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeMF_hasta.Name = "dateTimeMF_hasta";
            this.dateTimeMF_hasta.Size = new System.Drawing.Size(95, 29);
            this.dateTimeMF_hasta.TabIndex = 363;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(361, 38);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(82, 19);
            this.metroLabel24.TabIndex = 362;
            this.metroLabel24.Text = "Hasta Fecha:";
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
            // checkPagos
            // 
            this.checkPagos.AutoSize = true;
            this.checkPagos.Location = new System.Drawing.Point(700, 75);
            this.checkPagos.Name = "checkPagos";
            this.checkPagos.Size = new System.Drawing.Size(108, 15);
            this.checkPagos.TabIndex = 366;
            this.checkPagos.Text = "Pagos Emitodos";
            this.checkPagos.UseSelectable = true;
            // 
            // checkFacturas
            // 
            this.checkFacturas.AutoSize = true;
            this.checkFacturas.Location = new System.Drawing.Point(961, 75);
            this.checkFacturas.Name = "checkFacturas";
            this.checkFacturas.Size = new System.Drawing.Size(159, 15);
            this.checkFacturas.TabIndex = 369;
            this.checkFacturas.Text = "Compensación y Facturas";
            this.checkFacturas.UseSelectable = true;
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
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Location = new System.Drawing.Point(843, 40);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(104, 19);
            this.metroLabel38.TabIndex = 367;
            this.metroLabel38.Text = "Forma de Pago:";
            // 
            // generador_OI
            // 
            this.ClientSize = new System.Drawing.Size(1247, 689);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.generar_OI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "generador_OI";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Generador de Ordenes de Inserción";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
            this.ResumeLayout(false);

        }
    }
}
