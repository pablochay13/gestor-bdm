namespace gestor_bdm
{
    partial class clientes_tabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes_tabla));
            this.refresh = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.toExcel = new System.Windows.Forms.Button();
            this.textFind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listaClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSiglasHoteles = new System.Windows.Forms.TextBox();
            this.textRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textIDHanna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHoteles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSiglaHanna = new System.Windows.Forms.TextBox();
            this.textComercial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_comercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_hanna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglas_hanna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla_hoteles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrev_hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(856, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(82, 31);
            this.refresh.TabIndex = 63;
            this.refresh.Text = "Recargar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // find
            // 
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.Location = new System.Drawing.Point(782, 12);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(68, 31);
            this.find.TabIndex = 62;
            this.find.Text = "Buscar";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // toExcel
            // 
            this.toExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toExcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toExcel.Location = new System.Drawing.Point(1036, 12);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(130, 31);
            this.toExcel.TabIndex = 61;
            this.toExcel.Text = "Exportar a excel";
            this.toExcel.UseVisualStyleBackColor = true;
            this.toExcel.Click += new System.EventHandler(this.toExcel_Click);
            // 
            // textFind
            // 
            this.textFind.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFind.Location = new System.Drawing.Point(462, 14);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(314, 26);
            this.textFind.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Busqueda:";
            // 
            // listaClientes
            // 
            this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.region,
            this.razon_social,
            this.nombre_comercial,
            this.id_hanna,
            this.siglas_hanna,
            this.sigla_hoteles,
            this.abrev_hotel});
            this.listaClientes.Location = new System.Drawing.Point(372, 51);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.ReadOnly = true;
            this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClientes.Size = new System.Drawing.Size(794, 440);
            this.listaClientes.TabIndex = 58;
            this.listaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaClientes_CellContentClick);
            this.listaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaClientes_CellContentDoubleClick);
            this.listaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaClientes_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.clean);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.textHoteles);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textSiglaHanna);
            this.groupBox1.Controls.Add(this.textComercial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboRegion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboSiglasHoteles);
            this.groupBox1.Controls.Add(this.textRazon);
            this.groupBox1.Controls.Add(this.textRegion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textIDHanna);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 479);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // comboRegion
            // 
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(112, 56);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(99, 28);
            this.comboRegion.TabIndex = 109;
            this.comboRegion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Región Siglas";
            // 
            // comboSiglasHoteles
            // 
            this.comboSiglasHoteles.Location = new System.Drawing.Point(10, 320);
            this.comboSiglasHoteles.Name = "comboSiglasHoteles";
            this.comboSiglasHoteles.Size = new System.Drawing.Size(329, 26);
            this.comboSiglasHoteles.TabIndex = 107;
            // 
            // textRegion
            // 
            this.textRegion.Location = new System.Drawing.Point(10, 56);
            this.textRegion.Name = "textRegion";
            this.textRegion.Size = new System.Drawing.Size(96, 26);
            this.textRegion.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "Sigla Hoteles";
            // 
            // textIDHanna
            // 
            this.textIDHanna.Location = new System.Drawing.Point(10, 215);
            this.textIDHanna.Name = "textIDHanna";
            this.textIDHanna.Size = new System.Drawing.Size(329, 26);
            this.textIDHanna.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "ID Hanna - ID Maestro";
            // 
            // textRazon
            // 
            this.textRazon.Location = new System.Drawing.Point(10, 108);
            this.textRazon.Name = "textRazon";
            this.textRazon.Size = new System.Drawing.Size(329, 26);
            this.textRazon.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Razón Social";
            // 
            // textHoteles
            // 
            this.textHoteles.Location = new System.Drawing.Point(10, 373);
            this.textHoteles.Name = "textHoteles";
            this.textHoteles.Size = new System.Drawing.Size(329, 26);
            this.textHoteles.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "Abreviatura Hoteles";
            // 
            // textSiglaHanna
            // 
            this.textSiglaHanna.Location = new System.Drawing.Point(10, 267);
            this.textSiglaHanna.Name = "textSiglaHanna";
            this.textSiglaHanna.Size = new System.Drawing.Size(329, 26);
            this.textSiglaHanna.TabIndex = 113;
            // 
            // textComercial
            // 
            this.textComercial.Location = new System.Drawing.Point(10, 160);
            this.textComercial.Name = "textComercial";
            this.textComercial.Size = new System.Drawing.Size(329, 26);
            this.textComercial.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 110;
            this.label3.Text = "Nombre Comercial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 112;
            this.label5.Text = "Siglas Hanna";
            // 
            // delete
            // 
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Location = new System.Drawing.Point(267, 442);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(72, 31);
            this.delete.TabIndex = 117;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // edit
            // 
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.Location = new System.Drawing.Point(201, 442);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(60, 31);
            this.edit.TabIndex = 116;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Location = new System.Drawing.Point(120, 442);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 31);
            this.add.TabIndex = 118;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.Transparent;
            this.clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clean.Location = new System.Drawing.Point(39, 442);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 31);
            this.clean.TabIndex = 119;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(292, 54);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(47, 26);
            this.textId.TabIndex = 120;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // region
            // 
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razón Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // nombre_comercial
            // 
            this.nombre_comercial.HeaderText = "Nombre Comercial";
            this.nombre_comercial.Name = "nombre_comercial";
            this.nombre_comercial.ReadOnly = true;
            // 
            // id_hanna
            // 
            this.id_hanna.HeaderText = "ID Hanna";
            this.id_hanna.Name = "id_hanna";
            this.id_hanna.ReadOnly = true;
            // 
            // siglas_hanna
            // 
            this.siglas_hanna.HeaderText = "Siglas Hanna";
            this.siglas_hanna.Name = "siglas_hanna";
            this.siglas_hanna.ReadOnly = true;
            // 
            // sigla_hoteles
            // 
            this.sigla_hoteles.HeaderText = "Sigla Hotel";
            this.sigla_hoteles.Name = "sigla_hoteles";
            this.sigla_hoteles.ReadOnly = true;
            // 
            // abrev_hotel
            // 
            this.abrev_hotel.HeaderText = "Abrev Hotel";
            this.abrev_hotel.Name = "abrev_hotel";
            this.abrev_hotel.ReadOnly = true;
            // 
            // clientes_tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.find);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.textFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listaClientes);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "clientes_tabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button toExcel;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView listaClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comboSiglasHoteles;
        private System.Windows.Forms.TextBox textRazon;
        private System.Windows.Forms.TextBox textRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textIDHanna;
        private System.Windows.Forms.TextBox textHoteles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSiglaHanna;
        private System.Windows.Forms.TextBox textComercial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_comercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_hanna;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglas_hanna;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla_hoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrev_hotel;
    }
}