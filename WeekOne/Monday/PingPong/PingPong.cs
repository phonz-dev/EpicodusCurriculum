using System;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Give me a number:");
      string strNum = Console.ReadLine();
      int intNum = int.Parse(strNum);

      for (int i = 1; i <= intNum; i++)
      {
        if (IsDivisibleByThree(i) && IsDivisibleByFive(i))
        {
          Console.WriteLine("ping-pong");
        }
        else if (IsDivisibleByThree(i))
        {
          Console.WriteLine("ping");
        }
        else if (IsDivisibleByFive(i))
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }

    private static bool IsDivisibleByThree(int num)
    {
      return num % 3 == 0;
    }

    private static bool IsDivisibleByFive(int num)
    {
      return num % 5 == 0;
    }
  }
}
