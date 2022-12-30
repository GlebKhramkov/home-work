 class Program
    {
        static void Main(string[] args)
        {
 
            int[] arr = { 5, 3, 7, 4, 6,};//тут мы можем менять числа в массиве (5, 3, 7, 4, 6,/4, 6, 5, 3, 7,)
            int k = 3;
            int tmp;
            int nextInd = 0;
 
            Console.WriteLine(string.Join(" ", arr));
 
            for (int i = 0; i < arr.Length-1; ++i)
            {
                nextInd += k;
                nextInd %= arr.Length;
 
                tmp = arr[nextInd];
                arr[nextInd] = arr[0];
                arr[0] = tmp;
            }
 
            Console.WriteLine(string.Join(" ", arr));
 
        }
        
    }