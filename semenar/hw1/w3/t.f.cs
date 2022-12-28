namespace check1
 
{
 
    class Program
 
    {
 
        static void Main(string[] args)
 
        {
 
            int i;
 
            Console.Write("Введите число : ");//нашёл как сделать упростить ввод числа
 
            i = int.Parse(Console.ReadLine());
 
            if (i % 2 == 0)
 
            {
 
                Console.Write("Число четное");
 
                Console.Read();
 
            }
 
            else
 
            {
 
                Console.Write("ЧИсло нечетное");
 
                Console.Read();
 
            }
 
        }
 
    }
 
}