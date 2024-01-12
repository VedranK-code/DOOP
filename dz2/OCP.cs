using System;
using System.Collections.Generic;
namespace OCP
{

    public class Lav{
        public string BrzinaTrcanja {get; set;}
    }


    public class BrzinaKretanja{
        public void IspisiBrzinuKretanja(Lav lav)
        {
             Console.WriteLine($"Brzina trcanja lava je {lav.BrzinaTrcanja}");
        }

    }
}

/*Narusava OCP jer clasa BrzinaKretanja ispisuje samo brzinu trcanja lava, a ne bi radilo sa npr. brzinom leta sokola. 
bolje bi po OCP-u bilo da imamo apstrakciju zivotinja sa metodom brzina kretanja koju nasljeduje svaka zivotinja. 