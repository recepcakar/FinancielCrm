namespace FinancielCrm
{
    partial class FrmDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_BillAmount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_fatura = new System.Windows.Forms.Label();
            this.lbl_GelenHavale = new System.Windows.Forms.Label();
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
            this.lbl_Vakif1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_TotalBalance = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BillAmount
            // 
            this.lbl_BillAmount.AutoSize = true;
            this.lbl_BillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BillAmount.ForeColor = System.Drawing.Color.White;
            this.lbl_BillAmount.Location = new System.Drawing.Point(3, 48);
            this.lbl_BillAmount.Name = "lbl_BillAmount";
            this.lbl_BillAmount.Size = new System.Drawing.Size(113, 38);
            this.lbl_BillAmount.TabIndex = 5;
            this.lbl_BillAmount.Text = "0.00 ₺";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel5.Controls.Add(this.lbl_BillAmount);
            this.panel5.Controls.Add(this.lbl_fatura);
            this.panel5.Location = new System.Drawing.Point(425, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 121);
            this.panel5.TabIndex = 8;
            // 
            // lbl_fatura
            // 
            this.lbl_fatura.AutoSize = true;
            this.lbl_fatura.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fatura.Location = new System.Drawing.Point(3, 0);
            this.lbl_fatura.Name = "lbl_fatura";
            this.lbl_fatura.Size = new System.Drawing.Size(89, 24);
            this.lbl_fatura.TabIndex = 3;
            this.lbl_fatura.Text = "Faturalar";
            // 
            // lbl_GelenHavale
            // 
            this.lbl_GelenHavale.AutoSize = true;
            this.lbl_GelenHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GelenHavale.ForeColor = System.Drawing.Color.White;
            this.lbl_GelenHavale.Location = new System.Drawing.Point(3, 48);
            this.lbl_GelenHavale.Name = "lbl_GelenHavale";
            this.lbl_GelenHavale.Size = new System.Drawing.Size(113, 38);
            this.lbl_GelenHavale.TabIndex = 5;
            this.lbl_GelenHavale.Text = "0.00 ₺";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_Banks);
            this.panel1.Controls.Add(this.btn_BillsForm);
            this.panel1.Controls.Add(this.btn_hareket);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_category);
            this.panel1.Controls.Add(this.btn_fatura);
            this.panel1.Location = new System.Drawing.Point(-5, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 459);
            this.panel1.TabIndex = 6;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.FlatAppearance.BorderSize = 3;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.Location = new System.Drawing.Point(17, 267);
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
            this.btn_Banks.Location = new System.Drawing.Point(16, 63);
            this.btn_Banks.Name = "btn_Banks";
            this.btn_Banks.Size = new System.Drawing.Size(159, 45);
            this.btn_Banks.TabIndex = 0;
            this.btn_Banks.Text = "Bankalar";
            this.btn_Banks.UseVisualStyleBackColor = false;
            this.btn_Banks.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_BillsForm
            // 
            this.btn_BillsForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_BillsForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_BillsForm.FlatAppearance.BorderSize = 3;
            this.btn_BillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillsForm.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BillsForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BillsForm.Location = new System.Drawing.Point(16, 165);
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
            this.btn_hareket.Location = new System.Drawing.Point(16, 216);
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
            this.btn_LogOut.Location = new System.Drawing.Point(16, 369);
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
            this.btn_settings.Location = new System.Drawing.Point(16, 318);
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
            this.btn_category.Location = new System.Drawing.Point(16, 12);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(159, 45);
            this.btn_category.TabIndex = 0;
            this.btn_category.Text = "Kategoriler";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_fatura
            // 
            this.btn_fatura.BackColor = System.Drawing.Color.Transparent;
            this.btn_fatura.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fatura.FlatAppearance.BorderSize = 3;
            this.btn_fatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fatura.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fatura.Location = new System.Drawing.Point(16, 114);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(159, 45);
            this.btn_fatura.TabIndex = 0;
            this.btn_fatura.Text = "Faturalar";
            this.btn_fatura.UseVisualStyleBackColor = false;
            this.btn_fatura.Click += new System.EventHandler(this.btn_fatura_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel4.Controls.Add(this.lbl_GelenHavale);
            this.panel4.Controls.Add(this.lbl_Vakif1);
            this.panel4.Location = new System.Drawing.Point(651, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 121);
            this.panel4.TabIndex = 9;
            // 
            // lbl_Vakif1
            // 
            this.lbl_Vakif1.AutoSize = true;
            this.lbl_Vakif1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Vakif1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Vakif1.Location = new System.Drawing.Point(3, 4);
            this.lbl_Vakif1.Name = "lbl_Vakif1";
            this.lbl_Vakif1.Size = new System.Drawing.Size(156, 24);
            this.lbl_Vakif1.TabIndex = 3;
            this.lbl_Vakif1.Text = "Gelen son havale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-5, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 44);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.lbl_TotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(198, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 121);
            this.panel3.TabIndex = 10;
            // 
            // lbl_TotalBalance
            // 
            this.lbl_TotalBalance.AutoSize = true;
            this.lbl_TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TotalBalance.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalBalance.Location = new System.Drawing.Point(3, 48);
            this.lbl_TotalBalance.Name = "lbl_TotalBalance";
            this.lbl_TotalBalance.Size = new System.Drawing.Size(113, 38);
            this.lbl_TotalBalance.TabIndex = 5;
            this.lbl_TotalBalance.Text = "0.00 ₺";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(198, 251);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(329, 212);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "e";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(198, 185);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(329, 60);
            this.panel7.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bankalar ve Para miktarları \r\naşağıdaki grafikte verilmiştir.\r\n";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(533, 251);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(329, 212);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "e";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(533, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(329, 60);
            this.panel6.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(48, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 52);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fatura tutarları ve faturalar \r\naşağıdaki grafikte verilmiştir.\r\n";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(885, 483);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BillAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_fatura;
        private System.Windows.Forms.Label lbl_GelenHavale;
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
        private System.Windows.Forms.Label lbl_Vakif1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_TotalBalance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

