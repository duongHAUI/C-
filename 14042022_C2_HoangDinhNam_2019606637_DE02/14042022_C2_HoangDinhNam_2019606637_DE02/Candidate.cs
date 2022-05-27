using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14042022_C2_HoangDinhNam_2019606637_DE02
{
    public class Candidate : Examinee , IComparable
    {
        public int address { get; set; }
        public float prioritized
        {
            get
            {
                if (address == 2)
                    return 1;
                else if (address == 3)
                    return 2;
                else
                {
                    return 0;
                }
            }
        }
        public Candidate()
        {

        }
        public Candidate(string id)
        {
            this.id = id;
        }
        // override object.Equals để check id trùng
        public override bool Equals(object obj)
        {
            Candidate ob = (Candidate)obj;
            return this.id == ob.id;
        }

        public void Input(List<Candidate> ds)
        {
            Candidate checkC;
            do
            {
                Console.Write("Nhap id : ");
                id = Console.ReadLine();
                checkC = new Candidate(id);
            } while (ds.Contains(checkC));
            Console.Write("Nhap fullname : ");
            fullname = Console.ReadLine();
            Console.Write("Nhap math : ");
            math = float.Parse(Console.ReadLine());
            Console.Write("Nhap physical : ");
            physical = float.Parse(Console.ReadLine());
            Console.Write("Nhap address : ");
            address = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("{0,-10}{1,15}{2,15}{3,15}{4,20}{5,20}{6,20}", id,fullname,math,physical,address,prioritized,Total());
        }
        public override float Total()
        {
            return base.Total() + prioritized;
        }
        public static void TieuDe()
        {
            Console.WriteLine("{0,-10}{1,15}{2,15}{3,15}{4,20}{5,20}{6,20}", "id", "fullname", "math", "physical", "address", "prioritized","total");
        }


        // để tìm max theo total
        public int CompareTo(object obj)
        {
            Candidate ob = (Candidate)obj;
            return this.Total().CompareTo(ob.Total());
        }
    }
    class SortTotalCandidate : IComparer<Candidate>
    {
        public int Compare(Candidate a, Candidate b)
        {
            return a.Total().CompareTo(b.Total());
        }
    }
}
