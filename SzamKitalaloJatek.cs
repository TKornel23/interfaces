using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class SzamKitalaloJatek
    {
        const int MAX_VERSENYZO = 5;
        ITippelo[] versenyzok;
        int alsoHatar, felsoHatar;
        static Random rnd;
        int cel;
        int versenyzoN
        { 
            get
            {
                int szamolo = 0;
                while (szamolo < versenyzok.Length && versenyzok[szamolo] != null)
                {
                    szamolo++;
                }
                return szamolo;
            }
        }

        public SzamKitalaloJatek(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
            versenyzok = new ITippelo[MAX_VERSENYZO];
        }

        public void VersenyzoFelvetele(ITippelo tippelo)
        {
            versenyzok[versenyzoN] = tippelo;
        }
        public void VersenyIndul()
        {
            rnd = new Random();
            cel = rnd.Next(alsoHatar, felsoHatar + 1);
            Console.WriteLine($"      -> cel: {cel} <-");
            Console.WriteLine("Verseny Indul");
            for (int i = 0; i < versenyzoN; i++)
            {                   
                versenyzok[i].JatekIndul(alsoHatar, felsoHatar);
            }
        }
        

        public bool MindenkiTippel()
        {
            int[] szamolo = new int[versenyzoN];
            int szamlalo = 0;
            bool helper = false;
            for (int i = 0; i < versenyzoN; i++)
            {
                int tipp = versenyzok[i].KovetkezoTipp();
                Console.WriteLine($"{versenyzok[i]} tippje: {tipp}");
                if(tipp == cel)
                {
                    szamlalo++;
                    szamolo[i]++;
                    helper = true;
                }
                else
                {          
                    if (versenyzok[i] is IOkosTippelo)
                    {
                        IOkosTippelo okos = versenyzok[i] as IOkosTippelo; 
                        if(tipp > cel)
                        {
                            okos.Kisebb();
                        }
                        if(tipp < cel)
                        {
                            okos.Nagyobb();
                        }
                    }
                }
            }
            if (helper)
            {
                for (int i = 0; i < versenyzoN; i++)
                {
                    if(szamolo[i] == 1)
                    {
                        versenyzok[i].Nyert();
                    }
                    else
                    {
                        versenyzok[i].Veszített();
                    }
                }
            }
            return szamlalo > 0;
        }

        public void Statisztika(int korokSzama)
        {
            Console.WriteLine();
            if(korokSzama == 0)
            {
                for (int i = 0; i < versenyzoN; i++)
                {
                    if(versenyzok[i] is IStatisztikatSzolgaltat)
                    {
                        IStatisztikatSzolgaltat stat = versenyzok[i] as IStatisztikatSzolgaltat;
                        Console.WriteLine($"{i} játékos: {versenyzok[i]} {stat.HanyszorNyert} nyert és {stat.HanyszorVesztett} vesztett");
                    }
                }
            }
            else
            {
                Jatek();
                Statisztika(korokSzama - 1);
            }
        }

        public virtual void Jatek()
        {
            VersenyIndul();
            bool helper = true;
            while(helper)
            {
                Console.WriteLine("__________Mindenki tippel_________");
                if (MindenkiTippel())
                {
                    helper = false;
                }
            }
        }
    }
}
