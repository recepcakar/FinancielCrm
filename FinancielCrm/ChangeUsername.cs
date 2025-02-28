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
    public partial class ChangeUsername : Form
    {
        FinancielCrmDb1Entities db=new FinancielCrmDb1Entities();
        int userid;
        public ChangeUsername(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var value = db.Users.Find(userid);
            if (value != null) 
            {
                value.UserName=txt_UserName.Text.ToUpper();
                db.SaveChanges();
                MessageBox.Show("kullanıcı adı değiştirildi");
                this.Close();
            } 
        }

        private void ChangeUsername_Load(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
