#Prva Zadaca
Zadatak: Aplikacija za Praćenje Ocjena Studenata
Cilj zadatka je razviti aplikaciju za praćenje ocjena studenata u školskom sustavu koristeći principima objektno orijentiranog programiranja (OOP) u programskom jeziku C#.

Klase:
Osoba:
Atributi: Ime, Prezime, ID
Metode: Konstruktor, Get/Set metode za atribute

Student:
Atributi: Ocjene, Razred
Metode: Konstruktor, Metoda za dodavanje ocjene, Metoda za prikazivanje ocjena

Učitelj:
Atributi: Predmeti kojima predaje
Metode: Konstruktor, Metoda za dodavanje ocjena studentima, Metoda za pregled ocjena svojih učenika

Ravnatelj
Metode: Konstruktor, Metoda za dodavanje učitelja i studenata, Metoda za uklanjanje učitelja i studenata, Metoda za pregled općih ocjena škole

Razred:
Atributi: Naziv razreda, Lista studenata
Metode: Konstruktor, Metoda za dodavanje i uklanjanje studenata, Metoda za prikazivanje ocjena razreda

Scenariji Uporabe:
Unos Studenata:
Ravnatelj može dodavati nove studente u sustav.

Unos Učitelja:
Ravnatelj može dodavati nove učitelje u sustav.

Dodavanje Studenata u Razred:
Ravnatelj može dodavati studente u razrede.

Dodavanje Ocjena:
Učitelj može dodavati ocjene studentima.

Pregled Ocjena:
Student može pregledavati svoje ocjene.
Učitelj može pregledavati ocjene svojih učenika.

Pregled Ocjena Razreda:
Učitelj može pregledavati ocjene cijelog razreda.

Pregled Općih Ocjena Škole:
Ravnatelj može pregledavati ukupne ocjene škole.

Preporuke:
Korištenje kolekcija poput List<T> za pohranu studenata i ocjena.
Implementacija autentikacije i autorizacije za pristup različitim dijelovima sustava.
Osigurajte čitljivost koda, pridržavajte se principa SOLID dizajna te koristite dobro organiziranu i strukturiranu OOP praksu.
