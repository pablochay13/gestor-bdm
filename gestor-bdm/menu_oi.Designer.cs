namespace gestor_bdm
{
    partial class menu_oi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_oi));
            this.generar = new MetroFramework.Controls.MetroTile();
            this.consultar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.ActiveControl = null;
            this.generar.Location = new System.Drawing.Point(23, 83);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(154, 56);
            this.generar.TabIndex = 0;
            this.generar.Text = "Generar OI";
            this.generar.UseSelectable = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // consultar
            // 
            this.consultar.ActiveControl = null;
            this.consultar.Location = new System.Drawing.Point(183, 83);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(154, 56);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "Consultar OI";
            this.consultar.UseSelectable = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // menu_oi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 160);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.generar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu_oi";
            this.Resizable = false;
            this.Text = "Selecciona una opción";
            this.Load += new System.EventHandler(this.menu_oi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile generar;
        private MetroFramework.Controls.MetroTile consultar;
    }
}