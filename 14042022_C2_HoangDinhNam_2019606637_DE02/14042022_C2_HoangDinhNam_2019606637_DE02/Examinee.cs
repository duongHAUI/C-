using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14042022_C2_HoangDinhNam_2019606637_DE02
{
    public class Examinee
    {
        public string id { get; set; }
        public string fullname { get; set; }
        public float math { get; set; }
        public float physical { get; set; }

        public Examinee() { }
        public Examinee(string id,string fullname,float math,float physical)
        {
            this.id = id;
            this.fullname = fullname;
            this.math = math;
            this.physical = physical;
        }
        public virtual float Total()
        {
            return math * physical;
        }
        public string Check(float mark)
        {
            if (Total() >= mark)
            {
                return "Thi đỗ";
            }
            else
            {
                return "Thi trượt";
            }

        }
    }
}
