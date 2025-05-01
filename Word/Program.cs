var word = Console.ReadLine();

var nbrOfLowerCaseLetters = 0 ; 
int i = 0 ;

while ((i < word.Length) && (nbrOfLowerCaseLetters <= word.Length / 2))
{
    if (word[i] >= 'a' && word[i] <= 'z')
    {
        nbrOfLowerCaseLetters++;
    }

    i++;
}
int nbrOfUpperCaseLetters = word.Length - nbrOfLowerCaseLetters ;
if (nbrOfLowerCaseLetters >= nbrOfUpperCaseLetters)
{
    Console.WriteLine(word.ToLower());
}
else
{
    Console.WriteLine(word.ToUpper());
}