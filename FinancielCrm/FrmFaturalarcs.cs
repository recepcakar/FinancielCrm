using FinancielCrm.Models;
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
        FinancielCrmDb1Entities db =new FinancielCrmDb1Entities();
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

            var ElektrikValue = db.Bills.Where(x => x.BillTitle == "Elektrik").Select(y => new
            {
                y.BillId,
                y.BillAmount,
                y.BillPeriod,
            }).FirstOrDefault();
            if (ElektrikValue != null)
            {
                lbl_elektrikAmount.Text = ElektrikValue.BillAmount.ToString() + " ₺";
                lbl_elektriktarih.Text = ElektrikValue.BillPeriod.ToString();
                elektrikId = ElektrikValue.BillId;
                btn_Elektrik.Enabled=true;
            }
            else
            {
                btn_Elektrik.Text = "Ödendi";
                btn_Elektrik.Enabled = false;
            }

            //dogalgaz
            var DogalgazValue = db.Bills.Where(x => x.BillTitle == "Doğalgaz").Select(y => new
            {
                y.BillId,
                y.BillAmount,
                y.BillPeriod,
            }).FirstOrDefault();
            if(DogalgazValue != null)
            {
                lbl_dogalgaztarih.Text = DogalgazValue.BillPeriod.ToString();
                lbl_DogalgazAmount.Text = DogalgazValue.BillAmount.ToString() + " ₺";
                DogalgazId = DogalgazValue.BillId;
                btn_Dogalgaz.Enabled=true;
            }
            else
            {
                btn_Dogalgaz.Text = "Ödendi";
                btn_Dogalgaz.Enabled = false;
            }

            //SU

            var SuValue = db.Bills.Where(x => x.BillTitle == "Su").Select(y => new
            {
                y.BillId,
                y.BillAmount,
                y.BillPeriod,
            }).FirstOrDefault();
           if ( SuValue != null)
            {
                lbl_SuAmount.Text = SuValue.BillAmount.ToString() + " ₺";
                lbl_SuTarih.Text = SuValue.BillPeriod.ToString();
                SuId = SuValue.BillId;
                btn_Su.Enabled=true;
            }
            else
            {btn_Su.Text = "Ödendi";
                btn_Su.Enabled = false;
            }
            //int


            var IntValue = db.Bills.Where(x => x.BillTitle == "İnternet").Select(y => new
            {
                y.BillId,
                y.BillAmount,
                y.BillPeriod,
            }).FirstOrDefault();

           if (IntValue != null)
            {
                lbl_IntTarih.Text = IntValue.BillPeriod.ToString();
                lbl_IntAmount.Text = IntValue.BillAmount.ToString() + " ₺";
                IntId = IntValue.BillId;
                btn_Int.Enabled =true;
            }
            else
            {
                btn_Int.Text = "Ödendi";
                btn_Int.Enabled = false;
            }
            //tel
            var TelValue = db.Bills.Where(x => x.BillTitle == "Telefon").Select(y => new
            {
                y.BillId,
                y.BillAmount,
                y.BillPeriod,
            }).FirstOrDefault();
            if (TelValue != null)
            {
                lbl_TelAmount.Text = TelValue.BillAmount.ToString() + " ₺";
                LBL_TelTarih.Text = TelValue.BillPeriod;
                TelId = TelValue.BillId;
                btn_Tel.Enabled=true;
            }
            else
            {
                btn_Tel.Text = "Ödendi";
               btn_Tel.Enabled = false;
            }
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
                var removeValue = db.Bills.Find(ıd);
                db.Bills.Remove(removeValue);
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
            Bill bill = new Bill();
            bill.BillTitle=comboBox1.Text;
            bill.BillAmount=numericUpDown1.Value;
            bill.BillPeriod=txt_Date.Text;
            bill.CategoryId = 1;
            db.Bills.Add(bill);
            db.SaveChanges();
            YenidenYukle();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
