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
    public partial class FrmFaturalarcs : Form
    {
        public FrmFaturalarcs()
        {
            InitializeComponent();
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

        private void btn_category_Click(object sender, EventArgs e)
        {
            FrmCategory cat = new FrmCategory();
            cat.Show();
            this.Close();
        }

        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Close();

        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_BillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling  billing = new FrmBilling();
                
            billing.Show();
            this.Close();
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            FrmBankaHareket bankaH = new FrmBankaHareket();
            bankaH.Show();
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashboard = new FrmDashBoard();
            dashboard.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmAyarlar settings = new FrmAyarlar();
            settings.Show();
                
            this.Close();
        }

        private void FrmFaturalarcs_Load(object sender, EventArgs e)
        {

        }
    }
}
