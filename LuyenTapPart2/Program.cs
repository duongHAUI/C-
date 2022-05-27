using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTapPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ThiSinhUT> li = new List<ThiSinhUT>();
            int chose;
            do
            {
                Console.WriteLine("===========================MENU====================");
                Console.WriteLine("1. Them 1 sinh vien vao list\n" +
                    "2. In danh sach sinh vien hien co\n" +
                    "3.Xap xep danh sach theo diem so\n" +
                    "4. Xet tuyen\n" +
                    "5. In danh sach sinh vien trong khu vuc\n" +
                    "6. Tim sinh vien theo so bao danh\n" +
                    "7. Xoa sinh vien theo so bao danh\n" +
                    "8. Ket thuc chuong trinh\n");
                Console.WriteLine("Lua chon cua ban la: ");
                chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        ThiSinhUT ts = new ThiSinhUT();
                        ts.input();
                        li.Add(ts);
                        Console.WriteLine("Success!");
                        break;
                    case 2:
                        Console.WriteLine("Danh sach thi sinh hien co: ");
                        foreach(var item in li)
                        {
                            item.output();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Danh sach sau khi xap xep");
                        li.Sort((a, b) => a.CompareTo(b));
                        foreach(var item in li)
                        {
                            item.output();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap diem san: ");
                        float diemsan = float.Parse(Console.ReadLine());
                        int count=0;
                        foreach(var item in li)
                        {
                            if(item.XetTuyen(diemsan).Equals("Thi Do"))
                            {
                                
                                item.output();
                                count += 1;
                            }
                        }
                        if (count == 0) Console.WriteLine("Khong co mot ai trung tuyen");
                        break;
                    case 5:
                        Console.WriteLine("Nhap khu vuc ban muon tim");
                        int khuvuc_found = int.Parse(Console.ReadLine());
                         int count1 = 0;
                        foreach(var item in li)
                        {
                            if(item.KhuVuc == khuvuc_found)
                            {
                                item.output();
                                count1 += 1;
                            }
                        }
                        if(count1 == 0)
                        {
                            Console.WriteLine("khong co sinh vien nao trong khu vuc ");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Nhap so ban danh sinh vien muon tim: ");
                        String sbd_found = Console.ReadLine();
                        int count2 = 0;
                        foreach(var item in li)
                        {
                            if (item.sbd.Equals(sbd_found))
                            {
                                item.output();
                                count2 += 1;
                            }
                        }
                        if(count2 == 0)
                        {
                            Console.WriteLine("Khong co sinh nao co so bao danh nhu vay ca");
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Nhap so bao snah sinh vien muon xoa: ");
                            string sbd_delete = Console.ReadLine();
                            int count3 = 0;
                            foreach (var item in li)
                            {
                                if (item.sbd.Equals(sbd_delete))
                                {
                                    li.Remove(item);
                                    count3++;
                                    break;
                                }
                            }
                            if (count3 == 0)
                            {
                                Console.WriteLine("khong ton tai thi sinh do de xoa");
                            }
                            break;
                        }
                    case 8:
                        Console.WriteLine("Hen Khong Gap Lai");
                        break;
                }
            }
            while (chose != 8);
        }
    }
}
