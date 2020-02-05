namespace gestor_bdm
{
    partial class menu_opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_opciones));
            this.database = new MetroFramework.Controls.MetroTile();
            this.tipo_cambio = new MetroFramework.Controls.MetroTile();
            this.account = new MetroFramework.Controls.MetroTile();
            this.supply = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.close_con = new MetroFramework.Controls.MetroTile();
            this.hotels = new MetroFramework.Controls.MetroTile();
            this.daf = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // database
            // 
            this.database.ActiveControl = null;
            this.database.Location = new System.Drawing.Point(23, 87);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(142, 38);
            this.database.Style = MetroFramework.MetroColorStyle.Lime;
            this.database.TabIndex = 0;
            this.database.Text = "Bases de Datos";
            this.database.UseSelectable = true;
            this.database.UseStyleColors = true;
            this.database.Click += new System.EventHandler(this.database_Click);
            // 
            // tipo_cambio
            // 
            this.tipo_cambio.ActiveControl = null;
            this.tipo_cambio.Location = new System.Drawing.Point(171, 87);
            this.tipo_cambio.Name = "tipo_cambio";
            this.tipo_cambio.Size = new System.Drawing.Size(142, 38);
            this.tipo_cambio.TabIndex = 1;
            this.tipo_cambio.Text = "Tipo de Cambio";
            this.tipo_cambio.UseSelectable = true;
            this.tipo_cambio.Click += new System.EventHandler(this.tipo_cambio_Click);
            // 
            // account
            // 
            this.account.ActiveControl = null;
            this.account.Location = new System.Drawing.Point(319, 87);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(142, 38);
            this.account.Style = MetroFramework.MetroColorStyle.Red;
            this.account.TabIndex = 2;
            this.account.Text = "Accounts Managers";
            this.account.UseSelectable = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // supply
            // 
            this.supply.ActiveControl = null;
            this.supply.Location = new System.Drawing.Point(467, 87);
            this.supply.Name = "supply";
            this.supply.Size = new System.Drawing.Size(142, 38);
            this.supply.Style = MetroFramework.MetroColorStyle.Black;
            this.supply.TabIndex = 3;
            this.supply.Text = "Supplys Managers";
            this.supply.UseSelectable = true;
            this.supply.Click += new System.EventHandler(this.supply_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(467, 131);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(142, 38);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Visible = false;
            // 
            // close_con
            // 
            this.close_con.ActiveControl = null;
            this.close_con.Location = new System.Drawing.Point(319, 131);
            this.close_con.Name = "close_con";
            this.close_con.Size = new System.Drawing.Size(142, 38);
            this.close_con.Style = MetroFramework.MetroColorStyle.Magenta;
            this.close_con.TabIndex = 6;
            this.close_con.Text = "Cerrar Conexión";
            this.close_con.UseSelectable = true;
            this.close_con.Click += new System.EventHandler(this.close_con_Click);
            // 
            // hotels
            // 
            this.hotels.ActiveControl = null;
            this.hotels.Location = new System.Drawing.Point(171, 131);
            this.hotels.Name = "hotels";
            this.hotels.Size = new System.Drawing.Size(142, 38);
            this.hotels.Style = MetroFramework.MetroColorStyle.Orange;
            this.hotels.TabIndex = 5;
            this.hotels.Text = "Hoteles";
            this.hotels.UseSelectable = true;
            this.hotels.Click += new System.EventHandler(this.hotels_Click);
            // 
            // daf
            // 
            this.daf.ActiveControl = null;
            this.daf.Location = new System.Drawing.Point(23, 131);
            this.daf.Name = "daf";
            this.daf.Size = new System.Drawing.Size(142, 38);
            this.daf.Style = MetroFramework.MetroColorStyle.Pink;
            this.daf.TabIndex = 4;
            this.daf.Text = "Ejecutivos DAF";
            this.daf.UseSelectable = true;
            this.daf.Click += new System.EventHandler(this.daf_Click);
            // 
            // menu_opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 196);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.close_con);
            this.Controls.Add(this.hotels);
            this.Controls.Add(this.daf);
            this.Controls.Add(this.supply);
            this.Controls.Add(this.account);
            this.Controls.Add(this.tipo_cambio);
            this.Controls.Add(this.database);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu_opciones";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Menú de opciones";
            this.Load += new System.EventHandler(this.menu_opciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile database;
        private MetroFramework.Controls.MetroTile tipo_cambio;
        private MetroFramework.Controls.MetroTile account;
        private MetroFramework.Controls.MetroTile supply;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile close_con;
        private MetroFramework.Controls.MetroTile hotels;
        private MetroFramework.Controls.MetroTile daf;
    }
}