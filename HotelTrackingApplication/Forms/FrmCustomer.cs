using HotelTrackingApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FrmCustomer : Form
    {
        int selectedCustomerID = -1;
        int selectedReservationId = -1;
        Expression<Func<Customer, bool>> pradicate = null;
        AppDbContext db = new AppDbContext();
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private double CalculateTotalPrice(DateTime start, DateTime end, double price) => Math.Round((end - start).TotalDays) * price;
        private async void PerformDataGridAssignmentForCustomers(Expression<Func<Customer, bool>> pradicate)
        {
            List<Customer> customers = pradicate == null
                 ? await db.Customers.ToListAsync()
                 : await db.Customers.Where(pradicate).ToListAsync();

            dgCustomer.Rows.Clear();
            dgReservation.Rows.Clear();
            foreach (Customer customer in customers)
            {
                dgCustomer.Rows.Add(customer.Id, customer.Tc, customer.Name, customer.Lastname, customer.Email, customer.Phone);
            }
        }
        private async void PerformDataGridAssignmentForReservations(int customerID)
        {
            dgReservation.Rows.Clear();
            List<Reservation> reservations = await db.Reservations.Include(r => r.Room).Where(r => r.CustomerId == customerID).ToListAsync();
            foreach (Reservation reservation in reservations)
            {
                dgReservation.Rows.Add(reservation.Id, reservation.Room.Name, reservation.StartTime, reservation.EndTime, reservation.Price);
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            PerformDataGridAssignmentForCustomers(pradicate);
        }

        private async void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedCustomerID = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);
            tbxID.Text = dgCustomer.CurrentRow.Cells[0].Value.ToString();
            tbxTc.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
            tbxName.Text = dgCustomer.CurrentRow.Cells[2].Value.ToString();
            tbxLastname.Text = dgCustomer.CurrentRow.Cells[3].Value.ToString();
            tbxEmail.Text = dgCustomer.CurrentRow.Cells[4].Value.ToString();
            tbxPhone.Text = dgCustomer.CurrentRow.Cells[5].Value.ToString();
            btnCreateOrUpdate.Text = "Güncelle";

            PerformDataGridAssignmentForReservations(selectedCustomerID);
        }
        private void dgReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedReservationId = Convert.ToInt32(dgReservation.CurrentRow.Cells[0].Value);
        }

        private void btnCreateOrUpdate_Click(object sender, EventArgs e)
        {
            if (tbxTc.Text.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Yeni Kayıt
            if (selectedCustomerID < 0)
            {
                if (string.IsNullOrEmpty(tbxTc.Text) || string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxLastname.Text) || string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxPhone.Text))
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (db.Customers.Any(c => c.Tc == Convert.ToInt64(tbxTc.Text)))
                {
                    MessageBox.Show("Girilen TC Kimlik Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (db.Customers.Any(c => c.Phone == tbxPhone.Text))
                {
                    MessageBox.Show("Girilen Telefon Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var customer = new Customer();
                customer.Tc = Convert.ToInt64(tbxTc.Text);
                customer.Name = tbxName.Text;
                customer.Lastname = tbxLastname.Text;
                customer.Email = tbxEmail.Text;
                customer.Phone = tbxPhone.Text;

                customer.CreateDate = DateTime.Now;
                customer.UpdateDate = DateTime.Now;
                db.Customers.Add(customer);

            }
            // Güncelle
            else
            {
                if (string.IsNullOrEmpty(tbxTc.Text) || string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxLastname.Text) || string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxPhone.Text))
                {
                    MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Customer customer = db.Customers.SingleOrDefault(c => c.Id == selectedCustomerID);
                if (customer == null)
                {
                    MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customer.Tc = Convert.ToInt64(tbxTc.Text);
                customer.Name = tbxName.Text;
                customer.Lastname = tbxLastname.Text;
                customer.Email = tbxEmail.Text;
                customer.Phone = tbxPhone.Text;
                customer.UpdateDate = DateTime.Now;
                db.Customers.Update(customer);
            }

            db.SaveChanges();
            MessageBox.Show("İşlem tamamlandı.", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PerformDataGridAssignmentForCustomers(pradicate);
            btnClear.PerformClick();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedCustomerID = -1;
            selectedReservationId = -1;
            btnCreateOrUpdate.Text = "Oluştur";

            tbxID.Text = null;
            tbxTc.Text = null;
            tbxName.Text = null;
            tbxLastname.Text = null;
            tbxEmail.Text = null;
            tbxPhone.Text = null;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID < 0)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);
            Customer customer = db.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Customers.Remove(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
            PerformDataGridAssignmentForCustomers(pradicate);
        }
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (selectedReservationId < 0)
            {
                MessageBox.Show("Lütfen rezervasyon seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Reservation reservation = db.Reservations.SingleOrDefault(r => r.Id == selectedReservationId);
            if (reservation == null)
            {
                MessageBox.Show("Kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Reservations.Remove(reservation);
            db.SaveChanges();
            MessageBox.Show("Rezervasyon silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PerformDataGridAssignmentForReservations(selectedCustomerID);
        }
        private void btnFilterByTc_Click(object sender, EventArgs e)
        {
            if (tbxFilterByTc.Text.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pradicate = c => c.Tc == Convert.ToInt64(tbxFilterByTc.Text);
            PerformDataGridAssignmentForCustomers(pradicate);
        }
        private void btnFilterByName_Click(object sender, EventArgs e)
        {
            pradicate = c => c.Name.Contains(tbxFilterByName.Text) && c.Lastname.Contains(tbxFilterByLastname.Text);
            PerformDataGridAssignmentForCustomers(pradicate);
        }
        private void btnGetList_Click(object sender, EventArgs e)
        {
            tbxFilterByTc.Text = null;
            tbxFilterByName.Text = null;
            tbxFilterByLastname.Text = null;
            pradicate = null;
            PerformDataGridAssignmentForCustomers(pradicate);
        }

        private void tbxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void tbxTCForFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

    }
}