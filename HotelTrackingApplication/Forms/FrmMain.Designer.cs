namespace HotelTracingApplication
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnReservation = new ToolStripButton();
            btnNewReservation = new ToolStripButton();
            btnRoom = new ToolStripButton();
            btnCustomer = new ToolStripButton();
            btnExit = new ToolStripButton();
            label1 = new Label();
            lbTitle = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 152);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(64, 64);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReservation, btnNewReservation, btnRoom, btnCustomer, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(821, 86);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReservation
            // 
            btnReservation.ForeColor = SystemColors.HotTrack;
            btnReservation.Image = (Image)resources.GetObject("btnReservation.Image");
            btnReservation.ImageTransparentColor = Color.Magenta;
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(89, 83);
            btnReservation.Text = "Rezervasyonlar";
            btnReservation.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnNewReservation
            // 
            btnNewReservation.ForeColor = SystemColors.HotTrack;
            btnNewReservation.Image = (Image)resources.GetObject("btnNewReservation.Image");
            btnNewReservation.ImageTransparentColor = Color.Magenta;
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(101, 83);
            btnNewReservation.Text = "Yeni Rezervasyon";
            btnNewReservation.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNewReservation.Click += btnNewReservation_Click;
            // 
            // btnRoom
            // 
            btnRoom.ForeColor = SystemColors.HotTrack;
            btnRoom.Image = (Image)resources.GetObject("btnRoom.Image");
            btnRoom.ImageTransparentColor = Color.Magenta;
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(68, 83);
            btnRoom.Text = "Odalar";
            btnRoom.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.ForeColor = SystemColors.HotTrack;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageTransparentColor = Color.Magenta;
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(68, 83);
            btnCustomer.Text = "Müşteriler";
            btnCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 83);
            btnExit.Text = "Çıkış";
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 33);
            label1.TabIndex = 0;
            label1.Text = "Otel Takip Modülü";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(20, 119);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(100, 23);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Alt Başlık";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 152);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(821, 219);
            panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 371);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otel Takip Uygulaması";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTitle;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReservation;
        private ToolStripButton btnCustomer;
        private ToolStripButton btnExit;
        private Label label1;
        public Panel panel2;
        private ToolStripButton btnRoom;
        private ToolStripButton btnNewReservation;
    }
}