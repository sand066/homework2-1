using System;

class Program
{
  static void Main(string[] args)
  {
    int num = int.Parse(Console.ReadLine());
    while (num < 0)
    {
      Console.WriteLine("Invalid Pascal’s triangle row number.");
      num = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i <= num; i++)
    {
      for (int j = 0; j <= i; j++)
      {
        int a = Factorial(i) / (Factorial(j) * Factorial(i - j));
        Console.Write("{0} ", a);
      }
      Console.WriteLine("");
    }

  }
  static int Factorial(int num)
  {
    if (num <= 1)
    {
      return 1;
    }
    return num * Factorial(num - 1);
  }

}
