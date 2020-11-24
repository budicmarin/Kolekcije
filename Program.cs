using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;
namespace Kolekcije
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            // Dodajemo elemente u kolekciju
            al.Add(4);
            al.Add("C# i .NET");
al.Insert(1, "Programiranje");
            Console.WriteLine("--Elementi kolekcije napočetku-");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            // Uklanjamo elemente iz kolekcije
            if (al.Contains(4))
            {
                al.Remove(4);
            }
            int pozicija = al.IndexOf("Programiranje");
            if (pozicija >= 0)
            {
                al.RemoveAt(pozicija);
            }
            Console.WriteLine("\n-- Elementi kolekcije nazavršetku:");

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.ReadKey();
        }
    }
}
