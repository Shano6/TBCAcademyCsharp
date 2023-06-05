Console.WriteLine("Choose Rock, Paper or Scissors");
String userChoice = Console.ReadLine()!.ToUpper();

string[] choices = { "ROCK", "PAPER", "SCISSORS" };

if(!choices.Contains(userChoice))
{
    Console.WriteLine("Wrong Input");
    return;
}

Random random = new Random(); 
int chosenIndex = random.Next(choices.Length); 
String compChoice = choices[chosenIndex];

Console.WriteLine("Your choice: " + userChoice);
Console.WriteLine("Computer choice: " + compChoice);

if(
    (userChoice == "ROCK" && compChoice == "SCISSORS") ||
    (userChoice == "PAPER" && compChoice == "ROCK") ||
    (userChoice == "SCISSORS" && compChoice == "PAPER")
)
{
    Console.WriteLine("You win");
} else if(userChoice == compChoice)
{
    Console.WriteLine("Draw");
} else
{
    Console.WriteLine("Computer wins");
}

