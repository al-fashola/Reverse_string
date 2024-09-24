namespace Reverse_string;

class Program
{
    static void Main(string[] args)
    {
        List<char> entry_value = new List<char>();
        
        //entry_value.Add('a');
        
        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();
        string reverse_string = "";

        int cnt = input.Length;
        //Console.WriteLine(input[0]);
        //Console.WriteLine($"The total length is {cnt}");

        for (int i = cnt-1; i >=0 ; i--)
        {
            reverse_string += (input[i]);
            //entry_value.Add(input[i]);
            
        }

        string.Join(System.Environment.NewLine, reverse_string);
        string final = string.Join(System.Environment.NewLine, entry_value);
            
        
        Console.WriteLine($"The reverse of the string is {reverse_string}, {final}");
        
        
        


    }
}