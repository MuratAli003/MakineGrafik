namespace MakineGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMakine = new System.Windows.Forms.ComboBox();
            this.dtpOlusturBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpOlusturBitis = new System.Windows.Forms.DateTimePicker();
            this.dgwMakine = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCiz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxMakineAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxEkleUretilenMiktar = new System.Windows.Forms.TextBox();
            this.tbxEkleHedefMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEkle = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEkleMakineAd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMakine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makine Seçimi";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // cbxMakine
            // 
            this.cbxMakine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMakine.FormattingEnabled = true;
            this.cbxMakine.Location = new System.Drawing.Point(246, 37);
            this.cbxMakine.Name = "cbxMakine";
            this.cbxMakine.Size = new System.Drawing.Size(223, 28);
            this.cbxMakine.TabIndex = 3;
            this.cbxMakine.SelectedIndexChanged += new System.EventHandler(this.cbxMakine_SelectedIndexChanged);
            // 
            // dtpOlusturBaslangic
            // 
            this.dtpOlusturBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpOlusturBaslangic.Location = new System.Drawing.Point(246, 79);
            this.dtpOlusturBaslangic.Name = "dtpOlusturBaslangic";
            this.dtpOlusturBaslangic.Size = new System.Drawing.Size(223, 27);
            this.dtpOlusturBaslangic.TabIndex = 4;
            // 
            // dtpOlusturBitis
            // 
            this.dtpOlusturBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpOlusturBitis.Location = new System.Drawing.Point(246, 129);
            this.dtpOlusturBitis.Name = "dtpOlusturBitis";
            this.dtpOlusturBitis.Size = new System.Drawing.Size(223, 27);
            this.dtpOlusturBitis.TabIndex = 5;
            // 
            // dgwMakine
            // 
            this.dgwMakine.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwMakine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMakine.Location = new System.Drawing.Point(29, 23);
            this.dgwMakine.Name = "dgwMakine";
            this.dgwMakine.RowHeadersWidth = 51;
            this.dgwMakine.RowTemplate.Height = 24;
            this.dgwMakine.Size = new System.Drawing.Size(605, 219);
            this.dgwMakine.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(667, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Hedef Miktar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Üretilen Miktar";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(612, 219);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // btnCiz
            // 
            this.btnCiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiz.Location = new System.Drawing.Point(331, 165);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(138, 34);
            this.btnCiz.TabIndex = 8;
            this.btnCiz.Text = "Çiz";
            this.btnCiz.UseVisualStyleBackColor = true;
            this.btnCiz.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.dtpOlusturBitis);
            this.groupBox1.Controls.Add(this.btnCiz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxMakine);
            this.groupBox1.Controls.Add(this.dtpOlusturBaslangic);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Grafiği Oluştur";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbxMakineAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 123);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Makine Oluştur";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(368, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Olustur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxMakineAd
            // 
            this.tbxMakineAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMakineAd.Location = new System.Drawing.Point(236, 32);
            this.tbxMakineAd.Multiline = true;
            this.tbxMakineAd.Name = "tbxMakineAd";
            this.tbxMakineAd.Size = new System.Drawing.Size(223, 28);
            this.tbxMakineAd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Makine Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.cbxEkleMakineAd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.tbxEkleUretilenMiktar);
            this.groupBox3.Controls.Add(this.tbxEkleHedefMiktar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpEkle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(667, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 340);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Makine Verisi Ekle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(58, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Makine Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(343, 245);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 38);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Veri Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxEkleUretilenMiktar
            // 
            this.tbxEkleUretilenMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEkleUretilenMiktar.Location = new System.Drawing.Point(236, 134);
            this.tbxEkleUretilenMiktar.Multiline = true;
            this.tbxEkleUretilenMiktar.Name = "tbxEkleUretilenMiktar";
            this.tbxEkleUretilenMiktar.Size = new System.Drawing.Size(223, 28);
            this.tbxEkleUretilenMiktar.TabIndex = 13;
            // 
            // tbxEkleHedefMiktar
            // 
            this.tbxEkleHedefMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEkleHedefMiktar.Location = new System.Drawing.Point(236, 84);
            this.tbxEkleHedefMiktar.Multiline = true;
            this.tbxEkleHedefMiktar.Name = "tbxEkleHedefMiktar";
            this.tbxEkleHedefMiktar.Size = new System.Drawing.Size(223, 28);
            this.tbxEkleHedefMiktar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(58, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(58, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hedef Miktar";
            // 
            // dtpEkle
            // 
            this.dtpEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEkle.Location = new System.Drawing.Point(236, 187);
            this.dtpEkle.Name = "dtpEkle";
            this.dtpEkle.Size = new System.Drawing.Size(223, 27);
            this.dtpEkle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(58, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Üretilen Miktar";
            // 
            // cbxEkleMakineAd
            // 
            this.cbxEkleMakineAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxEkleMakineAd.FormattingEnabled = true;
            this.cbxEkleMakineAd.Location = new System.Drawing.Point(236, 39);
            this.cbxEkleMakineAd.Name = "cbxEkleMakineAd";
            this.cbxEkleMakineAd.Size = new System.Drawing.Size(223, 28);
            this.cbxEkleMakineAd.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1325, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgwMakine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMakine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMakine;
        private System.Windows.Forms.DateTimePicker dtpOlusturBaslangic;
        private System.Windows.Forms.DateTimePicker dtpOlusturBitis;
        private System.Windows.Forms.DataGridView dgwMakine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxMakineAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxEkleUretilenMiktar;
        private System.Windows.Forms.TextBox tbxEkleHedefMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxEkleMakineAd;
    }
}

