using System;
using System.Collections.Generic;
namespace dz1
{
    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ID { get; set; }

        public Osoba(string ime, string prezime, int id)
        {
            Ime = ime;
            Prezime = prezime;
            ID = id;
        }
    }


    public class Student : Osoba
    {
        public List<int> Ocjene { get; private set; }
        public string Razred { get; set; }

        public Student(string ime, string prezime, int id, string razred) : base(ime, prezime, id)
        {
            Ocjene = new List<int>();
            Razred = razred;
        }

        public void DodajOcjenu(int ocjena)
        {
            Ocjene.Add(ocjena);
        }

        public void PrikaziOcjene()
        {
            Console.WriteLine($"Ocjene studenta {Ime} {Prezime}: {string.Join(", ", Ocjene)}");
        }
    }


    public class Ucitelj : Osoba
    {
        public List<string> Predmeti { get; set; }

        public Ucitelj(string ime, string prezime, int id, List<string> predmeti) : base(ime, prezime, id)
        {
            Predmeti = predmeti;
        }

        public void DodajOcjenuStudentu(Student student, int ocjena)
        {
            student.DodajOcjenu(ocjena);
        }

        public void PregledOcjenaUcenika(Student student)
        {
            student.PrikaziOcjene();
        }

        public void PregledOcjenaRazreda(List<Student> razred)
        {
            foreach (var student in razred)
            {
                PregledOcjenaUcenika(student);
            }
        }
    }


    public class Ravnatelj : Osoba
    {
        public List<Student> Studenti { get; set; }
        public List<Ucitelj> Ucitelji { get; set; }

        public Ravnatelj(string ime, string prezime, int id) : base(ime, prezime, id)
        {
            Studenti = new List<Student>();
            Ucitelji = new List<Ucitelj>();
        }

        public void DodajStudenta(Student student)
        {
            Studenti.Add(student);
        }

        public void DodajUcitelja(Ucitelj ucitelj)
        {
            Ucitelji.Add(ucitelj);
        }

        public void UkloniStudenta(Student student)
        {
            Studenti.Remove(student);
        }

        public void UkloniUcitelja(Ucitelj ucitelj)
        {
            Ucitelji.Remove(ucitelj);
        }

        public void PregledOcjenaSkole()
        {
            foreach (var student in Studenti)
            {
                student.PrikaziOcjene();
            }
        }
    }


    public class Razred
    {
        public string Naziv { get; set; }
        public List<Student> Studenti { get; set; }

        public Razred(string naziv)
        {
            Naziv = naziv;
            Studenti = new List<Student>();
        }

        public void DodajStudenta(Student student)
        {
            Studenti.Add(student);
        }

        public void UkloniStudenta(Student student)
        {
            Studenti.Remove(student);
        }

        public void PrikaziOcjeneRazreda()
        {
            foreach (var student in Studenti)
            {
                student.PrikaziOcjene();
            }
        }
    }


    class Program
    {
        static void Main()
        {

            Student student1 = new Student("Marko", "Marković", 1, "1A");
            Ucitelj ucitelj1 = new Ucitelj("Ana", "Anić", 2, new List<string> { "Matematika", "Hrvatski" });
            Razred razred1 = new Razred("1A");
            Ravnatelj ravnatelj = new Ravnatelj("Ivan", "Ivanić", 3);

            ravnatelj.DodajStudenta(student1);
            ravnatelj.DodajUcitelja(ucitelj1);

            ucitelj1.DodajOcjenuStudentu(student1, 5);

            student1.PrikaziOcjene();
            ucitelj1.PregledOcjenaUcenika(student1);

            ravnatelj.PregledOcjenaSkole();

            razred1.DodajStudenta(student1);
            razred1.PrikaziOcjeneRazreda();
        }
    }
}