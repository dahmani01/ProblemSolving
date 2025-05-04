int n = int.Parse(Console.ReadLine());
List<Laptop> laptops = new List<Laptop>();  

for (var i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int price = input[0];
    int quality = input[1];
    var laptop = new Laptop(price, quality);
    laptops.Add(laptop);
} 

var sortedLaptops = laptops.OrderBy(laptop => laptop.Price).ToList();
var index = 1;
var MaxQuality = sortedLaptops[0].Quality;
while (index < sortedLaptops.Count)
{
    if (sortedLaptops[index].Quality > MaxQuality)
        MaxQuality = sortedLaptops[index].Quality;
    else
    {
        Console.WriteLine("Happy Alex");
        return;
    }

    index++;
}

Console.WriteLine("Poor Alex");
public record Laptop(int Price , int Quality) ;

