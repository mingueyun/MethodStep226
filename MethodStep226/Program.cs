﻿using System;
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
            int twoTwo = mathmeth.math1(two);
            Console.WriteLine(twoTwo);
          

            string three = "9";
            int threeThree = mathmeth.math1(three);
            Console.WriteLine(threeThree);

            Console.ReadLine();

        }
    }
}
