using FinancielCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancielCrm
{

    public partial class FrmBilling : Form
    {
        int userid;
        FinancielCrmDb1Entities db = new FinancielCrmDb1Entities();
        public FrmBilling(int id)
        {
            userid = id;
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks(userid);
            banks.ShowDialog();
            this.Close();

        }




        private void btn_category_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory(userid);
            category.Show();
            this.Close();

        }

        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks(userid);
            banks.Show();
            this.Close();
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            FrmFaturalarcs fat = new FrmFaturalarcs(userid);
            fat.Show();
            this.Close();
        }

        private void btn_BillsForm_Click(object sender, EventArgs e)
        {

        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            FrmBankaHareket bank = new FrmBankaHareket(userid);
            bank.Show();
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashboard = new FrmDashBoard(userid);
            dashboard.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmAyarlar settings = new FrmAyarlar(userid);
            settings.Show();
            this.Close();

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Devam etmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                // "Evet" seçildiğinde yapılacak işlemler
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbbox_kategori.SelectedValue != null)
            {
                int selectedCategoryId = (int)cmbbox_kategori.SelectedValue; // Doğru dönüşüm

                var valueAmount = db.Spendings
                    .Where(x => x.CategoryId == selectedCategoryId).Sum(x => x.SpendingAmount);
                var CatName = db.Categories.Where(x => x.CategoryId == selectedCategoryId).Select(x => x.CategoryName).FirstOrDefault();

                if (valueAmount != null)
                {
                    lbl_Kategori.Text = CatName;
                    lbl_tutar.Text = valueAmount.ToString() + " ₺";
                }
                else
                {
                    lbl_Kategori.Text = "Harcama Bulunamadı";
                    lbl_tutar.Text = "0 ₺";
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçin!");
            }
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var valuetotalprice = db.Spendings.Sum(x => x.SpendingAmount);
            lbl_TotalGider.Text = valuetotalprice.ToString() + " ₺";

            var valueCombo = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName,
            }).ToList();
            cmbbox_kategori.DisplayMember = "CategoryName";
            cmbbox_kategori.ValueMember = "CategoryId";
            cmbbox_kategori.DataSource = valueCombo;

            //CHART YAZIYORUM 
            // Kategori adları ve toplam harcama miktarını çek
            var data = db.Spendings
                .GroupBy(s => new { s.CategoryId, s.Category.CategoryName }) // Kategoriye göre gruplama
                .Select(g => new
                {
                    CategoryName = g.Key.CategoryName,  // X Ekseni: Kategori Adı
                    TotalSpending = g.Sum(s => s.SpendingAmount) // Y Ekseni: Toplam Harcama
                })
                .ToList();

            // Grafik bileşenini temizle
            chart1.Series.Clear();

            // Yeni bir seri ekle
            var series = chart1.Series.Add("Kategori Harcamaları");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Sütun grafiği

            // Veriyi grafiğe ekle
            foreach (var item in data)
            {
                series.Points.AddXY(item.CategoryName, item.TotalSpending);
            }


        }
        int count;
        private void timer1_Tick(object sender, EventArgs e)
        {

            count++;
            if (count % 4 == 1)
            {
                lbl_encok.Text = "En çok yapılan harcama";
                var max = db.Spendings.Max(x => x.SpendingAmount).ToString();
                lbl_tutarCokAz.Text = max+" ₺";

            }
            else if (count % 4 == 3)
            {
                {
                    lbl_encok.Text = "En az yapılan harcama";
                    var min = db.Spendings.Min(x => x.SpendingAmount).ToString();
                    lbl_tutarCokAz.Text = min+" ₺";

                }
            }
        }
    }
}
