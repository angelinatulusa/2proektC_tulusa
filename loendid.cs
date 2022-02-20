using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2proektC_tulusa
{
    class Loendid
    {
        static void Main(string[] args)
        {
            //1 ülesanne
            List<int> alguses = new List<int>();
            List<int> lopus = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                alguses.Add(int.Parse(Console.ReadLine()));
            }
            int al = alguses[0];
            int an = alguses[alguses.Count - 1];
            alguses.Insert(0, an);
            alguses.Add(al);



            //2 ülessanne
            int[] arvud = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbrid = new List<int>(arvud);
            List<int> paaris = new List<int>();
            List<int> paaritu = new List<int>();
            foreach (int item in numbrid)
            {
                if (item % 2 == 0)
                {
                    paaris.Add(item);
                }
                else
                {
                    paaritu.Add(item);
                }
            }
            foreach (int a in paaris)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            foreach (int b in paaritu)
            {
                Console.WriteLine(b);
            }



            Dictionary<int, string> sportlased = new Dictionary<int, string>(5);
            for (int i = 1; i < 6; i++)
            {
                sportlased.Add(i, Console.ReadLine());
            }
            Console.WriteLine(sportlased[1]);
            sportlased.Remove(4);
            foreach (KeyValuePair<int, string> kv in sportlased)
            {
                Console.WriteLine(kv.Key + ".kohal " + kv.Value);
            }

            LinkedList<int> loetelu = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                loetelu.AddFirst(i);
            }
            for (int i = 1; i < 10; i += 2)
            {
                loetelu.Remove(i);
            }
            foreach (int item in loetelu)
            {
                Console.WriteLine(item);
            }


            List<Inimene> inimesed = new List<Inimene>();
            inimesed.Add(new Inimene() { Nimi = "Madis" });
            inimesed.Add(new Inimene() { Nimi = "Kelli" });

            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi);
            }


            string[] nimed0 = new string[3] { "Mati", "Kati", "Juki" };
            List<string> nimed = new List<string>(nimed0);

            Console.WriteLine("Sisesta nime listisse");
            nimed.Add(Console.ReadLine());
            nimed.Insert(0, "Angelina");
            if (nimed.Contains("Angelina"))
            {
                Console.WriteLine("Seline nimi on olemas" + " ta on {0} kohal", nimed.IndexOf("Angelina"));
            }
            else
            {
                Console.WriteLine("Seline nimi puudub nimikirjas");
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }

            Console.ReadKey();
        }
    }
}
