namespace Assigment_1
{
    class Point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //int Number = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine($"The number is: {Number}"); 
            #endregion

            #region Q2
            //Console.Write("Enter a string to convert to an integer:");
            //string input = Console.ReadLine() ?? "NA";

            //int result;
            //bool flag = int.TryParse(input, out result);
            //Console.WriteLine(flag);
            //Console.WriteLine(result); 
            #endregion

            #region Q3
            //Console.Write("Enter 1 floating number: ");
            //float num1 = float.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter 2 floating number: ");
            //float num2 = float.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine($"Sum for the 2 number is {num1+num2}"); 
            #endregion

            #region Q4
            //Console.Write("Enter a string:");
            //string msg = Console.ReadLine() ?? "NA";

            //Console.Write("Enter the starting position for the substring:");
            //int startPosition = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter the length of the substring:");
            //int length = int.Parse(Console.ReadLine() ?? "0");

            //string substring = msg.Substring(startPosition, length);

            //Console.WriteLine($"Extracted substring: {substring}"); 
            #endregion

            #region Q5
            //int var1 = 0;
            //int var2 = 0;
            //var1 = var2;
            //var1 = 5;
            //Console.WriteLine(var2);
            //Console.WriteLine(var1); 
            #endregion

            #region Q6
            //Point p1 = new Point();
            //Point p2 = new Point();

            //p2 = p1;
            //p2.x = 10; p2.y = 20;
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p2.x); 
            #endregion

            #region Q7
            //Console.Write("Enter first string: ");
            //string msg1 = Console.ReadLine() ?? "NA";

            //Console.Write("Enter second string: ");
            //string msg2 = Console.ReadLine() ?? "NA";

            //Console.WriteLine($"{msg1} {msg2}"); 
            #endregion

            #region Q8
            //float PrincipalAmount = 15, RateOfInterest = 20, Time = 10;
            //float SimpleInterest;
            //SimpleInterest = (PrincipalAmount * RateOfInterest * Time) / 100;
            //Console.WriteLine(SimpleInterest); 
            #endregion

            #region Q9
            //Console.Write("Enter your weight in kg: ");
            //float Weight = float.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter your height in M: ");
            //float Height = float.Parse(Console.ReadLine() ?? "0");

            //float BMI = (Weight) / (Height * Height);

            //Console.WriteLine($"Your BMI is: {BMI}"); 
            #endregion

            #region Q10
            //Console.Write("Enter the temperature:");
            //int temperature = int.Parse(Console.ReadLine() ?? "0");
            //string result = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine($"The temperature is: {result}"); 
            #endregion

            #region Q11
            //Console.Write("Enter the day:");
            //int day = int.Parse(Console.ReadLine() ?? "00");

            //Console.Write("Enter the month:");
            //int month = int.Parse(Console.ReadLine() ?? "00");

            //Console.Write("Enter the year:");
            //int year = int.Parse(Console.ReadLine() ?? "0000");

            //DateTime date = new DateTime(year, month, day);
            //Console.WriteLine($"Today's date : {date:dd , MM , yyyy}");
            //Console.WriteLine($"Today's date : {date:dd / MM / yyyy}");
            //Console.WriteLine($"Today's date : {date:dd - MM - yyyy}"); 
            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //// answer is c: The event is on 06/14/2024 
            #endregion

            #region Q13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            //// answer is f: f)	A value 1 will be assigned to d. 
            #endregion

            #region Q14
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //// answer is d: 6 1 
            #endregion

            #region Q15
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //// answer is d 7 7 
            #endregion
        }
    }
}
