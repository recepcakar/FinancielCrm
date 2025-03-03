
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
    public partial class Frmsilme : Form
    {
        int userid;
        public Frmsilme(int userid)
        {
            InitializeComponent();
            this.userid = userid;   
        }
        FinancielCrmDb1Entities1 db = new FinancielCrmDb1Entities1();
        private void Frmsifre_Load(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = db.Users.Find(userid);

            if (result.Password == textBox1.Text)
            {
                db.Users.Remove(result);
                db.SaveChanges();
                MessageBox.Show("silme işlemi gerçekleşti uygulamayı yeniden açın", "bilgi", MessageBoxButtons.OK);
              
            }
        }
    }
}
