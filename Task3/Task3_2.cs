namespace Tasks {
class Task3_2
{
    public static void Run()
    {
        string path = "Task3/" + "input2.txt";

        CharCollection nonDigits = new CharCollection();
        CharCollection digits = new CharCollection();

        using (StreamReader reader = new StreamReader(path))
        {
            int ch;
            while ((ch = reader.Read()) != -1)
            {
                char c = (char)ch;

                if (char.IsDigit(c))
                    digits.Add(c);
                else
                    nonDigits.Add(c);
            }
        }

        foreach (char c in nonDigits)
            Console.Write(c);

        foreach (char c in digits)
            Console.Write(c);
    }
}
}