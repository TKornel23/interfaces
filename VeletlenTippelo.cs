using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class VeletlenTippelo : GepiJatekos
    {
        Random random = new Random();
        public override int KovetkezoTipp()
        {            
            return random.Next(this.alsoHatar, this.felsoHatar + 1);
        }
    }
}
