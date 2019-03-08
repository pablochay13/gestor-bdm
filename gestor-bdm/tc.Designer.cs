namespace gestor_bdm
{
    partial class tc
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.edit = new System.Windows.Forms.Button();
            this.tcPlaneacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tcDiario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(80, 38);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(305, 27);
            this.fecha.TabIndex = 24;
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(284, 215);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(101, 28);
            this.edit.TabIndex = 23;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // tcPlaneacion
            // 
            this.tcPlaneacion.Location = new System.Drawing.Point(15, 173);
            this.tcPlaneacion.Name = "tcPlaneacion";
            this.tcPlaneacion.Size = new System.Drawing.Size(100, 27);
            this.tcPlaneacion.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Planeación Financiera Tipo de Cambio:";
            // 
            // tcDiario
            // 
            this.tcDiario.Location = new System.Drawing.Point(15, 107);
            this.tcDiario.Name = "tcDiario";
            this.tcDiario.Size = new System.Drawing.Size(100, 27);
            this.tcDiario.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Diario Oficial de la Federación Tipo de Cambio:";
            // 
            // textoInicio
            // 
            this.textoInicio.AutoSize = true;
            this.textoInicio.Location = new System.Drawing.Point(11, 43);
            this.textoInicio.Name = "textoInicio";
            this.textoInicio.Size = new System.Drawing.Size(50, 20);
            this.textoInicio.TabIndex = 18;
            this.textoInicio.Text = "Fecha:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 30);
            this.panel1.TabIndex = 17;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::gestor_bdm.Properties.Resources.error;
            this.close.Location = new System.Drawing.Point(389, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 17);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edición tipos de Cambio";
            // 
            // tc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 255);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tcPlaneacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcDiario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoInicio);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox tcPlaneacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcDiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textoInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label3;
    }
}