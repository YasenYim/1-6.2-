using System;

namespace 数组最大值
{
    class Program
    {
        static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] g = new int[] { 2, 5, 6, 4, 7 };
            
            Console.WriteLine(MaxElement(g));

            Console.ReadKey();
        }
    }
}
