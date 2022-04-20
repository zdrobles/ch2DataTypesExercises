using System;

namespace DataTypesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            //Console.WriteLine(length.GetType());

            double area = width * length;

            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
