
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancielCrm
{
    public partial class FrmFaturalarcs : Form
    {
        int userid;
        public FrmFaturalarcs(int id)
        {
            InitializeComponent();
        }
        FinancielCrmDb1Entities1 db = new FinancielCrmDb1Entities1();
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


        //Burada ödeme butonlarında kullanılcak fieldları tutuyorum
        int elektrikId;
        int DogalgazId;
        int SuId;
        int TelId;
        int IntId;
        int genelId;
        bool gelen;





        private void btn_category_Click(object sender, EventArgs e)
        {
            FrmCategory cat = new FrmCategory(userid);
            cat.Show();
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
        
        }

        private void btn_BillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling  billing = new FrmBilling(userid);
                
            billing.Show();
            this.Close();
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            FrmBankaHareket bankaH = new FrmBankaHareket(userid);
            bankaH.Show();
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

        private void FrmFaturalarcs_Load(object sender, EventArgs e)
        {
            /*datagridview'in kodları
            var values = db.Bills.Select(x =>new
            { x.BillId,
                x.BillTitle,
                x.BillPeriod,
                x.BillAmount,
            }).ToList();
            dataGridView1.DataSource = values;
            //charset kodları
            chart1.Series.Clear();
            var series = chart1.Series.Add("Faturalar");
            series.ChartType=System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in values)
            {
                series.Points.AddXY(item.BillTitle, item.BillAmount);
            }
            */

            var degerler = db.Spendings.Where(x => x.CategoryId == 1).ToList();
            var ElektrikValue = degerler.Where(y => y.SpendingTitle == "Elektrik").Select(y => new
            {
                y.SpendingDate,
                y.SpendingTitle,
                y.SpendingId,
                y.SpendingAmount,
            }).FirstOrDefault();
            if (ElektrikValue != null)
            {
                lbl_elektrikAmount.Text = ElektrikValue.SpendingAmount + " ₺";
                lbl_elektriktarih.Text = ElektrikValue.SpendingDate.ToString();
                elektrikId = ElektrikValue.SpendingId;
                btn_Elektrik.Enabled = true;
            }
            else
            {
                btn_Elektrik.Text = "Ödendi";
                btn_Elektrik.Enabled = false;
            }
            var DogalgazValue = degerler.Where(y => y.SpendingTitle == "Doğalgaz").Select(y => new
            {
                y.SpendingDate,
                y.SpendingTitle,
                y.SpendingId,
                y.SpendingAmount,
            }).FirstOrDefault();
            if (DogalgazValue != null)
            {
                lbl_dogalgaztarih.Text = DogalgazValue.SpendingDate.ToString();
                lbl_DogalgazAmount.Text = DogalgazValue.SpendingAmount.ToString() + " ₺";
                DogalgazId = DogalgazValue.SpendingId;
                btn_Dogalgaz.Enabled = true;
            }
            else
            {
                btn_Dogalgaz.Text = "Ödendi";
                btn_Dogalgaz.Enabled = false;
            }
            var SuValue = degerler.Where(y => y.SpendingTitle == "Su").Select(y => new
            {
                y.SpendingDate,
                y.SpendingTitle,
                y.SpendingId,
                y.SpendingAmount,
            }).FirstOrDefault();
            if (SuValue != null)
            {
                lbl_SuAmount.Text = SuValue.SpendingAmount.ToString() + " ₺";
                lbl_SuTarih.Text = SuValue.SpendingDate.ToString();
                SuId = SuValue.SpendingId;
                btn_Su.Enabled = true;
            }
            else
            {
                btn_Su.Text = "Ödendi";
                btn_Su.Enabled = false;
            }
            var IntValue = degerler.Where(y => y.SpendingTitle == "İnternet").Select(y => new
            {
                y.SpendingDate,
                y.SpendingTitle,
                y.SpendingId,
                y.SpendingAmount,

            }).FirstOrDefault();


            if (IntValue != null)
            {
                lbl_TelAmount.Text = IntValue.SpendingAmount.ToString() + " ₺";
                LBL_TelTarih.Text = IntValue.SpendingDate.ToString();
                TelId = IntValue.SpendingId;
                btn_Tel.Enabled = true;
            }
            else
            {
                btn_Tel.Text = "Ödendi";
                btn_Tel.Enabled = false;
            }
            var TelValue = degerler.Where(y => y.SpendingTitle == "Telefon").Select(y => new
            {
                y.SpendingDate,
                y.SpendingTitle,
                y.SpendingId,
                y.SpendingAmount,
            }).FirstOrDefault();

            if (TelValue != null)
            {
                lbl_TelAmount.Text = TelValue.SpendingAmount.ToString() + " ₺";
                LBL_TelTarih.Text = TelValue.SpendingDate.ToString();
                TelId = TelValue.SpendingId;
                btn_Tel.Enabled = true;
            }
            else
            {
                btn_Tel.Text = "Ödendi";
                btn_Tel.Enabled = false;
            }



            //int





        }



        private void btn_Elektrik_Click(object sender, EventArgs e)
        {
             gelen = Odeme(elektrikId);
            if (gelen)
            {
                lbl_elektrikAmount.Text = "0.00 ₺";
                lbl_elektriktarih.Text = "--";
                MessageBox.Show("Başarılı bir şekilde ödendi");
                YenidenYukle();
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
                
        }

        private void btn_Dogalgaz_Click(object sender, EventArgs e)
        {
             gelen = Odeme(DogalgazId);
            if (gelen)
            {
                lbl_DogalgazAmount.Text = "0.00 ₺";
                lbl_dogalgaztarih.Text = "--";
                MessageBox.Show("Başarılı bir şekilde ödendi");
                YenidenYukle();
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
        }
        public bool Odeme(int ıd)
        {
            try
            {
                var removeValue = db.Spendings.Find(ıd);
                db.Spendings.Remove(removeValue);
                db.SaveChanges();

             
                return true;

            }
            catch
            {
               
                return false; }

        }

        private void btn_Su_Click(object sender, EventArgs e)
        {
             gelen = Odeme(SuId);
            if (gelen)
            {
                lbl_SuAmount.Text = "0.00 ₺";
                lbl_SuTarih.Text = "--";
                MessageBox.Show("Başarılı bir şekilde ödendi");
                YenidenYukle();
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void btn_Int_Click(object sender, EventArgs e)
        {
            gelen = Odeme(IntId);
            if (gelen)
            {
                lbl_IntAmount.Text = "0.00 ₺";
                lbl_IntTarih.Text = "--";
                MessageBox.Show("Başarılı bir şekilde ödendi");
                 YenidenYukle();
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void btn_Tel_Click(object sender, EventArgs e)
        {
            gelen = Odeme(TelId);
            if (gelen)
            {
                lbl_TelAmount.Text = "0.00 ₺";
                LBL_TelTarih.Text = "--";
                MessageBox.Show("Başarılı bir şekilde ödendi");
                YenidenYukle();
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
        }
        private void YenidenYukle()
        {
            FrmFaturalarcs yeniForm = new FrmFaturalarcs(userid);
            yeniForm.Show();
            this.Close(); // Eski formu kapat
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Spending spending = new Spending();
            spending.SpendingTitle = comboBox1.Text;
            spending.SpendingAmount=numericUpDown1.Value;
            spending .SpendingDate= Convert.ToDateTime(txt_Date.Text);
            spending.CategoryId = 1;
         db.Spendings.Add(spending);
            db.SaveChanges();
            YenidenYukle();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
