using System;
using System.Collections.Generic;

class AnimalTextArt
{
    static void Main()
    {
        Console.WriteLine("Welcome to AnimalTextArt!");
        Dictionary<string, string> animalArtDictionary = new Dictionary<string, string>
        {
            { "dog", @"
         / \__
        (    @\___
        /         O
       /   (_____/
      /_____/   U
    " },
            { "cat", @"
      /\_/\  
     ( o.o ) 
      > ^ <
    " },
            { "pig", @"
    ┈┈╭━╮╭━┈
    ┈┈┃┏┗┛ ┓┈
    ┈╭┓▋ ▋┏╯╯
    ╭━┻╮╲┗━━━
    ┃▎▎┃╲╲╲╲╲
    ╰━┳┻▅╯╲╲╲
    ┈┈╰━┳┓┏┳┓
    ┈┈┈┈┗┻┛┗┻
    " },
        };

        Console.Write("Enter an animal name: ");
        string userAnimal = Console.ReadLine().ToLower();
        if (animalArtDictionary.TryGetValue(userAnimal, out string animalArt))
        {
            Console.WriteLine("\n" + animalArt);
        }
        else
        {
            Console.WriteLine("Sorry, no text art available for that animal.");
        }

        Console.WriteLine("\nThanks for using AnimalTextArt!");
    }
}


