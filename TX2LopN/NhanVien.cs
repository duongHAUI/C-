using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2LopN
{
    public class NhanVien
    {
        public string hoTen { get; set; }
        public string loaiNhanVien { get; set; }
        public string ngaySinh  { get; set; }
        public string gioiTinh { get; set; }
        public string ngonNgu { get; set; }
        public double tienBanHang { get; set; }
        public double hoaHong {

            get
            {
                if (tienBanHang < 1000)
                {
                    return 0;
                }else if(tienBanHang <=5000)
                {
                    return tienBanHang * 0.05;
                }
                else
                {
                    return tienBanHang * 0.1;
                }
            }        
       }
        public NhanVien()
        {

        }
        public NhanVien(string hoTen,string loaiNhanVien , string gioiTinh,string ngaySinh,double tienBanHang, string ngonNgu)
        {
            this.hoTen = hoTen;
            this.loaiNhanVien = loaiNhanVien;
            this.ngaySinh = ngaySinh;
            this.tienBanHang = tienBanHang;
            this.ngonNgu = ngonNgu;
            this.gioiTinh = gioiTinh;
        }
    }
}
