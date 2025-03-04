
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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        FinancielCrmDb1Entities1 db = new FinancielCrmDb1Entities1();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName=txt_UserName.Text;
            user.Password=txt_Password.Text;
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Başarılı şekilde kayıt olundu");
            this.Close();
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
