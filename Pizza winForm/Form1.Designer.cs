namespace Pizza_winForm
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
            this.button_betoltes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_faljbetoltes = new System.Windows.Forms.TextBox();
            this.listBox_pizza_menu = new System.Windows.Forms.ListBox();
            this.button_atlagar = new System.Windows.Forms.Button();
            this.groupBox_fizetes = new System.Windows.Forms.GroupBox();
            this.radioButton_kezpenz = new System.Windows.Forms.RadioButton();
            this.radioButton_bankkartya = new System.Windows.Forms.RadioButton();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_hozzaadas = new System.Windows.Forms.Button();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_fizetesmegerosites = new System.Windows.Forms.Button();
            this.listBox_kosar = new System.Windows.Forms.ListBox();
            this.groupBox_fizetes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_betoltes
            // 
            this.button_betoltes.Location = new System.Drawing.Point(16, 56);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(75, 23);
            this.button_betoltes.TabIndex = 0;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizzák betöltése";
            // 
            // textBox_faljbetoltes
            // 
            this.textBox_faljbetoltes.Location = new System.Drawing.Point(16, 30);
            this.textBox_faljbetoltes.Name = "textBox_faljbetoltes";
            this.textBox_faljbetoltes.Size = new System.Drawing.Size(100, 20);
            this.textBox_faljbetoltes.TabIndex = 2;
            // 
            // listBox_pizza_menu
            // 
            this.listBox_pizza_menu.FormattingEnabled = true;
            this.listBox_pizza_menu.Location = new System.Drawing.Point(16, 86);
            this.listBox_pizza_menu.Name = "listBox_pizza_menu";
            this.listBox_pizza_menu.Size = new System.Drawing.Size(206, 264);
            this.listBox_pizza_menu.TabIndex = 3;
            this.listBox_pizza_menu.SelectedIndexChanged += new System.EventHandler(this.listBox_pizza_menu_SelectedIndexChanged);
            // 
            // button_atlagar
            // 
            this.button_atlagar.Location = new System.Drawing.Point(97, 415);
            this.button_atlagar.Name = "button_atlagar";
            this.button_atlagar.Size = new System.Drawing.Size(75, 23);
            this.button_atlagar.TabIndex = 4;
            this.button_atlagar.Text = "Átlagár";
            this.button_atlagar.UseVisualStyleBackColor = true;
            this.button_atlagar.Click += new System.EventHandler(this.button_atalagar);
            // 
            // groupBox_fizetes
            // 
            this.groupBox_fizetes.Controls.Add(this.radioButton_kezpenz);
            this.groupBox_fizetes.Controls.Add(this.radioButton_bankkartya);
            this.groupBox_fizetes.Location = new System.Drawing.Point(240, 30);
            this.groupBox_fizetes.Name = "groupBox_fizetes";
            this.groupBox_fizetes.Size = new System.Drawing.Size(200, 100);
            this.groupBox_fizetes.TabIndex = 5;
            this.groupBox_fizetes.TabStop = false;
            this.groupBox_fizetes.Text = "Mivel szeretne fizetni?";
            // 
            // radioButton_kezpenz
            // 
            this.radioButton_kezpenz.AutoSize = true;
            this.radioButton_kezpenz.Location = new System.Drawing.Point(7, 56);
            this.radioButton_kezpenz.Name = "radioButton_kezpenz";
            this.radioButton_kezpenz.Size = new System.Drawing.Size(66, 17);
            this.radioButton_kezpenz.TabIndex = 1;
            this.radioButton_kezpenz.TabStop = true;
            this.radioButton_kezpenz.Text = "Kézpénz";
            this.radioButton_kezpenz.UseVisualStyleBackColor = true;
            this.radioButton_kezpenz.CheckedChanged += new System.EventHandler(this.radioButton_kezpenz_CheckedChanged);
            // 
            // radioButton_bankkartya
            // 
            this.radioButton_bankkartya.AutoSize = true;
            this.radioButton_bankkartya.Location = new System.Drawing.Point(7, 26);
            this.radioButton_bankkartya.Name = "radioButton_bankkartya";
            this.radioButton_bankkartya.Size = new System.Drawing.Size(79, 17);
            this.radioButton_bankkartya.TabIndex = 0;
            this.radioButton_bankkartya.TabStop = true;
            this.radioButton_bankkartya.Text = "Bankkártya";
            this.radioButton_bankkartya.UseVisualStyleBackColor = true;
            this.radioButton_bankkartya.CheckedChanged += new System.EventHandler(this.radioButton_bankkartya_CheckedChanged);
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.Location = new System.Drawing.Point(240, 149);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(47, 17);
            this.checkBox_szamla.TabIndex = 6;
            this.checkBox_szamla.Text = "Igen";
            this.checkBox_szamla.UseVisualStyleBackColor = true;
            this.checkBox_szamla.CheckedChanged += new System.EventHandler(this.checkBox_szamla_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Szeretne számlát kérni, ha igen jelölje a négyzeten.";
            // 
            // button_hozzaadas
            // 
            this.button_hozzaadas.Location = new System.Drawing.Point(16, 415);
            this.button_hozzaadas.Name = "button_hozzaadas";
            this.button_hozzaadas.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaadas.TabIndex = 9;
            this.button_hozzaadas.Text = "Hozzáadás";
            this.button_hozzaadas.UseVisualStyleBackColor = true;
            this.button_hozzaadas.Click += new System.EventHandler(this.button_hozzaadas_Click);
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(16, 389);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(75, 20);
            this.textBox_db.TabIndex = 10;
            this.textBox_db.TextChanged += new System.EventHandler(this.textBox_db_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adja meg a darabszámot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kosár";
            // 
            // button_fizetesmegerosites
            // 
            this.button_fizetesmegerosites.Location = new System.Drawing.Point(240, 172);
            this.button_fizetesmegerosites.Name = "button_fizetesmegerosites";
            this.button_fizetesmegerosites.Size = new System.Drawing.Size(75, 23);
            this.button_fizetesmegerosites.TabIndex = 13;
            this.button_fizetesmegerosites.Text = "Megerősítés";
            this.button_fizetesmegerosites.UseVisualStyleBackColor = true;
            this.button_fizetesmegerosites.Click += new System.EventHandler(this.button_fizetesmegerosites_Click);
            // 
            // listBox_kosar
            // 
            this.listBox_kosar.FormattingEnabled = true;
            this.listBox_kosar.Location = new System.Drawing.Point(523, 37);
            this.listBox_kosar.Name = "listBox_kosar";
            this.listBox_kosar.Size = new System.Drawing.Size(265, 134);
            this.listBox_kosar.TabIndex = 14;
            this.listBox_kosar.SelectedIndexChanged += new System.EventHandler(this.listBox_kosar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_kosar);
            this.Controls.Add(this.button_fizetesmegerosites);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.button_hozzaadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_szamla);
            this.Controls.Add(this.groupBox_fizetes);
            this.Controls.Add(this.button_atlagar);
            this.Controls.Add(this.listBox_pizza_menu);
            this.Controls.Add(this.textBox_faljbetoltes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_betoltes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_fizetes.ResumeLayout(false);
            this.groupBox_fizetes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_faljbetoltes;
        private System.Windows.Forms.ListBox listBox_pizza_menu;
        private System.Windows.Forms.Button button_atlagar;
        private System.Windows.Forms.GroupBox groupBox_fizetes;
        private System.Windows.Forms.RadioButton radioButton_kezpenz;
        private System.Windows.Forms.RadioButton radioButton_bankkartya;
        private System.Windows.Forms.CheckBox checkBox_szamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_hozzaadas;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_fizetesmegerosites;
        private System.Windows.Forms.ListBox listBox_kosar;
    }
}

