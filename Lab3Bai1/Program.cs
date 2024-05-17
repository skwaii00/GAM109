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


    string content = sw.ToString();
// StringReader để đọc TK và MK
   
}
using (StringReader sw = new StringReader())
{
    sw.ReadLine();

}