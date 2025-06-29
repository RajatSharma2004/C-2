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

    Console.WriteLine($"The size of 1st array  {arr.Length}");
    Console.WriteLine($"This size of 2nd array  {Arr.Length}");

  }

  public void ZerosAtLast()
  {
    Console.WriteLine("Enter array ");
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int n = arr.Length;
    int[] result = new int[n];
    int x = 0;

    for (int i = 0; i < n; i++)
    {
      if (arr[i] != 0)
      {
        result[x] = arr[i];
        x++;
      }
    }
    while (n > x)
    {
      result[x] = 0;
      x++;
    }

    Console.WriteLine($"Array with 0 at the back is {string.Join(" ", result)}");
  }

  public void RotateArray()
  {
    Console.WriteLine("Input an array ");
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

    Console.WriteLine("Enter position to rotate");
    int pos = int.Parse(Console.ReadLine());

    int n = arr.Length;

    if (pos < 0 || pos >= n)
    {
      Console.WriteLine("Not possible");
      return;
    }


    int[] rotated = new int[n];
    int index = 0;


    for (int i = pos; i < n; i++)
      rotated[index++] = arr[i];


    for (int i = 0; i < pos; i++)
      rotated[index++] = arr[i];

    Console.WriteLine($"Array after rotating from position {pos}: {string.Join(" ", rotated)}");
  }

 
  public int[] RemoveDuplicate(int[] arr)
  {
    Array.Sort(arr);
    int n = arr.Length;
    if (n == 0 || n == 1)
    {
      return arr;
    }
    int j = 0;
    int[] result = new int[n];
    for (int i = 0; i < n - 1; i++)
    {
      if (arr[i] != arr[i + 1])
      {
        result[j++] = arr[i];
      }
    }
    result[j++] = arr[n - 1]; //j++ because it start with 0 so the length oj is more than value of j
    int[] finalResult = new int[j];
    for (int i = 0; i < j; i++)
    {
      finalResult[i] = result[i];
    }

    return finalResult;
  }
  }
