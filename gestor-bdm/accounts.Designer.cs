﻿namespace gestor_bdm
{
    partial class accounts
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.comboAccounts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Accounts managers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 30);
            this.panel1.TabIndex = 9;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::gestor_bdm.Properties.Resources.error;
            this.close.Location = new System.Drawing.Point(283, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 17);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // comboAccounts
            // 
            this.comboAccounts.FormattingEnabled = true;
            this.comboAccounts.Location = new System.Drawing.Point(12, 65);
            this.comboAccounts.Name = "comboAccounts";
            this.comboAccounts.Size = new System.Drawing.Size(280, 28);
            this.comboAccounts.TabIndex = 10;
            this.comboAccounts.SelectedIndexChanged += new System.EventHandler(this.comboAccounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecciona account manager:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 136);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(280, 27);
            this.name.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Area:";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(12, 189);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(280, 27);
            this.area.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Correo:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(12, 242);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(280, 27);
            this.mail.TabIndex = 17;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(102, 338);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 27);
            this.id.TabIndex = 18;
            this.id.Visible = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(34, 375);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 31);
            this.add.TabIndex = 19;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(115, 375);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 31);
            this.edit.TabIndex = 20;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(196, 375);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 31);
            this.delete.TabIndex = 21;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Status:";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboStatus.Location = new System.Drawing.Point(12, 304);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(280, 28);
            this.comboStatus.TabIndex = 23;
            // 
            // accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 429);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.id);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAccounts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.accounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboStatus;
    }
}