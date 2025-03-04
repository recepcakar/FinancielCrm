
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancielCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancielCrmDb1Entities1 db =new FinancielCrmDb1Entities1();
        private void button3_Click(object sender, EventArgs e)
        {
            var Username = txt_username.Text;
            var Password = txt_password.Text;

            var user = db.Users.FirstOrDefault(x => x.UserName== Username && x.Password == Password);

            if (user != null)
            {
                MessageBox.Show("Başarılı giriş yapıldı");
                FrmCategory frmCategory = new FrmCategory(user.UserId);
                frmCategory.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }

        private void linklbl_PasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şuanlık kullanılamıyor");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            FrmKayit frmKayit = new FrmKayit();
            frmKayit.Show();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
