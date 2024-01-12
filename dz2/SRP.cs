using System;
using System.Collections.Generic;
namespace SRP
{

    public class Racun
    {
        public void izdavanjeRacuna(string message)
        {
            //printanje racuna
        }
        public void GreskaPriIzdavanju(string message)
        {
            //Ispis greske(npr. fali papira)
        }
    }
}

/*Razlog narusavanja SRP-a: Klasa bi trebala imati samo jednu odgovornost, a clasa racun ima
dvije odgovornsti(izdavanje racuna i greska pri izdavanju), po SRP-u to treba razdijeliti na dvije 
klase.*/