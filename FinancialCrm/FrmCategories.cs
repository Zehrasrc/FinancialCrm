using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;


namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();

            // Veriyi DataGridView'a ata
            dataGridView1.DataSource = values;

            // DataGridView sütunlarını ayarla (gereksiz sütunları gizle)
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // Sadece CategoryId ve CategoryName sütunlarını göster
                if (column.Name != "CategoryId" && column.Name != "CategoryName")
                {
                    column.Visible = false;
                }

            }
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string Name = txtCategoryName.Text;

            Categories categories = new Categories();

            categories.CategoryName = Name;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sisteme eklendi!", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoriesId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sistemden silindi!", "Ödeme Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = int.Parse(txtCategoriesId.Text);

            var categories = db.Categories.Find(id);

            categories.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sistemde güncellendi!", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;

            
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }
    }
}
