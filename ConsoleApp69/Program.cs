using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    enum Markak { BMW, Audi, Volkswagen, Skoda, Suzuki}
    enum Uzemanyagok { Benzin, Dizel, Elektromos, Hibrid}
    class Auto
    {
        public int GyartasiEv { get; set; }
        public int Id { get; set; }
        public int Kor => DateTime.Now.Year - GyartasiEv;
        public Markak Marka { get; set; }
        public string Rendszam { get; set; }
        public bool UjRendszam => Rendszam.Length != 7;
        public Uzemanyagok Uzemanyag { get; set; }

        public override string ToString()
        {
            return $"Gyartasi év: {GyartasiEv} {Id} {Kor} {Marka} {Rendszam} {UjRendszam} {Uzemanyag}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>()
            {
                new Auto()
                {
                    Id=1,
                    GyartasiEv=2020,
                    Marka=Markak.BMW,
                    Rendszam="ABC-123",
                    Uzemanyag=Uzemanyagok.Dizel
                },
                new Auto()
                {
                    Id=2,
                    GyartasiEv=2010,
                    Marka=Markak.Audi,
                    Rendszam="AAAA-123",
                    Uzemanyag=Uzemanyagok.Elektromos
                },
                new Auto()
                {
                    Id=3,
                    GyartasiEv=2008,
                    Marka=Markak.Suzuki,
                    Rendszam="AAB-123",
                    Uzemanyag=Uzemanyagok.Benzin
                },
                new Auto()
                {
                    Id=4,
                    Marka=Markak.Volkswagen,
                    GyartasiEv=2004,
                    Rendszam="BOSS-111",
                    Uzemanyag=Uzemanyagok.Dizel
                }
            };

            // első autó
            Auto elso= autok.First();
            Console.WriteLine(elso);

            // első új rendszámos autó
            Auto ujrendszamos= autok.Where(x => x.UjRendszam == true).First();
            Console.WriteLine(ujrendszamos);

            // első elektromos autó
            Auto elektromosautok = autok.Where(x => x.Uzemanyag == Uzemanyagok.Elektromos).First();
            Console.WriteLine(elektromosautok);
            // utolsó autó
            Auto utolso = autok.Last();
            Console.WriteLine(utolso);
            // utolsó Audi
            Auto ucsoaudi = autok.Where(x => x.Marka == Markak.Audi).Last();
            Console.WriteLine(ucsoaudi);

            // hány évesek átlagosan az autók
            double atlag = autok.Average(x=>x.Kor);
            Console.WriteLine(atlag);

            // mennyi a idős a legidősebb autó
            int max = autok.Max(x => x.Kor);
            Console.WriteLine(max);

            // Mikor gyártották a legidősebb autót
            int maxGyartsiEV = autok.Min(x => x.GyartasiEv);
            Console.WriteLine(maxGyartsiEV);

            // Írasd ki az összes új rendszámos autót
            autok.Where(x => x.UjRendszam == true)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Írasd ki az összes Benzines autót
            autok.Where(x=>x.Uzemanyag==Uzemanyagok.Benzin)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Írasd ki az összes BMW - t, ami Benzines.
            autok.Where(x => x.Marka == Markak.BMW && x.Uzemanyag == Uzemanyagok.Benzin)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Írasd ki az összes 2007 - nél újabb modellt

            // Melyik az első autó, amely 5 évesnél idősebb?

            // Hány elektromos autó van a listában?

            // Létezik - e a listában olyan autó, amelynek a gyártási éve 2010 előtti ?

            // Írd ki a 2015 után gyártott autókat rendszám szerint rendezve!

            // Az utolsó benzines autó a listában?

            // Hány új rendszámos autó van a listában ?

            // Az 5 legfiatalabb autó a listából(kor szerint növekvő sorrendben)!

            // Írd ki az összes autót, amely 2000 és 2010 között készült(gyártási év szerint rendezve)!

            // Hány olyan autó van, amely nem benzines?

            // Van - e a listában olyan autó, amelynek rendszáma "AAAA-123" ?

            // Hány autó készült 2020 után ?

            // Az összes autó, amelynek a rendszámában van a "123" szöveg.

            // Írd ki az összes autót, amelyik Audi vagy BMW márkájú!

            // Létezik - e olyan autó, amely pontosan 3 éves ?

            // Hány autó készült 2000 előtt ?

            // Hány olyan autó van, amelynek a rendszáma "B" betűvel kezdődik?

            // Melyik az első olyan autó, amelynek a gyártási éve páros szám?

            // Az autók száma, amelynek a gyártási éve páratlan szám!



            Console.ReadKey();
        }
    }
}
