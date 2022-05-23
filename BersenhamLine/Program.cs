using System;

namespace BersenhamLine
{
    class Program
    {
        static void bresenham(int x1, int y1, int x2, int y2)
        {
            int x, y;
            int DeltaX= (x2-x1);
            int DeltaY = (y2 - y1);
            int slope_error_new = 2* DeltaY - DeltaX;


            int i = 0;
            for (x = x1, y = y1; x <= x2;)
            {

               
                 Console.Write("Point" + "[" + (i) + "]" + "=" + "(" + x + "," + y + ")\n");
               
               


                if (slope_error_new < 0)
                {
                    x++;
                    slope_error_new += 2 * DeltaY;
                }
                else
                {
                    x++; y++;
                    slope_error_new += 2*DeltaY- 2*DeltaX;
                }
                i++;
            }
        }

        // Driver code
        public static void Main()
        {
            Console.Write("Enter X1 :");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y1 :");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter XEnd :");
            int XEnd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter YEnd :");
            int YEnd = Convert.ToInt32(Console.ReadLine());

            bresenham(X1, Y1,XEnd, YEnd);
            Console.ReadLine();

        }
    }
}

