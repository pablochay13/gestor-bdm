namespace gestor_bdm
{
    partial class menu_media_oi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_media_oi));
            this.oi_esp = new MetroFramework.Controls.MetroTile();
            this.oi_en = new MetroFramework.Controls.MetroTile();
            this.oi_modifica = new MetroFramework.Controls.MetroTile();
            this.oi_consulta = new MetroFramework.Controls.MetroTile();
            this.oi_elimina = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // oi_esp
            // 
            this.oi_esp.ActiveControl = null;
            this.oi_esp.Location = new System.Drawing.Point(23, 91);
            this.oi_esp.Name = "oi_esp";
            this.oi_esp.Size = new System.Drawing.Size(169, 48);
            this.oi_esp.TabIndex = 0;
            this.oi_esp.Text = "Generar OI Español";
            this.oi_esp.UseSelectable = true;
            this.oi_esp.Click += new System.EventHandler(this.oi_esp_Click);
            // 
            // oi_en
            // 
            this.oi_en.ActiveControl = null;
            this.oi_en.Location = new System.Drawing.Point(198, 91);
            this.oi_en.Name = "oi_en";
            this.oi_en.Size = new System.Drawing.Size(169, 48);
            this.oi_en.Style = MetroFramework.MetroColorStyle.Silver;
            this.oi_en.TabIndex = 1;
            this.oi_en.Text = "Generar OI Ingles";
            this.oi_en.UseSelectable = true;
            this.oi_en.Click += new System.EventHandler(this.oi_en_Click);
            // 
            // oi_modifica
            // 
            this.oi_modifica.ActiveControl = null;
            this.oi_modifica.Location = new System.Drawing.Point(373, 91);
            this.oi_modifica.Name = "oi_modifica";
            this.oi_modifica.Size = new System.Drawing.Size(169, 48);
            this.oi_modifica.Style = MetroFramework.MetroColorStyle.Orange;
            this.oi_modifica.TabIndex = 2;
            this.oi_modifica.Text = "OI Modificatoria";
            this.oi_modifica.UseSelectable = true;
            this.oi_modifica.Click += new System.EventHandler(this.oi_modifica_Click);
            // 
            // oi_consulta
            // 
            this.oi_consulta.ActiveControl = null;
            this.oi_consulta.Location = new System.Drawing.Point(112, 145);
            this.oi_consulta.Name = "oi_consulta";
            this.oi_consulta.Size = new System.Drawing.Size(169, 48);
            this.oi_consulta.Style = MetroFramework.MetroColorStyle.Green;
            this.oi_consulta.TabIndex = 3;
            this.oi_consulta.Text = "Consultar OI";
            this.oi_consulta.UseSelectable = true;
            // 
            // oi_elimina
            // 
            this.oi_elimina.ActiveControl = null;
            this.oi_elimina.Location = new System.Drawing.Point(287, 145);
            this.oi_elimina.Name = "oi_elimina";
            this.oi_elimina.Size = new System.Drawing.Size(169, 48);
            this.oi_elimina.Style = MetroFramework.MetroColorStyle.Red;
            this.oi_elimina.TabIndex = 4;
            this.oi_elimina.Text = "Eliminar OI";
            this.oi_elimina.UseSelectable = true;
            // 
            // menu_media_oi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 226);
            this.Controls.Add(this.oi_elimina);
            this.Controls.Add(this.oi_consulta);
            this.Controls.Add(this.oi_modifica);
            this.Controls.Add(this.oi_en);
            this.Controls.Add(this.oi_esp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "menu_media_oi";
            this.Resizable = false;
            this.Text = "Ordenes de Inserción Media";
            this.Load += new System.EventHandler(this.menu_media_oi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile oi_esp;
        private MetroFramework.Controls.MetroTile oi_en;
        private MetroFramework.Controls.MetroTile oi_modifica;
        private MetroFramework.Controls.MetroTile oi_consulta;
        private MetroFramework.Controls.MetroTile oi_elimina;
    }
}