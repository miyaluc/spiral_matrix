using System;

namespace Matrix_Spirals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the spiral");

            int[,] structure =
            {
                { 1, 2, 3, 4, 5, 6},
                {7, 8, 9, 10, 11, 12 },
                { 13, 14, 15, 16, 17, 18}
            };
            int m = 3;
            int n = 6;

            Spiralizer(m, n, structure);

            Console.ReadLine();
        }

        //m - rows, n - columns
        static void Spiralizer(int m, int n, int[,] structure)
        {
            int i, k = 0, l = 0;

            //k - this is the starting row index
            //m - ending row index
            //l - starting column index
            //n - ending column index
            //i - iterator

            //while starting row index < ending row index AND starting column index < ending column index
            while (k < m && l < n)
            {
                //printing the first (top) row 
                for (i = l; i < n; i++)
                {
                    Console.WriteLine(structure[k, i]);
                }
                k++;

                //printing the last (far right) column
                for (i = k; i < m; i++)
                {
                    Console.WriteLine(structure[i, n - 1]);
                }
                n--;

                //if there are rows remaining
                if (k < m)
                {
                    //printing the last (bottom) row
                    for (i = n - 1; i >= l; i--)
                    {
                        Console.WriteLine(structure[m - 1, i]);
                    }
                    m--;
                }

                //if there are columns remaining
                if (l < n)
                {
                    //printing the first (far left) column
                    for (i = m - 1; i >= k; i--)
                    {
                        Console.WriteLine(structure[i, l]);
                    }
                    l++;
                }
            }
        }
    }
}
