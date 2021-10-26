using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
                          {0,1,2,3},
                          {3,6,1,7},
                          {5,8,1,0},
                          {5,1,7,3}
                         };

            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    if (x == 0 && y != 0)
                    {
                        Console.WriteLine();
                    }

                    if (arr.GetLength(1) > x + 1)
                    {
                        Console.Write(arr[y, x] + ",");
                    }
                    else
                    {
                        Console.Write(arr[y, x]);
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
