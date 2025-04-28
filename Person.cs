using System;
using BCrypt.Net;
using System.IO;

public class Person
{
	// Fields
	public string? Name;
	public int Age;
	public string[]? Hobbies;
	private string? Password { get; set; }


	public void PromptUserForPassword(string? userName)
	{
		Console.WriteLine($"Hello {userName}!\nPlease enter a new password!");
		string? userInput = Console.ReadLine();
		WriteToFile("eksempel.txt", $"username:{userName}" + "password: " + BCrypt.Net.BCrypt.HashPassword(userInput));
		Console.WriteLine($"Hello {userName}! Your password is {BCrypt.Net.BCrypt.HashPassword(userInput)}!");
	}

	private void WriteToFile(string? filePath, string? content) 
	{
		if(filePath == null) 
		{
			throw new Exception();
		}
		File.WriteAllText(filePath, content);
	}
}
