namespace WindowsFormsAlapok
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
            this.label_forrasfaljneve = new System.Windows.Forms.Label();
            this.textBox_forrasfaljneve = new System.Windows.Forms.TextBox();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.textBox_orszagokkeresese = new System.Windows.Forms.TextBox();
            this.textBox_eredemnyfaljneve = new System.Windows.Forms.TextBox();
            this.button_megszamolas = new System.Windows.Forms.Button();
            this.button_kiiras = new System.Windows.Forms.Button();
            this.button_kereses = new System.Windows.Forms.Button();
            this.button_maximumvagyminimum = new System.Windows.Forms.Button();
            this.comboBox_miminumvagymaximum = new System.Windows.Forms.ComboBox();
            this.listBox_Orszagoklista = new System.Windows.Forms.ListBox();
            this.groupBox_mitszamoljunk = new System.Windows.Forms.GroupBox();
            this.radioButton_legfeljebb = new System.Windows.Forms.RadioButton();
            this.radioButton_nagyobbterulet = new System.Windows.Forms.RadioButton();
            this.label_eredmenyfaljneve = new System.Windows.Forms.Label();
            this.label_minimumvagymaximum = new System.Windows.Forms.Label();
            this.label_orszagokkeresese = new System.Windows.Forms.Label();
            this.checkBox_talaltokkijelolese = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_teruletatlag = new System.Windows.Forms.Button();
            this.groupBox_mitszamoljunk.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_forrasfaljneve
            // 
            this.label_forrasfaljneve.AutoSize = true;
            this.label_forrasfaljneve.Location = new System.Drawing.Point(17, 20);
            this.label_forrasfaljneve.Name = "label_forrasfaljneve";
            this.helpProvider1.SetShowHelp(this.label_forrasfaljneve, false);
            this.label_forrasfaljneve.Size = new System.Drawing.Size(79, 13);
            this.label_forrasfaljneve.TabIndex = 0;
            this.label_forrasfaljneve.Text = "Forrásfájl neve:";
            // 
            // textBox_forrasfaljneve
            // 
            this.textBox_forrasfaljneve.Location = new System.Drawing.Point(20, 36);
            this.textBox_forrasfaljneve.Name = "textBox_forrasfaljneve";
            this.helpProvider1.SetShowHelp(this.textBox_forrasfaljneve, true);
            this.textBox_forrasfaljneve.Size = new System.Drawing.Size(189, 20);
            this.textBox_forrasfaljneve.TabIndex = 1;
            this.textBox_forrasfaljneve.TextChanged += new System.EventHandler(this.textBox_forrasfaljneve_TextChanged);
            // 
            // button_betoltes
            // 
            this.button_betoltes.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_betoltes.Location = new System.Drawing.Point(20, 63);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(189, 23);
            this.button_betoltes.TabIndex = 2;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = false;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // textBox_orszagokkeresese
            // 
            this.textBox_orszagokkeresese.Location = new System.Drawing.Point(244, 331);
            this.textBox_orszagokkeresese.Name = "textBox_orszagokkeresese";
            this.textBox_orszagokkeresese.Size = new System.Drawing.Size(189, 20);
            this.textBox_orszagokkeresese.TabIndex = 4;
            this.textBox_orszagokkeresese.TextChanged += new System.EventHandler(this.textBox_orszagokkeresese_TextChanged);
            // 
            // textBox_eredemnyfaljneve
            // 
            this.textBox_eredemnyfaljneve.Location = new System.Drawing.Point(244, 168);
            this.textBox_eredemnyfaljneve.Name = "textBox_eredemnyfaljneve";
            this.textBox_eredemnyfaljneve.Size = new System.Drawing.Size(189, 20);
            this.textBox_eredemnyfaljneve.TabIndex = 5;
            this.textBox_eredemnyfaljneve.TextChanged += new System.EventHandler(this.textBox_eredemnyfaljneve_TextChanged);
            // 
            // button_megszamolas
            // 
            this.button_megszamolas.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_megszamolas.Location = new System.Drawing.Point(244, 122);
            this.button_megszamolas.Name = "button_megszamolas";
            this.button_megszamolas.Size = new System.Drawing.Size(189, 23);
            this.button_megszamolas.TabIndex = 8;
            this.button_megszamolas.Text = "Megszámolás";
            this.button_megszamolas.UseVisualStyleBackColor = false;
            this.button_megszamolas.Click += new System.EventHandler(this.button_megszamolas_Click);
            // 
            // button_kiiras
            // 
            this.button_kiiras.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_kiiras.Location = new System.Drawing.Point(245, 197);
            this.button_kiiras.Name = "button_kiiras";
            this.button_kiiras.Size = new System.Drawing.Size(188, 23);
            this.button_kiiras.TabIndex = 9;
            this.button_kiiras.Text = "Kiírás";
            this.button_kiiras.UseVisualStyleBackColor = false;
            this.button_kiiras.Click += new System.EventHandler(this.button_kiiras_Click);
            // 
            // button_kereses
            // 
            this.button_kereses.BackColor = System.Drawing.Color.Red;
            this.button_kereses.Location = new System.Drawing.Point(244, 380);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(188, 23);
            this.button_kereses.TabIndex = 10;
            this.button_kereses.Text = "Keresés";
            this.button_kereses.UseVisualStyleBackColor = false;
            this.button_kereses.Click += new System.EventHandler(this.button_kereses_Click);
            // 
            // button_maximumvagyminimum
            // 
            this.button_maximumvagyminimum.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_maximumvagyminimum.Location = new System.Drawing.Point(244, 285);
            this.button_maximumvagyminimum.Name = "button_maximumvagyminimum";
            this.button_maximumvagyminimum.Size = new System.Drawing.Size(189, 23);
            this.button_maximumvagyminimum.TabIndex = 11;
            this.button_maximumvagyminimum.Text = "Minimum/ maximum kiválasztása";
            this.button_maximumvagyminimum.UseVisualStyleBackColor = false;
            this.button_maximumvagyminimum.Click += new System.EventHandler(this.button_maximumvagyminimum_Click);
            // 
            // comboBox_miminumvagymaximum
            // 
            this.comboBox_miminumvagymaximum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_miminumvagymaximum.FormattingEnabled = true;
            this.comboBox_miminumvagymaximum.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox_miminumvagymaximum.Location = new System.Drawing.Point(244, 258);
            this.comboBox_miminumvagymaximum.Name = "comboBox_miminumvagymaximum";
            this.comboBox_miminumvagymaximum.Size = new System.Drawing.Size(188, 21);
            this.comboBox_miminumvagymaximum.TabIndex = 12;
            this.comboBox_miminumvagymaximum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox_Orszagoklista
            // 
            this.listBox_Orszagoklista.FormattingEnabled = true;
            this.listBox_Orszagoklista.Location = new System.Drawing.Point(20, 94);
            this.listBox_Orszagoklista.Name = "listBox_Orszagoklista";
            this.listBox_Orszagoklista.Size = new System.Drawing.Size(189, 277);
            this.listBox_Orszagoklista.TabIndex = 13;
            this.listBox_Orszagoklista.SelectedIndexChanged += new System.EventHandler(this.listBox_Orszagoklista_SelectedIndexChanged);
            // 
            // groupBox_mitszamoljunk
            // 
            this.groupBox_mitszamoljunk.Controls.Add(this.radioButton_legfeljebb);
            this.groupBox_mitszamoljunk.Controls.Add(this.radioButton_nagyobbterulet);
            this.groupBox_mitszamoljunk.Location = new System.Drawing.Point(244, 38);
            this.groupBox_mitszamoljunk.Name = "groupBox_mitszamoljunk";
            this.groupBox_mitszamoljunk.Size = new System.Drawing.Size(189, 76);
            this.groupBox_mitszamoljunk.TabIndex = 14;
            this.groupBox_mitszamoljunk.TabStop = false;
            this.groupBox_mitszamoljunk.Text = "Mit számoljunk?";
            // 
            // radioButton_legfeljebb
            // 
            this.radioButton_legfeljebb.AutoSize = true;
            this.radioButton_legfeljebb.Location = new System.Drawing.Point(7, 44);
            this.radioButton_legfeljebb.Name = "radioButton_legfeljebb";
            this.radioButton_legfeljebb.Size = new System.Drawing.Size(150, 17);
            this.radioButton_legfeljebb.TabIndex = 1;
            this.radioButton_legfeljebb.TabStop = true;
            this.radioButton_legfeljebb.Text = "legfeljebb 100.000 területű";
            this.radioButton_legfeljebb.UseVisualStyleBackColor = true;
            this.radioButton_legfeljebb.CheckedChanged += new System.EventHandler(this.radioButton_legfeljebb_CheckedChanged);
            // 
            // radioButton_nagyobbterulet
            // 
            this.radioButton_nagyobbterulet.AutoSize = true;
            this.radioButton_nagyobbterulet.Location = new System.Drawing.Point(7, 20);
            this.radioButton_nagyobbterulet.Name = "radioButton_nagyobbterulet";
            this.radioButton_nagyobbterulet.Size = new System.Drawing.Size(163, 17);
            this.radioButton_nagyobbterulet.TabIndex = 0;
            this.radioButton_nagyobbterulet.TabStop = true;
            this.radioButton_nagyobbterulet.Text = "100.000-nél nagyobb területű";
            this.radioButton_nagyobbterulet.UseVisualStyleBackColor = true;
            this.radioButton_nagyobbterulet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label_eredmenyfaljneve
            // 
            this.label_eredmenyfaljneve.AutoSize = true;
            this.label_eredmenyfaljneve.Location = new System.Drawing.Point(244, 152);
            this.label_eredmenyfaljneve.Name = "label_eredmenyfaljneve";
            this.label_eredmenyfaljneve.Size = new System.Drawing.Size(97, 13);
            this.label_eredmenyfaljneve.TabIndex = 15;
            this.label_eredmenyfaljneve.Text = "Eredményfálj neve:";
            // 
            // label_minimumvagymaximum
            // 
            this.label_minimumvagymaximum.AutoSize = true;
            this.label_minimumvagymaximum.Location = new System.Drawing.Point(244, 233);
            this.label_minimumvagymaximum.Name = "label_minimumvagymaximum";
            this.label_minimumvagymaximum.Size = new System.Drawing.Size(126, 13);
            this.label_minimumvagymaximum.TabIndex = 16;
            this.label_minimumvagymaximum.Text = "Minimum vagy maximum?";
            // 
            // label_orszagokkeresese
            // 
            this.label_orszagokkeresese.AutoSize = true;
            this.label_orszagokkeresese.Location = new System.Drawing.Point(244, 315);
            this.label_orszagokkeresese.Name = "label_orszagokkeresese";
            this.label_orszagokkeresese.Size = new System.Drawing.Size(89, 13);
            this.label_orszagokkeresese.TabIndex = 17;
            this.label_orszagokkeresese.Text = "Ország keresése:";
            // 
            // checkBox_talaltokkijelolese
            // 
            this.checkBox_talaltokkijelolese.AutoSize = true;
            this.checkBox_talaltokkijelolese.Location = new System.Drawing.Point(244, 357);
            this.checkBox_talaltokkijelolese.Name = "checkBox_talaltokkijelolese";
            this.checkBox_talaltokkijelolese.Size = new System.Drawing.Size(164, 17);
            this.checkBox_talaltokkijelolese.TabIndex = 18;
            this.checkBox_talaltokkijelolese.Text = "Találatok kijelölése a listában";
            this.checkBox_talaltokkijelolese.UseVisualStyleBackColor = true;
            this.checkBox_talaltokkijelolese.CheckedChanged += new System.EventHandler(this.checkBox_talaltokkijelolese_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_teruletatlag
            // 
            this.button_teruletatlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_teruletatlag.Location = new System.Drawing.Point(20, 379);
            this.button_teruletatlag.Name = "button_teruletatlag";
            this.button_teruletatlag.Size = new System.Drawing.Size(189, 23);
            this.button_teruletatlag.TabIndex = 19;
            this.button_teruletatlag.Text = "Terület átlag";
            this.button_teruletatlag.UseVisualStyleBackColor = false;
            this.button_teruletatlag.Click += new System.EventHandler(this.button_teruletatlag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.button_teruletatlag);
            this.Controls.Add(this.checkBox_talaltokkijelolese);
            this.Controls.Add(this.label_orszagokkeresese);
            this.Controls.Add(this.label_minimumvagymaximum);
            this.Controls.Add(this.label_eredmenyfaljneve);
            this.Controls.Add(this.groupBox_mitszamoljunk);
            this.Controls.Add(this.listBox_Orszagoklista);
            this.Controls.Add(this.comboBox_miminumvagymaximum);
            this.Controls.Add(this.button_maximumvagyminimum);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.button_kiiras);
            this.Controls.Add(this.button_megszamolas);
            this.Controls.Add(this.textBox_eredemnyfaljneve);
            this.Controls.Add(this.textBox_orszagokkeresese);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.textBox_forrasfaljneve);
            this.Controls.Add(this.label_forrasfaljneve);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Példa Windows Forms Alkalmazás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_mitszamoljunk.ResumeLayout(false);
            this.groupBox_mitszamoljunk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_forrasfaljneve;
        private System.Windows.Forms.TextBox textBox_forrasfaljneve;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.TextBox textBox_orszagokkeresese;
        private System.Windows.Forms.TextBox textBox_eredemnyfaljneve;
        private System.Windows.Forms.Button button_megszamolas;
        private System.Windows.Forms.Button button_kiiras;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.Button button_maximumvagyminimum;
        private System.Windows.Forms.ComboBox comboBox_miminumvagymaximum;
        private System.Windows.Forms.ListBox listBox_Orszagoklista;
        private System.Windows.Forms.GroupBox groupBox_mitszamoljunk;
        private System.Windows.Forms.RadioButton radioButton_legfeljebb;
        private System.Windows.Forms.RadioButton radioButton_nagyobbterulet;
        private System.Windows.Forms.Label label_eredmenyfaljneve;
        private System.Windows.Forms.Label label_minimumvagymaximum;
        private System.Windows.Forms.Label label_orszagokkeresese;
        private System.Windows.Forms.CheckBox checkBox_talaltokkijelolese;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_teruletatlag;
    }
}

