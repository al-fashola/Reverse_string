namespace Reverse_string;

class Program
{
    static void Main(string[] args)
    {
        List<char> entry_value = new List<char>();
        List<char> reverse_char = new List<char>();
        List<string> reverse_value = new List<string>();
        
        entry_value.Add('a');
        
        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();

        int cnt = input.Length;

        foreach (char c in input)
        {
            entry_value.Add(c);
        }
        Console.WriteLine($"The total length of the string is {cnt}");
        
        //entry_value = input.ToList('');
        
        reverse_char =  entry_value.Reverse();
        reverse_value = reverse_char.ToList();
            
        //Console.WriteLine($"The final string is {entry_value[0]}, and the reversed string is {entry_value[entry_value.Count - 1]}");

        //entry_value.Add(input);



    }
}