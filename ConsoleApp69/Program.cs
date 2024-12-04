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
        public int Kor => DateTime.Now.Year - GyartasiEv; // csak Get értéke van a nyilacska miatt!
        public Markak Marka { get; set; }
        public string Rendszam { get; set; }
        public bool UjRendszam => Rendszam.Length != 7; // csak get értéke van a nyilacska miatt!
        public Uzemanyagok Uzemanyag { get; set; }

        // (osztályon belül) alt+enter --> generate overrides--> kiválasztod a ToSting overrideot, és felülírod az alapműködést
        // hogy minden értéke látszódjon az osztálynak
        public override string ToString()
        {
            return $"Gyartasi év: {GyartasiEv} {Id} {Kor} {Marka} {Rendszam} {UjRendszam} {Uzemanyag}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // lista létrehozása és feltöltése -------------------------------------------------------------
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

            // lekérdezések ---------------------------------------------------------------------

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
            autok.Where(x => x.GyartasiEv > 2007).ToList().ForEach(x => Console.WriteLine(x));

            // Melyik az első autó, amely 5 évesnél idősebb?
            Auto elsoOt = autok.Where(x => x.Kor > 5).First();
            Console.WriteLine(elsoOt);

            // Hány elektromos autó van a listában?
            int db = autok.Where(x => x.Uzemanyag == Uzemanyagok.Elektromos).Count();
            Console.WriteLine(db);

            // Létezik - e a listában olyan autó, amelynek a gyártási éve 2010 előtti ?
            bool letezik= autok.Exists(x => x.GyartasiEv < 2010);
            Console.WriteLine(letezik?"igen":"nem");

            // Írd ki a 2015 után gyártott autókat rendszám szerint rendezve!
            autok.Where(x => x.GyartasiEv > 2015).OrderBy(x => x.Rendszam)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Az utolsó benzines autó a listában?
            Auto utolsobenzines= autok.Where(x => x.Uzemanyag == Uzemanyagok.Benzin).Last();
            Console.WriteLine(utolsobenzines);

            // Hány új rendszámos autó van a listában ?
            int uj = autok.Where(x => x.UjRendszam == true).Count();
            Console.WriteLine(uj);

            // Az 5 legfiatalabb autó a listából(kor szerint növekvő sorrendben)!
            autok.OrderBy(x => x.Kor).Take(5)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Írd ki az összes autót, amely 2000 és 2010 között készült(gyártási év szerint rendezve)!
            autok.Where(x => x.GyartasiEv > 2000 && x.GyartasiEv < 2010)
                .OrderBy(x=>x.GyartasiEv)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Hány olyan autó van, amely nem benzines?
            int nembenzines=autok.Where(x => x.Uzemanyag != Uzemanyagok.Benzin).Count();
            Console.WriteLine(nembenzines);

            // Van - e a listában olyan autó, amelynek rendszáma "AAAA-123" ?
            bool rendszam=autok.Exists(x => x.Rendszam=="AAAA-123");
            Console.WriteLine(rendszam?"van a listában":"nincs a listában");

            // Hány autó készült 2020 után ?
             int db2 = autok.Where(x => x.GyartasiEv > 2020).Count();
            Console.WriteLine(db2);

            // Az összes autó, amelynek a rendszámában van a "123" szöveg.
            autok.Where(x => x.Rendszam.Contains("123"))
                .ToList().ForEach(x => Console.WriteLine(x));

            // Írd ki az összes autót, amelyik Audi vagy BMW márkájú!
            autok.Where(x => x.Marka == Markak.Audi || x.Marka == Markak.BMW)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Létezik - e olyan autó, amely pontosan 3 éves ?
            bool haromeves = autok.Exists(x => x.Kor == 3);
            Console.WriteLine(haromeves? "igen" : "nem");

            // Hány autó készült 2000 előtt ?
            int autok2000elottrol= autok.Where(x => x.GyartasiEv < 2000).Count();
            Console.WriteLine(autok2000elottrol);

            // Hány olyan autó van, amelynek a rendszáma "B" betűvel kezdődik?
            int bvelkezdodok= autok.Where(x => x.Rendszam.StartsWith("B")).Count();
            Console.WriteLine(bvelkezdodok);

            // Melyik az első olyan autó, amelynek a gyártási éve páros szám?
            Auto elsoParos = autok.Where(x => x.GyartasiEv % 2 == 0).First();
            Console.WriteLine(elsoParos);

            // Az autók száma, amelynek a gyártási éve páratlan szám!
            int autokszama = autok.Where(x => x.GyartasiEv % 2 != 0).Count();
            Console.WriteLine(autokszama);

            // plusz gyakorlók! --------------------------------------------------------------------

            // átlagoljuk a gyátási év szerint azon autókat, 
            // amelynek gyártási éve legalább 2002
            double atlag2=autok.Where(x => x.GyartasiEv >= 2002).Average(x => x.GyartasiEv);
            Console.WriteLine(atlag2);

            // Listázd azon autókat gyártási év szerint növekvő sorrendben
            // melyeknek a rendszámában szerepel a 65-ös szám
            autok.Where(x => x.Rendszam.Contains("65")).OrderBy(x => x.GyartasiEv)
                .ToList().ForEach(x => Console.WriteLine(x));

            // Az összes elektromos Audit listázd, rendszám szerint növekvő sorrendben
            autok.Where(x => x.Marka == Markak.Audi && x.Uzemanyag == Uzemanyagok.Elektromos)
                .OrderBy(x => x.Rendszam).ToList().ForEach(x => Console.WriteLine(x));

            // Hány olyan autó van amelynek a rendszáma 3-mal végződik
            int db5 = autok.Where(x => x.Rendszam.EndsWith("3")).Count();
            Console.WriteLine(db5);

            // létezik-e olyan benzines autó, melynek a rendszámában benne van a 4
            bool gf = autok.Exists(x => x.Uzemanyag == Uzemanyagok.Benzin && x.Rendszam.Contains("4"));
            Console.WriteLine(gf ?"van":"nincs");

            // Hány benzines autó készült 1900 előtt
            int autok1900elott= autok.Where(x => x.Uzemanyag == Uzemanyagok.Benzin && x.GyartasiEv > 1900).Count();
            Console.WriteLine(autok1900elott);

            // add össze azon BMW-k gyártási évét, melyek 2000 és 2010 között gyártottak
            int ossz = autok.Where(x => x.Marka == Markak.BMW && x.GyartasiEv > 2000 && x.GyartasiEv < 2010)
                .Sum(x=> x.GyartasiEv);
            Console.WriteLine(ossz);

            // Listázd ki az első 4 olyan autót, melynek új rendszáma van
            autok.Where(x => x.UjRendszam).Take(4)
                .ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
