game();
void game()
{
    Console.Write("Enter Min number:");
    string minInput = Console.ReadLine()!;

    Console.Write("Enter Max number:");
    string maxInput = Console.ReadLine()!;

    if (int.TryParse(maxInput, out int max) &&
        int.TryParse(minInput, out int min))
    {
        Random rnd = new Random();
        int compNumber = rnd.Next(min, max);
        int guesses = 1;
        int guessNumber = askForNumber();

        while (compNumber != guessNumber) 
        {
            ++guesses;
            guessNumber = askForNumber(); 
        }

        Console.WriteLine("You guessed it, the number was " + compNumber + 
            " It took you " + guesses + " tries.");

        Console.WriteLine("Want to play again? (Yes/No): ");

        if (Console.ReadLine()!.ToUpper() == "YES") 
        {
            game();
        }
        else
        {
            return;
        }
    }
    else
    {
        Console.WriteLine("Wrong Input");
        game();
    };
}

int askForNumber()
{
    Console.Write("Guess the number:");
    string guessInput = Console.ReadLine()!;

    if (!int.TryParse(guessInput, out int guess)) askForNumber();
    return guess;
}