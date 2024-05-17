using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_GAM109_Bai1
{
    public class UserData
    {
        public int id;
        public int level;
        public string name;
        public UserData()
        {
            id = 0;
            level = 0;
            name = "null";
        }
        public UserData(int id, int level, string name)
        {
            this.id = id;
            this.level = level;
            this.name = name;
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Name: " + name);
        }

    }
    public class bai1c
    {
        public static void XuatThongTin(String attributeName, dynamic attribute)
        {
            Console.WriteLine(attributeName + ": " + attribute);
        }
    }
}