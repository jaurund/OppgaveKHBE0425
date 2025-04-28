using System;

namespace HelloWorld
{
	public class Person
	{
	  // Fields
	  public string? Name;
	  public int Age;
	  public string[]? Hobbies;
	  private string? Password {get; set;}
	  
	  
	  public void PromptUserForPassword(string? userName) 
	  {
	    Console.WriteLine($"Hello {userName}!\nPlease enter a new password!");
	    string? userInput = Console.ReadLine();
	    Console.WriteLine($"Hello {userName}! Your password is {userInput}!");
	  }
	}
}