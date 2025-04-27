namespace FinancialCrm
{
    partial class FrmCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriesId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBanking = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(209, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(872, 342);
            this.panel4.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdateCategory);
            this.panel3.Controls.Add(this.btnRemoveCategory);
            this.panel3.Controls.Add(this.btnCreateCategory);
            this.panel3.Controls.Add(this.btnCategoryList);
            this.panel3.Controls.Add(this.txtCategoryName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCategoriesId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(209, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 182);
            this.panel3.TabIndex = 20;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(658, 118);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(162, 46);
            this.btnUpdateCategory.TabIndex = 10;
            this.btnUpdateCategory.Text = "Kategori Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCategory.Location = new System.Drawing.Point(490, 118);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(162, 46);
            this.btnRemoveCategory.TabIndex = 9;
            this.btnRemoveCategory.Text = "Kategori Sil";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnCreateCategory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategory.Location = new System.Drawing.Point(310, 118);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(162, 46);
            this.btnCreateCategory.TabIndex = 8;
            this.btnCreateCategory.Text = "Yeni Kategori";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.Color.Silver;
            this.btnCategoryList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryList.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryList.Location = new System.Drawing.Point(128, 118);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(162, 46);
            this.btnCategoryList.TabIndex = 0;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoryName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(171, 69);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(649, 29);
            this.txtCategoryName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Adı:";
            // 
            // txtCategoriesId
            // 
            this.txtCategoriesId.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoriesId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoriesId.Location = new System.Drawing.Point(171, 29);
            this.txtCategoriesId.Name = "txtCategoriesId";
            this.txtCategoriesId.Size = new System.Drawing.Size(649, 29);
            this.txtCategoriesId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 47);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori Formu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(95)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.btnFatura);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBanking);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Location = new System.Drawing.Point(1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 563);
            this.panel1.TabIndex = 18;
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.Transparent;
            this.btnFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFatura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ForeColor = System.Drawing.Color.Transparent;
            this.btnFatura.Location = new System.Drawing.Point(31, 161);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(167, 44);
            this.btnFatura.TabIndex = 7;
            this.btnFatura.Text = "Faturalar";
            this.btnFatura.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(31, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(31, 422);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(172, 44);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(31, 359);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 44);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBanking
            // 
            this.btnBanking.BackColor = System.Drawing.Color.Transparent;
            this.btnBanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanking.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanking.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanking.Location = new System.Drawing.Point(31, 292);
            this.btnBanking.Name = "btnBanking";
            this.btnBanking.Size = new System.Drawing.Size(170, 44);
            this.btnBanking.TabIndex = 3;
            this.btnBanking.Text = "Banka Hareketleri";
            this.btnBanking.UseVisualStyleBackColor = false;
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillForm.Location = new System.Drawing.Point(31, 227);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(167, 44);
            this.btnBillForm.TabIndex = 2;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.Location = new System.Drawing.Point(31, 96);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(167, 44);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategory.Location = new System.Drawing.Point(31, 29);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(167, 44);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Kategoriler";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1096, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoriesId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBanking;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategory;
    }
}