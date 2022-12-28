using System;

namespace Lessen
{
    class Program
    {
        static void Main(string{} args)
        {
            uint oddNumbersCount = 0; //нечетные числа
            uint eveNumbersCount = 0; //четные числа
            Console.WriteLine("введите первое число")
            int currentValue = int.Parse(Console.Readline())
            Console.WriteLine("введите последнее число")
            int limit = int.Parse(Console.Readline)
            
            while (currentValue <= limt)
            {
              if (currentValue%2==0)
              {
                eveNumbersCount++;
              }
              else
              {
                oddNumbersCount++;
              }
               
               currentValue++;
            }
            Console.Writeline("количество нечетных чисел: " + oddNumbersCount);
            Console.Writeline("количество четных чисел: " + eveNumbersCount);
            Console.ReadLine();

        }
    }
}