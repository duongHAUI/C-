using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx2
{
    public class KhachHang
    {
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public int soDien { get; set; }
        public string ngayThang { get; set; }
        public long thanhTien {
            get
            {
                return soDien * 500;
            }
        }
        public KhachHang()
        {

        }
        public KhachHang(string hoTen,string diaChi,int soDien,string ngayThang)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDien = soDien;
            this.ngayThang = ngayThang;
        }
        public override string ToString()
        {
            return hoTen + " - " + diaChi + " - " + soDien + " - " + ngayThang + " - " + thanhTien;
        }
    }
}
