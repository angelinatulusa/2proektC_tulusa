using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2proektC_tulusa
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Console.WriteLine("Vajuta mingi klahv!!");
                k = Console.ReadKey();
                Console.Beep();
            } while (k.Key!=ConsoleKey.Escape);
            Environment.Exit(0);

            //классная работа, задание про билеты
            /*string pilet = "tasuta";
            double hind = 10;
            Console.WriteLine("Mis on sinu nimi?");
            string eesnimi = Console.ReadLine();
            Console.Write("Tere tulemast! {0}", eesnimi);
            if (eesnimi.ToLower()=="juku")
            {
                Console.WriteLine("\nTule külla! Kas lähme kinno?");
                string vastus = Console.ReadLine();
                if (vastus.ToUpper() == "JAH" || vastus.ToUpper() == "YES" || vastus.ToUpper() == "ДА") 
                {
                    Console.WriteLine("Kui vana sa oled?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 108)
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus < 6 || vanus>65)
                    {
                        hind -= hind * 1;
                        pilet = "tasuta";
                    }
                    else if (vanus>=6 && vanus<14)
                    {
                        hind -= hind * 0.3;
                        pilet = "lastepilet";
                    }
                    else if (vanus>=14 && vanus<18)
                    {
                        hind -= hind * 0.1;
                        pilet = "taispilet";
                    }
                    else if (true)
                    {
                        hind -= hind * 0.2;
                        pilet = "soduspilet";
                    }
                    char[] tahed = eesnimi.ToCharArray();
                    int i = 0;
                    eesnimi = "";
                    foreach (var t in tahed)
                    {
                        if (i==0)
                        {
                            eesnimi += t.ToString().ToUpper();
                        }
                        else
                        {
                            eesnimi += t.ToString().ToLower();
                        }
                        i += 1;
                    }
                    Console.WriteLine("{0}, sul on {1} vaja maksta {2}", eesnimi, pilet, hind);
                }
                else
                {
                    Console.WriteLine("Kui ei taha siis ei taha");
                }
            }
            else
            {
                Console.WriteLine("\nMind täna kodus pole!");
            }
            Console.ReadKey();*/

            //задание про соседей
            /*Console.WriteLine("Kakoe tvoe imja?");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Kakoe imja tvoego druga?");
            string nimi2 = Console.ReadLine();
            if (nimi1.ToLower() == "artem" && nimi2.ToLower() == "timofei" || nimi1.ToLower() == "timofei" && nimi2.ToLower() == "artem") 
            {
                Console.WriteLine("{0}, vi s {1} sidite vmedte", nimi1, nimi2);
            }
            else if (nimi1.ToLower() == "german" && nimi2.ToLower() == "kevin" || nimi1.ToLower() == "german" && nimi2.ToLower() == "kevin")
            {
                Console.WriteLine("{0}, vi s {1} sidite vmeste", nimi1, nimi2);
            }
            else
            {
                Console.WriteLine("{0}, vi ne sosedi s {1}", nimi1, nimi2);
            }
            Console.ReadKey();*/

            //задание про температуру
            /*Console.WriteLine("Kakaja u vas temperatura v komnate?");
            int temp = int.Parse(Console.ReadLine());
            if (temp == 18)
            {
                Console.WriteLine("U vas v komnate rekomenduemaja temperatura");
            }
            else if (temp < 18)
            {
                Console.WriteLine("U vas sliskom holodno, vklu4ite otoplenie");
            }
            else if (temp > 18) 
            {
                Console.WriteLine("U vas sliskom zarko, ohladite kvartiru");
            }
            Console.ReadKey();*/

            //задание про 30%
            /*Console.WriteLine("Kakaja stoimost tovara so skidkoi?");
            double cena = double.Parse(Console.ReadLine());
            if (cena<=0)
            {
                Console.WriteLine("Takoi stoimosti ne mozet bit");
            }
            else
            {
                cena = cena / 0.3;
                Console.WriteLine($"Nacalnaja stoimost = {cena}");
            }
            Console.ReadKey();*/

            //задание про ремонт
            /*int S = 0;
            int cenaPola = 0;
            Console.WriteLine("Kakaja dlina pervoi steni?");
            int storonaA = int.Parse(Console.ReadLine());
            Console.WriteLine("Kakaja dlina vtoroi steni?");
            int storonaB = int.Parse(Console.ReadLine());
            S = storonaA * storonaB;
            Console.WriteLine($"Plosad pola = {S} kvadratnih metrov");
            Console.WriteLine("Hotite sdelat remont?");
            string remont = Console.ReadLine();
            if (remont.ToLower() == "jah" || remont.ToLower() == "yes" || remont.ToLower() == "da")
            {
                Console.WriteLine("Skolko evro stoit odin kvadratnii metr?");
                int metr = int.Parse(Console.ReadLine());
                cenaPola = S * metr;
                Console.WriteLine($"Zamena pola budet stoit {cenaPola} evro");
            }
            else
            {
                Console.WriteLine("Nu kak hoces!");
            }
            Console.ReadKey();*/

        }
    }
}
