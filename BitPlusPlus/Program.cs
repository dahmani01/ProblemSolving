int n = int.Parse(Console.ReadLine()) ; 
int x= 0;
for( int i =0 ; i < n ; i++) {
    string input = Console.ReadLine();
    if(input.Contains('-'))
        x--;
    else
        x++;
}
 
Console.WriteLine(x);