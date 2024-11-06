namespace Week_5_timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.KronometreBaslık = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.krSalise = new System.Windows.Forms.Label();
            this.Krsaniye = new System.Windows.Forms.Label();
            this.krDakika = new System.Windows.Forms.Label();
            this.krSaat = new System.Windows.Forms.Label();
            this.butonBasla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTarih = new System.Windows.Forms.Label();
            this.TarihSaat = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerKronometre = new System.Windows.Forms.Timer(this.components);
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.KronometreBaslık);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.krSalise);
            this.tabPage1.Controls.Add(this.Krsaniye);
            this.tabPage1.Controls.Add(this.krDakika);
            this.tabPage1.Controls.Add(this.krSaat);
            this.tabPage1.Controls.Add(this.butonBasla);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kronometre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImageKey = "4f15404539020e649202bc75fd009ea6.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(529, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button4, "Kaydet");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1f754403934024c0367d24ec8b771510.png");
            this.ımageList1.Images.SetKeyName(1, "1fc5ab18fa686a4662173482ea8b0618.png");
            this.ımageList1.Images.SetKeyName(2, "4f15404539020e649202bc75fd009ea6.png");
            this.ımageList1.Images.SetKeyName(3, "fd4c6837be5fb2260eb73ae175ab9469.png");
            this.ımageList1.Images.SetKeyName(4, "kisspng-computer-icons-floppy-disk-save-button-5ac25cea9f92c2.8812403915226872106" +
        "536.png");
            // 
            // button3
            // 
            this.button3.ImageKey = "kisspng-computer-icons-floppy-disk-save-button-5ac25cea9f92c2.8812403915226872106" +
    "536.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(243, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button3, "Kaydet");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageKey = "1f754403934024c0367d24ec8b771510.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(167, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 18;
            this.toolTip1.SetToolTip(this.button2, "Yenile");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "1fc5ab18fa686a4662173482ea8b0618.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(91, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button1, "Durdur");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KronometreBaslık
            // 
            this.KronometreBaslık.AutoSize = true;
            this.KronometreBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KronometreBaslık.Location = new System.Drawing.Point(27, 237);
            this.KronometreBaslık.Name = "KronometreBaslık";
            this.KronometreBaslık.Size = new System.Drawing.Size(199, 20);
            this.KronometreBaslık.TabIndex = 16;
            this.KronometreBaslık.Text = "Kronometre Uygulaması";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(382, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 264);
            this.listBox1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(222, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(151, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(68, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = ":";
            // 
            // krSalise
            // 
            this.krSalise.AutoSize = true;
            this.krSalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.krSalise.Location = new System.Drawing.Point(255, 85);
            this.krSalise.Name = "krSalise";
            this.krSalise.Size = new System.Drawing.Size(38, 26);
            this.krSalise.TabIndex = 8;
            this.krSalise.Text = "00";
            // 
            // Krsaniye
            // 
            this.Krsaniye.AutoSize = true;
            this.Krsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Krsaniye.Location = new System.Drawing.Point(172, 85);
            this.Krsaniye.Name = "Krsaniye";
            this.Krsaniye.Size = new System.Drawing.Size(38, 26);
            this.Krsaniye.TabIndex = 7;
            this.Krsaniye.Text = "00";
            // 
            // krDakika
            // 
            this.krDakika.AutoSize = true;
            this.krDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.krDakika.Location = new System.Drawing.Point(96, 85);
            this.krDakika.Name = "krDakika";
            this.krDakika.Size = new System.Drawing.Size(38, 26);
            this.krDakika.TabIndex = 6;
            this.krDakika.Text = "00";
            // 
            // krSaat
            // 
            this.krSaat.AutoSize = true;
            this.krSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.krSaat.Location = new System.Drawing.Point(20, 85);
            this.krSaat.Name = "krSaat";
            this.krSaat.Size = new System.Drawing.Size(38, 26);
            this.krSaat.TabIndex = 5;
            this.krSaat.Text = "00";
            // 
            // butonBasla
            // 
            this.butonBasla.ImageKey = "fd4c6837be5fb2260eb73ae175ab9469.png";
            this.butonBasla.ImageList = this.ımageList1;
            this.butonBasla.Location = new System.Drawing.Point(15, 159);
            this.butonBasla.Name = "butonBasla";
            this.butonBasla.Size = new System.Drawing.Size(70, 70);
            this.butonBasla.TabIndex = 4;
            this.toolTip1.SetToolTip(this.butonBasla, "Başlat");
            this.butonBasla.UseVisualStyleBackColor = true;
            this.butonBasla.Click += new System.EventHandler(this.butonBasla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(247, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(163, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saniye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geri sayım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(17, 349);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(54, 20);
            this.labelTarih.TabIndex = 14;
            this.labelTarih.Text = "Tarih:";
            // 
            // TarihSaat
            // 
            this.TarihSaat.AutoSize = true;
            this.TarihSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihSaat.Location = new System.Drawing.Point(227, 349);
            this.TarihSaat.Name = "TarihSaat";
            this.TarihSaat.Size = new System.Drawing.Size(52, 20);
            this.TarihSaat.TabIndex = 13;
            this.TarihSaat.Text = "Saat:";
            // 
            // timerKronometre
            // 
            this.timerKronometre.Interval = 1;
            this.timerKronometre.Tick += new System.EventHandler(this.timerKronometre_Tick);
            // 
            // timerSaat
            // 
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TarihSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label krSalise;
        private System.Windows.Forms.Label Krsaniye;
        private System.Windows.Forms.Label krDakika;
        private System.Windows.Forms.Label krSaat;
        private System.Windows.Forms.Button butonBasla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label TarihSaat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label KronometreBaslık;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerKronometre;
        private System.Windows.Forms.Timer timerSaat;
    }
}

