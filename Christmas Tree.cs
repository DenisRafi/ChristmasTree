using System;

namespace ByDenisRafi
{
    class Program
    {
        static void T1(int a, int b, int c)
        {
            int i, j, k, l = 0;
            for (i = a; i <= b; i++)
            {
                for (j = c - l; j > a; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                {
                    if (k == 1)
                        Console.Write(" /");
                    if (k == i)
                        Console.Write(" \\");
                    else
                        Console.Write(" ^");
                }
                Console.WriteLine();
                l++;
            }
        }
        static void T2(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.Write(" ");
        }
        static void func_l(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                T2(9);
                Console.WriteLine("||||");
            }
        }
        static void Main()
        {          
            T2(11);
            Console.Write("^");
            T1(0, 5, 11);
            T1(3, 7, 11);
            T1(5, 11, 11);
            func_l(4);
            Console.Write("\n ---------------");
            Console.Write("\n By Denis Rafi");
            Console.Write("\n ---------------");
            Console.ReadKey();
        }
    }
}
