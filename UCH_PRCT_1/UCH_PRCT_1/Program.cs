using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Virus
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Введите n m k: ");
            string[] s = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(s[0]);
            int n = Convert.ToInt32(s[1]);
            int k = Convert.ToInt32(s[2]);
            int[]
                x = new int[k],
                y = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Введите x[{0}] y[{0}]: ", i);
                s = Console.ReadLine().Split(' ');
                x[i] = Convert.ToInt32(s[0]);
                y[i] = Convert.ToInt32(s[1]);
            }
            int max = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    int min = n + m;
                    for (int l = 0; l < k; l++)
                    {
                        int d = Math.Abs(i - x[l]) + Math.Abs(j - y[l]);
                        if (d < min) min = d;
                    }
                    if (min > max) max = min;
                }
            Console.WriteLine("Результат max: {0}", max);
            Console.ReadKey();
        }

    }
}