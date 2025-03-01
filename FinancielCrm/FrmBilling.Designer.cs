namespace FinancielCrm
{
    partial class FrmBilling
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_Banks = new System.Windows.Forms.Button();
            this.btn_BillsForm = new System.Windows.Forms.Button();
            this.btn_hareket = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_fatura = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalGider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbox_kategori = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_encok = new System.Windows.Forms.Label();
            this.lbl_tutarCokAz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_Banks);
            this.panel1.Controls.Add(this.btn_BillsForm);
            this.panel1.Controls.Add(this.btn_hareket);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_category);
            this.panel1.Controls.Add(this.btn_fatura);
            this.panel1.Location = new System.Drawing.Point(-4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 483);
            this.panel1.TabIndex = 7;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.BorderSize = 3;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dashboard.Location = new System.Drawing.Point(16, 293);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(159, 45);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_Banks
            // 
            this.btn_Banks.BackColor = System.Drawing.Color.Transparent;
            this.btn_Banks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Banks.FlatAppearance.BorderSize = 3;
            this.btn_Banks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Banks.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Banks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Banks.Location = new System.Drawing.Point(16, 89);
            this.btn_Banks.Name = "btn_Banks";
            this.btn_Banks.Size = new System.Drawing.Size(159, 45);
            this.btn_Banks.TabIndex = 0;
            this.btn_Banks.Text = "Bankalar";
            this.btn_Banks.UseVisualStyleBackColor = false;
            this.btn_Banks.Click += new System.EventHandler(this.btn_Banks_Click);
            // 
            // btn_BillsForm
            // 
            this.btn_BillsForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_BillsForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BillsForm.FlatAppearance.BorderSize = 3;
            this.btn_BillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillsForm.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BillsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BillsForm.Location = new System.Drawing.Point(16, 191);
            this.btn_BillsForm.Name = "btn_BillsForm";
            this.btn_BillsForm.Size = new System.Drawing.Size(159, 45);
            this.btn_BillsForm.TabIndex = 0;
            this.btn_BillsForm.Text = "Giderler";
            this.btn_BillsForm.UseVisualStyleBackColor = false;
            this.btn_BillsForm.Click += new System.EventHandler(this.btn_BillsForm_Click);
            // 
            // btn_hareket
            // 
            this.btn_hareket.BackColor = System.Drawing.Color.Transparent;
            this.btn_hareket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_hareket.FlatAppearance.BorderSize = 3;
            this.btn_hareket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hareket.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hareket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hareket.Location = new System.Drawing.Point(16, 242);
            this.btn_hareket.Name = "btn_hareket";
            this.btn_hareket.Size = new System.Drawing.Size(159, 45);
            this.btn_hareket.TabIndex = 0;
            this.btn_hareket.Text = "Banka Hareketleri";
            this.btn_hareket.UseVisualStyleBackColor = false;
            this.btn_hareket.Click += new System.EventHandler(this.btn_hareket_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 3;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_LogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogOut.Location = new System.Drawing.Point(16, 395);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(159, 45);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "Çıkış Yap";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_settings.FlatAppearance.BorderSize = 3;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_settings.Location = new System.Drawing.Point(16, 344);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(159, 45);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Ayarlar";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.Transparent;
            this.btn_category.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_category.FlatAppearance.BorderSize = 3;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_category.Location = new System.Drawing.Point(16, 38);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(159, 45);
            this.btn_category.TabIndex = 0;
            this.btn_category.Text = "Kategoriler";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_fatura
            // 
            this.btn_fatura.BackColor = System.Drawing.Color.Transparent;
            this.btn_fatura.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fatura.FlatAppearance.BorderSize = 3;
            this.btn_fatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fatura.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fatura.Location = new System.Drawing.Point(16, 140);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(159, 45);
            this.btn_fatura.TabIndex = 0;
            this.btn_fatura.Text = "Faturalar";
            this.btn_fatura.UseVisualStyleBackColor = false;
            this.btn_fatura.Click += new System.EventHandler(this.btn_fatura_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(49)))));
            this.panel4.Controls.Add(this.lbl_TotalGider);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(205, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 115);
            this.panel4.TabIndex = 8;
            // 
            // lbl_TotalGider
            // 
            this.lbl_TotalGider.AutoSize = true;
            this.lbl_TotalGider.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TotalGider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalGider.Location = new System.Drawing.Point(3, 52);
            this.lbl_TotalGider.Name = "lbl_TotalGider";
            this.lbl_TotalGider.Size = new System.Drawing.Size(101, 40);
            this.lbl_TotalGider.TabIndex = 0;
            this.lbl_TotalGider.Text = "0,00 ₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam giderler";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(205, 233);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(349, 225);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(78, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori seç";
            // 
            // cmbbox_kategori
            // 
            this.cmbbox_kategori.FormattingEnabled = true;
            this.cmbbox_kategori.Location = new System.Drawing.Point(82, 38);
            this.cmbbox_kategori.Name = "cmbbox_kategori";
            this.cmbbox_kategori.Size = new System.Drawing.Size(147, 24);
            this.cmbbox_kategori.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giderleri getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmbbox_kategori);
            this.panel2.Location = new System.Drawing.Point(574, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 115);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(205, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 69);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam gider oranalrını aşağıdaki\r\ntablodan görebilirsiniz.";
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.Location = new System.Drawing.Point(58, 12);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(121, 37);
            this.lbl_Kategori.TabIndex = 12;
            this.lbl_Kategori.Text = "Kategori";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(560, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 487);
            this.panel5.TabIndex = 13;
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.Location = new System.Drawing.Point(58, 92);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(82, 37);
            this.lbl_tutar.TabIndex = 12;
            this.lbl_tutar.Text = "Tutar";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panel6.Controls.Add(this.lbl_Kategori);
            this.panel6.Controls.Add(this.lbl_tutar);
            this.panel6.Location = new System.Drawing.Point(576, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 137);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panel7.Controls.Add(this.lbl_encok);
            this.panel7.Controls.Add(this.lbl_tutarCokAz);
            this.panel7.Location = new System.Drawing.Point(576, 321);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 137);
            this.panel7.TabIndex = 14;
            // 
            // lbl_encok
            // 
            this.lbl_encok.AutoSize = true;
            this.lbl_encok.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_encok.Location = new System.Drawing.Point(3, 0);
            this.lbl_encok.Name = "lbl_encok";
            this.lbl_encok.Size = new System.Drawing.Size(173, 21);
            this.lbl_encok.TabIndex = 12;
            this.lbl_encok.Text = "En çok yapılan harcama";
            // 
            // lbl_tutarCokAz
            // 
            this.lbl_tutarCokAz.AutoSize = true;
            this.lbl_tutarCokAz.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutarCokAz.Location = new System.Drawing.Point(3, 85);
            this.lbl_tutarCokAz.Name = "lbl_tutarCokAz";
            this.lbl_tutarCokAz.Size = new System.Drawing.Size(82, 37);
            this.lbl_tutarCokAz.TabIndex = 12;
            this.lbl_tutarCokAz.Text = "Tutar";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 550;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(885, 483);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_Banks;
        private System.Windows.Forms.Button btn_BillsForm;
        private System.Windows.Forms.Button btn_hareket;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_fatura;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TotalGider;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbox_kategori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_encok;
        private System.Windows.Forms.Label lbl_tutarCokAz;
        private System.Windows.Forms.Timer timer1;
    }
}