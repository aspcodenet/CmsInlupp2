using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;

namespace CmsInlupp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var allProducts = ReadProductsFromFile();

            while (true)
            {
                Console.WriteLine("1. Ny kund");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine("Mata in nåt:");
                var sel = Console.ReadLine();
                if (sel == "0")
                    break;
                if (sel == "1")
                    NyKund();
            }
        }

        private static List<Product> ReadProductsFromFile()
        {
            var players = new List<Product>();

            using (var sr =
                File.OpenText(@"..\..\..\ProduktDatabasen.txt"))

            {
                while (true)
                {
                    var line = sr.ReadLine();
                    if (line == null) break;
                    //Bananer,300,12,typ
                    string[] split = line.Split(',');
                    var p = new Product();
                    p.Name = split[0];
                    p.ProductId = Convert.ToInt32(split[1]);
                    p.Price = Convert.ToDecimal(split[2]);
                    p.Typ = split[3];
                    players.Add(p);
                }

            }

            return players;
        }
        private static void NyKund()
        {
            throw new NotImplementedException();
        }
    }
}
