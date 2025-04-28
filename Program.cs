using System;
using System.Collections.Generic;

namespace OppgaveKHBE0424;



class Program
{
    static void Main(string[] args)
    {
       
        

        /*
            Oppgave 1:
                - Lag noen enkle variabler av forksjellige primitive datatyper
                - Forsøk å skrive ut verdiene som er tildelt variablene ved å bruke Console.WriteLine(); metoden.
        */
        // int alder = 30;
        // Her vil jeg heller regne ut alderen ut i fra fødselsdato, i stedet for å bare skrive det inn
        DateTime fødselsdato = new DateTime(1995, 1, 1);
        DateTime iDag = DateTime.Today;
        int alder = iDag.Year - fødselsdato.Year;
        if (fødselsdato.Date > iDag.AddYears(-alder))
        {
            alder--;
        }

        double høyde = 1.86;
        bool erStudent = false;
        char kjønn = 'M';
        string navn = "William";


        // string fødselsdato = "01.01.1995";
        // ChatGPT forteller at primitive datatyper ikke er så bra for å printe ut fødselsdatoer, og anbefalte heller funksjonen DateTime. Det er det jeg har gjort her, og bygget videre oppgaven min på.


        Console.WriteLine($"Navn: {navn}");
        Console.WriteLine($"Alder: {alder}");
        Console.WriteLine($"Høyde: {høyde} meter");
        Console.WriteLine($"Er student: {erStudent}");
        Console.WriteLine($"Kjønn: {kjønn}");
        Console.WriteLine($"Fødselsdato: {fødselsdato.ToShortDateString()}");
        //Console.WriteLine($"Alder: {alder}");
        // Console.WriteLine($"Fødselsdato: {fødselsdato}");

        /*
            Oppgave 2:
                - Forsøk å lage et array av forksjellige primitive datatyper.
                - Forsøk å skrive ut verdiene som befinner seg i arrayet, ved å bruke en for-loop, eller en foreach-loop.
        */
        object [] personData = new object []
        {
            "William",
            30,
            1.86,
            true,
            'M',
            new DateTime(1995, 1, 1)
        };

        Console.WriteLine("\nVerdier i arrayet:");
        foreach (var data in personData)
        {
            Console.WriteLine($"Verdi: {data}, Type: {data.GetType()}");
        }
        



        /*
            Oppgave 3:
                - Forsøk å tildele variabler til en generiske Liste: eksempel: List<int> integers = new List<int>();
                - Forsøk å skrive ut verdiene i listen, ved å bruke en for-loop eller en foreach-loop.
        */
        List<Person> personer = new List<Person>();

        personer.Add(new Person("William", 30, 1.86, false, 'M', new DateTime(1995, 1, 1)));
        personer.Add(new Person("Tuva", 29, 1.77, true, 'F', new DateTime(1995, 8, 6)));
        personer.Add(new Person("Gary", 30, 1.68, false, 'M', new DateTime(1995, 4, 17)));

        Console.WriteLine("\nPersoner i listen:");
        foreach (var person in personer)

        {
            Console.WriteLine($"Navn: {person.Navn}, Alder: {person.Alder}, Høyde: {person.Høyde} meter, Er student: {person.ErStudent}, Kjønn: {person.Kjønn}, Fødselsdato: {person.Fødselsdato.ToShortDateString()}");
        }
    }
}


public class Person

{
    public string Navn { get; set; }
    public int Alder { get; set; }
    public double Høyde { get; set; }
    public bool ErStudent { get; set; }
    public char Kjønn { get; set; }
    public DateTime Fødselsdato { get; set; }

    public Person(string navn, int alder, double høyde, bool erStudent, char kjønn, DateTime fødselsdato)
    {
        Navn = navn;
        Alder = alder;
        Høyde = høyde;
        ErStudent = erStudent;
        Kjønn = kjønn;
        Fødselsdato = fødselsdato;
    }

       

        

    

    	public static double Add(double a, double b) 
		{
		  return a + b;
		}
		
		public static void AddVoid(double a, double b) 
		{
		  Console.WriteLine(a + b);
		}
}
