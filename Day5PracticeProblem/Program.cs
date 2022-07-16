char alpha;
Console.WriteLine("Enter the letter:");
alpha = Char.Parse(Console.ReadLine());
if((alpha == 'a') || (alpha == 'e') || (alpha == 'i') || (alpha == 'o') || (alpha == 'u') || (alpha == 'A') || (alpha == 'E') || (alpha == 'I') || (alpha == 'O') || (alpha == 'U'))
{
    Console.WriteLine(alpha+" is a Vowel.");
}
else
{
    Console.WriteLine(alpha+" is a Consonant.");
}