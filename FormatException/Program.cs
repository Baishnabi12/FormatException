class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("your age");
        int age;
        string line = Console.ReadLine();
        try
        {
            age = int.Parse(line);
        }
        catch (FormatException)
        {
            Console.WriteLine("{0} is not integer", line);
        }
    }

}

