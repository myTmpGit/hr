using System;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 3, 4, 3, 1, 2 },
                { 1, 3, 4, 3, 0, 2 },
                { 0, 2, 4, 3, 1, 2 },
                { 1, 3, 0, 3, 1, 2 },
                { 3, 1, 0, 3, 3, 2 },
                { 9, 3, 4, 3, 1, 2 }, };
            int summ = int.MinValue;
            int s = int.MinValue;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    summ = arr[i, j] + arr[i, j + 1] + arr[i, j + 2] + arr[i + 1, j + 1] + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                    if (s <= summ)
                    {
                        s = summ;
                    }
                }
            }
            Console.WriteLine(s.ToString());
            Console.ReadLine();
        }
    }
}
