string[] snacks = { "sushi", "pizza", "poke bowl", "burger", "ice cream" };

Random rnd = new Random();
int randomIndex  = rnd.Next(0, snacks.Length);

Console.WriteLine($"Have a nice evening with {snacks[randomIndex]}");
