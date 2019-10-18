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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel55 = new MetroFramework.Controls.MetroLabel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textCargo_c = new MetroFramework.Controls.MetroTextBox();
            this.textNombre_c = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textCondiciones = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.c_c_facturas = new MetroFramework.Controls.MetroCheckBox();
            this.c_t_bancaria = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel48 = new MetroFramework.Controls.MetroLabel();
            this.Sumar = new MetroFramework.Controls.MetroButton();
            this.sfNumericTextBox1 = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.metroLabel47 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox15 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox16 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.textBoxEne = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel46 = new MetroFramework.Controls.MetroLabel();
            this.comboDic = new MetroFramework.Controls.MetroComboBox();
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
            this.checkFacturas = new MetroFramework.Controls.MetroCheckBox();
            this.checkPagos = new MetroFramework.Controls.MetroCheckBox();
            this.checkBancaria = new MetroFramework.Controls.MetroCheckBox();
            this.checkProduccion = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeMF_hasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.dateTimeMF_desde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.porcentajeMF_box = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.checkBoxMF = new MetroFramework.Controls.MetroCheckBox();
            this.label37 = new System.Windows.Forms.Label();
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
            this.CComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TComercial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.NComercial = new MetroFramework.Controls.MetroTextBox();
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
            this.textFechaCliente = new MetroFramework.Controls.MetroTextBox();
            this.textNombre_m = new MetroFramework.Controls.MetroTextBox();
            this.textCargo_m = new MetroFramework.Controls.MetroTextBox();
            this.textFechaMedia = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox21.SuspendLayout();
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
            this.groupBox21.Controls.Add(this.c_c_facturas);
            this.groupBox21.Controls.Add(this.c_t_bancaria);
            this.groupBox21.Controls.Add(this.metroLabel48);
            this.groupBox21.Controls.Add(this.Sumar);
            this.groupBox21.Controls.Add(this.sfNumericTextBox1);
            this.groupBox21.Controls.Add(this.metroLabel47);
            this.groupBox21.Controls.Add(this.metroTextBox8);
            this.groupBox21.Controls.Add(this.metroTextBox9);
            this.groupBox21.Controls.Add(this.metroTextBox15);
            this.groupBox21.Controls.Add(this.metroTextBox16);
            this.groupBox21.Controls.Add(this.metroTextBox4);
            this.groupBox21.Controls.Add(this.metroTextBox5);
            this.groupBox21.Controls.Add(this.metroTextBox6);
            this.groupBox21.Controls.Add(this.metroTextBox7);
            this.groupBox21.Controls.Add(this.metroTextBox2);
            this.groupBox21.Controls.Add(this.metroTextBox3);
            this.groupBox21.Controls.Add(this.metroTextBox1);
            this.groupBox21.Controls.Add(this.textBoxEne);
            this.groupBox21.Controls.Add(this.metroLabel46);
            this.groupBox21.Controls.Add(this.comboDic);
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
            this.groupBox21.Text = "Marketing Fijo";
            // 
            // c_c_facturas
            // 
            this.c_c_facturas.AutoSize = true;
            this.c_c_facturas.Location = new System.Drawing.Point(610, 537);
            this.c_c_facturas.Name = "c_c_facturas";
            this.c_c_facturas.Size = new System.Drawing.Size(166, 15);
            this.c_c_facturas.TabIndex = 480;
            this.c_c_facturas.Text = "Compensación en Facturas";
            this.c_c_facturas.UseSelectable = true;
            // 
            // c_t_bancaria
            // 
            this.c_t_bancaria.AutoSize = true;
            this.c_t_bancaria.Location = new System.Drawing.Point(449, 534);
            this.c_t_bancaria.Name = "c_t_bancaria";
            this.c_t_bancaria.Size = new System.Drawing.Size(140, 15);
            this.c_t_bancaria.TabIndex = 479;
            this.c_t_bancaria.Text = "Transferencia Bancaria";
            this.c_t_bancaria.UseSelectable = true;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Location = new System.Drawing.Point(339, 530);
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
            // 
            // sfNumericTextBox1
            // 
            this.sfNumericTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfNumericTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sfNumericTextBox1.Location = new System.Drawing.Point(111, 527);
            this.sfNumericTextBox1.Name = "sfNumericTextBox1";
            this.sfNumericTextBox1.Size = new System.Drawing.Size(153, 22);
            this.sfNumericTextBox1.TabIndex = 476;
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
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[] {
        " "};
            this.metroTextBox8.Location = new System.Drawing.Point(627, 450);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox8.TabIndex = 474;
            this.metroTextBox8.Text = " ";
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox9
            // 
            // 
            // 
            // 
            this.metroTextBox9.CustomButton.Image = null;
            this.metroTextBox9.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox9.CustomButton.Name = "";
            this.metroTextBox9.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.CustomButton.TabIndex = 1;
            this.metroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox9.CustomButton.UseSelectable = true;
            this.metroTextBox9.CustomButton.Visible = false;
            this.metroTextBox9.Lines = new string[] {
        " "};
            this.metroTextBox9.Location = new System.Drawing.Point(627, 415);
            this.metroTextBox9.MaxLength = 32767;
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.PasswordChar = '\0';
            this.metroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox9.SelectedText = "";
            this.metroTextBox9.SelectionLength = 0;
            this.metroTextBox9.SelectionStart = 0;
            this.metroTextBox9.ShortcutsEnabled = true;
            this.metroTextBox9.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox9.TabIndex = 473;
            this.metroTextBox9.Text = " ";
            this.metroTextBox9.UseSelectable = true;
            this.metroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox15
            // 
            // 
            // 
            // 
            this.metroTextBox15.CustomButton.Image = null;
            this.metroTextBox15.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox15.CustomButton.Name = "";
            this.metroTextBox15.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox15.CustomButton.TabIndex = 1;
            this.metroTextBox15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox15.CustomButton.UseSelectable = true;
            this.metroTextBox15.CustomButton.Visible = false;
            this.metroTextBox15.Lines = new string[] {
        " "};
            this.metroTextBox15.Location = new System.Drawing.Point(627, 380);
            this.metroTextBox15.MaxLength = 32767;
            this.metroTextBox15.Name = "metroTextBox15";
            this.metroTextBox15.PasswordChar = '\0';
            this.metroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox15.SelectedText = "";
            this.metroTextBox15.SelectionLength = 0;
            this.metroTextBox15.SelectionStart = 0;
            this.metroTextBox15.ShortcutsEnabled = true;
            this.metroTextBox15.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox15.TabIndex = 472;
            this.metroTextBox15.Text = " ";
            this.metroTextBox15.UseSelectable = true;
            this.metroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox15.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox16
            // 
            // 
            // 
            // 
            this.metroTextBox16.CustomButton.Image = null;
            this.metroTextBox16.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox16.CustomButton.Name = "";
            this.metroTextBox16.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox16.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox16.CustomButton.TabIndex = 1;
            this.metroTextBox16.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox16.CustomButton.UseSelectable = true;
            this.metroTextBox16.CustomButton.Visible = false;
            this.metroTextBox16.Lines = new string[] {
        " "};
            this.metroTextBox16.Location = new System.Drawing.Point(627, 345);
            this.metroTextBox16.MaxLength = 32767;
            this.metroTextBox16.Name = "metroTextBox16";
            this.metroTextBox16.PasswordChar = '\0';
            this.metroTextBox16.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox16.SelectedText = "";
            this.metroTextBox16.SelectionLength = 0;
            this.metroTextBox16.SelectionStart = 0;
            this.metroTextBox16.ShortcutsEnabled = true;
            this.metroTextBox16.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox16.TabIndex = 471;
            this.metroTextBox16.Text = " ";
            this.metroTextBox16.UseSelectable = true;
            this.metroTextBox16.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox16.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[] {
        " "};
            this.metroTextBox4.Location = new System.Drawing.Point(627, 310);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox4.TabIndex = 470;
            this.metroTextBox4.Text = " ";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[] {
        " "};
            this.metroTextBox5.Location = new System.Drawing.Point(627, 275);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox5.TabIndex = 469;
            this.metroTextBox5.Text = " ";
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[] {
        " "};
            this.metroTextBox6.Location = new System.Drawing.Point(627, 240);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox6.TabIndex = 468;
            this.metroTextBox6.Text = " ";
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[] {
        " "};
            this.metroTextBox7.Location = new System.Drawing.Point(627, 205);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox7.TabIndex = 467;
            this.metroTextBox7.Text = " ";
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        " "};
            this.metroTextBox2.Location = new System.Drawing.Point(627, 170);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox2.TabIndex = 466;
            this.metroTextBox2.Text = " ";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        " "};
            this.metroTextBox3.Location = new System.Drawing.Point(627, 135);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox3.TabIndex = 465;
            this.metroTextBox3.Text = " ";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        " "};
            this.metroTextBox1.Location = new System.Drawing.Point(627, 100);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(516, 23);
            this.metroTextBox1.TabIndex = 464;
            this.metroTextBox1.Text = " ";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // comboDic
            // 
            this.comboDic.FormattingEnabled = true;
            this.comboDic.ItemHeight = 23;
            this.comboDic.Items.AddRange(new object[] {
            "MXN",
            "USD",
            " "});
            this.comboDic.Location = new System.Drawing.Point(472, 444);
            this.comboDic.Name = "comboDic";
            this.comboDic.Size = new System.Drawing.Size(121, 29);
            this.comboDic.TabIndex = 461;
            this.comboDic.UseSelectable = true;
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
            // dateTimeMF_desde
            // 
            this.dateTimeMF_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMF_desde.Location = new System.Drawing.Point(253, 32);
            this.dateTimeMF_desde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeMF_desde.Name = "dateTimeMF_desde";
            this.dateTimeMF_desde.Size = new System.Drawing.Size(95, 29);
            this.dateTimeMF_desde.TabIndex = 361;
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
            this.checkBoxMF.Location = new System.Drawing.Point(142, 3);
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
            this.mediaPCorreo.Lines = new string[] {
        " "};
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
            this.mediaPCorreo.Text = " ";
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
            this.mediaPTelefono.Lines = new string[] {
        " "};
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
            this.mediaPTelefono.Text = " ";
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
            this.mediaPNombre.Lines = new string[] {
        " "};
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
            this.mediaPNombre.Text = " ";
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
        " "};
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
            this.mediaCTelefono.Text = " ";
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
            this.mediaCNombre.Lines = new string[] {
        " "};
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
            this.mediaCNombre.Text = " ";
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
            this.cxcCorreo.Lines = new string[] {
        " "};
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
            this.cxcCorreo.Text = " ";
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
        " "};
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
            this.cxcTelefono.Text = " ";
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
        " "};
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
            this.cxcNombre.Text = " ";
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
            this.NComercial.TabIndex = 41;
            this.NComercial.Text = " ";
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
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "ID Fiscal:";
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
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1212, 517);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Anexos";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
        " "};
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
            this.textCargo_m.Text = " ";
            this.textCargo_m.UseSelectable = true;
            this.textCargo_m.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textCargo_m.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1036, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // generador_OI
            // 
            this.ClientSize = new System.Drawing.Size(1247, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.generar_OI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "generador_OI";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Generador de Ordenes de Inserción";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
