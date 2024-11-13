using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    enum KedvencHelyek { RegiKastely, Temeto, ElhagyatottHaz, Erdo, Alagut};
    enum SzellemFajtak { Kisertet, Kopogoszellem, Arnyek, Demonszellem, Koborlelek};
    class Szellem
    {
        public bool Artalmatlan => Fajta == SzellemFajtak.Koborlelek || Fajta == SzellemFajtak.Kisertet;
        public SzellemFajtak Fajta { get; set; }
        public bool Felelmetes => Fajta == SzellemFajtak.Kopogoszellem || Fajta == SzellemFajtak.Arnyek;
        public DateTime HalalIdopont { get; set; }
        public int Id { get; set; }
        public KedvencHelyek KedvencHely { get; set; }
        public string Nev { get; set; }
        public bool Veszelyes => Fajta == SzellemFajtak.Demonszellem;

        public override string ToString()
        {
            return $"{Artalmatlan} {Fajta} {Felelmetes} {HalalIdopont} {Id} {KedvencHely} {Nev} {Veszelyes}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Szellem> szellemek = new List<Szellem>
{
    new Szellem { Id = 1, Nev = "Mária", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1800, 5, 12), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 2, Nev = "John", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1850, 7, 23), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 3, Nev = "Anna", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1900, 3, 15), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 4, Nev = "Robert", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(1920, 10, 2), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 5, Nev = "Károly", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1865, 4, 8), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 6, Nev = "Isabella", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1770, 9, 1), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 7, Nev = "Thomas", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1801, 11, 30), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 8, Nev = "Lily", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1990, 6, 19), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 9, Nev = "Henry", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2000, 2, 29), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 10, Nev = "Sara", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1960, 12, 15), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 11, Nev = "Benedek", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1902, 8, 10), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 12, Nev = "Jasper", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1915, 3, 21), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 13, Nev = "Ophelia", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1930, 11, 14), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 14, Nev = "Rudolf", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2005, 7, 30), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 15, Nev = "Beatrix", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1700, 6, 6), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 16, Nev = "Arthur", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1935, 9, 8), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 17, Nev = "Lucy", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1988, 4, 10), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 18, Nev = "Edmund", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1945, 5, 17), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 19, Nev = "Frederick", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2020, 12, 25), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 20, Nev = "Zsófia", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1689, 1, 3), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 21, Nev = "Helena", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1745, 8, 4), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 22, Nev = "Marcus", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1985, 11, 2), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 23, Nev = "Nina", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1955, 9, 11), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 24, Nev = "Timothy", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(1995, 2, 6), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 25, Nev = "András", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1880, 3, 15), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 26, Nev = "Eva", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1800, 6, 20), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 27, Nev = "Oscar", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1923, 1, 22), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 28, Nev = "Florence", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1975, 7, 7), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 29, Nev = "Gerald", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2001, 5, 12), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 30, Nev = "Matilda", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1845, 9, 30), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 31, Nev = "Paul", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1982, 12, 18), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 32, Nev = "Vera", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1765, 10, 9), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 33, Nev = "Catherine", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1820, 3, 19), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 34, Nev = "Viktor", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2010, 1, 5), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 35, Nev = "Bianca", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1705, 11, 21), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 36, Nev = "Lionel", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1901, 2, 1), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 37, Nev = "Diana", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1970, 7, 3), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 38, Nev = "Gustav", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1915, 5, 5), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 39, Nev = "Joanna", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2023, 6, 13), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 40, Nev = "Stefan", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1930, 3, 29), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 41, Nev = "Betty", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1999, 9, 2), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 42, Nev = "Alfred", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1860, 10, 22), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 43, Nev = "Victoria", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1918, 4, 17), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 44, Nev = "Felix", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2007, 5, 29), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 45, Nev = "Rosa", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1680, 12, 6), KedvencHely = KedvencHelyek.RegiKastely },
    new Szellem { Id = 46, Nev = "Mark", Fajta = SzellemFajtak.Kisertet, HalalIdopont = new DateTime(1972, 8, 8), KedvencHely = KedvencHelyek.Temeto },
    new Szellem { Id = 47, Nev = "Erika", Fajta = SzellemFajtak.Kopogoszellem, HalalIdopont = new DateTime(1833, 3, 12), KedvencHely = KedvencHelyek.ElhagyatottHaz },
    new Szellem { Id = 48, Nev = "Helga", Fajta = SzellemFajtak.Arnyek, HalalIdopont = new DateTime(1895, 7, 15), KedvencHely = KedvencHelyek.Erdo },
    new Szellem { Id = 49, Nev = "Martin", Fajta = SzellemFajtak.Demonszellem, HalalIdopont = new DateTime(2015, 11, 9), KedvencHely = KedvencHelyek.Alagut },
    new Szellem { Id = 50, Nev = "Alice", Fajta = SzellemFajtak.Koborlelek, HalalIdopont = new DateTime(1940, 9, 1), KedvencHely = KedvencHelyek.RegiKastely }
};

            //az összes szellem listázva(foreach)
            szellemek.ForEach(x => Console.WriteLine(x));
            //elhalálozás szerint rendezd növekvő sorrendbe(orderBy)
            szellemek.OrderBy(x => x.HalalIdopont).ToList().ForEach(x => Console.WriteLine(x));
            //Az összes olyan szellem aki temetőben kísért(where)
            szellemek.Where(x => x.KedvencHely == KedvencHelyek.Temeto).ToList().ForEach(x => Console.WriteLine(x));
            //van olyan szellem aki régi kastélyban kísért, de ártalmatlan? (Exists)
            bool van = szellemek.Exists(x => x.KedvencHely == KedvencHelyek.RegiKastely && x.Artalmatlan == true);
            Console.WriteLine(van ? "van" : "nincs");

            //az összes szellem darabszáma(count)

            //Az összes veszélyes és félelmetes szellem(where)

            //A legrégebben meghalt szellem(orderBy--> first)

            //Az első szellem ártalmatlan szellem?

            //Állapítsd meg, melyik szellem típus a legritkább a listában(ami a legkevesebb előfordulással rendelkezik), és írd ki a nevét.
            
            //Listázd ki az összes félelmetes szellem nevét és halál időpontját.
            
            //Listázd ki annak az ártalmatlan szellemnek a nevét és halál időpontját, aki a legrégebben halt meg.
            
            //Állapítsd meg, ki az a veszélyes szellem, aki a legutóbb halt meg, és írd ki a nevét.
            
            //Számold ki a temetőben kísértő szellemek átlagos halálozási évét.
            
            //Számold meg, hány szellem kísért az elhagyatott házban, és írd ki a nevüket.
            
            //Listázd ki a legutóbbi 3 halálesetet(legújabb 3 szellem) a nevükkel és halál időpontjukkal.
           
            //Számold ki az összes szellem átlagos halálozási évét.
            
            //Írd ki a legöregebb, erdőben kísértő ártalmatlan szellem nevét és halál időpontját.
            
            //Keresd meg a legfiatalabb szellemet, aki nem veszélyes és nem félelmetes, majd írd ki a nevét és halál időpontját.
            
            //Listázd ki az összes szellem nevét és kedvenc helyét, a neveket ábécé sorrendbe rendezve.
            
            //Szűrd ki azokat a szellemeket, akik 1900 és 1999 között haltak meg, és listázd ki a nevüket és halál időpontjukat.
            
            //Ellenőrizd, hogy a temetőben kizárólag ártalmatlan szellemek kísértenek - e.
            
            //Keresd meg azt a legöregebb szellemet, aki kastélyban kísért, de nem ártalmatlan, és írd ki a nevét és halál időpontját.
            
            //Listázd ki azokat a szellemeket, akik már legalább 50 éve kísértenek.
            
            //Keresd meg a legfiatalabb szellemet, aki félelmetes, de nem veszélyes, majd írd ki a nevét és halál időpontját.
            
            //Listázd ki azokat a szellemeket, akiknek a kedvenc helye kastély vagy temető.
            
            //Listázd ki minden második szellem adatait a listában(azaz az 1., 3., 5., stb.indexű szellemeket).
            Console.ReadKey();
        }
    }
}
