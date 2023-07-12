//Test 

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

Random dice = new Random();

int Roll1 = dice.Next();
int Roll2 = dice.Next(11);
int Roll3 = dice.Next(1, 11);

Console.WriteLine($"first number is {Roll1}");
Console.WriteLine($"second number is {Roll2}");
Console.WriteLine($"third number is {Roll3}");