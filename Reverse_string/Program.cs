namespace Reverse_string;

class Program
{
    static void Main(string[] args)
    {
        //entry message and declare entry variable  
        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();
        string originalString = input.ToLower();
        
        
        //Declare variables to use for length and reverse value 
        string reverseString = "";
        int count = originalString.Length;
        //List<string> entry = new List<string>();

        for (int i = 1; i <= count; i++)
        {
            reverseString += (input[count-i]).ToString();
            //entry.Add(originalString[count-i].ToString());
            
        }

        //string.Join(System.Environment.NewLine, reverse_string);
        //string final = string.Join("", reverseString);
        string final = reverseString;

        if (final == originalString)
        {
            Console.WriteLine($"This string '{input}' is a Palindrome!");
        }
        else
        {
            Console.WriteLine($"The reverse of the string is {final}, which is not a Palindrome!");
        }
        
    }
}