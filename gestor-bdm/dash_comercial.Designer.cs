namespace gestor_bdm
{
    partial class dash_comercial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dash_comercial));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTable = new System.Windows.Forms.Button();
            this.comboTemporada = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBancoPorcentaje = new System.Windows.Forms.TextBox();
            this.textBanco = new System.Windows.Forms.TextBox();
            this.textSell = new System.Windows.Forms.TextBox();
            this.textEstancia = new System.Windows.Forms.TextBox();
            this.textAnticipacion = new System.Windows.Forms.TextBox();
            this.textCanal = new System.Windows.Forms.TextBox();
            this.textShare = new System.Windows.Forms.TextBox();
            this.comboMercado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableDatos = new System.Windows.Forms.DataGridView();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTipoInversion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPais = new System.Windows.Forms.TextBox();
            this.comboPais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_inversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mercado_domestico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.share = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anticipacion_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estancia_promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1249, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1241, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addTable);
            this.panel1.Controls.Add(this.comboTemporada);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBancoPorcentaje);
            this.panel1.Controls.Add(this.textBanco);
            this.panel1.Controls.Add(this.textSell);
            this.panel1.Controls.Add(this.textEstancia);
            this.panel1.Controls.Add(this.textAnticipacion);
            this.panel1.Controls.Add(this.textCanal);
            this.panel1.Controls.Add(this.textShare);
            this.panel1.Controls.Add(this.comboMercado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.clean);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tableDatos);
            this.panel1.Controls.Add(this.comboStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboTipoInversion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboTipoCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textPais);
            this.panel1.Controls.Add(this.comboPais);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboClientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 594);
            this.panel1.TabIndex = 0;
            // 
            // addTable
            // 
            this.addTable.Location = new System.Drawing.Point(1153, 144);
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(75, 27);
            this.addTable.TabIndex = 237;
            this.addTable.Text = "Añadir";
            this.addTable.UseVisualStyleBackColor = true;
            // 
            // comboTemporada
            // 
            this.comboTemporada.ForeColor = System.Drawing.Color.Black;
            this.comboTemporada.FormattingEnabled = true;
            this.comboTemporada.Location = new System.Drawing.Point(446, 107);
            this.comboTemporada.Name = "comboTemporada";
            this.comboTemporada.Size = new System.Drawing.Size(220, 26);
            this.comboTemporada.TabIndex = 236;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(803, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 18);
            this.label15.TabIndex = 235;
            this.label15.Text = "promedio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(803, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 18);
            this.label16.TabIndex = 234;
            this.label16.Text = "Estancia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(693, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 233;
            this.label14.Text = "de compra:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(1042, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 232;
            this.label13.Text = "TC Banco:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(903, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 231;
            this.label12.Text = "Sell rate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(693, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 18);
            this.label11.TabIndex = 230;
            this.label11.Text = "Anticipación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(443, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 229;
            this.label10.Text = "Temporada de venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(304, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 228;
            this.label9.Text = "Canal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(168, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 227;
            this.label8.Text = "Share:";
            // 
            // textBancoPorcentaje
            // 
            this.textBancoPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.textBancoPorcentaje.Location = new System.Drawing.Point(1165, 107);
            this.textBancoPorcentaje.Name = "textBancoPorcentaje";
            this.textBancoPorcentaje.Size = new System.Drawing.Size(63, 24);
            this.textBancoPorcentaje.TabIndex = 226;
            // 
            // textBanco
            // 
            this.textBanco.ForeColor = System.Drawing.Color.Black;
            this.textBanco.Location = new System.Drawing.Point(1045, 107);
            this.textBanco.Name = "textBanco";
            this.textBanco.Size = new System.Drawing.Size(114, 24);
            this.textBanco.TabIndex = 225;
            // 
            // textSell
            // 
            this.textSell.ForeColor = System.Drawing.Color.Black;
            this.textSell.Location = new System.Drawing.Point(906, 107);
            this.textSell.Name = "textSell";
            this.textSell.Size = new System.Drawing.Size(114, 24);
            this.textSell.TabIndex = 224;
            // 
            // textEstancia
            // 
            this.textEstancia.ForeColor = System.Drawing.Color.Black;
            this.textEstancia.Location = new System.Drawing.Point(806, 107);
            this.textEstancia.Name = "textEstancia";
            this.textEstancia.Size = new System.Drawing.Size(72, 24);
            this.textEstancia.TabIndex = 223;
            // 
            // textAnticipacion
            // 
            this.textAnticipacion.ForeColor = System.Drawing.Color.Black;
            this.textAnticipacion.Location = new System.Drawing.Point(696, 107);
            this.textAnticipacion.Name = "textAnticipacion";
            this.textAnticipacion.Size = new System.Drawing.Size(84, 24);
            this.textAnticipacion.TabIndex = 222;
            // 
            // textCanal
            // 
            this.textCanal.ForeColor = System.Drawing.Color.Black;
            this.textCanal.Location = new System.Drawing.Point(307, 107);
            this.textCanal.Name = "textCanal";
            this.textCanal.Size = new System.Drawing.Size(114, 24);
            this.textCanal.TabIndex = 220;
            // 
            // textShare
            // 
            this.textShare.ForeColor = System.Drawing.Color.Black;
            this.textShare.Location = new System.Drawing.Point(171, 107);
            this.textShare.Name = "textShare";
            this.textShare.Size = new System.Drawing.Size(114, 24);
            this.textShare.TabIndex = 219;
            // 
            // comboMercado
            // 
            this.comboMercado.ForeColor = System.Drawing.Color.Black;
            this.comboMercado.FormattingEnabled = true;
            this.comboMercado.Location = new System.Drawing.Point(9, 107);
            this.comboMercado.Name = "comboMercado";
            this.comboMercado.Size = new System.Drawing.Size(142, 26);
            this.comboMercado.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 217;
            this.label7.Text = "Mercado domestico:";
            // 
            // clean
            // 
            this.clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clean.Location = new System.Drawing.Point(9, 556);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(68, 26);
            this.clean.TabIndex = 216;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Location = new System.Drawing.Point(1000, 556);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(68, 26);
            this.add.TabIndex = 215;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Location = new System.Drawing.Point(1144, 556);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 26);
            this.delete.TabIndex = 214;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.Location = new System.Drawing.Point(1074, 556);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(64, 26);
            this.edit.TabIndex = 213;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1219, 75);
            this.textBox1.TabIndex = 212;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 211;
            this.label6.Text = "Comentarios:";
            // 
            // tableDatos
            // 
            this.tableDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.pais,
            this.tipo_cliente,
            this.tipo_inversion,
            this.status,
            this.mercado_domestico,
            this.share,
            this.canal,
            this.temporada_venta,
            this.anticipacion_compra,
            this.estancia_promedio,
            this.sell_rate,
            this.banco,
            this.porcentaje_banco});
            this.tableDatos.Location = new System.Drawing.Point(9, 291);
            this.tableDatos.Name = "tableDatos";
            this.tableDatos.Size = new System.Drawing.Size(1219, 259);
            this.tableDatos.TabIndex = 210;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Activo",
            "Pausado",
            "Cancelado",
            "Finalizado"});
            this.comboStatus.Location = new System.Drawing.Point(1107, 30);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 26);
            this.comboStatus.TabIndex = 209;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1104, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 208;
            this.label5.Text = "Status:";
            // 
            // comboTipoInversion
            // 
            this.comboTipoInversion.ForeColor = System.Drawing.Color.Black;
            this.comboTipoInversion.FormattingEnabled = true;
            this.comboTipoInversion.Location = new System.Drawing.Point(913, 30);
            this.comboTipoInversion.Name = "comboTipoInversion";
            this.comboTipoInversion.Size = new System.Drawing.Size(170, 26);
            this.comboTipoInversion.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(910, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 141;
            this.label4.Text = "Tipo de inversión:";
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.ForeColor = System.Drawing.Color.Black;
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Location = new System.Drawing.Point(715, 30);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(170, 26);
            this.comboTipoCliente.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(712, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tipo de cliente: ";
            // 
            // textPais
            // 
            this.textPais.ForeColor = System.Drawing.Color.Black;
            this.textPais.Location = new System.Drawing.Point(600, 30);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(80, 24);
            this.textPais.TabIndex = 138;
            // 
            // comboPais
            // 
            this.comboPais.ForeColor = System.Drawing.Color.Black;
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(424, 30);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(170, 26);
            this.comboPais.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(421, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 136;
            this.label2.Text = "País*:";
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(9, 30);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(381, 26);
            this.comboClientes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1241, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            // 
            // pais
            // 
            this.pais.HeaderText = "Pais";
            this.pais.Name = "pais";
            // 
            // tipo_cliente
            // 
            this.tipo_cliente.HeaderText = "Tipo de cliente";
            this.tipo_cliente.Name = "tipo_cliente";
            // 
            // tipo_inversion
            // 
            this.tipo_inversion.HeaderText = "Tipo de inversión";
            this.tipo_inversion.Name = "tipo_inversion";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // mercado_domestico
            // 
            this.mercado_domestico.HeaderText = "Mercado domestico";
            this.mercado_domestico.Name = "mercado_domestico";
            // 
            // share
            // 
            this.share.HeaderText = "Share";
            this.share.Name = "share";
            // 
            // canal
            // 
            this.canal.HeaderText = "Canal";
            this.canal.Name = "canal";
            // 
            // temporada_venta
            // 
            this.temporada_venta.HeaderText = "Temporada de venta";
            this.temporada_venta.Name = "temporada_venta";
            // 
            // anticipacion_compra
            // 
            this.anticipacion_compra.HeaderText = "Anticipación de compra";
            this.anticipacion_compra.Name = "anticipacion_compra";
            // 
            // estancia_promedio
            // 
            this.estancia_promedio.HeaderText = "Estancia promedio";
            this.estancia_promedio.Name = "estancia_promedio";
            // 
            // sell_rate
            // 
            this.sell_rate.HeaderText = "Sell Rate";
            this.sell_rate.Name = "sell_rate";
            // 
            // banco
            // 
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            // 
            // porcentaje_banco
            // 
            this.porcentaje_banco.HeaderText = "Porcentaje TC";
            this.porcentaje_banco.Name = "porcentaje_banco";
            // 
            // dash_comercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 636);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dash_comercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Comercial";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboTipoInversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPais;
        private System.Windows.Forms.ComboBox comboPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tableDatos;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBancoPorcentaje;
        private System.Windows.Forms.TextBox textBanco;
        private System.Windows.Forms.TextBox textSell;
        private System.Windows.Forms.TextBox textEstancia;
        private System.Windows.Forms.TextBox textAnticipacion;
        private System.Windows.Forms.TextBox textCanal;
        private System.Windows.Forms.TextBox textShare;
        private System.Windows.Forms.ComboBox comboMercado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTemporada;
        private System.Windows.Forms.Button addTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_inversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn mercado_domestico;
        private System.Windows.Forms.DataGridViewTextBoxColumn share;
        private System.Windows.Forms.DataGridViewTextBoxColumn canal;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn anticipacion_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn estancia_promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_banco;
    }
}