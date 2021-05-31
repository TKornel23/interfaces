using System;
using System.Collections.Generic;
using System.Text;

namespace Interfesz
{
    class LogaritmikusKereso : GepiJatekos, IOkosTippelo
    {
        public void Kisebb()
        {
            felsoHatar = KovetkezoTipp()-1;
        }

        public override int KovetkezoTipp()
        {
            return (felsoHatar + alsoHatar) / 2;
        }

        public void Nagyobb()
        {
            alsoHatar = KovetkezoTipp()+1;
        }
    }
}
