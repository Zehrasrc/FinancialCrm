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
    public partial class FrmBanking : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmBanking()
        {
            InitializeComponent();
            dataGridView1.Dock = DockStyle.Fill;
        }
        private void ListProcesses()
        {
            var bankProcessList = from process in db.BankProcesses
                                  join bank in db.Banks on process.BankId equals bank.BankId
                                  select new
                                  {
                                      process.BankProcessId,
                                      process.Description,
                                      process.ProcessDate,
                                      process.Amount,
                                      BankName = bank.BankTitle
                                  };

            dataGridView1.DataSource = bankProcessList.ToList(); 
        }
        private void FrmBanking_Load(object sender, EventArgs e)
        {
            ListProcesses();
        }
        private string GetProcessType()
        {
            if (checkBoxGelenHavale.Checked) return "Gelen Havale";
            if (checkBoxGidenHavale.Checked) return "Giden Havale";
            return "Diğer";
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string description = txtBankingDescription.Text;
            DateTime processDate = DateTime.Parse(txtBankingDate.Text);
            decimal amount = decimal.Parse(txtBankingAmount.Text);
            string processType = GetProcessType();
            string bankName = txtBankingName.Text;

            var selectedBank = db.Banks.FirstOrDefault(b => b.BankTitle == bankName);

            if (selectedBank != null)
            {
                BankProcesses newProcess = new BankProcesses
                {
                    Description = description,
                    ProcessDate = processDate,
                    Amount = amount,
                    ProcessType = processType,
                    BankId = selectedBank.BankId
                };

                db.BankProcesses.Add(newProcess);
                db.SaveChanges();

                MessageBox.Show("İşlem başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListProcesses();
            }
            else
            {
                MessageBox.Show("Girilen banka bulunamadı. Lütfen doğru bir banka ismi yazınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankingId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemden silindi!", "Banka İşlemleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankingId.Text);  
            var transactionToUpdate = db.BankProcesses.Find(id);  

            if (transactionToUpdate != null)
            {
                transactionToUpdate.Description = txtBankingDescription.Text;
                transactionToUpdate.ProcessDate = DateTime.Parse(txtBankingDate.Text);
                transactionToUpdate.Amount = decimal.Parse(txtBankingAmount.Text);
                transactionToUpdate.ProcessType = GetProcessType();  
                var selectedBank = db.Banks.FirstOrDefault(b => b.BankTitle == txtBankingName.Text);

                if (selectedBank != null)
                {
                    transactionToUpdate.BankId = selectedBank.BankId;  
                }

                db.SaveChanges();

                MessageBox.Show("İşlem başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var values = (from process in db.BankProcesses
                              join bank in db.Banks on process.BankId equals bank.BankId
                              select new
                              {
                                  process.BankProcessId,
                                  process.Description,
                                  process.ProcessDate,
                                  process.ProcessType,
                                  process.Amount,
                                  BankName = bank.BankTitle
                              }).ToList();
                dataGridView1.DataSource = values;
            }
            else
            {
                MessageBox.Show("Güncellenecek işlem bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
