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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["Categories"].Visible = false;
        }

        private void btnSpendList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateSpend_Click(object sender, EventArgs e)
        {
            string title = txtSpendTitle.Text;
            decimal amount = decimal.Parse(txtSpendAmount.Text);
            DateTime date = DateTime.Parse(txtSpendDate.Text);
            int categoryıd = int.Parse(txtSpendCategoryId.Text);

            Spendings spendings = new Spendings();

            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId=categoryıd;

            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Masraf başarılı bir şekilde sisteme eklendi!", "Masraf Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveSpend_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Masraf başarılı bir şekilde sistemden silindi!", "Masraf Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpend_Click(object sender, EventArgs e)
        {
            string title = txtSpendTitle.Text;
            decimal amount = decimal.Parse(txtSpendAmount.Text);
            DateTime date = DateTime.Parse(txtSpendDate.Text);
            int categoryıd = int.Parse(txtSpendCategoryId.Text);
            int id=int.Parse(txtSpendId.Text);

            var spendings = db.Spendings.Find(id);

            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryıd;
            db.SaveChanges();
            MessageBox.Show("Masraf başarılı bir şekilde sistemde güncellendi!", "Masraf Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var spendings1 = db.Spendings.ToList();
            dataGridView1.DataSource = spendings1;



        }
    }
}
