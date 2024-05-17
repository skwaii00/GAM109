using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_GAM109_Bai1
{
    public class bai1b
    {
        public static void GetDeTail(dynamic value)
        {
            Console.WriteLine("value: " + value);
        }
        public static void Bai1b()
        {
            GetDeTail(10);
            GetDeTail("Games");
            GetDeTail(true);
            GetDeTail(9.5);
        }
    }
}