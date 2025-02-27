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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancielCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancielCrmDb1Entities db =new FinancielCrmDb1Entities();
        private void button3_Click(object sender, EventArgs e)
        {
            var Username = txt_username.Text.ToUpper();
            var Password = txt_password.Text.ToUpper();

            var values = db.Users.Select(X => new
            {
                X.UserName,
                X.Password
            }).ToList();
            foreach (var user in values) 
            {
                if (user.UserName == Username && user.Password == Password)
                {
                    MessageBox.Show("başarılı giriş yapıldı");
                    FrmDashBoard frmDashBoard = new FrmDashBoard();
                    frmDashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı veya şifre hatalı");
                }
            }
        }

      
    }
}
