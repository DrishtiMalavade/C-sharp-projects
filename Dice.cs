using System;

class Dice {
    static int score = 0; 
    
    public static void Main() {
        Console.WriteLine("Your current score is: " + score);
        Console.Write("Do you want to play? yes or no: ");
        string userInput = Console.ReadLine(); 
        Console.WriteLine(" ");
        
        if (userInput == "yes") {
            PlayRound(); 
        }
        else {
            Console.WriteLine("We will then exit the game, your score is: " + score);
        }
    }

    static void PlayRound() {
        Random random = new Random();
        int playerNum = random.Next(1, 6);
        Console.WriteLine("The number on your dice is: " + playerNum);
        
        int computerNum = random.Next(1, 6);
        Console.WriteLine("The number on the computer's dice is: " + computerNum);
        Console.WriteLine(" ");
        
        if (playerNum > computerNum) {
            Console.WriteLine("You win this round!");
            Console.WriteLine("---------------------------------------------");
            score++; // Increment the score
        }
        else if (playerNum == computerNum) {
            Console.WriteLine("It is a tie");
            Console.WriteLine("---------------------------------------------");
        }
        else {
            Console.WriteLine("You lost this round");
            Console.WriteLine("---------------------------------------------");
        }

        Main(); 
    }
}
