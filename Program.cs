string frase;
string dislalia;

Console.Clear();

Console.WriteLine("Digite uma frase: ");
frase = Console.ReadLine()!;

Console.Clear();

dislalia = frase
                .Replace("r", "l")
                .Replace("R", "L");

Console.WriteLine($"Você disse: {frase}");
Console.WriteLine($"O Cebolinha diria: {dislalia}");