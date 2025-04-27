namespace FinancialCrm
{
    partial class FrmSpendings
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
            this.txtSpendCategoryId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateSpend = new System.Windows.Forms.Button();
            this.btnRemoveSpend = new System.Windows.Forms.Button();
            this.btnCreateSpend = new System.Windows.Forms.Button();
            this.btnSpendList = new System.Windows.Forms.Button();
            this.txtSpendDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpendAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpendTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBanking = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
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
            this.panel4.Location = new System.Drawing.Point(209, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(872, 300);
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
            this.dataGridView1.Size = new System.Drawing.Size(872, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSpendCategoryId);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnUpdateSpend);
            this.panel3.Controls.Add(this.btnRemoveSpend);
            this.panel3.Controls.Add(this.btnCreateSpend);
            this.panel3.Controls.Add(this.btnSpendList);
            this.panel3.Controls.Add(this.txtSpendDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtSpendAmount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSpendTitle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtSpendId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(209, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 240);
            this.panel3.TabIndex = 20;
            // 
            // txtSpendCategoryId
            // 
            this.txtSpendCategoryId.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendCategoryId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendCategoryId.Location = new System.Drawing.Point(118, 152);
            this.txtSpendCategoryId.Name = "txtSpendCategoryId";
            this.txtSpendCategoryId.Size = new System.Drawing.Size(725, 29);
            this.txtSpendCategoryId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategori Id:";
            // 
            // btnUpdateSpend
            // 
            this.btnUpdateSpend.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateSpend.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateSpend.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSpend.Location = new System.Drawing.Point(644, 188);
            this.btnUpdateSpend.Name = "btnUpdateSpend";
            this.btnUpdateSpend.Size = new System.Drawing.Size(162, 40);
            this.btnUpdateSpend.TabIndex = 10;
            this.btnUpdateSpend.Text = "Masraf Güncelle";
            this.btnUpdateSpend.UseVisualStyleBackColor = false;
            this.btnUpdateSpend.Click += new System.EventHandler(this.btnUpdateSpend_Click);
            // 
            // btnRemoveSpend
            // 
            this.btnRemoveSpend.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveSpend.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveSpend.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSpend.Location = new System.Drawing.Point(476, 188);
            this.btnRemoveSpend.Name = "btnRemoveSpend";
            this.btnRemoveSpend.Size = new System.Drawing.Size(162, 40);
            this.btnRemoveSpend.TabIndex = 9;
            this.btnRemoveSpend.Text = "Masraf Sil";
            this.btnRemoveSpend.UseVisualStyleBackColor = false;
            this.btnRemoveSpend.Click += new System.EventHandler(this.btnRemoveSpend_Click);
            // 
            // btnCreateSpend
            // 
            this.btnCreateSpend.BackColor = System.Drawing.Color.Silver;
            this.btnCreateSpend.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateSpend.ForeColor = System.Drawing.Color.Black;
            this.btnCreateSpend.Location = new System.Drawing.Point(308, 188);
            this.btnCreateSpend.Name = "btnCreateSpend";
            this.btnCreateSpend.Size = new System.Drawing.Size(162, 40);
            this.btnCreateSpend.TabIndex = 8;
            this.btnCreateSpend.Text = "Yeni Masraf";
            this.btnCreateSpend.UseVisualStyleBackColor = false;
            this.btnCreateSpend.Click += new System.EventHandler(this.btnCreateSpend_Click);
            // 
            // btnSpendList
            // 
            this.btnSpendList.BackColor = System.Drawing.Color.Silver;
            this.btnSpendList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendList.ForeColor = System.Drawing.Color.Black;
            this.btnSpendList.Location = new System.Drawing.Point(140, 188);
            this.btnSpendList.Name = "btnSpendList";
            this.btnSpendList.Size = new System.Drawing.Size(162, 40);
            this.btnSpendList.TabIndex = 0;
            this.btnSpendList.Text = "Masraf Listesi";
            this.btnSpendList.UseVisualStyleBackColor = false;
            this.btnSpendList.Click += new System.EventHandler(this.btnSpendList_Click);
            // 
            // txtSpendDate
            // 
            this.txtSpendDate.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendDate.Location = new System.Drawing.Point(118, 117);
            this.txtSpendDate.Name = "txtSpendDate";
            this.txtSpendDate.Size = new System.Drawing.Size(725, 29);
            this.txtSpendDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tarih:";
            // 
            // txtSpendAmount
            // 
            this.txtSpendAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendAmount.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendAmount.Location = new System.Drawing.Point(118, 82);
            this.txtSpendAmount.Name = "txtSpendAmount";
            this.txtSpendAmount.Size = new System.Drawing.Size(725, 29);
            this.txtSpendAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar:";
            // 
            // txtSpendTitle
            // 
            this.txtSpendTitle.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendTitle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendTitle.Location = new System.Drawing.Point(118, 47);
            this.txtSpendTitle.Name = "txtSpendTitle";
            this.txtSpendTitle.Size = new System.Drawing.Size(725, 29);
            this.txtSpendTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Başlık:";
            // 
            // txtSpendId
            // 
            this.txtSpendId.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendId.Location = new System.Drawing.Point(118, 12);
            this.txtSpendId.Name = "txtSpendId";
            this.txtSpendId.Size = new System.Drawing.Size(725, 29);
            this.txtSpendId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masraf Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
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
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Masraf Formu";
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
            this.panel1.Location = new System.Drawing.Point(1, 45);
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
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSpendings";
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
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
        private System.Windows.Forms.Button btnUpdateSpend;
        private System.Windows.Forms.Button btnRemoveSpend;
        private System.Windows.Forms.Button btnCreateSpend;
        private System.Windows.Forms.Button btnSpendList;
        private System.Windows.Forms.TextBox txtSpendDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpendAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpendTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBanking;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox txtSpendCategoryId;
        private System.Windows.Forms.Label label6;
    }
}