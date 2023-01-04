using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] r;
            string[] f ;
            int b = 0;
            char[] ch;
            char[] ch1;
            int c = 0;
            string s = Console.ReadLine();
            string[] values = s.Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);
 
            for (int i = 0; i < x; i++)
            {
                r[i] = Console.ReadLine();
            }
            for (int i = 0; i < x; i++)
            {
                f[i] = Console.ReadLine();
            }
            for (int i = 0; i < x; i++)
            {
                r[i] = r[i].Replace("W", "N");
                r[i] = r[i].Replace("B", "W");
                r[i] = r[i].Replace("N", "B");
            }
            for (int i = 0; i < x; i++)
            {
                ch = r[i].ToCharArray();
                ch1 = f[i].ToCharArray();
                for (int j = 0; j < y; j++)
                {
                    if (ch[j] == ch1[j])
                    {
                        b = b + 1;
                    }
                    else
                        c++;
                }
            }
            Console.WriteLine(c);
 
        }
 
    }
}