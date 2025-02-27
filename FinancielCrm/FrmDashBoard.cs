using FinancielCrm.Models;
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
        public FrmDashBoard()
        {
            InitializeComponent();
        }
        FinancielCrmDb1Entities db=new FinancielCrmDb1Entities();
        int count=1;
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            var TotalPrice = db.Banks.Sum(x => x.BankBalance);
            lbl_TotalBalance.Text = TotalPrice.ToString()+" ₺";

            //  Gelen Son havale kısmını 

            var sonhavale=db.BankProccesses.OrderByDescending(x=>x.BankProccessId).Take(1).Select(y=>y.Amount).FirstOrDefault();
            lbl_GelenHavale.Text = sonhavale.ToString()+" ₺";


            #region chart1
            //BURADA CHART 1 KODLARINI YAZIYORUM

            var BankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
           // series.Points.AddXY(BankData.Select(x=>x.BankTitle),BankData.Select(y=>y.BankBalance));
           foreach(var item in BankData)
            {
                series.Points.AddXY(item.BankTitle,item.BankBalance);
            }

            #endregion
            #region chart2
            var values = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount,
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType=SeriesChartType.Doughnut;

            foreach (var item in values) 
            {
                series2.Points.AddXY(item.BillTitle,item.BillAmount);
                
            }
            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            count++;
            if (count % 4 == 0) 
            {
                var values=db.Bills.Where(x=>x.BillTitle== "Elektrik").Select(x=>x.BillAmount).FirstOrDefault();
                lbl_fatura.Text = "Elektrik faturası";
                lbl_BillAmount.Text = values.ToString()+" ₺";
            }
            else if (count % 4 == 1)
            {
                var values = db.Bills.Where(x => x.BillTitle == "Doğalgaz").Select(x => x.BillAmount).FirstOrDefault();
                lbl_fatura.Text = "Doğalgaz faturası";
                lbl_BillAmount.Text = values.ToString() + " ₺";

            }
            else if(count % 4 == 2) 
            {
                var values = db.Bills.Where(x => x.BillTitle == "Su").Select(x => x.BillAmount).FirstOrDefault();
                lbl_fatura.Text = "Su faturası";
                lbl_BillAmount.Text = values.ToString() + " ₺";
            }
            else if (count % 4 == 3)
            {
                var values = db.Bills.Where(x => x.BillTitle == "İnternet").Select(x => x.BillAmount).FirstOrDefault();
                lbl_fatura.Text = "İnternet faturası";
                lbl_BillAmount.Text = values.ToString() + " ₺";

            }
        }
    }
}
