﻿namespace WindowsFormsAppLogin
{
    partial class Form_kosarhoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_kosarhoz));
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.button_kosarhoz = new System.Windows.Forms.Button();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.listBox_kosar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_vegosszeg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.Location = new System.Drawing.Point(0, 0);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(173, 450);
            this.listBox_termek.TabIndex = 0;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiválasztott termék:";
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Location = new System.Drawing.Point(208, 64);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.Size = new System.Drawing.Size(166, 20);
            this.textBox_termeknev.TabIndex = 2;
            // 
            // button_kosarhoz
            // 
            this.button_kosarhoz.Location = new System.Drawing.Point(208, 245);
            this.button_kosarhoz.Name = "button_kosarhoz";
            this.button_kosarhoz.Size = new System.Drawing.Size(120, 23);
            this.button_kosarhoz.TabIndex = 3;
            this.button_kosarhoz.Text = "Kosárhoz adás";
            this.button_kosarhoz.UseVisualStyleBackColor = true;
            this.button_kosarhoz.Click += new System.EventHandler(this.button_kosarhoz_Click);
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(208, 166);
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_db.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Készleten db:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Termék Ár:";
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Location = new System.Drawing.Point(208, 114);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.ReadOnly = true;
            this.numericUpDown_ar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ar.TabIndex = 7;
            // 
            // listBox_kosar
            // 
            this.listBox_kosar.FormattingEnabled = true;
            this.listBox_kosar.Location = new System.Drawing.Point(505, 0);
            this.listBox_kosar.Name = "listBox_kosar";
            this.listBox_kosar.Size = new System.Drawing.Size(294, 173);
            this.listBox_kosar.TabIndex = 8;
            this.listBox_kosar.SelectedIndexChanged += new System.EventHandler(this.listBox_kosar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Végösszeg:";
            // 
            // textBox_vegosszeg
            // 
            this.textBox_vegosszeg.Location = new System.Drawing.Point(505, 343);
            this.textBox_vegosszeg.Name = "textBox_vegosszeg";
            this.textBox_vegosszeg.ReadOnly = true;
            this.textBox_vegosszeg.Size = new System.Drawing.Size(123, 20);
            this.textBox_vegosszeg.TabIndex = 10;
            this.textBox_vegosszeg.TextChanged += new System.EventHandler(this.textBox_vegosszeg_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Darabszám";
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(208, 219);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(38, 20);
            this.textBox_db.TabIndex = 12;
            this.textBox_db.TextChanged += new System.EventHandler(this.textBox_db_TextChanged);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(505, 193);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(114, 23);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Kosár törlése";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_kosarhoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_vegosszeg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_kosar);
            this.Controls.Add(this.numericUpDown_ar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_db);
            this.Controls.Add(this.button_kosarhoz);
            this.Controls.Add(this.textBox_termeknev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_kosarhoz";
            this.Text = "Vásárlás";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.Button button_kosarhoz;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.ListBox listBox_kosar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_vegosszeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.Button button_delete;
    }
}