int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();

int numberOfOnes = input.Count(c => c == '1');
int numberOfZeros = n - numberOfOnes;
int pairs = Math.Min(numberOfOnes, numberOfZeros);
Console.WriteLine( n - 2 * pairs);


//---------------- This method got time limit exceeded with a string of n=20000 --------------
// int index = FindAdjacent(input);
// while (index != -1)
// {
//     input = input.Remove(index, 2);
//     index = FindAdjacent(input);
// }
//
// Console.WriteLine(input.Length);
//
// int FindAdjacent(string textInput)                 
// {
//     if (textInput.Length < 1) return -1;
//     for (int i = 0; i < textInput.Length - 1 ; i++)
//     {
//         if (textInput[i] != textInput[i + 1])
//         {
//             return i;
//         }
//     }
//
//     return -1;
// }


