/*
This program uses C# to write a Mad Libs word game. 
Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech.
The end result is a hilarious and strange story.
*/

using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {

      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs is starting!");

      // Give the Mad Lib a title:
      string title = "Title: One Fine Day";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      // Ask the user for three adjectives
      Console.Write("Enter the first adjective: ");
      string adj1 = Console.ReadLine();

      Console.Write("Enter the second adjective: ");
      string adj2 = Console.ReadLine();

      Console.Write("Enter the third adjective: ");
      string adj3 = Console.ReadLine();

      // Ask the user for a verb
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      // Ask the user for two nouns
      Console.Write("Enter the first noun: ");
      string noun1 = Console.ReadLine();

      Console.Write("Enter the second noun: ");
      string noun2 = Console.ReadLine();

      // Ask the user for an animal
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();

      // Ask the user for a food
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();

      // Ask the user for a fruit
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();

      // Ask the user for a superhero
      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();

      // Ask the user for a country
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();

      // Ask the user for a dessert
      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();

      // Ask the user for a year
      Console.Write("Enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      // Print the story:
      Console.WriteLine(story);
    }
  }
}

