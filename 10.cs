Console.Write("Enter n: ");

var random = new Random();
int secretNumber = random.Next(1, int.Parse(Console.ReadLine()));
int attempts = random.Next(3, secretNumber);

Console.WriteLine($"You have {attempts} attempts");

while (attempts > 0)
{
    Console.Write("Make a guess: ");
    int guess = int.Parse(Console.ReadLine());
    if (guess == secretNumber)
    {
        Console.WriteLine("You're right!");
        break;
    }
    Console.WriteLine(guess > secretNumber ? "Guess begger than number" : "Guess less than number");
    attempts--;

}
