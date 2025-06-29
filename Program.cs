using System;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Start of the console app");
      BasicArray B = new BasicArray();
      //B.Operations();
      //B.ZerosAtLast();
      // B.RotateArray();

      Console.WriteLine("Enter an array ");
      int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
      //int[] result = B.RemoveDuplicate(arr);

      //Console.WriteLine($"The resultant array is {string.Join(" ", result)}");
      int res =B.MissingNumber(arr);
      Console.WriteLine($"The missing number is {res}");
    }
  }
}