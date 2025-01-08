using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp97
{
    class Program
    {
        static List<string> tanulok = new List<string>();
        static List<string> kerdesek = new List<string>();
        static void Main(string[] args)
        {
            tanulok = File.ReadAllLines("tanulok.csv").ToList();
            kerdesek = File.ReadAllLines("kerdesek.csv").ToList();
            Random r = new Random();
            foreach (var tanulo in tanulok)
            {
                Console.WriteLine(tanulo);
                List<string> tanuloKerdesei = new List<string>();
                while (tanuloKerdesei.Count()!=5)
                {
                    int index = r.Next(kerdesek.Count());
                    string kerdes = kerdesek[index];
                    if (tanuloKerdesei.Contains(kerdes) == false)
                    {
                        tanuloKerdesei.Add(kerdes);
                    }
                }
                foreach (var kerdes in tanuloKerdesei)
                {
                    Console.WriteLine($"\t {kerdes}");
                }
            }
            Console.ReadKey();
        }
    }
}
