int n = int.Parse(Console.ReadLine()) ; 
int sumX =0, sumY=0, sumZ=0 ; 
 
for( int i =0 ; i < n ; i++) {
    int[] vectors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray() ; 
    sumX += vectors[0];
    sumY += vectors[1];
    sumZ += vectors[2];
}
 
if( sumZ == 0 && sumY ==0 && sumX ==0 ){
    Console.WriteLine("YES") ;
}
else
{
    Console.WriteLine("NO");
}