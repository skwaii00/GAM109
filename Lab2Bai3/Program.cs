using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_GAM109_Bai3
{
    public class UserData
    {
        public int? id;
        public string name;
        public List<float> scores;


        public UserData()
        {
            id = null;
            name = null;
            scores = new List<float>();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            UserData userData = new UserData();
            Console.WriteLine("Nhập tên: ");
            userData.name = Console.ReadLine();
            Console.WriteLine("Userdata.name : " + userData.name);

            Console.WriteLine("Nhập id: ");
            string id = Console.ReadLine();
            userData.id = Convert.ToInt32(id);
            Console.WriteLine("Userdata.id :" + userData.id);

            Console.WriteLine("Nhập danh sách điểm. Nhập số lượng điểm cần nhập: ");
            int soLuongDiem = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soLuongDiem; i++)
            {
                userData.scores.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Số lượng điểm cần nhập là: ");
            //in ra cac phan tu trong list
            foreach (var i in userData.scores)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}