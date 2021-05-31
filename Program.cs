using System;

namespace Interfesz
{
    class Program
    {
        static void Teszt1()
        {
            SzamKitalaloJatek jatek = new SzamKitalaloJatek(10, 20);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();
            jatek.VersenyzoFelvetele(veletlen);
            jatek.VersenyzoFelvetele(bejaro);
            jatek.Jatek();
            Console.ReadLine();
        }

        static void Teszt2()
        {
            SzamKitalaloJatek jatek = new SzamKitalaloJatek(10, 20);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();
            LogaritmikusKereso logaritmikus = new LogaritmikusKereso();
            jatek.VersenyzoFelvetele(veletlen);
            jatek.VersenyzoFelvetele(bejaro);
            jatek.VersenyzoFelvetele(logaritmikus);
            jatek.Jatek();
            Console.ReadLine();
        }

        static void Teszt3()
        {
            SzamKitalaloJatek jatek = new SzamKitalaloJatek(10, 20);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();
            EmberiJatekos ember = new EmberiJatekos();
            LogaritmikusKereso logaritmikus = new LogaritmikusKereso();
            jatek.VersenyzoFelvetele(veletlen);
            jatek.VersenyzoFelvetele(bejaro);
            jatek.VersenyzoFelvetele(logaritmikus);
            jatek.VersenyzoFelvetele(ember);
            jatek.Jatek();
            Console.ReadLine();
        }

        static void Teszt4()
        {
            SzamKitalaloJatek jatek = new SzamKitalaloJatek(10, 20);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();
            LogaritmikusKereso logaritmikus = new LogaritmikusKereso();
            jatek.VersenyzoFelvetele(veletlen);
            jatek.VersenyzoFelvetele(bejaro);
            jatek.VersenyzoFelvetele(logaritmikus);
            jatek.Statisztika(1000);
            Console.ReadLine();
        }

        static void Teszt5()
        {
            SzamKitalaloJatekKaszino kaszino = new SzamKitalaloJatekKaszino(1, 100, 6);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();
            LogaritmikusKereso logaritmikus = new LogaritmikusKereso();
            kaszino.VersenyzoFelvetele(veletlen);
            kaszino.VersenyzoFelvetele(bejaro);
            kaszino.VersenyzoFelvetele(logaritmikus);
            kaszino.Statisztika(1000);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Teszt1();
            //Teszt2();
            //Teszt3();
            //Teszt4();
            Teszt5();
        }

       
    }
}
