using Lab4Bai1;
using System.Diagnostics;
using System.Linq.Expressions;

List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var newList = list.FindAll(item => item % 2 == 0);
foreach (var item in newList)
{
    Console.WriteLine(item);

}
//Lab4Bai2
List<userDataLab4> listt = new List<userDataLab4>();
listt.Add(new userDataLab4("GTA 5", 10));
listt.Add(new userDataLab4("Genshin impact", 15));
listt.Add(new userDataLab4("Gunny", 5));
listt.Add(new userDataLab4("Liên minh huyền thoại", 100));
//Câu a
var selectedData = listt.Select(u => new { u.name, u.level });
foreach (var item in selectedData)
{
    Console.WriteLine("Name: " + item.name + " |Level: " + item.level);
}
//Câu b
listt = listt.OrderByDescending(u => u.level).ToList();

//Lab4Bai3

List<studentLab4> listtt = new List<studentLab4>();
listtt.Add(new studentLab4("1", "Bảo Trâm", 13));
listtt.Add(new studentLab4("2", "Quốc Trung", 12));
listtt.Add(new studentLab4("3", "Huyền Trang", 15));
listtt.Add(new studentLab4("4", "Gia Lâm", 20));
listtt.Add(new studentLab4("5", "Vân Anh", 16));
//Câu a
var dataAge = from student in listtt
              where student.age > 12 && student.age < 20
              select student;
foreach (var item in dataAge)
{
    Console.WriteLine(item.id);
    Console.WriteLine(item.name);
    Console.WriteLine(item.age);
}
//Câu b
var dataAge2 = listtt.Where(item => item.age > 12 & item.age < 20);
foreach (var item in dataAge2)
{
    Console.WriteLine(item.id);
    Console.WriteLine(item.name);
    Console.WriteLine(item.age);
}