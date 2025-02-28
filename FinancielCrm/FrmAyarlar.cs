using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancielCrm
{
    public partial class FrmAyarlar : Form
    {
        int userid;
        public FrmAyarlar(int id)
        {
            userid = id;
            InitializeComponent();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory(userid);
            frm.Show();
            this.Close();
        }
 
        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks(userid);
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
                Application.Exit();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frm = new FrmDashBoard(userid);
            frm.Show();
            this.Close();
        }

        private void btn_BillsForm_Click_1(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling(userid);
            frm.Show();
            this.Close();
        }

        private void btn_fatura_Click_1(object sender, EventArgs e)
        {
            FrmFaturalarcs frm = new FrmFaturalarcs(userid);
            frm.Show();
            this.Close();
        }

        private void btn_hareket_Click_1(object sender, EventArgs e)
        {
            FrmBankaHareket frm = new FrmBankaHareket(userid);
            frm.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          panel2.BackColor=Color.White;
          panel2.ForeColor=Color.Black;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            panel2.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var respond = MessageBox.Show("Hesabınızı kalıcı olarak silmek istediğinize emin misiniz","Soru",MessageBoxButtons.YesNo);
            if (respond == DialogResult.Yes) 
            {
                Frmsilme frm =new Frmsilme(userid);
                frm.Show();
                
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                ChangeUsername changeUsername = new ChangeUsername(userid);
                changeUsername.Show();
                          
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
               FrmChangePassword frmChangePassword = new FrmChangePassword(userid);
               frmChangePassword.Show();
                

        }
    }
}
