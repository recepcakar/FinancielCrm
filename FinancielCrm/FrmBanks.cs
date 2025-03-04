
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancielCrm
{
    public partial class FrmBanks : Form
    {
        int userid;
        public FrmBanks(int id)
        {
            userid = id;
            InitializeComponent();
        }
       FinancielCrmDb1Entities1 db =new FinancielCrmDb1Entities1 ();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ZiraatBalance = db.Banks.Where(x => x.UserId == userid).Where(x => x.BankTitle == "Ziraat").Select(y => y.BankBalance).FirstOrDefault();
            var İsBankasiBalance=db.Banks.Where(x => x.UserId == userid).Where(x=>x.BankTitle=="İş bankası").Select(y => y.BankBalance).FirstOrDefault();
            var VakifBalance = db.Banks.Where(x => x.UserId == userid).Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();

            lbl_Ziraat.Text=ZiraatBalance.ToString() + " ₺";
            lbl_Is.Text=İsBankasiBalance.ToString() + " ₺";
            lbl_Vakif.Text=VakifBalance.ToString()+" ₺";

            //BANKA HAREKETLERİ.

            var BankProccess1 = db.BankProccesses.Where(x => x.UserId == userid).OrderByDescending(x => x.BankProccessId).Take(1).FirstOrDefault();

            if (BankProccess1 != null)
            {
                lbl_Procces1.Text = BankProccess1.Amount + " " + BankProccess1.BankDescription + " " + BankProccess1.ProccessDate.ToString();
            }
            else lbl_Procces1.Text = "";
            var BankProccess2 = db.BankProccesses.Where(x => x.UserId == userid).OrderByDescending(x => x.BankProccessId).Take(2).Skip(1).FirstOrDefault();
            if (BankProccess2 != null)
            {
                lbl_Proccess2.Text = BankProccess2.Amount + " " + BankProccess2.BankDescription + " " + BankProccess2.ProccessDate.ToString();
            }
            else lbl_Proccess2.Text = "";
            var BankProccess3 = db.BankProccesses.Where(x => x.UserId == userid).OrderByDescending(x => x.BankProccessId).Take(3).Skip(2).FirstOrDefault();
            if (BankProccess3 != null)
            {
                lbl_Proccess3.Text = BankProccess3.Amount + " " + BankProccess3.BankDescription + " " + BankProccess3.ProccessDate.ToString();
            }
            else lbl_Proccess3.Text = "";
            var BankProccess4 = db.BankProccesses.Where(x => x.UserId == userid).OrderByDescending(x => x.BankProccessId).Take(4).Skip(3).FirstOrDefault();
            if (BankProccess4 != null)
            {
                lbl_Proccess4.Text = BankProccess4.Amount + " " + BankProccess4.BankDescription + " " + BankProccess4.ProccessDate.ToString();
            }
            else lbl_Proccess4.Text = "";
        }


        private void btn_category_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory(userid);
            frm.Show();
            this.Close();
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        { FrmFaturalarcs frm = new FrmFaturalarcs(userid);
            frm.Show();
            this.Close();
        }

        private void btn_BillsForm_Click(object sender, EventArgs e)
        {  FrmBilling frm = new FrmBilling(userid);
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        { FrmBankaHareket frm = new FrmBankaHareket(userid);
            frm.Show();
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        { FrmDashBoard frm = new FrmDashBoard(userid);
            frm.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        { FrmAyarlar frm = new FrmAyarlar(userid);
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
            }//Çıkış yapmak istediğine emin misin?
        }
    }
}
