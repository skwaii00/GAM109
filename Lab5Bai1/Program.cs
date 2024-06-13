using System;
using System.Collections.Generic;
using System.Linq;

public class UserAccountLab5
{
    public string name;
    public int rank;
    public float winRate;
    public string type;
    public int skin;

    public UserAccountLab5(string _name, int _rank, float _winRate, string _type, int _skin)
    {
        name    = _name;
        rank    = _rank;
        winRate = _winRate;
        type    = _type;
        skin    = _skin;
    }
}


// Câu a
class Program
{
    static void Main()
    {
        List<UserAccountLab5> List = new List<UserAccountLab5>();

        List.Add(new UserAccountLab5("Sơn Tùng", 10, 55.5f, "Ca Nhạc", 50));
        List.Add(new UserAccountLab5("Đen Vâu", 5, 70, "Ca Nhạc", 10));
        List.Add(new UserAccountLab5("Thùy Linh", 15, 45.5f, "Ca Nhạc", 25));
        List.Add(new UserAccountLab5("Độ Mixi", 1, 90, "ALL", 2));
        List.Add(new UserAccountLab5("Bà tuyết Diamond", 3, 60.5f, "Ẩm thực", 10));
        List.Add(new UserAccountLab5("PewPew", 4, 55.5f, "live", 50));
        List.Add(new UserAccountLab5("Lê Bảo Bình", 3, 45f, "live", 30));


        //Sap xep ti le winRate
        List = List.SkipWhile(u => u.winRate > 50).OrderByDescending(u => u.winRate).ToList();
        Console.WriteLine("Danh sách sau khi lọc những người có 'WinRate' <= 50 và sắp xếp giảm dần theo 'WinRate':\n");
        foreach (UserAccountLab5 user in List)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, Win Rate: {user.winRate}, Type: {user.type}, Skin: {user.skin}\n");
        }

        // Câu b
        List.Sort((x, y)
            => y.rank.CompareTo(x.rank));

        Console.WriteLine("Danh sách sau khi sắp xếp theo Rank giảm dần:\n");
        foreach (UserAccountLab5 user in List)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, Win Rate: {user.winRate}, Type: {user.type}, Skin: {user.skin}\n");
        }

        List.Sort((x, y) =>
        {
            if (y.name.CompareTo(x.name) != 0)
            {
                return y.name.CompareTo(x.name);
            }
            else
            {
                return y.skin.CompareTo(x.skin);
            }
        });


        // Câu c
        Console.WriteLine("\nDanh sách sau khi sắp xếp theo Name và Skin giảm dần:\n");
        foreach (UserAccountLab5 user in List)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, Win Rate: {user.winRate}, Type: {user.type}, Skin: {user.skin}\n");
        }

        List<UserAccountLab5> result = List.FindAll(u => u.name.StartsWith("B"));


        // Câu d
        Console.WriteLine("\nDanh sách người có Name bắt đầu bằng ký tự 'B':\n");
        foreach (UserAccountLab5 user in result)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, Win Rate: {user.winRate}, Type: {user.type}, Skin: {user.skin}\n");
        }
    }
}