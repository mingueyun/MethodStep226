using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodStep226
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMeth mathmeth = new MathMeth();
            int one = 2;
            int oneOne = mathmeth.math1(one);
            Console.WriteLine(oneOne);

            decimal two = 6;
            decimal twoTwo = mathmeth.math1(two);
            int twotwotwo = Convert.ToInt32(twoTwo);
            Console.WriteLine(twotwotwo);
          

            string three = "9";
            string threeThree = mathmeth.math1(three);
            int threethreethree = Convert.ToInt32(threeThree);
            Console.WriteLine(threethreethree);

            Console.ReadLine();

        }
    }
}
