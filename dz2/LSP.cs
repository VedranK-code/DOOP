using System;
using System.Collections.Generic;
namespace LSP
{
    public class Macka
    {
        public virtual double Visina{ get; set;}
        public virtual double Sirina{ get; set;}
        public virtual double Tezina{ get; set;}
        public virtual string BojaKrzna{ get; set;}

        public Macka(double visina, double sirina, double tezina, string bojaKrzna){
            Visina=visina;
            Sirina=sirina;
            Tezina=tezina;
            BojaKrzna=bojaKrzna;
        }
    }

    public class SfinksMacka : Macka //NemaKrzna
    {
        public override double Visina{
            set{ base.Visina= value;}
        }
        public override double Sirina{
            set{ base.Sirina= value;}
        }
        public override double Tezina{
            set{ base.Tezina= value;}
        }

        public override string BojaKrzna{
            set{ base.BojaKrzna= "Nema krzna";}
        }

        public SfinksMacka(double visina, double sirina, double tezina, string bojaKrzna): base(visina,sirina,tezina,bojaKrzna){
            Visina=visina;
            Sirina=sirina;
            Tezina=tezina;
            BojaKrzna=bojaKrzna;
        }
    }

   public class DetaljiMacke
{
    public void IspisiDetalje(Macka macka)
    {
        Console.WriteLine("Detalji macke:");
        Console.WriteLine($"Visina: {macka.Visina}");
        Console.WriteLine($"Sirina: {macka.Sirina}");
        Console.WriteLine($"Tezina: {macka.Tezina}");
        Console.WriteLine($"Boja Krzna: {macka.BojaKrzna}");
    }
}

class Program
{
    static void Main()
    {

         Macka Garfield = new Macka(25, 15, 5, "zuta");


        SfinksMacka sfinksMacka = new SfinksMacka(45, 10, 4, "Nema Krzna");
        DetaljiMacke detaljiMacke = new DetaljiMacke();

        detaljiMacke.IspisiDetalje(Garfield);
        detaljiMacke.IspisiDetalje(sfinksMacka);
    }
}
}

/*Ovaj kod krsi LSP jer SfinksMacka ima nepotrebno svojstvo Boja Krzna, To je 
problem jer klasa SfinksMacka mora implementirati 
nepotrebno ponasanje kako bi mogle biti koristena od strane IspisMacke:*/