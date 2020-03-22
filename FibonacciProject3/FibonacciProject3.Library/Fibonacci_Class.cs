using System;


namespace FibonacciProject3.Library
{
    public class Fibonacci_Class
    {
        public static void Fibonacci(int n)
        {
            int i1 = 0;
            int i2 = 1;
            int i;                      

            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Elements of string Fibonacci are : " + i1);                      
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Elements of string Fibonacci are : " + i1 + "," + i2);                                               
                        break;
                    }
                default:
                    Console.Write("Elements of string Fibonacci are : " + i1 + "," + i2);
                   

                    for (int j = 2; j < n; j++)
                    {
                        i = i1 + i2;
                        i1 = i2;
                        i2 = i;
                        Console.Write("," + i);                                             
                    }
                    break;
            }
            
            Console.WriteLine();           
            
        }
}
}
