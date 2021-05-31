using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class BejaroTippelo : GepiJatekos
    {
        int aktualis;

        public override void JatekIndul(int alsoHatar, int felsoHatar)
        {
            base.JatekIndul(alsoHatar, felsoHatar);
            this.aktualis = this.alsoHatar;
        }
        public override int KovetkezoTipp()
        {
            return aktualis++;
        }
    }
}
