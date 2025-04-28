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
        Console.WriteLine("Hello, World!");
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
