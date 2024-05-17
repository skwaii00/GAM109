using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_GAM109_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bai2a();
            Console.WriteLine();
            bai2b();
            Console.ReadLine();
        }
        public static void bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = "faker",
                isplaying = false,
                bag = new
                {
                    skins = 0,
                    cups = 20,
                }
            };
            Console.WriteLine("id: " + userInfp.id);
            Console.WriteLine("name: " + userInfp.name);
            Console.WriteLine("is playing: " + userInfp.isplaying);
            Console.WriteLine("bag skins: " + userInfp.bag.skins);
            Console.WriteLine("bag cups: " + userInfp.bag.cups);

        }
        public static void bai2b()
        {
            int y = 10;
            Action<int> AnonymousMenthod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("sum: " + sum);
                Console.WriteLine("sub: " + sub);
            };
            AnonymousMenthod(5);
        }
    }
}