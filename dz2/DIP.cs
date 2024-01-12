using System;

public class TV
{
    public void TurnOn()
    {
        Console.WriteLine("TV is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is OFF");
    }
}

public class Daljinski
{
    private TV Samsung;

    public Daljinski()
    {
        Samsung = new TV();
    }

    public void Press()
    {
        Samsung.TurnOn();
    }

    public void Release()
    {
        Samsung.TurnOff();
    }
}

class Program
{
    static void Main()
    {
        Daljinski SamsungDaljinski = new Daljinski();
        SamsungDaljinski.Press();
        SamsungDaljinski.Release();
    }
}
/*Narusava DIP jer je klasa Daljinski u cvrstoj sprezi s klasom TV, bilo bi ispravije da ovisi o 
interfaceu ITurnOnable, tako bi molgi injectati neku drugu klasu u kod bez greske umjesto da 
ovisimo o TV klasi.