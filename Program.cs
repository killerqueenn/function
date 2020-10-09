using System;
using System.ComponentModel;
using System.Diagnostics;

namespace table_of_values
{
    class Program
    {
        public static void Func(int[] y) 
        {
            int x = 0;
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = x * x + 2 * x;
            }
        }
        
        public static int MaxNumber(int[] y) 
        {
            int maxN = y[0]; 
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] > maxN)
                {
                    maxN = y[i]; 
                }
            } 
            return maxN;
        }
        public static void WriteTable(int[] y, double step) 
        {
            double x = 0;
            string maxNum = Convert.ToString(MaxNumber(y)); 
            Console.Write('|');
            Console.Write('x');
            for (int i = 0; i < maxNum.Length; i++) 
            {
                Console.Write(' ');
            }
            Console.Write('|');
            Console.Write('y');
            for (int i = 0; i < maxNum.Length; i++)
            {
                Console.Write(' ');
            }                      
            Console.WriteLine('|');
            for (int i = 0; i < y.Length; i++)
            {
                string number = Convert.ToString(x);
                Console.Write('|');
                Console.Write(x);
                for (int p = 0; p < (maxNum.Length - number.Length + 1); p++)
                {
                    Console.Write(' ');
                }
                x = x + step; 
                Console.Write('|');
                Console.Write(y[i]);
                number = Convert.ToString(y[i]);
                for (int p = 0; p < (maxNum.Length - number.Length + 1); p++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('|');
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг построения: ");
            string step = Console.ReadLine();
            int.Parse(step);

            Console.WriteLine("Введите максимальное значение диапазона для x: ");
            string maxX = Console.ReadLine();
            int.Parse(maxX);

            Console.WriteLine("Введите минимальное значение диапазона для x: ");
            string minX = Console.ReadLine();
            int.Parse(minX);



            int[] y = new int[5];
            Func(y);                 
            WriteTable(y);           
        }
    } 
}