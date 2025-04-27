namespace FinancialCrm
{
    partial class FrmBanking
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBanking = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBankingDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankingDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankingId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBankingAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankingName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxGelenHavale = new System.Windows.Forms.CheckBox();
            this.checkBoxGidenHavale = new System.Windows.Forms.CheckBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(2, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(892, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------------------------------";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(218, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 289);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banka Hareketleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 262);
            this.dataGridView1.TabIndex = 10;
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
            this.panel1.Location = new System.Drawing.Point(-2, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 584);
            this.panel1.TabIndex = 14;
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.Transparent;
            this.btnFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFatura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ForeColor = System.Drawing.Color.Transparent;
            this.btnFatura.Location = new System.Drawing.Point(29, 158);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(173, 44);
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
            this.btnExit.Location = new System.Drawing.Point(29, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 44);
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
            this.btnSettings.Location = new System.Drawing.Point(29, 423);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(173, 44);
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
            this.btnDashboard.Location = new System.Drawing.Point(29, 357);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(173, 44);
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
            this.btnBanking.Location = new System.Drawing.Point(32, 284);
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
            this.btnBillForm.Location = new System.Drawing.Point(29, 219);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(173, 44);
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
            this.btnBanksForm.Location = new System.Drawing.Point(29, 102);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(173, 44);
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
            this.btnCategory.Location = new System.Drawing.Point(29, 29);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(173, 44);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Kategoriler";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Banka İşlemleri Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 47);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(217, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Havale Tipi:";
            // 
            // txtBankingDate
            // 
            this.txtBankingDate.BackColor = System.Drawing.Color.Khaki;
            this.txtBankingDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankingDate.Location = new System.Drawing.Point(332, 133);
            this.txtBankingDate.Name = "txtBankingDate";
            this.txtBankingDate.Size = new System.Drawing.Size(725, 29);
            this.txtBankingDate.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(268, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tarih:";
            // 
            // txtBankingDescription
            // 
            this.txtBankingDescription.BackColor = System.Drawing.Color.Khaki;
            this.txtBankingDescription.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankingDescription.Location = new System.Drawing.Point(332, 98);
            this.txtBankingDescription.Name = "txtBankingDescription";
            this.txtBankingDescription.Size = new System.Drawing.Size(725, 29);
            this.txtBankingDescription.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(234, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Açıklama:";
            // 
            // txtBankingId
            // 
            this.txtBankingId.BackColor = System.Drawing.Color.Khaki;
            this.txtBankingId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankingId.Location = new System.Drawing.Point(332, 63);
            this.txtBankingId.Name = "txtBankingId";
            this.txtBankingId.Size = new System.Drawing.Size(725, 29);
            this.txtBankingId.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(244, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "İşlem Id:";
            // 
            // txtBankingAmount
            // 
            this.txtBankingAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtBankingAmount.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankingAmount.Location = new System.Drawing.Point(332, 205);
            this.txtBankingAmount.Name = "txtBankingAmount";
            this.txtBankingAmount.Size = new System.Drawing.Size(725, 29);
            this.txtBankingAmount.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(265, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tutar:";
            // 
            // txtBankingName
            // 
            this.txtBankingName.BackColor = System.Drawing.Color.Khaki;
            this.txtBankingName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankingName.Location = new System.Drawing.Point(332, 241);
            this.txtBankingName.Name = "txtBankingName";
            this.txtBankingName.Size = new System.Drawing.Size(725, 29);
            this.txtBankingName.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(219, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Banka İsmi:";
            // 
            // checkBoxGelenHavale
            // 
            this.checkBoxGelenHavale.AutoSize = true;
            this.checkBoxGelenHavale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGelenHavale.Location = new System.Drawing.Point(332, 173);
            this.checkBoxGelenHavale.Name = "checkBoxGelenHavale";
            this.checkBoxGelenHavale.Size = new System.Drawing.Size(143, 28);
            this.checkBoxGelenHavale.TabIndex = 36;
            this.checkBoxGelenHavale.Text = "Gelen Havale";
            this.checkBoxGelenHavale.UseVisualStyleBackColor = true;
            // 
            // checkBoxGidenHavale
            // 
            this.checkBoxGidenHavale.AutoSize = true;
            this.checkBoxGidenHavale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGidenHavale.Location = new System.Drawing.Point(488, 173);
            this.checkBoxGidenHavale.Name = "checkBoxGidenHavale";
            this.checkBoxGidenHavale.Size = new System.Drawing.Size(144, 28);
            this.checkBoxGidenHavale.TabIndex = 37;
            this.checkBoxGidenHavale.Text = "Giden Havale";
            this.checkBoxGidenHavale.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(869, 276);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(162, 46);
            this.btnUpdateCategory.TabIndex = 41;
            this.btnUpdateCategory.Text = "İşlemi Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCategory.Location = new System.Drawing.Point(701, 276);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(162, 46);
            this.btnRemoveCategory.TabIndex = 40;
            this.btnRemoveCategory.Text = "İşlemi Sil";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnCreateCategory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategory.Location = new System.Drawing.Point(521, 276);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(162, 46);
            this.btnCreateCategory.TabIndex = 39;
            this.btnCreateCategory.Text = "Yeni İşlem";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.Color.Silver;
            this.btnCategoryList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryList.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryList.Location = new System.Drawing.Point(339, 276);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(162, 46);
            this.btnCategoryList.TabIndex = 38;
            this.btnCategoryList.Text = "İşlem Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            // 
            // FrmBanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1185, 629);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.btnCategoryList);
            this.Controls.Add(this.checkBoxGidenHavale);
            this.Controls.Add(this.checkBoxGelenHavale);
            this.Controls.Add(this.txtBankingName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBankingAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBankingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankingDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBankingId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanking";
            this.Text = "FrmBanking";
            this.Load += new System.EventHandler(this.FrmBanking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBanking;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBankingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankingDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankingId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankingName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxGelenHavale;
        private System.Windows.Forms.CheckBox checkBoxGidenHavale;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}