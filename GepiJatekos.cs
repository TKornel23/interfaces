using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{

    abstract class GepiJatekos : ITippelo, IStatisztikatSzolgaltat
    {
        int IStatisztikatSzolgaltat.HanyszorNyert { get { return nyertDB; } }
        int IStatisztikatSzolgaltat.HanyszorVesztett { get { return veszitettDB; } }

        protected int alsoHatar, felsoHatar;
        protected int nyertDB, veszitettDB = 0;
        public virtual void JatekIndul(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }

        public abstract int KovetkezoTipp();

        public void Nyert()
        {
            nyertDB++;
        }

        public void Veszített()
        {
            veszitettDB++;
        }
    }
}
