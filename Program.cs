// Jasmine Leek
// 18 Oct 2022
// Mini-Challenge #2 "Add 2 Numbers"
// This is an application that asks the user to input two numbers, then adds them together and prints the sum

Console.Clear();
bool playAgain = true;

while (playAgain)
{
    Console.WriteLine("Let's add two numbers together!\n");
    Console.Write("Enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Now enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nCalculating...\nThe sum is " + (num1 + num2) + "!\n");

    Console.Write("Want to play again? \n \nEnter any key to restart or type 'end' to quit: ");

    string ready = Console.ReadLine();
    if (ready == "end")
    {
        playAgain = false;
    }
}