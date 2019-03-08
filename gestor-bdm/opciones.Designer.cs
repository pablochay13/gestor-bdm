namespace gestor_bdm
{
    partial class opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filee = new System.Windows.Forms.TextBox();
            this.restoreBD = new System.Windows.Forms.PictureBox();
            this.backupBD = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupBD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Respaldo BD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurar BD";
            // 
            // filee
            // 
            this.filee.Location = new System.Drawing.Point(292, 39);
            this.filee.Name = "filee";
            this.filee.Size = new System.Drawing.Size(23, 27);
            this.filee.TabIndex = 9;
            this.filee.Visible = false;
            // 
            // restoreBD
            // 
            this.restoreBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBD.Image = global::gestor_bdm.Properties.Resources.databaseb;
            this.restoreBD.Location = new System.Drawing.Point(186, 39);
            this.restoreBD.Name = "restoreBD";
            this.restoreBD.Size = new System.Drawing.Size(100, 100);
            this.restoreBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restoreBD.TabIndex = 2;
            this.restoreBD.TabStop = false;
            this.restoreBD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restoreBD_MouseClick);
            // 
            // backupBD
            // 
            this.backupBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupBD.Image = global::gestor_bdm.Properties.Resources.db;
            this.backupBD.Location = new System.Drawing.Point(32, 39);
            this.backupBD.Name = "backupBD";
            this.backupBD.Size = new System.Drawing.Size(100, 100);
            this.backupBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backupBD.TabIndex = 0;
            this.backupBD.TabStop = false;
            this.backupBD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backupBD_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 30);
            this.panel1.TabIndex = 52;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::gestor_bdm.Properties.Resources.error;
            this.close.Location = new System.Drawing.Point(300, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gestor_bdm.Properties.Resources.error;
            this.pictureBox2.Location = new System.Drawing.Point(348, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(123, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "OPCIONES";
            // 
            // opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 172);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restoreBD);
            this.Controls.Add(this.backupBD);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.restoreBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupBD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backupBD;
        private System.Windows.Forms.PictureBox restoreBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}