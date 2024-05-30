namespace HotelTracingApplication.Forms
{
    partial class FrmCustomer
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
            tbxPhone = new TextBox();
            label6 = new Label();
            tbxEmail = new TextBox();
            label4 = new Label();
            tbxLastname = new TextBox();
            label5 = new Label();
            tbxTc = new TextBox();
            label2 = new Label();
            dgCustomer = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnDelete = new Button();
            btnCreateOrUpdate = new Button();
            label3 = new Label();
            tbxName = new TextBox();
            groupBox1 = new GroupBox();
            tbxFilterByTc = new TextBox();
            btnFilterByTc = new Button();
            btnGetList = new Button();
            btnFilterByName = new Button();
            tbxFilterByName = new TextBox();
            tbxFilterByLastname = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dgReservation = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            tbxID = new TextBox();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            btnDeleteReservation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgReservation).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(64, 156);
            tbxPhone.Margin = new Padding(2);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(181, 23);
            tbxPhone.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 159);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 63;
            label6.Text = "Telefon";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(64, 129);
            tbxEmail.Margin = new Padding(2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(181, 23);
            tbxEmail.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 61;
            label4.Text = "E-Posta";
            // 
            // tbxLastname
            // 
            tbxLastname.Location = new Point(64, 102);
            tbxLastname.Margin = new Padding(2);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new Size(181, 23);
            tbxLastname.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 105);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 59;
            label5.Text = "Soyadı";
            // 
            // tbxTc
            // 
            tbxTc.Location = new Point(64, 48);
            tbxTc.Margin = new Padding(2);
            tbxTc.MaxLength = 11;
            tbxTc.Name = "tbxTc";
            tbxTc.Size = new Size(181, 23);
            tbxTc.TabIndex = 57;
            tbxTc.KeyPress += tbxTc_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 55;
            label2.Text = "TC";
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.AllowUserToDeleteRows = false;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { Column3, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Column1, dataGridViewTextBoxColumn4, Column5 });
            dgCustomer.Location = new Point(294, 44);
            dgCustomer.Margin = new Padding(2);
            dgCustomer.MultiSelect = false;
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 62;
            dgCustomer.RowTemplate.Height = 33;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(864, 221);
            dgCustomer.TabIndex = 54;
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "TC";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Soyadı";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(41, 197);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 28);
            btnClear.TabIndex = 65;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(1058, 269);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Müşteriyi Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreateOrUpdate
            // 
            btnCreateOrUpdate.BackColor = SystemColors.HotTrack;
            btnCreateOrUpdate.FlatStyle = FlatStyle.Flat;
            btnCreateOrUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrUpdate.ForeColor = SystemColors.ActiveCaption;
            btnCreateOrUpdate.Location = new Point(145, 197);
            btnCreateOrUpdate.Margin = new Padding(2);
            btnCreateOrUpdate.Name = "btnCreateOrUpdate";
            btnCreateOrUpdate.Size = new Size(100, 28);
            btnCreateOrUpdate.TabIndex = 66;
            btnCreateOrUpdate.Text = "Oluştur";
            btnCreateOrUpdate.UseVisualStyleBackColor = false;
            btnCreateOrUpdate.Click += btnCreateOrUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 78);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 59;
            label3.Text = "Adı";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(64, 75);
            tbxName.Margin = new Padding(2);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(181, 23);
            tbxName.TabIndex = 60;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxFilterByTc);
            groupBox1.Controls.Add(btnFilterByTc);
            groupBox1.Controls.Add(btnGetList);
            groupBox1.Controls.Add(btnFilterByName);
            groupBox1.Controls.Add(tbxFilterByName);
            groupBox1.Controls.Add(tbxFilterByLastname);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 253);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreleme";
            // 
            // tbxFilterByTc
            // 
            tbxFilterByTc.Location = new Point(64, 22);
            tbxFilterByTc.MaxLength = 11;
            tbxFilterByTc.Name = "tbxFilterByTc";
            tbxFilterByTc.Size = new Size(181, 23);
            tbxFilterByTc.TabIndex = 69;
            // 
            // btnFilterByTc
            // 
            btnFilterByTc.BackColor = SystemColors.HotTrack;
            btnFilterByTc.FlatStyle = FlatStyle.Flat;
            btnFilterByTc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilterByTc.ForeColor = SystemColors.ActiveCaption;
            btnFilterByTc.Location = new Point(170, 50);
            btnFilterByTc.Margin = new Padding(2);
            btnFilterByTc.Name = "btnFilterByTc";
            btnFilterByTc.Size = new Size(75, 30);
            btnFilterByTc.TabIndex = 61;
            btnFilterByTc.Text = "Filtrele";
            btnFilterByTc.UseVisualStyleBackColor = false;
            btnFilterByTc.Click += btnFilterByTc_Click;
            // 
            // btnGetList
            // 
            btnGetList.BackColor = SystemColors.HotTrack;
            btnGetList.FlatStyle = FlatStyle.Flat;
            btnGetList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetList.ForeColor = SystemColors.ActiveCaption;
            btnGetList.Location = new Point(125, 218);
            btnGetList.Margin = new Padding(2);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(133, 30);
            btnGetList.TabIndex = 76;
            btnGetList.Text = "Filtreyi Temizle";
            btnGetList.UseVisualStyleBackColor = false;
            btnGetList.Click += btnGetList_Click;
            // 
            // btnFilterByName
            // 
            btnFilterByName.BackColor = SystemColors.HotTrack;
            btnFilterByName.FlatStyle = FlatStyle.Flat;
            btnFilterByName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilterByName.ForeColor = SystemColors.ActiveCaption;
            btnFilterByName.Location = new Point(170, 159);
            btnFilterByName.Margin = new Padding(2);
            btnFilterByName.Name = "btnFilterByName";
            btnFilterByName.Size = new Size(75, 30);
            btnFilterByName.TabIndex = 61;
            btnFilterByName.Text = "Filtrele";
            btnFilterByName.UseVisualStyleBackColor = false;
            btnFilterByName.Click += btnFilterByName_Click;
            // 
            // tbxFilterByName
            // 
            tbxFilterByName.Location = new Point(64, 102);
            tbxFilterByName.MaxLength = 32;
            tbxFilterByName.Name = "tbxFilterByName";
            tbxFilterByName.Size = new Size(181, 23);
            tbxFilterByName.TabIndex = 70;
            // 
            // tbxFilterByLastname
            // 
            tbxFilterByLastname.Location = new Point(64, 131);
            tbxFilterByLastname.MaxLength = 32;
            tbxFilterByLastname.Name = "tbxFilterByLastname";
            tbxFilterByLastname.Size = new Size(181, 23);
            tbxFilterByLastname.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 25);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 68;
            label9.Text = "TC";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 134);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 66;
            label10.Text = "Soyad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 105);
            label11.Name = "label11";
            label11.Size = new Size(22, 15);
            label11.TabIndex = 67;
            label11.Text = "Ad";
            // 
            // dgReservation
            // 
            dgReservation.AllowUserToAddRows = false;
            dgReservation.AllowUserToDeleteRows = false;
            dgReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReservation.Columns.AddRange(new DataGridViewColumn[] { Column9, Column2, Column6, Column7, Column8 });
            dgReservation.Location = new Point(294, 321);
            dgReservation.Margin = new Padding(2);
            dgReservation.MultiSelect = false;
            dgReservation.Name = "dgReservation";
            dgReservation.ReadOnly = true;
            dgReservation.RowHeadersWidth = 62;
            dgReservation.RowTemplate.Height = 33;
            dgReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReservation.Size = new Size(567, 220);
            dgReservation.TabIndex = 77;
            dgReservation.CellClick += dgReservation_CellClick;
            // 
            // Column9
            // 
            Column9.HeaderText = "ID";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Oda";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Başlangıç";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Bitiş";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ücret";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbxID);
            groupBox2.Controls.Add(tbxTc);
            groupBox2.Controls.Add(btnCreateOrUpdate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbxPhone);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbxLastname);
            groupBox2.Controls.Add(tbxEmail);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbxName);
            groupBox2.Location = new Point(1184, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 253);
            groupBox2.TabIndex = 78;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri oluştur veya güncelle";
            // 
            // tbxID
            // 
            tbxID.Enabled = false;
            tbxID.Location = new Point(64, 21);
            tbxID.Margin = new Padding(2);
            tbxID.MaxLength = 11;
            tbxID.Name = "tbxID";
            tbxID.ReadOnly = true;
            tbxID.Size = new Size(101, 23);
            tbxID.TabIndex = 56;
            tbxID.KeyPress += tbxTc_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 24);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 55;
            label8.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 55;
            label1.Text = "Müşteriler";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(294, 289);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(285, 30);
            label7.TabIndex = 55;
            label7.Text = "Müşteriye ait rezervasyonlar";
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.BackColor = SystemColors.HotTrack;
            btnDeleteReservation.FlatStyle = FlatStyle.Flat;
            btnDeleteReservation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteReservation.ForeColor = SystemColors.ActiveCaption;
            btnDeleteReservation.Location = new Point(731, 545);
            btnDeleteReservation.Margin = new Padding(2);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(130, 28);
            btnDeleteReservation.TabIndex = 53;
            btnDeleteReservation.Text = "Rezervasyonu Sil";
            btnDeleteReservation.UseVisualStyleBackColor = false;
            btnDeleteReservation.Click += btnDeleteReservation_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1521, 578);
            Controls.Add(groupBox2);
            Controls.Add(dgReservation);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Controls.Add(btnDeleteReservation);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgReservation).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPhone;
        private Label label6;
        private TextBox tbxEmail;
        private Label label4;
        private TextBox tbxLastname;
        private Label label5;
        private TextBox tbxTc;
        private Label label2;
        private DataGridView dgCustomer;
        private Button btnClear;
        private Button btnDelete;
        private Button btnCreateOrUpdate;
        private Label label3;
        private TextBox tbxName;
        private GroupBox groupBox1;
        private TextBox tbxFilterByTc;
        private Button btnFilterByTc;
        private Button btnFilterByName;
        private TextBox tbxFilterByName;
        private TextBox tbxFilterByLastname;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnGetList;
        private DataGridView dgReservation;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private GroupBox groupBox2;
        private Label label1;
        private Label label7;
        private Button btnDeleteReservation;
        private TextBox tbxID;
        private Label label8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
    }
}