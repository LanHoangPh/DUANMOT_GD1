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
    public partial class NuocSXFrm : Form
    {
        NuocSXSver NuocSXSver;
        public NuocSXFrm()
        {
            NuocSXSver = new NuocSXSver();
            InitializeComponent();
        }

        private void NuocSXFrm_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();

        }

        private void button_exitfrmsx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_timkiemsx_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox_timkiemsx.Text.ToLower();
            var allDatas = NuocSXSver.GetAll();

            var filteredData = allDatas.Where(vl => vl.TenQg.ToLower().Contains(searchValue)).ToList();
            dataGridView_sx.Rows.Clear();
            foreach (var data in filteredData)
            {
                dataGridView_sx.Rows.Add(data.MaQg, data.TenQg);
            }

        }

        private void button_xoasx_Click(object sender, EventArgs e)
        {
            string maqg = textBox_maqg.Text;
            MessageBox.Show(NuocSXSver.Delete(maqg));
            LoadDataToGridView();
            ClearForm();
        }

        private void button_suasx_Click(object sender, EventArgs e)
        {
            string maqg = textBox_maqg.Text;
            string tenqg = textBox_tenqgg.Text;
            NuocSx nuocSx = new NuocSx()
            {
                MaQg = maqg,
                TenQg = tenqg,
            };

            MessageBox.Show(NuocSXSver.Update(nuocSx, maqg));
            LoadDataToGridView();
            ClearForm();
        }

        private void button_addsx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_maqg.Text) || string.IsNullOrEmpty(textBox_tenqgg.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maqg = textBox_maqg.Text;
            string tenqg = textBox_tenqgg.Text;
            NuocSx nuocSx = new NuocSx()
            {
                MaQg = maqg,
                TenQg = tenqg,
            };

            MessageBox.Show(NuocSXSver.Create(nuocSx));
            LoadDataToGridView();
            ClearForm();
        }
        public void LoadDataToGridView()
        {
            dataGridView_sx.Rows.Clear();
            var allDatas = NuocSXSver.GetAll();
            dataGridView_sx.ColumnCount = 2;
            dataGridView_sx.Columns[0].HeaderText = "Ma quốc gia";
            dataGridView_sx.Columns[1].HeaderText = "Tên quốc gia";
            foreach (var data in allDatas)
            {
                dataGridView_sx.Rows.Add(data.MaQg, data.TenQg);
            }
        }

        public void ClearForm()
        {
            textBox_maqg.Text = "";
            textBox_tenqgg.Text = "";
        }

        private void dataGridView_sx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                DataGridViewRow row = dataGridView_sx.Rows[e.RowIndex]; // Lấy ra dòng mà mình được chọn
                textBox_maqg.Text = row.Cells[0].Value.ToString(); // Cập nhật textBox_maVL với giá trị cột MaVL
                textBox_tenqgg.Text = row.Cells[1].Value.ToString(); // Cập nhật textBox_tenVL với giá trị cột TenVL
            }
        }
    }
}
