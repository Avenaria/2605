using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2605
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c-для числовых данных, символ местной валюты
            //d-для целочисленных значаний 
            //е е- выводит число в экспоненциальной форме +1е
            //f F - выводит число с фиксированной десятичнйо точкой 
            // N n  в формате локальных настроек
            // P - с символом %
            // x -выводит в 16 представлении

            //double test1 = 9999999.879;
            //int test2 = 9999;
            //Console.WriteLine( string.Format("c format : {0,15:c}",test1));
            //Console.WriteLine( string.Format("d format : {0:d9}",test2));
            //Console.WriteLine( string.Format("e format : {0:e}",test1));
            //Console.WriteLine( string.Format("g format : {0:g}",test1));
            //Console.WriteLine( string.Format("n format : {0,15:n}",test2));
            //Console.WriteLine( string.Format("x format : {0:x}",test2));

            //Console.WriteLine($" double{test1}");//передача значений можно туда впихнуть в тернанрый оператор 

            // StringBuilder
            //Append(0-добавляет ещё строку к исходной 
            //Appendformat -добавляет строку в форматиррованную строку.
            //Insert -вставка строки в строку
            //Remuve -может удалять диапозон символов в строку
            // Replece(0)-заменяет символ или подстроку на указанный 
            //CoryTo- копирует в массив

            //   StringBuilder sB = new StringBuilder();
            //sB.Append("Hello");
            //sB.AppendLine();    //пустая строка добавить


            //Console.WriteLine(sB);
            //sB.Insert(4,"iugfhrguh");
            //Console.WriteLine(sB);
            //sB.Replace('a', 'f');
            //Console.WriteLine(sB);
            //sB.Remove(4, 9);
            //Console.WriteLine(sB);
            //Console.WriteLine($"{sB.Capacity}");
            /// перечеслители enum ___NAme {dflskj,dfsf,sfs,fsdf,fsdf}
            /// getname()-выводит имя константы в данном перечеслении имеющее заданое значени
            /// get Names -выводит маасив имён 
            /// getValues - выводит значение констатнт в данном
            /// Is Define - признак наличия константы с задонным перечеслениям
            /// Pars -приобразует строковое значение, в эквиволентный обьект стркоав число 




            // int count = 0;

            //Console.WriteLine(Console.ReadLine().Split('a', 'e', 'y', 'o', 'y','i').Length);

            //string str = "Кролик ехал на Роликах покупать роллы ";
            //string str2 = "рол ";
            //int count =0;
            int [,] a = { { 9, 4 }, { 1, 4 } };
            int [,] a2= { { 6, 8 }, { 3, 4 } };
            //foreach (int i in a2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}
            int k = 0;
            for(int i = 0; i < a2.GetLength(0); i++)
            {
                for(int j = 0; j < a2.GetLength(1); j++)
                {
                    a[i,j] = a2[i,j];
                    Console.WriteLine(a2[i,j]);
                    
                }
                  
            }

        }
            
                
            
           
       



    }
}



        

    
