using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class SzamKitalaloJatekKaszino : SzamKitalaloJatek, IStatisztikatSzolgaltat
    {
        int kaszinoNyert, kaszinoVeszitett;
        int korokSzama;

        public SzamKitalaloJatekKaszino(int alsoHatar, int felsoHatar, int korokSzama)
            : base(alsoHatar, felsoHatar)
        {
            this.kaszinoNyert = 0;
            this.kaszinoVeszitett = 0;
            this.korokSzama = korokSzama;
        }

        public int HanyszorNyert => kaszinoNyert;

        public int HanyszorVesztett => kaszinoVeszitett;

        public override void Jatek()
        {
            VersenyIndul();
            int j = 0;
            bool helper = true;
            while(j < korokSzama && helper)
            {
                Console.WriteLine("__________Mindenki tippel_________");
                if (MindenkiTippel())
                {
                    kaszinoVeszitett++;
                    helper = false;
                }                
                j++;
            }
            if (helper)
            {
                kaszinoNyert++;
            }
            
        }

        public new void Statisztika(int korokSzama)
        {
            base.Statisztika(korokSzama);
            Console.WriteLine($"Ny: {HanyszorNyert} V: {HanyszorVesztett}");
        }
    }
}
