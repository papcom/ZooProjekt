﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa några djur och skötare
            Däggdjur lejon = new Däggdjur("Lejon", 5);
            Däggdjur björn = new Däggdjur("Björn", 15);
            Fågel örn = new Fågel("Örn", 10);
            Fågel papegoja = new Fågel("Papegoja", 50);
            Skötare skötare1 = new Skötare("Alice");
            Skötare skötare2 = new Skötare("Bob");

            // Lägg till djur i skötarnas ansvar
            skötare1.LäggTillDjur(lejon);
            skötare1.LäggTillDjur(björn);
            skötare2.LäggTillDjur(örn);
            skötare2.LäggTillDjur(papegoja);

            // Hämta skötarens ansvariga djur
            List<Djur> ansvarigaDjurSkötare1 = skötare1.GetAnsvarigaDjur();
            List<Djur> ansvarigaDjurSkötare2 = skötare2.GetAnsvarigaDjur();

            // Visa informationen
            Console.WriteLine("Skötare 1 - " + skötare1.GetNamn() + ":");
            foreach (Djur djur in ansvarigaDjurSkötare1)
            {
                Console.WriteLine(" - " + djur.GetNamn());
            }

            Console.WriteLine("Skötare 2 - " + skötare2.GetNamn() + ":");
            foreach (Djur djur in ansvarigaDjurSkötare2)
            {
                Console.WriteLine(" - " + djur.GetNamn());
            }
            Console.ReadLine();
        }
    }
}
