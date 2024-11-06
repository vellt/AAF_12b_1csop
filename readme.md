```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    enum Italok { Viz, Kola, Narancs, Limonade  }
    class Palack
    {
        public int Id { get; set; }
        public double KiszerelesLiter { get; set; }
        public bool KupakRogzitveVan => PalackozasIdeje.Year >= 2023;
        public DateTime PalackozasIdeje { get; set; }
        public Italok Tartalom { get; set; }
        public bool Visszavalhato => PalackozasIdeje.Year >= 2024;
        public override string ToString()
        {
            return $"{Id} {KiszerelesLiter} {KupakRogzitveVan} {PalackozasIdeje.ToShortDateString()} {Tartalom} {Visszavalhato}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Palack> palackok = new List<Palack>()
            {
                new Palack()
                {
                    Id=1,
                    KiszerelesLiter=1.75,
                    PalackozasIdeje= new DateTime(2024,12,03),
                    Tartalom=Italok.Limonade,
                },
                new Palack()
                {
                    Id=2,
                    KiszerelesLiter=1.0,
                    PalackozasIdeje= new DateTime(2023,12,03),
                    Tartalom=Italok.Narancs,
                },
                new Palack()
                {
                    Id=3,
                    KiszerelesLiter=0.5,
                    PalackozasIdeje= new DateTime(2021,12,03),
                    Tartalom=Italok.Kola,
                },
                new Palack()
                {
                    Id=4,
                    KiszerelesLiter=0.25,
                    PalackozasIdeje= new DateTime(2021,12,03),
                    Tartalom=Italok.Limonade,
                },
            };

            //első palackom
            Console.WriteLine(palackok.First());
            //utolsó palackom
            Console.WriteLine(palackok.Last());
            //hány literesek átlagosan a palackjaim
            Console.WriteLine($"átlaguk: {palackok.Average(x => x.KiszerelesLiter)}");
            //mennyi a legnagyobb palackom kiszerelése
            Console.WriteLine(palackok.Max(x=>x.KiszerelesLiter));
            //mennyi a legkisebb palackom kiszerelése
            Console.WriteLine(palackok.Min(x=>x.KiszerelesLiter));
            //Írasd ki az összes visszaváltható palackot
            palackok.Where(x => x.Visszavalhato == true).ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}

```