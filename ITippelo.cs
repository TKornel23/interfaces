using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    interface ITippelo : IJatekos
    {
        void JatekIndul(int alsoHatar, int felsoHatar);
        int KovetkezoTipp();
    }
}
