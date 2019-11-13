using System;
using System.Collections.Generic;
using System.Text;
namespace laba_18
{
    class Program
    {
        static void Create(List<int> a, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a.Add(r.Next(-100, 100));
            }

        }
        static void Print(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
                System.Console.Write(" " + a[i]);
            System.Console.WriteLine();
        }
        static int minIndex(List<int> a)
        {
            int min = a[0], index = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] < min && (a[i] % 2 == 1 || a[i] % 2 == -1) || min % 2 == 0)
                {
                    min = a[i];
                    index = i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            System.Console.Write("n = ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            List<int> a = new List<int>();
            Create(a, n);
            Print(a);
            System.Console.WriteLine("Index of min number is " + minIndex(a));
        }
    }
}
