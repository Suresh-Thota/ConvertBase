using System;

namespace ConvertBase
{
    class Program
    {
        public static void Binary(int n)
        {
            if (n == 0)
                return;
            Binary(n / 2);
            Console.Write(n % 2 + " ");
        }
        public static void ConvertToBase(int n,int b)
        {
            if (n == 0)
                return;
            ConvertToBase(n / b, b);
            int remainder = n % b;
            if (remainder < 10)
                Console.Write(" " + remainder);
            else
                Console.Write((char)(remainder - 10 + 'A'));
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Binary form of given number is: ");
            Binary(n);
            Console.WriteLine();
            Console.Write("binary form ");ConvertToBase(n, 2);
            Console.WriteLine();
            Console.Write("octal form ");ConvertToBase(n, 8);
            Console.WriteLine();
            Console.WriteLine("hexadecimal form ");ConvertToBase(n, 16);
            Console.WriteLine();

        }
    }
}
