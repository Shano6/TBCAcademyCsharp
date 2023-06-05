Console.WriteLine("Enter Your Birthyear");
String userInput = Console.ReadLine()!;

string[] yearNames = {
   "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", 
   "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"

};

if(int.TryParse(userInput, out int year) && year > 0)
{
    Console.WriteLine("You were born in " + yearNames[year % 12] + " year");
} else
{
    Console.WriteLine("Wrong Input");
}
