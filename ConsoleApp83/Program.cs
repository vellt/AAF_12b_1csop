using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    enum Tipusok { Viz, Tuz, Noveny, Elektromos};
    class Pokemon
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Szint { get; set; }
        public int TamadoEro { get; set; }
        public bool Tapasztalt => Szint > 10 == true;
        public Tipusok Tipus { get; set; }
        public int Vedekezoero { get; set; }

        public override string ToString()
        {
            return $"{Id} {Nev} {Szint} {TamadoEro} {Tapasztalt} {Tipus} {Vedekezoero}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonok = new List<Pokemon>
            {
               new Pokemon()
               {
                   Id=1,
                   Nev="Lapras",
                   Szint=25,
                   Vedekezoero=18,
                   Tipus=Tipusok.Elektromos,
                   TamadoEro=29,
               },
               // többi pokémon..
            };

            // Számold meg mennyi tapasztalt tűz típusú Pokémonod van.
            int ennyivan = pokemonok.Where(x => x.Tapasztalt == true && x.Tipus == Tipusok.Tuz).Count();
            Console.WriteLine(ennyivan);
            
            // Átlagosan mennyi a támadóereje Pokémonjaidnak?
            double atlagero = pokemonok.Average(x => x.TamadoEro);
            Console.WriteLine(Math.Round(atlagero, 2)); // vagy így kerekítünk 2 tizedesre
            Console.WriteLine($"{atlagero:0.00}"); // vagy így
            
            // Van olyan Pokémonod, amelynek a védekező és támadóereje több 45-nél?
            bool vane = pokemonok.Exists(x => x.Vedekezoero > 45 && x.TamadoEro > 45);
            Console.WriteLine(vane? "van":"nincs");
            
            // Listázd azon elektromos Pokémonjaidat, melyek támadóereje több 100-nál.
            pokemonok.Where(x => x.TamadoEro > 100 && x.Tipus == Tipusok.Elektromos)
                .ToList().ForEach(x => Console.WriteLine(x));
            
            // Mennyi tapasztalt Pokémonod van?
            int ennyi = pokemonok.Where(x => x.Tapasztalt == true).Count();
            Console.WriteLine(ennyi);
            
            // Írasd ki pokémonjaidat színjük szerint növekvősorrendbe rendezve.
            pokemonok.OrderBy(x=>x.Szint)
                .ToList().ForEach(x => Console.WriteLine(x));
            
            // Add össze Pokémonjaid összerejét.
            int osszero=pokemonok.Sum(x => x.TamadoEro);
            Console.WriteLine(osszero);
            
            // Listázd ki az első 3 legnagyobb támadóerejű Pokémonodat.
            pokemonok.OrderByDescending(x=>x.TamadoEro).Take(3)
                .ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
