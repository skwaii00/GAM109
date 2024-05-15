using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class UserData
    {
        public static string ID;
        public static string UserName;
        public static float Health;
        public static int Point;

        static UserData()
        {
            ID = "2024";
            UserName = "Hide on bush";
            Health = 100.5f;
            Point = 100;
        }
    }
}
