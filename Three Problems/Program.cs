using System.Runtime.CompilerServices;

int choice;

// do while loop used to show menu as long as entry isnt 5
do
{
    
 

Console.WriteLine("=== CSCI 1260 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");
 choice = 0;
Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());

if (choice > 5)
{Console.WriteLine("Choose a number from 1 to 5.");
}




if (choice == 1 || choice == 4)
{
int score;


Console.WriteLine("=== Excercise 1: The Grade Checker ===");
Console.Write("Please enter score: ");
score = Convert.ToInt32(Console.ReadLine());

// while loop used so the program doesn't continue with a number outside these parameters

while (score > 100 || score < 0)
{Console.WriteLine("Choose a number between 0 and 100");
score = 0;
}
}

if (choice == 2 || choice == 4)
{
    //excercise 2
}

if (choice == 3 || choice == 4)
{
    //excercise 3
}



}while (choice != 5); 





 Console.WriteLine("Goodbye.");