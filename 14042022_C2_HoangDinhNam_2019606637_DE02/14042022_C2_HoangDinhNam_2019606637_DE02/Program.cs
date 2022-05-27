using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _14042022_C2_HoangDinhNam_2019606637_DE02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            List<Candidate> list = new List<Candidate>();
            while (true)
            {
                Console.WriteLine("\t\t=============================================");
                Console.WriteLine("\t1. Nhập thêm thông tin 1 thí sinh từ màn hình vào Danh sách thí sinh");
                Console.WriteLine("\t2. Hiển thị thông tin toàn bộ các thí sinh trong Danh sách theo thứ tự đã nhập");
                Console.WriteLine("\t3. Hiển thị thông tin toàn bộ các thí sinh trong Danh sách có sắp xếp theo Tổngđiểm thi");
                Console.WriteLine("\t4. Nhập vào Điểm sàn từ bàn phím và trả ra danh sách các thí sinh đã “Thi đỗ”.");
                Console.WriteLine("\t5. Nhập vào Khu vực ưu tiên, hiển thị danh sách các thí sinh có cùng khu vực ưu tiên đã nhập.");
                Console.WriteLine("\t6. Tìm kiếm và hiển thị thông tin thí sinh theo số báo danh nhập từ bàn phím");
                Console.WriteLine("\t7. Nhập vào thông tin số báo danh, xóa thí sinh đó khỏi danh sách.");
                Console.WriteLine("\t8. Kết thúc chương trình.");
                Console.WriteLine("\t9. Tìm thí sinh có điểm tổng kết cao nhất!");
                Console.WriteLine("\t\t=============================================");
                Console.Write("\n\t\tNhap lua chon : ");
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        {
                            Candidate newSV = new Candidate();
                            newSV.Input(list);
                            list.Add(newSV);
                            Console.WriteLine("\t\tNhap thanh cong!");
                            break;
                        }
                    case 2:
                        {
                            Candidate.TieuDe();
                            foreach (var item in list)
                            {
                                item.Output();
                            }
                            break;
                        }
                    case 3:
                        {
                            Candidate.TieuDe();
                            list.Sort(new SortTotalCandidate());
                            foreach (var item in list)
                            {
                                item.Output();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Nhap diem san : ");
                            float diemSan = float.Parse(Console.ReadLine());
                            bool check = false;
                            foreach (var item in list)
                            {

                                if (item.Check(diemSan).Equals("Thi đỗ"))
                                {
                                    if (!check)
                                    {
                                        Candidate.TieuDe();
                                    }
                                    item.Output();
                                    check = true;
                                }
                            }
                            if (!check)
                            {
                                Console.WriteLine("Không có ai thi đỗ!");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Nhap khu vuc uu tien : ");
                            int searchAddress = int.Parse(Console.ReadLine());
                            bool check = false;
                            foreach (var item in list)
                            {

                                if (item.address.Equals(searchAddress))
                                {
                                    if (!check)
                                    {
                                        Candidate.TieuDe();
                                    }
                                    item.Output();
                                    check = true;
                                }
                            }
                            if (!check)
                            {
                                Console.WriteLine("Không có có khu vực là " + searchAddress + " trong danh sach!");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Nhap so bao danh sinh vien can tim kiem : ");
                            string searchId = Console.ReadLine();
                            bool check = false;
                            foreach (var item in list)
                            {

                                if (item.id.Equals(searchId))
                                {
                                    if (!check)
                                    {
                                        Candidate.TieuDe();
                                    }
                                    item.Output();
                                    check = true;
                                    break;
                                }
                            }
                            if (!check)
                            {
                                Console.WriteLine("Không có sv có so bao danh là " + searchId + " trong danh sach!");
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Nhap so bao danh sinh vien can xoa : ");
                            string removeId = Console.ReadLine();
                            bool check = false;
                            foreach (var item in list)
                            {

                                if (item.id.Equals(removeId))
                                {
                                    list.Remove(item);
                                    check = true;
                                    break;
                                }
                            }
                            if (!check)
                            {
                                Console.WriteLine("Không có sv có so bao danh là " + removeId + " trong danh sach!");
                            }
                            break;
                        }
                    case 8:
                        {
                            return;
                        }
                    case 9:
                        {
                            Candidate a = list.Max();
                            a.Output();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
