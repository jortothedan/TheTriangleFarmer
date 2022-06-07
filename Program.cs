using System;

namespace TheTriangleFarmer
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleHeight;
            double triangleBase;

            Console.WriteLine("What is the triangle's Base?");
            triangleBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the triangle's Height?");
            triangleHeight = Convert.ToDouble(Console.ReadLine());

            double area = triangleBase * triangleHeight / 2;

            Console.WriteLine("The triangle's Area is: " + area);

        }
    }
}
