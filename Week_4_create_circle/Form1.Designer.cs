namespace Week_4_create_circle
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calculateParameter = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alanHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarı çapı giriniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // calculateParameter
            // 
            this.calculateParameter.AutoSize = true;
            this.calculateParameter.BackColor = System.Drawing.Color.Turquoise;
            this.calculateParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculateParameter.Location = new System.Drawing.Point(42, 241);
            this.calculateParameter.Name = "calculateParameter";
            this.calculateParameter.Size = new System.Drawing.Size(299, 89);
            this.calculateParameter.TabIndex = 6;
            this.calculateParameter.Text = "Calculate parameter";
            this.calculateParameter.UseVisualStyleBackColor = false;
            this.calculateParameter.Click += new System.EventHandler(this.calculateParameter_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Turquoise;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(42, 336);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(135, 89);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(42, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 39);
            this.textBox1.TabIndex = 9;
            // 
            // alanHesapla
            // 
            this.alanHesapla.BackColor = System.Drawing.Color.Turquoise;
            this.alanHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alanHesapla.Location = new System.Drawing.Point(42, 146);
            this.alanHesapla.Name = "alanHesapla";
            this.alanHesapla.Size = new System.Drawing.Size(135, 89);
            this.alanHesapla.TabIndex = 10;
            this.alanHesapla.Text = "Alan hesapla";
            this.alanHesapla.UseVisualStyleBackColor = false;
            this.alanHesapla.Click += new System.EventHandler(this.alanHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alanHesapla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculateParameter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calculateParameter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button alanHesapla;
    }
}

