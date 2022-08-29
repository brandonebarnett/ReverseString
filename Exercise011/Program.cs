/* Write a program that ask's the user to enter their name.  Use an array to reverse
 * the name and then store the result in a new string.  Display the reversed name on the console.*/

using System.Text;

string userInput;

Console.WriteLine("Please enter your name.");
userInput = Console.ReadLine();

ReverseName(userInput);

//Console.WriteLine(ReverseName(userInput));

static void ReverseName(string name)
{
    char[] chars = name.ToCharArray();
    StringBuilder reversed = new StringBuilder();

    for (int i = chars.Length - 1; i >= 0; i--)
    {
        reversed.Append(chars[i]);
    }
    Console.WriteLine(reversed);
}