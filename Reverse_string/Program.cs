namespace Reverse_string;

class Program
{
    static void Main(string[] args)
    {
        //entry message and declare entry variable  
        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();
        input = input.ToLower();
        
        
        //Declare variables to use for length and reverse value 
        //string reverse_string = "";
        int cnt = input.Length;
        List<char> entry_value = new List<char>();
        

        for (int i = cnt-1; i >=0 ; i--)
        {
            //reverse_string += (input[i]);
            entry_value.Add(input[i]);
            
        }

        //string.Join(System.Environment.NewLine, reverse_string);
        string final = string.Join("", entry_value);

        if (final == input)
        {
            Console.WriteLine("This string is a Palindrome!");
        }
        else
        {
            Console.WriteLine($"The reverse of the string is {final}, which is not a Palindrome!");
        }
        
    }
}