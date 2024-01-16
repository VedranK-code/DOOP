using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public abstract class Factory
    {
        public abstract ITV createTV();
        public abstract IMonitor createMonitor();
    }

    public class DellFactory : Factory
    {
        public override ITV createTV()
        {
            return new DellTV();
        }
        public override IMonitor createMonitor()
        {
            return new DellDisplay();
        }

    }
    public class SamsungFactory : Factory
    {
        public override ITV createTV()
        {
            return new SamsungTV();
        }
        public override IMonitor createMonitor()
        {
            return new SamsungDisplay();
        }

    }
    public interface ITV { public void SellTV(); }
    public interface IMonitor { public void SellMonitor(); }

    public class DellTV : ITV
    {
        public void SellTV()
        {
            Console.WriteLine("Dell TV Sold!");
        }
    }

    public class SamsungTV : ITV
    {
        public void SellTV()
        {
            Console.WriteLine("Samsung TV Sold!");
        }
    }

    public class DellDisplay : IMonitor
    {
        public void SellMonitor()
        {
            Console.WriteLine("Dell Monitor Sold!");
        }
    }

    public class SamsungDisplay : IMonitor
    {
        public void SellMonitor()
        {
            Console.WriteLine("Samsung Monitor Sold!");
        }
    }

    public class App
    {
        List<Factory> screenFactory = new List<Factory>
            {new DellFactory(), new SamsungFactory()};

        public void Run()
        {
            screenFactory.ForEach(screenFactory =>
            {
                ITV tv = screenFactory.createTV();
                IMonitor monitor = screenFactory.createMonitor();

                tv.SellTV();
                monitor.SellMonitor();
            });
        }
    }

    class Program
    {
        static void Main()
        {
            App app = new App();
            app.Run();
        }
    }
}

/*
SRP- klasa App sad samo koristi listu tvornica umjesto da instancira vise klasa proizvoda
OCP- suceljem proizvoda i apstraktnom tvornicom omogucujemo prosirenje tj. mozemo dodati jos tipova proizvoda bez da mjenjamo kod u App klasi
DIP- konkretne klase ovise o apstrakcijama tj. DellTV, DellMonitor, SamsungTV, SamsungMonitor, DellFactory, SamsungFactory sad ovise o ITV i IMoniotr suceljima
ISP - ITV i IMonitor su odvojeni umjesto da su spojeni u npr. IManufacturer
LSP - Konkretne Klase Factory su međusobno zamjenjive
*/