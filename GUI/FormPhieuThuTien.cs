using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormPhieuThuTien : Form
    {
        public FormPhieuThuTien()
        {
            InitializeComponent();
        }

        private void FormPhieuThuTien_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private  void RefreshForm()
        {
            maphieu_tb.Text = PhieuThuTienBUS.GenerateNewMaPhieuThu();
            makh_tb.Text = "";
            ten_tb.Text = "";
            diachi_tb.Text = "";
            sdt_tb.Text = "";
            email_tb.Text = "";
            sotienthu_tb.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
