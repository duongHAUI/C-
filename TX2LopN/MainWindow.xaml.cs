using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TX2LopN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<NhanVien> list = new ObservableCollection<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            dprNgaySinh.Text = DateTime.Now + "";
        }
        void ResetForm()
        {
            txtHoTen.Focus();
            txtHoTen.Clear();
            txtTienBan.Clear();
            dprNgaySinh.Text = DateTime.Now.ToString();
            rdoNam.IsChecked = true;
            cbAnh.IsChecked = false;
            cbTrung.IsChecked = false;
            cbbLoaiNhanVien.SelectedIndex = 0;
        }
        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            string msgerr = "";
            string hoTen = txtHoTen.Text, loaiNhanVien = cbbLoaiNhanVien.Text,
                tienBanHang = txtTienBan.Text, ngaySinh = dprNgaySinh.Text, gioiTinh = "Nam";
            string ngonNgu = "";
            if (hoTen.Equals("") || tienBanHang.Equals(""))
            {
                msgerr += "Nhập đầy đủ các trường";
            }
            DateTime ns = DateTime.Parse(ngaySinh);
            DateTime today = DateTime.Now;
            int tuoi = today.Year - ns.Year;
            if (tuoi < 19 || tuoi > 60)
            {
                msgerr += "Tuổi phải thuộc từ 19 đến 60!";
            }
            float tien;
            if (!float.TryParse(tienBanHang, out tien))
            {
                msgerr += "Tiền hàng phải là số!";
            }
            else if (tien <= 0)
            {
                msgerr += "Tiền hàng phải lớn hơn 0!";
            }
            if (rdoNam.IsChecked == false)
            {
                gioiTinh = "Nữ";
            }
            if (cbAnh.IsChecked == true)
            {
                ngonNgu += "Anh";
            }
            if (cbTrung.IsChecked == true)
            {
                ngonNgu += (ngonNgu.Equals("") ? "Trung" : " , Trung");
            }
            if (!msgerr.Equals(""))
            {
                MessageBox.Show(msgerr);
            }
            else
            {
                ResetForm();
                NhanVien nv = new NhanVien(hoTen, loaiNhanVien,gioiTinh, ngaySinh, tien,ngonNgu);
                list.Add(nv);
                lbdata.ItemsSource = list;
                lbdata.Items.RemoveAt(list.Count);
            }
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            if(lbdata.SelectedIndex != lbdata.Items.Count - 1)
            {
                Window2 w2 = new Window2();
                w2.emp = (NhanVien)lbdata.Items[lbdata.SelectedIndex];
                w2.ShowDialog();
            }
        }
        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            ResetForm();
        }
    }
}
