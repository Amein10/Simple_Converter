using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, km;
            Console.Write("Enter Value of Kilometer: ");
            km = Convert.ToDouble(Console.ReadLine());
            miles = km * 0.62137;
            Console.WriteLine("Miles = " + miles);
        }
    }   
}