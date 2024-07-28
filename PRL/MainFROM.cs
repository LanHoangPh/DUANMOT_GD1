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
    public partial class MainFROM : Form
    {
        public MainFROM()
        {
            InitializeComponent();
        }

        private void vatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            VatLieuu vatLieu = new VatLieuu();
            vatLieu.TopLevel = false;
            panel_main.Controls.Add(vatLieu);
            vatLieu.Show();
            vatLieu.FormBorderStyle = FormBorderStyle.None;


        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            FrmLoaiHAng frmLoaiHAng = new FrmLoaiHAng();
            frmLoaiHAng.TopLevel = false;
            panel_main.Controls.Add(frmLoaiHAng);
            frmLoaiHAng.Show();
            frmLoaiHAng.FormBorderStyle = FormBorderStyle.None;

        }

        private void nuocSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            NuocSXFrm nuocSXFrm = new NuocSXFrm();
            nuocSXFrm.TopLevel = false;
            panel_main.Controls.Add(nuocSXFrm);
            nuocSXFrm.Show();
            nuocSXFrm.FormBorderStyle = FormBorderStyle.None;
        }

        private void sanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
