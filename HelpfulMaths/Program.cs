short[] equation = Console.ReadLine().Split("+").Select(short.Parse).ToArray();
Array.Sort(equation);
Console.WriteLine(string.Join("+", equation));