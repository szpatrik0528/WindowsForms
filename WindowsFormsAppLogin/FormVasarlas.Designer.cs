namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_vasarlas = new System.Windows.Forms.Button();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.Location = new System.Drawing.Point(13, 13);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(173, 342);
            this.listBox_termek.TabIndex = 0;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiválasztott termék:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Location = new System.Drawing.Point(219, 249);
            this.button_vasarlas.Name = "button_vasarlas";
            this.button_vasarlas.Size = new System.Drawing.Size(166, 23);
            this.button_vasarlas.TabIndex = 3;
            this.button_vasarlas.Text = "Vásárlás";
            this.button_vasarlas.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(219, 210);
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_db.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Darabszám";
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_db);
            this.Controls.Add(this.button_vasarlas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVasarlas";
            this.Text = "Vásárlás";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_vasarlas;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
        private System.Windows.Forms.Label label2;
    }
}