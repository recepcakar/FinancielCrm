
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
    public partial class FrmChangePassword : Form
    {
        FinancielCrmDb1Entities1 db = new FinancielCrmDb1Entities1();
        int userid;
        public FrmChangePassword(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value=db.Users.Find(userid);
            if (value.Password == txt_oldPassword.Text)
            {
                value.Password = txt_newPassword.Text;
                db.SaveChanges();
                MessageBox.Show("Değiştirildi ");
               this.Close();
            }

        }
    }
}
