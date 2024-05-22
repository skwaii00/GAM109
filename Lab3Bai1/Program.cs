using System.Diagnostics;
using System.Text;


string path = "example.txt";
    using (FileStream fs = new FileStream(path, FileMode.Create))
{
    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
    {
        sw.WriteLine("Username:");
        sw.WriteLine("Password:");
    }
}
    using (FileStream fs = new FileStream(path, FileMode.Open))
{
    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}


   //Bài2

//Tạo biến
string username = "A";
string password = "B";
string time = DateTime.Now.ToString();

// StringWriter Lưu TK và MK
using (StringWriter sw = new StringWriter())
{

    sw.WriteLine ("Username: " + username);
    sw.WriteLine ("Password: " + password);
    sw.WriteLine ("Time save: " + time);

    // Lấy nội dung đã lưu trong StringWriter
    string content = sw.ToString();

    // Sử dụng StringReader để đọc các data đã lưu và xuất ra màn hình console
    using (StringReader sr = new StringReader(content))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}

    //Bài3

Directory.CreateDirectory("data");
using (StreamWriter sw = new StreamWriter(File.Create("data/data.txt")))
{
    sw.WriteLine("MSSV:PD10121");
    sw.WriteLine("Họ và tên:Đinh Văn Bình");
}
Directory.CreateDirectory("data2");
File.Copy("data/data.txt","data2/data.txt");