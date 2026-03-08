using System;

File.Delete("diceRolls.txt");
Console.WriteLine("How big is the dice? (Enter a number)");
int diceSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many times do you want to roll the dice? (Enter a number)");
int rolls = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < rolls; i++)
{
Random random = new Random();
int diceRoll = random.Next(1, diceSize + 1);
//Console.Write(" ," + diceRoll);
using (FileStream fs = new FileStream("diceRolls.txt", FileMode.Append, FileAccess.Write))
using (StreamWriter sw = new StreamWriter("diceRolls.txt", true))
    {
        sw.WriteLine(diceRoll);
    }
}
Console.ReadLine();
