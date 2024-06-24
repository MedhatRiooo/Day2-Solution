namespace Assigment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //int Number = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine($"The number is: {Number}"); 
            #endregion

            Console.Write("Enter a string to convert to an integer:");
            string input = Console.ReadLine() ?? "NA";

            int result;
            bool flag = int.TryParse(input, out result);
            Console.WriteLine(flag);
            Console.WriteLine(result);
        }
    }
}
