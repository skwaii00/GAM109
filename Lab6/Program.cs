// Bai 1
using Lab6;
using System;

List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
List<string> listNul = new List<string>();

// Cau a
var firstNumGt5 = listInt.FirstOrDefault(n => n % 2 == 0 && n > 5);

// Cau b
var lastNumGt200 = listInt.LastOrDefault(n => n > 200);

// Cau c
var firstItemStartWithT = listStr.FirstOrDefault(i => i != null && i.StartsWith("T"));

// Cau d
var list = listInt.Where(i => listInt.IndexOf(i) % 2 == 1 && i % 2 == 0);
var sum = list.Sum();

Console.WriteLine();

// Cau 2
List<Shop> listShop = new List<Shop>();
listShop.Add(new Shop(1, "HCM", "Quận 12"));
listShop.Add(new Shop(2, "Hà Nội", "Quận Nam từ liêm"));
listShop.Add(new Shop(3, "Đà Nẵng", "Quận Hải Châu"));

List<Phone> listPhone = new List<Phone>();
listPhone.Add(new Phone(1, 1, "IP 15", 100, "Độc lạ Bình Dương"));
listPhone.Add(new Phone(2, 2, "IP 16", 1000, "Độc lạ Bình Dương"));
listPhone.Add(new Phone(3, 3, "IP 17", 10000, "Độc lạ Bình Dương"));
listPhone.Add(new Phone(4, 1, "IP 18", 100000, "Độc lạ Bình Dương"));

// Cau a
foreach (var item in listShop.Join(listPhone,
    num1 => num1.id,
    num2 => num2.id,
    (item1, item2) => new
    {
        item1.shopname,
        item2.name
    }))
{
    Console.WriteLine($"ShopName: {item.shopname} | phoneName: {item.name}\n");
}

Console.WriteLine();

// Cau b
foreach (var item in listShop.GroupJoin(listPhone,
    shop => shop.id,
    phone => phone.shop_id,
    (shop, phones) => new
    {
        shop.shopname,
        phones
    }))
{
    Console.WriteLine($"ShopName: {item.shopname}");
    Console.WriteLine("-----------------");
    foreach(var p in item.phones)
    {
        Console.WriteLine($"phoneName: {p.name}");
        Console.WriteLine($"phonePrice: {p.price}");
    }
}

Console.WriteLine();

// Bai 3
List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };

// Cau a
foreach (var num in list1.Union(list2).OrderDescending())
{
    Console.WriteLine(num);
}

Console.WriteLine();

// Cau b
foreach (var num in list1.Intersect(list2))
{
    Console.WriteLine(num);
}

Console.WriteLine();

// Cau c
foreach (var num in list1.Concat(list2))
{
    Console.WriteLine(num);
}

Console.WriteLine();

// Cau d
foreach (var num in list1.Except(list2))
{
    Console.WriteLine(num);
}