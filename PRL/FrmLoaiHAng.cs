using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FrmLoaiHAng : Form
    {
        LoaiHangsver LoaiHangsver;
        public FrmLoaiHAng()
        {
            LoaiHangsver = new LoaiHangsver();
            InitializeComponent();
        }

        private void FrmLoaiHAng_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void button_Themlh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_malh.Text) || string.IsNullOrEmpty(textBox_tenlh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string malh = textBox_malh.Text;
            string tenlh = textBox_tenlh.Text;
            LoaiHang loaiHang = new LoaiHang()
            {
                MaLoaiLh = malh,
                TenLh = tenlh,
            };
         
            MessageBox.Show(LoaiHangsver.Create(loaiHang));
            LoadDataToGridView();
            ClearForm();

        }

        private void button_updatelh_Click(object sender, EventArgs e)
        {
            string malh = textBox_malh.Text;
            string tenlh = textBox_tenlh.Text;

            LoaiHang loaiHang = new LoaiHang()
            {
                MaLoaiLh = malh,
                TenLh = tenlh,
            };

            MessageBox.Show(LoaiHangsver.Update(loaiHang, malh));
            LoadDataToGridView();
            ClearForm();

        }

        private void button_deletelh_Click(object sender, EventArgs e)
        {
            string maVL = textBox_malh.Text;
            MessageBox.Show(LoaiHangsver.Delete(maVL));
            LoadDataToGridView();
            ClearForm();


        }

        private void button_exitfromlh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_lh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_lh.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
                textBox_malh.Text = row.Cells[0].Value.ToString(); // Cập nhật textBox_maVL với giá trị cột MaVL
                textBox_tenlh.Text = row.Cells[1].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
            }

        }

        private void textBox_timkiemlh_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox_timkiemlh.Text.ToLower();
            var allDatas = LoaiHangsver.GetAll();

            var filteredData = allDatas.Where(vl => vl.TenLh.ToLower().Contains(searchValue)).ToList();
            dataGridView_lh.Rows.Clear();
            foreach (var data in filteredData)
            {
                dataGridView_lh.Rows.Add(data.MaLoaiLh, data.TenLh);
            }


        }
        public void LoadDataToGridView()
        {
            dataGridView_lh.Rows.Clear();
            var allDatas = LoaiHangsver.GetAll();
            dataGridView_lh.ColumnCount = 2;
            dataGridView_lh.Columns[0].HeaderText = "Ma VL";
            dataGridView_lh.Columns[1].HeaderText = "Tên Vat Lieu";
            foreach (var data in allDatas)
            {
                dataGridView_lh.Rows.Add(data.MaLoaiLh, data.TenLh);
            }
        }

        public void ClearForm()
        {
            textBox_malh.Text = "";
            textBox_tenlh.Text = "";
        }
    }
}
