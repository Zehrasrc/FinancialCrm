using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string name = txtUsername.Text.Trim(); 
            string password = txtPassword.Text.Trim(); 

            var users = db.Users.FirstOrDefault(u => u.Username == name);  

            if (users != null && users.Password == password)  
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else  
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
