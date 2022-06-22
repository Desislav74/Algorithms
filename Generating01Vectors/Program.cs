using System;

namespace _3._Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            Gen01(arr, 0);
        }

        private static void Gen01(int[] arr, int idx)
        {

            if (idx == arr.Length)
            {
                Console.WriteLine(string.Join(String.Empty, arr));
                return;
            }


            for (int i = 0; i < 2; i++)
            {
                arr[idx] = i;

                Gen01(arr, idx + 1);
            }
        }
    }
}

