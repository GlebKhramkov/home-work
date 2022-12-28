using System;
using System.Linq;
 
public class Example//так как мой массив идет через arr то усложним его выводом минимальных значений
 
{
    public static void Main()
    {
        int[] arr = { -6, -18, 20 }; // все значения в задаче(2, 3, 7, 44, 5, 78, 22, 3, 9,)
        Console.WriteLine("Minimum number is " + arr.Min());
        Console.WriteLine("Maximum number is " + arr.Max());
    }
}