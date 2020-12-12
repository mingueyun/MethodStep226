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
        public int math1(decimal b)
        {
            decimal math1 = b / 2;
            int x = Convert.ToInt32(math1);
            return x;
        }
        public int math1 (string c )
        {
            int iGEt = Convert.ToInt32(c);
            int math1 =  iGEt % 2;
            int x = Convert.ToInt32(math1);
            return x;
        }
            
        



   


    }

}
