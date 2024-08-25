internal class Baitap_string
{
    static void Main(string[] args)
    {
        //Baiso01();
        //Baiso02();
        
    }

    static void Baiso01()
    {string str; 
    Console.Write("\n\nAccept a string from the keyboard:\n");
        Console.Write("Input the string: ");
        str = Console.ReadLine(); 
        Console.Write("The string you entered is: {0}\n", str);
        }

    static void Baiso02()
    {string str; 
    int l = 0; 

    Console.Write("\n\nFind the length of a string:\n");
        Console.Write("Input the string: ");
        str = Console.ReadLine(); 
        foreach (char chr in str)
        {
            l += 1; 
        }
    Console.Write("Length of the string is: {0}\n\n", l);
}
}