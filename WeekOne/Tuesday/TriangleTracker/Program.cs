using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Give me 3 numbers: ");
      int num1 = int.Parse(Console.ReadLine());
      int num2 = int.Parse(Console.ReadLine());
      int num3 = int.Parse(Console.ReadLine());

      Triangle triangle = new Triangle(num1, num2, num3);

      Console.WriteLine(triangle.DetermineType());
    }
  }
}
