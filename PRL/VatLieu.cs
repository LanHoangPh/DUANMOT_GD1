using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL
{
    public partial class VatLieuu : Form
    {
        VatLieuSver VatLieuSver;
        public VatLieuu()
        {
            VatLieuSver = new VatLieuSver();
            InitializeComponent();
        }

        private void button_ThemVL_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_maVL.Text) || string.IsNullOrEmpty(textBox_tenVL.Text) )
{
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maVL = textBox_maVL.Text;
            string tenVL = textBox_tenVL.Text;
            VatLieu vatLieu = new VatLieu()
            {
                MaVl = maVL,
                TenVl = tenVL
            };

            MessageBox.Show(VatLieuSver.Create(vatLieu));
            LoadDataToGridView();
            ClearForm();
        }

        private void button_updatevl_Click(object sender, EventArgs e)
        {
            string maVL = textBox_maVL.Text;
            string tenVL = textBox_tenVL.Text;

            VatLieu vatLieu = new VatLieu()
            {
                MaVl = maVL,
                TenVl = tenVL
            };

            MessageBox.Show(VatLieuSver.Update(vatLieu, maVL));
            LoadDataToGridView();
            ClearForm();
        }

        private void button_deletevl_Click(object sender, EventArgs e)
        {
            string maVL = textBox_maVL.Text;
            MessageBox.Show(VatLieuSver.Delete(maVL));
            LoadDataToGridView();
            ClearForm();
        }

        private void button_exitfromvl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VatLieu_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        public void LoadDataToGridView()
        {
            dataGridView1.Rows.Clear();
            var allDatas = VatLieuSver.GetAll();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Ma VL";
            dataGridView1.Columns[1].HeaderText = "Tên Vat Lieu";
            foreach (var data in allDatas)
            {
                dataGridView1.Rows.Add(data.MaVl, data.TenVl);
            }
        }

        public void ClearForm()
        {
            textBox_maVL.Text = "";
            textBox_tenVL.Text = "";
        }

        private void textBox_timkiemVL_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox_timkiemVL.Text.ToLower();
            var allDatas = VatLieuSver.GetAll();

            var filteredData = allDatas.Where(vl => vl.TenVl.ToLower().Contains(searchValue)).ToList();
            dataGridView1.Rows.Clear();
            foreach (var data in filteredData)
            {
                dataGridView1.Rows.Add(data.MaVl, data.TenVl);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
                textBox_maVL.Text = row.Cells[0].Value.ToString(); // Cập nhật textBox_maVL với giá trị cột MaVL
                textBox_tenVL.Text = row.Cells[1].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
            }

        }
    }
}
