using FinancielCrm.Models;
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
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancielCrmDb1Entities db=new FinancielCrmDb1Entities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ZiraatBalance = db.Banks.Where(x => x.BankTitle == "Ziraat").Select(y => y.BankBalance).FirstOrDefault();
            var İsBankasiBalance=db.Banks.Where(x=>x.BankTitle=="İş bankası").Select(y => y.BankBalance).FirstOrDefault();
            var VakifBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();

            lbl_Ziraat.Text=ZiraatBalance.ToString() + " ₺";
            lbl_Is.Text=İsBankasiBalance.ToString() + " ₺";
            lbl_Vakif.Text=VakifBalance.ToString()+" ₺";

            //BANKA HAREKETLERİ.

            var BankProccess1 = db.BankProccesses.OrderByDescending(x => x.BankProccessId).Take(1).FirstOrDefault();
            lbl_Procces1.Text=BankProccess1.Amount+" "+BankProccess1.BankDescription+" "+ BankProccess1.ProccessDate;
       
            var BankProccess2 = db.BankProccesses.OrderByDescending(x => x.BankProccessId).Take(2).Skip(1).FirstOrDefault();
            lbl_Proccess2.Text = BankProccess2.Amount + " " + BankProccess2.BankDescription + " " + BankProccess2.ProccessDate;
 
            var BankProccess3 = db.BankProccesses.OrderByDescending(x => x.BankProccessId).Take(3).Skip(2).FirstOrDefault();
            lbl_Proccess3.Text = BankProccess3.Amount + " " + BankProccess3.BankDescription + " " + BankProccess3.ProccessDate;

            var BankProccess4 = db.BankProccesses.OrderByDescending(x => x.BankProccessId).Take(4).Skip(3).FirstOrDefault();
            lbl_Proccess4.Text = BankProccess4.Amount + " " + BankProccess4.BankDescription + " " + BankProccess4.ProccessDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.ShowDialog();
            this.Close();
        }
    }
}
