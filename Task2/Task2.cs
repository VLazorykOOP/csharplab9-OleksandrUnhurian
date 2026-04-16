namespace Tasks {
class Task2
{
    public static void Run()
    {
        string path = "Task2/" + "input.txt";

        Queue<char> nonDigits = new Queue<char>();
        Queue<char> digits = new Queue<char>();

        using (StreamReader reader = new StreamReader(path))
        {
            int ch;
            while ((ch = reader.Read()) != -1)
            {
                char c = (char)ch;

                if (char.IsDigit(c))
                    digits.Enqueue(c);
                else
                    nonDigits.Enqueue(c);
            }
        }

        Console.WriteLine("Result:");

        while (nonDigits.Count > 0)
        {
            Console.Write(nonDigits.Dequeue());
        }

        while (digits.Count > 0)
        {
            Console.Write(digits.Dequeue());
        }
    }
}
}