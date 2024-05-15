
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            Console.WriteLine("ID: " + UserData.ID);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Health: " + UserData.Health);
            Console.WriteLine("Point: " + UserData.Point);

            //Bài 2

            var maps1 = new Maps("2024", "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps()
            {
                ID = "2024",
                Name = "URF"
            };
            Console.WriteLine(maps2.ShowData());

            //Bài 3

            var calculator = new Calculator();
            calculator.A = 4;
            calculator.B = 0;

            Console.WriteLine("Kết quả của A + B: " + calculator.Cong());
            Console.WriteLine("Kết quả của A - B: " + calculator.Tru());
            Console.WriteLine("Kết quả của A * B: " + calculator.Nhan());
            Console.WriteLine("Kết quả của A / B: " + calculator.Chia());

        }

    }
        
}
