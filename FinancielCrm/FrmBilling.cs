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

namespace FinancielCrm
{
    public partial class FrmBilling : Form
    {
        int userid;
        public FrmBilling(int id)
        {
            userid = id;
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txt_BillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("silme işlemi başarılı ", " Bilgi");

        }
        FinancielCrmDb1Entities db=new FinancielCrmDb1Entities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values=db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks(userid);
            banks.ShowDialog();
            this.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string title=txt_BillTitle.Text;
            decimal amaunt=decimal.Parse(txt_BillAmount.Text);
            string period=txt_Period.Text;
           
            Bill bill = new Bill();
            bill.BillTitle = title;
            bill.BillAmount = amaunt;
            bill.BillPeriod = period;
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı "," Bilgi");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_BillId.Text);
            string title=txt_BillTitle.Text;    
            string period= txt_Period.Text;
            decimal amount=decimal.Parse(txt_BillAmount.Text); 

            var UpdatedValue = db.Bills.Find(id);

            UpdatedValue.BillAmount=amount;
            UpdatedValue.BillTitle = title;
            UpdatedValue.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı ", " Bilgi");
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
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
            FrmFaturalarcs fat=new FrmFaturalarcs(userid);    
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
    }
}
