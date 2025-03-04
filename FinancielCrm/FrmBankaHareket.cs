
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancielCrm
{
    public partial class FrmBankaHareket : Form
    {
        public FrmBankaHareket(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }



        int userid;
        private void btn_fatura_Click(object sender, EventArgs e)
        {
            FrmFaturalarcs frm = new FrmFaturalarcs(userid);
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            FrmBankaHareket frm = new FrmBankaHareket(userid);
            frm.Show();
            this.Close();
        }

        private void btn_category_Click_1(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory(userid);
            frm.Show();
            this.Close();
        }

        private void btn_Banks_Click_1(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks(userid);
            frm.Show();
            this.Close();
        }

        private void btn_BillsForm_Click_1(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling(userid);
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click_1(object sender, EventArgs e)
        {
            //Buradayız
        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            FrmDashBoard frm = new FrmDashBoard(userid);
            frm.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar(userid);
            frm.Show();
            this.Close();
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
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
        FinancielCrmDb1Entities1 db = new FinancielCrmDb1Entities1();
        private void btn_ziraat_Click(object sender, EventArgs e)
        {
            datagrid(1);
            label4.Text = "Ziraat Bankası";
        }

        private void btn_is_Click(object sender, EventArgs e)
        {
            datagrid(2);
            label4.Text = "İş Bankası";
        }

        private void btn_vakıf_Click(object sender, EventArgs e)
        {
            datagrid(3);
            label4.Text = "Vakıf Bankası";
        }
        public void datagrid(int id)
        {
            var value = db.BankProccesses.Where(x=>x.UserId==userid).Where(x => x.BankId == id).Select(y => new
            {
                y.ProccessDate,
                y.BankDescription,
                y.ProccessType,
                y.Amount,
            }).ToList();
            dataGridView1.DataSource = value;
        }
    }
}
