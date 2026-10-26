/*
Name:       Felix Jordan
Course:     CSCI 1250, Section 001
Assignment: Lab06, Three Short Problems
Date:       10/25/2026
Description: A menu that keeps running until the user quits, offering three
independent exercises or all three at once. Each excercise
practices decisions and one of the four loops        

*/



Random rng = new Random(4000);
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

// while loop used so the program doesn't continue with a number outside these parameters and resets

while (score > 100 || score < 0)
{Console.WriteLine("Choose a number between 0 and 100");
Console.Write("Please enter score: ");
score = Convert.ToInt32(Console.ReadLine());
;
}

// else if used to organize scores from top to bottom 
 if (score >= 90)
 {Console.WriteLine("Score: " + score);
 Console.WriteLine(score + " earns an A");
}

else if (score >= 80)
{Console.WriteLine("Score: " + score);
Console.WriteLine(score + " earns an B");
}

else if (score >= 70)
{Console.WriteLine("Score: " + score);
Console.WriteLine(score + " earns an C");
}

else if (score < 60)
{Console.WriteLine("Score: " + score);
Console.WriteLine(score + " earns an F");
}
}

int wins = 0;
int rolls = 0;
string rollAgain = "y";



if (choice == 2 || choice == 4)
{


   Console.WriteLine("=== Excercise 2 The Dice Table ===");

// this loop starts with a dice roll and continues as long as we want it to
do
{

    int roll1 = rng.Next(1,7);
    int roll2 = rng.Next(1,7);
    int sum = roll1 + roll2;
    rolls++;

    Console.Write($"Roll {rolls}: {roll1} and {roll2}, total {sum}. ");



if (sum == 2)
{Console.Write("Snake eyes.");}

if (roll1 == roll2 && roll1 != 1)
{Console.Write("Doubles!");}

if (sum == 7 || sum == 11)
{Console.Write("A winner!");
wins++;}

Console.WriteLine("\nRoll again? y/n: ");
rollAgain = Console.ReadLine();

} while (rollAgain == "y");

if (rollAgain != "y")
{Console.WriteLine($"You rolled {rolls} times and won {wins}");
}
}



if (choice == 3 || choice == 4)

{
   Console.WriteLine("=== Excercise 3: The Score Report ===");

double[] scores = new double[5];
double total = 0;
double passingGrades = 0;

for (int i = 0; i < 5; i++)
{  
     Console.Write($"Score {i+1}: ");
    scores[i] = Convert.ToUInt64(Console.ReadLine());
   total = total + scores[i];
}
 
foreach (double score in scores)
{if (score > 60)
{passingGrades++;
}
}

double max = scores.Max();



Console.WriteLine($"Scores entered: {scores.Length}");
Console.WriteLine($"Score total: {total}");
Console.WriteLine($"Score Average: {total / (scores.Length)}");
Console.WriteLine($"Highest: {max}");
Console.WriteLine($"Passing: {passingGrades} of {scores.Length} ");
}

choice = 0;
}while (choice != 5); 

 Console.WriteLine("Goodbye.");
 
