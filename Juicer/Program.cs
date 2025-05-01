int[] line1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
int b= line1[1] , d= line1[2] ;
string[] a = Console.ReadLine().Split(" ");
int sum = 0, waste = 0;
for (int i = 0; i < a.Length; i++)
{
    int x= int.Parse(a[i]);
    if (x > b)
    {
        continue;
    }
    sum += x;
    if (sum > d)
    {
        sum = 0;
        waste++;
    }
}
Console.WriteLine(waste);