using HotelTrackingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTracingApplication.Forms
{
    public partial class FrmReservation : Form
    {
        int selectedReservationID = -1;
        AppDbContext db = new AppDbContext();
        Expression<Func<Reservation, bool>> predicate = null;

        public FrmReservation()
        {
            InitializeComponent();
        }

        private void DeleteReservationById(int id)
        {
            Reservation reservation = db.Reservations.SingleOrDefault(r => r.Id == id);
            db.Remove(reservation);
            db.SaveChanges();
        }
        private async void PerformDataGridAssignment(Expression<Func<Reservation, bool>> predicate)
        {
            List<Reservation> reservations = predicate == null
                ? await db.Reservations.Include(r => r.Customer).Include(r => r.Room).ToListAsync()
                : await db.Reservations.Include(r => r.Customer).Include(r => r.Room).Where(predicate).ToListAsync();

            dgReservation.Rows.Clear();
            foreach (Reservation reservation in reservations)
            {
                dgReservation.Rows.Add(reservation.Id, reservation.Customer.Tc, reservation.Room.Name, reservation.Customer.Name, reservation.Customer.Lastname,
                    reservation.Customer.Phone, reservation.StartTime, reservation.EndTime, reservation.Price);
            }
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            dtFilterByStart.Value = DateTime.Today;
            PerformDataGridAssignment(predicate);
        }
        private void dgReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedReservationID = Convert.ToInt32(dgReservation.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            tbxFilterByTc.Text = null;
            tbxFilterByName.Text = null;
            tbxFilterByLastname.Text = null;
            dtFilterByStart.Value = DateTime.Today;
            dtFilterByEnd.Value = DateTime.Today.AddDays(1);
            predicate = null;
            PerformDataGridAssignment(predicate);
        }
        private void btnFilterByTc_Click(object sender, EventArgs e)
        {
            if (tbxFilterByTc.Text.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            predicate = r => r.Customer.Tc == Convert.ToInt64(tbxFilterByTc.Text);
            PerformDataGridAssignment(predicate);
        }
        private void btnFilterByName_Click(object sender, EventArgs e)
        {
            predicate = r => r.Customer.Name.Contains(tbxFilterByName.Text) && r.Customer.Lastname.Contains(tbxFilterByLastname.Text);
            PerformDataGridAssignment(predicate);
        }
        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            predicate = r => !(dtFilterByEnd.Value <= r.StartTime || r.EndTime <= dtFilterByStart.Value);
            PerformDataGridAssignment(predicate);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReservationID < 0)
            {
                MessageBox.Show("Lütfen rezervasyon seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DeleteReservationById(selectedReservationID);
            PerformDataGridAssignment(predicate);
            selectedReservationID = -1;
        }

        private void tbxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtFilterByStart.Value = new DateTime(dtFilterByStart.Value.Year, dtFilterByStart.Value.Month, dtFilterByStart.Value.Day);
            if (dtFilterByStart.Value < DateTime.Today)
            {
                dtFilterByStart.Value = DateTime.Today;
                MessageBox.Show("Başlangıç tarihi bugünün tarihinden küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dtFilterByEnd.Value <= dtFilterByStart.Value)
                dtFilterByEnd.Value = dtFilterByStart.Value.AddDays(1);
        }
        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            dtFilterByEnd.Value = new DateTime(dtFilterByEnd.Value.Year, dtFilterByEnd.Value.Month, dtFilterByEnd.Value.Day);
            if (dtFilterByStart.Value >= dtFilterByEnd.Value)
            {
                dtFilterByEnd.Value = dtFilterByStart.Value.AddDays(1);
                MessageBox.Show("Başlangıç tarihinden küçük veya eşit olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnFilterByDate.Enabled = true;
        }
    }
}
