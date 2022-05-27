using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace TX2LopN
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public NhanVien emp { get; set; }
        public Window2()
        {
            
            InitializeComponent();
            
        }
        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            txtHoTen.Text = emp.hoTen + "";
            txtTienBan.Text = emp.tienBanHang + "";
            cbbLoaiNhanVien.Text = emp.loaiNhanVien;
            dprNgaySinh.Text = emp.ngaySinh;
        }
    }
}
