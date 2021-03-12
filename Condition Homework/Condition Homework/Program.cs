using System;

namespace Condition_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, t1, t2, x, y;
            string mode, Input1, Input2;
            Console.Write("Please input the mode: ");
            mode = Console.ReadLine();
            Console.WriteLine("Please enter your mouse position ");
            
            Console.Write("time: ");
            Input1 = Console.ReadLine();
            x = double.Parse(Input1);
            Console.Write("price: ");            
            Input2 = Console.ReadLine();
            y = double.Parse(Input2);

            if (x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }
            else
            {
                if (mode == "time")
                {
                    p1 = Math.Pow(x - 1, 2);
                    Console.WriteLine("({0:f2},{1:f2})", x, p1);
                }
                else if (mode == "price")
                {
                    if (x < 1)
                    {
                        if (y > 1)
                        {
                            t2 = (1 + (Math.Sqrt(y)));
                            Console.WriteLine("({0:f2},{1:f2})", t2, y);
                        }
                        else
                        {
                            t2 = (1 - (Math.Sqrt(y)));
                            Console.WriteLine("({0:f2},{1:f2})", t2, y);
                        }
                    }
                    else if (x > 1)
                    {
                        t2 = (1 + (Math.Sqrt(y)));
                        Console.WriteLine("({0:f2},{1:f2})", t2, y);
                    }
                    else
                    {
                        t1 = (1 - (Math.Sqrt(y)));
                        if (t1 > 1)
                        {
                            t2 = (1 + (Math.Sqrt(y)));
                            Console.WriteLine("({0:f2},{1:f2})", t2, y);
                        }
                        else
                        {
                            t1 = (1 - (Math.Sqrt(y)));
                            Console.WriteLine("({0:f2},{1:f2})", t1, y);
                            Console.WriteLine("Or");
                            t2 = (1 + (Math.Sqrt(y)));
                            Console.WriteLine("({0:f2},{1:f2})", t2, y);
                        }
                        
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid Mode");
                }
            }
        }
    }
}
