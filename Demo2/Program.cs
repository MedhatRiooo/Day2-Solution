namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine() ?? "na";
            Console.Write("Enter your Age: ");
            int.TryParse(Console.ReadLine() ?? "0", out int age);
            Console.Write("Enter your Salary: ");
            double.TryParse(Console.ReadLine() ?? "0", out double Salary);

            Console.Clear();
            Console.Beep(356, 2000);

            Console.WriteLine($"Your name is {Name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your salary is {Salary}");
        }
    }
}
