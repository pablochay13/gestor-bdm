namespace gestor_bdm
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.listaUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPasswordR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tPrivilegios = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.limpiarB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.usuario,
            this.password,
            this.correo,
            this.privilegios});
            this.listaUsuarios.Location = new System.Drawing.Point(335, 41);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUsuarios.Size = new System.Drawing.Size(674, 348);
            this.listaUsuarios.TabIndex = 0;
            this.listaUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaUsuarios_MouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // password
            // 
            this.password.HeaderText = "Contraseña";
            this.password.Name = "password";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // privilegios
            // 
            this.privilegios.HeaderText = "Privilegios";
            this.privilegios.Name = "privilegios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(20, 82);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(303, 27);
            this.tNombre.TabIndex = 2;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(20, 134);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(303, 27);
            this.tUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(20, 186);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(303, 27);
            this.tPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // tPasswordR
            // 
            this.tPasswordR.Location = new System.Drawing.Point(20, 238);
            this.tPasswordR.Name = "tPasswordR";
            this.tPasswordR.PasswordChar = '*';
            this.tPasswordR.Size = new System.Drawing.Size(303, 27);
            this.tPasswordR.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir contraseña:";
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(20, 290);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(303, 27);
            this.tCorreo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo:";
            // 
            // tPrivilegios
            // 
            this.tPrivilegios.Location = new System.Drawing.Point(20, 342);
            this.tPrivilegios.Name = "tPrivilegios";
            this.tPrivilegios.Size = new System.Drawing.Size(303, 27);
            this.tPrivilegios.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Privilegios:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(129, 12);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(35, 27);
            this.textId.TabIndex = 34;
            this.textId.Visible = false;
            // 
            // add
            // 
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Location = new System.Drawing.Point(85, 346);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(79, 30);
            this.add.TabIndex = 33;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Location = new System.Drawing.Point(235, 346);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 30);
            this.delete.TabIndex = 32;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.Location = new System.Drawing.Point(170, 346);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(59, 30);
            this.edit.TabIndex = 31;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiarB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Location = new System.Drawing.Point(11, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 391);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // toExcel
            // 
            this.toExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toExcel.Location = new System.Drawing.Point(882, 393);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(127, 27);
            this.toExcel.TabIndex = 56;
            this.toExcel.Text = "Exportar a excel";
            this.toExcel.UseVisualStyleBackColor = true;
            this.toExcel.Click += new System.EventHandler(this.toExcel_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 26);
            this.panel1.TabIndex = 81;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::gestor_bdm.Properties.Resources.error;
            this.close.Location = new System.Drawing.Point(995, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 21);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestor_bdm.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(1253, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 23);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(429, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(166, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "USUARIOS BEST MEDIA";
            // 
            // limpiarB
            // 
            this.limpiarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.limpiarB.Location = new System.Drawing.Point(9, 346);
            this.limpiarB.Name = "limpiarB";
            this.limpiarB.Size = new System.Drawing.Size(71, 30);
            this.limpiarB.TabIndex = 35;
            this.limpiarB.Text = "Limpiar";
            this.limpiarB.UseVisualStyleBackColor = true;
            this.limpiarB.Click += new System.EventHandler(this.limpiarB_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.tPrivilegios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tPasswordR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios Media";
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPasswordR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tPrivilegios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button toExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button limpiarB;
    }
}