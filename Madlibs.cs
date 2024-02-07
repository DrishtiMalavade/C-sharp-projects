using System;

class Madlibs
{
    static void Main()
    {
        string adjective, noun1, verb1, noun2, verb2;

        Console.WriteLine("Let's create a madlibs!");
        Console.Write("Enter an adjective: ");
        adjective = Console.ReadLine();

        Console.Write("Enter the first noun: ");
        noun1 = Console.ReadLine();

        Console.Write("Enter the first verb: ");
        verb1 = Console.ReadLine();

        Console.Write("Enter the second noun: ");
        noun2 = Console.ReadLine();

        Console.Write("Enter the second verb: ");
        verb2 = Console.ReadLine();

        Console.WriteLine($"\nHope is the {adjective} with {noun1}");
        Console.WriteLine($"That {verb1} in the {noun2},");
        Console.WriteLine($"And {verb2} the {noun1} without the {noun2},");
        Console.WriteLine("And never stops at all.");
        Console.WriteLine("\nOriginal poem is by Emily Dickinson titled \"Hope is the thing with feathers\"");
    }
}
