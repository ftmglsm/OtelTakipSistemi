namespace HotelTracingApplication.Forms
{
    partial class FrmNewReservation
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
            groupBox3 = new GroupBox();
            dtStart = new DateTimePicker();
            label3 = new Label();
            dtEnd = new DateTimePicker();
            label2 = new Label();
            btnRoomList = new Button();
            groupBox1 = new GroupBox();
            btnGetCustomerById = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tbxEmail = new TextBox();
            tbxPhone = new TextBox();
            tbxLastname = new TextBox();
            tbxName = new TextBox();
            tbxTC = new TextBox();
            btnClear = new Button();
            btnCreate = new Button();
            dgRoom = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tbxTotalPrice = new TextBox();
            label10 = new Label();
            label8 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtStart);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dtEnd);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnRoomList);
            groupBox3.Location = new Point(12, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 124);
            groupBox3.TabIndex = 63;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tarih Aralığı";
            // 
            // dtStart
            // 
            dtStart.Enabled = false;
            dtStart.Location = new Point(64, 31);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(190, 23);
            dtStart.TabIndex = 10;
            dtStart.ValueChanged += dtStart_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 60);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "Çıkış";
            // 
            // dtEnd
            // 
            dtEnd.Enabled = false;
            dtEnd.Location = new Point(64, 60);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(190, 23);
            dtEnd.TabIndex = 11;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Giriş";
            // 
            // btnRoomList
            // 
            btnRoomList.BackColor = SystemColors.HotTrack;
            btnRoomList.Enabled = false;
            btnRoomList.FlatStyle = FlatStyle.Flat;
            btnRoomList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoomList.ForeColor = SystemColors.ActiveCaption;
            btnRoomList.Location = new Point(193, 88);
            btnRoomList.Margin = new Padding(2);
            btnRoomList.Name = "btnRoomList";
            btnRoomList.Size = new Size(61, 28);
            btnRoomList.TabIndex = 12;
            btnRoomList.Text = "Listele";
            btnRoomList.UseVisualStyleBackColor = false;
            btnRoomList.Click += btnRoomList_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetCustomerById);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxEmail);
            groupBox1.Controls.Add(tbxPhone);
            groupBox1.Controls.Add(tbxLastname);
            groupBox1.Controls.Add(tbxName);
            groupBox1.Controls.Add(tbxTC);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 215);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // btnGetCustomerById
            // 
            btnGetCustomerById.BackColor = SystemColors.HotTrack;
            btnGetCustomerById.FlatStyle = FlatStyle.Flat;
            btnGetCustomerById.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetCustomerById.ForeColor = SystemColors.ActiveCaption;
            btnGetCustomerById.Location = new Point(191, 57);
            btnGetCustomerById.Name = "btnGetCustomerById";
            btnGetCustomerById.Size = new Size(63, 28);
            btnGetCustomerById.TabIndex = 2;
            btnGetCustomerById.Text = "Gözat";
            btnGetCustomerById.UseVisualStyleBackColor = false;
            btnGetCustomerById.Click += btnGetCustomerById_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 181);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 152);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 0;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 124);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 94);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 0;
            label4.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(64, 178);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.ReadOnly = true;
            tbxEmail.Size = new Size(190, 23);
            tbxEmail.TabIndex = 6;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(64, 149);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.ReadOnly = true;
            tbxPhone.Size = new Size(190, 23);
            tbxPhone.TabIndex = 5;
            // 
            // tbxLastname
            // 
            tbxLastname.Location = new Point(64, 120);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.ReadOnly = true;
            tbxLastname.Size = new Size(190, 23);
            tbxLastname.TabIndex = 4;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(64, 91);
            tbxName.Name = "tbxName";
            tbxName.ReadOnly = true;
            tbxName.Size = new Size(190, 23);
            tbxName.TabIndex = 3;
            // 
            // tbxTC
            // 
            tbxTC.Location = new Point(64, 28);
            tbxTC.MaxLength = 11;
            tbxTC.Name = "tbxTC";
            tbxTC.Size = new Size(190, 23);
            tbxTC.TabIndex = 1;
            tbxTC.KeyPress += tbxTC_KeyPress;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(570, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 30);
            btnClear.TabIndex = 7;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.HotTrack;
            btnCreate.Enabled = false;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.ActiveCaption;
            btnCreate.Location = new Point(660, 395);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 31);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Oluştur";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgRoom
            // 
            dgRoom.AllowUserToAddRows = false;
            dgRoom.AllowUserToDeleteRows = false;
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgRoom.Location = new Point(313, 45);
            dgRoom.MultiSelect = false;
            dgRoom.Name = "dgRoom";
            dgRoom.ReadOnly = true;
            dgRoom.RowTemplate.Height = 25;
            dgRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRoom.Size = new Size(447, 316);
            dgRoom.TabIndex = 13;
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
            // tbxTotalPrice
            // 
            tbxTotalPrice.Location = new Point(660, 367);
            tbxTotalPrice.Name = "tbxTotalPrice";
            tbxTotalPrice.ReadOnly = true;
            tbxTotalPrice.Size = new Size(100, 23);
            tbxTotalPrice.TabIndex = 64;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(580, 370);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 63;
            label10.Text = "Toplam Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(313, 12);
            label8.Name = "label8";
            label8.Size = new Size(196, 30);
            label8.TabIndex = 65;
            label8.Text = "Kiralanabilir Odalar";
            // 
            // FrmNewReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(773, 444);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(dgRoom);
            Controls.Add(tbxTotalPrice);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(btnCreate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNewReservation";
            Text = "FrmNewReservation";
            WindowState = FormWindowState.Maximized;
            Load += FrmNewReservation_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private DateTimePicker dtStart;
        private Label label3;
        private DateTimePicker dtEnd;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnGetCustomerById;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox tbxEmail;
        private TextBox tbxPhone;
        private TextBox tbxLastname;
        private TextBox tbxName;
        private TextBox tbxTC;
        private Button btnCreate;
        private DataGridView dgRoom;
        private TextBox tbxTotalPrice;
        private Button btnRoomList;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label8;
    }
}