namespace random2_1473
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
            this.btnÜret = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblTaktir = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.lblGecen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnÜret
            // 
            this.btnÜret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜret.Location = new System.Drawing.Point(11, 30);
            this.btnÜret.Name = "btnÜret";
            this.btnÜret.Size = new System.Drawing.Size(144, 88);
            this.btnÜret.TabIndex = 0;
            this.btnÜret.Text = "ORTALAMA NOT ÜRET";
            this.btnÜret.UseVisualStyleBackColor = true;
            this.btnÜret.Click += new System.EventHandler(this.btnÜret_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "GEÇME / KALMA DUERUMU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 16;
            this.lbNotlar.Location = new System.Drawing.Point(177, 64);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(256, 164);
            this.lbNotlar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÖRENÇİ NOTLAR";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(174, 237);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(187, 16);
            this.lblKalan.TabIndex = 4;
            this.lblKalan.Text = "KALAN ÖĞRENÇİ SAYISI=";
            // 
            // lblTaktir
            // 
            this.lblTaktir.AutoSize = true;
            this.lblTaktir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaktir.Location = new System.Drawing.Point(174, 326);
            this.lblTaktir.Name = "lblTaktir";
            this.lblTaktir.Size = new System.Drawing.Size(121, 16);
            this.lblTaktir.TabIndex = 5;
            this.lblTaktir.Text = "TAKTİR SAYISI=";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesekkur.Location = new System.Drawing.Point(174, 293);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(138, 16);
            this.lblTesekkur.TabIndex = 6;
            this.lblTesekkur.Text = "TEŞEKÜR SAYISI=";
            // 
            // lblGecen
            // 
            this.lblGecen.AutoSize = true;
            this.lblGecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecen.Location = new System.Drawing.Point(174, 264);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Size = new System.Drawing.Size(173, 16);
            this.lblGecen.TabIndex = 7;
            this.lblGecen.Text = "DÜZ GEÇEN ÖĞRETÇİ=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 364);
            this.Controls.Add(this.lblGecen);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblTaktir);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnÜret);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÜret;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblTaktir;
        private System.Windows.Forms.Label lblTesekkur;
        private System.Windows.Forms.Label lblGecen;
    }
}

