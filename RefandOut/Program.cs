using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning  a string and mulitplying the parameter. So it will have two outputs but only returns the string.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable.
        public static string TimesFive(ref int x)
        {
            x = x * 5;

            return $"{x / 5} times 5 is {x}";
        }

        //TODO create method that uses the out keyword. Call the method in the main.
        public static string HalfOfNum(double y, out double number)
        {
            number = y / 2;

            return $"Half of {y} is {number}";
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine("Ref");
            Console.WriteLine("-----------------------");

            int x = 10;
            Console.WriteLine($"Initial x value: {x}");
            Console.WriteLine(TimesFive(ref x));
            Console.WriteLine($"Final x value: {x}\n");

            Console.WriteLine("Out");
            Console.WriteLine("-----------------------");

            double number;
            Console.WriteLine("No value yet for number");
            Console.WriteLine(HalfOfNum(50, out number));
            Console.WriteLine($"Final number value: {number}");
        
        }

    }
}
