/*
-------------------------------
Koji je oblikovni obrazac prikladan za rješavanje zadatka danog u 
nastavku i u koju skupinu pripada?Navedite strukturu klasa te pripadajuće 
metode/atribute koje biste koristili i njihove uloge:

Razvijate sustav za upravljanje datotekama koji omogućuje organizaciju i 
manipulaciju različitih vrsta datoteka u računarskom sustavu. 
Svaka datoteka može biti ili direktorij (folder) koji može sadržavati 
druge datoteke ili samo konkretna datoteka.
-------------------------------

Odgovor: Pošto se radi s datotekama najbolje je koristiti obrazac kompozit, pripada skupini 
obrazaca strukture.
*/

public interface FileSystem{//Komponenta
    public virtual void Display();
}

public class File : FileSystem // List (Datoteka)
{
    private string fileName;

    public File(string name)
    {
        fileName = name;
    }

    public override void Display()
    {
        Console.WriteLine($"Datoteka: {fileName}");
    }


    public class Directory : FileSystem //Kompozit
{
    private string directoryName;
    private List<FileSystem> files;

    public Directory(string name)
    {
        directoryName = name;
        files = new List<FileSystem>();
    }

    public void Add(FileSystem item)
    {
        files.Add(item);
    }

    public void Remove(FileSystem item)
    {
        files.Remove(item);
    }

    public override void Display()
    {
        Console.WriteLine($"Direktorij: {directoryName}");
        foreach (var file in files)
        {
            file.Display();
        }
    }
}
}
