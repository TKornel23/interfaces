using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class EmberiJatekos : IOkosTippelo
    {
        public void JatekIndul(int alsoHatar, int felsoHatar)
        {
            Console.WriteLine($"-> Jatek indul az alábbi határok között: [{alsoHatar},{felsoHatar}]");
        }

        public void Kisebb()
        {
            Console.WriteLine("-> Az előző tippnél kisebb a keresett szám");
        }

        public int KovetkezoTipp()
        {
            Console.Write("-> Add meg a következő tippet: ");
            int tipp = int.Parse(Console.ReadLine());
            return tipp;
        }

        public void Nagyobb()
        {
            Console.WriteLine("-> Az előző tippnél nagyobb a keresett szám");
        }

        public void Nyert()
        {
            Console.WriteLine("-> Nyertél");
        }

        public void Veszített()
        {
            Console.WriteLine("-> Veszítettél");
        }
    }
}
