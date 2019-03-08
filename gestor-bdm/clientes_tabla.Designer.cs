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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inversion_usd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inversion_mxn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mf_paquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reinversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(496, 10);
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
            this.find.Location = new System.Drawing.Point(422, 10);
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
            this.toExcel.Location = new System.Drawing.Point(676, 10);
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
            this.textFind.Location = new System.Drawing.Point(102, 12);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(314, 26);
            this.textFind.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 15);
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
            this.cliente,
            this.marca,
            this.inversion_usd,
            this.inversion_mxn,
            this.mf_paquete,
            this.reinversion,
            this.contacto,
            this.email,
            this.telefono,
            this.tipo});
            this.listaClientes.Location = new System.Drawing.Point(12, 48);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.ReadOnly = true;
            this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClientes.Size = new System.Drawing.Size(794, 534);
            this.listaClientes.TabIndex = 58;
            this.listaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaClientes_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // inversion_usd
            // 
            this.inversion_usd.HeaderText = "Inversion USD";
            this.inversion_usd.Name = "inversion_usd";
            this.inversion_usd.ReadOnly = true;
            // 
            // inversion_mxn
            // 
            this.inversion_mxn.HeaderText = "Inversión MXN";
            this.inversion_mxn.Name = "inversion_mxn";
            this.inversion_mxn.ReadOnly = true;
            // 
            // mf_paquete
            // 
            this.mf_paquete.HeaderText = "MF paquete";
            this.mf_paquete.Name = "mf_paquete";
            this.mf_paquete.ReadOnly = true;
            // 
            // reinversion
            // 
            this.reinversion.HeaderText = "Reinversión";
            this.reinversion.Name = "reinversion";
            this.reinversion.ReadOnly = true;
            // 
            // contacto
            // 
            this.contacto.HeaderText = "Contacto";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // clientes_tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 597);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn inversion_usd;
        private System.Windows.Forms.DataGridViewTextBoxColumn inversion_mxn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mf_paquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn reinversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}