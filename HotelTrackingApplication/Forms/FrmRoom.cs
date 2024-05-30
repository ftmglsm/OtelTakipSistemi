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
    public partial class FrmRoom : Form
    {
        int selectedRowIndex = -1;
        Expression<Func<Room, bool>> pradicate = null;
        AppDbContext db = new AppDbContext();
        public FrmRoom()
        {
            InitializeComponent();
        }

        private async void PerformDataGridAssignment(Expression<Func<Room, bool>> pradicate)
        {
            List<Room> rooms = pradicate == null
                   ? await db.Rooms.ToListAsync()
                   : await db.Rooms.Where(pradicate).ToListAsync();

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

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            PerformDataGridAssignment(pradicate);
        }
        private void dgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedRowIndex = e.RowIndex;
            tbxId.Text = dgRoom.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tbxName.Text = dgRoom.Rows[selectedRowIndex].Cells[1].Value.ToString();
            tbxCapacity.Text = dgRoom.Rows[selectedRowIndex].Cells[2].Value.ToString();
            tbxPrice.Text = dgRoom.Rows[selectedRowIndex].Cells[3].Value.ToString();
            btnCreateOrUpdate.Text = "Güncelle";
        }

        private void btnFilterByName_Click(object sender, EventArgs e)
        {
            pradicate = r => r.Name.Contains(tbxNameForFilter.Text);
            PerformDataGridAssignment(pradicate);
        }
        private void btnGetList_Click(object sender, EventArgs e)
        {
            pradicate = null;
            PerformDataGridAssignment(pradicate);
        }
        private void btnCreateOrUpdate_Click(object sender, EventArgs e)
        {
            // Yeni kayıt
            if (selectedRowIndex < 0)
            {
                if (db.Rooms.Any(r => r.Name == tbxName.Text))
                {
                    MessageBox.Show("Oda adı zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Room room = new Room();
                room.Name = tbxName.Text;
                room.Capacity = Convert.ToInt32(tbxCapacity.Text);
                room.Price = Convert.ToDouble(tbxPrice.Text);

                db.Rooms.Add(room);
            }
            // Güncelleme
            else
            {
                if (db.Rooms.Any(r => r.Name == tbxName.Text && r.Id != Convert.ToInt32(tbxId.Text)))
                {
                    MessageBox.Show("Oda adı zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Room room = db.Rooms.SingleOrDefault(r => r.Id == Convert.ToInt32(tbxId.Text));
                room.Name = tbxName.Text;
                room.Capacity = Convert.ToInt32(tbxCapacity.Text);
                room.Price = Convert.ToDouble(tbxPrice.Text);
            }

            db.SaveChanges();
            MessageBox.Show("İşlem tamamlandı.", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
            PerformDataGridAssignment(pradicate);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Lütfen satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Room room = db.Rooms.SingleOrDefault(r => r.Id == Convert.ToInt32(tbxId.Text));
            db.Rooms.Remove(room);
            db.SaveChanges();
            btnClear.PerformClick();
            MessageBox.Show("Müşteri Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PerformDataGridAssignment(pradicate);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedRowIndex = -1;
            tbxNameForFilter.Text = null;
            tbxId.Text = null;
            tbxName.Text = null;
            tbxCapacity.Text = null;
            tbxPrice.Text = null;
            btnCreateOrUpdate.Text = "Oluştur";
        }

        private void tbxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


    }
}
