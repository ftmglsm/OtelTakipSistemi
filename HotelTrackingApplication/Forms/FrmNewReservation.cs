using HotelTrackingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTracingApplication.Forms
{
    public partial class FrmNewReservation : Form
    {
        public FrmNewReservation()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        Room? selectedRoom;
        Customer? selectedCustomer;

        private Customer? GetCustomerByTc(string tcText)
        {
            long tc = Convert.ToInt64(tcText);
            return db.Customers.SingleOrDefault(c => c.Tc == tc);
        }
        private Room? GetRoomById(int id)
        {
            return db.Rooms.SingleOrDefault(r => r.Id == id);
        }
        private async void PerformDataGridAssignment(DateTime startDateTime, DateTime endDateTime)
        {
            List<Room> rooms = await db.Rooms
                .Where(room => !db.Reservations
                    .Any(reservation => reservation.RoomId == room.Id
                      && !(endDateTime <= reservation.StartTime || reservation.EndTime <= startDateTime)
                      ))
                .ToListAsync();

            PerformDataGridAssignment(rooms);
        }
        private void PerformDataGridAssignment(List<Room> rooms)
        {
            dgRoom.Rows.Clear();
            foreach (Room room in rooms)
            {
                dgRoom.Rows.Add(room.Id, room.Name, room.Capacity, room.Price);
            }
        }
        private double CalculateTotalPrice(DateTime start, DateTime end, double price) => Math.Round((end - start).TotalDays) * price;

        private void FrmNewReservation_Load(object sender, EventArgs e)
        {

        }
        private void dgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedRoom = GetRoomById(Convert.ToInt32(dgRoom.Rows[e.RowIndex].Cells[0].Value));
            tbxTotalPrice.Text = "₺" + CalculateTotalPrice(dtStart.Value, dtEnd.Value, selectedRoom.Price);
            btnCreate.Enabled = true;
        }

        private void btnGetCustomerById_Click(object sender, EventArgs e)
        {
            if (tbxTC.Text.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedCustomer = GetCustomerByTc(tbxTC.Text);
            if (selectedCustomer == null)
            {
                MessageBox.Show("Müşteri bulunamadı! Lütfen ilk önce müşteriyi oluşturun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbxName.Text = selectedCustomer.Name;
            tbxLastname.Text = selectedCustomer.Lastname;
            tbxPhone.Text = selectedCustomer.Phone;
            tbxEmail.Text = selectedCustomer.Email;

            tbxTC.Enabled = false;
            dtStart.Enabled = true;
            dtEnd.Enabled = true;
            dtStart.Value = DateTime.Today;
            dtEnd.Value = DateTime.Today.AddDays(1);
            btnRoomList.Enabled = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxTC.Text = null;
            tbxName.Text = null;
            tbxLastname.Text = null;
            tbxPhone.Text = null;
            tbxEmail.Text = null;
            tbxTotalPrice.Text = null;
            dgRoom.Rows.Clear();

            tbxTC.Enabled = true;
            btnRoomList.Enabled = false;
            dtStart.Enabled = false;
            dtEnd.Enabled = false;
            btnCreate.Enabled = false;
            dtStart.Value = DateTime.Today;
            dtEnd.Value = DateTime.Today.AddDays(1);
            btnRoomList.Enabled = false;
        }
        private void btnRoomList_Click(object sender, EventArgs e)
        {
            if (dtStart.Value < DateTime.Today)
            {
                MessageBox.Show("Başlangıç tarihi bugünün tarihinden küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtStart.Value >= dtEnd.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük veya eşit olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PerformDataGridAssignment(dtStart.Value, dtEnd.Value);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Müşteri belirtilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedRoom == null)
            {
                MessageBox.Show("Oda seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Reservation reservation = new Reservation
            {
                CustomerId = selectedCustomer.Id,
                RoomId = selectedRoom.Id,
                StartTime = dtStart.Value,
                EndTime = dtEnd.Value,
                Price = CalculateTotalPrice(dtStart.Value, dtEnd.Value, selectedRoom.Price)
            };
            db.Reservations.Add(reservation);
            db.SaveChanges();
            MessageBox.Show("Rezervasyon Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtStart.Value = new DateTime(dtStart.Value.Year, dtStart.Value.Month, dtStart.Value.Day);
            if (dtStart.Value < DateTime.Today)
            {
                dtStart.Value = DateTime.Today;
                MessageBox.Show("Başlangıç tarihi bugünün tarihinden küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dtEnd.Value <= dtStart.Value)
                dtEnd.Value = dtStart.Value.AddDays(1);

            dgRoom.Rows.Clear();
            tbxTotalPrice.Text = null;
            btnCreate.Enabled = false;
        }
        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            dtEnd.Value = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, dtEnd.Value.Day);
            if (dtStart.Value >= dtEnd.Value)
            {
                dtEnd.Value = dtStart.Value.AddDays(1);
                MessageBox.Show("Başlangıç tarihinden küçük veya eşit olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgRoom.Rows.Clear();
            tbxTotalPrice.Text = null;
            btnRoomList.Enabled = true;
            btnCreate.Enabled = false;
        }
        private void tbxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
