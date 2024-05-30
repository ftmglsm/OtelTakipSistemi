namespace HotelTracingApplication.Forms
{
    partial class FrmRoom
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
            tbxName = new TextBox();
            label1 = new Label();
            tbxCapacity = new TextBox();
            label2 = new Label();
            tbxPrice = new TextBox();
            label3 = new Label();
            btnDelete = new Button();
            btnCreateOrUpdate = new Button();
            btnClear = new Button();
            tbxNameForFilter = new TextBox();
            btnFilterByName = new Button();
            label4 = new Label();
            dgRoom = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tbxId = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnGetList = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tbxName
            // 
            tbxName.Location = new Point(73, 51);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(204, 23);
            tbxName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 54);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 69;
            label1.Text = "Oda Adı";
            // 
            // tbxCapacity
            // 
            tbxCapacity.Location = new Point(73, 80);
            tbxCapacity.MaxLength = 2;
            tbxCapacity.Name = "tbxCapacity";
            tbxCapacity.Size = new Size(204, 23);
            tbxCapacity.TabIndex = 6;
            tbxCapacity.KeyPress += tbxCapacity_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 83);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 69;
            label2.Text = "Kapasitesi";
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(73, 109);
            tbxPrice.MaxLength = 16;
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(204, 23);
            tbxPrice.TabIndex = 7;
            tbxPrice.KeyPress += tbxPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 112);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 69;
            label3.Text = "Fiyat";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(640, 411);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Seçileni Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreateOrUpdate
            // 
            btnCreateOrUpdate.BackColor = SystemColors.HotTrack;
            btnCreateOrUpdate.FlatStyle = FlatStyle.Flat;
            btnCreateOrUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrUpdate.ForeColor = SystemColors.ActiveCaption;
            btnCreateOrUpdate.Location = new Point(177, 153);
            btnCreateOrUpdate.Margin = new Padding(2);
            btnCreateOrUpdate.Name = "btnCreateOrUpdate";
            btnCreateOrUpdate.Size = new Size(100, 28);
            btnCreateOrUpdate.TabIndex = 8;
            btnCreateOrUpdate.Text = "Oluştur";
            btnCreateOrUpdate.UseVisualStyleBackColor = false;
            btnCreateOrUpdate.Click += btnCreateOrUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(73, 153);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 28);
            btnClear.TabIndex = 11;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbxNameForFilter
            // 
            tbxNameForFilter.Location = new Point(69, 22);
            tbxNameForFilter.MaxLength = 11;
            tbxNameForFilter.Name = "tbxNameForFilter";
            tbxNameForFilter.Size = new Size(178, 23);
            tbxNameForFilter.TabIndex = 1;
            // 
            // btnFilterByName
            // 
            btnFilterByName.BackColor = SystemColors.HotTrack;
            btnFilterByName.FlatStyle = FlatStyle.Flat;
            btnFilterByName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilterByName.ForeColor = SystemColors.ActiveCaption;
            btnFilterByName.Location = new Point(172, 50);
            btnFilterByName.Margin = new Padding(2);
            btnFilterByName.Name = "btnFilterByName";
            btnFilterByName.Size = new Size(75, 28);
            btnFilterByName.TabIndex = 2;
            btnFilterByName.Text = "Filtrele";
            btnFilterByName.UseVisualStyleBackColor = false;
            btnFilterByName.Click += btnFilterByName_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 25);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 78;
            label4.Text = "Oda Adı:";
            // 
            // dgRoom
            // 
            dgRoom.AllowUserToAddRows = false;
            dgRoom.AllowUserToDeleteRows = false;
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgRoom.Location = new Point(293, 41);
            dgRoom.MultiSelect = false;
            dgRoom.Name = "dgRoom";
            dgRoom.ReadOnly = true;
            dgRoom.RowTemplate.Height = 25;
            dgRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRoom.Size = new Size(447, 365);
            dgRoom.TabIndex = 4;
            dgRoom.CellClick += dgRoom_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kapasitesi";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ücreti";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // tbxId
            // 
            tbxId.Enabled = false;
            tbxId.Location = new Point(73, 22);
            tbxId.Name = "tbxId";
            tbxId.ReadOnly = true;
            tbxId.Size = new Size(100, 23);
            tbxId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 25);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 69;
            label5.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(tbxName);
            groupBox1.Controls.Add(tbxCapacity);
            groupBox1.Controls.Add(tbxPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCreateOrUpdate);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(768, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 198);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oda oluştur veya güncelle";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbxNameForFilter);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnGetList);
            groupBox2.Controls.Add(btnFilterByName);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 99);
            groupBox2.TabIndex = 80;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtreleme";
            // 
            // btnGetList
            // 
            btnGetList.BackColor = SystemColors.HotTrack;
            btnGetList.FlatStyle = FlatStyle.Flat;
            btnGetList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetList.ForeColor = SystemColors.ActiveCaption;
            btnGetList.Location = new Point(82, 50);
            btnGetList.Margin = new Padding(2);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(86, 28);
            btnGetList.TabIndex = 2;
            btnGetList.Text = "Temizle";
            btnGetList.UseVisualStyleBackColor = false;
            btnGetList.Click += btnGetList_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(293, 8);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 78;
            label6.Text = "Odalar";
            // 
            // FrmRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1075, 450);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgRoom);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRoom";
            Text = "FrmRegisteration";
            WindowState = FormWindowState.Maximized;
            Load += FrmRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dgRoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxName;
        private Label label1;
        private TextBox tbxCapacity;
        private Label label2;
        private TextBox tbxPrice;
        private Label label3;
        private Button btnDelete;
        private Button btnCreateOrUpdate;
        private Button btnClear;
        private TextBox tbxNameForFilter;
        private Button btnFilterByName;
        private Label label4;
        private DataGridView dgRoom;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbxId;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Button btnGetList;
    }
}