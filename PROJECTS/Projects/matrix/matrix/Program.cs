using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//matrix multiplication
namespace matrix
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m=0,n=0,i,j,k;
            int m1=0,n1=0;
            Console.WriteLine("------Matrix multiplication-------");
            while (true)
            {  
                do

                {
                    //if((m <= 0 || n <= 0))
                    //{
                    //    Console.WriteLine("Enter a non zero value");
                    //}
                    
                    Console.WriteLine("Enter the size  (m*n) for matrix1");
                        while (!(int.TryParse(Console.ReadLine(), out m)) || m<=0)
                        {
                            Console.WriteLine("Enter only integer values");
                           // Console.Clear();
                    }
                      
                    while (!(int.TryParse(Console.ReadLine(), out n)) || n<=0)
                    {
                        Console.WriteLine("Enter only integer values");
                    }    
                } while ( m <=0 || n <=0);       
                do
                {
                    Console.WriteLine("Enter the size (m*n) for the matrix2");
                    while (!(int.TryParse(Console.ReadLine(), out m1)) || m1<=0)
                    {
                        Console.WriteLine("Enter only integer values");
                    }
                    while (!(int.TryParse(Console.ReadLine(), out n1)) ||n1<= 0)
                    {
                        Console.WriteLine("Enter only integer values");
                    }  
                } while (m1 > 5 || n1 > 5 || m1 < 0 || n1 < 0);
                if (m1 == n)
                    break;
                else
                    Console.WriteLine("Matrix multiplication not posible");
            }
            int[,] a = new int[m, n];
            int[,] b=new int[m1,n1];
            int[,] c=new int[m,n1];
            Console.WriteLine("Enter the matrix elements for the matrix 1");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    while(!(int.TryParse(Console.ReadLine(),out a[i,j])))
                    {
                        Console.WriteLine("Enter only integer values");
                    }
                }
            }
            Console.WriteLine("Enter the matrix elements for the matrix 2");
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n1; j++)
                {
                    while (!(int.TryParse(Console.ReadLine(), out b[i, j])))
                    {
                        Console.WriteLine("Enter only integer values");
                    }
                }
            }
            if(m1==n)
            {
                Console.WriteLine("The matrix obtained after multiplication is");
                for(i=0;i<m;i++)
                {
                    for(j=0;j<n1;j++)
                    {
                        for(k=0;k<n;k++)
                        c[i,j]+=a[i,k]*b[k,j];
                    }
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n1; j++)
                    {
                        Console.Write(c[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Matrix multiplication is not possible");
            }

            Console.ReadKey();
        }
    }
}
