//install -> https://git-scm.com/

string name = "Tibor";
Console.WriteLine($"Hello {name}!");

ConsoleColor[] colors = 
    [ConsoleColor.Red, ConsoleColor.Green,
    ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Magenta];

for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = colors[i % colors.Length];
    Console.Write("random text ");
}

Console.WriteLine("Hello fucked up World!");

int szam = 12;