namespace WindowsFormsAppTagdij
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_tagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_azon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_irszam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_orsz = new System.Windows.Forms.TextBox();
            this.groupBox_muveletek = new System.Windows.Forms.GroupBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            this.groupBox_muveletek.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_tagok
            // 
            this.listBox_tagok.BackColor = System.Drawing.Color.DarkGray;
            this.listBox_tagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_tagok.FormattingEnabled = true;
            this.listBox_tagok.ItemHeight = 20;
            this.listBox_tagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_tagok.Name = "listBox_tagok";
            this.listBox_tagok.Size = new System.Drawing.Size(253, 692);
            this.listBox_tagok.TabIndex = 0;
            this.listBox_tagok.SelectedIndexChanged += new System.EventHandler(this.listBox_tagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_muveletek);
            this.groupBox1.Controls.Add(this.textBox_orsz);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_szulev);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_irszam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_azon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(253, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 692);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott tag";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // textBox_azon
            // 
            this.textBox_azon.Location = new System.Drawing.Point(11, 59);
            this.textBox_azon.Name = "textBox_azon";
            this.textBox_azon.ReadOnly = true;
            this.textBox_azon.Size = new System.Drawing.Size(100, 26);
            this.textBox_azon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(11, 136);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(277, 26);
            this.textBox_nev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Irányítószám";
            // 
            // numericUpDown_irszam
            // 
            this.numericUpDown_irszam.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Location = new System.Drawing.Point(11, 215);
            this.numericUpDown_irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_irszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Name = "numericUpDown_irszam";
            this.numericUpDown_irszam.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_irszam.TabIndex = 5;
            this.numericUpDown_irszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_irszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Születési év";
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(15, 293);
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_szulev.TabIndex = 8;
            this.numericUpDown_szulev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Országkód";
            // 
            // textBox_orsz
            // 
            this.textBox_orsz.Location = new System.Drawing.Point(15, 372);
            this.textBox_orsz.Name = "textBox_orsz";
            this.textBox_orsz.Size = new System.Drawing.Size(100, 26);
            this.textBox_orsz.TabIndex = 10;
            // 
            // groupBox_muveletek
            // 
            this.groupBox_muveletek.Controls.Add(this.button_delete);
            this.groupBox_muveletek.Controls.Add(this.button_update);
            this.groupBox_muveletek.Controls.Add(this.button_insert);
            this.groupBox_muveletek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_muveletek.Location = new System.Drawing.Point(3, 433);
            this.groupBox_muveletek.Name = "groupBox_muveletek";
            this.groupBox_muveletek.Size = new System.Drawing.Size(941, 256);
            this.groupBox_muveletek.TabIndex = 11;
            this.groupBox_muveletek.TabStop = false;
            this.groupBox_muveletek.Text = "Műveletek";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(318, 25);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(282, 37);
            this.button_insert.TabIndex = 0;
            this.button_insert.Text = "Létrehozás";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DarkOrange;
            this.button_update.Location = new System.Drawing.Point(320, 83);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(280, 37);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Modósítás";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Location = new System.Drawing.Point(318, 140);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(280, 37);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_tagok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tagok Nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            this.groupBox_muveletek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_tagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_azon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_irszam;
        private System.Windows.Forms.TextBox textBox_orsz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.GroupBox groupBox_muveletek;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
    }
}

