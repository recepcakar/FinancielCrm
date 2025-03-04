
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancielCrm
{
    public partial class FrmDashBoard : Form
    {

        int userid;
        public FrmDashBoard(int id)
        {
            userid= id; 
            InitializeComponent();
        }
        FinancielCrmDb1Entities1 db = new FinancielCrmDb1Entities1();
        int count=1;
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {   
            var value=db.Banks.Where(x=>x.UserId==userid).Sum(x => x.BankBalance);
            if (value != null)
            {
                lbl_TotalBalance.Text = value.ToString() + " ₺";
            }
            else
            {
                lbl_TotalBalance.Text = " 1.00 ₺";
            }

            //  Gelen Son havale kısmını 

            var sonhavale=db.BankProccesses.Where(x=>x.UserId==userid).OrderByDescending(x=>x.BankProccessId).Take(1).Select(y=>y.Amount).FirstOrDefault();
            lbl_GelenHavale.Text = sonhavale.ToString()+" ₺";


            #region chart1
            //BURADA CHART 1 KODLARINI YAZIYORUM

            var BankData1 = db.Banks.Where(x => x.UserId == userid);
            var BankData=BankData1.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();
            chart1.Series.Clear();
            
            if (BankData != null)
            {
                var series = chart1.Series.Add("Bankalar");
                series.ChartType = SeriesChartType.Doughnut;
                // series.Points.AddXY(BankData.Select(x=>x.BankTitle),BankData.Select(y=>y.BankBalance));
                foreach (var item in BankData)
                {
                    series.Points.AddXY(item.BankTitle, item.BankBalance);
                }
            }
            else
            {
                var emptySeries = chart1.Series.Add("Veri Yok");
                emptySeries.Points.AddY(0); // Boş bir veri noktası ekleme
                emptySeries.ChartType = SeriesChartType.Doughnut;
            }
          

            #endregion
            #region chart2
           var values=db.Spendings.Where(x => x.UserId == userid).Where(x=>x.CategoryId==1).ToList();
           var val2 = db.Spendings.Select(x => new
           {
               x.SpendingTitle,
               x.SpendingAmount,
           }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            
            series2.ChartType=SeriesChartType.Doughnut;

            foreach (var item in values) 
            {
                series2.Points.AddXY(item.SpendingTitle,item.SpendingAmount);
                
            }
            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(userid);
            frmBanks.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var degerler = db.Spendings.Where(x => x.CategoryId == 1 && x.UserId==userid).ToList();
            count++;
            if (count % 4 == 0) 
            {
                var values = degerler.Where(x => x.UserId == userid).Where(y => y.SpendingTitle == "Elektrik").Select(y =>y.SpendingAmount).FirstOrDefault();
                
                lbl_fatura.Text = "Elektrik faturası";
                if (values == null)
                {
                    lbl_BillAmount.Text = "0,00 ₺";
                } 
                else
                {
                    lbl_BillAmount.Text = values.ToString() + " ₺";
                } 
            }
            else if (count % 4 == 1)
            {
                var values = degerler.Where(x => x.UserId == userid).Where(y => y.SpendingTitle == "Doğalgaz").Select(y => y.SpendingAmount).FirstOrDefault();
                lbl_fatura.Text = "Doğalgaz faturası";
                if (values == null)
                {
                    lbl_BillAmount.Text = "0,00 ₺";
                }
                else
                {
                    lbl_BillAmount.Text = values.ToString() + " ₺";
                }

            }
            else if(count % 4 == 2) 
            {
                var values = degerler.Where(x => x.UserId == userid).Where(y => y.SpendingTitle == "Su").Select(y => y.SpendingAmount).FirstOrDefault();
                lbl_fatura.Text = "Su faturası";
                if (values == null)
                {
                    lbl_BillAmount.Text = "0,00 ₺";
                }
                else
                {
                    lbl_BillAmount.Text = values.ToString() + " ₺";
                }
            }
            else if (count % 4 == 3)
            {
                var values = degerler.Where(x => x.UserId == userid).Where(y => y.SpendingTitle == "İnternet").Select(y => y.SpendingAmount).FirstOrDefault();
                lbl_fatura.Text = "İnternet faturası";
                if (values == null)
                {
                    lbl_BillAmount.Text = "0,00 ₺";
                }
                else
                {
                    lbl_BillAmount.Text = values.ToString() + " ₺";
                }

            }
        }

        private void btn_BillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling(userid);
            frmBilling.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory(userid);
            frmCategory.Show();
            this.Close();
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            FrmFaturalarcs frm = new FrmFaturalarcs(userid);
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            FrmBankaHareket frmBank=new FrmBankaHareket(userid);
            frmBank.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar(userid);
            frm.Show();
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
