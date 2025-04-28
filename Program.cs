namespace OppgaveKHBE0424;

class Program
{
    static void Main(string[] args)
    {
        // initalize a new object, from a class
        Person person = new Person();
        person.Name = "Marius";
        person.Age = 39;
        
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);

        string[] shoppingList = {"Milk", "Soda", "Dinner", "Candy", "Fish", "Salmon"}; // fixed size: new string[6]
        List<string> programmeringLanguages = new List<string>() {
            "C#", "Java", "Python", "JavaScript", "C", "C++", "Rust", "Go"
        };

        List<int> ints = [1,2,3,4];

        for(int i = 0; i < shoppingList.Length; i++) 
        {
            Console.WriteLine(shoppingList[i]);
        }

        foreach(var programming in programmeringLanguages) 
        {
            Console.WriteLine(programming);
        }

        /*
            Oppgave 1:
                - Lag noen enkle variabler av forksjellige primitive datatyper
                - Forsøk å skrive ut verdiene som er tildelt variablene ved å bruke Console.WriteLine(); metoden.
        */


        /*
            Oppgave 2:
                - Forsøk å lage et array av forksjellige primitive datatyper.
                - Forsøk å skrive ut verdiene som befinner seg i arrayet, ved å bruke en for-loop, eller en foreach-loop.
        */

        /*
            Oppgave 3:
                - Forsøk å tildele variabler til en generiske Liste: eksempel: List<int> integers = new List<int>();
                - Forsøk å skrive ut verdiene i listen, ved å bruke en for-loop eller en foreach-loop.
        */

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
