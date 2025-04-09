using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            int 빈칸 = 2 * radius + (size/3);
            int a, b;
            int i=0;
            while(i<size)
            {
                if(i==0)
                {
                    for(b= 0; b< 빈칸+1; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for(b= 0; b<size/3-1; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                    i++;
                    
                }
                else if(i==1 || i==size-1)
                {
                    Console.Write(" ");
                    for(b= 0; b< 2* radius-1; b++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    for(b= 0; b< size/3; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for(b= 0; b<size/3-1; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                    i++;
                }
                else if(i== (2*radius)/3 +1 || i == ((2*radius)/3*2+2))
                {
                    Console.Write("*");
                    for(b= 0; b<2*radius; b++)
                    {
                        Console.Write(" ");
                    }
                    for(b= 0; b<size; b++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                    i++;
                }
                else
                {
                    Console.Write("*");
                    for(b= 0; b< 빈칸; b++)
                    {
                    Console.Write(" ");
                    }
                    Console.Write("*");
                    for(b= 0; b<size/3-1; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                    i++;
                }
            }
            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}
