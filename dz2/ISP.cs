using System;
using System.Collections.Generic;
namespace ISP
{
    public interface IReptile
    {
        public void walk();
        public void slither();
        public void fly();
        public void eat();
    }

    public class Lizzard : IReptile
    {
        public void walk() { }
        public void slither() { }
        public void fly() { }
        public void eat() { }

    }


    public class Snake : IReptile
    {
        public void walk() { }
        public void slither() { }
        public void fly() { }
        public void eat() { }

    }

    public class Pterosaur : IReptile
    {
        public void walk() { }
        public void slither() { }
        public void fly() { }
        public void eat() { }

    }

}

/*Više specifičnih sučelja bolje je od jednog općeg. Nepotrebno je Lizzardu: slither i fly, Snakeu: walk i fly,
Pterosauru; slither. Bolje nam je razdvojiti na: IWalkable, ISlitherble, Iflyable, IEatable, i onda svaka klasa moze
implementirati potrebna sučelja.*/