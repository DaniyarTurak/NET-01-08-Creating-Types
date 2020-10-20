using System;

namespace Task_1_FindNthRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8, 3, 0.1 => 2
            double number = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double precision = double.Parse(Console.ReadLine());

            double count = a;
            double n = 0;
            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                double temp_number = number;
                while (count > 0)
                {
                    temp_number /= i;
                    count--;
                    n = i;
                }
                if (temp_number == 1)
                    Console.WriteLine(n);
                else
                    count = a;
            }
        }
    }
}
