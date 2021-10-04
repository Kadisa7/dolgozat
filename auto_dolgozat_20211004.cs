using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok_dolgozat_20211004
{
    class Program
    {
        enum Markak
        {
            mercedes,
            bugatti,
            suzuki,
            alfaromeo,
            volga,
        }
        public static string Betuk(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        public static string Szamok(int length)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        public static Random rnd = new Random();


        class autok
        {
            double Atlagfogy;
            int Tank;
            int Aktuzem;
            bool Matrica;
            string Rendszam;

            public double Atlagfogy
            {
                get => atlagfogy; 
                set => value = rnd.NextDouble() * (3.0 - 20.0) + 3.0;

            }
            public int Tank
            {
                get => tank;
                set => value = rnd.Next(20, 100);
            }
            public int Aktuzem
            {
                get => aktuzem;
                set => value = rnd.Next(0, 100);
            }
            public bool Matrica
            {
                get => matrica;
                set
                {
                    int valami = rnd.Next(0, 100);
                    if (valami % 2 == 0) Matrica = true;
                    else Matrica = false;
                }
            }
            public string Rendszam
            {
                get => rendszam;
                set
                {
                    value = Betuk(3);
                    value += Szamok(3);
                }
            }
            public Markak markak
            {
                get;
                set;
            }            
        }
        static List<autok> Auto = new List<autok>();
        static void Main(string[] args)
        {
            KiIr();
            Console.ReadKey();
        }

        private static void KiIr()
        {
            foreach (var mittomen in Auto)
            {
                Console.WriteLine(mittomen.Atlagfogy + " " + mittomen.Tank + " " + mittomen.Aktuzem + " " + mittomen.Matrica + " " + mittomen.Rendszam );
            }
        }
       
    }
}
