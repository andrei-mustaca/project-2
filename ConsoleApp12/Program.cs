using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //int[] mass = new int[15];
            //Random random = new Random();
            //for(int i=0;i<15;i++)
            //{
            //    mass[i] = random.Next(-50,50) ;
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //for(int i=0;i<15;i++)
            //{
            //    if (mass[i]%3==0)
            //    {
            //        Console.WriteLine($"Элемент кратный трем:{mass[i]}");
            //    }
            //}

            //Задача 2
            //int imax = 0;
            //int imin = 0;
            //int[] a = new int[20];
            //Random r = new Random();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = r.Next(0,100);
            //    Console.WriteLine();
            //    if (a[imin] > a[i])
            //    {
            //        imin = i;
            //    }
            //    if (a[imax] < a[i])
            //    {
            //        imax = i;
            //    }
            //}
            //int x = a[imin];
            //a[imin] = a[imax];
            //a[imax] = x;
            //Console.WriteLine();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}

            //Задача 3
            //double[] array = new double[31];
            //Random rand = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = 60 + 5 * rand.NextDouble();
            //    Console.WriteLine($"array[{i}]={array[i]:f2}");
            //}
            //double sum = 0;
            //for (byte i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine($"Среднее значения курса валюты= {(double)sum / array.Length}");
            //double min = array[0];
            //byte indexMin = 0;
            //double max = array[0];
            //byte indexMax = 0;
            //for (byte i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //        indexMin = i;
            //    }
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //        indexMax = i;
            //    }

            //}
            //Console.WriteLine($"Самый низкий курс валюты= {min:f2}\t Дата:{indexMin}\nСамый высокий курс валюты= {max:f2}\t Дата:{indexMax}");
            //Console.ReadKey();
            //int[] mass = { -5, 1, 9, 0, 4, -4, 3 };
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int p = mass[i];
            //            array[i] = array[j];
            //            array[j] = p;
            //        }
            //    }
            //}

            //Array.Sort(array);
            //foreach (int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
            //Console.WriteLine();
            //Array.Reverse(array);
            //foreach (int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
            Console.ReadKey();
        }
    }
}
