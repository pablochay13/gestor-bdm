﻿namespace gestor_bdm
{
    partial class supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supply));
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSupply = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPais = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.comboCluster = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(229, 404);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 31);
            this.delete.TabIndex = 33;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(138, 404);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(84, 31);
            this.edit.TabIndex = 32;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(46, 404);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 31);
            this.add.TabIndex = 31;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Selecciona supply manager:";
            // 
            // comboSupply
            // 
            this.comboSupply.FormattingEnabled = true;
            this.comboSupply.Location = new System.Drawing.Point(21, 33);
            this.comboSupply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboSupply.Name = "comboSupply";
            this.comboSupply.Size = new System.Drawing.Size(327, 28);
            this.comboSupply.TabIndex = 22;
            this.comboSupply.SelectedIndexChanged += new System.EventHandler(this.comboSupply_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboCluster);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboPais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(338, 324);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // comboPais
            // 
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(10, 111);
            this.comboPais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(314, 28);
            this.comboPais.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Región:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(10, 56);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 26);
            this.name.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(335, 398);
            this.id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(14, 26);
            this.id.TabIndex = 37;
            this.id.Visible = false;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(12, 398);
            this.area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(10, 26);
            this.area.TabIndex = 38;
            this.area.Visible = false;
            // 
            // comboCluster
            // 
            this.comboCluster.FormattingEnabled = true;
            this.comboCluster.Items.AddRange(new object[] {
            "Sureste",
            "Bajio, Centro y Norte de Mexico",
            "Pacifico Mexicano",
            "USA & Caribbean",
            "Senior Supply Manager - Global Account ",
            "Senior Supply Manager Strategic Accounts",
            "G & S Accounts Senior Supply Manager",
            "Senior Supply Manager Destination Services",
            "Senior Manager Theme Resorts and Parks",
            "Supply Management Director Mexico",
            "STETA MARKETING GROUP, S.C.",
            "BDT Travel -  Receptivo - Cancun",
            "Media",
            "Back Office de Coops / Marketing",
            "BDT Travel -  Receptivo - Punta cana"});
            this.comboCluster.Location = new System.Drawing.Point(10, 172);
            this.comboCluster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCluster.Name = "comboCluster";
            this.comboCluster.Size = new System.Drawing.Size(314, 28);
            this.comboCluster.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cluster:";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboStatus.Location = new System.Drawing.Point(10, 285);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(314, 28);
            this.comboStatus.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Status:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(10, 229);
            this.mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(314, 26);
            this.mail.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Correo:";
            // 
            // supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 453);
            this.Controls.Add(this.area);
            this.Controls.Add(this.id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSupply);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "supply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supply Manager";
            this.Load += new System.EventHandler(this.Supply_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSupply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCluster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label5;
    }
}