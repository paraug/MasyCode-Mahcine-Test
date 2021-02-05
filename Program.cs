using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest
{
    class Program
    {        
        static int rows = 4;
        static int cols = 4;

        static void rotatematrix(int m,int n, int[,] mat)
        {
            int row = 0, col = 0;
            int previous, current;
           
            while (row < m && col < n)
            {

                if (row + 1 == m || col + 1 == n)
                    break;

                previous = mat[row + 1, col];
               
                for (int i = col; i < n; i++)
                {
                    current = mat[row, i];
                    mat[row, i] = previous;
                    previous = current;
                }
                row++;
               
                for (int i = row; i < m; i++)
                {
                    current = mat[i, n - 1];
                    mat[i, n - 1] = previous;
                    previous = current;
                }
                n--;
               
                if (row < m)
                {
                    for (int i = n - 1; i >= col; i--)
                    {
                        current = mat[m - 1, i];
                        mat[m - 1, i] = previous;
                        previous = current;
                    }
                }
                m--;

                if (col < n)
                {
                    for (int i = m - 1; i >= row; i--)
                    {
                        current = mat[i, col];
                        mat[i, col] = previous;
                        previous = current;
                    }
                }
                col++;
            }

           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(mat[i, j] + " ");
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
           
            int[,] a = {
              {1, 2, 3, 4},
               {5, 6, 7, 8},
               {9, 10, 11, 12},
               {13, 14, 15, 16}
                        };
            rotatematrix(rows,cols, a);
            Console.ReadKey();
        }
    }
}
