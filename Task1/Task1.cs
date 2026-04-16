namespace Tasks {
class Task1
{
    public static void Run()
    {
        string inputPath = "Task1/" + "input.txt";
        string outputPath = "Task1/" + "output.txt";

        Stack<int> stack = new Stack<int>();

        string[] parts = File.ReadAllText(inputPath)
            .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var p in parts)
        {
            stack.Push(int.Parse(p));
        }

        // Запис у файл у зворотному порядку
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            while (stack.Count > 0)
            {
                writer.Write(stack.Pop() + " ");
            }
        }

        Console.WriteLine("Data written to output.txt!");
    }
}
}