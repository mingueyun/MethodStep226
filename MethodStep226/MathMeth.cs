using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodStep226
{
    public class MathMeth
    {
        public int math1(int a)
        {
            int math1 = a * a;
            return math1;
        }
        public decimal math1(decimal b)
        {
            decimal math1 = b / 2;
            Convert.ToInt32(math1);
            return math1;
        }
        public string math1 (string c )
        {
            int stuff = Convert.ToInt32(c);
            int math2 = stuff + 1;
            string math1 = Convert.ToString(math2);
            return math1;
        }
            
        



   


    }

}
