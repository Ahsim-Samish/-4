using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*{
                //Задача 1
                int[] mas = new int[22];
                int a = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write($"mas[{i}]=");
                    mas[i] = Convert.ToInt32(Console.ReadLine());
                    a += mas[i];
                }
                a = a / mas.Length;
                Console.WriteLine($"Среднее количество осадков - {a}");
                for (int i = 0; i < mas.Length; i++)
                {
                    if ((i + 1) / 10 == 0)
                        Console.WriteLine($"Отклонение от среднего количества осадков для 200{i + 1} года - {Math.Abs(a - mas[i])}");
                    else
                        Console.WriteLine($"Отклонение от среднего количества осадков для 20{i + 1} года - {Math.Abs(a - mas[i])}");
                }
            }*/
            /*{
                //Задача 2
                int[] mas = new int[10];
                int a=0,i=0,o = 0;
                do
                {
                    Console.Write($"mas[{i}]=");
                    mas[i] = Convert.ToInt32(Console.ReadLine());
                    o = mas[i];
                    i++;
                } 
                while (o>=0);
                a += mas[i];
                for (i=i; i < mas.Length; i++)
                {
                    Console.Write($"mas[{i}]=");
                    mas[i] = Convert.ToInt32(Console.ReadLine());
                    a += mas[i];
                }
                Console.WriteLine($"a={a}");

            }*/
            /*{
                int[] omas = new int[6];
                Random random = new Random();
                int max = omas[0];
                int indexmax = 0;
                int minus = omas[0];
                int indexmin = 0;
                int i = 0;
                int p = 0;
                for (i = 0; i < omas.Length; i++)
                {
                    omas[i] = random.Next(-10, 10);
                    Console.WriteLine(omas[i]);
                }
                for (i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                        indexmax = i;
                    }
                }
                bool l;
                do
                {
                    if (omas[p] < 0)
                    {
                        minus = omas[p];
                        indexmin = p;
                    }
                    p++;
                    if (p < omas.Length)
                    {
                        l = true;
                    }
                    else
                    {
                        l = false;
                    }
                }
                while (minus >= 0 & l==true);
                var b = omas[indexmax];
                omas[indexmax] = omas[indexmin];
                omas[indexmin] = b;
                for (int k = 0; k < omas.Length; k++) 
                {
                    Console.Write($"{omas[k]} ");
                }
            }*/
            /*{
                int[] omas = new int[31];
                Random random = new Random();
                int max = omas[0];
                int indexmax = 0;
                int min = omas[0];
                int indexmin = 0;
                int a = 0;
                for (int i = 0; i < omas.Length; i++)
                {
                    omas[i] = random.Next(60, 160);
                    Console.WriteLine(omas[i]);
                    a += omas[i];
                }
                a = a / 31;
                for (int i = 0; i < omas.Length; i++)
                {
                    if (omas[i] > max)
                    {
                        max = omas[i];
                        indexmax = i;
                    }
                    if (omas[i] < min)
                    {
                        min = omas[i];
                        indexmin = i;
                    }
                }
                Console.WriteLine($"Среднее значение КВ - {a}");
                Console.WriteLine($"Максимальное значение КВ - {max}");
                Console.WriteLine($"День с максимальным значением КВ - {indexmax}");
                Console.WriteLine($"Минимальное значение КВ - {min}");
                Console.WriteLine($"День с минимальным значением КВ - {indexmin}");
            }*/

        }
    }
}
