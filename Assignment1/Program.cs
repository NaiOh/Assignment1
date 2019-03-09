using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, p;
            Console.WriteLine("Enter value for X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for Y");
            y = Convert.ToInt32(Console.ReadLine());

            PrintPrimeNumbers(x, y);

            Console.WriteLine("Enter value to get Series");
            z = Convert.ToInt32(Console.ReadLine());
            //double r1 = getSeriesResult(z);
            //Console.WriteLine("Factorial is: " + r1);
            double r1 = GetSeriesResult(z);
            Console.WriteLine("The sum of the series is: " + r1);

            Console.WriteLine("Print triangle");
            p = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(p);

            //declae and instert strings in array
            int[] a = new[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            ComputeFrequency(a);



            //Or get input here
            //Console.WriteLine("Enter the Array Number: ");
            //int w = Convert.ToInt32(Console.ReadLine());
            //GetArray(w);
            
            Console.ReadKey();

        }
        public static void PrintPrimeNumbers(int x, int y)
        {
            int i, j;
            for (i = x; i <= y; i++)
            {
                bool isPrime = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }
            }
        }
        public static double GetSeriesResult(int b)
        {
            double result = 0;

            try
            {
                int a = 1; // always start at 1 for factorial.
                double c;
                for (a = 1; a <= b; a++)
                {
                    c = ((Math.Pow(-1, (a + 1))) * Factorial(a)) / (a + 1);
                    result = result + c;
                    //Console.WriteLine("Final: " + final);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }

            return result;

        }
        public static double Factorial(int n)
        {
            int counter, fact;
            fact = n;

            for (counter = n - 1; counter >= 1; counter--)
            {
                fact = fact * counter;
            }
            return fact;
        }
        public static void PrintTriangle(int n)
        {

            try
            {
                int i, j, k, l;
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    for (l = i - 1; l >= 1; l--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static void ComputeFrequency(int[] a)
        {
            int i, cnt, j;
            int[] repeatNum = new int[55];
            try
            {
                for (i = 0; i < a.Length; i++)
                {
                    repeatNum[i] = -1;
                }

                for (i = 0; i < a.Length; i++)
                {
                    cnt = 1;
                    for (j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            cnt++;
                            repeatNum[j] = 0;
                        }
                    }
                    if (repeatNum[i] != 0)
                    {
                        repeatNum[i] = cnt;
                    }
                }

                Console.WriteLine(" Number	Frequency");

                for (i = 0; i < a.Length; i++)
                {
                    if (repeatNum[i] != 0)
                    {
                        Console.WriteLine(" "+a[i] + "         " + repeatNum[i]);
                    }
                }





            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
        public static void GetArray(int w)
        {
            int[] a = new int[55];
            int[] v = new int[55];

            Console.WriteLine("Enter Element in Array[" + w + "]: ");
            for (int i = 0; i < w; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                v[i] = -1;
            }

        }


    }

}
