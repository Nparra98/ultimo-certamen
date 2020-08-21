using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[6, 6];

            for (int i = 0; 1 < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        mat[i, j] = 1;
                    }
                    else
                    {
                        mat[i, j] = 0;

                    }

                    Console.Write("{0}", mat[i, j]);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
