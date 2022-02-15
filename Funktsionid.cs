using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2proektC_tulusa
{
    public class Funktsionid
    {

        public static int Korrutamine(int arv1, int arv2)
        {
            int k = arv1 * arv2;
            return k;
        }
        public static int[] Massiv(int n, bool tf)
        {
            Random rnd = new Random();
            int[] arvud = new int[n];
            for (int i = 0; i < n; i++)
            {
                arvud[i] = int.Parse(Console.ReadLine());
                if (tf)
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    arvud[i] = rnd.Next(5, 500);
                }
            }
            return arvud;

        }
        public static void Massiv_ekraanile(Array massiiv)
        {
            foreach (var a in massiiv)
            {
                Console.WriteLine($"{a,4}");
            }
        }
        public static int Srednee(int arv1, int arv2)
        {
            int[] arvud = new int[2];
            int summa = 0;
            int arit = 0;
            summa = arv1 + arv2;
            arit = summa / 2;
            return arit;
        }
        public static string Nurr(int arv1, int arv2, string t)
        {
            int a = 0;
            if (t == "+")
            {
                a = arv1 + arv2;
                for (int i = 0; i < a; i++)
                {
                    Console.Write("nurr ");
                }
            }
            else if (t == "*") 
            {
                a = arv1 * arv2;
                for (int i = 0; i < a; i++)
                {
                    Console.Write("nurr ");
                }
            }
            return t;
        }
        public static int Star(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("*");
            }
            return a;
        }

    }
}
