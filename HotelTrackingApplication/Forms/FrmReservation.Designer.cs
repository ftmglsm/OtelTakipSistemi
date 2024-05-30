namespace HotelTracingApplication.Forms
{
    partial class FrmReservation
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
            dgReservation = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnFilterByDate = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            tbxFilterByLastname = new TextBox();
            tbxFilterByName = new TextBox();
            tbxFilterByTc = new TextBox();
            dtFilterByStart = new DateTimePicker();
            label3 = new Label();
            dtFilterByEnd = new DateTimePicker();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnFilterByTc = new Button();
            btnGetList = new Button();
            btnFilterByName = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgReservation).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgReservation
            // 
            dgReservation.AllowUserToAddRows = false;
            dgReservation.AllowUserToDeleteRows = false;
            dgReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReservation.Columns.AddRange(new DataGridViewColumn[] { Column9, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgReservation.Location = new Point(306, 43);
            dgReservation.Margin = new Padding(2);
            dgReservation.MultiSelect = false;
            dgReservation.Name = "dgReservation";
            dgReservation.ReadOnly = true;
            dgReservation.RowHeadersWidth = 62;
            dgReservation.RowTemplate.Height = 33;
            dgReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReservation.Size = new Size(944, 542);
            dgReservation.TabIndex = 55;
            dgReservation.CellClick += dgReservation_CellClick;
            // 
            // Column9
            // 
            Column9.HeaderText = "ID";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "TC";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Oda";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Soyad";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
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
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(1114, 589);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 33);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Seçileni Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFilterByDate
            // 
            btnFilterByDate.BackColor = SystemColors.HotTrack;
            btnFilterByDate.Enabled = false;
            btnFilterByDate.FlatStyle = FlatStyle.Flat;
            btnFilterByDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilterByDate.ForeColor = SystemColors.ActiveCaption;
            btnFilterByDate.Location = new Point(170, 256);
            btnFilterByDate.Margin = new Padding(2);
            btnFilterByDate.Name = "btnFilterByDate";
            btnFilterByDate.Size = new Size(75, 30);
            btnFilterByDate.TabIndex = 61;
            btnFilterByDate.Text = "Filtrele";
            btnFilterByDate.UseVisualStyleBackColor = false;
            btnFilterByDate.Click += btnFilterByDate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 129);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 66;
            label5.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 100);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 67;
            label4.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 68;
            label1.Text = "TC";
            // 
            // tbxFilterByLastname
            // 
            tbxFilterByLastname.Location = new Point(64, 126);
            tbxFilterByLastname.MaxLength = 32;
            tbxFilterByLastname.Name = "tbxFilterByLastname";
            tbxFilterByLastname.Size = new Size(181, 23);
            tbxFilterByLastname.TabIndex = 71;
            // 
            // tbxFilterByName
            // 
            tbxFilterByName.Location = new Point(64, 97);
            tbxFilterByName.MaxLength = 32;
            tbxFilterByName.Name = "tbxFilterByName";
            tbxFilterByName.Size = new Size(181, 23);
            tbxFilterByName.TabIndex = 70;
            // 
            // tbxFilterByTc
            // 
            tbxFilterByTc.Location = new Point(64, 22);
            tbxFilterByTc.MaxLength = 11;
            tbxFilterByTc.Name = "tbxFilterByTc";
            tbxFilterByTc.Size = new Size(181, 23);
            tbxFilterByTc.TabIndex = 69;
            tbxFilterByTc.KeyPress += tbxTC_KeyPress;
            // 
            // dtFilterByStart
            // 
            dtFilterByStart.Location = new Point(64, 199);
            dtFilterByStart.Name = "dtFilterByStart";
            dtFilterByStart.Size = new Size(181, 23);
            dtFilterByStart.TabIndex = 10;
            dtFilterByStart.ValueChanged += dtStart_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 228);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 0;
            label3.Text = "Bitiş";
            // 
            // dtFilterByEnd
            // 
            dtFilterByEnd.Location = new Point(64, 228);
            dtFilterByEnd.Name = "dtFilterByEnd";
            dtFilterByEnd.Size = new Size(181, 23);
            dtFilterByEnd.TabIndex = 11;
            dtFilterByEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 199);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Başlangıç";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxFilterByTc);
            groupBox1.Controls.Add(dtFilterByStart);
            groupBox1.Controls.Add(btnFilterByTc);
            groupBox1.Controls.Add(btnGetList);
            groupBox1.Controls.Add(btnFilterByName);
            groupBox1.Controls.Add(btnFilterByDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxFilterByName);
            groupBox1.Controls.Add(tbxFilterByLastname);
            groupBox1.Controls.Add(dtFilterByEnd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 349);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreleme";
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
            btnGetList.Location = new Point(138, 314);
            btnGetList.Margin = new Padding(2);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(125, 30);
            btnGetList.TabIndex = 61;
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
            btnFilterByName.Location = new Point(170, 152);
            btnFilterByName.Margin = new Padding(2);
            btnFilterByName.Name = "btnFilterByName";
            btnFilterByName.Size = new Size(75, 30);
            btnFilterByName.TabIndex = 61;
            btnFilterByName.Text = "Filtrele";
            btnFilterByName.UseVisualStyleBackColor = false;
            btnFilterByName.Click += btnFilterByName_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(306, 11);
            label6.Name = "label6";
            label6.Size = new Size(158, 30);
            label6.TabIndex = 68;
            label6.Text = "Rezervasyonlar";
            // 
            // FrmReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1261, 633);
            Controls.Add(groupBox1);
            Controls.Add(dgReservation);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmReservation";
            Text = "FrmWork";
            WindowState = FormWindowState.Maximized;
            Load += FrmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dgReservation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelete;
        private DataGridView dgReservation;
        private DataGridView dgWork;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button btnFilterByDate;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox tbxFilterByLastname;
        private TextBox tbxFilterByName;
        private TextBox tbxFilterByTc;
        private DateTimePicker dtFilterByStart;
        private Label label3;
        private DateTimePicker dtFilterByEnd;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnFilterByTc;
        private Button btnFilterByName;
        private Button btnGetList;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label6;
    }
}