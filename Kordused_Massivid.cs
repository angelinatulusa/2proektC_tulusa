﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2proektC_tulusa
{
    class Kordused_Massivid
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 50);
            int popitki = 5;
            while (popitki<0)
            {
                Console.WriteLine("kakoe cislo?");
                int a = Console.ReadLine();
                if (a==n)
                {
                    Console.Write("vi ugadali, pozdravlau!");
                    break;
                }
                else if (a!=n)
                {
                    Console.Write("poprobui ese");
                    popitki -= 1;
                }
            }



            Console.ReadKey();

            //таблица умножения
            /*int y = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    y = i * j;
                    Console.Write($"{y,4}");
                }
                Console.Write("\n");
            }
            Console.ReadKey();*/

            //купи слона
            /*string a = " ";
            while (true)
            {
                Console.WriteLine("kupi slona");
                a = Console.ReadLine();
                if (a.ToLower() == "slon") 
                {
                    Console.Write("slon tvoi");
                    break;
                }
                else
                {

                }
            }*/
            //Console.ReadKey();


            //Console.OutputEncoding = Encoding.UTF8; чтобы программа понимала на русском
            /*int[] arvud = new int[5];
            int a=0;
            int k=0;
            do
            {
                try
                {
                    Console.WriteLine("vvedi cislo: ");
                    a = int.Parse(Console.ReadLine());
                    arvud[k] = a;
                    k++;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
                
            } while (k<5);
            int summa = 0;
            int korr = 1;//умножение
            int arit = 0;
            foreach (int arv in arvud)
            {
                summa += arv;
                korr *= arv;
                arit = summa / arvud.Length;
            }
            Console.WriteLine($"summa={summa}, korrutis={korr}, aritmeetiline keskmine={arit,4}");

            Console.ReadKey();*/
            /*Random rnd = new Random();
            int N = rnd.Next(1, 50);
            int M = rnd.Next(1, 50);
            Console.WriteLine($"N={N}");
            Console.WriteLine($"M={M}");
            if (N>M)
            {
                int abi = N;
                N = M;
                M = abi;
            }
            int[] N_M = new int[M - N + 1];
            int j = 0;
            for (int i = N; i < M; i++)
            {
                N_M[j]= i;
                j++;
            }
            foreach (var n_m in N_M)
            {
                Console.Write($"{n_m^2,5}");
            }

            Console.WriteLine();

            char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' }; //char - значит что в массиве будут значения только по одной букве
            Console.WriteLine($"Esimene taht on {Tahed[0]}");

            foreach (char taht in Tahed)
            {
                Console.Write($"{taht,2}");//2 - добaвляет один пробел перед буквой 
            }
            Console.WriteLine();

            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(5, 500);
            }
            foreach (int arv in arvud)
            {
                Console.Write($"{arv,4}");
            }
            Console.WriteLine();

            int[,] tabel = new int[20,10];
            for (int i = 1; i < 21; i++)//ili (int i = 0; i < 20; i++)
            {
                Console.Write($"rida {i}: ");
                for (int l = 1; l < 11; l++)//ili (int j = 0; j < 10; j++)
                {
                    Console.Write($"koht{j} ");//ili Console.Write($"rida{i+1} koht{j+1}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();*/
        }
    }
}
