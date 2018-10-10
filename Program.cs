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
            //задаём ширину
            Console.Write("i = ");
            string a = Console.ReadLine();
            //задаём длину
            Console.Write("j = ");
            string b = Console.ReadLine();            
            //пробел между матрицей и выбором действий
            Console.WriteLine();

            
            //заполнение матрици
            int[,] Array = new int[Convert.ToInt32(a), Convert.ToInt32(b)];
            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                for (int j = 0; j < Convert.ToInt32(b); j++)
                {
                    Array[i,j] = 0;
                }                
            }

          //переход к выводу матрицы
          Vubir:
            Console.WriteLine("Выберите из предложеного:");
            Console.WriteLine("1.Матрица; 2.Замена; 3.Удаление; 4.Рандом 5.Выхид.");
            Console.WriteLine();
            Console.Write("Ваш выбор: ");

            string v = Console.ReadLine();

            switch (v)
            {                
                case "Матрица":
                    goto Matrix;                    
                case "Замена":
                    goto Matrix2;                    
                case "Удаление":
                    goto Matrix3;
                case "Рандом":
                    goto Matrix4;
                case "Выхид":
                    goto Exit;                   

            }

          Matrix:
            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                for (int j = 0; j < Convert.ToInt32(b); j++)
                {
                    Console.Write("{0}", Array[i,j]);
                }
                Console.WriteLine();
            }
            goto Vubir;

          Matrix2:
            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                for (int j = 0; j < Convert.ToInt32(b); j++)
                {
                    if (i == 0)
                    {
                        Console.Write("1");
                    }   
                    
                    else if (j == 0)
                    {
                        Console.Write("1");
                    }

                    else
                    {
                        Console.Write("{0}", Array[i, j]);
                    } 
                                       
                    
                }
                Console.WriteLine();
            }
            goto Vubir;

        Matrix3:
            Console.WriteLine("Какой рядок и столбек удалить?");
            Console.Write("Выбор рядка: ");
            string c1 = Console.ReadLine();
            Console.Write("Выбор столбца: ");
            string c2 = Console.ReadLine();

            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                for(int j = 0; j < Convert.ToInt32(b); j++)
                {
                    if (i == (Convert.ToInt32(c1)))
                    {
                        Console.Write("-");
                    }
                    else if (j == (Convert.ToInt32(c2)))
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("{0}", Array[i, j]);
                    }
                }
                Console.WriteLine();
            }
            goto Vubir;

        Matrix4:
           Random rand = new Random();
            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                for (int j = 0; j < Convert.ToInt32(b); j++)
                {
                    Console.Write(" {0} ",Array[i,j] = rand.Next());
                }
                Console.WriteLine();
            }
            goto Vubir;

          Exit:
            Console.ReadKey();
        }

    }
}
