using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//obrazac je Composite
//Imamo abstraknu klasu Component koju nasljeđuju Datoteka i Direktorij s Metodom Display koja kod datoteke sluzi za ispis imena a kod direktroija za ispis podataka datoteka unutar direktorija
//U nasem Slucaju Leaf je Datoteka a Composit je direktorij
//Unutar klase direktorija imamo jos metode za dodavanje i brisanje dototeka

public abstract class Component
{
    public abstract void DisplayInfo();
}


public class Datoteka: Component
{
    private string name;

    public Datoteka(string Name) {
        name = Name;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"File: {name}");
    }
}

public class Direktorij : Component
{
    private string name;
    private List<Component> children = new List<Component>();

    public Direktorij(string name)
    {
        this.name = name;
    }

    public void Add(Component component)
    {
        children.Add(component);
    }

    public void Remove(Component component)
    {
        children.Remove(component);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Directory: {name}");

        foreach (var component in children)
        {
            component.DisplayInfo();
        }
    }
}





