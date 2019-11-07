using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IntToDouble
    {
        public static void convert(int n, double[] Array1)
        {
            Console.WriteLine("Array of int");
            for (int i = 0; i < n; i++)
            {
                int[] Array2 = new int[n];
                Array2[i] = (int)Array1[i];
                Console.WriteLine(Array2[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter array lenght");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] Array1 = new double[n];
                // Random r = new Random();
                Console.WriteLine("Array of double");
                for (int i = 0; i < n; i++)
                {
                    //Array1[i] = r.NextDouble();
                    Array1[i] = Convert.ToDouble(Console.ReadLine());
                    // Console.WriteLine(Array1[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                convert(n, Array1);
            }
        }
    }
}
