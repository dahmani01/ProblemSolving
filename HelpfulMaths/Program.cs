short[] equation = Console.ReadLine().Split("+").Select(short.Parse).ToArray();
Console.WriteLine(string.Join("+", equation.Order()));