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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTcKimlikNo.Text;
            string telefonNo = txtTelefonNo.Text;
            string sifre = txtPassword.Text;
            string guvenlikSorusu = cmbSecurityQuestion.SelectedItem.ToString();
            string guvenlikCevabi = txtSecurityAnswer.Text;

            MessageBox.Show("Ayarlar başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
