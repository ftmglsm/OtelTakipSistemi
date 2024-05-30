using HotelTracingApplication.Forms;

namespace HotelTracingApplication
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenForm(new FrmReservation());
            lbTitle.Text = "Rezervasyonlar";
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReservation());
            lbTitle.Text = "Rezervasyonlar";
        }
        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmNewReservation());
            lbTitle.Text = "Yeni Rezervasyon";
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRoom());
            lbTitle.Text = "Oda Yönetimi";
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCustomer());
            lbTitle.Text = "Müþteriler";
        }
        private void OpenForm(Form f)
        {
            panel2.Controls.Clear();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.BackColor = SystemColors.ActiveCaption;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ForeColor = SystemColors.HotTrack;
            f.Show();
        }

    }
}