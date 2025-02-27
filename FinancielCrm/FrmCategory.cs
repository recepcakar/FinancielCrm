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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

       

        private void btn_Banks_Click(object sender, EventArgs e)
        {

            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            FrmFaturalarcs frm = new FrmFaturalarcs();
            frm.Show();
            this.Close();
        }

        private void btn_BillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            FrmBankaHareket frm = new FrmBankaHareket();
            frm.Show();
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frm = new FrmDashBoard();
            frm.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new FrmAyarlar();
            frm.Show();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
           //Çıkış yapmak istediğine emin misin?
        }
    }
}
