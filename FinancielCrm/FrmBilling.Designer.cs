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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.txt_BillId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Period = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BillTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_Banks = new System.Windows.Forms.Button();
            this.btn_BillsForm = new System.Windows.Forms.Button();
            this.btn_hareket = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_fatura = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_list);
            this.panel2.Controls.Add(this.txt_BillId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Period);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_BillAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_BillTitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 188);
            this.panel2.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_delete.FlatAppearance.BorderSize = 6;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(488, 105);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(192, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Ödeme Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gray;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_update.FlatAppearance.BorderSize = 6;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_update.Location = new System.Drawing.Point(281, 105);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(189, 46);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Ödeme Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gray;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_add.FlatAppearance.BorderSize = 6;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_add.Location = new System.Drawing.Point(488, 27);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(192, 46);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Ödeme Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.Gray;
            this.btn_list.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_list.FlatAppearance.BorderSize = 6;
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_list.Location = new System.Drawing.Point(281, 27);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(189, 46);
            this.btn_list.TabIndex = 2;
            this.btn_list.Text = "Ödeme Listesi";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // txt_BillId
            // 
            this.txt_BillId.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_BillId.Location = new System.Drawing.Point(111, 41);
            this.txt_BillId.Name = "txt_BillId";
            this.txt_BillId.Size = new System.Drawing.Size(154, 22);
            this.txt_BillId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödeme İd :";
            // 
            // txt_Period
            // 
            this.txt_Period.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_Period.Location = new System.Drawing.Point(110, 126);
            this.txt_Period.Name = "txt_Period";
            this.txt_Period.Size = new System.Drawing.Size(154, 22);
            this.txt_Period.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Periyot :";
            // 
            // txt_BillAmount
            // 
            this.txt_BillAmount.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_BillAmount.Location = new System.Drawing.Point(111, 98);
            this.txt_BillAmount.Name = "txt_BillAmount";
            this.txt_BillAmount.Size = new System.Drawing.Size(154, 22);
            this.txt_BillAmount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar :";
            // 
            // txt_BillTitle
            // 
            this.txt_BillTitle.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_BillTitle.Location = new System.Drawing.Point(111, 70);
            this.txt_BillTitle.Name = "txt_BillTitle";
            this.txt_BillTitle.Size = new System.Drawing.Size(154, 22);
            this.txt_BillTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(193, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 292);
            this.dataGridView1.TabIndex = 3;
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
            this.btn_dashboard.Location = new System.Drawing.Point(22, 276);
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
            this.btn_Banks.Location = new System.Drawing.Point(22, 72);
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
            this.btn_BillsForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_BillsForm.FlatAppearance.BorderSize = 3;
            this.btn_BillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillsForm.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BillsForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BillsForm.Location = new System.Drawing.Point(22, 174);
            this.btn_BillsForm.Name = "btn_BillsForm";
            this.btn_BillsForm.Size = new System.Drawing.Size(159, 45);
            this.btn_BillsForm.TabIndex = 0;
            this.btn_BillsForm.Text = "Buradasınız.";
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
            this.btn_hareket.Location = new System.Drawing.Point(22, 225);
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
            this.btn_LogOut.Location = new System.Drawing.Point(22, 378);
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
            this.btn_settings.Location = new System.Drawing.Point(22, 327);
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
            this.btn_category.Location = new System.Drawing.Point(22, 21);
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
            this.btn_fatura.Location = new System.Drawing.Point(22, 123);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(159, 45);
            this.btn_fatura.TabIndex = 0;
            this.btn_fatura.Text = "Faturalar";
            this.btn_fatura.UseVisualStyleBackColor = false;
            this.btn_fatura.Click += new System.EventHandler(this.btn_fatura_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(885, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_BillId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Period;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BillTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_Banks;
        private System.Windows.Forms.Button btn_BillsForm;
        private System.Windows.Forms.Button btn_hareket;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_fatura;
    }
}