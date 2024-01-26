using System;
using System.Collections.Generic;

namespace LanacOdgovornosti
{

    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        
        object Handle(object request);
    }
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            
            return handler;
        }
        
        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class LionHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Child")
            {
                return $"Lion: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class SharkHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Mother")
            {
                return $"Shark: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class CatHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "CatFood")
            {
                return $"Cat: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Child", "Mother", "Cup Of My Enemys Blood" })
            {
                Console.WriteLine($"Vedran: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lion = new LionHandler();
            var shark = new SharkHandler();
            var cat = new CatHandler();

            lion.SetNext(shark).SetNext(cat);


            Console.WriteLine("Lanac: Lion > Shark > Cat\n");
            Client.ClientCode(lion);
            Console.WriteLine();

        }
    }
}