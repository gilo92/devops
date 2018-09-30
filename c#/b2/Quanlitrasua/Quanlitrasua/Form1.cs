using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlitrasua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        List<SanPham> dsSanPhamCuaQuan = new List<SanPham>();
        HoaDon hoaDon = new HoaDon();
        List<ChiTietHoaDon> dsChiTietHoaDon = new List<ChiTietHoaDon>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tao sp moi
            SanPham sp1 = new SanPham();
            sp1.TenSP = "Tra sua Dau";
            sp1.Gia = 40000;
            dsSanPhamCuaQuan.Add(sp1);

            SanPham sp2 = new SanPham();
            sp2.TenSP = "Tra sua Vai";
            sp2.Gia = 45000;
            dsSanPhamCuaQuan.Add(sp2);

            SanPham sp3 = new SanPham();
            sp3.TenSP = "Tra sua Mia";
            sp3.Gia = 35000;
            dsSanPhamCuaQuan.Add(sp3);

            SanPham sp4 = new SanPham();
            sp4.TenSP = "Tra sua Man";
            sp4.Gia = 45000;
            dsSanPhamCuaQuan.Add(sp4);

            SanPham sp5 = new SanPham();
            sp5.TenSP = "Tra sua Tao";
            sp5.Gia = 50000;
            dsSanPhamCuaQuan.Add(sp5);

            dgvSanPham.DataSource = dsSanPhamCuaQuan;
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            dgvDsChiTietHoaDon.DataSource = null;
            int chiSoCUaSanPhamChon = dgvSanPham.SelectedRows[0].Index;
            SanPham sp = dsSanPhamCuaQuan[chiSoCUaSanPhamChon];
            ChiTietHoaDon ChiTietHoaDon = new ChiTietHoaDon();
            ChiTietHoaDon.SanPham = sp;
            ChiTietHoaDon.SoLuong = int.Parse(nmSoLuong.Value.ToString());
            ChiTietHoaDon.ThanhTien = sp.Gia * ChiTietHoaDon.SoLuong;

            dsChiTietHoaDon.Add(ChiTietHoaDon);
            // gan cai ds chi tiet hoa don moi tao cho hoa don moi tinh
            hoaDon.DsChiTietHoaDon = dsChiTietHoaDon;
            // cong don tien vao hoa don
            hoaDon.TongSoTien = hoaDon.TongSoTien + ChiTietHoaDon.ThanhTien;
            hoaDon.Ngay = dtNgay.Value;
            //Lamda expression
            dgvDsChiTietHoaDon.DataSource = dsChiTietHoaDon.Select(u=> new {u.SanPham.TenSP,u.SoLuong,u.ThanhTien }).ToList();
            lblTongSoTien.Text = hoaDon.TongSoTien.ToString();
        }
    }
}
