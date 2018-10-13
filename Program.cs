using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Таск_Паша_
{
    class Program
    {

        static void Main()
        {
             Random rand = new Random();
            Console.Write("i = ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("j = ");
            int b = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine();            

            //Matrix fill:
            int[,] Array = new int[a,b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Array[i,j] = 0;
                }                
            }


            Console.WriteLine("---------------Matrix output--------------");

          //Matrix output:
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($" {Array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------Replacement--------------");
            //Matrix - row and column replacement:
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(" 1 ");
                    }   
                    
                    else if (j == 0)
                    {
                        Console.Write(" 1 ");
                    }

                    else
                    {
                        Console.Write($" {Array[i, j]} ");
                    } 
                                       
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------Delete--------------");
            //Matrix - Delete row and column:
            Console.WriteLine("Which row and column to delete?");
            Console.Write("Row selection: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Column selection: ");
            int c2 = Convert.ToInt32(Console.ReadLine());

            int[,] ArrayDel = new int[a - 1, b - 1];

            for (int i = 0; i < a - 1; i++)
            {                
                for (int j = 0; j < b - 1; j++)
                {
                    if (i == c1)
                    {
                        ArrayDel[i, j] = Array[i + 1,j];
                    }                    
                    if (j == c2)
                    {
                        ArrayDel[i, j] = Array[i, j + 1];
                    }                    
                    Console.Write($" {ArrayDel[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------Random--------------");
            //Matrix - Random values:
            
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {                    
                    Array[i, j] = rand.Next(10, 99);
                    Console.Write($" {Array[i,j]} ");
                }
                Console.WriteLine();
            }
           

          //Delay
            Console.ReadKey();
        }

    }
}
