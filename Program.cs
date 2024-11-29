//install -> https://git-scm.com/

string name = "Zoltan";
Console.WriteLine($"Hello {name}!");

ConsoleColor[] colors = 
    [ConsoleColor.Red, ConsoleColor.Green,
    ConsoleColor.Blue, ConsoleColor.Yellow];

for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = colors[colors.Length % 4];
    Console.Write("random text ");
}

