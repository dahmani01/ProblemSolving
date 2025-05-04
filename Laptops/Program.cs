int n = int.Parse(Console.ReadLine());
List<Laptop> laptops = new List<Laptop>(n);  

for (var i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    int price = int.Parse(input[0]);
    int quality = int.Parse(input[1]);
    laptops.Add(new Laptop(price, quality));
} 

laptops.Sort((x,y)=> x.Price.CompareTo(y.Price));
var maxQuality = laptops[0].Quality;
for( int i = 1; i < laptops.Count; i++ )
{
    if (laptops[i].Quality < maxQuality)
    {
        Console.WriteLine("Happy Alex");
        return;
    }
    maxQuality = Math.Max(maxQuality, laptops[i].Quality);
}

Console.WriteLine("Poor Alex");
public record Laptop(int Price , int Quality) ;

