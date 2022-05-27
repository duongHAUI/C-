using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tx2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ObservableCollection<KhachHang> list = new ObservableCollection<KhachHang>();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dateNgaythang.Text = DateTime.Now.ToString();
        }

        private void btnDong_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            string msgErr = "", hoTen = txtHoten.Text, diaChi = cbbDiaChi.Text, soDien = txtSoDien.Text, ngayThang = dateNgaythang.Text;
            if(hoTen.Equals("") || soDien.Equals(""))
            {
                msgErr += "Phải nhập đủ các trường!\n";
            }
            int so = 0;
            try
            {
                so = int.Parse(soDien);
                if(so <10 || so > 100)
                {
                    msgErr += "Số ddieeejn thuộc 10 - 100!\n";
                }
            }
            catch (Exception)
            {
                msgErr += "Số điện là số!!\n";
            }
            if(msgErr != "")
            {
                MessageBox.Show(msgErr);
            }
            else
            {
                KhachHang kh = new KhachHang(hoTen, diaChi, so, ngayThang);
                //list.Add(kh);
                lbData.Items.Add(kh);
                //lbData.ItemsSource = list;
            }
        }
        
        private void btnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            if (lbData.SelectedIndex != -1)
            {
                KhachHang khk = (KhachHang)lbData.Items[lbData.SelectedIndex];
                Window2 win2 = new Window2();
                win2.kh = khk;
                win2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn khách hàng!");
            }
            
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            txtHoten.Clear();
            txtHoten.Focus();
            txtSoDien.Clear();
            cbbDiaChi.SelectedIndex = 0;
            dateNgaythang.Text = DateTime.Now.ToString();
        }

        private void btnXoaDong_Click(object sender, RoutedEventArgs e)
        {
            if (lbData.SelectedIndex != -1)
            {
                lbData.Items.RemoveAt(lbData.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn khách hàng muốn xóa!");
            }
        }
    }
}
