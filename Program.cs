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
            int c = 10;
            //Matrix fill:
            int[,] Array = new int[a,b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Array[i,j] = c++;
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
                        Console.Write("  1 ");
                    }   
                    
                    else if (j == 0)
                    {
                        Console.Write("  1 ");
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
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Column selection: ");
            int column = Convert.ToInt32(Console.ReadLine());            

            for (int i = 0; i < a ; i++)
            {     
                if (i==row)
                {
                    i++;
                }
                for (int j = 0; j < b ; j++)
                {                    
                                  
                    if (j == column)
                    {
                        j++;
                    }                    
                    Console.Write($" {Array[i, j]} ");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------Random (10-90)--------------");
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

            Console.Write("Press key to ext.");

          //Delay
            Console.ReadKey();
        }

    }
}
