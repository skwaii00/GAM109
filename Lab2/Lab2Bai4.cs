using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_GAM109_Bai4
{
    class Program
    {


        static void Main()
        {
            List<int> numberlist = new List<int>();

            numberlist.Add(10);
            numberlist.Add(7);
            numberlist.Add(20);
            numberlist.Add(66);
            numberlist.Add(90);



            //Yêu cầu 3
            int result = 0;
            foreach (int number in numberlist)
            {
                if (check(number))
                {
                    result += number;
                }
            }
            Console.WriteLine(result);




        }

        private static bool check(int number)
        {
            if (number <= 1) return false;
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0) return true;
                }
            }
            return true;
        }
    }
}