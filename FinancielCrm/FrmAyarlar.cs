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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Close();
        }
 
        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frm = new FrmDashBoard();
            frm.Show();
            this.Close();
        }

        private void btn_BillsForm_Click_1(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btn_fatura_Click_1(object sender, EventArgs e)
        {
            FrmFaturalarcs frm = new FrmFaturalarcs();
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click_1(object sender, EventArgs e)
        {
            FrmBankaHareket frm = new FrmBankaHareket();
            frm.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }
    }
}
