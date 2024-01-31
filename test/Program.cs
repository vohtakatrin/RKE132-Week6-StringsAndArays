string[] colors = { "red", "green", "blue", "pink", "yellow" };
for (int i = colors.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(colors[i]);
//}
{
    Console.WriteLine($"{colors.Length - i}. {colors[i]}");
}

string[] myNumbers = { "1, 2, 3", "4,5,6", "7,8,9" };
int fruitArrayLength = myNumbers.Length;
Console.WriteLine($"Massiivi/kogumiku suurus on {myNumbers.Length}");
int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int fuitArrayLength = numbers.Length;
Console.WriteLine($"Massiivi/kogumiku suurus on {numbers.Length}");

string[] colours = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
int randomColor = colours[rnd.Next(0, colours.Length)];
Console.WriteLine($"You should wear {colours[randomColor]]} today.");