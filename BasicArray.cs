using System.Buffers;
using System.ComponentModel.DataAnnotations;

public class BasicArray
{
  public void Operations()
  {
    Console.WriteLine("Enter array elements ");
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

    Console.WriteLine("Enter string array elements");

    string[] Arr = Console.ReadLine().Split();

    Console.WriteLine($"Max number is {arr.Max()}");
    Console.WriteLine($"The minimum element is {arr.Min()}");

    Array.Sort(arr);
    Console.WriteLine($"This is sorted{string.Join(" ", arr)}");

    Array.Reverse(arr);
    Array.Reverse(Arr);
    Console.WriteLine($"This is reversed array{string.Join(" ", arr)}");

    Console.WriteLine($"This is reversed string array {string.Join(" ", Arr)}");
 Array.Sort(Arr);
     Console.WriteLine($"This is sorted{string.Join(" ", Arr)}");
    
  }
}