namespace Demo
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
            #region comments
            //single line comment
            /*
             * multiple 
             * line
             * comment
             * 
             * 
             * 
             * */
            #endregion

            #region Variable Declaration
            //int id = 10;

            ////PascalCase -> FirstName
            ////camelCase -> firstName
            ////kabab-case -> first-name [Angular Files]
            ////snake_case -> first_name
            //Console.WriteLine(id);   
            #endregion

            #region Varibale datatype
            //int x;
            //x = 5;
            ////clr will alocate 4 unintialized bytes by stack
            ////int c# keywaord
            //Int32 y = 10;
            ////int c# bcl

            //y = x; //5
            //x++; //6
            //Console.WriteLine(y); 
            #endregion

            #region ReferenceType
            Point p1;
            //declare  for reference of type point = null
            // p1 can refer to an obj of type point or another inherting 
            //clr will alocate 4 bytes for reference in stack 
            //clr will alocate 0 bytes at heap
            p1 = new Point();

            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);

            Point p2 = new Point(); //unreachable obj
            p2 = p1;

            p2.x = 10; p2.y = 20;
            Console.WriteLine(p1.x); // 10 
            #endregion

            #region Part 12 Fractions and Discard
            //float x = 5.3f;
            //double y = 4.34;
            //decimal z = 9943.4m;

            ////for readability (discard)
            //long Number = 100_000_000_000; 
            #endregion

            #region Implicit
            //int x = 8;

            //long y =/*long*/ x; //1.implicit casting [safe casting]

            //Console.WriteLine(y); 
            #endregion

            #region Explicit
            //long x = 5468464648879;
            //checked
            //{
            //    int y = (int)x; //explicit casting 
            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }
            //} 
            #endregion

            #region Convert
            //// convert is a class conatining set of methods used for casting from datatype to another
            //Console.Write("Please Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "NA";

            //Console.WriteLine("Please Enter Your Age: ");
            //int Age = Convert .ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal Salary = Convert .ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 2000);

            //Console.WriteLine($"Your Name is {Name}");
            //Console.WriteLine($"Your Age is {Age}");
            //Console.WriteLine($"Your Salary is {Salary}"); 
            #endregion

            #region Parse
            ////parse is a method for casting to the caller datatype 
            //Console.Write("Please Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "NA";

            //Console.WriteLine("Please Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.Beep(324, 2000);

            //Console.WriteLine($"Your Name is {Name}");
            //Console.WriteLine($"Your Age is {Age}");
            //Console.WriteLine($"Your Salary is {Salary}"); 
            #endregion

            #region TryParse
            //string x = "Ahmed";

            //int y;

            //bool flag = int.TryParse(x, out y); // if failed, no exception will be thrown
            //Console.WriteLine(flag);
            //Console.WriteLine(y); 
            #endregion

            #region opertatiion priority
            //opertatiion priority
            /**
             * unary operator (prefix)
             * round  braces ()
             * * / %
             * + -
             */
            #endregion

            #region StringForamting
            //// Equation: 3 + 4 = 7
            //int x = 3, y = 4;
            //string message = "Equation: " + x + " + " + y + " = " + (x + y);
            //Console.WriteLine(message);

            ////1.composite formating
            //message = string.Format("Equation: {0} + {1} = {2}", x, y, (x+y));
            //Console.WriteLine(message);

            ////2.string interpolation
            //message = $"Equation: {x} + {y} = {x + y}";
            //Console.WriteLine(message); 
            #endregion
        }
    }
}
