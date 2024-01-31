namespace ReverseString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Reverse String! Enter a word or phrase you would like to see in reverse\n");

        string userWord = string.Empty;
        userWord = Console.ReadLine().ToLower();

        string reverseWord = string.Empty;
        for (int i = userWord.Length - 1; i >= 0; i --)
        {
            reverseWord += userWord[i];
        }
        Console.WriteLine($"Your word in reverse is:\n {reverseWord}\n");

        //checking for a palidrome
        if (reverseWord == userWord)
        {
            Console.WriteLine("The word you entered is a palidrome!\n");
        }
        else
        {
            Console.WriteLine("Your word is not a palidrome");
        }
    }
}

