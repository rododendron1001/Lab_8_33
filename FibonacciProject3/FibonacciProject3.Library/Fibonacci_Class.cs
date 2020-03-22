using System;

namespace FibonacciProject3.Library
{
    public class Fibonacci_Class
    {
        public static string Fibonacci(int n)
        {
            int i1 = 0;
            int i2 = 1;
            int i;
            string[] s = new string[n];
            string s1 = s.ToString();


            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Elements of string Fibonacci are : " + i1);
                        s[0] = Convert.ToString(i1);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Elements of string Fibonacci are : " + i1 + "," + i2);
                        s[0] = Convert.ToString(i1);
                        s[1] = Convert.ToString(i2);
                        break;
                    }
                default:
                    Console.Write("Elements of string Fibonacci are : " + i1 + "," + i2);
                    s[0] = Convert.ToString(i1);
                    s[1] = Convert.ToString(i2);

                    for (int j = 2; j < n; j++)
                    {
                        i = i1 + i2;
                        i1 = i2;
                        i2 = i;
                        Console.Write("," + i);
                        s[j] = Convert.ToString(i);
                    }
                    break;
            }
            return s1;
        }
}
}
