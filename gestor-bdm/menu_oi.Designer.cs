﻿namespace gestor_bdm
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // generar
            // 
            this.generar.ActiveControl = null;
            this.generar.Location = new System.Drawing.Point(187, 78);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(154, 56);
            this.generar.TabIndex = 0;
            this.generar.Text = "Validar OI";
            this.generar.UseSelectable = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // consultar
            // 
            this.consultar.ActiveControl = null;
            this.consultar.Location = new System.Drawing.Point(17, 78);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(154, 56);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "Consultar OI";
            this.consultar.UseSelectable = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(102, 149);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(154, 56);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Generar OI";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // menu_oi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 230);
            this.Controls.Add(this.metroTile1);
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
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}