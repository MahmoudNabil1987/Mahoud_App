using System.Runtime.CompilerServices;

namespace First_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello from EraaSoft538");

            //Console.Write("Enter your favorite number (1-100):");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"No really!! {n} is my favorite number too!");

            //Arrat
            //int[] students = new int[3];
            ////students[0] = 200;
            //students[0] = 500;
            //students[1] = 300;
            //students[2] = 400;
            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);


            //
            //int[] students = { 1, 2, 4 };
            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);

            //List<int> number=new List<int>();
            ////Set
            //number.Add(11);
            //number.Add(22);
            //number.Add(23);
            //number.Add(23);
            //Console.WriteLine(number[0]);
            //Console.WriteLine(number[1]);

            //Console.WriteLine(number.Count);
            //Console.WriteLine(number.Capacity);

            //number.Add(24);
            //number.TrimExcess();
            //Console.WriteLine(number.Count);
            //Console.WriteLine(number.Capacity);

            //
            double tax = 6;
            Console.WriteLine("Estimate for carpet cleaning service");
            List<int> number = new List<int>();
            Console.Write("Number of Small carpet : ");
            number.Add(Convert.ToInt32(Console.ReadLine()));//0
            Console.Write("Number of Large carpet : ");
            number.Add(Convert.ToInt32(Console.ReadLine()));//1
            Console.Write("Price Per Small carpet :$ ");
            number.Add(Convert.ToInt32(Console.ReadLine()));//2
            Console.Write("Price Per Large carpet :$ ");
            number.Add(Convert.ToInt32(Console.ReadLine()));//3
            double total = (number[0] * number[2]) + (number[1] * number[3]);
            Console.WriteLine($"Cost : {total}");
            Console.WriteLine($"Price Per Large carpet :$ {tax}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Total estimate :$ {total+(total*tax/100)}");
            Console.WriteLine("This estimate is valid for 30 days");
           
            //int X = 10;
            //int Y = 20;
            //Console.WriteLine($"Equation: {X} + {Y} = {X + Y:c}");



            //Console.WriteLine("Please enter the commission");
            //int[] numbers = { 100, Convert.ToInt32(Console.ReadLine()) };
            //Console.WriteLine($"The {numbers[0]}-pound commission is: {(numbers[0] * numbers[1]):C}");











        }
    }
}
